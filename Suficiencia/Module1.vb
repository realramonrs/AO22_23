Module Module1

    Sub Main()
        'Repaso Arrays
        Dim sercae(7) As Integer

        Console.WriteLine("Capacidad matriz: " & sercae.Length)
        'Visualizar todos los valores
        'For i As Integer = 0 To sercae.Length - 1 Step 1
        '    Console.Write(sercae(i) & " ")
        'Next

        For Each numero As Integer In sercae
            Console.Write(numero & " ")
        Next
        Console.WriteLine()

        '**********************************'
        Dim sercaeConValores() As Integer = {3, 5, 568, 1, 2, 0, 4}
        'Calcular suma de valores
        Dim suma As Integer = 0
        For i As Integer = 0 To sercaeConValores.Length - 1 Step 1

            suma = suma + sercaeConValores(i)

        Next

        'Calcular la media
        Dim media As Double = suma / sercaeConValores.Length
        'Buscar valores en una matriz
        Dim n As Integer
        Console.WriteLine("Introduzca un valor: ")
        n = Convert.ToInt32(Console.ReadLine())
        Dim encontrado As Boolean = False
        For i As Integer = 0 To sercaeConValores.Length - 1 Step 1
            If sercaeConValores(i) = n Then
                Console.WriteLine(n & " está en posición: " & i)
                encontrado = True
                Exit For
            End If
        Next
        If Not encontrado Then
            Console.WriteLine("No está en la matriz")
        End If
        'Calcular el valor máximo y el mínimo
        Dim max As Integer = sercaeConValores(0)
        For i As Integer = 1 To sercaeConValores.Length - 1 Step 1
            If sercaeConValores(i) > max Then
                max = sercaeConValores(i)
            End If
        Next

        '% numeros negativos
        Dim contadorNegs As Integer = 0

        For i As Integer = 0 To sercaeConValores.Length - 1 Step 1
            If sercaeConValores(i) < 0 Then
                contadorNegs += 1
            End If
        Next
        Dim porcentajeNegs As Double = (contadorNegs / sercaeConValores.Length) * 100

        Console.ReadLine()
    End Sub

End Module
