Public Class Start
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.CenterToScreen()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub OwnerBtn_Click(sender As Object, e As EventArgs) Handles OwnerBtn.Click
        Dim home As New homeOwner()
        home.Show()
        Me.Hide()
    End Sub

    Private Sub RiderBtn_Click(sender As Object, e As EventArgs) Handles RiderBtn.Click
        Dim home As New homeRider()
        home.Show()
        Me.Hide()
    End Sub
End Class