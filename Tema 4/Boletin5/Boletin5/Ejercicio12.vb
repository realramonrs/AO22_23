Module Module13
    Sub Main()
        'ejericcio 12
        Dim n, suma As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)

        For i = 1 To n
            If n Mod i = 0 Then
                suma += i
            End If
        Next
        Console.WriteLine(suma)
        Console.ReadLine()
    End Sub
End Module
