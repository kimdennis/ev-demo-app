Imports System.Diagnostics.Eventing.Reader

Public Class Schedule
    Private Editing As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.CenterToScreen()
        Me.Cursor = New Cursor(My.Resources.cursor.Handle)

        Me.DateTimePicker1.Value = "11/22/2022 8:00 AM"
        Me.DateTimePicker2.Value = "11/22/2022 2:00 PM"

        Me.SunBtn.Enabled = False
        Me.MonBtn.Enabled = False
        Me.TueBtn.Enabled = False
        Me.WedBtn.Enabled = False
        Me.ThuBtn.Enabled = False
        Me.FriBtn.Enabled = False
        Me.SatBtn.Enabled = False

    End Sub
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim home As New homeOwner(True)
        home.Show()
        Me.Dispose()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SunBtn.Click, MonBtn.Click, TueBtn.Click, WedBtn.Click, ThuBtn.Click, FriBtn.Click, SatBtn.Click
        If sender.BackColor = Color.FromArgb(255, 243, 243, 243) Then
            sender.BackColor = Color.FromArgb(255, 116, 220, 0)
        Else
            sender.BackColor = Color.FromArgb(255, 243, 243, 243)
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Me.Editing = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        Me.SunBtn.Enabled = True
        Me.MonBtn.Enabled = True
        Me.TueBtn.Enabled = True
        Me.WedBtn.Enabled = True
        Me.ThuBtn.Enabled = True
        Me.FriBtn.Enabled = True
        Me.SatBtn.Enabled = True
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Me.Editing = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        Me.SunBtn.Enabled = False
        Me.MonBtn.Enabled = False
        Me.TueBtn.Enabled = False
        Me.WedBtn.Enabled = False
        Me.ThuBtn.Enabled = False
        Me.FriBtn.Enabled = False
        Me.SatBtn.Enabled = False
    End Sub
End Class
