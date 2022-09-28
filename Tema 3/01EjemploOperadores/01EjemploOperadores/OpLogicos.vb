Module OpLogicos
    Sub Main()
        'Operadores Lógicos --> AND , OR, Not
        'AND --> Y Lógico --> Devuelv True si las dos condiciones son True
        Dim x As Boolean = True
        Dim y As Boolean = False

        Dim condicionAND As Boolean = x And y
        Dim condicionAND2 As Boolean = True And True
        Dim condicionAND3 As Boolean = False And True
        Dim condicionAND4 As Boolean = False And False

        'Programa que lea un número entre 1 y 10, sino error
        Dim numero As Integer
        Dim correcto As Boolean

        Console.WriteLine("Introduzca un número entre 1 y 10 (incluidos)")
        numero = Convert.ToInt32(Console.ReadLine())

        correcto = numero >= 1 And numero <= 10

        Console.WriteLine("Correcto : " & correcto)


        'Or --> Devuelve True si una de las condiciones es True
        'Los niños deben llevar SPI (silla protectora) si son menores de 8 años
        ' o miden menos de 1,35 metros
        Dim altura As Single = 1.4
        Dim edad As Byte = 10
        Dim silla As Boolean = altura < 1.35 Or edad < 8

        Console.WriteLine("Silla : " & silla)


        'Not --> Devuelve lo contrario de lo que tiene a su derecha
        'Programa que lee un número y la condicion es True si no es par
        Dim numero2 As Integer
        Dim impar As Boolean
        Console.WriteLine("Introduzca un número impar: ")
        numero2 = Convert.ToInt32(Console.ReadLine())

        impar = Not numero2 Mod 2 = 0
        'impar = numeroImpar Mod 2 <> 0
        Console.WriteLine(numero2 & " impar? " & impar)

        Console.ReadLine()

    End Sub
End Module
