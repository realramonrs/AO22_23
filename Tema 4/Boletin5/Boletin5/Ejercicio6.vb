Imports System

Module Ejercicio6
    Sub Main(args As String())

        For i = 1 To 100
            'Multiplo de 5 AND 7
            If i Mod 5 = 0 And i Mod 7 = 0 Then
                Console.Write(i & ", ")
            End If

            'Multiplo de 5 Or 7
            If i Mod 5 = 0 Or i Mod 7 = 0 Then
                Console.Write(i & ", ")
            End If
        Next

        Console.ReadLine()

    End Sub
End Module
