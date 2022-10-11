Module Module1

    Sub Main()
        'Programa que me diga si un número es > 100 y/o Múltiplo de 6

        Dim numero As Integer
        Dim continuar As Char
        Do
            Console.WriteLine("Introduce un número.")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero Mod 6 = 0 Then
                If numero > 100 Then
                    Console.WriteLine("Múltiplo de 6 y > 100")
                Else
                    Console.WriteLine("Múltiplo de 6 y <= 100")

                End If
            Else
                If numero > 100 Then
                    Console.WriteLine("Numero > 100 y no es múltiplo de 6 ")
                Else
                    Console.WriteLine("Numero <= 100 y no es múltiplo de 6")
                End If
            End If


            Console.WriteLine("Desea continuar s/n")
            continuar = Convert.ToChar(Console.ReadLine())

        Loop While continuar = "s"c
    End Sub

End Module
