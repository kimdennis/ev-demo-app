Public Class RequestCar
    Private Sub destinationTxt_Click(sender As Object, e As EventArgs) Handles destinationTxt.Click
        destinationTxt.Text = ""
    End Sub

    Private Sub SetDestinationbtn_Click(sender As Object, e As EventArgs) Handles SetDestinationbtn.Click
        Dim x As String = destinationTxt.Text
        destinationName.Text = "Destination: " + x
        SetDestinationbtn.Visible = False
        ChangeDestinationbtn.Visible = True
    End Sub

    Private Sub ChangeDestinationbtn_Click(sender As Object, e As EventArgs) Handles ChangeDestinationbtn.Click
        Dim y As String = destinationTxt.Text
        destinationName.Text = "Destination: " + y
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        homeRider.Show()
        Me.Hide()
    End Sub

    Private Sub devbtn_Click(sender As Object, e As EventArgs) Handles devbtn.Click
        StarIconOne.Visible = True
        StarIconTwo.Visible = True
        StarIconThree.Visible = True
        StarIconFour.Visible = True
        StarIconFive.Visible = True
        MapBox.Visible = False
        BatteryIndicator1.Visible = False
        SetDestinationbtn.Visible = False
        ChangeDestinationbtn.Visible = False
        destinationTxt.Visible = False
        destinationName.Visible = False

        arrivedTxt.Visible = True
        picDriver.Visible = True
        Sallytxt.Visible = True
        btnSkip.Visible = True
        btnSubmit.Visible = True
        lblLeaveReview.Text = "Would you like to leave a review?"
        lblLeaveReview.Visible = True

    End Sub

    Private Sub StarIconOne_Click(sender As Object, e As EventArgs) Handles StarIconOne.Click
        StarIconFive.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconFour.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconThree.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconTwo.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconOne.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
    End Sub

    Private Sub StarIconTwo_Click(sender As Object, e As EventArgs) Handles StarIconTwo.Click
        StarIconFive.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconFour.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconThree.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconTwo.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconOne.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
    End Sub

    Private Sub StarIconThree_Click(sender As Object, e As EventArgs) Handles StarIconThree.Click
        StarIconFive.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconFour.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconThree.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconTwo.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconOne.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
    End Sub

    Private Sub StarIconFour_Click(sender As Object, e As EventArgs) Handles StarIconFour.Click
        StarIconFive.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        StarIconFour.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconThree.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconTwo.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconOne.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
    End Sub

    Private Sub StarIconFive_Click(sender As Object, e As EventArgs) Handles StarIconFive.Click
        StarIconFive.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconFour.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconThree.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconTwo.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        StarIconOne.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        StarIconOne.Visible = False
        StarIconTwo.Visible = False
        StarIconThree.Visible = False
        StarIconFour.Visible = False
        StarIconFive.Visible = False
        MapBox.Visible = True
        BatteryIndicator1.Visible = True
        SetDestinationbtn.Visible = True
        destinationTxt.Visible = True
        destinationName.Visible = True
        destinationName.Text = "Awaiting Destination"
        destinationTxt.Text = "Please input your destination and select the button"

        arrivedTxt.Visible = False
        picDriver.Visible = False
        Sallytxt.Visible = False
        btnSkip.Visible = False
        btnSubmit.Visible = False
        lblLeaveReview.Visible = False

        homeRider.Show()
        Me.Hide()


    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click

        StarIconOne.Visible = False
        StarIconTwo.Visible = False
        StarIconThree.Visible = False
        StarIconFour.Visible = False
        StarIconFive.Visible = False
        MapBox.Visible = True
        BatteryIndicator1.Visible = True
        SetDestinationbtn.Visible = True
        destinationTxt.Visible = True
        destinationName.Visible = True
        destinationName.Text = "Awaiting Destination"
        destinationTxt.Text = "Please input your destination and select the button"

        arrivedTxt.Visible = False
        picDriver.Visible = False
        Sallytxt.Visible = False
        btnSkip.Visible = False
        btnSubmit.Visible = False
        lblLeaveReview.Visible = False

        homeRider.Show()
        Me.Hide()


    End Sub
End Class