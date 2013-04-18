Public Class Form1

    Dim key As String
    Dim Schiet As Boolean = False
    Dim Jump As Integer
    Dim Getal As Integer
    Public UserName As String
    Public Moeilijkheidsgraad As Integer
    Public Points As Integer

    Dim ZombieSnelheid As Integer = 2
    Dim BullSpeed As Integer = 13

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label2.Text = "Moeilijkheid: Easy"

        If Settings.RadioButton1.Checked = True Then
            ZombieSnelheid = 2
            Label2.Text = "Moeilijkheidsgraad: Heel Makkelijk"
            Stats.Label5.Text = "Heel Makkelijk"
        ElseIf Settings.RadioButton2.Checked = True Then
            ZombieSnelheid = 3
            Label2.Text = "Moeilijkheidsgraad: Makkelijk"
            Stats.Label5.Text = "Makkelijk"
        ElseIf Settings.RadioButton3.Checked = True Then
            ZombieSnelheid = 4
            Label2.Text = "Moeilijkheidsgraad: Gemiddeld"
            Stats.Label5.Text = "Gemiddeld"
        ElseIf Settings.RadioButton4.Checked = True Then
            ZombieSnelheid = 5
            Label2.Text = "Moeilijkheidsgraad: Moeilijk"
            Stats.Label5.Text = "Moeilijk"
        ElseIf Settings.RadioButton5.Checked = True Then
            ZombieSnelheid = 6
            Label2.Text = "Moeilijkheidsgraad: Heel Moeilijk"
            Stats.Label5.Text = "Heel Moeilijk"
        End If


        Timer3.Start()
        Timer2.Start()
        SetInvader()
        Button1.Select()

    End Sub

    Private Sub Button1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        CheckKey(e)
    End Sub

    Public Sub SetInvader()
        Randomize()
        Getal = Int(Rnd() * 400)
        picturebox1.Top = -30
        picturebox1.Left = Getal
    End Sub

    Public Sub CheckKey(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.D Then
            Timer1.Start()
            key = "D"
        End If
        If e.KeyCode = Keys.A Then
            Timer1.Start()
            key = "A"
        End If
        If e.KeyCode = Keys.Space Then
            OvalShape1.Show()
            Schiet = True
            My.Computer.Audio.Play(My.Resources.shooting2, AudioPlayMode.Background)
        End If
        If e.KeyValue = Keys.E Then
            DisableBull()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Schiet = False Then
            OvalShape1.Left = Button1.Left + 6
        End If

        If Jump >= 1 Then
            Jump = Jump - 1
        End If

        If key = "D" Then
            If Not Button1.Left + 55 >= 530 Then
                Button1.Left = Button1.Left + Settings.TrackBar1.Value
            End If
        End If

        If key = "A" Then
            If Not Button1.Left <= 1 Then
                Button1.Left = Button1.Left - Settings.TrackBar1.Value
            End If
        End If

    End Sub

    Private Sub Button1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyUp
        If Not e.KeyValue = Keys.Space Then
            Timer1.Stop()
            key = ""
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Schiet = True Then
            OvalShape1.Top = OvalShape1.Top - BullSpeed
        End If
        If OvalShape1.Top <= -13 Then
            DisableBull()
        End If
    End Sub

    Public Sub DisableBull()
        OvalShape1.Hide()
        Schiet = False
        OvalShape1.Top = Button1.Top
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        picturebox1.Top = picturebox1.Top + ZombieSnelheid

        If OvalShape1.Left + 12 >= picturebox1.Left Then
            If OvalShape1.Left <= PictureBox1.Left + 65 Then
                If OvalShape1.Top <= PictureBox1.Top + 23 Then
                    If Not OvalShape1.Top = 394 Then

                        Points = Points + 1
                        Label1.Text = "Points: " & Points
                        Stats.Label7.Text = Points

                        My.Computer.Audio.Play(My.Resources.Kill2, AudioPlayMode.Background)

                        DisableBull()
                        SetInvader()
                    End If
                End If
            End If
        End If

        If PictureBox1.Top >= 400 Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Me.Close()
            Stats.Show()
        End If

    End Sub
End Class
