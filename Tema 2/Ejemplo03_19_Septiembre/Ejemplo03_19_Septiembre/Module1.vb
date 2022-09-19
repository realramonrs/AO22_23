Module Module1
    'Programa que calcula el precio final de una vivienda, teniendo en cuenta
    'los siguientes impuestos:
    'La inmobiliaria se lleva el 3% del precio Inicial
    'El ayuntamiento el 9% del precio Inicial: Impuesto Transf Patrimonio
    Sub Main()
        Dim precioInicial, precioFinal, precioInmobiliaria, impuestoTransferencia As Single
        'Entrada
        precioInicial = 120000

        'Cálculos:
        precioInmobiliaria = 0.03 * precioInicial
        impuestoTransferencia = precioInicial * (9 / 100)
        precioFinal = precioInicial + precioInmobiliaria + impuestoTransferencia


        'Salida por pantalla:
        Console.WriteLine("Precio inicial: " & precioInicial & " euros")
        Console.WriteLine("Cuota inmobiliaria: " & precioInmobiliaria & " euros.")
        Console.WriteLine("Impuesto Transferencia: " & impuestoTransferencia & " euros.")

        Console.WriteLine("Precio final: " & precioFinal)
        Console.ReadLine()






    End Sub

End Module
