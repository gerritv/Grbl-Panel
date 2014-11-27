Imports GrblPanel.GrblConnection
Imports System.Xml
Partial Class GrblGui
    Public Class GrblOffsets

        Private _gui As GrblGui
        Private _wtgForGrbl As Boolean = False
        Private _collecting As Boolean = False
        Private _offsets As New List(Of String)

        Public Sub New(ByRef gui As GrblGui)
            _gui = gui

            AddHandler _gui.Connected, AddressOf GrblConnected
        End Sub

        Public Sub enableOffsets(ByVal action As Boolean)
            _gui.gbStatus.Enabled = action
            If action = True Then
                _gui.grblPort.addRcvDelegate(AddressOf _gui.showGrblOffsets)
            Else
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.showGrblOffsets)
            End If
        End Sub

        Public Sub ClearParams()
            ' empty the list of parameters
            _offsets.Clear()
        End Sub

        Public Sub AddOffset(ByVal data As String)
            ' Add a raw parameter line to the list
            _offsets.Add(data)
        End Sub

        Public Sub SaveOffsets()
            ' Save the Work and TLO offsets to a file of users' choice
            If Not _gui.sfdOffsets.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Return
            End If

            Dim settings As XmlWriterSettings = New Xml.XmlWriterSettings
            settings.Indent = True
            settings.NewLineOnAttributes = True


            Dim writer As XmlWriter = XmlWriter.Create(_gui.sfdOffsets.FileName, settings)
            Dim ctls As Control()

            writer.WriteStartElement("WorkOffsets")
            For Each id As String In {"G54", "G55", "G56", "G57", "G58", "G59"}
                writer.WriteStartElement(id)
                For Each axis As String In {"X", "Y", "Z"}
                    ctls = _gui.tpOffsets.Controls.Find("tbOffsets" + id + axis, True)
                    writer.WriteAttributeString(axis, ctls(0).Text)
                Next
                writer.WriteEndElement()        ' End an offset
            Next
            ' Do TLO as special

            writer.WriteStartElement("G43")
            ctls = _gui.tpOffsets.Controls.Find("tbOffsetsG43Z", True)
            writer.WriteAttributeString("Z", ctls(0).Text)
            writer.WriteEndElement()

            writer.WriteEndElement()            ' End WorkOffsets
            writer.Close()

        End Sub

        Public Sub LoadOffsets()
            ' Load Work and TLO Offsets
            ' This lets the user double click on values for which there is a fixture etc. for quick set up
            If Not _gui.ofdOffsets.ShowDialog() = System.windows.forms.dialogresult.ok Then
                Return
            End If

            Dim reader As Xml.XmlReader = XmlReader.Create(_gui.ofdOffsets.FileName)
            Dim ctls As Control()
            While reader.Read
                Select Case reader.NodeType
                    Case XmlNodeType.Element
                        If reader.HasAttributes Then
                            ' This finds only the nodes we need
                            Dim offsetName As String = reader.Name
                            While reader.MoveToNextAttribute
                                ctls = _gui.tpOffsets.Controls.Find("tbOffsets" + offsetName + reader.Name, True)
                                ctls(0).Text = reader.Value
                            End While
                        End If
                End Select
            End While
        End Sub

        Property OffsetsWtgForGrbl
            ' Used to enable watch for $ parameters
            Get
                Return _wtgForGrbl
            End Get
            Set(value)
                _wtgForGrbl = value
            End Set
        End Property

        Property CollectingOffsets
            ' True is we are collecting params from response stream
            Get
                Return _collecting
            End Get
            Set(value)
                _collecting = value
            End Set
        End Property

        ReadOnly Property Offsets
            Get
                Return _offsets
            End Get
        End Property

        Private Sub GrblConnected()     ' Handles GrblGui.Connected Event
            ' We are now connected so ask for Offset data
            OffsetsWtgForGrbl = True
            gcode.sendGCodeLine("$#")
        End Sub
    End Class


    Private Sub btnOffsetsZero_Click(sender As Object, e As EventArgs) Handles btnOffsetsG43Zero.Click, btnOffsetsG55Zero.Click, btnOffsetsG56Zero.Click, _
                                                                                     btnOffsetsG57Zero.Click, btnOffsetsG58Zero.Click, btnOffsetsG59Zero.Click, _
                                                                                     btnOffsetsG28Set.Click, btnOffsetsG30Set.Click, btnOffsetsG54Zero.Click

        Dim b As Button = sender
        Dim index As String = ""
        Dim tag As String = b.Tag.ToString
        tag = tag.Substring(0, 3)
        ' Set the Offset to zero
        If tag.StartsWith("G5") Then
            Select Case tag
                Case "G54"
                    index = "P1"
                Case "G55"
                    index = "P2"
                Case "G56"
                    index = "P3"
                Case "G57"
                    index = "P4"
                Case "G58"
                    index = "P5"
                Case "G59"
                    index = "P6"
            End Select
            gcode.sendGCodeLine("G10 L2 " + index + " X0 Y0 Z0")
        ElseIf tag.StartsWith("G28") Or tag.StartsWith("G30") Then
            ' set G28 or G30 to current Machine Position
            gcode.sendGCodeLine(tag.Substring(0, 3) + ".1")
        ElseIf tag.StartsWith("G43") Then
            gcode.sendGCodeLine("G43.1 Z0")
        End If

    End Sub

    Private Sub tbOffsets_DoubleClick(sender As Object, e As EventArgs) Handles tbOffsetsG43Z.DoubleClick, tbOffsetsG54X.DoubleClick, tbOffsetsG54Y.DoubleClick, _
                                                                                tbOffsetsG54Z.DoubleClick, tbOffsetsG55X.DoubleClick, tbOffsetsG55Y.DoubleClick, _
                                                                                tbOffsetsG55Z.DoubleClick, tbOffsetsG56X.DoubleClick, tbOffsetsG56Y.DoubleClick, _
                                                                                tbOffsetsG56Z.DoubleClick, tbOffsetsG57X.DoubleClick, tbOffsetsG57Y.DoubleClick, _
                                                                                tbOffsetsG57Z.DoubleClick, tbOffsetsG58X.DoubleClick, tbOffsetsG58Y.DoubleClick, _
                                                                                tbOffsetsG58Z.DoubleClick, tbOffsetsG59X.DoubleClick, tbOffsetsG59Y.DoubleClick, _
                                                                                tbOffsetsG59Z.DoubleClick

        ' Set a specific offset and axis to entered value
        Dim tb As TextBox = sender
        Dim index As String = ""
        Dim tag As String = tb.Tag.ToString
        Dim axis As String = tag(3)
        If tag.Contains("G5") Then
            Select Case tag.Substring(0, 3)  ' Get the offset value
                Case "G54"
                    index = "P1"
                Case "G55"
                    index = "P2"
                Case "G56"
                    index = "P3"
                Case "G57"
                    index = "P4"
                Case "G58"
                    index = "P5"
                Case "G59"
                    index = "P6"
            End Select
            gcode.sendGCodeLine("G10 L2 " + index + " " + axis + tb.Text)
        End If
    End Sub

    Private Sub btnOffsetsRetrieve_Click(sender As Object, e As EventArgs) Handles btnOffsetsRetrieve.Click, btnSettingsRetrieveLocations.Click
        ' Ask Grbl to send us the present offsets
        offsets.OffsetsWtgForGrbl = True
        offsets.ClearParams()
        gcode.sendGCodeLine("$#")
    End Sub

    Public Sub showGrblOffsets(ByVal data As String)
        ' We come here from the recv_data thread so have to do this trick to cross threads
        ' (http://msdn.microsoft.com/en-ca/library/ms171728(v=vs.85).aspx)
        If data.Length < 3 Then
            Return
        End If
        If Me.btnReset.InvokeRequired Then
            ' we need to cross thread this callback
            Dim ncb As New grblDataReceived(AddressOf Me.showGrblOffsets)
            Me.BeginInvoke(ncb, New Object() {data})
            Return
        Else
            ' Extract anything with a [<n> into array
            If offsets.OffsetsWtgForGrbl Then
                If data(0) = "[" And (data(1) = "G" Or data(1) = "T") Then
                    offsets.AddOffset(data)
                    offsets.CollectingOffsets = True
                ElseIf offsets.CollectingOffsets And data(0) <> "[" Then
                    ' we are done collecting parameters, time to display them
                    offsets.OffsetsWtgForGrbl = False
                    offsets.CollectingOffsets = False
                    ShowOffsets()
                End If
            End If
        End If
    End Sub

    Public Sub ShowOffsets()
        ' TODO move into offsets class, needs ref to grblgui object
        ' Populate the Offsets display
        Dim label As String
        Dim axes As String()
        Dim tb As Control()
        For Each line In offsets.Offsets
            line = line.Remove(0, 1)                   ' remove the leading [
            line = line.Remove(line.Length - 3, 3)     ' remove the trailing "] <vbLf>"
            label = line.Substring(0, 3)
            line = line.Remove(0, 4)                   ' finally remove the label:
            axes = line.Split(",")
            Select Case label
                Case "G28", "G30"
                    Dim i As Integer = 0
                    For Each axi In {"X", "Y", "Z"}
                        tb = tabPgSettings.Controls.Find("tbOffsets" + label + axi, True)
                        tb(0).Text = axes(i)
                        i += 1
                    Next
                Case "G54", "G55", "G56", "G57", "G58", "G59"
                    Dim i As Integer = 0
                    For Each axi In {"X", "Y", "Z"}
                        tb = tpOffsets.Controls.Find("tbOffsets" + label + axi, True)
                        tb(0).Text = axes(i)
                        i += 1
                    Next
                Case "TLO"
                    tb = tpOffsets.Controls.Find("tbOffsets" + "G43" + "Z", True)
                    tb(0).Text = axes(0)
            End Select
        Next
    End Sub

    Private Sub btnOffsetsSave_Click(sender As Object, e As EventArgs) Handles btnOffsetsSave.Click
        ' Save Work and TLO offsets
        offsets.SaveOffsets()
    End Sub

    Private Sub btnOffsetsLoad_Click(sender As Object, e As EventArgs) Handles btnOffsetsLoad.Click
        ' Load offsets from user specified file
        offsets.LoadOffsets()
    End Sub
End Class