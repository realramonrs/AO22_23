Module Module2
    Sub Main()
        Dim contador As Integer = 0
        Dim suma As Integer = 0
        For i As Integer = 0 To 9 Step 1
            If i Mod 2 = 0 Then
                contador += 1
                suma = suma + i
            End If
            Console.WriteLine(i & " ")

        Next

        Dim n, m As Integer
        n = 15
        m = 350

        'Mostrar todos los divisores de m
        Console.WriteLine("Los divisores de m son: ")
        For i As Integer = n To m Step 1
            If m Mod i = 0 Then
                Console.Write(i & " ")
            End If
        Next

        'Mostrar el primer divisor de m
        Console.WriteLine("el primer divisor de m es: ")
        For i As Integer = n To m Step 1
            If m Mod i = 0 Then
                Console.Write(i & " ")
                Exit For
            End If
        Next

        Console.ReadLine()
    End Sub
End Module
