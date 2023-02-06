Module Module1

    Sub Main()

        Dim matriz(4, 4), cont As Integer
        Dim aleatorio As New Random
        For i = 0 To matriz.GetUpperBound(0)
            For x = 0 To matriz.GetUpperBound(1)
                matriz(i, x) = aleatorio.Next(-50, 50)
                Console.Write(matriz(i, x) & "  ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        For i = 0 To matriz.GetUpperBound(0)
            For x = 0 To matriz.GetUpperBound(1)

                For n = 0 To matriz.GetUpperBound(0)
                    For m = 0 To matriz.GetUpperBound(1)
                        If matriz(i, x) = matriz(n, m) Then
                            cont += 1
                        End If
                    Next
                Next
                If cont < 2 Then
                    Console.Write(matriz(i, x) & "  ")
                End If
                cont = 0
            Next

        Next
        Console.ReadLine()

        '        Dim opcion As Integer
        '        Do
        '            Console.WriteLine("Escoja un ejercicio: ")
        '            Console.WriteLine("10 para salir.")
        '            opcion = Convert.ToInt32(Console.ReadLine())

        '            Select Case opcion
        '                Case 1
        '                    Dim matriz1(,) As Integer = {{3, 0, 1}, {9, 8, 1}, {5, 2, 1}}
        '                    Console.WriteLine("Último índice de fila: " & matriz1.GetUpperBound(0))
        '                    Console.WriteLine("Último índice de columna: " & matriz1.GetUpperBound(1))
        '                    Dim fila As Integer
        '                    Console.WriteLine("Escoja la fila:")
        '                    fila = Convert.ToInt32(Console.ReadLine())

        '                    Console.WriteLine("Valores fila indice : " & fila)
        '                    For i As Integer = 0 To matriz1.GetUpperBound(1) Step 1

        '                        Console.Write(matriz1(fila, i) & " ")

        '                    Next
        '                    Console.WriteLine()
        '                    Console.WriteLine("Pulse Enter para continuar")
        '                    'Guardar un cero en las últimas posiciones de cada fila

        '                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
        '                        matriz1(i, matriz1.GetUpperBound(1)) = 0
        '                    Next
        '                    Console.WriteLine("Ponemos un cero en la última columna: ")
        '                    'Para comprobarlo la mostramos por pantalla
        '                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
        '                            Console.Write(matriz1(i, j) & " ")
        '                        Next
        '                        Console.WriteLine()
        '                    Next

        '                    'Sumar todos los valores de la primera fila
        '                    Dim suma As Integer = 0

        '                    For i As Integer = 0 To matriz1.GetUpperBound(1) Step 1
        '                        suma = suma + matriz1(0, i)
        '                    Next
        '                    Console.WriteLine("La suma de la primera fila es: " & suma)

        '                    'Contar cuantos ceros hay en la segunda columna (indice 1)
        '                    Dim contador As Integer = 0
        '                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
        '                        If matriz1(i, 1) = 0 Then
        '                            contador += 1

        '                        End If
        '                    Next
        '                    If contador = 0 Then
        '                        Console.WriteLine("No hay ceros")
        '                    Else
        '                        Console.WriteLine("Hay " & contador & " ceros.")
        '                    End If
        '                Case 2
        '                    Dim matriz2(2, 2) As Integer
        '                    generarMatriz2D(matriz2, 1, 10)
        '                    Console.WriteLine("matriz de trabajo: ")
        '                    mostrarMatriz(matriz2)
        '                    Dim suma As Integer
        '                    Dim media As Double
        '                    For i As Integer = 0 To matriz2.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz2.GetUpperBound(1) Step 1
        '                            suma = suma + matriz2(i, j)
        '                        Next
        '                    Next
        '                    media = suma / matriz2.Length
        '                    Console.WriteLine("La media es : " & media)

        '                Case 3
        '                Case 4
        '                    Dim matriz4(4, 4) As Integer
        '                    generarMatriz2D(matriz4, 0, 10)
        '                    Dim contadorCeros As Integer

        '                    'Visualizar la matriz generada
        '                    mostrarMatriz(matriz4)
        '                    Console.WriteLine("Número de ceros: ")
        '                    For i As Integer = 0 To matriz4.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz4.GetUpperBound(1) Step 1
        '                            If matriz4(i, j) = 0 Then
        '                                contadorCeros += 1
        '                            End If
        '                        Next
        '                    Next
        '                    Console.WriteLine(contadorCeros)
        '                    Dim porcentaje As Double = (contadorCeros / matriz4.Length) * 100
        '                    Console.WriteLine("Porcentaje de ceros: " & porcentaje & " %")

        '                Case 5
        '                    Dim matriz5(,) As Integer = {{1, 1, 0}, {0, 1, 0}, {0, 0, 1}}
        '                    ' generarMatriz2D(matriz5, 0, 10)
        '                    'visualizar la matriz
        '                    mostrarMatriz(matriz5)
        '                    'Traspuesta
        '                    Dim matriz5traspuesta(matriz5.GetUpperBound(1), matriz5.GetUpperBound(0)) As Integer

        '                    For i As Integer = 0 To matriz5.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz5.GetUpperBound(1) Step 1
        '                            matriz5traspuesta(j, i) = matriz5(i, j)
        '                        Next

        '                    Next

        '                    Console.WriteLine("Matriz traspuesta: ")
        '                    mostrarMatriz(matriz5traspuesta)

        '                    'Comprobar si es simétrica
        '                    Dim diferente As Boolean = False

        '                    For i As Integer = 0 To matriz5.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz5.GetUpperBound(1) Step 1
        '                            If matriz5(i, j) <> matriz5traspuesta(i, j) Then
        '                                diferente = True
        '                                Exit For
        '                            End If
        '                        Next
        '                        If diferente Then
        '                            Exit For
        '                        End If
        '                    Next

        '                    If diferente Then
        '                        Console.WriteLine("no siméttrica")
        '                    Else
        '                        Console.WriteLine("simétrica.")
        '                    End If
        '                Case 6
        '                    Dim matriz6(4, 9) As Integer
        '                    Console.WriteLine("Matriz generada : ")

        '                    For i As Integer = 0 To matriz6.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz6.GetUpperBound(1) Step 1
        '                            Console.Write(matriz6(i, j) & " ")
        '                        Next
        '                        Console.WriteLine()

        '                    Next

        '                    'Suma primera fila
        '                    Dim sumaFila0 As Integer
        '                    For u As Integer = 0 To matriz6.GetUpperBound(1) Step 1
        '                        sumaFila0 = sumaFila0 + matriz6(0, u)
        '                    Next
        '                    Console.WriteLine("La suma de la primera fila es : " & sumaFila0)
        '                    Dim sumaUltimaColumna As Integer

        '                    For fila As Integer = 0 To matriz6.GetUpperBound(0) Step 1
        '                        sumaUltimaColumna = sumaUltimaColumna + matriz6(fila, matriz6.GetUpperBound(1))
        '                    Next

        '                    Console.WriteLine("La suma de la última col es: " & sumaUltimaColumna)
        '                Case 8
        '                    Dim matriz8(4, 4) As Integer
        '                    generarMatriz2D(matriz8, 1, 20)
        '                    Console.WriteLine("Matriz generada: ")
        '                    mostrarMatriz(matriz8)
        '                    Dim suma As Integer
        '                    Dim media, desviacionMinimo, desviacionMaximo As Double
        '                    Dim filaMinimo, filaMaximo, columnaMinimo, columnaMaximo As Integer
        '                    Dim minimo, maximo As Integer

        '                    For i As Integer = 0 To matriz8.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz8.GetUpperBound(1) Step 1
        '                            suma = suma + matriz8(i, j)
        '                        Next j
        '                    Next i

        '                    media = suma / matriz8.Length

        '                    minimo = matriz8(0, 0)
        '                    maximo = matriz8(0, 0)

        '                    For i As Integer = 0 To matriz8.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz8.GetUpperBound(1) Step 1
        '                            If i = 0 And j = 0 Then
        '                                Continue For
        '                            End If
        '                            If matriz8(i, j) > maximo Then
        '                                maximo = matriz8(i, j)
        '                                filaMaximo = i
        '                                columnaMaximo = j
        '                            End If
        '                        Next j
        '                    Next i

        '                    For i As Integer = 0 To matriz8.GetUpperBound(0) Step 1
        '                        For j As Integer = 0 To matriz8.GetUpperBound(1) Step 1
        '                            If matriz8(i, j) < minimo Then
        '                                minimo = matriz8(i, j)
        '                                filaMinimo = i
        '                                columnaMinimo = j
        '                            End If
        '                        Next j
        '                    Next i

        '                    desviacionMaximo = Math.Abs(maximo - media)
        '                    desviacionMinimo = Math.Abs(minimo - media)

        '                    Console.WriteLine("El mínimo está en la posición : " & filaMinimo & "," & columnaMinimo)
        '                    Console.WriteLine("El máximo está en la posición : " & filaMaximo & "," & columnaMaximo)

        '                Case 9
        '                    Dim matriz(,) As Integer = {{0, 1, 0}, {0, 0, 0}, {1, 1, 1}}



        '                    Console.ReadLine()
        '            End Select

        '        Loop While opcion < 10
    End Sub



End Module
