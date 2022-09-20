
Module Module1

    Sub Main()
        'Lectura por teclado
        'Funciones: Console.ReadLine , InputBox

        'Programa que pide al usuario: DNI, Edad, Salario, Teléfono
        Dim dni As String
        Dim edad As Byte
        Dim salario As Single
        Dim telefono As String

        Console.WriteLine("Introduzca el dni: ")
        dni = Console.ReadLine()

        Console.WriteLine("Introduzca la edad: ")
        edad = Convert.ToByte(Console.ReadLine())

        Console.WriteLine("Introduzca su salario: ")
        salario = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("Introduzca su teléfono: ")
        telefono = Console.ReadLine()

        Console.WriteLine("Sus datos han sido guardados con éxito! Pulse Enter para salir.")
        Console.ReadLine()

    End Sub

End Module
