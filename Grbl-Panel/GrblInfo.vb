Partial Class GrblGui
    ''' <summary>
    ''' A Class to handle Grbl VER and OPT messages
    ''' </summary>
    ''' 

    Public Class GrblInfo
        Private _gui As GrblGui

        Public Sub New(ByRef gui As GrblGui)
            ' Get ref to parent object
            _gui = gui
            ' For Connected events
            AddHandler(GrblGui.Connected), AddressOf Me.GrblConnected

        End Sub
        ''' <summary>
        ''' Activate Info object to request/process VER/OPT messages
        ''' </summary>
        ''' <param name="msg"></param>
        Private Sub GrblConnected(ByVal msg As String)     ' Handles GrblGui.Connected Event
            If msg = "Connected" Then
                _gui.grblPort.addRcvDelegate(AddressOf _gui.processVerOptMessages)
                ' We are connected to Grbl so populate the State
                gcode.sendGCodeLine("$I")
                once = True
            End If
        End Sub

        Private _single As Boolean
        Public Property once() As Boolean
            Get
                Return _single
            End Get
            Set(ByVal value As Boolean)
                _single = value
            End Set
        End Property
        Private _QueueSize As Int16
        Public Property QueueSize() As Int16
            Get
                Return _QueueSize
            End Get
            Set(ByVal value As Int16)
                _QueueSize = value
            End Set
        End Property
        Private _BufferSize As Int16
        Public Property BufferSize() As Int16
            Get
                Return _BufferSize
            End Get
            Set(ByVal value As Int16)
                _BufferSize = value
            End Set
        End Property
    End Class

    ''' <summary>
    ''' Handle incoming VER and OPT message from $I request
    ''' </summary>
    ''' <param name="data"></param>
    Public Sub processVerOptMessages(ByVal data As String)
        If info.once = True Then
            If data.StartsWith("[VER:") Then
                Dim str As String = data.Remove(data.Length - 3)
                tbGrblVersion.Text = str.Remove(0, 5)
            End If
            If data.StartsWith("[OPT") Then
                Dim str As String = data.Remove(data.Length - 3)
                tbGrblOptions.Text = str.Remove(0, 5)

                Dim values() As String
                values = Split(tbGrblOptions.Text, ",")
                info.BufferSize = Convert.ToInt16(values(2))
                info.QueueSize = Convert.ToInt16(values(1))

                info.once = False
            End If
        End If
    End Sub
End Class