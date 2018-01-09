Public Class Form1
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pboxReceiver.Click

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Dim bonus
        bonus = CInt(0) + 1
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

        While (Collision(pboxReceiver, pboxBall) = True)
            lblScore.Text = "Score: " & bonus + 1
        End While
        For Each (
 Next
        lblDefendScore.Text = "Score: " & bonus
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
