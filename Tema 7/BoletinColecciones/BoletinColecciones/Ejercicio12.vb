Option Strict On
Imports System
Imports System.Threading
Imports Microsoft.VisualBasic.Logging

Module Ejercicio12
    Sub Main(args As String())

        Dim opcion As Char

        Dim listaTareas As ArrayList = New ArrayList()
        Dim listaTareasCompletadas As ArrayList = New ArrayList()

        While True
            Console.WriteLine("a.Introducir tarea:")
            Console.WriteLine("b.Completar tarea:")
            Console.WriteLine("c.Contar tareas")
            Console.WriteLine("d.Mostrar tareas pendientes")
            Console.WriteLine("e.Mostrar tareas completadas.")
            Console.WriteLine("f.Mostrar tareas cuya fecha vencimiento es el día de hoy.")
            Console.WriteLine("g.Mostrar tareas más urgentes (prioridad > 8)")
            Console.WriteLine("h.Salir")

            opcion = Convert.ToChar(Console.ReadLine())

            Select Case opcion
                Case "a"c
                    Dim tarea As String = Console.ReadLine()
                    listaTareas.Add(tarea)

                Case "b"c
                    Dim tareaAEliminar As String = Console.ReadLine()
                    listaTareas.Remove(tareaAEliminar)
                    listaTareasCompletadas.Add(tareaAEliminar)

                Case "c"c
                    Dim totalTareas As Integer = listaTareas.Count
                    Console.WriteLine("Total de tareas: " & totalTareas)

                Case "d"c
                    Console.WriteLine("Lista de tareas pendientes: ")
                    For Each tareaPendiente In listaTareas
                        Console.WriteLine(tareaPendiente)
                    Next
                Case "e"c
                    Console.WriteLine("Lista de tareas completadas: ")
                    For Each tareaCompletada In listaTareasCompletadas
                        Console.WriteLine(tareaCompletada)
                    Next
                Case "f"c
                    Dim diaHoy As DateTime = Date.Today

                    For Each tarea As String In listaTareas

                        Dim array() As String = tarea.Split("*"c)

                        Dim diaTarea As DateTime = Convert.ToDateTime(array(2).ToString())

                        If diaTarea = diaHoy Then
                            Console.WriteLine(tarea)
                        End If
                    Next

                Case "g"c
                    For Each tarea As String In listaTareas
                        Dim array() As String = tarea.Split("*"c)
                        Dim prioridad As Integer = Convert.ToInt32(array(1).ToString())
                        If prioridad > 8 Then
                            Console.WriteLine(tarea)
                        End If
                    Next

                Case "h"c
                    Exit While
            End Select

            Console.ReadKey()
            Console.Clear()
        End While



        Console.ReadKey()
    End Sub
End Module
