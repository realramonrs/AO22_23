Option Strict On
Imports System

Module Ejercicio3
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(10)
        Dim rnd As Random = New Random()
        Dim min, max As Integer

        'Llenamos la lista con valores aleatorios

        For index = 1 To lista.Capacity
            lista.Add(rnd.Next(1, 101))
        Next

        Console.WriteLine("Mostramos la lista:")
        For Each numero In lista
            Console.WriteLine(numero)
        Next

        'Buscamos el numero mas grande y el mas pequeño
        lista.Sort()

        min = Convert.ToInt32(lista(0))
        max = Convert.ToInt32(lista(lista.Count - 1))

        Console.WriteLine("El minimo es {0} y el maximo es {1}", min, max)

        Console.ReadKey()
    End Sub
End Module
