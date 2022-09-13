
Module Module1

    Sub Main()
        '****** Zona declaración de variables *******
        'Reservamos memoria para nuestro programa
        Dim b1 As Byte
        Dim i1 As Integer = 150  'Declaración e inicialización
        Dim l1 As Long
        l1 = 450000000

        Dim s1 As Single = 4.56
        Dim d1 As Double

        '********************************************'
        '***** Visualizamos los valores de las variables
        Console.WriteLine("b1 = " & b1)
        'Visualizar máximo valor que almacena el tipo Byte
        Console.WriteLine("Máximo valor de byte : " & Byte.MaxValue)
        Console.WriteLine("Minimo valor de byte : " & Byte.MinValue)

        Console.WriteLine("s1 = " & s1)
        'Modificar valores de variables
        b1 = 90

        i1 = i1 + 10
        s1 = 5.8888859
        Console.WriteLine("s1 = " & s1)
        Console.ReadLine()
    End Sub

End Module
