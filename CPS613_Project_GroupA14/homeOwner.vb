Public Class homeOwner
    Private _triggerRideRequest As Boolean = False
    Public Sub New(Optional ByVal triggerRideRequest As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Cursor = New Cursor(My.Resources.cursor.Handle)
        Me.CenterToScreen()

        Me._triggerRideRequest = triggerRideRequest
        Me.ShowRideRequest()

    End Sub

    Private Async Sub ShowRideRequest()
        Await Task.Delay(3000)
        If _triggerRideRequest Then
            Dim techProblemAlert = New Alert("rideRequest")
            techProblemAlert.Left = 57
            techProblemAlert.Top = 102
            techProblemAlert.Parent = Me
            techProblemAlert.BringToFront()
        End If
    End Sub

    Shared Async Sub SetRideInProgress(ByVal el As homeOwner)
        el.RideStatus.Text = "Status: Ride in progress"
        Await Task.Delay(30000)
        Dim ratingPage = New Rating()
        ratingPage.Show()
    End Sub

    Shared Sub SetStationary(ByRef el As homeOwner)
        el.RideStatus.Text = "Status: Stationary"
    End Sub

    Shared Async Sub ShowTechnicalProblem(ByVal parentEl As homeOwner)
        Await Task.Delay(10000)
        Dim techProblemAlert = New Alert("techProblem")
        techProblemAlert.Left = 57
        techProblemAlert.Top = 102
        techProblemAlert.Parent = parentEl
        techProblemAlert.BringToFront()
    End Sub

    Private Sub CarControlsBtn_Click(sender As Object, e As EventArgs) Handles CarControlsBtn.Click
        Dim CarControlPage As New CarControls()
        CarControls.Show()
        Me.Visible = False
    End Sub

    Private Sub ScheduleBtn_Click(sender As Object, e As EventArgs) Handles ScheduleBtn.Click
        Dim Schedule As New Schedule()
        Schedule.Show()
        Me.Dispose()
    End Sub
End Class
