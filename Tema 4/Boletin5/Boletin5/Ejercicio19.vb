Module Module20
    Sub Main()
        'ejercicio 19
        Dim n, m, c As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Introduce un número")
        m = Convert.ToInt32(Console.ReadLine)

        For i = n To m Step 1
            If i Mod 3 = 0 And i Mod 5 = 0 And i Mod 7 = 0 Then
                c += 1
                If c = 1 Then
                    Console.WriteLine(i & " es multiplo de 3,5 y 7")
                End If
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
