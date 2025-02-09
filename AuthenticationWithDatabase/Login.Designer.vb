<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        Panel1 = New Panel()
        lblExit = New Label()
        PictureBox1 = New PictureBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblDaftar = New Label()
        btnLogin = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(96, 91)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 49)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME BACK"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(lblExit)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(561, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(582, 776)
        Panel1.TabIndex = 2
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.Cursor = Cursors.Hand
        lblExit.Font = New Font("FiraCode Nerd Font Mono", 13.1249981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExit.ForeColor = Color.Red
        lblExit.Location = New Point(533, 4)
        lblExit.Margin = New Padding(5, 0, 5, 0)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(41, 43)
        lblExit.TabIndex = 4
        lblExit.Text = "X"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.imphnen_simple
        PictureBox1.Location = New Point(0, 91)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(580, 580)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(96, 336)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(372, 43)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(96, 459)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(372, 43)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("FiraCode Nerd Font Mono", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(96, 300)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 33)
        Label2.TabIndex = 5
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("FiraCode Nerd Font Mono", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(96, 423)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 33)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(96, 713)
        Label4.Name = "Label4"
        Label4.Size = New Size(285, 25)
        Label4.TabIndex = 7
        Label4.Text = "Belum mempunyai akun?"
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Cursor = Cursors.Hand
        lblDaftar.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDaftar.ForeColor = SystemColors.MenuHighlight
        lblDaftar.Location = New Point(378, 713)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(90, 25)
        lblDaftar.TabIndex = 8
        lblDaftar.Text = "Daftar"
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.BackColor = SystemColors.MenuHighlight
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("FiraCode Nerd Font", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(96, 550)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(372, 51)
        btnLogin.TabIndex = 9
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(22F, 54F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1140, 775)
        Controls.Add(btnLogin)
        Controls.Add(lblDaftar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 15F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblExit As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDaftar As Label
    Friend WithEvents btnLogin As Button
End Class
