Public Class Series

    Private Sub Series_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        'Volcar las listas del List de Form1 a este listbox
        For Each serie As String In Form1.seriesVistas
            ListBox1.Items.Add(serie.Split("*"c)(0))
        Next
    End Sub

    Private Sub btnVerHBO_Click(sender As Object, e As EventArgs) Handles btnVerHBO.Click
        'limpiar el listbox
        ListBox1.Items.Clear()

        For Each serie As String In Form1.seriesVistas
            If serie.Split("*"c)(1) = "HBO" Then
                ListBox1.Items.Add(serie.Split("*"c)(0))
            End If
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Obtener el título de la serie seleccionada
        Dim titulo As String = ListBox1.SelectedItem.ToString

        For Each elemento As String In Form1.seriesVistas
            If elemento.Split("*"c)(0) = titulo Then
                'Vuelco los datos a las cajas de texto
                txtValoracion.Text = elemento.Split("*"c)(2)
                txtPlataforma.Text = elemento.Split("*"c)(1)
                txtFechaEstreno.Text = elemento.Split("*"c)(3)
            End If
        Next
    End Sub
End Class