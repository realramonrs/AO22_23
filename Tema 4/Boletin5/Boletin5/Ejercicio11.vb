Imports System

Module Ejercicio11
    Sub Main(args As String())

        Dim m, suma As Double

        Console.WriteLine("Introduce el valor de m: ")
        m = Convert.ToInt32(Console.ReadLine())

        While m < 0
            Console.WriteLine("Introduce el valor de m: ")
            m = Convert.ToInt32(Console.ReadLine())
        End While

        For i = 1 To m
            suma += 1 / Math.Pow(i, 3)
        Next

        Console.WriteLine("La suma final es: " & suma)

        Console.ReadLine()
    End Sub
End Module
