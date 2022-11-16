Module Module19
    Sub Main()
        'ejercicio 18
        Dim n, c As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)

        While n <= 0
            Console.WriteLine("Introduce un número")
            n = Convert.ToInt32(Console.ReadLine)
        End While

        For i = 1 To n
            If n Mod i = 0 Then
                c += 1
            End If
        Next

        If c <> 2 Then
            Console.WriteLine("No es primo")
        Else
            Console.WriteLine("Es primo")
        End If
        Console.ReadLine()
    End Sub
End Module
