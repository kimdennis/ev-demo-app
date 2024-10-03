Public Class Rating
    Private Sub Rating_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.CenterToScreen()
        Me.Cursor = New Cursor(My.Resources.cursor.Handle)

        Me.Label1.Text = "Bad"
        Me.Button1.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button3.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button4.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button5.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Label1.Text = "Bad"

        Me.Button1.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button3.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button4.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button5.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Label1.Text = "Poor"

        Me.Button1.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button3.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button4.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button5.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Label1.Text = "Average"

        Me.Button1.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button3.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button4.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.Button5.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Label1.Text = "Great"

        Me.Button1.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button3.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button4.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button5.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Label1.Text = "Excellent"

        Me.Button1.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button3.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button4.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.Button5.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Me.Dispose()
    End Sub
End Class