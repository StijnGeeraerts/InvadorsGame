Public Class Stats

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Button2.Select()
        Label3.Text = MainMenu.TextBox1.Text

    End Sub
End Class