Public Class MainMenu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not TextBox1.Text = "" Then
            Form1.UserName = TextBox1.Text
            TextBox1.Enabled = False
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Please enter your name!", MsgBoxStyle.Information, "Enter name!")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Settings.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AboutUS.Show()
    End Sub
End Class