Module OpMatematicos

    Sub Main()
        'Operadores matemáticos : Mod , / , \
        Dim x As Integer = 14
        Dim y As Integer = 4

        Dim resto As Integer = x Mod y
        Dim divisionReal As Double = x / y
        Dim divisionEntera As Integer = x \ y

        Console.WriteLine("Resto: " & resto)
        Console.WriteLine("Division real : " & divisionReal)
        Console.WriteLine("Division entera : " & divisionEntera)
        Console.ReadLine()

    End Sub

End Module
