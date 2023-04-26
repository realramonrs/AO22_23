Public Class Form1
    'Zona declaración variables globales a Form1
    Public seriesVistas As New List(Of String)

    Private Sub btnGuardarSerie_Click(sender As Object, e As EventArgs) Handles btnGuardarSerie.Click
        Dim titulo, plataforma As String
        Dim valoracion As Double
        Dim fechaEstreno As Date
        Dim correcto As Boolean = True
        'Guardar datos introducidos por el usuario
        If txtTitulo.Text <> "" Then
            titulo = txtTitulo.Text
        Else
            txtTitulo.BackColor = Color.Beige
            Me.ActiveControl = txtTitulo
            MessageBox.Show("El título es obligatorio")
            correcto = False
        End If

        plataforma = txtPlataforma.Text

        'Validar valoracion
        Try
            valoracion = Convert.ToDouble(txtValoracion.Text)

            'Valido que sea un número entre 1 y 10
            If valoracion < 1 Or valoracion > 10 Then
                txtValoracion.BackColor = Color.Firebrick
                txtValoracion.SelectAll()
                Me.ActiveControl = txtValoracion
                correcto = False

                txtValoracion.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                MessageBox.Show("La valoración debe estar entre 1 y 10")
            End If

        Catch ex As Exception
            txtValoracion.BackColor = Color.Firebrick
            txtValoracion.SelectAll()
            Me.ActiveControl = txtValoracion
            correcto = False
            MessageBox.Show("La valoración debe ser numérica")
        End Try
        fechaEstreno = dtpFechaEstreno.Value

        If correcto Then
            'Creo el String que quiero guardar en la lista
            Dim registro As String = titulo + "*" + plataforma + "*" + valoracion.ToString + "*" + fechaEstreno.ToShortDateString
            'Añado a la lista
            seriesVistas.Add(registro)

            MessageBox.Show("Serie guardada con éxito")
        End If

    End Sub

    Private Sub btnAbrirConsultaSeries_Click(sender As Object, e As EventArgs) Handles btnAbrirConsultaSeries.Click
        Series.ShowDialog()
    End Sub
End Class
