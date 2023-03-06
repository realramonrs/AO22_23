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

        'Mostramos el men�

        While True
            Console.WriteLine("a. Mostrar pel�culas")
            Console.WriteLine("b. Buscar pel�cula")
            Console.WriteLine("c. A�adir pel�cula")
            Console.WriteLine("d. Eliminar pel�cula")
            Console.WriteLine("e. Salir")

            'Elegimos la opci�n que queramos

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
                        Console.WriteLine("La peli est� en la lista")
                    Else
                        Console.WriteLine("La peli no est� en la lista")
                    End If
                Case "c"
                    Console.WriteLine("Introduce una peli para a�adir")
                    Dim peliAIntroducir As String = Console.ReadLine()

                    If listaPelis.Contains(peliAIntroducir) Then
                        Console.WriteLine("La peli ya est� en la lista")
                    Else
                        listaPelis.Add(peliAIntroducir)
                    End If
                Case "d"
                    Console.WriteLine("Introduce una peli para eliminar")
                    Dim peliAEliminar As String = Console.ReadLine()

                    If listaPelis.Contains(peliAEliminar) Then
                        listaPelis.Remove(peliAEliminar)
                    Else
                        Console.WriteLine("La peli NO est� en la lista")
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
