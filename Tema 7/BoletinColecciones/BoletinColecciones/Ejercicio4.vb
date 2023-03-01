Option Strict On
Imports System

Module Ejercicio4
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(10)
        Dim minimoLetras, maximoLetras As Integer
        Dim palabraMasLarga, palabraMasCorta As String

        'Llenamos la lista con palabras

        For index = 0 To lista.Capacity - 1
            Console.Write("Mete una palabra: ")
            lista.Add(Console.ReadLine())
        Next

        For Each palabra1 In lista
            Console.WriteLine(palabra1)
        Next

        'Forma Martin
        Dim cantidadLetras As Integer
        Dim palabra As String

        For index = 0 To lista.Count - 1
            palabra = Convert.ToString(lista(index))
            cantidadLetras = palabra.Length

            If index = 0 Then
                minimoLetras = cantidadLetras
                maximoLetras = cantidadLetras
                palabraMasCorta = palabra
                palabraMasLarga = palabra
            Else
                If cantidadLetras < minimoLetras Then
                    minimoLetras = cantidadLetras
                    palabraMasCorta = palabra
                End If
                If cantidadLetras > maximoLetras Then
                    maximoLetras = cantidadLetras
                    palabraMasLarga = palabra
                End If
            End If
        Next

        Console.WriteLine("La palabra mas corta es {0} y la mas larga {1}", palabraMasCorta, palabraMasLarga)

        'Otra forma
        Dim comparar As String = lista(0).ToString()
        For Each palabra2 As String In lista
            If comparar.Length > palabra2.Length Then
                comparar = palabra2
            End If
        Next

        Console.WriteLine("Palabra mas corta: " & comparar)

        For Each palabra2 As String In lista
            If comparar.Length < palabra2.Length Then
                comparar = palabra2
            End If
        Next

        Console.WriteLine("Palabra mas larga: " & comparar)

        Console.ReadKey()
    End Sub
End Module
