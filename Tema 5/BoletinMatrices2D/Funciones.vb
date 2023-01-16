Module Funciones

    Public Sub generarMatriz2D(ByRef matriz(,) As Integer, ByVal limiteInf As Integer, ByVal limiteSuperior As Integer)
        Dim aleatorio As New Random

        For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                matriz(i, j) = aleatorio.Next(limiteInf, limiteSuperior + 1)
            Next
        Next


    End Sub

    Public Sub mostrarMatriz(ByRef m(,) As Integer)
        For i As Integer = 0 To m.GetUpperBound(0) Step 1
            For j As Integer = 0 To m.GetUpperBound(1) Step 1
                Console.Write(m(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
