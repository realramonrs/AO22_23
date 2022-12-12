Module Module1

    Sub Main()

        Dim n As Integer = 5

        'Contar los divisores de n
        Dim cuentaDivisores As Integer = 0
        For i As Integer = 1 To n Step 1
            If n Mod i = 0 Then
                cuentaDivisores += 1
            End If
        Next

        If cuentaDivisores = 2 Then
            Console.WriteLine(n & " es número primo.")
        Else
            Console.WriteLine("No es número primo.")
        End If

        'Contar los múltiplos de 3 que hay por debajo de n
        Dim cuentaMultiplos As Integer = 0
        For i As Integer = 3 To n Step 1
            If i Mod 3 = 0 Then
                cuentaMultiplos += 1
            End If
        Next

        'Sumar los divisores de n
        Dim suma As Integer
        For i As Integer = 1 To n - 1 Step 1
            If n Mod i = 0 Then
                suma += i
            End If
        Next
        'Un número es perfecto si es igual a la suma de sus divisores descontando él mismo
        If suma = n Then
            Console.WriteLine("El número es perfecto.")
        Else
            Console.WriteLine("El número no es perfecto.")
        End If
        'sumar los múltiplos de 3 que hay por debajo de n

        Dim suma2 As Integer
        For i As Integer = 3 To n Step 1
            If i Mod 3 = 0 Then
                suma2 += i
            End If

        Next
        'Calculo del factorial de n = 5 --> 5*4*3*2*1

        Dim fact As Long
        For i As Integer = n To 1 Step -1
            fact = fact * i
        Next


        'Mostrar todos los números perfectos por debajo de n
        Console.WriteLine("Introduzca el valor de n: ")
        n = Convert.ToInt32(Console.ReadLine())
        Dim suma3 As Integer
        Dim sumaPerfectos As Integer = 0
        For i As Integer = 6 To n Step 1
            suma3 = 0
            For j As Integer = 1 To i - 1 Step 1
                If i Mod j = 0 Then
                    suma3 += j
                End If
            Next
            If suma3 = i Then
                sumaPerfectos += i
                Console.WriteLine(i & " es Número perfecto")
            End If
        Next
        Console.WriteLine("La suma es : " & sumaPerfectos)

        Console.ReadLine()
    End Sub

End Module
