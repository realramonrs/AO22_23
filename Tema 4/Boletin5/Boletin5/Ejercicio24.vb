Module Ejercoicio24
    Sub main()
        'Realizar un programa que cuente cuántos números primos hay por debajo de uno dado.
        Dim num, divisores, cont As Integer
        Console.WriteLine("Introduzca numero: ")
        num = Convert.ToInt32(Console.ReadLine)

        For i = 1 To num
            divisores = 0
            For a = 1 To i
                If i Mod a = 0 Then
                    divisores += 1

                End If

            Next
            If divisores = 2 Then
                Console.Write(i & ", ")
                cont += 1
            End If
        Next
        Console.WriteLine()
        Console.WriteLine("por debajo de " & num & " hay " & cont & " numeros")
        Console.ReadLine()

    End Sub
End Module
