Module Module1

    Sub Main()
        'Crear una matriz 2D de tipo Integer
        Dim matriz(2, 2) As Integer
        'Acceder a las posiciones:
        matriz(0, 0) = 3
        matriz(0, 1) = 4
        matriz(0, 2) = 9
        matriz(1, 0) = 1
        matriz(1, 1) = 2
        matriz(1, 2) = 3
        matriz(2, 0) = 4
        matriz(2, 1) = 5
        matriz(2, 2) = 7

        'Visualizar los valores por pantalla
        For i As Integer = 0 To 2 Step 1
            For j As Integer = 0 To 2 Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        'length --> nº d eelementos de la matriz
        Console.WriteLine("Nº de elementos: " & matriz.Length)
        'GetUpperBound(int dimension)--> Devuelve el último índice
        'accesible de esa dimension

        Dim matriz2(2, 1) As Integer
        Dim filas As Integer = matriz2.GetUpperBound(0)
        Dim columnas As Integer = matriz2.GetUpperBound(1)
        Console.WriteLine("Último índice de fila de matriz2: " & filas)
        Console.WriteLine("Último índice de columna de matriz2: " & columnas)


        'Puedo usarlos para recorer matrices 2d
        Console.WriteLine("Elementos de matriz2: ")
        For i As Integer = 0 To matriz2.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz2.GetUpperBound(1) Step 1
                Console.Write(matriz2(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()


    End Sub

End Module
