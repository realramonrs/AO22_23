Imports System

Module Program
    Sub Main(args As String())

        Dim nombresProfesores() As String = {"Ram�n", "Alberto", "Enrique", "Andr�s Luna", "Igor"}

        For index = 0 To nombresProfesores.Length - 1
            Console.WriteLine("Nombre: " & nombresProfesores(index))
        Next

        Console.WriteLine()
        nombresProfesores(0) = "Mart�n"
        Console.WriteLine()

        For index = 0 To nombresProfesores.Length - 1
            Console.WriteLine("Nombre: " & nombresProfesores(index))
        Next

        Console.ReadLine()

    End Sub
End Module
