Module Module17
    Sub Main()
        'ejercicio 16
        Dim n, contador As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)

        For i = 1 To n
            If i Mod 3 = 0 Then
                contador += 1
            End If
        Next
        Console.WriteLine(contador)
        Console.ReadLine()
    End Sub
End Module
