<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alert
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AlertIcon = New System.Windows.Forms.PictureBox()
        Me.DismissAlertBtn = New System.Windows.Forms.Button()
        Me.FollowAlertBtn = New System.Windows.Forms.Button()
        Me.AlertName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DismissInfo = New System.Windows.Forms.Label()
        CType(Me.AlertIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlertIcon
        '
        Me.AlertIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AlertIcon.Location = New System.Drawing.Point(100, 133)
        Me.AlertIcon.Name = "AlertIcon"
        Me.AlertIcon.Size = New System.Drawing.Size(128, 128)
        Me.AlertIcon.TabIndex = 0
        Me.AlertIcon.TabStop = False
        '
        'DismissAlertBtn
        '
        Me.DismissAlertBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DismissAlertBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DismissAlertBtn.FlatAppearance.BorderSize = 0
        Me.DismissAlertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DismissAlertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DismissAlertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DismissAlertBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DismissAlertBtn.Location = New System.Drawing.Point(34, 380)
        Me.DismissAlertBtn.Name = "DismissAlertBtn"
        Me.DismissAlertBtn.Size = New System.Drawing.Size(260, 40)
        Me.DismissAlertBtn.TabIndex = 1
        Me.DismissAlertBtn.Text = "Dismiss"
        Me.DismissAlertBtn.UseVisualStyleBackColor = False
        '
        'FollowAlertBtn
        '
        Me.FollowAlertBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FollowAlertBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FollowAlertBtn.FlatAppearance.BorderSize = 0
        Me.FollowAlertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FollowAlertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FollowAlertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FollowAlertBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FollowAlertBtn.Location = New System.Drawing.Point(34, 331)
        Me.FollowAlertBtn.Name = "FollowAlertBtn"
        Me.FollowAlertBtn.Size = New System.Drawing.Size(260, 40)
        Me.FollowAlertBtn.TabIndex = 2
        Me.FollowAlertBtn.UseVisualStyleBackColor = False
        '
        'AlertName
        '
        Me.AlertName.AutoSize = True
        Me.AlertName.BackColor = System.Drawing.Color.Transparent
        Me.AlertName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AlertName.Location = New System.Drawing.Point(46, 283)
        Me.AlertName.Name = "AlertName"
        Me.AlertName.Size = New System.Drawing.Size(0, 25)
        Me.AlertName.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CPS613_Project_GroupA14.My.Resources.Resources.iconInformation
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(34, 429)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'DismissInfo
        '
        Me.DismissInfo.AutoSize = True
        Me.DismissInfo.Location = New System.Drawing.Point(51, 430)
        Me.DismissInfo.MaximumSize = New System.Drawing.Size(260, 50)
        Me.DismissInfo.Name = "DismissInfo"
        Me.DismissInfo.Size = New System.Drawing.Size(0, 15)
        Me.DismissInfo.TabIndex = 10
        '
        'Alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DismissInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AlertName)
        Me.Controls.Add(Me.FollowAlertBtn)
        Me.Controls.Add(Me.DismissAlertBtn)
        Me.Controls.Add(Me.AlertIcon)
        Me.Name = "Alert"
        Me.Size = New System.Drawing.Size(329, 584)
        CType(Me.AlertIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlertIcon As PictureBox
    Friend WithEvents DismissAlertBtn As Button
    Friend WithEvents FollowAlertBtn As Button
    Friend WithEvents AlertName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DismissInfo As Label
End Class
