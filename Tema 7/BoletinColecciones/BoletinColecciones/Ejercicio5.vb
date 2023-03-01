Option Strict On
Imports System

Module Ejercicio5
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(10)
        Dim rnd As Random = New Random()
        Dim suma As Integer
        Dim promedio As Double

        'Llenamos la lista con edades

        For index = 1 To lista.Capacity
            lista.Add(rnd.Next(16, 31))
        Next

        Console.WriteLine("Mostramos la lista:")
        For Each numero In lista
            Console.WriteLine(numero)
        Next

        'Sumamos las edades
        For Each edad As Integer In lista
            suma = suma + edad
        Next

        'Calculamos el promedio
        promedio = suma / lista.Count

        Console.WriteLine("La edad promedio sería: " & promedio)

        Console.ReadKey()
    End Sub
End Module
