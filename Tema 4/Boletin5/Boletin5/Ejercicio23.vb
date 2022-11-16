Module Ejercicio23
    Sub main()
        'Realizar un programa que muestre todos los números perfectos por debajo de uno dado.
        Dim num, suma As Integer
        Console.WriteLine("Introduzca un numero: ")
        num = Convert.ToInt32(Console.ReadLine)
        For x = 1 To num Step 1
            For divisor = 1 To x - 1
                If x Mod divisor = 0 Then
                    suma = suma + divisor
                End If

            Next


            If suma = x Then
                Console.Write(suma & ", ")
            End If

        Next
        Console.ReadLine()
    End Sub
End Module
