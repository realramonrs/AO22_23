Module EjemploInput
    Sub Main()
        Dim dni As String
        Dim edad As Integer

        dni = InputBox("Introduce el DNI")
        edad = Convert.ToInt32(InputBox("Introduce la edad: "))

        Console.WriteLine("Sus datos han sido guardados con éxito! Pulse Enter para salir.")
        Console.ReadLine()

    End Sub
End Module
