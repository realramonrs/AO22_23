
Module CalculoMedia
    Sub Main()
        'Calcular la media de 3 números
        Dim n1, n2, n3 As Integer
        Dim media As Single

        'Entrada 
        n1 = 4
        n2 = 9
        n3 = 1

        'Cálculo
        media = (n1 + n2 + n3) / 3

        'Salida
        Console.WriteLine("La media es : " & media)
        'Mantener consola abierta hasta pulsar enter
        Console.ReadLine()

    End Sub
End Module
