Option Strict On
Imports System

Module Ejercicio8
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(5)
        Dim rnd As Random = New Random()
        Dim contador As Integer = 0

        'Creamos una lista de palabras
        lista.Add("Mesa")
        lista.Add("Zapato")
        lista.Add("Ordenador")
        lista.Add("Pantalla")
        lista.Add("Boli")

        'Mostramos la lista
        For Each palabra In lista
            Console.WriteLine(palabra)
        Next

        'Contamos las palabras que tengan mas de 5 letras
        For Each palabra As String In lista
            If palabra.Length > 5 Then
                contador += 1
            End If
        Next

        'Muestro la cantidad de palabras de más de 5 letras que tengo
        Console.WriteLine("La cantidad de palabras es: " & contador)

        Console.ReadKey()
    End Sub
End Module
