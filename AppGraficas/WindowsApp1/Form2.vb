Public Class Form2
    Dim generador As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TextBox1.Text = generador.Next(1, 31)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.A) Then
            TextBox1.Left -= 20
            Me.Left -= 20
        ElseIf e.KeyChar = Convert.ToChar(Keys.w) Then
            TextBox1.Top -= 20
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class