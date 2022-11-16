Module Ejercicio25
    Sub main()
        Dim numnegativo, numpositivo, com, porcentajecom As Integer
        Dim aleatorio As New Random

        For i = 1 To 10
            numpositivo = 0
            numnegativo = 0
            com = 0

            For x = 1 To 10
                Dim n As Integer = aleatorio.Next(-5, 5)
                Console.Write(n & " ")
                If n < 0 Then
                    numnegativo += 1
                ElseIf n >= 0 Then
                    numpositivo += 1
                End If

                If n <= 2 And n >= -2 Then
                    com += 1
                End If
                Console.WriteLine()
            Next
            porcentajecom = com / 10 * 100
            Console.WriteLine(numnegativo & "numeros negativos")
            Console.WriteLine(numpositivo & "numeros positivos")
            Console.WriteLine(porcentajecom & "%")

        Next


    End Sub
End Module
