<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.ProfileBtn = New System.Windows.Forms.Button()
        Me.EarningsBtn = New System.Windows.Forms.Button()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.SetDestinationbtn = New System.Windows.Forms.Button()
        Me.BatteryIndicator1 = New CPS613_Project_GroupA14.BatteryIndicator()
        Me.MapBox = New System.Windows.Forms.PictureBox()
        Me.destinationName = New System.Windows.Forms.Label()
        Me.destinationTxt = New System.Windows.Forms.TextBox()
        Me.ChangeDestinationbtn = New System.Windows.Forms.Button()
        Me.devbtn = New System.Windows.Forms.Button()
        Me.StarIconOne = New System.Windows.Forms.PictureBox()
        Me.StarIconTwo = New System.Windows.Forms.PictureBox()
        Me.StarIconThree = New System.Windows.Forms.PictureBox()
        Me.StarIconFour = New System.Windows.Forms.PictureBox()
        Me.StarIconFive = New System.Windows.Forms.PictureBox()
        Me.arrivedTxt = New System.Windows.Forms.Label()
        Me.picDriver = New System.Windows.Forms.PictureBox()
        Me.Sallytxt = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.lblLeaveReview = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarIconOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarIconTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarIconThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarIconFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarIconFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(57, 687)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 2)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        Me.HomeBtn.TabIndex = 20
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HomeBtn.UseVisualStyleBackColor = False
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
        Me.ProfileBtn.TabIndex = 21
        Me.ProfileBtn.Text = "Profile"
        Me.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProfileBtn.UseVisualStyleBackColor = False
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
        Me.EarningsBtn.TabIndex = 22
        Me.EarningsBtn.Text = "Earnings"
        Me.EarningsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EarningsBtn.UseVisualStyleBackColor = False
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
        Me.SettingsBtn.TabIndex = 23
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SettingsBtn.UseVisualStyleBackColor = False
        '
        'SetDestinationbtn
        '
        Me.SetDestinationbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SetDestinationbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SetDestinationbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SetDestinationbtn.FlatAppearance.BorderSize = 0
        Me.SetDestinationbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SetDestinationbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SetDestinationbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SetDestinationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetDestinationbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SetDestinationbtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconCar
        Me.SetDestinationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SetDestinationbtn.Location = New System.Drawing.Point(72, 164)
        Me.SetDestinationbtn.Name = "SetDestinationbtn"
        Me.SetDestinationbtn.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.SetDestinationbtn.Size = New System.Drawing.Size(301, 71)
        Me.SetDestinationbtn.TabIndex = 24
        Me.SetDestinationbtn.Text = "Set Destination"
        Me.SetDestinationbtn.UseVisualStyleBackColor = False
        '
        'BatteryIndicator1
        '
        Me.BatteryIndicator1.Increment = 3490
        Me.BatteryIndicator1.Location = New System.Drawing.Point(102, 632)
        Me.BatteryIndicator1.Name = "BatteryIndicator1"
        Me.BatteryIndicator1.Size = New System.Drawing.Size(240, 30)
        Me.BatteryIndicator1.TabIndex = 26
        '
        'MapBox
        '
        Me.MapBox.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.map
        Me.MapBox.Location = New System.Drawing.Point(77, 308)
        Me.MapBox.Name = "MapBox"
        Me.MapBox.Size = New System.Drawing.Size(290, 299)
        Me.MapBox.TabIndex = 27
        Me.MapBox.TabStop = False
        '
        'destinationName
        '
        Me.destinationName.AutoSize = True
        Me.destinationName.BackColor = System.Drawing.Color.Transparent
        Me.destinationName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.destinationName.Location = New System.Drawing.Point(72, 261)
        Me.destinationName.Name = "destinationName"
        Me.destinationName.Size = New System.Drawing.Size(198, 25)
        Me.destinationName.TabIndex = 28
        Me.destinationName.Text = "Awaiting Destination"
        '
        'destinationTxt
        '
        Me.destinationTxt.ForeColor = System.Drawing.SystemColors.GrayText
        Me.destinationTxt.Location = New System.Drawing.Point(72, 117)
        Me.destinationTxt.Name = "destinationTxt"
        Me.destinationTxt.Size = New System.Drawing.Size(301, 23)
        Me.destinationTxt.TabIndex = 29
        Me.destinationTxt.Text = "Please input your destination and select the button"
        '
        'ChangeDestinationbtn
        '
        Me.ChangeDestinationbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChangeDestinationbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChangeDestinationbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChangeDestinationbtn.FlatAppearance.BorderSize = 0
        Me.ChangeDestinationbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChangeDestinationbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ChangeDestinationbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ChangeDestinationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeDestinationbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChangeDestinationbtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconCar
        Me.ChangeDestinationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangeDestinationbtn.Location = New System.Drawing.Point(72, 164)
        Me.ChangeDestinationbtn.Name = "ChangeDestinationbtn"
        Me.ChangeDestinationbtn.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.ChangeDestinationbtn.Size = New System.Drawing.Size(306, 71)
        Me.ChangeDestinationbtn.TabIndex = 30
        Me.ChangeDestinationbtn.Text = "Change Destination"
        Me.ChangeDestinationbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChangeDestinationbtn.UseVisualStyleBackColor = False
        Me.ChangeDestinationbtn.Visible = False
        '
        'devbtn
        '
        Me.devbtn.Location = New System.Drawing.Point(370, 797)
        Me.devbtn.Name = "devbtn"
        Me.devbtn.Size = New System.Drawing.Size(75, 23)
        Me.devbtn.TabIndex = 31
        Me.devbtn.Text = "developer"
        Me.devbtn.UseVisualStyleBackColor = True
        '
        'StarIconOne
        '
        Me.StarIconOne.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.StarIconOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StarIconOne.Location = New System.Drawing.Point(72, 393)
        Me.StarIconOne.Name = "StarIconOne"
        Me.StarIconOne.Size = New System.Drawing.Size(51, 52)
        Me.StarIconOne.TabIndex = 32
        Me.StarIconOne.TabStop = False
        Me.StarIconOne.Visible = False
        '
        'StarIconTwo
        '
        Me.StarIconTwo.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.StarIconTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StarIconTwo.Location = New System.Drawing.Point(129, 393)
        Me.StarIconTwo.Name = "StarIconTwo"
        Me.StarIconTwo.Size = New System.Drawing.Size(51, 52)
        Me.StarIconTwo.TabIndex = 33
        Me.StarIconTwo.TabStop = False
        Me.StarIconTwo.Visible = False
        '
        'StarIconThree
        '
        Me.StarIconThree.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.StarIconThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StarIconThree.Location = New System.Drawing.Point(186, 393)
        Me.StarIconThree.Name = "StarIconThree"
        Me.StarIconThree.Size = New System.Drawing.Size(51, 52)
        Me.StarIconThree.TabIndex = 34
        Me.StarIconThree.TabStop = False
        Me.StarIconThree.Visible = False
        '
        'StarIconFour
        '
        Me.StarIconFour.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.star
        Me.StarIconFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StarIconFour.Location = New System.Drawing.Point(245, 393)
        Me.StarIconFour.Name = "StarIconFour"
        Me.StarIconFour.Size = New System.Drawing.Size(51, 52)
        Me.StarIconFour.TabIndex = 35
        Me.StarIconFour.TabStop = False
        Me.StarIconFour.Visible = False
        '
        'StarIconFive
        '
        Me.StarIconFive.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.empty
        Me.StarIconFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StarIconFive.Location = New System.Drawing.Point(303, 393)
        Me.StarIconFive.Name = "StarIconFive"
        Me.StarIconFive.Size = New System.Drawing.Size(51, 52)
        Me.StarIconFive.TabIndex = 36
        Me.StarIconFive.TabStop = False
        Me.StarIconFive.Visible = False
        '
        'arrivedTxt
        '
        Me.arrivedTxt.AutoSize = True
        Me.arrivedTxt.BackColor = System.Drawing.Color.Transparent
        Me.arrivedTxt.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.arrivedTxt.Location = New System.Drawing.Point(72, 93)
        Me.arrivedTxt.Name = "arrivedTxt"
        Me.arrivedTxt.Size = New System.Drawing.Size(295, 21)
        Me.arrivedTxt.TabIndex = 37
        Me.arrivedTxt.Text = "You have arrived at your destination"
        Me.arrivedTxt.Visible = False
        '
        'picDriver
        '
        Me.picDriver.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.driver
        Me.picDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDriver.Location = New System.Drawing.Point(139, 146)
        Me.picDriver.Name = "picDriver"
        Me.picDriver.Size = New System.Drawing.Size(167, 173)
        Me.picDriver.TabIndex = 38
        Me.picDriver.TabStop = False
        Me.picDriver.Visible = False
        '
        'Sallytxt
        '
        Me.Sallytxt.AutoSize = True
        Me.Sallytxt.BackColor = System.Drawing.Color.Transparent
        Me.Sallytxt.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sallytxt.Location = New System.Drawing.Point(186, 333)
        Me.Sallytxt.Name = "Sallytxt"
        Me.Sallytxt.Size = New System.Drawing.Size(79, 37)
        Me.Sallytxt.TabIndex = 39
        Me.Sallytxt.Text = "Sally"
        Me.Sallytxt.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSubmit.FlatAppearance.BorderSize = 2
        Me.btnSubmit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmit.Location = New System.Drawing.Point(72, 552)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.btnSubmit.Size = New System.Drawing.Size(147, 74)
        Me.btnSubmit.TabIndex = 40
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSubmit.UseVisualStyleBackColor = False
        Me.btnSubmit.Visible = False
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.IndianRed
        Me.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnSkip.FlatAppearance.BorderSize = 2
        Me.btnSkip.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSkip.ForeColor = System.Drawing.Color.DarkRed
        Me.btnSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSkip.Location = New System.Drawing.Point(231, 552)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.btnSkip.Size = New System.Drawing.Size(147, 74)
        Me.btnSkip.TabIndex = 41
        Me.btnSkip.Text = "SKIP"
        Me.btnSkip.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSkip.UseVisualStyleBackColor = False
        Me.btnSkip.Visible = False
        '
        'lblLeaveReview
        '
        Me.lblLeaveReview.AutoSize = True
        Me.lblLeaveReview.BackColor = System.Drawing.Color.Transparent
        Me.lblLeaveReview.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblLeaveReview.Location = New System.Drawing.Point(75, 473)
        Me.lblLeaveReview.Name = "lblLeaveReview"
        Me.lblLeaveReview.Size = New System.Drawing.Size(49, 21)
        Me.lblLeaveReview.TabIndex = 42
        Me.lblLeaveReview.Text = "test1"
        Me.lblLeaveReview.Visible = False
        '
        'RequestCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(444, 821)
        Me.Controls.Add(Me.lblLeaveReview)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Sallytxt)
        Me.Controls.Add(Me.picDriver)
        Me.Controls.Add(Me.arrivedTxt)
        Me.Controls.Add(Me.StarIconFive)
        Me.Controls.Add(Me.StarIconFour)
        Me.Controls.Add(Me.StarIconThree)
        Me.Controls.Add(Me.StarIconTwo)
        Me.Controls.Add(Me.StarIconOne)
        Me.Controls.Add(Me.devbtn)
        Me.Controls.Add(Me.ChangeDestinationbtn)
        Me.Controls.Add(Me.destinationTxt)
        Me.Controls.Add(Me.destinationName)
        Me.Controls.Add(Me.MapBox)
        Me.Controls.Add(Me.BatteryIndicator1)
        Me.Controls.Add(Me.SetDestinationbtn)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.EarningsBtn)
        Me.Controls.Add(Me.ProfileBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "RequestCar"
        Me.Text = "RequestCar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarIconOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarIconTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarIconThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarIconFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarIconFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDriver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HomeBtn As Button
    Friend WithEvents ProfileBtn As Button
    Friend WithEvents EarningsBtn As Button
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents SetDestinationbtn As Button
    Friend WithEvents BatteryIndicator1 As BatteryIndicator
    Friend WithEvents MapBox As PictureBox
    Friend WithEvents destinationName As Label
    Friend WithEvents destinationTxt As TextBox
    Friend WithEvents ChangeDestinationbtn As Button
    Friend WithEvents devbtn As Button
    Friend WithEvents StarIconOne As PictureBox
    Friend WithEvents StarIconTwo As PictureBox
    Friend WithEvents StarIconThree As PictureBox
    Friend WithEvents StarIconFour As PictureBox
    Friend WithEvents StarIconFive As PictureBox
    Friend WithEvents arrivedTxt As Label
    Friend WithEvents picDriver As PictureBox
    Friend WithEvents Sallytxt As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnSkip As Button
    Friend WithEvents lblLeaveReview As Label
End Class
