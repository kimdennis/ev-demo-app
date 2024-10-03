Public Class BatteryIndicator
    Private _increment As Integer = 0

    Public Property Increment() As Integer
        Get
            Return _increment
        End Get
        Set(ByVal value As Integer)
            _increment = value
        End Set
    End Property
    Private Sub BatteryIndicator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Increment += 10
        If Increment = 10000 Then
            Increment = 0
            ProgressBar1.Value -= 1
            Label1.Text = "Battery" & ProgressBar1.Value & "%"
        End If
        If ProgressBar1.Value = 0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
