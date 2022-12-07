Module Funciones
    'by ramonrs
    'Función que llena un array con números aleatorios
    Sub generarArray(ByRef matriz() As Integer)
        Dim aleatorio As New Random
        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = aleatorio.Next()
        Next
    End Sub
    Sub generarArray(ByRef matriz() As Integer, ByVal limitUp As Integer)
        Dim aleatorio As New Random
        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = aleatorio.Next(limitUp)
        Next
    End Sub

    'Función que muestra un array por Consola
    Sub mostrarArray(ByRef matriz() As Integer)

        For Each valor As Integer In matriz
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
