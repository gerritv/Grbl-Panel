Partial Class GrblGui
    Public Class GrblGcodeView
        ' A class to manage the Gcode list view
        ' This contains the GCode queue going to Grbl
        ' GrblGui owns the dgvGcode control but this class manages its content

        Private _dgview As DataGridView
        Private _gcodeTable As List(Of gcodeItem)
        Private _filemode As Boolean = False ' True if in File Send mode
        Private _source As BindingSource = New BindingSource()

        Public Class gcodeItem   '(Type)
            Private _gcode As String
            ' Information about the gcode line
            Private _file As Boolean = False   ' Is line from file or MDI?
            Private _lineNum As Int64
            Private _status As String
            Private _sent As Boolean = False    ' Was the line sent?
            Private _acked As Boolean = False    ' Was the line Ack'd?
            Private _M0 As Boolean = False    ' Does this line contain M0 Pause?
            Private _M6 As Boolean = False     ' Does this line contain M06 Tool Change?
#Region "gcodeItem Properties"
            Public Property status As String
                Get
                    Return _status
                End Get
                Set(value As String)
                    _status = value
                End Set
            End Property
            Public Property lineNum As Int64
                Get
                    Return _lineNum
                End Get
                Set(value As Int64)
                    _lineNum = value
                End Set
            End Property
            Public Property gcode As String
                Get
                    Return _gcode
                End Get
                Set(value As String)
                    _gcode = value
                End Set
            End Property
            Public Property file As Boolean
                Get
                    Return _file
                End Get
                Set(value As Boolean)
                    _file = value
                End Set
            End Property
            Public Property sent As Boolean
                Get
                    Return _sent
                End Get
                Set(value As Boolean)
                    _sent = value
                End Set
            End Property
            Public Property acked As Boolean
                Get
                    Return _acked
                End Get
                Set(value As Boolean)
                    _acked = value
                End Set
            End Property
#End Region
        End Class

        Public Sub New(ByRef view As DataGridView)

            _gcodeTable = New List(Of GrblGcodeView.gcodeItem)
            _source.DataSource = _gcodeTable
            _dgview = view
            _dgview.DataSource = _source

            With _dgview
                .DefaultCellStyle.Font = New Font("microsoft san serif", 10)
                .RowTemplate.Height = 17
                .Columns("file").Visible = False
                .Columns("Status").Width = 46
                .Columns("Status").HeaderText = "Sts"
                .Columns("lineNum").Width = 46
                .Columns("lineNum").HeaderText = "Line"
                .Columns("gcode").Width = 459
                .Columns("gcode").HeaderText = "Gcode"
                .Columns("sent").Visible = False
                .Columns("acked").Visible = False
            End With
        End Sub

        Public Sub Clear()
            '_lview.Items.Clear()
            '_filemode = False
            '_lview.Update()
            ' Clear the gcode queue
            ' Plan B
            _gcodeTable.Clear()
            _filemode = False  ' need to move this to Gcode obj
            _dgview.Update()
        End Sub


        Public Sub Insert(ByVal data As String, ByVal source As String, ByVal lineNumber As String)
            ' Inserts gcode line into the dt
            ' Scans for interesting blocks such as M0, M6
            'Dim gcodes() As String
            Dim newGcode As New gcodeItem
            newGcode.gcode = data
            newGcode.lineNum = lineNumber
            Select Case source
                Case "File"
                    newGcode.file = True
                    _gcodeTable.Add(newGcode)
                    ' The loader is responsible for calling RefreshView at end of load
                Case "MDI"
                    newGcode.file = False
                    _gcodeTable.Add(newGcode)
                    RefreshView()  ' keep the view updated
            End Select
            ' TODO Add special cases
            'gcodes = ParseGcode(data)
            'If gcodes.Contains("M0") Then
            '    info.M0 = True
            'End If
            'If gcodes.Contains("M6") Then
            '    info.M6 = True
            'End If
            '_gcodeTable.Rows.InsertAt(newR, InsertPtr)       ' This is what we need for editing
        End Sub

        Public Function readGcode(ByVal lineCount As Int64, ByVal linesDone As Int64) As String
            ' Read a line, if EOF then return EOF
            If lineCount > 0 Then
                Return _dgview.Rows(linesDone).Cells(2).Value
            Else
                Return "EOF"
            End If
        End Function
        ''' <summary>
        ''' Peek at line previously sent
        ''' </summary>
        ''' <returns>Previous Gcode line</returns>
        Public Function readGcodePrevious(ByVal lineCount As Int64, ByVal linesDone As Int64) As String
            ' Read a line, if EOF then return EOF
            If lineCount >= 0 Then
                Return _dgview.Rows(linesDone - 1).Cells(2).Value
            Else
                Return "EOF"
            End If
        End Function

        Public Sub UpdateGCodeStatus(ByVal stat As String, ByVal index As Integer)
            ' Set the Status column of the line item
            ' Keep current active line visible in the view

            Dim a As Integer = 0

            Dim b As Integer = 0
            With _dgview
                a = .FirstDisplayedScrollingRowIndex
                b = .DisplayedRowCount(True)
            End With
            Console.WriteLine("a,b, index{0} {1} {2})", a, b, index)


            If _filemode Then
                _gcodeTable(index).status = stat
                If index < _dgview.FirstDisplayedScrollingRowIndex Then
                    ' Make top of queue visible again
                    _dgview.FirstDisplayedScrollingRowIndex = 0
                Else
                    If (_dgview.FirstDisplayedScrollingRowIndex + _dgview.DisplayedRowCount(True) <= index) Then
                        _dgview.FirstDisplayedScrollingRowIndex = index - _dgview.DisplayedRowCount(True) + 5
                    End If
                End If
            Else            ' we always pick the last entry
                _gcodeTable(_gcodeTable.Count - 1).status = stat
                ' we are in MDI mode so use bottom
                index = _dgview.RowCount
                If index < _dgview.FirstDisplayedScrollingRowIndex Then
                    ' Make top of queue visible again
                    _dgview.FirstDisplayedScrollingRowIndex = 0
                Else
                    If (_dgview.FirstDisplayedScrollingRowIndex + _dgview.DisplayedRowCount(True) <= index) Then
                        _dgview.FirstDisplayedScrollingRowIndex = index - _dgview.DisplayedRowCount(True) + 1
                    End If
                End If
            End If


            _dgview.Refresh()
        End Sub

        Public Sub UpdateGcodeSent(ByVal index As Integer)
            '  Set background to indicate the gcode line was sent
            If _filemode Then       ' Are we running a file
                _dgview.Rows(index).DefaultCellStyle.BackColor = Color.LightBlue
            Else
                If _gcodeTable.Count = 1 Then
                    ' index = 0
                End If
                '_dgview.Rows(_gcodeTable.Count + index).DefaultCellStyle.BackColor = Color.LightBlue
                _dgview.Rows(_gcodeTable.Count + index).DefaultCellStyle.BackColor = Color.LightBlue
            End If

            '_dgview.Update()

        End Sub
        ''' <summary>
        ''' Refreshes the view. Use after adding or clearing datasource, e.g. file read or MDI input
        ''' </summary>
        Public Sub RefreshView()
            _source.ResetBindings(False)

        End Sub
        ''' <summary>
        ''' Rewind the Gcode view (for M30)
        ''' </summary>
        Public Sub Rewind()
            ' clear status and colouring, leave commands
            For Each row As DataGridViewRow In _dgview.Rows
                row.DefaultCellStyle.BackColor = Color.Empty
                row.Cells("status").Value = ""
            Next
            _dgview.FirstDisplayedScrollingRowIndex = 0 ' show top of file for user to verify etc
        End Sub

        ReadOnly Property count As Integer
            Get
                Return GrblGui.dgvGcode.Rows.Count
            End Get
        End Property
        Property fileMode As Boolean
            ' Set true if we are running a gcode file
            Get
                Return _filemode
            End Get
            Set(value As Boolean)
                _filemode = value
            End Set
        End Property

    End Class
End Class
