' Imported from
' http://www.codeproject.com/Articles/5289/A-Simple-Auto-Repeat-Button-on-VB-NET
' Thank you Daniel
' 

Imports System.Windows.Forms


Public Class RepeatButton
    Inherits System.Windows.Forms.Button

    Public Sub New()
        AddHandler myTimer.Tick, AddressOf OnTimer
        myTimer.Enabled = False
    End Sub

    Public myTimer As New Timer
    Public Property Interval() As Integer
        Get
            Return myTimer.Interval
        End Get

        Set(ByVal Value As Integer)
            myTimer.Interval = Value
        End Set
    End Property

    Private Sub OnTimer(ByVal sender As Object, ByVal e As EventArgs)
        'fire off a click on each timer tick
        OnClick(EventArgs.Empty)
    End Sub

    Private Sub RepeatButton_MouseDown(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'turn on the timer 
        myTimer.Enabled = True
    End Sub

    Private Sub RepeatButton_MouseUp(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        ' turn off the timer 
        myTimer.Enabled = False
    End Sub

End Class

