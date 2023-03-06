Option Strict On
Imports System

Module Ejercicio7
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(5)
        Dim rnd As Random = New Random()

        'Creamos una lista de nombres
        For index = 1 To 5
            Console.Write("Introduce un nombre: ")
            lista.Add(Console.ReadLine())
        Next

        'Mostramos la lista
        Console.WriteLine("Lista desordenada: ")
        For Each nombre In lista
            Console.WriteLine(nombre)
        Next

        'Ordenamos la lista alfabéticamente
        lista.Sort()

        'Mostramos la lista ordenada
        Console.WriteLine("Lista ordenada: ")
        For Each nombre In lista
            Console.WriteLine(nombre)
        Next

        Console.ReadKey()
    End Sub
End Module
