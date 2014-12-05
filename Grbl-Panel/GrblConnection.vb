Imports System.IO
Imports System.IO.Ports
Imports System.Collections.Queue
Imports System.Net.Sockets
Imports System.Net
Imports System.Text
'
' Usefule serialport tips, #3 is important!!!!
' http://blogs.msdn.com/b/bclteam/archive/2006/10/10/top-5-serialport-tips-_5b00_kim-hamilton_5d00_.aspx
'
Public Class GrblConnection

    Public Enum ConnectionType
        IP
        Serial
        None
    End Enum

    ' A class to handle serial port list/open/close/read/write

    Private _commports As String()           ' the comm ports available
    Private WithEvents _port As IO.Ports.SerialPort '
    Private _commport As String             ' desired comm port
    Private _baudrate As Integer            ' active baudrate
    Private _connected As Boolean = False
    Private _client As New TcpClient()
    Private _remoteHost As IPAddress           ' desired remote host
    Private _portNum As Integer = 0            ' remote port number
    Private _type As ConnectionType

    Private Delegate Sub _dataReceived()

    ' The inbound queue supports delegates to call when a line of data arrives
    Public Delegate Sub grblDataReceived(ByVal data As String)

    Private _recvDelegates As List(Of grblDataReceived)   ' who should get called when a line arrives

    Public Sub New()
        _port = New IO.Ports.SerialPort()
        _port.ReceivedBytesThreshold = 2            ' wait for this # of bytes to raise event

        _recvDelegates = New List(Of grblDataReceived)

    End Sub

    Public Function Connect(typeIn As ConnectionType) As Boolean
        _type = typeIn

        Select Case _type
            Case ConnectionType.IP
                If _client.Connected Then
                    Return False
                End If

                Try
                    _client = New TcpClient()

                    _client.Connect(_remoteHost, _portNum)

                    Dim d As _dataReceived = AddressOf _client_DataReceived

                    d.BeginInvoke(Nothing, Nothing)

                Catch ex As Exception
                    Return False
                End Try
                ' Reset the board
                '_port.DtrEnable = True
                '_port.DtrEnable = False
                _connected = True
                Return True
            Case ConnectionType.Serial
                If _port.IsOpen Then
                    Return False
                End If
                _port.PortName = _commport
                _port.BaudRate = _baudrate

                Try
                    _port.Open()
                Catch ex As System.IO.IOException
                    Return False
                End Try
                ' Reset the board
                _port.DtrEnable = True
                _port.DtrEnable = False
                _connected = True
                Return True
            Case Else
                Return False ' This should never happen, just in case.
        End Select
    End Function

    Public Sub Disconnect()
        Select Case _type
            Case ConnectionType.IP
                _client.Close()
            Case ConnectionType.Serial
        End Select
        ' disconnect from Grbl
        Try
            If _port.IsOpen Then
                '_port.BaseStream.Close()
                _port.Close()     ' There is a known problem that hangs the program if you are using Invoke in the ReceiveData event (I now use BeforeInvoke)
                ' See http://social.msdn.microsoft.com/Forums/en-US/ce8ce1a3-64ed-4f26-b9ad-e2ff1d3be0a5/serial-port-hangs-whilst-closing?forum=Vsexpressvcs
            End If
        Catch
            ' This happens for sure if user disconnects the USB cable
            MessageBox.Show("Error on close of Grbl port")
        End Try
        _connected = False
        _type = ConnectionType.None
    End Sub

    Public Function rescan() As String()
        ' scan for com ports again
        Return IO.Ports.SerialPort.GetPortNames
    End Function

    ReadOnly Property comports() As String()
        Get
            ' get list of available com ports
            _commports = IO.Ports.SerialPort.GetPortNames()
            Return _commports
        End Get
    End Property

    Property comport() As String
        Get
            Return _commport
        End Get
        Set(value As String)
            _commport = value
        End Set
    End Property

    Property baudrate() As Integer
        Get
            Return _baudrate
        End Get
        Set(value As Integer)
            _baudrate = value
        End Set
    End Property

    Property host() As IPAddress
        Get
            Return _remoteHost
        End Get
        Set(value As IPAddress)
            _remoteHost = value
        End Set
    End Property

    Property portnum() As Integer
        Get
            Return _portNum
        End Get
        Set(value As Integer)
            _portNum = value
        End Set
    End Property

    ReadOnly Property Connected
        ' Are we connected to Grbl?
        Get
            Return _connected
        End Get
    End Property

    ' **** Receive Queue Management
    ' calls delegates (callbacks) to consumers of the data
    ' collects received data line and pushes to queue
    ' pops from queue after last delegate returns

    Public Function addRcvDelegate(param As grblDataReceived) As Boolean
        ' Add a delegate (callback) to the received Data list
        _recvDelegates.Add(param)

        Return True
    End Function

    Public Function deleteRcvDelegate(param As grblDataReceived) As Boolean
        ' Add a delegate (callback) to the received Data list
        _recvDelegates.Remove(param)

        Return True
    End Function

    Private Sub _client_DataReceived() 'sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles _stream.DataReceived
        ' THIS RUNS IN ITS OWN THREAD!!!!! with no direct access to UI elements
        ' By using ReadLine here, we should block this thread until the rest of a line is available, set ReceivedBytesThreshold low (2)
        ' All registered delegates are called, any new receive events get queued up 'in the system'

        Dim data As String

        Dim _stream As NetworkStream = _client.GetStream()
        Dim _reader As New StreamReader(_stream)

        While _connected

            Try

                data = _reader.ReadLine()

                If data.Length <> 0 Then

                    'Dim lines As String() = data.Split({10, 13}, StringSplitOptions.RemoveEmptyEntries)
                    'If lines.Length > 0 Then
                    'For Each line In lines
                    For Each callback In _recvDelegates
                        'Console.WriteLine("recvDelegates:")
                        callback.Invoke(data)
                    Next
                    'Next
                    'End If

                End If

            Catch ex As Exception
                ' various exceptions occur when closing app
                ' all due to race conditions because we process receive events on 
                ' different thread from gui.
                ' This Catch handles data=Nothing from passing to rest of code at exit
                'Disconnect()
                'Return
            End Try

        End While

    End Sub

    Private Sub _port_COM_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles _port.DataReceived
        ' THIS RUNS IN ITS OWN THREAD!!!!! with no direct access to UI elements
        ' By using ReadLine here, we should block this thread until the rest of a line is available, set ReceivedBytesThreshold low (2)
        ' All registered delegates are called, any new receive events get queued up 'in the system'

        Dim data As String
        Try
            data = _port.ReadLine()
        Catch ex As Exception
            ' various exceptions occur when closing app
            ' all due to race conditions because we process receive events on 
            ' different thread from gui.
            ' This Catch handles data=Nothing from passing to rest of code at exit
            Return
        End Try

        'Console.WriteLine("port_DataReceived: " + data)
        For Each callback In _recvDelegates
            'Console.WriteLine("recvDelegates:")
            callback.Invoke(data)
        Next

    End Sub

    Public Function sendData(ByVal data As String) As Boolean

        Select Case _type
            Case ConnectionType.IP
                ' We depend on the caller to not over send the 127 byte limit TODO HOW DO I PREVENT THIS???

                If _connected And _client.Connected Then
                    ' Write data to Grbl
                    ' TODO implement simple and aggressive sending
                    ' Simple is send data, wait for ok before sending next block
                    ' Aggressive is determing how full the Grbl buffer is and sending as much as possible.
                    ' This requires tracking ok's, see Grbl Wiki
                    ' For now we just write
                    If data.Length = 1 Then     ' no CRLF at end, it should be an immediate command such as ! or ~ or ?
                        '_port.Write(data)
                        Dim c As Byte() = ASCIIEncoding.ASCII.GetBytes(data)
                        Try
                            _client.GetStream().Write(c, 0, c.Length)
                        Catch
                            _connected = False
                            ' _port.Close()
                            MessageBox.Show("Fatal error on write to Grbl")
                        End Try

                        'Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                    Else
                        Dim c As Byte() = ASCIIEncoding.ASCII.GetBytes(data + vbLf)
                        Try
                            _client.GetStream().Write(c, 0, c.Length)
                        Catch
                            _connected = False
                            '_port.Close()
                            MessageBox.Show("Fatal error on write to Grbl")
                        End Try
                        'Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                    End If
                    Return True
                Else
                    Return False
                End If

            Case ConnectionType.Serial
                ' We depend on the caller to not over send the 127 byte limit TODO HOW DO I PREVENT THIS???

                If _connected And _port.IsOpen Then
                    ' Write data to Grbl
                    ' TODO implement simple and aggressive sending
                    ' Simple is send data, wait for ok before sending next block
                    ' Aggressive is determing how full the Grbl buffer is and sending as much as possible.
                    ' This requires tracking ok's, see Grbl Wiki
                    ' For now we just write
                    If data.Length = 1 Then     ' no CRLF at end, it should be an immediate command such as ! or ~ or ?
                        '_port.Write(data)
                        Dim c As Byte() = ASCIIEncoding.ASCII.GetBytes(data)
                        Try
                            _port.BaseStream.Write(c, 0, c.Length)
                        Catch
                            _connected = False
                            ' _port.Close()
                            MessageBox.Show("Fatal error on write to Grbl")
                        End Try

                        'Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                    Else
                        Dim c As Byte() = ASCIIEncoding.ASCII.GetBytes(data + vbLf)
                        Try
                            _port.BaseStream.Write(c, 0, c.Length)
                        Catch
                            _connected = False
                            '_port.Close()
                            MessageBox.Show("Fatal error on write to Grbl")
                        End Try
                        'Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                    End If
                    Return True
                Else
                    Return False
                End If
            Case Else
                Return False 'This should not happen if connected, just in case.
        End Select
    End Function

End Class
