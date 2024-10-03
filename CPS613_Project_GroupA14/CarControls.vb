Public Class CarControls
    Private openWindowFront As Boolean = False
    Private openWindowBack As Boolean = False
    Private Trunk As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Cursor = New Cursor(My.Resources.cursor.Handle)
        Me.CenterToScreen()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrontOpenBtn_Click(sender As Object, e As EventArgs) Handles FrontOpenBtn.Click
        openWindowFront = Not openWindowFront
        If openWindowFront Then
            FrontOpenBtn.Image = My.Resources.windowdown
            FrontWText.Text = "Open Windows"
        Else
            FrontOpenBtn.Image = My.Resources.windowup
            FrontWText.Text = "Close Windows"
        End If
    End Sub

    Private Sub BackOpenBtn_Click(sender As Object, e As EventArgs) Handles BackOpenBtn.Click
        openWindowBack = Not openWindowBack
        If openWindowBack Then
            BackOpenBtn.Image = My.Resources.windowdown
            BackWText.Text = "Open Windows"
        Else
            BackOpenBtn.Image = My.Resources.windowup
            BackWText.Text = "Close Windows"
        End If
    End Sub

    Private Sub TrunkBtn_Click(sender As Object, e As EventArgs) Handles TrunkBtn.Click
        Trunk = Not Trunk
        If Trunk Then
            TrunkBtn.Image = My.Resources.car
            TrunkText.Text = "Close Trunk"
        Else
            TrunkBtn.Image = My.Resources.boot
            TrunkText.Text = "Open Trunk"
        End If
    End Sub


    Private Sub ClimateBtn_Click(sender As Object, e As EventArgs) Handles ClimateBtn.Click
        Dim climate As New ClimateControl
        climate.Show()
        Me.Visible = False
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim home As New homeOwner()
        home.Show()
        Me.Visible = False
    End Sub
End Class