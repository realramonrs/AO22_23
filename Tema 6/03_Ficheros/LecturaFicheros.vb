Imports System.IO
Module LecturaFicheros

    Sub Main()

        'Para leer de un fichero:
        '1º --> Creamos variable StreamReader (Es necesario que el fichero exista)
        Dim lector As New StreamReader(Globals.ruta)
        '2º --> Crear la matriz en la que volcaremos los datos
        Dim productos(99) As String

        '3º --> Ir recorriendo los registros y volcarlos en las posiciones de la matriz
        Dim posicion As Integer = 0
        While Not lector.EndOfStream
            productos(posicion) = lector.ReadLine()
            posicion += 1
        End While
        '4º --> Cerrar el lector

        Console.WriteLine("Productos actualmente en tienda: ")
        'Mostramos los datos de la matriz
        For Each producto As String In productos
            If producto Is Nothing Then
                Exit For
            End If
            Console.WriteLine(producto)
        Next


        Console.ReadLine()
    End Sub
End Module
