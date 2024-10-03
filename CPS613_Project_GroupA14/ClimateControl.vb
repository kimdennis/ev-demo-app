Imports System.Diagnostics.Eventing.Reader

Public Class ClimateControl
    Private Temp As Boolean = False
    Private Fan As Boolean = False
    Private SeatHeat As Boolean = False
    Private Seat1 As Boolean = False
    Private Seat2 As Boolean = False
    Private Seat3 As Boolean = False
    Private Seat4 As Boolean = False
    Private Temp2 As Double = 23
    Private Fan1 As Integer = 0
    Private Fan2 As Integer = 0
    Private Fan3 As Integer = 0
    Private Fan4 As Integer = 0
    Private SeatTemp1 As Integer = 0
    Private SeatTemp2 As Integer = 0
    Private SeatTemp3 As Integer = 0
    Private SeatTemp4 As Integer = 0
    Private TrackValue As Integer = 0
    Private TrackValue2 As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Cursor = New Cursor(My.Resources.cursor.Handle)
        Me.CenterToScreen()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ClimateControl_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TempBtn_Click(sender As Object, e As EventArgs) Handles TempBtn.Click
        Temp = Not Temp
        If Temp Then
            TempSlider.Enabled = True
            FanSlider.Enabled = False
            TempBtn.BackColor = Color.Blue
            FanBtn.BackColor = Color.White
            Fan = False
            SeatHeat = False
            SeatHeatBtn.BackColor = Color.White
        Else
            TempBtn.BackColor = Color.White
            TempSlider.Enabled = False
        End If

    End Sub

    Private Sub FanBtn_Click(sender As Object, e As EventArgs) Handles FanBtn.Click
        Fan = Not Fan
        If Fan Then
            FanSlider.Enabled = True
            TempSlider.Enabled = False
            FanBtn.BackColor = Color.Blue
            Temp = False
            SeatHeat = False
            TempBtn.BackColor = Color.White
            SeatHeatBtn.BackColor = Color.White
        Else
            FanBtn.BackColor = Color.White
            FanSlider.Enabled = False
        End If
    End Sub

    Private Sub SeatHeatBtn_Click(sender As Object, e As EventArgs)
        SeatHeat = Not SeatHeat
        If SeatHeat Then
            TempSlider.Enabled = False
            FanSlider.Enabled = False
            SeatHeatBtn.BackColor = Color.Blue
            Temp = False
            Fan = False
            TempBtn.BackColor = Color.White
            FanBtn.BackColor = Color.White
        Else
            SeatHeatBtn.BackColor = Color.White
        End If
    End Sub

    Private Sub DriverBtn_Click(sender As Object, e As EventArgs) Handles DriverBtn.Click
        Seat1 = Not Seat1
        If Seat1 Then
            DriverBtn.BackColor = Color.Red
        Else
            DriverBtn.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub PassBtn_Click(sender As Object, e As EventArgs) Handles PassBtn.Click
        Seat2 = Not Seat2
        If Seat2 Then
            PassBtn.BackColor = Color.Red
        Else
            PassBtn.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub Pass2Btn_Click(sender As Object, e As EventArgs) Handles Pass2Btn.Click
        Seat3 = Not Seat3
        If Seat3 Then
            Pass2Btn.BackColor = Color.Red
        Else
            Pass2Btn.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub Pass3Btn_Click(sender As Object, e As EventArgs) Handles Pass3Btn.Click
        Seat4 = Not Seat4
        If Seat4 Then
            Pass3Btn.BackColor = Color.Red
        Else
            Pass3Btn.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub TempSlider_Scroll(sender As Object, e As EventArgs) Handles TempSlider.Scroll
        If Seat1 And Temp And TempSlider.Value > TrackValue Then
            Temp2 += 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If
        If Seat2 And Temp And TempSlider.Value > TrackValue Then
            Temp2 += 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If
        If Seat3 And Temp And TempSlider.Value > TrackValue Then
            Temp2 += 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If
        If Seat4 And Temp And TempSlider.Value > TrackValue Then
            Temp2 += 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If

        If Seat1 And Temp And TempSlider.Value < TrackValue Then
            Temp2 -= 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If
        If Seat2 And Temp And TempSlider.Value < TrackValue Then
            Temp2 -= 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If
        If Seat3 And Temp And TempSlider.Value < TrackValue Then
            Temp2 -= 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If
        If Seat4 And Temp And TempSlider.Value < TrackValue Then
            Temp2 -= 0.5
            TempBox.Text = "Inside Temp: " + Temp2.ToString + "°C" + vbCrLf + vbCrLf + vbCrLf + "Outside Temp: 14°C"
        End If
    End Sub


    Private Sub FanSlider_Scroll(sender As Object, e As EventArgs) Handles FanSlider.Scroll
        If Seat1 And Fan And FanSlider.Value > TrackValue2 Then
            Fan1 += 10
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If
        If Seat2 And Fan And FanSlider.Value > TrackValue2 Then
            Fan2 += 10
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If
        If Seat3 And Fan And FanSlider.Value > TrackValue2 Then
            Fan3 += 10
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If
        If Seat4 And Fan And FanSlider.Value > TrackValue2 Then
            Fan4 += 10
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If

        If Seat1 And Fan And FanSlider.Value < TrackValue2 Then
            Fan1 -= 10
            If Fan1 < 0 Then
                Fan1 = 0
            End If
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If
        If Seat2 And Fan And FanSlider.Value < TrackValue2 Then
            Fan2 -= 10
            If Fan2 < 0 Then
                Fan2 = 0
            End If
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If
        If Seat3 And Fan And FanSlider.Value < TrackValue2 Then
            Fan3 -= 10
            If Fan3 < 0 Then
                Fan3 = 0
            End If
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If
        If Seat4 And Fan And FanSlider.Value < TrackValue2 Then
            Fan4 -= 10
            If Fan4 < 0 Then
                Fan4 = 0
            End If
            FanBox.Text = "Fan 1: " + Fan1.ToString + "%" + vbCrLf + "Fan 2: " + Fan2.ToString + "%" + vbCrLf + "Fan 3: " + Fan3.ToString + "%" + vbCrLf + "Fan 4: " + Fan4.ToString + "%"
        End If
    End Sub

    Private Sub TempSlider_ValueChanged(sender As Object, e As EventArgs) Handles TempSlider.ValueChanged
        TrackValue = TempSlider.Value
    End Sub

    Private Sub FanSlider_ValueChanged(sender As Object, e As EventArgs) Handles FanSlider.ValueChanged
        TrackValue2 = FanSlider.Value
    End Sub

    Private Sub SeatHeatBtn_Click_1(sender As Object, e As EventArgs) Handles SeatHeatBtn.Click
        If Seat1 And SeatTemp1 + 1 <= 3 Then
            SeatTemp1 += 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If

        If Seat2 And SeatTemp2 + 1 <= 3 Then
            SeatTemp2 += 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If

        If Seat3 And SeatTemp3 + 1 <= 3 Then
            SeatTemp3 += 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If

        If Seat4 And SeatTemp4 + 1 <= 3 Then
            SeatTemp4 += 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If
    End Sub

    Private Sub SeatCoolBtn_Click(sender As Object, e As EventArgs) Handles SeatCoolBtn.Click
        If Seat1 And SeatTemp1 - 1 >= 0 Then
            SeatTemp1 -= 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If

        If Seat2 And SeatTemp2 - 1 >= 0 Then
            SeatTemp2 -= 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If

        If Seat3 And SeatTemp3 - 1 >= 0 Then
            SeatTemp3 -= 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If

        If Seat4 And SeatTemp4 - 1 >= 0 Then
            SeatTemp4 -= 1
            SeatBox.Text = "Heating Level" + vbCrLf + "Seat 1: " + SeatTemp1.ToString + vbCrLf + "Seat 2: " + SeatTemp2.ToString + vbCrLf + "Seat 3: " + SeatTemp3.ToString + vbCrLf + "Seat 4: " + SeatTemp4.ToString
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim home As New homeOwner()
        home.Show()
        Me.Visible = False
    End Sub
End Class