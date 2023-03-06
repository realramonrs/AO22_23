Option Strict On
Imports System

Module Ejercicio9
    Sub Main(args As String())

        'Creamos una lista sin capacidad inicial
        Dim listaPelis = New ArrayList()
        Dim opcion As String

        'Metemos 5 peliculas
        listaPelis.Add("REC 2")
        listaPelis.Add("American Pie")
        listaPelis.Add("Project X")
        listaPelis.Add("Cars")
        listaPelis.Add("Torrente")

        'Mostramos el menú

        While True
            Console.WriteLine("a. Mostrar películas")
            Console.WriteLine("b. Buscar película")
            Console.WriteLine("c. Añadir película")
            Console.WriteLine("d. Eliminar película")
            Console.WriteLine("e. Salir")

            'Elegimos la opción que queramos

            opcion = Console.ReadLine()

            Select Case opcion
                Case "a"
                    Console.WriteLine("Lista de pelis")
                    For Each pelicula In listaPelis
                        Console.WriteLine(pelicula)
                    Next
                Case "b"
                    Console.WriteLine("Introduce una peli para buscar")
                    Dim peliElegida As String = Console.ReadLine()
                    If listaPelis.Contains(peliElegida) Then
                        Console.WriteLine("La peli está en la lista")
                    Else
                        Console.WriteLine("La peli no está en la lista")
                    End If
                Case "c"
                    Console.WriteLine("Introduce una peli para añadir")
                    Dim peliAIntroducir As String = Console.ReadLine()

                    If listaPelis.Contains(peliAIntroducir) Then
                        Console.WriteLine("La peli ya está en la lista")
                    Else
                        listaPelis.Add(peliAIntroducir)
                    End If
                Case "d"
                    Console.WriteLine("Introduce una peli para eliminar")
                    Dim peliAEliminar As String = Console.ReadLine()

                    If listaPelis.Contains(peliAEliminar) Then
                        listaPelis.Remove(peliAEliminar)
                    Else
                        Console.WriteLine("La peli NO está en la lista")
                    End If
                Case "e"
                    Exit While
            End Select
            Console.ReadKey()
            Console.Clear()
        End While

        Console.ReadKey()
    End Sub
End Module
