Public Class SplashScreenForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(1)
        lblPercentage.Text = ProgressBar.Value & "%"

        If (ProgressBar.Value = 100) Then
            Timer1.Stop()
            Timer1.Enabled = False

            'Hide the current form
            Me.Hide()

            'Show the next form
            Login.Show()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enable the timer
        Timer1.Enabled = True
        'Start the timer
        Timer1.Start()
    End Sub
End Class