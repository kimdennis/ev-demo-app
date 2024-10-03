<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homeRider
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PathBtn = New System.Windows.Forms.Button()
        Me.BatteryIndicator1 = New CPS613_Project_GroupA14.BatteryIndicator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CarIcon = New System.Windows.Forms.PictureBox()
        Me.CarRating = New System.Windows.Forms.PictureBox()
        Me.ScheduleBtn = New System.Windows.Forms.Button()
        Me.CarControlsBtn = New System.Windows.Forms.Button()
        Me.CarName = New System.Windows.Forms.Label()
        Me.MapBox = New System.Windows.Forms.PictureBox()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.EarningsBtn = New System.Windows.Forms.Button()
        Me.ProfileBtn = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.messenger
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(303, 462)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 50)
        Me.Button2.TabIndex = 37
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PathBtn
        '
        Me.PathBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PathBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PathBtn.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.route
        Me.PathBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PathBtn.FlatAppearance.BorderSize = 0
        Me.PathBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PathBtn.Location = New System.Drawing.Point(89, 462)
        Me.PathBtn.Name = "PathBtn"
        Me.PathBtn.Size = New System.Drawing.Size(52, 50)
        Me.PathBtn.TabIndex = 36
        Me.PathBtn.UseVisualStyleBackColor = False
        '
        'BatteryIndicator1
        '
        Me.BatteryIndicator1.Increment = 110
        Me.BatteryIndicator1.Location = New System.Drawing.Point(102, 634)
        Me.BatteryIndicator1.Name = "BatteryIndicator1"
        Me.BatteryIndicator1.Size = New System.Drawing.Size(240, 30)
        Me.BatteryIndicator1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(57, 687)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 2)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 572)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Located: Korea Town"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 584)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 32
        '
        'CarIcon
        '
        Me.CarIcon.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconCar
        Me.CarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CarIcon.Location = New System.Drawing.Point(81, 546)
        Me.CarIcon.Name = "CarIcon"
        Me.CarIcon.Size = New System.Drawing.Size(60, 60)
        Me.CarIcon.TabIndex = 31
        Me.CarIcon.TabStop = False
        '
        'CarRating
        '
        Me.CarRating.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources._360_F_274864312_uNlm9yCpdViwKzHkCp0sOBrmJFN0pKAa
        Me.CarRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CarRating.Location = New System.Drawing.Point(147, 584)
        Me.CarRating.Name = "CarRating"
        Me.CarRating.Size = New System.Drawing.Size(74, 30)
        Me.CarRating.TabIndex = 30
        Me.CarRating.TabStop = False
        '
        'ScheduleBtn
        '
        Me.ScheduleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ScheduleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ScheduleBtn.FlatAppearance.BorderSize = 0
        Me.ScheduleBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ScheduleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ScheduleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScheduleBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconSchedule
        Me.ScheduleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ScheduleBtn.Location = New System.Drawing.Point(232, 105)
        Me.ScheduleBtn.Name = "ScheduleBtn"
        Me.ScheduleBtn.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.ScheduleBtn.Size = New System.Drawing.Size(135, 93)
        Me.ScheduleBtn.TabIndex = 29
        Me.ScheduleBtn.Text = "Schedule"
        Me.ScheduleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ScheduleBtn.UseVisualStyleBackColor = False
        '
        'CarControlsBtn
        '
        Me.CarControlsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CarControlsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CarControlsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CarControlsBtn.FlatAppearance.BorderSize = 0
        Me.CarControlsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CarControlsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.CarControlsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.CarControlsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CarControlsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CarControlsBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconCarControls
        Me.CarControlsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CarControlsBtn.Location = New System.Drawing.Point(77, 105)
        Me.CarControlsBtn.Name = "CarControlsBtn"
        Me.CarControlsBtn.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.CarControlsBtn.Size = New System.Drawing.Size(149, 93)
        Me.CarControlsBtn.TabIndex = 28
        Me.CarControlsBtn.Text = "Car Controls"
        Me.CarControlsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CarControlsBtn.UseVisualStyleBackColor = False
        '
        'CarName
        '
        Me.CarName.AutoSize = True
        Me.CarName.BackColor = System.Drawing.Color.Transparent
        Me.CarName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CarName.Location = New System.Drawing.Point(148, 543)
        Me.CarName.Name = "CarName"
        Me.CarName.Size = New System.Drawing.Size(225, 25)
        Me.CarName.TabIndex = 27
        Me.CarName.Text = "Kawasaki JT1500 ULTRA"
        '
        'MapBox
        '
        Me.MapBox.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.map
        Me.MapBox.Location = New System.Drawing.Point(77, 223)
        Me.MapBox.Name = "MapBox"
        Me.MapBox.Size = New System.Drawing.Size(290, 299)
        Me.MapBox.TabIndex = 26
        Me.MapBox.TabStop = False
        '
        'SettingsBtn
        '
        Me.SettingsBtn.BackColor = System.Drawing.Color.White
        Me.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SettingsBtn.FlatAppearance.BorderSize = 0
        Me.SettingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SettingsBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconSettings
        Me.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SettingsBtn.Location = New System.Drawing.Point(303, 698)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(70, 57)
        Me.SettingsBtn.TabIndex = 25
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SettingsBtn.UseVisualStyleBackColor = False
        '
        'EarningsBtn
        '
        Me.EarningsBtn.BackColor = System.Drawing.Color.White
        Me.EarningsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EarningsBtn.FlatAppearance.BorderSize = 0
        Me.EarningsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EarningsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EarningsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EarningsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EarningsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EarningsBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconEarnings
        Me.EarningsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EarningsBtn.Location = New System.Drawing.Point(226, 698)
        Me.EarningsBtn.Name = "EarningsBtn"
        Me.EarningsBtn.Size = New System.Drawing.Size(70, 57)
        Me.EarningsBtn.TabIndex = 24
        Me.EarningsBtn.Text = "Earnings"
        Me.EarningsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EarningsBtn.UseVisualStyleBackColor = False
        '
        'ProfileBtn
        '
        Me.ProfileBtn.BackColor = System.Drawing.Color.White
        Me.ProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProfileBtn.FlatAppearance.BorderSize = 0
        Me.ProfileBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProfileBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProfileBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconProfile
        Me.ProfileBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ProfileBtn.Location = New System.Drawing.Point(149, 698)
        Me.ProfileBtn.Name = "ProfileBtn"
        Me.ProfileBtn.Size = New System.Drawing.Size(70, 57)
        Me.ProfileBtn.TabIndex = 23
        Me.ProfileBtn.Text = "Profile"
        Me.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProfileBtn.UseVisualStyleBackColor = False
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.White
        Me.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconHome
        Me.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HomeBtn.Location = New System.Drawing.Point(72, 698)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(70, 57)
        Me.HomeBtn.TabIndex = 22
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 48)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Request Ride"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'homeRider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(444, 821)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PathBtn)
        Me.Controls.Add(Me.BatteryIndicator1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CarIcon)
        Me.Controls.Add(Me.CarRating)
        Me.Controls.Add(Me.ScheduleBtn)
        Me.Controls.Add(Me.CarControlsBtn)
        Me.Controls.Add(Me.CarName)
        Me.Controls.Add(Me.MapBox)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.EarningsBtn)
        Me.Controls.Add(Me.ProfileBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.DoubleBuffered = True
        Me.Name = "homeRider"
        Me.Text = "homeRider"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents PathBtn As Button
    Friend WithEvents BatteryIndicator1 As BatteryIndicator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CarIcon As PictureBox
    Friend WithEvents CarRating As PictureBox
    Friend WithEvents ScheduleBtn As Button
    Friend WithEvents CarControlsBtn As Button
    Friend WithEvents CarName As Label
    Friend WithEvents MapBox As PictureBox
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents EarningsBtn As Button
    Friend WithEvents ProfileBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents Button1 As Button
End Class
