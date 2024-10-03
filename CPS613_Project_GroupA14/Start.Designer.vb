<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.OwnerBtn = New System.Windows.Forms.Button()
        Me.RiderBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OwnerBtn
        '
        Me.OwnerBtn.Location = New System.Drawing.Point(50, 98)
        Me.OwnerBtn.Name = "OwnerBtn"
        Me.OwnerBtn.Size = New System.Drawing.Size(331, 186)
        Me.OwnerBtn.TabIndex = 0
        Me.OwnerBtn.Text = "Owner"
        Me.OwnerBtn.UseVisualStyleBackColor = True
        '
        'RiderBtn
        '
        Me.RiderBtn.Location = New System.Drawing.Point(419, 98)
        Me.RiderBtn.Name = "RiderBtn"
        Me.RiderBtn.Size = New System.Drawing.Size(331, 186)
        Me.RiderBtn.TabIndex = 1
        Me.RiderBtn.Text = "Rider"
        Me.RiderBtn.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RiderBtn)
        Me.Controls.Add(Me.OwnerBtn)
        Me.Name = "Start"
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OwnerBtn As Button
    Friend WithEvents RiderBtn As Button
End Class
