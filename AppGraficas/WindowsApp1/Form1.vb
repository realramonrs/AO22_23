Public Class Form1

    'Región variables globales del formulario
    Dim dni As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cambiar color de fondo del formulario
        Me.BackColor = Color.Red
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Cambio sorpresa"
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.Left += 150
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Abrir el Formulario 2
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Recoger el texto introducido por el usuario
        dni = TextBox1.Text
        'Validar si tiene 9 caracteres
        If dni.Length = 9 Then
            MessageBox.Show("DNI correcto")
        Else
            TextBox1.ForeColor = Color.Red
            TextBox1.Focus()
        End If
    End Sub
End Class
