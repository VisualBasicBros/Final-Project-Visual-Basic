Public Class Form1
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pboxReceiver.Click

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim totalScore As Integer
        Dim totalScore2 As Integer
        Dim score

        totalScore = CInt(0) + 1
        score = CInt(0)
        'sets controls for defender and receiver
        If e.KeyCode = Keys.D Then
            pboxReceiver.Left += 10
        ElseIf e.KeyCode = Keys.A Then
            pboxReceiver.Left -= 10
        ElseIf e.KeyCode = Keys.W Then
            pboxReceiver.Top -= 10
        ElseIf e.KeyCode = Keys.S Then
            pboxReceiver.Top += 10
        End If

        If e.KeyCode = Keys.Right Then
            pboxDefender.Left += 10
        ElseIf e.KeyCode = Keys.Left Then
            pboxDefender.Left -= 10
        ElseIf e.KeyCode = Keys.Up Then
            pboxDefender.Top -= 10
        ElseIf e.KeyCode = Keys.Down Then
            pboxDefender.Top += 10
        End If
        'Sets the score for when the two characters collide with eachother
        If (Collision(pboxReceiver, pboxBall) = True) Then
            lblScore.Text = "Receiver Score: " + totalScore.ToString
        End If

        If (Collision(pboxReceiver, pboxDefender) = True) Then
            lblDefendScore.Text = "Defender Score: " + totalScore2.ToString
        End If
        'This if statement randomizes the placement of the ball on the canvas
        If Collision(pboxReceiver, pboxBall) = True Then
            pboxBall.Top = Int(Rnd() * (520 - 2 * pboxBall.Height) + pboxBall.Height)
            pboxBall.Left = Int(Rnd() * (550 - 2 * pboxBall.Width) + pboxBall.Width)
            Debug.WriteLine("Ball top: " & pboxBall.Top)
            Debug.WriteLine("Ball left: " & pboxBall.Left)
            lblScore.Text = "Receiver Score: " & score
        End If

     


    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles pboxDefender.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub
    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        'Collision function
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
                Object2.Top + Object2.Height >= Object1.Top And
                Object1.Left + Object1.Width >= Object2.Left And
                Object2.Left + Object2.Width >= Object1.Left Then
            Collided = True
        End If
        Return Collided

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'An array of the other pictureboxes, Incomplete
        Dim arr As System.Windows.Forms.PictureBox() = New PictureBox() {}
        arr(0) = New PictureBox()
        arr(1) = New PictureBox()
        arr(2) = New PictureBox()
        arr(3) = New PictureBox()
        arr(4) = New PictureBox()
        arr(5) = New PictureBox()
        arr(6) = New PictureBox()
        arr(7) = New PictureBox()
        arr(8) = New PictureBox()
        arr(9) = New PictureBox()
        arr(10) = New PictureBox()
        arr(11) = New PictureBox()
        arr(12) = New PictureBox()
        arr(13) = New PictureBox()
        arr(14) = New PictureBox()
        arr(15) = New PictureBox()
        arr(16) = New PictureBox()
        While Collision(pboxBall, pboxReceiver) = True
            arr(17).Top = Int(Rnd() * (520 - 2 * arr(17).Height) + pboxBall.Height)
            arr(17).Left = Int(Rnd() * (550 - 2 * arr(17).Width) + pboxBall.Width)
            Debug.WriteLine("Ball top: " & arr(17).Top)
            Debug.WriteLine("Ball left: " & arr(17).Left)
        End While


    End Sub
End Class
