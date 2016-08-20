Imports System.Threading
Imports System.TimeSpan
Imports System.Threading.Thread

Partial Class GrblGui

    Public Class Elapsed

        Private _stopwatch As Stopwatch
        Private _timer As Timer
        Private _span As TimeSpan

        ' Private _target As Object = Nothing

        Public Sub New(target As Object)
            _stopwatch = New Stopwatch()
            _timer = New Timer(AddressOf _timerCB, target, 0, 1000)
            ' _target = target
        End Sub

        Public Sub BeginTimer()
            _stopwatch.Reset()
            _stopwatch.Start()
        End Sub

        Public Sub StopTimer()
            _stopwatch.Stop()
        End Sub

        Public Sub ResumeTimer()
            _stopwatch.Start()
        End Sub

        Public Sub ResetTimer()
            _stopwatch.Reset()
        End Sub

        Delegate Sub MySub(data As Object)

        Private Sub _timerCB(state As Object)
            Dim c As Control = DirectCast(state, System.Windows.Forms.Control)
            If c.InvokeRequired Then
                ' we need to cross thread this callback
                Dim ncb As New MySub(AddressOf Me._timerCB)
                c.Parent.BeginInvoke(ncb, New Object() {state})
                Return
            Else
                If Not IsNothing(state) And _stopwatch.IsRunning Then
                    _span = FromMilliseconds(_stopwatch.ElapsedMilliseconds)
                    state.Text = _span.ToString("hh\:mm\:ss")
                End If
            End If
        End Sub
        Public ReadOnly Property ElapsedMillis() As String
            Get
                Return _stopwatch.ElapsedMilliseconds
            End Get
        End Property
    End Class
End Class
