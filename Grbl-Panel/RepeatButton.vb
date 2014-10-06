Public Class RepeatButton
    Inherits System.Windows.Forms.Button

    Public Sub New()
        AddHandler timer.Tick, AddressOf OnTimer
        timer.Enabled = False
    End Sub

    Public Timer As New timer
    Public Property Interval() As Integer
        Get
            Return timer.Interval
        End Get

        Set(ByVal Value As Integer)
            timer.Interval = Value
        End Set
    End Property

    Private Sub OnTimer(ByVal sender As Object, ByVal e As EventArgs)
        'fire off a click on each timer tick 
        OnClick(EventArgs.Empty)
    End Sub

    Private Sub RepeatButton_MouseDown(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'turn on the timer 
        timer.Enabled = True
    End Sub

    Private Sub RepeatButton_MouseUp(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        ' turn off the timer 
        timer.Enabled = False
    End Sub

End Class
