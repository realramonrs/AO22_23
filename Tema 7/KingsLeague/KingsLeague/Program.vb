Imports System

Module Program
    Sub Main(args As String())

        'Creamos un ArrayList con los diferentes elementos que queremos introducir
        Dim nombrePresidentes(3) As String
        nombrePresidentes(0) = "Gerard Piqué"
        nombrePresidentes(1) = "Spursito"
        nombrePresidentes(2) = "Xbuyer"
        nombrePresidentes(3) = "Iker Casillas"

        Dim jugadores As ArrayList = New ArrayList()
        Dim arbitros As ArrayList = New ArrayList(4)
        Dim presidentes As ArrayList = New ArrayList(nombrePresidentes)

        'Agregamos un jugador
        jugadores.Add("Ronaldinho")
        jugadores.Add("Gabri Veiga")
        jugadores.Add("Alvaro Rodriguez")
        jugadores.Add("Alejandro Garnacho")

        'Borrar un jugador segun su indice
        jugadores.RemoveAt(3)

        'Borrar un presidente segun su valor
        presidentes.Remove("Xbuyer")

        'Comprobar si un elemento esta dentro de una lista
        Dim estaContenido As Boolean
        estaContenido = jugadores.Contains("Ronaldinho")

        'Comprobamos la cantidad de presidentes que hay
        Console.WriteLine("Tenemos " & presidentes.Count & " presidentes")

        'Saber el indice de un elemento
        Console.WriteLine("El indice de Alvaro Rodriguez es " & jugadores.IndexOf("Alvaro Rodriguez"))

        'Añadimos a un posible BdO
        jugadores.Insert(0, "Vini Jr.")

        'Añadir a Cristiano antes de Gabri Veiga y a Messi después
        Dim posicion As Integer
        posicion = jugadores.IndexOf("Gabri Veiga")
        jugadores.Insert(posicion, "Cristiano Ronaldo")
        jugadores.Insert(posicion + 2, "Leo Messi")

        'Quiero obtener el jugador en la ultima posicion
        Dim ultimoJugador As String
        ultimoJugador = jugadores.Item(jugadores.Count - 1)
        Console.WriteLine("El ultimo jugador de la lista es: " & ultimoJugador)

        'Quiero obtener el array de jugadores ordenado
        jugadores.Sort()

        'Mostramos todo por pantalla
        Console.WriteLine("Los jugadores de mi equipo son: ")
        For Each jugador In jugadores
            Console.WriteLine(jugador)
        Next

        Console.WriteLine("Los arbitros de La Liga son: ")
        For Each arbitro In arbitros
            Console.WriteLine(arbitro)
        Next

        Console.WriteLine("Los presidentes son: ")
        For Each presidente In presidentes
            Console.WriteLine(presidente)
        Next

        Console.ReadKey()

    End Sub
End Module
