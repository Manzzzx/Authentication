<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        ProgressBar = New ProgressBar()
        lblPercentage = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(219, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 49)
        Label1.TabIndex = 0
        Label1.Text = "Authentication"
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(103, 215)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(458, 46)
        ProgressBar.TabIndex = 1
        ' 
        ' lblPercentage
        ' 
        lblPercentage.AutoSize = True
        lblPercentage.Font = New Font("FiraCode Nerd Font Mono", 10.124999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPercentage.ForeColor = SystemColors.MenuHighlight
        lblPercentage.Location = New Point(580, 222)
        lblPercentage.Name = "lblPercentage"
        lblPercentage.Size = New Size(117, 33)
        lblPercentage.TabIndex = 2
        lblPercentage.Text = "Label2"
        ' 
        ' Timer1
        ' 
        ' 
        ' SplashScreenForm
        ' 
        AutoScaleDimensions = New SizeF(25F, 49F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(791, 317)
        Controls.Add(lblPercentage)
        Controls.Add(ProgressBar)
        Controls.Add(Label1)
        Font = New Font("FiraCode Nerd Font Mono", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6, 5, 6, 5)
        Name = "SplashScreenForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents lblPercentage As Label
    Friend WithEvents Timer1 As Timer
End Class
