Public Class Form1
    'Declaración variables globales
    Dim nombre As String

    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        'Recoger el nombre que el usuario inttrodujo en la caja de texto
        nombre = txtNombre.Text
        MessageBox.Show("Hola " & nombre)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnContarLetras.Click
        Dim numeroLetras As Integer = nombre.Length
        MessageBox.Show(nombre + " tiene " + numeroLetras.ToString + " letras")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

End Class
