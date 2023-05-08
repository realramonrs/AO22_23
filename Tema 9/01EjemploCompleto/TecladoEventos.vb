Public Class TecladoEventos
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        'Obtener la 
    End Sub

    Private Sub TecladoEventos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Label1.Text = "Tecla Pulsada "
        'Label2.Text = "Código caracter: "
        'Dim caracter As String = e.KeyValue.ToString
        'Label2.Text += caracter
        'Label1.Text += Convert.ToChar(e.KeyValue)

    End Sub

    Private Sub TecladoEventos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Label1.Text = "Tecla Pulsada "
        Label2.Text = "Código caracter: "
        Dim letra As Char = e.KeyChar
        Label1.Text += letra
        Label2.Text += Convert.ToInt32(letra).ToString()
    End Sub
End Class