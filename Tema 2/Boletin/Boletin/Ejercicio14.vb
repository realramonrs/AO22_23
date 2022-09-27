Module Ejercicio14
    Sub Main()
        Dim precioInicial, precioFinal As Single
        Dim descuento As Byte

        'Entrada:
        Console.WriteLine("Intro precio inicial: ")
        precioInicial = Convert.ToSingle(Console.ReadLine())
        Console.WriteLine("Intro descuento: ")
        descuento = Convert.ToByte(Console.ReadLine())

        precioFinal = precioInicial - (descuento * precioInicial) / 100

        Console.WriteLine("El precio final es de : " & precioFinal & " euros.")
        Console.ReadLine()
    End Sub
End Module
