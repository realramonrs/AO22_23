Module Ejercicio26
    Sub main()
        'Programar el juego de adivina el número.
        'Para ello el programa genera un número aleatorio y el usuario debe de acertar de que número se trata.
        'Al empezar el programa debemos elegir nivel.
        'Con cada intento, el programa debe avisar al usuario si es menor o mayor.

        Dim num, n2 As Char
        Dim contador, n, aleatorio2 As Integer
        Dim aleatorio As New Random
        Console.WriteLine("Eija el nivel: ")
        Console.WriteLine("-Nivel 1")
        Console.WriteLine("-Nivel 2")
        Console.WriteLine("-Nivel 3")
        num = Convert.ToChar(Console.ReadLine)

        Select Case num
            Case "1"c
                contador = 3
                    For i = 3 To 1 Step -1
                        Console.WriteLine("Adivina el numero de 1 al 15")
                        n = Convert.ToInt32(Console.ReadLine())
                        aleatorio2 = aleatorio.Next(1, 15)
                        Console.WriteLine(aleatorio2)
                        If n <> aleatorio2 Then
                            contador -= 1
                            Console.WriteLine("Tienes " & contador & " intentos")
                        Else
                        Console.WriteLine("Has adivinado")
                        Exit For
                    End If
                    Next

            Case "2"c
                contador = 4
                For i = 4 To 1 Step -1
                    Console.WriteLine("Adivina el numero de 1 al 30")
                    n = Convert.ToInt32(Console.ReadLine())
                    aleatorio2 = aleatorio.Next(1, 30)
                    Console.WriteLine(aleatorio2)
                    If n <> aleatorio2 Then
                        contador -= 1
                        Console.WriteLine("Tienes " & contador & " intentos")
                    Else
                        Console.WriteLine("Has adivinado")
                        Exit For
                    End If
                Next

            Case "3"c
                contador = 6
                For i = 6 To 1 Step -1
                    Console.WriteLine("Adivina el numero de 1 al 50")
                    n = Convert.ToInt32(Console.ReadLine())
                    aleatorio2 = aleatorio.Next(1, 50)
                    Console.WriteLine(aleatorio2)
                    If n <> aleatorio2 Then
                        contador -= 1
                        Console.WriteLine("Tienes " & contador & " intentos")
                    Else
                        Console.WriteLine("Has adivinado")
                        Exit For
                    End If
                Next
        End Select
        Console.ReadLine()



    End Sub
End Module
