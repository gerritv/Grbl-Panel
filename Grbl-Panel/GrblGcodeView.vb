Imports System.Reflection

Partial Class GrblGui
    Public Class GrblGcodeView
        ' A class to manage the Gcode list view
        ' This contains the GCode queue going to Grbl
        ' GrblGui owns the dgvGcode control but this class manages its content

        Private _dgview As DataGridView
        Private _gcodeTable As List(Of gcodeItem)
        Private _filemode As Boolean = False ' True if in File Send mode
        Private _source As BindingSource = New BindingSource()

        Private _errors As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
        {"0", "ok"},
        {"1", "Expected command letter "},
        {"2", "Bad number format "},
        {"3", "Invalid statement "},
        {"4", "Value < 0 "},
        {"5", "Setting disabled "},
        {"6", "Value < 3 usec "},
        {"7", "EEPROM read fail, using Defaults "},
        {"8", "Not idle "},
        {"9", "Alarm lock "},
        {"10", "Homing is not enabled "},
        {"11", "Line overflow "},
        {"12", "Step rate > 30kHz "},
        {"13", "Check door "},
        {"20", "Unsupported command "},
        {"21", "Modal group violation "},
        {"22", "Undefined feed rate "},
        {"23", "Command value is not integer "},
        {"24", "Axis command conflict "},
        {"25", "Word repeated "},
        {"26", "No axis words "},
        {"27", "Invalid line number "},
        {"28", "Value word missing "},
        {"29", "Unsupported coordinate system "},
        {"30", "G53 invalid motion mode "},
        {"31", "Axis words exist "},
        {"32", "No axis words in plane "},
        {"33", "Invalid target "},
        {"34", "Arc radius error "},
        {"35", "No offsets in plane "},
        {"36", "Unused words "},
        {"37", "G43 dynamic axis error "}
        }
        Public Class gcodeItem   '(Type)
            Private _gcode As String
            ' Information about the gcode line
            Private _file As Boolean = False   ' Is line from file or MDI?
            Private _lineNum As Integer
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
            Public Property lineNum As Integer
                Get
                    Return _lineNum
                End Get
                Set(value As Integer)
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
            '_source.DataSource = _gcodeTable
            '_dgview.DataSource = _source
            _dgview = view

            With _dgview
                ' http://stackoverflow.com/questions/4255148/how-to-improve-painting-performance-of-datagridview
                DoubleBuffered(_dgview, True)       ' Improve performance of refresh!
                .DefaultCellStyle.Font = New Font("microsoft san serif", 10)
                .RowTemplate.Height = 17
                .RowCount = 17      ' For Virtual mode
                '.Columns("file").Visible = False
                .Columns("stat").Width = 46
                .Columns("stat").HeaderText = "Sts"
                .Columns("lineNum").Width = 46
                .Columns("lineNum").HeaderText = "Line"
                .Columns("data").Width = 459
                .Columns("data").HeaderText = "Gcode"
                '.Columns("sent").Visible = False
                '.Columns("acked").Visible = False
            End With
        End Sub
        ''' <summary>
        ''' Set DataGridView to double buffered. Noticeably implroves refresh performance
        ''' </summary>
        ''' <param name="dgv">The DataGridView.</param>
        ''' <param name="setting">if set to <c>true</c> [setting].</param>
        Private Sub DoubleBuffered(ByRef dgv As DataGridView, setting As Boolean)
            Dim dgvtype As Type = dgv.GetType
            Dim pi As PropertyInfo = dgvtype.GetProperty("DoubleBuffered", BindingFlags.Instance + BindingFlags.NonPublic)
            pi.SetValue(dgv, setting)
        End Sub

        ''' <summary>
        ''' Clears the gcode list/queue.
        ''' </summary>
        Public Sub Clear()
            _gcodeTable.Clear()
            _filemode = False  ' need to move this to Gcode obj
            _dgview.RowCount = 0
            _dgview.Refresh()
        End Sub
        ''' <summary>
        ''' Inserts a gcode line into the list/queuea.
        ''' </summary>
        ''' <param name="data">The data.</param>
        ''' <param name="source">The source. "File" or "MDI"</param>
        ''' <param name="lineNumber">The line number. Line in file or 0 for MDI</param>
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
                    RefreshView(_gcodeTable.Count)  ' keep the view updated
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
        ''' <summary>
        ''' Gets a gcode line.
        ''' </summary>
        ''' <param name="lineCount">The line count.</param>
        ''' <param name="linesDone">The lines done.</param>
        ''' <returns></returns>
        Public Function readGcode(ByVal lineCount As Integer, ByVal linesDone As Integer) As String
            ' Read a line, if EOF then return EOF
            If lineCount > 0 Then
                Return _gcodeTable(linesDone).gcode
            Else
                Return "EOF"
            End If
        End Function

        ''' <summary>
        ''' Gets a gcode item.
        ''' </summary>
        ''' <param name="index">The index.</param>
        ''' <returns></returns>
        Public Function GetGcodeItem(ByVal index As Integer) As gcodeItem
            If _gcodeTable.Count > 0 Then
                Return _gcodeTable(index)
            Else Return Nothing
            End If
        End Function

        ''' <summary>
        ''' Peek at line previously sent
        ''' </summary>
        ''' <returns>Previous Gcode line</returns>
        Public Function readGcodePrevious(ByVal lineCount As Integer, ByVal linesDone As Integer) As String
            ' Read a line, if EOF then return EOF
            If lineCount >= 0 Then
                Return _gcodeTable(linesDone - 1).gcode
            Else
                Return "EOF"
            End If
        End Function
        ''' <summary>
        ''' Updates the gcode line display status.
        ''' </summary>
        ''' <param name="stat">The status, e.g. "ok", "error", "sent".</param>
        ''' <param name="index">The index.</param>
        Public Sub UpdateGCodeStatus(ByVal stat As String, ByVal index As Integer)
            ' Set the Status column of the line item
            ' Keep current active line visible in the view
            Dim errorCode As Integer

            ' locals to boost performance, these methods have an apparent performance impact
            Dim firstDisplayed As Integer = _dgview.FirstDisplayedScrollingRowIndex
            Dim displayCount As Integer = _dgview.DisplayedRowCount(False)
            ' expansion of error:<number> for GUI Mode
            If (stat.StartsWith("error:")) Then
                ' We are in GUI mode so expand the message
                errorCode = Convert.ToInt16(stat.Substring(6, stat.Length - 6 - 2))
                stat = stat + ": " + _errors(errorCode)
            End If
            If _filemode Then
                _gcodeTable(index).status = stat
                '_dgview.Rows(index).Cells(0).Value = stat
                If index < firstDisplayed Then
                    ' Make top of queue visible again
                    _dgview.FirstDisplayedScrollingRowIndex = 0
                Else
                    If (firstDisplayed + displayCount <= index) Then
                        _dgview.FirstDisplayedScrollingRowIndex = index - displayCount ' + 5
                    End If
                End If
            Else            ' MDI mode: we always pick the last entry
                _gcodeTable(_gcodeTable.Count - 1).status = stat
                '_dgview.Rows(_gcodeTable.Count - 1).Cells(0).Value = stat
                ' we are in MDI mode so use bottom
                index = _dgview.RowCount - 1
                If index < firstDisplayed Then
                    ' Make top of queue visible again
                    _dgview.FirstDisplayedScrollingRowIndex = 0
                Else
                    If (firstDisplayed + displayCount <= index) And index <> 0 Then
                        _dgview.FirstDisplayedScrollingRowIndex = index - displayCount + 2
                    End If
                End If
            End If

            ' make display look responsive when doing first 16 lines
            If firstDisplayed <= displayCount Then
                'Console.WriteLine("UpdateGCodeStatus: FirstIndex, DisplayRowCount, index {0} {1} {2}", firstDisplayed, displayCount, index)
                _dgview.Refresh()
            End If

        End Sub

        ''' <summary>
        ''' Mark gcode line as sent.
        ''' </summary>
        ''' <param name="index">The index.</param>
        Public Sub UpdateGcodeSent(ByVal index As Integer)
            '  Set background to indicate the gcode line was sent
            If _filemode Then       ' Are we running a file
                '_dgview.Rows(index).DefaultCellStyle.BackColor = Color.LightBlue ' gives a noticeable performance hit
                _gcodeTable(index).status = "Sent"
            Else
                'If _gcodeTable.Count = 1 Then
                '    index = -1
                'End If
                _gcodeTable(_gcodeTable.Count + index).status = "Sent"
                _dgview.Refresh()
                '_dgview.Rows(_gcodeTable.Count + index).DefaultCellStyle.BackColor = Color.LightBlue
            End If

        End Sub
        ''' <summary>
        ''' Refreshes the view. Use after adding or clearing datasource, e.g. file read or MDI input
        ''' </summary>
        Public Sub RefreshView(ByVal lineCount As Integer)
            _dgview.RowCount = lineCount
            _dgview.Refresh()

        End Sub
        ''' <summary>
        ''' Rewind the Gcode view (for M30)
        ''' </summary>
        Public Sub Rewind()
            ' clear status, leave commands
            For Each item As gcodeItem In _gcodeTable
                item.status = Nothing
            Next
            _dgview.FirstDisplayedScrollingRowIndex = 0 ' show top of file for user to verify etc
            _dgview.Refresh()
        End Sub

        ''' <summary>
        ''' Displays the top row.
        ''' </summary>
        Public Sub DisplayTop()
            _dgview.FirstDisplayedScrollingRowIndex = 0
        End Sub

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
    ''' <summary>
    ''' Handles the CellValueNeeded event of the dgvGcode control. Used
    ''' by Virtual Mode=true
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellValueEventArgs"/> instance containing the event data.</param>
    Private Sub dgvGcode_CellValueNeeded(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs) Handles dgvGcode.CellValueNeeded
        ' Get a set of cell values from our gcode table to paint in the grid view
        Dim item As GrblGcodeView.gcodeItem
        ' If this is the row for new records, no values are needed.
        'If e.RowIndex = dgvGcode.RowCount - 1 Then
        '    Return
        'End If
        If cbMonitorEnable.Checked Then     ' Issue #60 Don't update gcode view
            If IsNothing(gcodeview) Then
                ' Happens during start up and a column is auto-resizeable based on content
                Return
            Else
                item = gcodeview.GetGcodeItem(e.RowIndex)
                If IsNothing(item) Then
                    Return
                End If
            End If

            Select Case dgvGcode.Columns(e.ColumnIndex).Name
                Case "stat"
                    e.Value = item.status
                Case "lineNum"
                    e.Value = item.lineNum
                Case "data"
                    e.Value = item.gcode
            End Select
        End If
    End Sub
End Class
