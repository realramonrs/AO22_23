Imports System

Module Ejercicio9
    Sub Main(args As String())

        Dim raiz As Double

        For i = 16 To 1 Step -2.5
            raiz = Math.Sqrt(i)
            Console.WriteLine("N: " & i & " Raiz: " & raiz)
        Next

        Console.ReadLine()
    End Sub
End Module
