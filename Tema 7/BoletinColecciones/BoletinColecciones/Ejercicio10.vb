Option Strict On
Imports System

Module Ejercicio10
    Sub Main(args As String())

        Dim listaEj1 As ArrayList = New ArrayList(10)

        Dim random As New Random()

        For index = 1 To listaEj1.Capacity
            listaEj1.Add(random.Next(1, 51))
        Next

        'Creamos una lista a partir de la lista del ejercicio 1
        Dim listaNueva As ArrayList = New ArrayList(listaEj1)

        'Añadimos otros 5 valores aleatorios
        For index = 1 To 5
            listaNueva.Add(random.Next(100, 201))
        Next

        'Mostramos por pantalla los valores almacenados
        For Each valor In listaNueva
            Console.WriteLine(valor)
        Next

        Console.ReadKey()
    End Sub
End Module
