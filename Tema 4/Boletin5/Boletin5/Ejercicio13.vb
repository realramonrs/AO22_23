Module Module14
    Sub Main()
        'ejercicio 13
        Dim n, suma As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)

        For i = 1 To n - 1
            If n Mod i = 0 Then
                suma += i
                If suma = n Then
                    Console.WriteLine(n & " es un número perfecto")
                End If
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
