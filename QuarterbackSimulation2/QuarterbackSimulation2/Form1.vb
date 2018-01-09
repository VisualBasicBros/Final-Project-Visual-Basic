Public Class Form1
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pboxReceiver.Click

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Dim bonus

        bonus = CInt(0)
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

        If (Collision(pboxReceiver, pboxBall) = True) Then
            lblScore.Text = "Receiver Score: " & bonus + ++1
        End If

        If (Collision(pboxReceiver, pboxDefender) = True) Then
            lblDefendScore.Text = "Defender Score: " & bonus + 1
        End If
        If Collision(pboxReceiver, pboxBall) = True Then
            pboxBall.Top = Int(Rnd() * (520 - 2 * pboxBall.Height) + pboxBall.Height)
            pboxBall.Left = Int(Rnd() * (550 - 2 * pboxBall.Width) + pboxBall.Width)
            Debug.WriteLine("Ball top: " & pboxBall.Top)
            Debug.WriteLine("Ball left: " & pboxBall.Left)
            bonus = bonus + 1
            lblScore.Text = "Receiver Score: " & bonus
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles pboxDefender.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub
    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
                Object2.Top + Object2.Height >= Object1.Top And
                Object1.Left + Object1.Width >= Object2.Left And
                Object2.Left + Object2.Width >= Object1.Left Then
            Collided = True
        End If
        Return Collided = True

    End Function
End Class
