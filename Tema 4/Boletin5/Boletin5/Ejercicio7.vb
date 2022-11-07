Imports System

Module Ejercicio7
    Sub Main(args As String())

        Dim numero, multiplo As Integer

        Console.WriteLine("Introduce un número")
        numero = Convert.ToInt32(Console.ReadLine())

        For i = 1 To 10
            multiplo = numero * i
            Console.WriteLine(numero & " x " & i & " = " & multiplo)
        Next
        Console.ReadLine()
    End Sub
End Module
