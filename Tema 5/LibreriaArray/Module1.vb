Module Module1

    Sub Main()
        Dim original(9) As Integer
        Dim copia(9) As Integer
        Dim aleatorio As New Random
        For i As Integer = 0 To original.Length - 1 Step 1
            original(i) = aleatorio.Next(1, 30)
        Next

        'Librería Array
        'Copiar un array en otro

        Array.Copy(original, copia, 4)

        Array.Copy(original, 4, copia, 0, 4)

        Dim arrayPrueba() As Integer = {4, -1, 0, 9, 7, -9, -4, 5, 7, 8, 9, 12}
        For i As Integer = 0 To original.Length - 1 Step 1
            Console.Write(original(i) & " ")
        Next
        'Búsquedas : binarySearch-->si el array está previamente ordenado
        ' Array.Sort(arrayPrueba)
        Console.WriteLine()
        For i As Integer = 0 To arrayPrueba.Length - 1 Step 1
            Console.Write(arrayPrueba(i) & " ")
        Next

        Dim posicion As Integer = Array.BinarySearch(arrayPrueba, 0)

        Console.WriteLine("Posición: " & posicion)

        'Comprobar si dos arrays son iguales
        Dim a1() As Integer = {1, 2, 3}
        Dim a2() As Integer = {1, 26, 3}
        a1 = a2
        Dim iguales As Boolean = a1.Equals(a2)
        Console.WriteLine("Iguales ? " & iguales)
        Console.ReadLine()

    End Sub

End Module
