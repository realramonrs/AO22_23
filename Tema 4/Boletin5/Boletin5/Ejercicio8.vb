Imports System

Module Ejercicio8
    Sub Main(args As String())

        Dim numero, multiplo As Integer

        Console.WriteLine("Introduce un número")
        numero = Convert.ToInt32(Console.ReadLine())

        For i = numero To numero + 5
            Console.WriteLine("numero: " & i & " cuadrado: " & Math.Pow(i, 2) & " cubo: " & Math.Pow(i, 3))
        Next
        Console.ReadLine()
    End Sub
End Module
