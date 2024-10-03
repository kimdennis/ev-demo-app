Public Class Alert

    Private _AlertType As String

    Public Property AlertType As String
        Get
            Return _AlertType
        End Get
        Set(value As String)
            _AlertType = value
            Me.SetInfo()
        End Set
    End Property

    Public Sub New(ByVal alertType As String)

        ' This call is required by the designer.
        InitializeComponent()
        _AlertType = alertType
        Me.SetInfo()

    End Sub

    Public Sub SetInfo()
        If _AlertType IsNot Nothing Then
            Select Case _AlertType
                Case "intruder"
                    Me.AlertIcon.BackgroundImage = My.Resources.iconIntruder
                    Me.AlertName.Text = "Attempted Intruder Alert"
                    Me.FollowAlertBtn.Text = "Review Information"
                    Me.DismissInfo.Text = "Dismissing will dispatch authorities to the car"
                Case "damage"
                    Me.AlertIcon.BackgroundImage = My.Resources.iconCarDamage
                    Me.AlertName.Text = "Car Damage Alert"
                    Me.FollowAlertBtn.Text = "Review Information"
                    Me.DismissInfo.Text = "Dismissing will dispatch authorities to the car"
                Case "techProblem"
                    Me.AlertIcon.BackgroundImage = My.Resources.iconTechProblem
                    Me.AlertName.Text = "Technical Problem Alert"
                    Me.FollowAlertBtn.Text = "Review Information"
                    Me.DismissInfo.Text = "Dismissing will attempt to auto-resolve the issue"
                Case "lowCharge"
                    Me.AlertIcon.BackgroundImage = My.Resources.iconLowCharge
                    Me.AlertName.Text = "Low Charge Alert"
                    Me.FollowAlertBtn.Text = "Review Information"
                    Me.DismissInfo.Text = "Dismissing will auto re-charge the car"
                Case "rideRequest"
                    Me.AlertIcon.BackgroundImage = My.Resources.iconRideRequest
                    Me.AlertName.Text = "Ride Request Alert"
                    Me.FollowAlertBtn.Text = "Accept Request"
                    Me.DismissInfo.Text = "Dismissing will reject the ride request"
                Case Else
                    Me.AlertIcon.BackgroundImage = My.Resources.iconDefaultAlert
                    Me.AlertName.Text = "Generic Alert Element"
                    Me.FollowAlertBtn.Text = "Review Information"
                    Me.DismissInfo.Text = "Dismissing will do this and that"
            End Select
            Me.AlertName.Left = (Me.AlertName.Parent.Width \ 2) - (Me.AlertName.Width \ 2)
        End If
    End Sub


    Private Sub DismissAlertBtn_Click(sender As Object, e As EventArgs) Handles DismissAlertBtn.Click
        ' Destroy Alert Overlay Element
        Me.Dispose()
    End Sub

    Private Sub ReviewAlertBtn_Click(sender As Object, e As EventArgs) Handles FollowAlertBtn.Click
        ' Open info page
        If _AlertType = "techProblem" Then
            Dim detailsPage = New CarSystems
            detailsPage.Left = 57
            detailsPage.Top = 102
            detailsPage.Parent = Me.Parent
            detailsPage.BringToFront()
        End If
        If _AlertType = "rideRequest" Then
            homeOwner.SetRideInProgress(Me.Parent)
            homeOwner.ShowTechnicalProblem(Me.Parent)
        End If
        Me.Dispose()
    End Sub

    Async Sub ShowTechnicalProblem()
        Await Task.Delay(3000)
        Dim techProblemAlert = New Alert("techProblem")
        techProblemAlert.Left = 57
        techProblemAlert.Top = 102
        techProblemAlert.Parent = Me
        techProblemAlert.BringToFront()
    End Sub
End Class
