Module Module1
    Sub Main()
        'ejercicio 20
        Dim factor, numElementos, resultado As Integer

        Console.WriteLine("Introduce el factor")
        factor = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("Introduce el número de elementos")
        numElementos = Convert.ToInt32(Console.ReadLine)

        For i = 1 To numElementos
            resultado = i * factor
            Console.WriteLine(factor & "x" & i & "=" & resultado)
        Next
        Console.ReadLine()
    End Sub
End Module
