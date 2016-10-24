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

        If data(0) = vbLf Or data(0) = vbCr Then
            Return                  ' nothing to do
        End If

        ' Show X, Y, Z limit pin state
        If Not pins.LimitsSeen Then
            If data.Contains("Lim:") Or data.Contains("Pin:") Then
                pins.LimitsSeen = True
            End If
        End If

        If Not pins.PinsSeen Then
            If data.Contains("Pin:") Then
                pins.PinsSeen = True
            End If
        End If

        If data.Contains("Lim:") Or data.Contains("Pin:") Then
            ' We need to show Limit pins
            pos = InStr(data, "Lim:") + InStr(data, "Pin:")
            cbLimitZ.Checked = (data(pos + 3) = "1")
            cbLimitY.Checked = (data(pos + 4) = "1")
            cbLimitX.Checked = (data(pos + 5) = "1")
        End If

        ' pos 6 and 8 are delimiters "|"
        If data.Contains("Pin:") Then
            ' Show other pins
            cbProbePin.Checked = (data(pos + 7) = "0")
            cbStartResume.Checked = (data(pos + 9) = "1")
            cbFeedHold.Checked = (data(pos + 10) = "1")
            cbResetAbort.Checked = (data(pos + 11) = "1")
        End If
    End Sub
End Class