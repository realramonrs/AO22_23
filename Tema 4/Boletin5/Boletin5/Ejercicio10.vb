Imports System

Module Ejercicio10
    Sub Main(args As String())

        Dim m, suma As Integer

        Console.WriteLine("Introduce el valor de m: ")
        m = Convert.ToInt32(Console.ReadLine())

        While m < 0
            Console.WriteLine("Introduce el valor de m: ")
            m = Convert.ToInt32(Console.ReadLine())
        End While

        For i = m To 1 Step -1
            suma += i
        Next

        Console.WriteLine("La suma final es: " & suma)

        Console.ReadLine()
    End Sub
End Module
