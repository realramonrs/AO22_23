Module Module2
    Public Sub generarArray(ByRef matriz() As Integer, ByVal limiteInf As Integer, ByVal limiteSuperios As Integer)
        Dim generator As New Random
        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = generator.Next(limiteInf, limiteSuperios + 1)
        Next

    End Sub

    Public Sub mostrarArray(ByRef matriz() As Integer)
        For i As Integer = 0 To matriz.Length - 1 Step 1
            Console.Write(matriz(i) & " ")
        Next
        Console.WriteLine()

    End Sub
    Public Sub mostrarArray(ByRef matriz() As Double)
        For i As Integer = 0 To matriz.Length - 1 Step 1
            Console.Write(matriz(i) & " ")
        Next

    End Sub
End Module
