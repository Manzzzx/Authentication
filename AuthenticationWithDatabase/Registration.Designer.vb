<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        btnRegis = New Button()
        lblLogin = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label1 = New Label()
        lblExit = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label = New Label()
        txtName = New TextBox()
        Label5 = New Label()
        txtConfirmPassword = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRegis
        ' 
        btnRegis.AutoSize = True
        btnRegis.BackColor = SystemColors.MenuHighlight
        btnRegis.Cursor = Cursors.Hand
        btnRegis.FlatStyle = FlatStyle.Flat
        btnRegis.Font = New Font("FiraCode Nerd Font", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegis.ForeColor = Color.White
        btnRegis.Location = New Point(661, 552)
        btnRegis.Name = "btnRegis"
        btnRegis.Size = New Size(372, 51)
        btnRegis.TabIndex = 17
        btnRegis.Text = "Daftar"
        btnRegis.UseVisualStyleBackColor = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Cursor = Cursors.Hand
        lblLogin.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.ForeColor = SystemColors.MenuHighlight
        lblLogin.Location = New Point(939, 677)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(77, 25)
        lblLogin.TabIndex = 16
        lblLogin.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(674, 677)
        Label4.Name = "Label4"
        Label4.Size = New Size(272, 25)
        Label4.TabIndex = 15
        Label4.Text = "Sudah memiliki akun?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(661, 331)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 25)
        Label3.TabIndex = 14
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(661, 241)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 25)
        Label2.TabIndex = 13
        Label2.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(661, 359)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(372, 43)
        txtPassword.TabIndex = 12
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(661, 269)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(372, 43)
        txtUsername.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(661, 55)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 49)
        Label1.TabIndex = 10
        Label1.Text = "BUAT AKUN BARU"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.Cursor = Cursors.Hand
        lblExit.Font = New Font("FiraCode Nerd Font Mono", 13.1249981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExit.ForeColor = Color.Red
        lblExit.Location = New Point(1069, 6)
        lblExit.Margin = New Padding(5, 0, 5, 0)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(41, 43)
        lblExit.TabIndex = 18
        lblExit.Text = "X"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(571, 758)
        Panel1.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.imphnen_simple
        PictureBox1.Location = New Point(3, 64)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(569, 580)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label.Location = New Point(661, 150)
        Label.Name = "Label"
        Label.Size = New Size(64, 25)
        Label.TabIndex = 21
        Label.Text = "Nama"
        ' 
        ' txtName
        ' 
        txtName.Cursor = Cursors.IBeam
        txtName.Font = New Font("Segoe UI", 10F)
        txtName.Location = New Point(661, 178)
        txtName.Name = "txtName"
        txtName.Size = New Size(372, 43)
        txtName.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("FiraCode Nerd Font Mono", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(661, 418)
        Label5.Name = "Label5"
        Label5.Size = New Size(259, 25)
        Label5.TabIndex = 23
        Label5.Text = "Konfirmasi Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Cursor = Cursors.IBeam
        txtConfirmPassword.Font = New Font("Segoe UI", 10F)
        txtConfirmPassword.Location = New Point(661, 446)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(372, 43)
        txtConfirmPassword.TabIndex = 22
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' Registration
        ' 
        AutoScaleDimensions = New SizeF(25F, 49F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1115, 758)
        Controls.Add(Label5)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label)
        Controls.Add(txtName)
        Controls.Add(Panel1)
        Controls.Add(lblExit)
        Controls.Add(btnRegis)
        Controls.Add(lblLogin)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Font = New Font("FiraCode Nerd Font", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6, 5, 6, 5)
        Name = "Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegis As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfirmPassword As TextBox
End Class
