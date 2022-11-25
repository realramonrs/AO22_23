Imports System

Module Program
    Sub Main(args As String())

        Dim nombresProfesores() As String = {"Ramón", "Alberto", "Enrique", "Andrés Luna", "Igor"}

        For index = 0 To nombresProfesores.Length - 1
            Console.WriteLine("Nombre: " & nombresProfesores(index))
        Next

        Console.WriteLine()
        nombresProfesores(0) = "Martín"
        Console.WriteLine()

        For index = 0 To nombresProfesores.Length - 1
            Console.WriteLine("Nombre: " & nombresProfesores(index))
        Next

        Console.ReadLine()

    End Sub
End Module
