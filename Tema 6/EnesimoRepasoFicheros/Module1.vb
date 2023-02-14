Imports System.IO
Module Module1

    Sub Main()
        'Aplicacion que permite registrar vehículos
        'De cada vehículo tenemos que almacenar la siguiente info: 
        'matricula-Marca-Modelo-Fecha Matriculacion
        'Al arrancar la aplicación se debe volcar toda la info de los vehiculos
        'a un fichero
        Dim ruta As String = Directory.GetCurrentDirectory() + "\vehiculos.txt"
        Dim vehiculos(99) As String
        Dim lector As StreamReader
        Try

            lector = New StreamReader(ruta)
            Dim pos As Integer = 0

            While Not lector.EndOfStream
                vehiculos(pos) = lector.ReadLine()
                pos += 1
            End While
            lector.Close()
        Catch ex As Exception
            lector.Close()
            File.Create(ruta)
            lector = New StreamReader(ruta)
            Dim pos As Integer = 0
            While Not lector.EndOfStream
                vehiculos(pos) = lector.ReadLine()
                pos += 1
            End While
            lector.Close()
        End Try

        'Meter vehículos en el fichero
        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        Dim matricula, marca, modelo, fechaNacimiento As String
        Console.WriteLine("matricula: ")
        matricula = Console.ReadLine()

        Console.WriteLine("marca: ")
        marca = Console.ReadLine()

        Console.WriteLine("modelo: ")
        modelo = Console.ReadLine()

        Console.WriteLine("fecha nacimiento: ")
        fechaNacimiento = Console.ReadLine()

        escritor.WriteLine(matricula + "*" + marca + "*" + modelo + "*" + fechaNacimiento)
        escritor.Close()

        Console.WriteLine("Vehículos por marca: ")
        Console.WriteLine("Introduzca la marca de la que desea info: ")
        Dim marca2 As String = Console.ReadLine

        'Nos conectamos al fichero y consultamos por marca
        lector = New StreamReader(ruta)

        While Not lector.EndOfStream
            Dim registro As String = lector.ReadLine()
            If registro.Split("*"c)(1) = marca2 Then
                Console.WriteLine(registro)
            End If
        End While

        lector.Close()

        Console.ReadLine()
    End Sub

End Module
