
Imports System.Threading.Thread
Imports GrblPanel.GrblIF
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
            If Not _gui.ofdOffsets.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
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

        Property OffsetsWtgForGrbl As Boolean
            ' Used to enable watch for $ parameters
            Get
                Return _wtgForGrbl
            End Get
            Set(value As Boolean)
                _wtgForGrbl = value
            End Set
        End Property

        Property CollectingOffsets As Boolean
            ' True is we are collecting params from response stream
            Get
                Return _collecting
            End Get
            Set(value As Boolean)
                _collecting = value
            End Set
        End Property

        ReadOnly Property Offsets As List(Of String)
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


    Private Sub btnOffsetsZero_Click(sender As Object, e As EventArgs) Handles btnOffsetsG43Zero.Click, btnOffsetsG55Zero.Click, btnOffsetsG56Zero.Click,
                                                                                     btnOffsetsG57Zero.Click, btnOffsetsG58Zero.Click, btnOffsetsG59Zero.Click,
                                                                                     btnOffsetsG28Set.Click, btnOffsetsG30Set.Click, btnOffsetsG54Zero.Click

        Dim btn As Button = sender
        Dim index As String = ""
        Dim tag As String = DirectCast(btn.Tag, String)
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

        ' Get new values
        btnOffsetsRetrieve_Click(Nothing, Nothing)
    End Sub

    Private Sub tbOffsets_DoubleClick(sender As Object, e As EventArgs) Handles tbOffsetsG43Z.DoubleClick, tbOffsetsG54X.DoubleClick, tbOffsetsG54Y.DoubleClick,
                                                                                tbOffsetsG54Z.DoubleClick, tbOffsetsG55X.DoubleClick, tbOffsetsG55Y.DoubleClick,
                                                                                tbOffsetsG55Z.DoubleClick, tbOffsetsG56X.DoubleClick, tbOffsetsG56Y.DoubleClick,
                                                                                tbOffsetsG56Z.DoubleClick, tbOffsetsG57X.DoubleClick, tbOffsetsG57Y.DoubleClick,
                                                                                tbOffsetsG57Z.DoubleClick, tbOffsetsG58X.DoubleClick, tbOffsetsG58Y.DoubleClick,
                                                                                tbOffsetsG58Z.DoubleClick, tbOffsetsG59X.DoubleClick, tbOffsetsG59Y.DoubleClick,
                                                                                tbOffsetsG59Z.DoubleClick

        ' Set a specific offset and axis to entered value
        Dim tb As TextBox = sender
        Dim index As String = ""
        Dim tag As String = DirectCast(tb.Tag, String)
        SendOffsets(tag, tb.Text)

    End Sub

    ''' <summary>
    ''' Send Offset info to Grbl
    ''' </summary>
    ''' <param name="tag"></param>
    ''' <param name="value"></param>
    Public Sub SendOffsets(tag As String, value As String)
        ' also called from GrblGui ProcessKeyCommand for Enter key processing
        Dim index As String = ""
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
            gcode.sendGCodeLine("G10 L2 " + index + " " + axis + value)
            Sleep(400)              ' Have to wait for EEProm write
            btnOffsetsRetrieve_Click(Nothing, Nothing)
        End If
        If tag.Contains("G43") Then
            gcode.sendGCodeLine("G43.1" + axis + value)
            Sleep(400)              ' Have to wait for EEProm write
            btnOffsetsRetrieve_Click(Nothing, Nothing)
        End If

    End Sub
    ''' <summary>
    ''' Set an offset to current machine coordinates
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnSetOffset_Click(sender As Object, e As EventArgs) Handles btnSetOffsetG54.Click, btnSetOffsetG55.Click, btnSetOffsetG56.Click,
                                                                             btnSetOffsetG57.Click, btnSetOffsetG58.Click, btnSetOffsetG59.Click
        Dim btn As Button = sender
        Dim index As String = ""
        Dim tag As String = DirectCast(btn.Tag, String)
        Dim XValue As String = tbOffSetsMachX.Text.ToString
        Dim YValue As String = tbOffSetsMachY.Text.ToString
        Dim ZValue As String = tbOffSetsMachZ.Text.ToString

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
        gcode.sendGCodeLine("G10 L2 " + index + " " + "X" + XValue + "Y" + YValue + "Z" + ZValue)
        ' Get new values
        btnOffsetsRetrieve_Click(Nothing, Nothing)

    End Sub

    Private Sub btnOffsetsRetrieve_Click(sender As Object, e As EventArgs) Handles btnOffsetsRetrieve.Click, btnSettingsRetrieveLocations.Click
        ' Ask Grbl to send us the present offsets
        offsets.OffsetsWtgForGrbl = True
        offsets.ClearParams()
        gcode.sendGCodeLine("$#")
    End Sub

    Public Sub showGrblOffsets(ByVal data As String)

        If data.Length < 3 Then
            Return
        End If
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