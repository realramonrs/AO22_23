Module Module1

    Sub Main()

        'Cambiar propiedades de la consola
        Console.Title = "Mi segundo programa"

        'Cambiar el color de fondo del texto
        Console.BackgroundColor = ConsoleColor.Blue

        Console.WriteLine("Me lo paso genial en clase de AO")
        'Mantener la consola abierta hasta que el usuario pulse Enter
        Console.WriteLine("Pulsa Enter para continuar :")
        Console.ReadLine()
        'Cambiar color del texto
        Console.ForegroundColor = ConsoleColor.Yellow
        'Quitar el fondo del texto
        Console.BackgroundColor = Nothing
        Console.WriteLine("Esto está en color amarillo")
        Console.Beep(150, 1000)

        System.Threading.Thread.Sleep(3000)

        Console.Beep(150, 5000)
        Console.ReadLine()


    End Sub

End Module
