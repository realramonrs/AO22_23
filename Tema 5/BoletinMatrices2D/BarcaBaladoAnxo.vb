Imports System.ComponentModel

Module BarcaBaladoAnxo
    Public Sub GenerarMatriz(ByRef matriz(,) As Integer)
        'Genera un Array y le da valores entre 1 y 100
        Dim aleatorio As New Random
        For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                matriz(i, j) = aleatorio.Next(1, 100)
            Next
        Next
    End Sub
    Public Sub GenerarMatriz(ByRef matriz(,) As Integer, ByRef LimitUp As Integer, ByRef LimitDown As Integer)
        'Genera Array con un Limite escrito 
        Dim aleatorio As New Random
        For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                matriz(i, j) = aleatorio.Next(LimitDown, LimitUp)
            Next
        Next
    End Sub
    Public Sub MostrarMatriz(ByRef matriz(,) As Integer)
        'Genera un Array y le da valores entre 1 y 100
        Console.WriteLine("Matriz: ")
        For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine(" ")
        Next
        Console.WriteLine("")
    End Sub

    Sub Main() 'Boletin Tema 5: Arrais 2D
        Dim EjercicioSeleccionado As String
        Dim VariableDeSalida As Double
        Do
            EjercicioSeleccionado = InputBox("Ingrese el ejercicio que quiere ejecutar entre el numero 1 y el 16 o escriba exit para salir")
            Select Case EjercicioSeleccionado
                Case "1"
                    Console.Clear()
                    Dim matriz(,) As Integer = {{1, 2, 2}, {3, 1, 2}, {2, 8, 1}}
                    MostrarMatriz(matriz)
                    'Solicitar al usuario que escoja una fila y mostrarle los valores de esa fila.
                    Dim Fila As Integer
                    Fila = Convert.ToInt32(InputBox("Ingrese una fila"))
                    For i As Integer = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(Fila, i) & " ")
                    Next
                    Console.WriteLine(" ")
                    Console.WriteLine(" ")
                    'Guardar un cero en las últimas posiciones de cada fila.
                    For i As Integer = 0 To matriz.GetUpperBound(0)
                        matriz(i, matriz.GetUpperBound(0)) = 0
                    Next
                    MostrarMatriz(matriz)
                    Dim Suma As Integer
                    For i As Integer = 0 To matriz.GetUpperBound(1)
                        Suma += matriz(0, i)
                    Next
                    Console.WriteLine("La suma de los numeros de la primera linea es: " & Suma)
                    Dim Suma2 As Integer
                    For i As Integer = 0 To matriz.GetUpperBound(0)
                        If matriz(i, 1) = 0 Then
                            Suma2 += 1
                        End If
                    Next
                    Console.WriteLine("Hay estos 0 en la segunda Columna: " & Suma2)
                    Console.WriteLine("")
                    Console.ReadKey()
                Case "2"
                    Console.Clear()
                    'Calcular la media de una matriz 3x3
                    Dim matriz(2, 2) As Integer
                    Dim aleatorio As New Random
                    GenerarMatriz(matriz)
                    MostrarMatriz(matriz)
                    Dim Suma, Media As Integer
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            Suma += matriz(i, j)
                        Next
                    Next
                    Media = Suma / matriz.Length
                    Console.WriteLine(Suma)
                    Console.WriteLine(matriz.Length)
                    Console.WriteLine("La media de todos los valores es: " & Media)
                Case "4"
                    Console.Clear()
                    'Calcular el porcentaje de ceros de una matriz 3x3.
                    Dim matriz(2, 2) As Integer
                    Dim aleatorio As New Random
                    GenerarMatriz(matriz, 3, 0)
                    MostrarMatriz(matriz)

                    Dim Suma0, media As Integer
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            If matriz(i, j) = 0 Then
                                Suma0 += 1
                            End If
                        Next
                    Next
                    media = Suma0 / matriz.Length * 100
                    Console.WriteLine("Hay un total de: " & Suma0 & " ceros: " & media & "%")
                    Console.ReadKey()
                Case "3"
                    Console.Clear()
                    'Realizar una aplicación que calcula la temperatura media de los 12 meses del año. Para ello se registran 30 valores para cada mes.
                    Dim matriz(11, 29), Suma As Integer
                    GenerarMatriz(matriz, -10, 40)
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            Suma += matriz(i, j)
                        Next
                    Next
                    MostrarMatriz(matriz)
                    Console.WriteLine("")
                    Console.WriteLine("la temperatura media del año fue de " & (Suma / (12 * 30)))
                    Console.ReadKey()
                Case "5"
                    'A partir de una matriz 3x3 obtener otra matriz que sea la matriz traspuesta de la primera.
                    Console.Clear()
                    'Comprobar que es simétrica.
                    Dim matriz(2, 2), Salida As Integer
                    GenerarMatriz(matriz, 3, 0)
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            Console.Write(matriz(i, j) & " ")
                        Next
                        Console.WriteLine(" ")
                    Next
                    Console.WriteLine()
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            Console.Write(matriz(j, i) & " ")
                        Next
                        Console.WriteLine(" ")
                    Next
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            If matriz(j, i) <> matriz(i, j) Then
                                Console.WriteLine("No es simetrica")
                                Salida = 2
                                Exit For
                            End If
                        Next
                        If Salida = 2 Then
                            Exit For
                        End If
                        Console.WriteLine(" ")
                    Next
                    Console.ReadKey()
                Case "6"
                    Console.Clear()
                    'Calcular la suma de la primera fila de una matriz 3x3.
                    Dim matriz(3, 3) As Integer
                    Dim aleatorio As New Random
                    Dim suma As Integer
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            matriz(i, j) = aleatorio.Next(0, 3)
                        Next
                    Next
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            Console.Write(matriz(i, j) & " ")
                        Next
                        Console.WriteLine(" ")
                    Next
                    Console.WriteLine(" ")
                    For i = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(0, i) & " ")
                        suma += matriz(0, i)
                    Next
                    Console.WriteLine(" ")
                    Console.WriteLine("La suma de los elementos de la primera linea es " & suma)
                    Console.ReadKey()
                Case "7"
                    'Calcular la suma de la última columna de una matriz 3x3.
                    Dim matriz(3, 3) As Integer
                    Dim aleatorio As New Random
                    Dim suma As Integer
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            matriz(i, j) = aleatorio.Next(0, 3)
                        Next
                    Next
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            Console.Write(matriz(i, j) & " ")
                        Next
                        Console.WriteLine(" ")
                    Next
                    Console.WriteLine(" ")
                    For i = 0 To matriz.GetUpperBound(0)
                        Console.Write(matriz(i, matriz.GetUpperBound(1)) & " ")
                        suma += matriz(i, matriz.GetUpperBound(1))
                    Next
                    Console.WriteLine(" ")
                    Console.WriteLine(" ")
                    Console.WriteLine("La suma de los elementos de la ultima columna es " & suma)
                Case "8"
                    'Calcular el valor mínimo y el máximo y sus desviaciones con respecto a la media de una matriz 2D. Indicar en qué posiciones de la matriz se encuentran estos valores.
                    Dim matriz(1, 1) As Integer
                    Dim suma, min, max, media As Integer
                    min = matriz(0, 0)
                    GenerarMatriz(matriz, 5, 0)
                    MostrarMatriz(matriz)
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            suma += matriz(i, j)
                            If matriz(i, j) < min Then
                                min = matriz(i, j)
                            End If
                            If matriz(i, j) > max Then
                                max = matriz(i, j)
                            End If
                        Next
                    Next
                    media = suma / 4
                    Console.WriteLine()
                    Console.WriteLine("El valor minimo de la matriz es " & min & " y esta a " & (min - media) & " de la media, el valor max es " & max & " y esta a " & (max - media) & " de la media")
                Case "9"
                    'Detectar si una matriz 3x3 tiene una fila compuesta sólo por ceros.
                    Dim matriz(3, 3), filacumple As Integer
                    GenerarMatriz(matriz, 4, 0)
                    MostrarMatriz(matriz)
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            If matriz(i, j) = 0 Then
                                filacumple += 1
                            End If
                        Next
                        If filacumple = 4 Then
                            Console.WriteLine("La fila: " & (i + 1) & "tiene todo 0")
                        End If
                        filacumple = 0
                    Next
                Case "10"
                    Dim matriz1(3, 3), matriz2(3, 3), suma As Integer
                    Console.WriteLine()

                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                            matriz1(i, j) = InputBox("Ingrese el valor para " & i & " " & j)
                        Next
                    Next
                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                            matriz2(i, j) = InputBox("Ingrese el valor para " & i & " " & j)
                        Next
                    Next
                    MostrarMatriz(matriz1)
                    MostrarMatriz(matriz2)
                    Console.WriteLine("Matriz sumada:")
                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                            matriz1(i, j) += matriz2(i, j)
                        Next
                    Next

                    For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                            suma += matriz1(i, j)
                        Next
                    Next
                Case "11"
                    ' El algoritmo debe pasar a la primera posición el primer número negativo que haya en el array.
                    Dim matriz(5, 5), PrimerNegativo, Salir As Integer
                    GenerarMatriz(matriz, 150, -10)
                    MostrarMatriz(matriz)
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            If matriz(i, j) < 0 Then
                                Salir = 5
                                PrimerNegativo = matriz(i, j)
                                matriz(i, j) = 0
                                Exit For

                            End If
                        Next
                        If Salir = 5 Then
                            Exit For

                        End If
                    Next
                    matriz(0, 0) = PrimerNegativo
                Case "12"
                    'El algoritmo debe pasar a la última posición el primer número superior a 100.
                    Dim matriz(5, 5), salir, Primermax As Integer
                    GenerarMatriz(matriz, 150, 10)
                    MostrarMatriz(matriz)
                    MostrarMatriz(matriz)
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            If matriz(i, j) > 100 Then
                                salir = 5
                                Primermax = matriz(i, j)
                                matriz(i, j) = 0
                                Exit For

                            End If
                        Next
                        If salir = 5 Then
                            Exit For

                        End If
                    Next
                    matriz(5, 5) = Primermax
                Case "13"
                    'El algoritmo debe detectar si una matriz 4x4 es triangular inferior o superior.
                    Dim matriz(4, 4), matrizcuadradainferior(4, 4), matrizcuadradasuperioir(4, 4) As Integer
                    GenerarMatriz(matriz, 2, 0)
                    MostrarMatriz(matriz)
                    matrizcuadradasuperioir = {{1, 1, 1, 1}, {1, 1, 1, 0}, {1, 1, 0, 0}, {1, 0, 0, 0}}
                    matrizcuadradainferior = {{1, 0, 0, 0}, {1, 1, 0, 0}, {1, 1, 1, 0}, {1, 1, 1, 1}}
                    If matriz.Equals(matrizcuadradainferior) Then
                        Console.WriteLine("La matriz es triangular inferioir")
                    End If
                    If matriz.Equals(matrizcuadradainferior) Then
                        Console.WriteLine("La matriz es triangular superior")
                    End If
                Case "14"
                    'Diseñar un algoritmo que verifique si una matriz es cuadrada , en cuyo caso muestra los elementos de la diagonal principal resaltados en rojo
                    Dim n As Integer
                    Dim n1 As Integer = InputBox("Ingrese el numero de Columnas")
                    Dim n2 As Integer = InputBox("Ingrese el numero de Filas")
                    Dim matriz(n1, n2) As Integer
                    If matriz.GetUpperBound(0) <> matriz.GetUpperBound(1) Then
                        Console.WriteLine("La matriz no es cuadrada")
                    End If
                    If matriz.GetUpperBound(0) = matriz.GetUpperBound(1) Then
                        Console.WriteLine("La matriz es cuadrada")
                    End If
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            If i = j Then

                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(matriz(i, j))
                                Console.ResetColor()
                                'No soy capaz de que se quede solo ese color
                            Else
                                Console.Write(matriz(i, j))
                            End If
                            ' Console.ForegroundColor = ConsoleColor.White
                            '  Console.Write(i, j)
                        Next
                        '  n += 1
                        Console.WriteLine("")
                    Next
                Case "15"
                    'Rellenar una matriz con 25 valores aleatorios entre -5 y 5. Mostrar por pantalla aquellos valores de la matriz que no están repetidos.
                    Dim matriz(4, 4) As Integer
                    Dim Matriz2() As Integer
                    Dim Salir = 2
                    GenerarMatriz(matriz, 5, -5)
                    MostrarMatriz(matriz)
                    Console.WriteLine("")

                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            For k As Integer = 0 To matriz.GetUpperBound(0) Step 1
                                For l As Integer = 0 To matriz.GetUpperBound(1) Step 1
                                    If matriz(i, j) = matriz(k, l) Then
                                        Salir += 2
                                    End If
                                    If Salir = 4 Then
                                        Exit For
                                    End If
                                    If matriz(i, j) <> matriz(k, l) And matriz(k, l) = matriz(4, -4) Then
                                        Console.WriteLine(matriz(i, j))
                                    End If
                                Next
                                If Salir = 4 Then
                                    Exit For
                                End If
                            Next
                        Next
                        Console.WriteLine()
                    Next
                Case "16"
                    'El programa debe llenar una matriz 5x5 con números generados aleatoriamente, menos 3 posiciones que son llenadas con el número 0. A continuación se va solicitando al usuario que introduzca las coordenadas donde cree que hay un cero.El usuario tiene 6 vidas cada vez que falla se le resta una.

                Case "exit"
                    VariableDeSalida = 4
                Case Else
                    MsgBox("Error con el dato introducido")
            End Select
        Loop Until VariableDeSalida = 4
        Console.ReadKey()
    End Sub

End Module
