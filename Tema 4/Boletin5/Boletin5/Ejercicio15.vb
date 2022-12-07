Module Module16
    Sub Main()
        'ejercicio 15
        Dim n, factorial As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)
        factorial = 1
        For i = n To 1 Step -1
            factorial *= i
        Next
        Console.WriteLine(factorial)
        Console.ReadLine()
    End Sub
End Module
