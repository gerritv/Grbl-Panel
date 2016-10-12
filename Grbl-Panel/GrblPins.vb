Imports Microsoft.VisualBasic.Strings

Partial Class GrblGui

    ' Module to display Pin: and Lim: messages
    Public Class GrblPins
        Private _gui As GrblGui
        Private _limits As Boolean      ' have we seen a Lim: message?
        Private _pins As Boolean        ' have we seen Pin: message?
        Public Sub New(ByRef gui As GrblGui)
            ' do setup stuff
            _gui = gui
            _gui.grblPort.addRcvDelegate(AddressOf _gui.showGrblPins)
        End Sub
        ''' <summary>
        ''' Make the Pin Status panel visible or not
        ''' </summary>
        ''' <param name="action">True or False</param>
        ''' <returns></returns>
        Private Function enablePinStatus(ByVal action As Boolean) As Boolean
            _gui.gbPinStatus.Visible = action
            If action = False Then
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.showGrblPins)
            End If
            Return True

        End Function
        ''' <summary>
        ''' Tidy shutdown of PinStatus
        ''' </summary>
        Public Sub shutdown()

            enablePinStatus(False)

        End Sub

        Public Property LimitsSeen() As Boolean
            Get
                Return _limits
            End Get
            Set(ByVal value As Boolean)
                _limits = value
                _gui.gbPinStatus.Visible = value
                If value = True Then
                    With _gui
                        .cbLimitX.Visible = True
                        .cbLimitY.Visible = True
                        .cbLimitZ.Visible = True
                    End With
                End If
            End Set
        End Property

        Public Property PinsSeen() As Boolean
            Get
                Return _pins
            End Get
            Set(ByVal value As Boolean)
                _pins = value
                _gui.gbPinStatus.Visible = value
                If value = True Then
                    With _gui
                        .cbLimitX.Visible = True
                        .cbLimitY.Visible = True
                        .cbLimitZ.Visible = True
                        .cbProbePin.Visible = True
                        .cbResetAbort.Visible = True
                        .cbFeedHold.Visible = True
                        .cbStartResume.Visible = True
                    End With
                End If
            End Set
        End Property
    End Class
    ''' <summary>
    ''' Display Pin states, adapt to what Grbl is sending us (Pin: or Lim:)
    ''' </summary>
    ''' <param name="data">Grbl's status message</param>
    Public Sub showGrblPins(ByVal data As String)
        Dim pos As Integer

        If data = vbCrLf Then Return

        ' We are on Grbl 0.9
        If GrblVersion = 0 And data.Contains("Lim:") Then
            ' We need to show Limit pins
            If Not pins.LimitsSeen Then
                pins.LimitsSeen = True
            End If
            pos = InStr(data, "Lim:")
            cbLimitZ.Checked = (data(pos + 3) = "1")
            cbLimitY.Checked = (data(pos + 4) = "1")
            cbLimitX.Checked = (data(pos + 5) = "1")
        End If

        ' Are we on Grbl 1.0 or later?
        If GrblVersion = 1 And data(0) = "<" Then
            If data.Contains("Pn:") Then
                ' Show other pins
                Dim pinlist As String
                If Not pins.PinsSeen Then
                    pins.PinsSeen = True
                End If
                data = data.Remove(data.Length - 3, 3)
                Dim statusMessage = Split(data, "|")
                For Each item As String In statusMessage
                    Dim portion() As String = Split(item, ":")
                    Select Case portion(0)
                        Case "Pn"
                            pinlist = portion(1)
                            cbProbePin.Checked = InStr(pinlist, "P")
                            cbDoorOpen.Checked = InStr(pinlist, "D")
                            cbFeedHold.Checked = InStr(pinlist, "H")
                            cbResetAbort.Checked = InStr(pinlist, "R")
                            cbStartResume.Checked = InStr(pinlist, "S")

                            cbLimitX.Checked = InStr(pinlist, "X")
                            cbLimitY.Checked = InStr(pinlist, "Y")
                            cbLimitZ.Checked = InStr(pinlist, "Z")
                    End Select
                Next
                ' We don't clear, use the provided button. 
                ' This makes the pin occurance latch
            End If
        End If
    End Sub


    Private Sub btnStatusClearPins_Click(sender As Object, e As EventArgs) Handles btnStatusClearPins.Click
        ' Clear pins if set
        cbProbePin.Checked = False
        cbDoorOpen.Checked = False
        cbFeedHold.Checked = False
        cbResetAbort.Checked = False
        cbStartResume.Checked = False

        cbLimitX.Checked = False
        cbLimitY.Checked = False
        cbLimitZ.Checked = False
    End Sub
End Class