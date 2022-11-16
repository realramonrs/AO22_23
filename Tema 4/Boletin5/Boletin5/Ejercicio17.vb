Module Module18
    Sub Main()
        'ejercicio 17
        Dim n, contador As Integer

        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine)

        For i = 1 To n
            If n Mod i = 0 Then
                contador += 1
            End If
        Next
        Console.WriteLine(contador)
        Console.ReadLine()
    End Sub
End Module
