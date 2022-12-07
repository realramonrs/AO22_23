Imports System
'Ejemplo para guardar el nombre de 5 alumnos
Module Program
    Sub Main(args As String())
        'Declarar el array
        Dim nombres(4) As String

        'Llenar el array
        nombres(0) = "Brais Blanco"
        nombres(1) = "Hugo Pexegueiro"
        nombres(2) = "Anxo Benavides"
        nombres(3) = "Paula Pérez"
        nombres(4) = "Pablo Casal"

        'Mostramos la info
        For i = 0 To 4
            Console.WriteLine(nombres(i))
        Next
        Console.ReadLine()
    End Sub
End Module
