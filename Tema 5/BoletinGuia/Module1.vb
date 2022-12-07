Option Strict On
Module Module1

    Sub Main()
        'Sintaxis
        Dim matriz() As Integer = New Integer(99) {}
        Dim matriz2(9) As Integer
        Console.WriteLine("Elementos: " & matriz.Length)
        Console.WriteLine("Ultimo indice: " & matriz.Length - 1)

        'Recorrer un array para operaciones de sólo lectura
        For Each valor As Integer In matriz2
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
        'Modificar las posiciones impares guardando un 1

        For i = 1 To matriz.Length - 1 Step 2
            matriz(i) = 1
        Next

        'Llenar las posiciones pares con números aleatorios entre 1 y 50
        Dim aleatorio As New Random
        For i As Integer = 0 To matriz.Length - 1 Step 2
            matriz(i) = aleatorio.Next(1, 51)
        Next
        Console.WriteLine()
        Console.WriteLine("Nuevo array")

        For Each numero As Integer In matriz
            Console.Write(numero & " ")
        Next

        'Calcular la media de los valores dle array
        Dim suma As Double
        Dim media As Double

        For i = 0 To matriz.Length - 1 Step 1
            suma = suma + matriz(i)
        Next
        media = suma / matriz.Length

        Console.ReadLine()

    End Sub

End Module
