Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Visible = True
        Timer1.Start()
        ProgressBar1.Show()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        ElseIf TextBox1.Text = "Niyati" And TextBox2.Text = "123" Then
            Timer1.Stop()
            MsgBox("Login Successful")
            ProgressBar1.Value = 0
            Button1.Enabled = True
            ProgressBar1.Visible = False
        Else
            Timer1.Stop()
            MsgBox("Not a valid username or password !! Try Again")
            Button1.Enabled = True
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
        End If
    End Sub
End Class
