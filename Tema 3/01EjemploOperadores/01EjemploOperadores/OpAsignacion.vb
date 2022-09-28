Module OpAsignacion

    Sub Main()
        'Operadores asignación: = , +=, -= , *= , /=

        Dim x As Integer = 1
        'Sumar 1 a x --> x = x + 1
        x += 1
        Console.WriteLine("x = " & x)
        'Restar 1 a x --> x = x - 1
        x -= 1
        Console.WriteLine("x = " & x)

        Console.ReadLine()
    End Sub

End Module
