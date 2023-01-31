Module BenavidesHermidaAnxo

    Sub Main()
        Dim ejercicios As Integer
        Do
            ejercicios = CInt(InputBox("Elija un ejercicio del 1 al 16 y opción 17 para salir"))
            Select Case ejercicios
                Case 1
                    'Ejercicio 1: Anxo Benavides, Declarar una matriz 3 X 3 y darle valores en la declaración.
                    Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
                    Dim apartados As Integer
                    apartados = CInt(InputBox("Elija un apartado del 1 al 4"))
                    Select Case apartados
                        Case 1
                            Dim eleccion As Integer
                            eleccion = CInt(InputBox("Elija una de las 3 filas"))
                            If eleccion = 1 Then
                                For i As Integer = 0 To 2 Step 1
                                    Console.Write(matriz(0, i) & " ")
                                Next
                                Console.WriteLine()
                            ElseIf eleccion = 2 Then
                                For i As Integer = 0 To 2 Step 1
                                    Console.Write(matriz(1, i) & " ")
                                Next
                                Console.WriteLine()
                            ElseIf eleccion = 3 Then
                                For i As Integer = 0 To 2 Step 1
                                    Console.Write(matriz(1, i) & " ")
                                Next
                                Console.WriteLine()
                            End If
                        Case 2
                            Dim valor As Integer = 0
                            matriz(0, 2) = valor
                            matriz(1, 2) = valor
                            matriz(2, 2) = valor
                            For j As Integer = 0 To 2 Step 1
                                For i As Integer = 0 To 2 Step 1
                                    Console.Write(matriz(j, i) & " ")
                                Next
                                Console.WriteLine()
                            Next
                        Case 3
                            Dim suma As Integer
                            suma = matriz(0, 0) + matriz(0, 1) + matriz(0, 2)
                            Console.WriteLine("La suma de la primera fila es " & suma)
                        Case 4
                            Dim columna As Integer
                            For i As Integer = 0 To 2 Step 1
                                If matriz(i, 1) = 0 Then
                                    columna += 1
                                End If
                            Next
                            Console.WriteLine("La cantidad de ceros en la 2º columna es de " & columna)
                    End Select
                Case 2
                    'Ejercicio 2: Anxo Benavides, Calcular la media de una matriz 3x3.
                    Dim matriz2(2, 2) As Integer
                    Dim suma2 As Integer
                    Dim media As Double
                    Dim aleatorio As New Random
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            matriz2(j, i) = aleatorio.Next(1, 100)
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz2(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            suma2 += matriz2(j, i)
                        Next
                    Next
                    media = suma2 / matriz2.Length
                    Console.WriteLine("La media de esta matriz es " & media)
                Case 3
                    'Ejercicio 3: Anxo Benavides, Realizar una aplicación que calcula la temperatura media de los 12 meses del año.
                    'Para ello se registran 30 valores para cada mes.
                    Dim mes(4, 7) As Integer
                    Dim suma, contador, eleccion As Integer
                    Dim media As Double
                    Dim aleatorio As New Random
                    Do
                        eleccion = CInt(InputBox("Quiere saber la temperatura de este mes? Elija 1 para si o 2 para no"))
                        If eleccion = 1 Then
                            For j = 0 To 4 Step 1
                                For i = 0 To 7 Step 1
                                    mes(j, i) = aleatorio.Next(-10, 50)
                                Next
                            Next
                            For j = 0 To 4 Step 1
                                For i = 0 To 7 Step 1
                                    Console.Write(mes(j, i) & "  | ")
                                Next
                                Console.WriteLine()
                            Next
                            For j = 0 To 4 Step 1
                                For i = 0 To 7 Step 1
                                    suma += mes(j, i)
                                Next
                            Next
                            media = suma / mes.Length
                            Console.WriteLine("Esta es la temperatura media de este mes: " & media & " ºC")
                            contador += 1
                            media = 0
                        Else
                            Exit Do
                        End If
                    Loop Until contador = 12
                    contador = 0
                Case 4
                    'Ejercicio 4: Anxo Benavides, Calcular el porcentaje de ceros de una matriz 3x3.
                    Dim matriz3(2, 2) As Integer
                    Dim contar As Integer
                    Dim porcentaje As Double
                    Dim aleatorio As New Random
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            matriz3(j, i) = aleatorio.Next(0, 2)
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz3(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            If matriz3(j, i) = 0 Then
                                contar += 1
                            End If
                        Next
                    Next
                    porcentaje = (contar / matriz3.Length) * 100
                    Console.WriteLine("El porcentaje de ceros es de " & porcentaje & "%")
                Case 5
                    'Ejercicio 5: Anxo Benavides, A partir de una matriz 3x3 obtener otra matriz que sea la matriz traspuesta de la primera.
                    Dim matriz4(2, 2) As Integer
                    Dim matriz5(2, 2) As Integer
                    Dim simetria As Integer
                    Dim aleatorio As New Random
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            matriz4(j, i) = aleatorio.Next(0, 2)
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            matriz5(i, j) += matriz4(j, i)
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz4(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine()
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz5(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            If matriz4(j, i) = matriz5(j, i) Then
                                simetria += 1
                            End If
                        Next
                        Console.WriteLine()
                    Next
                    If simetria = 9 Then
                        Console.WriteLine("Las matrices son simetricas")
                    Else
                        Console.WriteLine("Las matrices no son simetricas")
                    End If
                    simetria = 0
                Case 6
                    'Ejercicio 6: Anxo Benavides, Calcular la suma de la primera fila de una matriz nxm.
                    Dim matriz6(2, 2) As Integer
                    Dim aleatorio As New Random
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            matriz6(j, i) = aleatorio.Next(0, 10)
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz6(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Dim suma As Integer
                    For i = 0 To 2 Step 1
                        suma += matriz6(0, i)
                    Next
                    Console.WriteLine("La suma de la primera fila es " & suma)
                Case 7
                    'Ejercicio 7: Anxo Benavides, Calcular la suma de la última columna de una matriz nxm.
                    Dim matriz7(2, 2) As Integer
                    Dim aleatorio As New Random
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            matriz7(j, i) = aleatorio.Next(0, 10)
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz7(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Dim suma As Integer
                    For j = 0 To 2 Step 1
                        suma += matriz7(j, 2)
                    Next
                    Console.WriteLine("La suma de la última columna es " & suma)
                Case 8
                    'Ejercicio 8: Anxo Benavides, Calcular el valor mínimo y el máximo y sus desviaciones con respecto a la media de una matriz 2D.
                    'Indicar en qué posiciones de la matriz se encuentran estos valores.
                    Dim matriz(4, 4) As Integer
                    Dim aleatorio As New Random
                    Dim media, desviacionMinima, desviacionMaxima As Double
                    Dim LongMinimo, LongMaximo, LatMinimo, LatMaximo, suma As Integer
                    Dim minimo, maximo As Integer
                    For j = 0 To 4 Step 1
                        For i = 0 To 4 Step 1
                            matriz(j, i) = aleatorio.Next(-5, 5)
                        Next
                    Next
                    For j = 0 To 4 Step 1
                        For i = 0 To 4 Step 1
                            Console.Write(matriz(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine()
                    For i As Integer = 0 To 4 Step 1
                        For j As Integer = 0 To 4 Step 1
                            suma = suma + matriz(i, j)
                        Next j
                    Next i
                    media = suma / matriz.Length
                    minimo = matriz(0, 0)
                    maximo = matriz(0, 0)
                    For i As Integer = 0 To 4 Step 1
                        For j As Integer = 0 To 4 Step 1
                            If i = 0 And j = 0 Then
                                Continue For
                            End If
                            If matriz(i, j) > maximo Then
                                maximo = matriz(i, j)
                                LongMaximo = i
                                LatMaximo = j
                            End If
                        Next j
                    Next i
                    For i As Integer = 0 To 4 Step 1
                        For j As Integer = 0 To 4 Step 1
                            If matriz(i, j) < minimo Then
                                minimo = matriz(i, j)
                                LongMinimo = i
                                LatMinimo = j
                            End If
                        Next j
                    Next i
                    desviacionMaxima = Math.Abs(maximo - media)
                    desviacionMinima = Math.Abs(minimo - media)
                    Console.WriteLine("La media es de " & media)
                    Console.WriteLine("La desviación minimá es de " & desviacionMinima)
                    Console.WriteLine("La desviación máxima es de " & desviacionMaxima)
                    Console.WriteLine("El mínimo está en la posición : " & LongMinimo & "," & LatMinimo)
                    Console.WriteLine("El máximo está en la posición : " & LongMaximo & "," & LatMaximo)
                    Console.WriteLine()
                Case 9
                    'Ejercicio 9: Anxo Benavides, Detectar si una matriz 3x3 tiene una fila compuesta sólo por ceros.
                    Dim matriz9(2, 2) As Integer
                    Dim aleatorio As New Random
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            matriz9(j, i) = aleatorio.Next(0, 2)
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1

                            Console.Write(matriz9(j, i) & " ")
                        Next

                        Console.WriteLine()
                    Next
                    If matriz9(0, 0) = 0 And matriz9(0, 1) = 0 And matriz9(0, 2) = 0 Then
                        Console.WriteLine("La 1º linea esta compuesta unicamente de ceros")
                    ElseIf matriz9(1, 0) = 0 And matriz9(1, 1) = 0 And matriz9(1, 2) = 0 Then
                        Console.WriteLine("La 2º linea esta compuesta unicamente de ceros")
                    ElseIf matriz9(2, 0) = 0 And matriz9(2, 1) = 0 And matriz9(2, 2) = 0 Then
                        Console.WriteLine("La 3º linea esta compuesta unicamente de ceros")
                    End If
                Case 10
                    'Ejercicio 10: Anxo Benavides, Calcular la suma de dos matrices 3x3 cuyos datos son introducidos por teclado.
                    Dim matriz10(2, 2) As Integer
                    Dim matriz11(2, 2) As Integer
                    Dim matriz12(2, 2) As Double
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            matriz10(j, i) = CInt(InputBox("Introduzca un valor para cada posición de la 1º matriz a sumar"))
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz10(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine()
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            matriz11(j, i) = CInt(InputBox("Introduzca un valor para cada posición de la 2º matriz a sumar"))
                        Next
                    Next
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz11(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            matriz12(j, i) = matriz11(j, i) + matriz10(j, i)
                        Next
                    Next
                    Console.WriteLine()
                    Console.WriteLine("El resultado de la suma de las matrices es:")
                    For j As Integer = 0 To 2 Step 1
                        For i As Integer = 0 To 2 Step 1
                            Console.Write(matriz12(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                Case 11
                    'Ejercicio 11: Anxo Benavides,  El algoritmo debe pasar a la primera posición el primer número negativo que haya en el array.
                    Dim matrizA(2, 2) As Double
                    Dim aleatorio As New Random
                    Dim negativo As Double
                    Dim j, i As Integer
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            matrizA(j, i) = aleatorio.Next(-1, 5)
                        Next
                    Next
                    matrizA(0, 0) = 3
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            Console.Write(matrizA(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine()
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            If matrizA(j, i) < 0 Then
                                negativo += matrizA(j, i)
                                Exit For
                            End If
                        Next
                        If negativo < 0 Then
                            Exit For
                        End If
                    Next
                    matrizA(0, 0) = negativo
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            Console.Write(matrizA(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    negativo = 0
                Case 12
                    'Ejercicio 12: Anxo Benavides, El algoritmo debe pasar a la última posición el primer número superior a 100.
                    Dim matrizA(2, 2) As Double
                    Dim aleatorio As New Random
                    Dim mayor100 As Double
                    Dim j, i As Integer
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            matrizA(j, i) = aleatorio.Next(95, 105)
                        Next
                    Next
                    matrizA(2, 2) = 69
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            Console.Write(matrizA(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine()
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            If matrizA(j, i) > 100 Then
                                mayor100 += matrizA(j, i)
                                Exit For
                            End If
                        Next
                        If mayor100 > 100 Then
                            Exit For
                        End If
                    Next
                    matrizA(2, 2) = mayor100
                    For j = 0 To 2 Step 1
                        For i = 0 To 2 Step 1
                            Console.Write(matrizA(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    mayor100 = 0
                Case 13
                    'Ejercicio 13: Anxo Benavides, El algoritmo debe detectar si una matriz 4x4 es triangular inferior o superior.
                    Dim triangular(3, 3) As Integer
                    Dim aleatorio As New Random
                    For j = 0 To 3 Step 1
                        For i = 0 To 3 Step 1
                            triangular(j, i) = aleatorio.Next(0, 2)
                        Next
                    Next
                    For j = 0 To 3 Step 1
                        For i = 0 To 3 Step 1
                            Console.Write(triangular(j, i) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine()
                    If triangular(0, 0) = 0 And triangular(0, 1) = 0 And triangular(0, 2) = 0 And triangular(1, 0) = 0 And triangular(1, 1) = 0 And triangular(2, 0) = 0 Then
                        Console.WriteLine("La matriz es triangular superior")
                    ElseIf triangular(0, 3) = 0 And triangular(0, 2) = 0 And triangular(0, 1) = 0 And triangular(1, 3) = 0 And triangular(1, 2) = 0 And triangular(2, 3) = 0 Then
                        Console.WriteLine("La matriz es triangular superior")
                    ElseIf triangular(3, 0) = 0 And triangular(3, 1) = 0 And triangular(3, 2) = 0 And triangular(2, 0) = 0 And triangular(2, 1) = 0 And triangular(1, 0) = 0 Then
                        Console.WriteLine("La matriz es triangular inferior")
                    ElseIf triangular(3, 3) = 0 And triangular(3, 2) = 0 And triangular(3, 1) = 0 And triangular(2, 3) = 0 And triangular(2, 2) = 0 And triangular(1, 3) = 0 Then
                    End If
                    Console.WriteLine()
                Case 14
                    'Ejercicio 14 : Anxo Benavides, Diseñar un algoritmo que verifique si una matriz es cuadrada, en cuyo caso muestra los elementos de la diagonal principal resaltados en rojo.
                    Dim n, m, j, i As Integer
                    n = CInt(InputBox("Diga un número de filas con un máximo de 4"))
                    m = CInt(InputBox("Diga un número de columnas con un máximo de 4"))
                    Dim cuadrado(n, m) As Integer
                    Dim aleatorio As New Random
                    For j = 0 To n Step 1
                        For i = 0 To m Step 1
                            cuadrado(j, i) = aleatorio.Next(0, 2)
                        Next
                    Next
                    If n = m Then
                        For j = 0 To n Step 1
                            For i = 0 To m Step 1
                                If j = i Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                ElseIf j <> i Then
                                    Console.ForegroundColor = ConsoleColor.White
                                End If
                                Console.Write(cuadrado(j, i) & " ")
                            Next
                            Console.WriteLine()
                        Next
                    Else
                        Console.WriteLine("Su Matriz no es cuadrada")
                    End If
                    Console.ForegroundColor = ConsoleColor.White
                Case 15
                    'Ejercicio 15: Anxo Benavides, Rellenar una matriz con 25 valores aleatorios entre -5 y 5.
                    'Mostrar por pantalla aquellos valores de la matriz que no están repetidos.
                    Dim mattrizGrande(4, 4) As Integer
                    Dim valores(24) As Integer
                    Dim aleatorio As New Random
                    Dim j, i As Integer
                    For j = 0 To 4 Step 1
                        For i = 0 To 4 Step 1
                            mattrizGrande(j, i) = aleatorio.Next(-5, 5)
                        Next
                    Next
                    For j = 0 To 4 Step 1
                        For i = 0 To 4 Step 1
                            Console.Write(mattrizGrande(j, i) & "  ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine()
                    For j = 0 To 4 Step 1
                        For i = 0 To 4 Step 1
                            valores(i) = mattrizGrande(j, i)
                        Next
                    Next
                    For i = 0 To 24 Step 1
                        If Array.LastIndexOf(valores, valores(i)) = i Then
                            Console.Write(valores(i) & " ")
                        End If
                    Next
                    Console.WriteLine()
                Case 16
                    'Ejercicio 16: Anxo Benavides, El programa debe llenar una matriz 5x5 con números generados aleatoriamente, menos 3 posiciones que son llenadas con el número 0.
                    'A continuación se va solicitando al usuario que introduzca las coordenadas donde cree que hay un cero.
                    'El usuario tiene 6 vidas cada vez que falla se le resta una.
                    Dim buscaminas(4, 4) As Integer
                    Dim aleatorio As New Random
                    Dim n, m, i, j As Integer
                    Dim intentos, encontrada, contar As Integer
                    For j = 0 To 4 Step 1
                        For i = 0 To 4 Step 1
                            buscaminas(j, i) = aleatorio.Next(1, 10)
                        Next
                    Next
                    contar = 6
                    buscaminas(0, 3) = 0
                    buscaminas(2, 2) = 0
                    buscaminas(4, 1) = 0
                    Do
                        n = CInt(InputBox("Digame un número del 0 al 4"))
                        m = CInt(InputBox("Digame un número del 0 al 4"))
                        If buscaminas(n, m) = 0 Then
                            encontrada += 1
                            buscaminas(n, m) += 1
                            Console.WriteLine("Has acertado una posición")
                            Console.WriteLine()
                        Else
                            contar -= 1
                            Console.WriteLine("Has fallado, vuelva a intentarlo, le quedan " & contar & " intentos")
                            Console.WriteLine()
                        End If

                        If encontrada = 3 Then
                            Console.WriteLine("Has encontrado todos los ceros, Enhorabuena, clicke otra vez para salir")
                            Console.ReadLine()
                            Exit Do
                        End If
                        intentos += 1
                    Loop While intentos < 6
            End Select
        Loop While ejercicios < 17
        Console.ReadLine()
    End Sub

End Module
