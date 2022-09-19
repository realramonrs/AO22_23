Module Module1

    Sub Main()
        Dim numero As Integer = 10
        'PORQUÉ UTILIZAMOS EL OPTION STRICT ON
        'Pérdida de precisión
        '  Dim raiz As Integer = Math.Sqrt(numero)
        '   Console.WriteLine("La raiz es: " & raiz)

        Dim x As Byte
        Dim y As Integer = 290
        'Error desbordamiento --> OverflowException en tiempo de ejecución
        '  x = y + 5

        Console.ReadLine()
    End Sub

End Module
