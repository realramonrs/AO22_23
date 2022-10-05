Module RiosRamonEjemplo1

    Sub Main()
        'Programa que lee la altura y la edad de un niño,
        'e indica si debe de llevar protección , los niños están obligados a llevar protección
        'si miden menos de 1,35 o su edad es menor que 8
        Dim edad As Byte
        Dim altura As Single
        Dim condicion As Boolean
        Console.WriteLine("Intro edad: ")
        edad = Convert.ToByte(Console.ReadLine())
        Console.WriteLine("Intro altura: ")
        altura = Convert.ToSingle(Console.ReadLine())
        condicion = edad < 8 Or altura < 1.35

        If condicion Then
        Else


        End If
        If edad < 8 Or altura < 1.35 Then
            Console.WriteLine("Debe de llevar silla de protección.")
        Else
            Console.WriteLine("No debe de llevar silla de protección.")
        End If

        'Si un número es múltiplo de 7
        Dim numero As Integer = 45

        If numero Mod 7 = 0 Then
            Console.WriteLine("Múltiplo de 7")
        Else
            Console.WriteLine("No múltiplo de 7")
        End If
        Console.ReadLine()
    End Sub

End Module
