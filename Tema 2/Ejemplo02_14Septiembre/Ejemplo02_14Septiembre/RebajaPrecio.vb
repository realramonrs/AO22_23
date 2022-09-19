Module RebajaPrecio
    Sub Main()
        '		Inicio
        'Variables: precioInicial , rebaja, precioFinal → Decimales.

        '		Leer precioInicial
        '		rebaja = precioInicial * 0.15
        '1ª Opción: precioFinal = precioInicial - rebaja

        '2ª)Opción: precioFinal = precioInicial - precioInicial * 0.15 → precioInicial*(1 - 0.15)
        '		
        Dim precioInicial, rebaja, precioFinal As Single
        precioInicial = 456
        rebaja = precioInicial * 0.15
        precioFinal = precioInicial - precioInicial * 0.15
        '2ª Opción precioFinal = precioInicial * 0.85
        '3ª Opción precioFinal = precioInicial - rebaja

        Console.WriteLine("El precio final es: " & precioFinal)
        Console.ReadLine()

    End Sub
End Module
