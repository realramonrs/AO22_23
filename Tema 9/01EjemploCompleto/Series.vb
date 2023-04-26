Public Class Series
    Private Sub Series_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        'Volcar las listas del List de Form1 a este listbox
        For Each serie As String In Form1.seriesVistas
            ListBox1.Items.Add(serie.Split("*"c)(0))
        Next
    End Sub
End Class