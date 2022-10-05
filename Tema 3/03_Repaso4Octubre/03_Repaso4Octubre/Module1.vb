Option Strict On

Module Module1

    Sub Main()
        'Operadores relacionales y lógicos que devuelven valores booleanos
        ' <, > , <> , = , <=, >=
        'AND, OR , Not
        'if condicion Then
        ' instrucciones
        'else
        'instrucciones
        'End If

        'Indicar si un  número está en el rango [10-20]
        Dim numero As Integer
        Try
            Console.WriteLine("Introduce un número: ")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero <= 20 And numero >= 10 Then
                Console.WriteLine("Entre 10 y 20 ok!")
            Else
                Console.WriteLine("Error!!")
            End If

            'Indicar si el número es múltiplo de 3
            If numero Mod 3 = 0 Then
                Console.WriteLine(" y múltiplo de 3")
            End If
        Catch ex As Exception
            Console.WriteLine("Error en la entrada de datos")
        End Try



        Console.ReadLine()

    End Sub

End Module
