using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System;
using System.Collections.Generic;
// 
//  Useful serialport tips, #3 is important!!!!
//  http://blogs.msdn.com/b/bclteam/archive/2006/10/10/top-5-serialport-tips-_5b00_kim-hamilton_5d00_.aspx
// 
public class GrblIF
{

    public enum ConnectionType
    {

        IP,

        Serial,

        None,
    }

    //  A class to handle serial port list/open/close/read/write
    private string[] _commports;

    private SerialPort _port;

    // 
    private string _commport;

    //  desired comm port
    private int _baudrate;

    //  active baudrate
    private bool _connected = false;

    private TcpClient _client = new TcpClient();

    private IPAddress _remoteHost;

    //  desired remote host
    private int _portNum = 0;

    //  remote port number
    private ConnectionType _type;

    public delegate void _dataReceived();

    public delegate void grblDataReceived(string data);

    private List<grblDataReceived> _recvDelegates;

    public GrblIF()
    {
        _port = new SerialPort();
        _port.ReceivedBytesThreshold = 2;
        //  wait for this # of bytes to raise event
        _recvDelegates = new List<grblDataReceived>();
        serialDataEvent. += new System.EventHandler(this.raiseAppSerialDataEvent);
    }

    // '' <summary>
    // '' Starts the connection to grbl, via IP or Serial (COM). Expects to have the needed properties set beforehand.
    // '' </summary>
    // '' <param name="typeIn">Specifies if we're connecting via IP or Serial. None as safety/exception case</param>
    // '' <returns>Returns True if the connection succeeded, false otherwise.</returns>
    public bool Connect(ConnectionType typeIn)
    {
        _type = typeIn;
        switch (_type)
        {
            case ConnectionType.IP:
                if (_client.Connected)
                {
                    return false;
                }

                try
                {
                    _client = new TcpClient();
                    _client.Connect(_remoteHost, _portNum);
                    _dataReceived d = new System.EventHandler(this._client_DataReceived);
                    d.BeginInvoke(null, null);
                }
                catch (Exception ex)
                {
                    return false;
                }

                _connected = true;
                return true;
                break;
            case ConnectionType.Serial:
                if (_port.IsOpen)
                {
                    return false;
                }

                _port.PortName = _commport;
                _port.BaudRate = _baudrate;
                _port.ReadTimeout = 5000;
                try
                {
                    _port.Open();
                }
                catch (System.IO.IOException ex)
                {
                    return false;
                }

                //  Reset the board
                _port.DtrEnable = true;
                _port.DtrEnable = false;
                _connected = true;
                _client_ComReadData();
                //  Start reading
                return true;
                break;
            default:
                return false;
                break;
        }
    }

    // '' <summary>
    // '' Closes the connection.
    // '' </summary>
    public void Disconnect()
    {
        switch (_type)
        {
            case ConnectionType.IP:
                _client.Close();
                break;
            case ConnectionType.Serial:
                //  disconnect from Grbl
                try
                {
                    if (_port.IsOpen)
                    {
                        _port.BaseStream.Close();
                        //  _port.Close()     ' There is a known problem that hangs the program if you are using Invoke in the ReceiveData event (I now use BeforeInvoke)
                        //  See http://social.msdn.microsoft.com/Forums/en-US/ce8ce1a3-64ed-4f26-b9ad-e2ff1d3be0a5/serial-port-hangs-whilst-closing?forum=Vsexpressvcs
                    }

                }
                catch (System.Exception MessageBox.Show) {
                    "Error on close of Grbl port";
                }

                break;
                }
                _connected = false;
                _type = ConnectionType.None;
        }


    public string[] rescan()
    {
        return IO.Ports.SerialPort.GetPortNames;
    }

    // '' <summary>
    // '' Lists the available COM ports on the system.
    // '' </summary>
    // '' <returns>String Array of COM ports</returns>
    string[] comports
    {
        get
        {
            //  get list of available com ports
            _commports = IO.Ports.SerialPort.GetPortNames();
            return _commports;
        }
    }

    string comport
    {
        get
        {
            return _commport;
        }
        set
        {
            _commport = value;
        }
    }

    int baudrate
    {
        get
        {
            return _baudrate;
        }
        set
        {
            _baudrate = value;
        }
    }

    IPAddress ipaddress
    {
        get
        {
            return _remoteHost;
        }
        set
        {
            _remoteHost = value;
        }
    }

    int portnum
    {
        get
        {
            return _portNum;
        }
        set
        {
            if (((value > 65535)
                        || (value < 0)))
            {
                // port number passed in is outside of valid bounds, default to 2000.
                _portNum = 2000;
            }
            else
            {
                _portNum = value;
            }

        }
    }

    bool Connected
    {
    }
}
byte[,] readBuffer;
PrivateAsync;
UnknownEndclass Unknown
{
}


//  **** Receive Queue Management
//  calls delegates (callbacks) to consumers of the data
//  collects received data line and pushes to queue
//  pops from queue after last delegate returns
public bool addRcvDelegate(grblDataReceived param)
{
    //  Add a delegate (callback) to the received Data list
    _recvDelegates.Add(param);
    return true;
}

public bool deleteRcvDelegate(grblDataReceived param)
{
    //  Add a delegate (callback) to the received Data list
    _recvDelegates.Remove(param);
    return true;
}

private void _client_DataReceived()
{
    // sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles _stream.DataReceived
    //  THIS RUNS IN ITS OWN THREAD!!!!! with no direct access to UI elements
    //  By using ReadLine here, we should block this thread until the rest of a line is available, set ReceivedBytesThreshold low (2)
    //  All registered delegates are called, any new receive events get queued up 'in the system'
    string data;
    NetworkStream _stream = _client.GetStream();
    StreamReader _reader = new StreamReader(_stream);
    while (_connected)
    {
        try
        {
            data = _reader.ReadLine();
            if ((data.Length != 0))
            {
                // Dim lines As String() = data.Split({10, 13}, StringSplitOptions.RemoveEmptyEntries)
                // If lines.Length > 0 Then
                // For Each line In lines
                foreach (callback in _recvDelegates)
                {
                    callback.Invoke(data);
                }

                // Next
                // End If
            }

        }
        catch (Exception ex)
        {
            //  various exceptions occur when closing app
            //  all due to race conditions because we process receive events on 
            //  different thread from gui.
            //  This Catch handles data=Nothing from passing to rest of code at exit
            // Disconnect()
            // Return
        }

    }

}

void _client_ComReadData()
{
    try
    {
        int _actualLength = Await;
        _port.BaseStream.ReadAsync(readBuffer, 0, 200);
        byte[,] _received;
        Buffer.BlockCopy(readBuffer, 0, _received, 0, _actualLength);
        // Console.WriteLine("_client_ComReadData: Finished async read, bytes {0}", _actualLength)
        // raiseAppSerialDataEvent(System.Text.ASCIIEncoding.ASCII.GetString(_received))
        serialDataEvent(System.Text.ASCIIEncoding.ASCII.GetString(_received));
        _client_ComReadData();
        //  reprime the read
    }
    catch (System.InvalidOperationException e)
    {
    }
    catch (System.IO.IOException e)
    {
        Debug.WriteLine(("_client_ComReadData: error on reading from port " + e.Message));
    }
    catch (TimeoutException e)
    {
        Debug.WriteLine("_client_ComReadData: Timeout exception {0}", e.Message);
    }

}

public event EventHandler serialDataEvent;

private string data;

// '' <summary>
// '' Handles the application serial data event.
// '' </summary>
// '' <remarks>
// '' Processes the received data into lines
// '' For each line, calls the registered delegates
// '' </remarks>
// '' <param name="data">The (possibly partial) data.</param>
private void raiseAppSerialDataEvent(string data)
{
    ((void)(line));
    new StringBuilder();
    foreach (char ch in data)
    {
        if ((ch != vbNullChar))
        {
            //  ignore the Null at end of received data
            if ((ch == "\n"))
            {
                line.Append(ch);
                // Send for processing
                //  Console.WriteLine("raiseAppSerialDataEvent: {0} ", line)
                foreach (callback in _recvDelegates)
                {
                    // Console.WriteLine("recvDelegates: calling " + callback.Method.Name)
                    callback.Invoke(line.ToString);
                }

                //  Get ready for next portion
                line.Clear();
            }
            else
            {
                line.Append(ch);
            }

        }

    }

}

// '' <summary>
// '' Sends a byte of data to grbl
// '' </summary>
// '' <param name="data">The data to send to grbl</param>
// '' <returns>True if send was successful, false otherwise</returns>
public bool sendData(string data)
{
    switch (_type)
    {
        case ConnectionType.IP:
            //  We depend on the caller to not over send the 127 byte limit TODO HOW DO I PREVENT THIS???
            if ((_connected && _client.Connected))
            {
                //  Write data to Grbl
                //  Simple is send data, wait for ok before sending next block
                //  Aggressive is determing how full the Grbl buffer is and sending as much as possible.
                //  This requires tracking ok's, see Grbl Wiki
                //  For now we just write
                if ((data.Length == 1))
                {
                    //  no CRLF at end, it should be an immediate command such as ! or ~ or ?
                    // _port.Write(data)
                    byte[] c = System.Text.Encoding.GetEncoding(1252).GetBytes(data);
                    try
                    {
                        _client.GetStream().Write(c, 0, c.Length);
                    }
                    catch (System.Exception _connected)
                    {
                        false;
                        MessageBox.Show("Fatal error on write to Grbl");
                    }

                    // Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                }
                else
                {
                    //  Note that this encoding allows only 7 bit Ascii characters!
                    byte[] c = ASCIIEncoding.ASCII.GetBytes((data + "\n"));
                    try
                    {
                        _client.GetStream().Write(c, 0, c.Length);
                    }
                    catch (System.Exception _connected)
                    {
                        false;
                        MessageBox.Show("Fatal error on write to Grbl");
                    }

                    // Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                }

                return true;
            }
            else
            {
                return false;
            }

            break;
        case ConnectionType.Serial:
            //  We depend on the caller to not over send the 127 byte limit TODO HOW DO I PREVENT THIS???
            if ((_connected && _port.IsOpen))
            {
                //  Write data to Grbl
                //  Simple is send data, wait for ok before sending next block
                //  Aggressive is determing how full the Grbl buffer is and sending as much as possible.
                //  This requires tracking ok's, see Grbl Wiki
                //  For now we just write
                if ((data.Length == 1))
                {
                    //  no CRLF at end, it should be an immediate command such as ! or ~ or ?
                    byte[] c = System.Text.Encoding.GetEncoding(1252).GetBytes(data);
                    try
                    {
                        _port.BaseStream.Write(c, 0, c.Length);
                    }
                    catch (Exception e)
                    {
                        _connected = false;
                        MessageBox.Show(("Fatal error on write to Grbl, " + e.Message));
                    }

                    //  Console.WriteLine("GrblIF:char:sendData Sent: " + data + " to Grbl")
                }
                else
                {
                    //  Note that this encoding allows only 7 bit Ascii characters!
                    byte[] c = ASCIIEncoding.ASCII.GetBytes((data + "\n"));
                    try
                    {
                        _port.BaseStream.Write(c, 0, c.Length);
                    }
                    catch (Exception e)
                    {
                        _connected = false;
                        MessageBox.Show(("Fatal error on write to Grbl, " + e.Message));
                    }

                    //  Console.WriteLine(String.Format("Sent as byte: {0:X} {1:X}", c(0), c(1)))
                    //  Console.WriteLine("GrblIF:line:sendData Sent: " + data + " to Grbl")
                }

                return true;
            }
            else
            {
                return false;
            }

            break;
        default:
            return false;
            break;
    }
}