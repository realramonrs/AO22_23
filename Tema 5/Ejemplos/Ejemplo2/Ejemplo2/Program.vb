Imports System

Module Program
    Sub Main(args As String())

        'Creamos dos arrays
        Dim nombresFutbolistas(4) As String
        Dim golesFutbolistas(4) As Integer

        'Pedir por pantalla el futbolista y los goles que lleva
        For i = 0 To 4
            Console.Write("Introduce el nombre del futbolista: ")
            nombresFutbolistas(i) = Console.ReadLine()
            Console.Write("Introduce los goles: ")
            golesFutbolistas(i) = Convert.ToInt32(Console.ReadLine())
        Next

        Console.WriteLine()
        Console.WriteLine("Goles en el Mundial:")

        'Pintamos la info completa
        For i = 0 To 4
            Console.WriteLine("Nombre futbolista: " & nombresFutbolistas(i) & " Goles: " & golesFutbolistas(i))
        Next

        'APARECE EL VAR
        golesFutbolistas(4) = golesFutbolistas(4) - 1
        Console.WriteLine()
        Console.WriteLine("OJO, HAY VAR! [ ] ")
        Console.WriteLine()
        Console.WriteLine("Goles en el Mundial:")
        Console.WriteLine()


        'Pintamos la info completa (después del VAR)
        For i = 0 To 4
            Console.WriteLine("Nombre futbolista: " & nombresFutbolistas(i) & " Goles: " & golesFutbolistas(i))
        Next
        Console.ReadLine()
    End Sub
End Module
