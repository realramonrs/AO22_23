Module CasalRomeroPablo

    Sub Main()

        Dim ejercicio As Integer
        Dim continuar As Char

        Do

            Console.WriteLine("Introduce el ejercicio que deseas ejecutar")
            ejercicio = Convert.ToInt32(Console.ReadLine)

            Console.WriteLine("")

            Select Case ejercicio

                Case 1
                    'Declarar una matriz 3 X 3 y darle valores en la declaración. Solicitar al usuario que escoja una fila y mostrarle los valores de esa fila.
                    'Guardar un cero en las últimas posiciones de cada fila. Sumar todos los valores de la primera fila. Contar cuántos ceros hay en la segunda columna.

                    Dim matriz(,) As Integer = {{1, 2, 3}, {4, 2, 6}, {7, 4, 9}}
                    Dim filaParaVer, sumaValoresFila, contador As Integer

                    Console.WriteLine("Introduce la fila que quieres ver")
                    filaParaVer = Convert.ToInt32(Console.ReadLine)

                    Console.WriteLine("")

                    'a

                    Console.WriteLine("Valores de la fila " & filaParaVer & " : ")

                    For a = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(filaParaVer, a) & "")
                    Next

                    Console.WriteLine("")

                    'b

                    For b = 0 To matriz.GetUpperBound(0)
                        matriz(b, matriz.GetUpperBound(1)) = 0
                    Next

                    For g = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine("")

                        For h = 0 To matriz.GetUpperBound(1)
                            Console.Write(matriz(g, h) & " ")
                        Next
                    Next

                    'c

                    For u = 0 To matriz.GetUpperBound(1)
                        sumaValoresFila += matriz(0, u)
                    Next

                    Console.WriteLine(" ")
                    Console.WriteLine("La suma de los valores de la primera fila es : " & sumaValoresFila)

                    'd

                    Console.WriteLine("")

                    For t = 0 To matriz.GetUpperBound(0)

                        If matriz(t, matriz.GetUpperBound(1) - 1) = 0 Then
                            contador += 1
                        End If

                    Next

                    Console.WriteLine("Hay " & contador & " ceros en la segunda columna")

                    Console.ReadLine()

                Case 2

                    'Declarar una matriz 3x3 y darle valores aleatorios entre 1 y 100. A continuación calcular la media de sus elementos.

                    Dim matriz(2, 2) As Integer
                    Dim random As New Random
                    Dim media As Double

                    For i = 0 To matriz.GetUpperBound(0)

                        Console.WriteLine("")

                        For n = 0 To matriz.GetUpperBound(1)

                            matriz(i, n) = random.Next(1, 101)
                            Console.Write(matriz(i, n) & " ")

                            media += matriz(i, n)

                        Next
                    Next

                    media = media / 9

                    Console.WriteLine("")
                    Console.WriteLine("La media de las 9 posiciones es " & media)

                    Console.ReadLine()

                Case 3

                    'Realizar una aplicación que calcula la temperatura media de los 12 meses del año. Para ello se registran 30 valores para cada mes.

                    Dim matriz(11, 29) As Integer
                    Dim random As New Random
                    Dim media As Double

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        media = 0

                        For o = 0 To matriz.GetUpperBound(1)

                            matriz(i, o) = random.Next(0, 11)

                            Console.Write(matriz(i, o) & " ")

                            media += matriz(i, o)
                        Next

                        media = media / 30
                        Console.WriteLine(" --> La media del mes " & i & " es " & media)

                    Next

                Case 4

                    'Calcular el porcentaje de ceros de una matriz 3x3.

                    Dim matriz(2, 2) As Integer
                    Dim contador As Integer
                    Dim porcentaje As Double

                    For n = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For k = 0 To matriz.GetUpperBound(1)

                            Console.WriteLine("Introduce el valor de la posición " & n & "," & k)
                            matriz(n, k) = Convert.ToInt32(Console.ReadLine)

                            If matriz(n, k) = 0 Then
                                contador += 1
                            End If
                        Next
                    Next

                    For v = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine("")

                        For b = 0 To matriz.GetUpperBound(1)

                            Console.Write(matriz(v, b) & " ")
                        Next
                    Next

                    porcentaje = (contador / matriz.Length) * 100

                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("Hay un " & porcentaje & "% de ceros")

                Case 5

                    'A partir de una matriz 3x3 obtener otra matriz que sea la matriz traspuesta de la primera. Comprobar que es simétrica.

                    Dim matriz(2, 2) As Integer
                    Dim matriz2(2, 2) As Integer

                    For I = 0 To matriz.GetUpperBound(0)

                        For n = 0 To matriz.GetUpperBound(1)

                            Console.WriteLine("Introduce el valor de la posición " & I & "," & n)
                            matriz(I, n) = Convert.ToInt32(Console.ReadLine)
                        Next
                    Next

                    For I = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()
                        For n = 0 To matriz.GetUpperBound(1)

                            Console.Write(matriz(I, n) & " ")
                        Next
                    Next

                    Console.WriteLine()

                    For i = 0 To matriz.GetUpperBound(0)

                        For o = 0 To matriz.GetUpperBound(1)

                            matriz2(o, i) = matriz(i, o)
                        Next
                    Next

                    For I = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()
                        For n = 0 To matriz.GetUpperBound(1)

                            Console.Write(matriz2(I, n) & " ")
                        Next
                    Next

                    'comprobar si es simetrica

                    Dim difernte As Boolean = False

                    For I = 0 To matriz.GetUpperBound(0)

                        For j = 0 To matriz.GetUpperBound(1)

                            If matriz(I, j) <> matriz2(I, j) Then

                                difernte = True

                                Exit For
                            End If
                        Next

                        If difernte = True Then
                            Exit For
                        End If

                    Next

                    Console.WriteLine("")

                    If difernte = True Then
                        Console.WriteLine("No es simétrica")
                    Else
                        Console.WriteLine("Es simétrica")
                    End If

                Case 6

                    'Calcular la suma de la primera fila de una matriz 3x3.

                    Dim matriz(2, 2) As Integer
                    Dim random As New Random
                    Dim suma As Integer

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine("")

                        For N = 0 To matriz.GetUpperBound(1)

                            matriz(i, N) = random.Next(0, 6)

                            Console.Write(matriz(i, N) & " ")
                        Next
                    Next

                    For k = 0 To matriz.GetUpperBound(1)
                        suma += matriz(0, k)
                    Next

                    Console.WriteLine("")
                    Console.WriteLine("La suma de la primera fila es " & suma)

                Case 7

                    'Calcular la suma de la última columna de una matriz 3x3.

                    Dim matriz(2, 2) As Integer
                    Dim random As New Random
                    Dim suma As Integer

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine("")

                        For N = 0 To matriz.GetUpperBound(1)

                            matriz(i, N) = random.Next(0, 6)

                            Console.Write(matriz(i, N) & " ")
                        Next
                    Next

                    For k = 0 To matriz.GetUpperBound(1)
                        suma += matriz(2, k)
                    Next

                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("La suma de la última fila es " & suma)

                Case 8

                    'Calcular el valor mínimo y el máximo y sus desviaciones con respecto a la media de una matriz 2D.
                    'Indicar en qué posiciones de la matriz se encuentran estos valores.

                    Dim matriz(2, 2) As Integer
                    Dim random As New Random
                    Dim menor, mayor, posicionFila, posicionColumna, posicionFilaMayor, PosicionColumnaMayor As Integer
                    Dim media, desviaciónMenor, desviaciónMayor As Double


                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine("")

                        For N = 0 To matriz.GetUpperBound(1)

                            matriz(i, N) = random.Next(0, 6)

                            media += matriz(i, N)

                            Console.Write(matriz(i, N) & " ")
                        Next
                    Next

                    media = media / 9

                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("La media es " & media)

                    menor = matriz(0, 0)

                    For u = 0 To matriz.GetUpperBound(0)

                        For l = 0 To matriz.GetUpperBound(1)


                            If menor < matriz(u, l) Then

                            Else
                                menor = matriz(u, l)
                                posicionFila = u
                                posicionColumna = l
                            End If
                        Next
                    Next

                    desviaciónMenor = media - menor

                    If desviaciónMenor < 0 Then
                        desviaciónMenor = desviaciónMenor * -1
                    End If

                    Console.WriteLine()
                    Console.WriteLine("El menor es " & menor & " , está en la posición " & posicionFila & "," & posicionColumna & " y su desviación frente a la media es " & desviaciónMenor)

                    mayor = matriz(0, 0)

                    For u = 0 To matriz.GetUpperBound(0)

                        For l = 0 To matriz.GetUpperBound(1)

                            If mayor < matriz(u, l) Then

                                mayor = matriz(u, l)
                                posicionFilaMayor = u
                                PosicionColumnaMayor = l

                            End If
                        Next
                    Next

                    desviaciónMayor = media - mayor

                    If desviaciónMayor < 0 Then
                        desviaciónMayor = desviaciónMayor * -1
                    End If

                    Console.WriteLine()
                    Console.WriteLine("El mayor es " & mayor & " , está en la posición " & posicionFilaMayor & "," & PosicionColumnaMayor & " y su desviación frente a la media es " & desviaciónMayor)

                Case 9

                    'Detectar si una matriz 3x3 tiene una fila compuesta sólo por ceros..

                    Dim matriz(2, 2) As Integer
                    Dim random As New Random
                    Dim contador As Integer

                    For i = 0 To matriz.GetUpperBound(0)

                        Console.WriteLine("")

                        For n = 0 To matriz.GetUpperBound(1)

                            matriz(i, n) = random.Next(0, 2)
                            Console.Write(matriz(i, n) & " ")

                        Next
                    Next

                    For j = 0 To matriz.GetUpperBound(0)

                        contador = 0

                        For o = 0 To matriz.GetUpperBound(1)

                            If matriz(j, o) = 0 Then
                                contador += 1
                            End If

                        Next

                        If contador = 3 Then

                            Console.WriteLine()
                            Console.WriteLine("La fila " & j & " está compuesta solo por ceros")

                        End If
                    Next

                Case 10

                    'Calcular la suma de dos matrices 3x3 cuyos datos son introducidos por teclado.

                    Dim matriz(2, 2) As Integer
                    Dim matriz2(2, 2) As Integer
                    Dim matriz3(2, 2) As Integer

                    For I = 0 To matriz.GetUpperBound(0)

                        For n = 0 To matriz.GetUpperBound(1)

                            Console.WriteLine("Introduce el valor de la posición " & I & "," & n & " de la matriz 1")
                            matriz(I, n) = Convert.ToInt32(Console.ReadLine)
                        Next
                    Next

                    Console.WriteLine()

                    For I = 0 To matriz.GetUpperBound(0)

                        For n = 0 To matriz.GetUpperBound(1)

                            Console.WriteLine("Introduce el valor de la posición " & I & "," & n & " de la matriz 2")
                            matriz2(I, n) = Convert.ToInt32(Console.ReadLine)
                        Next
                    Next

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For k = 0 To matriz2.GetUpperBound(1)
                            Console.Write(matriz(i, k) & " ")
                        Next
                    Next

                    Console.WriteLine()

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For k = 0 To matriz2.GetUpperBound(1)
                            Console.Write(matriz2(i, k) & " ")
                        Next
                    Next

                    Console.WriteLine()

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For k = 0 To matriz2.GetUpperBound(1)

                            matriz3(i, k) = matriz(i, k) + matriz2(i, k)
                            Console.Write(matriz3(i, k) & " ")
                        Next

                    Next


                Case 11

                    'El algoritmo debe pasar a la primera posición el primer número negativo que haya en el array.

                    Dim matriz(2, 2) As Integer
                    Dim random As New Random
                    Dim negativo As Integer
                    Dim salirBucle As Boolean = True

                    For i = 0 To matriz.GetUpperBound(0)

                        Console.WriteLine("")

                        For n = 0 To matriz.GetUpperBound(1)

                            matriz(i, n) = random.Next(-5, 6)
                            Console.Write(matriz(i, n) & " ")

                        Next
                    Next

                    For k = 0 To matriz.GetUpperBound(0)

                        For j = 0 To matriz.GetUpperBound(1)

                            If matriz(k, j) < 0 Then

                                negativo = matriz(k, j)
                                salirBucle = False

                                Exit For
                            End If
                        Next

                        If salirBucle = False Then

                            Exit For
                        End If

                    Next

                    matriz(0, 0) = negativo

                    Console.WriteLine()

                    For n = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For b = 0 To matriz.GetUpperBound(1)
                            Console.Write(matriz(n, b) & " ")
                        Next
                    Next

                Case 12

                    'El algoritmo debe pasar a la última posición el primer número superior a 100.

                    'El algoritmo debe pasar a la primera posición el primer número negativo que haya en el array.

                    Dim matriz(2, 2) As Integer
                    Dim random As New Random
                    Dim superior As Integer
                    Dim salirBucle As Boolean = True

                    For i = 0 To matriz.GetUpperBound(0)

                        Console.WriteLine("")

                        For n = 0 To matriz.GetUpperBound(1)

                            matriz(i, n) = random.Next(95, 102)
                            Console.Write(matriz(i, n) & " ")

                        Next
                    Next

                    For k = 0 To matriz.GetUpperBound(0)

                        For j = 0 To matriz.GetUpperBound(1)

                            If matriz(k, j) > 100 Then

                                superior = matriz(k, j)
                                salirBucle = False

                                Exit For
                            End If
                        Next

                        If salirBucle = False Then

                            Exit For
                        End If

                    Next

                    matriz(0, 0) = superior

                    Console.WriteLine()

                    For n = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For b = 0 To matriz.GetUpperBound(1)
                            Console.Write(matriz(n, b) & " ")
                        Next
                    Next

                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("Si en el segundo array la primera posición es 0, es que en el primer array no hay ningún número mayor que 100")

                Case 13

                    'El algoritmo debe detectar si una matriz 4x4 es triangular inferior o superior.

                    Dim matriz(,) As Integer = {{1, 1, 1, 1}, {0, 1, 1, 1}, {0, 0, 1, 1}, {0, 0, 0, 1}}

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For o = 0 To matriz.GetUpperBound(1)
                            Console.Write(matriz(i, o) & " ")
                        Next

                    Next

                    If matriz(0, 1) = 0 And matriz(0, 2) = 0 And matriz(0, 3) = 0 And matriz(1, 2) = 0 And matriz(1, 3) = 0 And matriz(2, 3) = 0 Then
                        Console.WriteLine()
                        Console.WriteLine()
                        Console.WriteLine("La matriz es triangular inferior")
                    End If

                    If matriz(1, 0) = 0 And matriz(2, 0) = 0 And matriz(2, 1) = 0 And matriz(3, 0) = 0 And matriz(3, 1) = 0 And matriz(3, 2) = 0 Then
                        Console.WriteLine()
                        Console.WriteLine()
                        Console.WriteLine("La matriz es triangular superior")
                    End If

                Case 14

                    'Diseñar un algoritmo que verifique si una matriz es cuadrada ,
                    'en cuyo caso muestra los elementos de la diagonal principal resaltados en rojo

                    Dim matriz(2, 3) As Integer
                    Dim contadorFilas, contadorColumnas, contador3 As Integer

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For o = 0 To matriz.GetUpperBound(1)

                            Console.Write(matriz(i, o) & " ")

                        Next

                    Next

                    For i = 0 To matriz.GetUpperBound(0)

                        contadorColumnas = 0
                        contadorFilas += 1

                        For o = 0 To matriz.GetUpperBound(1)

                            contadorColumnas += 1
                        Next

                        contador3 = contadorColumnas
                    Next

                    If contadorFilas = contador3 Then

                        Console.WriteLine("La matriz es cuadrada")
                    Else

                        Console.WriteLine("La matriz no es cuadrada")
                    End If

                Case 15

                    'Rellenar una matriz con 25 valores aleatorios entre -5 y 5.
                    'Mostrar por pantalla aquellos valores de la matriz que no están repetidos.

                    Dim matriz(4, 4) As Integer
                    Dim random As New Random
                    Dim contador As Integer

                    For i = 0 To matriz.GetUpperBound(0)
                        Console.WriteLine()

                        For o = 0 To matriz.GetUpperBound(1)

                            matriz(i, o) = random.Next(-5, 6)

                            Console.Write(matriz(i, o) & " ")
                        Next

                    Next

                    Console.WriteLine()

                    For k = -5 To 5

                        contador = 0

                        For i = 0 To matriz.GetUpperBound(0)

                            For o = 0 To matriz.GetUpperBound(1)

                                If k = matriz(i, o) Then

                                    contador += 1
                                End If
                            Next
                        Next

                        If contador < 2 And contador > 0 Then
                            Console.WriteLine()
                            Console.WriteLine(k)
                        End If
                    Next

                Case 16

                    'El programa debe llenar una matriz 5x5 con números generados aleatoriamente, menos 3 posiciones que son llenadas con el número 0.
                    'A continuación se va solicitando al usuario que introduzca las coordenadas donde cree que hay un cero.
                    'El usuario tiene 6 vidas cada vez que falla se le resta una.

                    Dim matriz(4, 4) As Integer
                    Dim random As New Random
                    Dim fila, columna As Integer
                    Dim contador As Integer = 6
                    Dim ganar As Boolean = False
                    Dim perder As Boolean = False
                    Dim otraPartida As Char

                    For i = 0 To matriz.GetUpperBound(0)

                        For o = 0 To matriz.GetUpperBound(1)

                            matriz(i, o) = random.Next(-5, 6)
                        Next
                    Next

                    matriz(0, 4) = 0
                    matriz(4, 2) = 0
                    matriz(2, 2) = 0

                    Do
                        contador = 6
                        ganar = False
                        perder = False

                        Do
                            Console.WriteLine("Introduce la fila donde crees que está el 0. Recuerda que solo puedes introducir un número de 0 a 4")
                            fila = Convert.ToInt32(Console.ReadLine)

                            Console.WriteLine("Introduce la columna donde crees que está el 0. Recuerda que solo puedes introducir un número de 0 a 4")
                            columna = Convert.ToInt32(Console.ReadLine)

                            If matriz(fila, columna) = 0 Then

                                Console.WriteLine()
                                Console.WriteLine("Felicidades, has ganado ! El 0 estaba en " & fila & "," & columna)
                                ganar = True

                            Else

                                contador -= 1
                                Console.WriteLine("")
                                Console.WriteLine("Has perdido :( Pero tienes " & contador & " intentos más")
                                Console.WriteLine()

                            End If


                        Loop Until ganar = True Or contador = 0

                        Console.WriteLine("Quieres jugar otra partida ? {S/N}")
                        otraPartida = CChar(Console.ReadLine)

                    Loop While otraPartida = "S"c Or otraPartida = "s"c

            End Select

            Console.WriteLine("")
            Console.WriteLine("Quieres ejecutar otro ejercicio ? (S/N)")
            continuar = CChar(Console.ReadLine)

            Console.WriteLine("")

        Loop While continuar = "s"c Or continuar = "S"c
    End Sub

End Module
