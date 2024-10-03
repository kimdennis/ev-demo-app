Public Class homeRider
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.CenterToScreen()
        Me.Cursor = New Cursor(My.Resources.cursor.Handle)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CarControlsBtn_Click(sender As Object, e As EventArgs) Handles CarControlsBtn.Click
        Dim CarControlPage As New CarControls()
        CarControls.Show()
        Me.Visible = False
    End Sub

    Private Sub ScheduleBtn_Click(sender As Object, e As EventArgs) Handles ScheduleBtn.Click
        Dim Schedule As New Schedule()
        Schedule.Show()
        Me.Visible = False
    End Sub

    Private Sub BatteryIndicator1_Load(sender As Object, e As EventArgs) Handles BatteryIndicator1.Load

    End Sub

    Private Sub PathBtn_Click(sender As Object, e As EventArgs) Handles PathBtn.Click
        ' not implemented
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RequestCar.Show()
        Me.Hide()
    End Sub
End Class