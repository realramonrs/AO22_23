Module Module15
    Sub Main()
        'ejercicio 14
        Dim n, suma As Integer

        Console.WriteLine("Introduce un numero positivo")
        n = Convert.ToInt32(Console.ReadLine)

        For i = n To 1 Step -1
            If i Mod 5 = 0 Then
                suma += i
            End If
        Next
        Console.WriteLine(suma)
        Console.ReadLine()
    End Sub
End Module
