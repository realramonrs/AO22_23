Module FragaQuirogaGuillermo

    Public Sub generarmatriz2D(ByRef matriz(,) As Integer, ByVal limiteinf As Integer, ByVal limitesuperior As Integer)
        Dim aleatorio As New Random

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                matriz(i, j) = aleatorio.Next(limiteinf, limitesuperior + 1)
            Next
        Next

    End Sub
    Public Sub mostrarMatriz(ByRef m(,) As Integer)

        For a = 0 To m.GetUpperBound(0)
            For b = 0 To m.GetUpperBound(1)
                Console.Write(m(a, b) & " ")
            Next
            Console.WriteLine("")
            Console.WriteLine("-----------")
        Next



    End Sub


    Sub Main()

        Dim seleccion As Integer

        Console.WriteLine("Introduzca el número del ejercicio entre el 1 y el 16")
        seleccion = Convert.ToInt32(Console.ReadLine())


        Select Case seleccion

            Case 1

                Dim matriz(2, 2), seleccionarfila, suma, contador As Integer

                matriz(0, 0) = 1
                matriz(0, 1) = 2
                matriz(0, 2) = 3
                matriz(1, 0) = 4
                matriz(1, 1) = 5
                matriz(1, 2) = 6
                matriz(2, 0) = 7
                matriz(2, 1) = 8
                matriz(2, 2) = 9

                Console.WriteLine("Selecciones una fila del 0 al 2: ")
                seleccionarfila = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine(" ")

                For i = 0 To matriz.GetUpperBound(0)
                    Console.Write(matriz(seleccionarfila, i) & " ")
                Next

                Console.WriteLine("")
                Console.WriteLine("")

                For c = 0 To matriz.GetUpperBound(0)
                    matriz(c, matriz.GetUpperBound(1)) = 0
                    For h = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(c, h) & " ")
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("----------")
                Next


                Console.WriteLine(" ")


                For j = 0 To matriz.GetUpperBound(1)
                    suma += matriz(0, j)
                Next

                Console.WriteLine("Suma de la 1ª Fila: " & suma)

                For a = 0 To matriz.GetUpperBound(1)
                    If matriz(a, 1) = 0 Then
                        contador += 1
                    End If
                Next
                Console.WriteLine(" ")
                Console.WriteLine("Ceros en la segunda columna " & contador)



            Case 2

                Dim matriz(2, 2), suma, media As Double
                Dim r As New Random

                matriz(0, 0) = r.Next(1, 101)
                matriz(0, 1) = r.Next(1, 101)
                matriz(0, 2) = r.Next(1, 101)
                matriz(1, 0) = r.Next(1, 101)
                matriz(1, 1) = r.Next(1, 101)
                matriz(1, 2) = r.Next(1, 101)
                matriz(2, 0) = r.Next(1, 101)
                matriz(2, 1) = r.Next(1, 101)
                matriz(2, 2) = r.Next(1, 101)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        suma += matriz(i, j)
                    Next
                Next

                media = suma / 9

                Console.WriteLine("Media: " & media)

                Console.ReadLine()


            Case 3

                Dim temp(11, 29) As Integer
                Dim media, mes As Double

                generarmatriz2D(temp, 7, 24)

                For i = 0 To temp.GetUpperBound(0)
                    For j = 0 To temp.GetUpperBound(1)
                        Console.Write(temp(i, j) & " ")
                    Next
                Next

                Console.WriteLine(" ")

                For k = 0 To temp.GetUpperBound(0)
                    For l = 0 To temp.GetUpperBound(1)
                        media += temp(k, l)
                    Next
                    mes += 1
                    media = media / 30
                    If mes = 1 Then
                        Console.WriteLine("Media temperatura de Enero: " & media)
                    ElseIf mes = 2 Then
                        Console.WriteLine("Media temperatura de Febrero: " & media)
                    ElseIf mes = 3 Then
                        Console.WriteLine("Media temperatura de Marzo: " & media)
                    ElseIf mes = 4 Then
                        Console.WriteLine("Media temperatura de Abril: " & media)
                    ElseIf mes = 5 Then
                        Console.WriteLine("Media temperatura de Mayo: " & media)
                    ElseIf mes = 6 Then
                        Console.WriteLine("Media temperatura de Junio: " & media)
                    ElseIf mes = 7 Then
                        Console.WriteLine("Media temperatura de Julio: " & media)
                    ElseIf mes = 8 Then
                        Console.WriteLine("Media temperatura de Agosto: " & media)
                    ElseIf mes = 9 Then
                        Console.WriteLine("Media temperatura de Septiembre: " & media)
                    ElseIf mes = 10 Then
                        Console.WriteLine("Media temperatura de Octubre: " & media)
                    ElseIf mes = 11 Then
                        Console.WriteLine("Media temperatura de Noviembre: " & media)
                    ElseIf mes = 12 Then
                        Console.WriteLine("Media temperatura de Diciembre: " & media)
                    End If
                    media = 0
                Next


                Console.ReadLine()




            Case 4

                Dim matriz(2, 2), porcentaje, contador As Double
                Dim r As New Random

                matriz(0, 0) = 0
                matriz(0, 1) = 0
                matriz(0, 2) = 2
                matriz(1, 0) = 0
                matriz(1, 1) = 1
                matriz(1, 2) = 0
                matriz(2, 0) = 1
                matriz(2, 1) = 0
                matriz(2, 2) = 1

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        If matriz(i, j) = 0 Then
                            contador += 1
                        End If
                    Next
                Next

                porcentaje = (contador / matriz.Length) * 100

                Console.WriteLine("porcentaje de 0: " & porcentaje & "%")




            Case 5

                Dim matriz(2, 2), matriz2(2, 2) As Integer

                generarmatriz2D(matriz, 1, 10)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("-----------------")
                Next


                For a = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriz.GetUpperBound(1)
                        matriz2(b, a) = matriz(a, b)
                    Next
                Next

                For c = 0 To matriz.GetUpperBound(0)
                    For d = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz2(c, d) & " ")
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("-----------")
                Next


            Case 6

                Dim matriz(2, 2) As Integer
                Dim suma As Double

                generarmatriz2D(matriz, 1, 10)

                For a = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(a, b) & " ")
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("----------")
                Next

                For i = 0 To matriz.GetUpperBound(1)
                    suma += matriz(0, i)
                Next

                Console.WriteLine("")
                Console.WriteLine("Suma de la primera fila: " & suma)


            Case 7

                Dim matriz(2, 2) As Integer
                Dim suma As Double

                generarmatriz2D(matriz, 1, 10)

                For a = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(a, b) & " ")
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("----------")
                Next

                For i = 0 To matriz.GetUpperBound(1)
                    suma += matriz(matriz.GetUpperBound(0), i)
                Next

                Console.WriteLine("")
                Console.WriteLine("Suma de la ultima fila: " & suma)


            Case 8

                Dim matriz(2, 2) As Integer
                Dim minimo, maximo, desviacion, media, desviacion2, posicionf, posicionc, posicionf2, posicionc2 As Double

                generarmatriz2D(matriz, 1, 10)

                For a = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(a, b) & " ")
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("----------")
                Next

                Console.WriteLine("")

                minimo = matriz(0, 0)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        If minimo > matriz(i, j) Then
                            minimo = matriz(i, j)
                            posicionf2 = i
                            posicionc2 = j
                        End If
                    Next
                Next

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        If maximo < matriz(i, j) Then
                            maximo = matriz(i, j)
                            posicionf = i
                            posicionc = j
                        End If
                        media += matriz(i, j)
                    Next
                Next

                media = media / 9

                Console.WriteLine("")
                Console.WriteLine("Media: " & media)
                Console.WriteLine("")

                desviacion = media - maximo

                If desviacion < 0 Then
                    desviacion *= -1
                End If

                Console.WriteLine("Valor maximo: " & maximo & " desviacion: " & desviacion & " posicion: " & posicionf & "," & posicionc)
                Console.WriteLine("")

                desviacion2 = media - minimo

                If desviacion2 < 0 Then
                    desviacion2 *= -1
                End If

                Console.WriteLine("Valor minimo: " & minimo & " desviacion: " & desviacion2 & " posicion: " & posicionf2 & "," & posicionc2)


            Case 9

                Dim matriz(2, 2), contador, contador2 As Integer

                generarmatriz2D(matriz, 0, 3)
                mostrarMatriz(matriz)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        If matriz(i, j) = 0 Then
                            contador += 1
                        End If
                    Next
                    If contador = matriz.GetUpperBound(1) + 1 Then
                        Console.WriteLine("La fila " & i & " esta compuesta por ceros")
                        Console.WriteLine("")
                        contador2 += 1
                    End If
                    contador = 0
                Next

                If contador2 = 0 Then
                    Console.WriteLine("No hay ninguna fila compuesta por ceros")
                End If


            Case 10

                Dim matriz(2, 2), matriz2(2, 2), matriz3(2, 2) As Integer

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.WriteLine("Introduzca un valor para la posicion: " & i & "," & j)
                        matriz(i, j) = Convert.ToInt32(Console.ReadLine())

                    Next
                Next

                mostrarMatriz(matriz)

                For a = 0 To matriz2.GetUpperBound(0)
                    For b = 0 To matriz2.GetUpperBound(1)
                        Console.WriteLine("Introduzca un valor para la posicion: " & a & "," & b)
                        matriz2(a, b) = Convert.ToInt32(Console.ReadLine())

                    Next
                Next

                mostrarMatriz(matriz2)

                Console.WriteLine("")
                Console.WriteLine("Suma de las dos matrices: ")
                Console.WriteLine("")

                For c = 0 To matriz.GetUpperBound(0)
                    For d = 0 To matriz.GetUpperBound(1)
                        matriz3(c, d) = (matriz(c, d) + matriz2(c, d))
                    Next
                Next

                mostrarMatriz(matriz3)

            Case 11

                Dim matriz(2, 2), guardar As Integer
                Dim negativo As Boolean = False

                generarmatriz2D(matriz, -5, 5)

                mostrarMatriz(matriz)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        If matriz(i, j) < 0 Then
                            guardar = matriz(0, 0)
                            matriz(0, 0) = matriz(i, j)
                            matriz(i, j) = guardar
                            negativo = True
                            Exit For
                        End If
                    Next
                    If negativo Then
                        Exit For
                    End If
                Next

                Console.WriteLine("")
                mostrarMatriz(matriz)


            Case 12

                Dim matriz(2, 2), guardar As Integer
                Dim num As Boolean = False

                generarmatriz2D(matriz, 1, 140)

                mostrarMatriz(matriz)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        If matriz(i, j) > 100 Then
                            guardar = matriz(matriz.GetUpperBound(0), matriz.GetUpperBound(1))
                            matriz(matriz.GetUpperBound(0), matriz.GetUpperBound(1)) = matriz(i, j)
                            matriz(i, j) = guardar
                            num = True
                            Exit For
                        End If
                    Next
                    If num Then
                        Exit For
                    End If
                Next

                Console.WriteLine("")
                mostrarMatriz(matriz)


            Case 13

                Dim matriz(3, 3) As Integer

                generarmatriz2D(matriz, 0, 5)

                mostrarMatriz(matriz)


                If matriz(0, 1) = 0 And matriz(0, 2) = 0 And matriz(0, 3) = 0 And matriz(1, 2) = 0 And matriz(1, 3) = 0 And matriz(2, 3) = 0 Then
                    Console.WriteLine("Matriz triangular inferior. ")
                End If

                If matriz(1, 0) = 0 And matriz(2, 0) = 0 And matriz(2, 1) = 0 And matriz(3, 0) = 0 And matriz(3, 1) = 0 And matriz(3, 2) = 0 Then
                    Console.WriteLine("Matriz triangular superior. ")
                End If



            Case 14

                Dim matriz(3, 3) As Integer

                generarmatriz2D(matriz, 0, 5)

                mostrarMatriz(matriz)

                Console.WriteLine("")

                If matriz.GetUpperBound(0) = matriz.GetUpperBound(1) Then
                    For i = 0 To matriz.GetUpperBound(0)
                        For j = 0 To matriz.GetUpperBound(1)
                            If i = j Then
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(matriz(i, j) & " ")
                                Console.ResetColor()
                            Else
                                Console.Write(matriz(i, j) & " ")
                            End If
                        Next
                        Console.WriteLine("")
                        Console.WriteLine("-------")
                    Next
                Else
                    Console.WriteLine("La matriz no es cuadrada. ")

                    Console.WriteLine("")
                End If

            Case 15

                Dim matriz(4, 4), contador As Integer

                generarmatriz2D(matriz, -5, 5)

                mostrarMatriz(matriz)

                For g = -5 To 5

                    contador = 0

                    For i = 0 To matriz.GetUpperBound(0)
                        For j = 0 To matriz.GetUpperBound(1)
                            If matriz(i, j) = g Then
                                contador += 1
                            End If
                        Next
                    Next
                    If contador < 2 And contador > 0 Then
                        Console.WriteLine("El número " & g & " no esta repetido")
                        Console.WriteLine("")
                    End If

                Next


            Case 16


                Dim matriz(4, 4), contador, vida, pf, pc, pf1, pc1, pf2, pc2, pf3, pc3, salir As Integer
                Dim x As New Random
                vida = 6

                generarmatriz2D(matriz, 1, 5)

                mostrarMatriz(matriz)

                For i = x.Next(0, 5) To matriz.GetUpperBound(0)
                    For j = x.Next(0, 5) To matriz.GetUpperBound(1)
                        matriz(i, j) = 0
                        contador += 1
                        If contador = 1 Then
                            pf1 = i
                            pc1 = j
                        End If
                        If contador = 2 Then
                            pf2 = i
                            pc2 = j
                        End If
                        If contador = 3 Then
                            pf3 = i
                            pc3 = j
                        End If
                        If contador = 3 Then
                            Exit For
                        End If
                    Next
                    If contador = 3 Then
                        Exit For
                    End If
                Next

                Console.WriteLine("")
                Console.WriteLine("")

                mostrarMatriz(matriz)

                Console.WriteLine("")

                Console.WriteLine(pf1 & " " & pc1 & " " & pf2 & " " & pc2 & " " & pf3 & " " & pc3)

                Do

                    Console.WriteLine("Introduzca la cordenada de fila donde esta el 0: ")
                    pf = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduzca la cordenada de la columna donde esta el 0: ")
                    pc = Convert.ToInt32(Console.ReadLine())

                    If pf1 = pf And pc1 = pc Then
                        contador -= 1
                        Console.WriteLine("Hacertaste una posicion te quedan: " & contador & " posiciones para encontrar")
                    End If

                    If pf2 = pf And pc2 = pc Then
                        contador -= 1
                        Console.WriteLine("Hacertaste una posicion te quedan: " & contador & " posiciones para encontrar")
                    End If

                    If pf3 = pf And pc3 = pc Then
                        contador -= 1
                        Console.WriteLine("Hacertaste una posicion te quedan: " & contador & " posiciones para encontrar")
                    End If

                    If matriz(pf, pc) <> 0 Then
                        vida -= 1
                        Console.WriteLine("has fallado te quedan: " & vida & " vidas")
                    End If

                    Console.WriteLine("")

                    If contador = 0 Then
                        Console.ForegroundColor = ConsoleColor.Blue
                        Console.WriteLine("YOU WIN")
                        Console.ResetColor()
                        Exit Do
                    End If

                    If vida = 0 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("GAME OVER")
                        Console.ResetColor()
                        Exit Do
                    End If

                Loop While vida > 0



                Console.WriteLine("")


                Console.WriteLine("Posicion de los ceros: ")

                Console.WriteLine("")
                For a = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriz.GetUpperBound(1)
                        If matriz(a, b) = 0 Then
                            Console.ForegroundColor = ConsoleColor.Green
                            Console.Write(matriz(a, b) & " ")
                            Console.ResetColor()
                        Else
                            Console.Write(matriz(a, b) & " ")
                        End If
                    Next
                    Console.WriteLine("")
                    Console.WriteLine("-----------")
                Next



        End Select


        Console.ReadLine()



    End Sub

End Module
