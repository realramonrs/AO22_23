Option Strict On
Imports System

Module Ejercicio6
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(10)
        Dim rnd As Random = New Random()
        Dim suma As Integer = 0

        'Creamos una lista de numeros
        For index = 1 To 10
            lista.Add(rnd.Next(1, 10))
        Next

        'Mostramos la lista
        For Each numero In lista
            Console.WriteLine(numero)
        Next

        'Sumamos los numeros pares
        For Each numero As Integer In lista
            If numero Mod 2 = 0 Then
                suma += numero
            End If
        Next

        Console.WriteLine("La suma de los numeros pares es: " & suma)

        Console.ReadKey()
    End Sub
End Module
