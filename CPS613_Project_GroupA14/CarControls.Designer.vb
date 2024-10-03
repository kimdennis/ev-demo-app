<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarControls
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
        Me.BatteryIndicator1 = New CPS613_Project_GroupA14.BatteryIndicator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.EarningsBtn = New System.Windows.Forms.Button()
        Me.ProfileBtn = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.ClimateBtn = New System.Windows.Forms.Button()
        Me.ChargingBtn = New System.Windows.Forms.Button()
        Me.MediaBtn = New System.Windows.Forms.Button()
        Me.FrontLabel = New System.Windows.Forms.Label()
        Me.BackLabel = New System.Windows.Forms.Label()
        Me.FrontOpenBtn = New System.Windows.Forms.Button()
        Me.BackOpenBtn = New System.Windows.Forms.Button()
        Me.TrunkBtn = New System.Windows.Forms.Button()
        Me.FrontWText = New System.Windows.Forms.Label()
        Me.BackWText = New System.Windows.Forms.Label()
        Me.TrunkText = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BatteryIndicator1
        '
        Me.BatteryIndicator1.Increment = 7840
        Me.BatteryIndicator1.Location = New System.Drawing.Point(102, 632)
        Me.BatteryIndicator1.Name = "BatteryIndicator1"
        Me.BatteryIndicator1.Size = New System.Drawing.Size(240, 30)
        Me.BatteryIndicator1.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(58, 685)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 2)
        Me.PictureBox1.TabIndex = 24
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
        Me.SettingsBtn.Location = New System.Drawing.Point(304, 696)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(70, 57)
        Me.SettingsBtn.TabIndex = 23
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
        Me.EarningsBtn.Location = New System.Drawing.Point(227, 696)
        Me.EarningsBtn.Name = "EarningsBtn"
        Me.EarningsBtn.Size = New System.Drawing.Size(70, 57)
        Me.EarningsBtn.TabIndex = 22
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
        Me.ProfileBtn.Location = New System.Drawing.Point(150, 696)
        Me.ProfileBtn.Name = "ProfileBtn"
        Me.ProfileBtn.Size = New System.Drawing.Size(70, 57)
        Me.ProfileBtn.TabIndex = 21
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
        Me.HomeBtn.Location = New System.Drawing.Point(73, 696)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(70, 57)
        Me.HomeBtn.TabIndex = 20
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'ClimateBtn
        '
        Me.ClimateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClimateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClimateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClimateBtn.FlatAppearance.BorderSize = 0
        Me.ClimateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClimateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClimateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClimateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClimateBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClimateBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.control
        Me.ClimateBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClimateBtn.Location = New System.Drawing.Point(76, 99)
        Me.ClimateBtn.Name = "ClimateBtn"
        Me.ClimateBtn.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.ClimateBtn.Size = New System.Drawing.Size(94, 165)
        Me.ClimateBtn.TabIndex = 26
        Me.ClimateBtn.Text = "Climate Control"
        Me.ClimateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClimateBtn.UseVisualStyleBackColor = False
        '
        'ChargingBtn
        '
        Me.ChargingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChargingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChargingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChargingBtn.FlatAppearance.BorderSize = 0
        Me.ChargingBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChargingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ChargingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ChargingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChargingBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChargingBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.charging
        Me.ChargingBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ChargingBtn.Location = New System.Drawing.Point(175, 99)
        Me.ChargingBtn.Name = "ChargingBtn"
        Me.ChargingBtn.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.ChargingBtn.Size = New System.Drawing.Size(94, 165)
        Me.ChargingBtn.TabIndex = 27
        Me.ChargingBtn.Text = "Charging"
        Me.ChargingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ChargingBtn.UseVisualStyleBackColor = False
        '
        'MediaBtn
        '
        Me.MediaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MediaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MediaBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MediaBtn.FlatAppearance.BorderSize = 0
        Me.MediaBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MediaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MediaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MediaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MediaBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MediaBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.music
        Me.MediaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MediaBtn.Location = New System.Drawing.Point(275, 99)
        Me.MediaBtn.Name = "MediaBtn"
        Me.MediaBtn.Padding = New System.Windows.Forms.Padding(0, 17, 0, 10)
        Me.MediaBtn.Size = New System.Drawing.Size(94, 165)
        Me.MediaBtn.TabIndex = 28
        Me.MediaBtn.Text = "Media"
        Me.MediaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MediaBtn.UseVisualStyleBackColor = False
        '
        'FrontLabel
        '
        Me.FrontLabel.AutoSize = True
        Me.FrontLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FrontLabel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.FrontLabel.Location = New System.Drawing.Point(74, 305)
        Me.FrontLabel.Name = "FrontLabel"
        Me.FrontLabel.Size = New System.Drawing.Size(137, 22)
        Me.FrontLabel.TabIndex = 29
        Me.FrontLabel.Text = "Front Windows"
        '
        'BackLabel
        '
        Me.BackLabel.AutoSize = True
        Me.BackLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackLabel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BackLabel.Location = New System.Drawing.Point(236, 305)
        Me.BackLabel.Name = "BackLabel"
        Me.BackLabel.Size = New System.Drawing.Size(134, 22)
        Me.BackLabel.TabIndex = 30
        Me.BackLabel.Text = "Back Windows"
        '
        'FrontOpenBtn
        '
        Me.FrontOpenBtn.BackColor = System.Drawing.Color.White
        Me.FrontOpenBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FrontOpenBtn.FlatAppearance.BorderSize = 0
        Me.FrontOpenBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FrontOpenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FrontOpenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FrontOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FrontOpenBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FrontOpenBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.windowdown
        Me.FrontOpenBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FrontOpenBtn.Location = New System.Drawing.Point(93, 330)
        Me.FrontOpenBtn.Name = "FrontOpenBtn"
        Me.FrontOpenBtn.Size = New System.Drawing.Size(70, 73)
        Me.FrontOpenBtn.TabIndex = 31
        Me.FrontOpenBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FrontOpenBtn.UseVisualStyleBackColor = False
        '
        'BackOpenBtn
        '
        Me.BackOpenBtn.BackColor = System.Drawing.Color.White
        Me.BackOpenBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BackOpenBtn.FlatAppearance.BorderSize = 0
        Me.BackOpenBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BackOpenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BackOpenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BackOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackOpenBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackOpenBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.windowdown
        Me.BackOpenBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BackOpenBtn.Location = New System.Drawing.Point(281, 330)
        Me.BackOpenBtn.Name = "BackOpenBtn"
        Me.BackOpenBtn.Size = New System.Drawing.Size(70, 57)
        Me.BackOpenBtn.TabIndex = 33
        Me.BackOpenBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BackOpenBtn.UseVisualStyleBackColor = False
        '
        'TrunkBtn
        '
        Me.TrunkBtn.BackColor = System.Drawing.Color.White
        Me.TrunkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TrunkBtn.FlatAppearance.BorderSize = 0
        Me.TrunkBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TrunkBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TrunkBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TrunkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrunkBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TrunkBtn.Image = Global.CPS613_Project_GroupA14.My.Resources.Resources.boot
        Me.TrunkBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrunkBtn.Location = New System.Drawing.Point(187, 460)
        Me.TrunkBtn.Name = "TrunkBtn"
        Me.TrunkBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrunkBtn.Size = New System.Drawing.Size(70, 57)
        Me.TrunkBtn.TabIndex = 35
        Me.TrunkBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TrunkBtn.UseVisualStyleBackColor = False
        '
        'FrontWText
        '
        Me.FrontWText.AutoSize = True
        Me.FrontWText.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FrontWText.Location = New System.Drawing.Point(76, 406)
        Me.FrontWText.Name = "FrontWText"
        Me.FrontWText.Size = New System.Drawing.Size(104, 19)
        Me.FrontWText.TabIndex = 36
        Me.FrontWText.Text = "Open Windows"
        '
        'BackWText
        '
        Me.BackWText.AutoSize = True
        Me.BackWText.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackWText.Location = New System.Drawing.Point(256, 406)
        Me.BackWText.Name = "BackWText"
        Me.BackWText.Size = New System.Drawing.Size(104, 19)
        Me.BackWText.TabIndex = 37
        Me.BackWText.Text = "Open Windows"
        '
        'TrunkText
        '
        Me.TrunkText.AutoSize = True
        Me.TrunkText.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TrunkText.Location = New System.Drawing.Point(181, 520)
        Me.TrunkText.Name = "TrunkText"
        Me.TrunkText.Size = New System.Drawing.Size(82, 19)
        Me.TrunkText.TabIndex = 38
        Me.TrunkText.Text = "Open Trunk"
        '
        'CarControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(444, 821)
        Me.Controls.Add(Me.TrunkText)
        Me.Controls.Add(Me.BackWText)
        Me.Controls.Add(Me.FrontWText)
        Me.Controls.Add(Me.TrunkBtn)
        Me.Controls.Add(Me.BackOpenBtn)
        Me.Controls.Add(Me.FrontOpenBtn)
        Me.Controls.Add(Me.BackLabel)
        Me.Controls.Add(Me.FrontLabel)
        Me.Controls.Add(Me.MediaBtn)
        Me.Controls.Add(Me.ChargingBtn)
        Me.Controls.Add(Me.ClimateBtn)
        Me.Controls.Add(Me.BatteryIndicator1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.EarningsBtn)
        Me.Controls.Add(Me.ProfileBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.DoubleBuffered = True
        Me.Name = "CarControls"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BatteryIndicator1 As BatteryIndicator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents EarningsBtn As Button
    Friend WithEvents ProfileBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents ClimateBtn As Button
    Friend WithEvents ChargingBtn As Button
    Friend WithEvents MediaBtn As Button
    Friend WithEvents FrontLabel As Label
    Friend WithEvents BackLabel As Label
    Friend WithEvents FrontOpenBtn As Button
    Friend WithEvents BackOpenBtn As Button
    Friend WithEvents TrunkBtn As Button
    Friend WithEvents FrontWText As Label
    Friend WithEvents BackWText As Label
    Friend WithEvents TrunkText As Label
End Class
