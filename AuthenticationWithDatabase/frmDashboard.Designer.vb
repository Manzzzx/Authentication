<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        btnLogout = New Button()
        Label1 = New Label()
        lblExit = New Label()
        Label2 = New Label()
        lblUsername = New Label()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.AutoSize = True
        btnLogout.BackColor = SystemColors.MenuHighlight
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = SystemColors.HighlightText
        btnLogout.Location = New Point(32, 627)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(246, 58)
        btnLogout.TabIndex = 14
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(62, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 54)
        Label1.TabIndex = 13
        Label1.Text = "Dashboard"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.Cursor = Cursors.Hand
        lblExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblExit.ForeColor = Color.Red
        lblExit.Location = New Point(1049, 10)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(41, 45)
        lblExit.TabIndex = 19
        lblExit.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.Location = New Point(712, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 37)
        Label2.TabIndex = 20
        Label2.Text = "Current User:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10F)
        lblUsername.ForeColor = SystemColors.MenuHighlight
        lblUsername.Location = New Point(889, 60)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(132, 37)
        lblUsername.TabIndex = 21
        lblUsername.Text = "username"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(20F, 50F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 720)
        Controls.Add(lblUsername)
        Controls.Add(Label2)
        Controls.Add(lblExit)
        Controls.Add(btnLogout)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 14F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
End Class
