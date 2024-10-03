<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClimateControl
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
        Me.TempSlider = New System.Windows.Forms.TrackBar()
        Me.FanSlider = New System.Windows.Forms.TrackBar()
        Me.TempBtn = New System.Windows.Forms.Button()
        Me.IntakeBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.EarningsBtn = New System.Windows.Forms.Button()
        Me.ProfileBtn = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.FanBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DriverBtn = New System.Windows.Forms.Button()
        Me.PassBtn = New System.Windows.Forms.Button()
        Me.Pass2Btn = New System.Windows.Forms.Button()
        Me.Pass3Btn = New System.Windows.Forms.Button()
        Me.TempBox = New System.Windows.Forms.RichTextBox()
        Me.FanBox = New System.Windows.Forms.RichTextBox()
        Me.SeatBox = New System.Windows.Forms.RichTextBox()
        Me.SeatHeatBtn = New System.Windows.Forms.Button()
        Me.SeatCoolBtn = New System.Windows.Forms.Button()
        CType(Me.TempSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TempSlider
        '
        Me.TempSlider.BackColor = System.Drawing.SystemColors.Info
        Me.TempSlider.Enabled = False
        Me.TempSlider.Location = New System.Drawing.Point(121, 445)
        Me.TempSlider.Name = "TempSlider"
        Me.TempSlider.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TempSlider.Size = New System.Drawing.Size(45, 134)
        Me.TempSlider.TabIndex = 5
        Me.TempSlider.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TempSlider.Value = 5
        '
        'FanSlider
        '
        Me.FanSlider.BackColor = System.Drawing.SystemColors.Info
        Me.FanSlider.Enabled = False
        Me.FanSlider.Location = New System.Drawing.Point(282, 445)
        Me.FanSlider.Name = "FanSlider"
        Me.FanSlider.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.FanSlider.Size = New System.Drawing.Size(45, 134)
        Me.FanSlider.TabIndex = 6
        Me.FanSlider.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TempBtn
        '
        Me.TempBtn.BackColor = System.Drawing.Color.White
        Me.TempBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TempBtn.FlatAppearance.BorderSize = 0
        Me.TempBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TempBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TempBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TempBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TempBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TempBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.thermometer
        Me.TempBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TempBtn.Location = New System.Drawing.Point(72, 86)
        Me.TempBtn.Name = "TempBtn"
        Me.TempBtn.Size = New System.Drawing.Size(146, 84)
        Me.TempBtn.TabIndex = 25
        Me.TempBtn.Text = "Temperature"
        Me.TempBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TempBtn.UseVisualStyleBackColor = False
        '
        'IntakeBtn
        '
        Me.IntakeBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.IntakeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.IntakeBtn.FlatAppearance.BorderSize = 0
        Me.IntakeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.IntakeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.IntakeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.IntakeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IntakeBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IntakeBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.air_conditioner
        Me.IntakeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IntakeBtn.Location = New System.Drawing.Point(188, 445)
        Me.IntakeBtn.Name = "IntakeBtn"
        Me.IntakeBtn.Size = New System.Drawing.Size(70, 74)
        Me.IntakeBtn.TabIndex = 27
        Me.IntakeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IntakeBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(57, 684)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 2)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
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
        Me.SettingsBtn.Location = New System.Drawing.Point(303, 695)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(70, 57)
        Me.SettingsBtn.TabIndex = 31
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
        Me.EarningsBtn.Location = New System.Drawing.Point(226, 695)
        Me.EarningsBtn.Name = "EarningsBtn"
        Me.EarningsBtn.Size = New System.Drawing.Size(70, 57)
        Me.EarningsBtn.TabIndex = 30
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
        Me.ProfileBtn.Location = New System.Drawing.Point(149, 695)
        Me.ProfileBtn.Name = "ProfileBtn"
        Me.ProfileBtn.Size = New System.Drawing.Size(70, 57)
        Me.ProfileBtn.TabIndex = 29
        Me.ProfileBtn.Text = "Profile"
        Me.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProfileBtn.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconHome
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(72, 695)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 57)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "Home"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'FanBtn
        '
        Me.FanBtn.BackColor = System.Drawing.Color.White
        Me.FanBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FanBtn.FlatAppearance.BorderSize = 0
        Me.FanBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FanBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FanBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FanBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FanBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.fan
        Me.FanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FanBtn.Location = New System.Drawing.Point(227, 86)
        Me.FanBtn.Name = "FanBtn"
        Me.FanBtn.Size = New System.Drawing.Size(146, 84)
        Me.FanBtn.TabIndex = 34
        Me.FanBtn.Text = "Fans"
        Me.FanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FanBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.car_outline_top_view_md
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(72, 186)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(301, 253)
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'DriverBtn
        '
        Me.DriverBtn.BackColor = System.Drawing.SystemColors.Control
        Me.DriverBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DriverBtn.FlatAppearance.BorderSize = 0
        Me.DriverBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DriverBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DriverBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DriverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DriverBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DriverBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.seat
        Me.DriverBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DriverBtn.Location = New System.Drawing.Point(119, 211)
        Me.DriverBtn.Name = "DriverBtn"
        Me.DriverBtn.Size = New System.Drawing.Size(100, 90)
        Me.DriverBtn.TabIndex = 40
        Me.DriverBtn.Text = "1"
        Me.DriverBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DriverBtn.UseVisualStyleBackColor = False
        '
        'PassBtn
        '
        Me.PassBtn.BackColor = System.Drawing.SystemColors.Control
        Me.PassBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PassBtn.FlatAppearance.BorderSize = 0
        Me.PassBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.PassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PassBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.seat
        Me.PassBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PassBtn.Location = New System.Drawing.Point(227, 211)
        Me.PassBtn.Name = "PassBtn"
        Me.PassBtn.Size = New System.Drawing.Size(100, 90)
        Me.PassBtn.TabIndex = 41
        Me.PassBtn.Text = "2"
        Me.PassBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PassBtn.UseVisualStyleBackColor = False
        '
        'Pass2Btn
        '
        Me.Pass2Btn.BackColor = System.Drawing.SystemColors.Control
        Me.Pass2Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass2Btn.FlatAppearance.BorderSize = 0
        Me.Pass2Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass2Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass2Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass2Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pass2Btn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.seat
        Me.Pass2Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Pass2Btn.Location = New System.Drawing.Point(119, 323)
        Me.Pass2Btn.Name = "Pass2Btn"
        Me.Pass2Btn.Size = New System.Drawing.Size(100, 90)
        Me.Pass2Btn.TabIndex = 42
        Me.Pass2Btn.Text = "3"
        Me.Pass2Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Pass2Btn.UseVisualStyleBackColor = False
        '
        'Pass3Btn
        '
        Me.Pass3Btn.BackColor = System.Drawing.SystemColors.Control
        Me.Pass3Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass3Btn.FlatAppearance.BorderSize = 0
        Me.Pass3Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass3Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass3Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Pass3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass3Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pass3Btn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.seat
        Me.Pass3Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Pass3Btn.Location = New System.Drawing.Point(227, 323)
        Me.Pass3Btn.Name = "Pass3Btn"
        Me.Pass3Btn.Size = New System.Drawing.Size(100, 90)
        Me.Pass3Btn.TabIndex = 43
        Me.Pass3Btn.Text = "4"
        Me.Pass3Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Pass3Btn.UseVisualStyleBackColor = False
        '
        'TempBox
        '
        Me.TempBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TempBox.Location = New System.Drawing.Point(61, 582)
        Me.TempBox.Name = "TempBox"
        Me.TempBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TempBox.Size = New System.Drawing.Size(109, 96)
        Me.TempBox.TabIndex = 44
        Me.TempBox.Text = "Inside Temp: 23°C" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Outside Temp: 14°C" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FanBox
        '
        Me.FanBox.Location = New System.Drawing.Point(176, 582)
        Me.FanBox.Name = "FanBox"
        Me.FanBox.Size = New System.Drawing.Size(100, 96)
        Me.FanBox.TabIndex = 45
        Me.FanBox.Text = "Fan 1: 0%" & Global.Microsoft.VisualBasic.ChrW(10) & "Fan 2: 0%" & Global.Microsoft.VisualBasic.ChrW(10) & "Fan 3: 0%" & Global.Microsoft.VisualBasic.ChrW(10) & "fan 4:  0%"
        '
        'SeatBox
        '
        Me.SeatBox.Location = New System.Drawing.Point(282, 582)
        Me.SeatBox.Name = "SeatBox"
        Me.SeatBox.Size = New System.Drawing.Size(100, 96)
        Me.SeatBox.TabIndex = 46
        Me.SeatBox.Text = "Heating Level " & Global.Microsoft.VisualBasic.ChrW(10) & "Seat 1: 0" & Global.Microsoft.VisualBasic.ChrW(10) & "Seat 2: 0" & Global.Microsoft.VisualBasic.ChrW(10) & "Seat 3: 0" & Global.Microsoft.VisualBasic.ChrW(10) & "Seat 4: 0" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SeatHeatBtn
        '
        Me.SeatHeatBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SeatHeatBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatHeatBtn.FlatAppearance.BorderSize = 0
        Me.SeatHeatBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatHeatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatHeatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatHeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeatHeatBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SeatHeatBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.SeatHeating
        Me.SeatHeatBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SeatHeatBtn.Location = New System.Drawing.Point(172, 525)
        Me.SeatHeatBtn.Name = "SeatHeatBtn"
        Me.SeatHeatBtn.Size = New System.Drawing.Size(47, 54)
        Me.SeatHeatBtn.TabIndex = 47
        Me.SeatHeatBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SeatHeatBtn.UseVisualStyleBackColor = False
        '
        'SeatCoolBtn
        '
        Me.SeatCoolBtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.SeatCoolBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatCoolBtn.FlatAppearance.BorderSize = 0
        Me.SeatCoolBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatCoolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatCoolBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SeatCoolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeatCoolBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SeatCoolBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.car_seat_cooler_icon_135818
        Me.SeatCoolBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SeatCoolBtn.Location = New System.Drawing.Point(225, 525)
        Me.SeatCoolBtn.Name = "SeatCoolBtn"
        Me.SeatCoolBtn.Size = New System.Drawing.Size(47, 54)
        Me.SeatCoolBtn.TabIndex = 48
        Me.SeatCoolBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SeatCoolBtn.UseVisualStyleBackColor = False
        '
        'ClimateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(444, 821)
        Me.Controls.Add(Me.SeatCoolBtn)
        Me.Controls.Add(Me.SeatHeatBtn)
        Me.Controls.Add(Me.SeatBox)
        Me.Controls.Add(Me.FanBox)
        Me.Controls.Add(Me.TempBox)
        Me.Controls.Add(Me.Pass3Btn)
        Me.Controls.Add(Me.Pass2Btn)
        Me.Controls.Add(Me.PassBtn)
        Me.Controls.Add(Me.DriverBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FanBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.EarningsBtn)
        Me.Controls.Add(Me.ProfileBtn)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.IntakeBtn)
        Me.Controls.Add(Me.TempBtn)
        Me.Controls.Add(Me.FanSlider)
        Me.Controls.Add(Me.TempSlider)
        Me.DoubleBuffered = True
        Me.Name = "ClimateControl"
        CType(Me.TempSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TempSlider As TrackBar
    Friend WithEvents FanSlider As TrackBar
    Friend WithEvents TempBtn As Button
    Friend WithEvents IntakeBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents EarningsBtn As Button
    Friend WithEvents ProfileBtn As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents FanBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DriverBtn As Button
    Friend WithEvents PassBtn As Button
    Friend WithEvents Pass2Btn As Button
    Friend WithEvents Pass3Btn As Button
    Friend WithEvents TempBox As RichTextBox
    Friend WithEvents FanBox As RichTextBox
    Friend WithEvents SeatBox As RichTextBox
    Friend WithEvents SeatHeatBtn As Button
    Friend WithEvents SeatCoolBtn As Button
End Class
