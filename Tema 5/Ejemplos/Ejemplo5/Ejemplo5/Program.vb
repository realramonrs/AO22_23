Imports System
'Ejemplo 5: Introducimos info para jugadores del Mundial.
'Queremos saber los siguientes datos: LA PEDIMOS POR PANTALLA
'   - Cantidad de jugadores (Tamaño de los arrays)
'   - Para cada jugador: (Dentro del bucle)
'      - Nombres
'      - Nacionalidades
'      - Goles
'      - Asistencias

'Metemos la siguiente información: NOMBRE JUGADOR - NACIONALIDAD - GOLES - ASISTENCIAS

'Ejemplo de como debe aparecer CRISTIANO - PORTUGUES - 999 - 2

Module Program
    Sub Main(args As String())

        Dim nJugadores As Integer

        'Pedimos la cantidad de jugadores
        Console.Write("¿Qué cantidad de jugadores vas a meter?")
        nJugadores = Convert.ToInt32(Console.ReadLine())

        'Creamos los arrays
        Dim nombres(nJugadores - 1), nacionalidades(nJugadores - 1) As String
        Dim goles(nJugadores - 1), asistencias(nJugadores - 1) As Integer

        'Pedir la info de cada jugador
        For i = 0 To nJugadores - 1
            Console.WriteLine("Nombre jugador: ")
            nombres(i) = Console.ReadLine()

            Console.WriteLine("Nacionalidad jugador: ")
            nacionalidades(i) = Console.ReadLine()

            Console.WriteLine("Goles jugador: ")
            goles(i) = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Asistencias jugador: ")
            asistencias(i) = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()
        Next
        Console.WriteLine()

        'Mostrar la info de cada jugador
        For i = 0 To nJugadores - 1
            Console.WriteLine(nombres(i) & " - " & nacionalidades(i) & " - " & goles(i) & " - " & asistencias(i))
        Next

        Console.ReadLine()
    End Sub
End Module
