Module AhnMenesesHugoMoises
    Sub main()
        Dim selector As String

        Console.WriteLine("
Selecione el ejercicio que quieras hacer:

1- Declarar una matriz 3 X 3 y darle valores en la declaración...
2- Calcular la media de una matriz 3x3
3- Realizar una aplicación que calcula la temperatura media de los 12 meses del año...
4- Calcular el porcentaje de ceros de una matriz 3x3.
5- A partir de una matriz 3x3 obtener otra matriz que sea la matriz traspuesta de la primera...
6- Calcular la suma de la primera fila de una matriz nxm.
7- Calcular la suma de la última columna de una matriz nxm
8- Calcular el valor mínimo y el máximo y sus desviaciones con respecto a la media de una matriz 2D...
9- Detectar si una matriz 3x3 tiene una fila compuesta sólo por ceros...
10- Calcular la suma de dos matrices 3x3 cuyos datos son introducidos por teclado...
11- El algoritmo debe pasar a la primera posición el primer número negativo que haya en el array...
12- El algoritmo debe pasar a la última posición el primer número superior a 100.
13- El algoritmo debe detectar si una matriz 4x4 es triangular inferior o superior.
14- Diseñar un algoritmo que verifique si una matriz es cuadrada...
15- Rellenar una matriz con 25 valores aleatorios entre -5 y 5...
16-El programa debe llenar una matriz 5x5 con números generados aleatoriamente, menos 3 posiciones que son llenadas con el número 0...
")
        selector = Console.ReadLine()

        Select Case selector
            Case "1"
                'Ejercicio 1:
                Console.Clear()
                Console.Title = "Ejercicio 1"

                'Variables:
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {0, 8, 1}}
                Dim fila, suma, contador As Double

                ' ------- A) -------
                Console.WriteLine("Escoje una fila para mostrar")
                fila = Convert.ToDouble(Console.ReadLine())

                Console.WriteLine("Los valores encontrados en la fila " & fila & ", son: ")

                fila = fila - 1

                For i = 0 To mat.GetUpperBound(0)
                    Console.Write(mat(i, fila) & " ")
                Next
                Console.WriteLine(" ")

                ' ------- B) -------

                For i = 0 To mat.GetUpperBound(0)

                    For o = 0 To mat.GetUpperBound(1)
                        mat(i, o) = mat(i, 0)
                    Next
                Next



                ' ------- C) -------

                'Test
                'Console.WriteLine("TEST: " & mat.GetUpperBound(1))

                For i = 0 To mat.GetUpperBound(0)
                    suma = suma + mat(i, 0)
                Next

                Console.WriteLine("La suma de los valores de la matriz es: " & suma)

                ' ------- D) -------

                For i = 0 To mat.GetUpperBound(0)
                    For j = 0 To mat.GetUpperBound(1)
                        If mat(i, j) = 0 Then
                            contador = contador + 1
                        End If
                    Next
                Next
                Console.WriteLine("La cantidad de 0 encontrados es de: " & contador)
                Console.ReadLine()

            Case "2"
                'Ejercicio 2:
                Console.Clear()
                Console.Title = "Ejercicio 2"
                'Variables:
                Dim mat(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
                Dim suma, media As Double

                'Suma Todos valores
                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        suma = suma + mat(i, o)
                    Next
                Next
                '45

                'Hace media
                media = suma / ((mat.GetUpperBound(0) + 1) * (mat.GetUpperBound(1) + 1))


                'muestra
                Console.WriteLine("La media es: " & media)
                Console.ReadLine()

            Case "3"
                'Ejercicio 3:
                Console.Clear()
                Console.Title = "Ejercicio 3"

                'Variables:
                Dim TempMedia12, contarBonito1, contarBonito2, suma As Double
                Dim mes(11, 30) As Integer

                For i = 0 To mes.GetUpperBound(0)
                    contarBonito1 = i + 1
                    Console.WriteLine("Introduzca las temperaturas del mes: " & contarBonito1)
                    For o = 0 To mes.GetUpperBound(1) - 1
                        contarBonito2 = o + 1
                        Console.WriteLine("Registra la temp: " & contarBonito2)
                        mes(i, o) = Convert.ToInt32(Console.ReadLine())
                    Next o
                Next i

                For i = 0 To mes.GetUpperBound(0)
                    For o = 0 To mes.GetUpperBound(1)
                        suma += mes(i, o)
                    Next o
                Next i

                TempMedia12 = suma / 360

                Console.WriteLine("Temperatura media: " & TempMedia12)
                Console.ReadLine()

            Case "4"
                'Ejercicio 4:
                Console.Clear()
                Console.Title = "Ejercicio 4"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {0, 8, 1}}
                Dim xCentaje, contador As Double

                For i = 0 To 2
                    For j = 0 To 2
                        If mat(i, j) = 0 Then
                            contador = contador + 1
                        End If
                    Next
                Next

                xCentaje = contador / 100
                Console.WriteLine("El porcentaje de 0 es de:" & xCentaje)

                Console.ReadLine()

            Case "5"
                'Ejercicio 5:
                Console.Clear()
                Console.Title = "Ejercicio 5"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {0, 8, 1}}
                Dim Mat2(2, 2) As Integer
                Dim filas As Integer = 3
                Dim columnas As Integer = 3
                Dim Simetrico As Boolean = True

                For i = 1 To mat.GetUpperBound(0)
                    For o = 1 To mat.GetUpperBound(1)
                        Mat2(o, i) = mat(i, o)
                    Next
                Next

                For i = 0 To 1
                    For o = 0 To 1
                        Mat2(o, i) = mat(i, o)
                    Next
                Next

                For i = 0 To mat.GetUpperBound(0)
                    For j = 0 To mat.GetUpperBound(1)
                        Console.Write(mat(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine("-------------------------------")

                For i = 0 To Mat2.GetUpperBound(0)
                    For j = 0 To Mat2.GetUpperBound(1)
                        Console.Write(Mat2(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next



                For i = 0 To filas - 1
                    For o = 0 To columnas - 1

                        If mat(i, o) <> mat(o, i) Then
                            Simetrico = False
                            Exit For
                        End If
                    Next
                    If Not Simetrico Then Exit For
                Next

                If Simetrico = True Then
                    Console.WriteLine("La matriz es simétrica")
                Else
                    Console.WriteLine("La matriz no es simétrica")
                End If
                Console.ReadLine()

            Case "6"
                'Ejercicio 6:
                Console.Clear()
                Console.Title = "Ejercicio 6"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {0, 8, 1}}
                '1 2 3
                '9 5 2
                '0 8 1
                '  Dim mat2(,) As Integer = {{9, 8, 7}, {6, 5, 4}, {3, 2, 1}}
                Dim suma As Double

                For i = 0 To mat.GetUpperBound(1)
                    suma = suma + mat(0, i)
                Next



                Console.WriteLine("La suma de los valores de la matriz es: " & suma)

                Console.ReadLine()

            Case "7"
                'Ejercicio 7:
                Console.Clear()
                Console.Title = "Ejercicio 7"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {0, 8, 1}}
                Dim mat2(,) As Integer = {{9, 8, 7}, {6, 5, 4}, {3, 2, 1}}
                Dim suma As Double

                For i = 0 To mat.GetUpperBound(1)
                    suma = suma + mat(i, 2)
                Next

                For i = 0 To mat2.GetUpperBound(1)
                    suma = suma + mat2(i, 2)
                Next

                Console.WriteLine("La suma de los valores de la matriz es: " & suma)

                Console.ReadLine()

            Case "8"
                'Ejercicio 8:
                Console.Clear()
                Console.Title = "Ejercicio 8"

                'Variables
                Dim min, max, desviacion, media, suma, contadorPosicion, contadorPosicion2 As Double
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {-0, 8, 1}}

                min = 12736917283967

                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        If mat(i, o) < min Then
                            min = mat(i, o)
                            contadorPosicion = contadorPosicion + 1
                        End If
                    Next
                Next


                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        If mat(i, o) > max Then
                            max = mat(i, o)
                            contadorPosicion2 = contadorPosicion2 + 1
                        End If
                    Next
                Next

                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        suma = suma + mat(i, o)
                    Next
                Next

                'Hace media
                media = suma / ((mat.GetUpperBound(0) + 1) * (mat.GetUpperBound(1) + 1))

                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        desviacion = Math.Abs(mat(i, o) - media)
                        Console.WriteLine("La desviación de " & mat(i, o) & ", es de: " & desviacion)
                    Next
                Next

                Console.WriteLine("El valor min es: " & min & ", si se encunetra en la posición: " & contadorPosicion)
                Console.WriteLine("El valor max es: " & max & ", si se encunetra en la posición: " & contadorPosicion2)


                Console.ReadLine()

            Case "9"
                'Ejercicio 9:
                Console.Clear()
                Console.Title = "Ejercicio 9"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {0, 8, 1}}
                Dim contador As Double

                For i = 0 To mat.GetUpperBound(0)
                    For j = 0 To mat.GetUpperBound(1)
                        contador = contador + 1
                    Next
                    If contador = 3 Then
                        Console.WriteLine("Fila compuesta sólo por ceros, encontrada")
                        Exit For
                    Else
                        contador = 0
                    End If
                Next
                Console.ReadLine()
            Case "10"
                'Ejercicio 10:
                Console.Clear()
                Console.Title = "Ejercicio 10"

                'Variables
                Dim suma As Double
                Dim mat(2, 2) As Integer
                Dim mat2(2, 2) As Integer

                Console.WriteLine("Introduzca datos para la primera matriz")
                Console.WriteLine(" ")
                For i = 0 To mat.GetUpperBound(0)
                    Console.WriteLine("introduzca los elementos de la fila: " & i)
                    For o = 0 To mat.GetUpperBound(1)
                        Console.WriteLine("introduzca los elementos de la columna: " & o)
                        mat(i, o) = Convert.ToInt32(Console.ReadLine())
                    Next
                Next

                Console.WriteLine("Introduzca datos para la segunda matriz")
                Console.WriteLine(" ")

                For i = 0 To mat2.GetUpperBound(0)
                    Console.WriteLine("introduzca los elementos de la fila: " & i)
                    For o = 0 To mat2.GetUpperBound(1)
                        Console.WriteLine("introduzca los elementos de la columna: " & o)
                        mat2(i, o) = Convert.ToInt32(Console.ReadLine())
                    Next
                Next

                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        suma = suma + mat(i, o)
                    Next
                Next

                For i = 0 To mat2.GetUpperBound(0)
                    For o = 0 To mat2.GetUpperBound(1)
                        suma = suma + mat(i, o)
                    Next
                Next

                Console.WriteLine("La suma de los valores de la matriz es: " & suma)

                Console.ReadLine()

            Case "11"
                'Ejercicio 11:
                Console.Clear()
                Console.Title = "Ejercicio 11"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {-9, 8, 1}}

                Console.WriteLine(" ")
                Console.WriteLine("Before")
                Console.WriteLine(" ")

                'Before
                For i As Integer = 0 To mat.GetUpperBound(0)
                    For j = 0 To mat.GetUpperBound(1)
                        Console.Write(mat(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        If mat(i, o) < 0 Then
                            mat(0, 0) = mat(i, o)
                        End If
                    Next
                Next
                Console.WriteLine(" ")
                Console.WriteLine("After")
                Console.WriteLine(" ")

                'after
                For i As Integer = 0 To mat.GetUpperBound(0)
                    For j = 0 To mat.GetUpperBound(1)
                        Console.Write(mat(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next
                Console.ReadLine()
            Case "12"
                'Ejercicio 12:
                Console.Clear()
                Console.Title = "Ejercicio 12"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {-9, 8, 1}}

                Console.WriteLine(" ")
                Console.WriteLine("Before")
                Console.WriteLine(" ")

                'Before
                For i As Integer = 0 To mat.GetUpperBound(0)
                    For j = 0 To mat.GetUpperBound(1)
                        Console.Write(mat(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        If mat(i, o) > 100 Then
                            mat(2, 2) = mat(i, o)
                        End If
                    Next
                Next
                Console.WriteLine(" ")
                Console.WriteLine("After")
                Console.WriteLine(" ")

                'after
                For i As Integer = 0 To mat.GetUpperBound(0)
                    For j = 0 To mat.GetUpperBound(1)
                        Console.Write(mat(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next
                Console.ReadLine()
            Case "13"
                'Ejercicio 13:
                Console.Clear()
                Console.Title = "Ejercicio 13"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 0, 6}, {9, 5, 2, 6}, {-9, 8, 1, 2}, {5, 9, 0, 0}}

                If mat(0, 1) = 0 And mat(0, 2) = 0 And mat(0, 3) = 0 And mat(1, 2) = 0 And mat(1, 3) = 0 And mat(3, 3) = 0 Then
                    Console.WriteLine("Matriz triangular superior ENCONTRADO")
                End If

                If mat(1, 0) = 0 And mat(2, 0) = 0 And mat(2, 1) = 0 And mat(3, 0) = 0 And mat(3, 1) = 0 And mat(3, 2) = 0 Then
                    Console.WriteLine("Matriz triangular inferior ENCONTRADO")
                End If

                Console.ReadLine()
            Case "14"
                'Ejercicio 14:
                Console.Clear()
                Console.Title = "Ejercicio 14"

                'Variables
                Dim mat(,) As Integer = {{1, 2, 3}, {9, 5, 2}, {-9, 8, 1}}
                Dim contador1, contador2 As Double

                For i = 0 To mat.GetUpperBound(0)
                    contador1 = contador1 + 1
                Next

                For i = 0 To mat.GetUpperBound(1)
                    contador2 = contador2 + 1
                Next

                If contador1 = contador2 Then
                    Console.WriteLine("Matriz es cuadrada!!!")
                    Console.WriteLine(" ")

                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write(mat(0, 0))
                    Console.ResetColor()
                    Console.Write(mat(0, 1))
                    Console.Write(mat(0, 2))

                    Console.Write(mat(1, 0))
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write(mat(1, 1))
                    Console.ResetColor()
                    Console.Write(mat(1, 2))

                    Console.Write(mat(2, 0))
                    Console.Write(mat(2, 1))
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write(mat(2, 0))
                    Console.ResetColor()

                End If
                Console.ReadLine()
            Case "15"
                'Ejercicio 15:
                Console.Clear()
                Console.Title = "Ejercicio 15"

                'Variables
                Dim rand As New Random
                Dim mat(4, 4)
                Dim mat2(4, 4)
                Dim Repetido As Boolean

                Repetido = False



                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)
                        mat(i, o) = rand.Next(-5, 5)
                    Next
                Next
                Console.WriteLine("Matriz generada: ")
                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)

                        Console.Write(mat(i, o) & " ")
                    Next
                    Console.WriteLine()
                Next
                Console.WriteLine("------------------")
                For i = 0 To mat.GetUpperBound(0)
                    For o = 0 To mat.GetUpperBound(1)


                        For x = 0 To mat2.GetUpperBound(0)
                            For d = 0 To mat2.GetUpperBound(1)

                                If mat(i, o) = mat2(x, d) Then
                                    Repetido = True
                                End If
                            Next
                        Next
                        mat2(i, o) = mat(i, o)
                        If Repetido = True Then

                        Else
                            Console.Write(mat(i, o) & " ")
                        End If
                        Repetido = False
                    Next
                    Console.WriteLine()
                Next

                Console.ReadLine()

            Case "16"
                'Ejercicio 16
                Console.Clear()
                Console.Title = "Ejercicio 16"

                'Variables
                Dim mat(4, 4) As Integer
                Dim rand As New Random()
                Dim vidas As Integer = 6
                Dim intentoFila As Double
                Dim intentoColumna As Double

                For i = 0 To 4
                    For o = 0 To 4
                        mat(i, o) = rand.Next(1, 9)
                    Next
                Next

                ' Matriz(posición,posición) = 0
                mat(rand.Next(0, 4), rand.Next(0, 4)) = 0
                mat(rand.Next(0, 4), rand.Next(0, 4)) = 0
                mat(rand.Next(0, 4), rand.Next(0, 4)) = 0

                '' TEST DISPLAY (si quieres hacer trampas ;))
                'For i As Integer = 0 To 4
                '    For j As Integer = 0 To 4
                '        Console.Write(mat(i, j) & " ")
                '    Next
                '    Console.WriteLine()
                'Next

                Do
                    Console.WriteLine("Escribe donde crees que hay un 0 [Fila]")
                    intentoFila = Convert.ToDouble(Console.ReadLine)

                    Console.WriteLine("Escribe donde crees que hay un 0 [Columna]")
                    intentoColumna = Convert.ToDouble(Console.ReadLine)

                    If mat(intentoFila, intentoColumna) = 0 Then
                        Console.Clear()
                        Console.WriteLine("LO HAS ADVINADO")
                        Exit Do
                    Else
                        Console.Clear()
                        Console.WriteLine("Has fallado :( | Te quedan: " & vidas)
                        vidas = vidas - 1
                    End If
                Loop Until vidas = 0

                Console.Clear()
                Console.WriteLine("Se acabaron tus vidas. Fin del juego.")

                Console.ReadLine()
        End Select
    End Sub
End Module
