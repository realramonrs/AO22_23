Module Module1

    Sub Main()
        Dim opcion As Integer
        Do
            Console.WriteLine("Escoja un ejercicio: ")
            Console.WriteLine("10 para salir.")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    Dim matriz1(,) As Integer = {{3, 0, 1}, {9, 8, 1}, {5, 2, 1}}
                    Console.WriteLine("Último índice de fila: " & matriz1.GetUpperBound(0))
                    Console.WriteLine("Último índice de columna: " & matriz1.GetUpperBound(1))
                    Dim fila As Integer
                    Console.WriteLine("Escoja la fila:")
                    fila = Convert.ToInt32(Console.ReadLine())

                    Console.WriteLine("Valores fila indice : " & fila)
                    For i As Integer = 0 To matriz1.GetUpperBound(1) Step 1

                        Console.Write(matriz1(fila, i) & " ")

                    Next
                    Console.WriteLine()
                    Console.WriteLine("Pulse Enter para continuar")
                    'Guardar un cero en las últimas posiciones de cada fila

                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                        matriz1(i, matriz1.GetUpperBound(1)) = 0
                    Next
                    Console.WriteLine("Ponemos un cero en la última columna: ")
                    'Para comprobarlo la mostramos por pantalla
                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                            Console.Write(matriz1(i, j) & " ")
                        Next
                        Console.WriteLine()
                    Next

                    'Sumar todos los valores de la primera fila
                    Dim suma As Integer = 0

                    For i As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                        suma = suma + matriz1(0, i)
                    Next
                    Console.WriteLine("La suma de la primera fila es: " & suma)

                    'Contar cuantos ceros hay en la segunda columna (indice 1)
                    Dim contador As Integer = 0
                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                        If matriz1(i, 1) = 0 Then
                            contador += 1

                        End If
                    Next
                    If contador = 0 Then
                        Console.WriteLine("No hay ceros")
                    Else
                        Console.WriteLine("Hay " & contador & " ceros.")
                    End If
                Case 2
                    Dim matriz2(2, 2) As Integer
                    generarMatriz2D(matriz2, 1, 10)
                    Console.WriteLine("matriz de trabajo: ")
                    mostrarMatriz(matriz2)
                    Dim suma As Integer
                    Dim media As Double
                    For i As Integer = 0 To matriz2.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz2.GetUpperBound(1) Step 1
                            suma = suma + matriz2(i, j)
                        Next
                    Next
                    media = suma / matriz2.Length
                    Console.WriteLine("La media es : " & media)

                Case 3
                Case 4
                    Dim matriz4(4, 4) As Integer
                    generarMatriz2D(matriz4, 0, 10)
                    Dim contadorCeros As Integer

                    'Visualizar la matriz generada
                    mostrarMatriz(matriz4)
                    Console.WriteLine("Número de ceros: ")
                    For i As Integer = 0 To matriz4.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz4.GetUpperBound(1) Step 1
                            If matriz4(i, j) = 0 Then
                                contadorCeros += 1
                            End If
                        Next
                    Next
                    Console.WriteLine(contadorCeros)
                    Dim porcentaje As Double = (contadorCeros / matriz4.Length) * 100
                    Console.WriteLine("Porcentaje de ceros: " & porcentaje & " %")

                Case 5
                    Dim matriz5(,) As Integer = {{1, 1, 0}, {0, 1, 0}, {0, 0, 1}}
                    ' generarMatriz2D(matriz5, 0, 10)
                    'visualizar la matriz
                    mostrarMatriz(matriz5)
                    'Traspuesta
                    Dim matriz5traspuesta(matriz5.GetUpperBound(1), matriz5.GetUpperBound(0)) As Integer

                    For i As Integer = 0 To matriz5.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz5.GetUpperBound(1) Step 1
                            matriz5traspuesta(j, i) = matriz5(i, j)
                        Next

                    Next

                    Console.WriteLine("Matriz traspuesta: ")
                    mostrarMatriz(matriz5traspuesta)

                    'Comprobar si es simétrica
                    Dim diferente As Boolean = False

                    For i As Integer = 0 To matriz5.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz5.GetUpperBound(1) Step 1
                            If matriz5(i, j) <> matriz5traspuesta(i, j) Then
                                diferente = True
                                Exit For
                            End If
                        Next
                        If diferente Then
                            Exit For
                        End If
                    Next

                    If diferente Then
                        Console.WriteLine("no siméttrica")
                    Else
                        Console.WriteLine("simétrica.")
                    End If


                    Console.ReadLine()
            End Select

        Loop While opcion < 10
    End Sub



End Module
