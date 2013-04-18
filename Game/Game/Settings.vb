Public Class Settings

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Form1.Moeilijkheidsgraad = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Form1.Moeilijkheidsgraad = 2
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Form1.Moeilijkheidsgraad = 3
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Form1.Moeilijkheidsgraad = 4
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Form1.Moeilijkheidsgraad = 5
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.Moeilijkheidsgraad = 1 Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
        ElseIf Form1.Moeilijkheidsgraad = 2 Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
        ElseIf Form1.Moeilijkheidsgraad = 3 Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = True
            RadioButton4.Checked = False
            RadioButton5.Checked = False
        ElseIf Form1.Moeilijkheidsgraad = 4 Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = True
            RadioButton5.Checked = False
        ElseIf Form1.Moeilijkheidsgraad = 5 Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = True
        End If
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Label4.Text = "Value: " & TrackBar1.Value
    End Sub
End Class