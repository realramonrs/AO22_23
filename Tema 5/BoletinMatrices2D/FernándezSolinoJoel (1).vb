Module FernándezSolinoJoel

    Sub Main()
        'Zona del select case
        Dim opcion As Integer
        Do
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine("Eliga el ejercicio poniendo el número del ejercicio en específico.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("Escoja una opción: ")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 1.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 2.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 3.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 4.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 5.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 6.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 7.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 8.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 9.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 10.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 11.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 12.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 13.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 14.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 15.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("Ejercicio 16.")
            Console.ResetColor()
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkMagenta
            Console.WriteLine("Ponga (99) para cerrar la consola.")
            Console.ResetColor()
            Console.WriteLine("")
            opcion = Convert.ToInt32(Console.ReadLine)
            Select Case opcion
                Case 1
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 1.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Declarar una matriz 3 X 3 y darle valores en la declaración. 
                    '   Solicitar al usuario que escoja una fila y mostrarle los valores de esa fila.
                    '   Guardar un cero en las últimas posiciones de cada fila.
                    '   Sumar todos los valores de la primera fila.
                    '   Contar cuántos ceros hay en la segunda columna.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2) As Integer
                    array(0, 0) = 1
                    array(0, 1) = 2
                    array(0, 2) = 3
                    array(1, 0) = 4
                    array(1, 1) = 5
                    array(1, 2) = 6
                    array(2, 0) = 7
                    array(2, 1) = 8
                    array(2, 2) = 9
                    Dim opci, cont As Integer
                    Dim suma As Double

                    'Zona de operaciones
                    Console.WriteLine("Elige que fila quieres que te muestre (0 - 2).")
                    opci = Int32.Parse(Console.ReadLine)
                    Console.WriteLine("Los valores de la fila elegida son: ")
                    For j = 0 To array.GetUpperBound(0)
                        Console.Write(array(opci, j) & " ")
                    Next
                    Console.WriteLine("")
                    For i = 0 To array.GetUpperBound(0)
                        array(i, array.GetUpperBound(1)) = 0
                        For h = 0 To array.GetUpperBound(1)
                            Console.Write(array(i, h) & " ")
                        Next
                    Next
                    Console.WriteLine("")
                    For y = 0 To array.GetUpperBound(1)
                        suma += array(0, y)
                    Next
                    Console.WriteLine("La suma de los dígitos de la primera fila es: " & suma & ".")
                    Console.WriteLine("")
                    For k = 0 To array.GetUpperBound(0)
                        If array.GetUpperBound(1) = 0 Then
                            cont += 1
                        End If
                    Next
                    Console.WriteLine("La cantidad de 0 que tiene la columna 2 es un total de: " & cont & ".")
                    Console.ReadLine()

                Case 2
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 2.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Declarar una matriz 3x3 y darle valores aleatorios entre 1 y 100. A continuación calcular la media de sus elementos.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2), suma As Integer
                    Dim aleat As New Random
                    Dim media As Double

                    'Zona de operaciones
                    'For en el que doy los valores aleatorios
                    'For en el que se pones valores aleatorios en cada posición
                    For c = 0 To array.GetUpperBound(0)
                        For v = 0 To array.GetUpperBound(1)
                            array(c, v) = aleat.Next(0, 100)
                        Next
                    Next
                    'For en el que hago la suma
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            suma += array(i, j)
                        Next
                    Next
                    media = suma / 9
                    Console.WriteLine("La media da" & media & ".")
                    Console.ReadLine()

                Case 3
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 3.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Realizar una aplicación que calcula la temperatura media de los 12 meses del año.
                    'Para ello se registran 30 valores para cada mes.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(11, 29) As Integer
                    Dim aleat As New Random
                    Dim mediaanual, mediamensual, suma, suma2 As Double
                    Dim cont, cont2 As Integer

                    'Zona de operaciones
                    For i = 0 To array.GetUpperBound(0)
                        For h = 0 To array.GetUpperBound(1)
                            array(i, h) = aleat.Next(0, 20)
                            'Con los comentarios de abajo, lo que hago es hacer que se me muestre en pantalla las temperaturas de cada dia,
                            'y me ponga cada día en su correspondiente temperatura.
                            cont += 1
                            Console.WriteLine("Día: " & cont)
                            Console.WriteLine(array(i, h) & "º ")
                        Next
                    Next
                    'For en el que sumo los valores del array
                    For k = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            suma += array(k, j)
                        Next
                    Next
                    'Aquí calculo la media anual
                    mediaanual = suma / (30 * 12)
                    Console.WriteLine("La media de temperatura durante todo el año fue de " & mediaanual & ".")
                    Console.WriteLine("")
                    'En este for hago que me cambie el número del mes, por el mes que es escrito.
                    For g = 0 To 11
                        If cont2 = 0 Then
                            Console.Write("Enero")
                        ElseIf cont2 = 1 Then
                            Console.Write("Febrero")
                        ElseIf cont2 = 2 Then
                            Console.Write("Marzo")
                        ElseIf cont2 = 3 Then
                            Console.Write("Abril")
                        ElseIf cont2 = 4 Then
                            Console.Write("Mayo")
                        ElseIf cont2 = 5 Then
                            Console.Write("Junio")
                        ElseIf cont2 = 6 Then
                            Console.Write("Julio")
                        ElseIf cont2 = 7 Then
                            Console.Write("Agosto")
                        ElseIf cont2 = 8 Then
                            Console.Write("Septiembre")
                        ElseIf cont2 = 9 Then
                            Console.Write("Octubre")
                        ElseIf cont2 = 10 Then
                            Console.Write("Noviembre")
                        ElseIf cont2 = 11 Then
                            Console.Write("Diciembre")
                        End If
                        cont2 += 1
                        suma2 = 0
                        'Aquí calculo la media mensual
                        mediamensual = 0
                        For d = 0 To array.GetUpperBound(1)
                            suma2 += array(g, d)
                        Next
                        mediamensual = suma2 / 30
                        Console.WriteLine(" -- " & mediamensual & ".")
                    Next
                    Console.ReadLine()

                Case 4
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 4.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Calcular el porcentaje de ceros de una matriz 3x3

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2) As Integer
                    Dim cont As Integer
                    Dim porcentaje As Double
                    Dim aleat As New Random

                    'Zona de operaciones
                    'For en el que doy los valores aleatorios
                    'For en el que se pones valores aleatorios en cada posición
                    For c = 0 To array.GetUpperBound(0)
                        For v = 0 To array.GetUpperBound(1)
                            array(c, v) = aleat.Next(0, 2)
                        Next
                    Next
                    'For en el que cuento cuantos ceros hay en el array
                    For i = 0 To array.GetUpperBound(0)
                        For h = 0 To array.GetUpperBound(1)
                            If array(i, h) = 0 Then
                                cont += 1
                            End If
                        Next
                    Next
                    'Aquí calculo el porcentaje de 0 que hay en el array
                    porcentaje = (cont / 9) * 100
                    Console.WriteLine("El porcentaje de 0 que hay en el array es de " & porcentaje & ".")
                    Console.ReadLine()

                Case 5
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 5.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'A partir de una matriz 3x3 obtener otra matriz que sea la matriz traspuesta de la primera.
                    'Comprobar que es simétrica.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2), array2(2, 2) As Integer
                    array(0, 0) = 1
                    array(0, 1) = 2
                    array(0, 2) = 3
                    array(1, 0) = 4
                    array(1, 1) = 5
                    array(1, 2) = 6
                    array(2, 0) = 7
                    array(2, 1) = 8
                    array(2, 2) = 9

                    'Zona de operaciones
                    'Este for lo que hace es enseñar el array por pantalla.
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            Console.Write(array(i, j) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    'Aquí cojo los dos arrays para hacer el array traspuesto
                    For a = 0 To array2.GetUpperBound(0)
                        For n = 0 To array2.GetUpperBound(1)
                            array2(n, a) = array(a, n)
                        Next
                    Next
                    'For en el que muestro el array traspuesto por pantalla
                    Console.WriteLine("")
                    For k = 0 To array2.GetUpperBound(0)
                        For f = 0 To array2.GetUpperBound(1)
                            Console.Write(array2(k, f) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.ReadLine()

                Case 6
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 6.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Calcular la suma de la primera fila de una matriz 3x3.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2) As Integer
                    array(0, 0) = 1
                    array(0, 1) = 2
                    array(0, 2) = 3
                    array(1, 0) = 4
                    array(1, 1) = 5
                    array(1, 2) = 6
                    array(2, 0) = 7
                    array(2, 1) = 8
                    array(2, 2) = 9
                    Dim suma As Double

                    'Zona de operaciones
                    'For en el que calculo la suma de la primera fila del array
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            Console.Write(array(i, j) & " ")
                            suma = array(0, j)
                        Next
                        Console.WriteLine("")
                    Next
                    Console.WriteLine("La suma de los valores de la primera fila del array es " & suma & ".")
                    Console.ReadLine()

                Case 7
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 7.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Calcular la suma de la última columna de una matriz 3x3.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2) As Integer
                    Dim suma As Double
                    array(0, 0) = 1
                    array(0, 1) = 2
                    array(0, 2) = 3
                    array(1, 0) = 4
                    array(1, 1) = 5
                    array(1, 2) = 6
                    array(2, 0) = 7
                    array(2, 1) = 8
                    array(2, 2) = 9

                    'Zona de operaciones
                    'For en el que hago la suma de los valores de la ultima columna del array
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            Console.Write(array(i, j) & " ")
                            suma += array.GetUpperBound(1)
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine("El resultado de la suma de la última columna del array es " & suma & ".")
                    Console.ReadLine()

                Case 8
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 8.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Calcular el valor mínimo y el máximo y sus desviaciones con respecto a la media de una matriz 2D.
                    'Indicar en qué posiciones de la matriz se encuentran estos valores.


                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2) As Integer
                    array(0, 0) = 1
                    array(0, 1) = 2
                    array(0, 2) = 3
                    array(1, 0) = 4
                    array(1, 1) = 5
                    array(1, 2) = 6
                    array(2, 0) = 7
                    array(2, 1) = 8
                    array(2, 2) = 9
                    Dim media, desviacion, desviacion2, maximo, minimo As Double
                    Dim posicionmin, posicionmax, posicionmax2, posicionmin2 As Double

                    'Zona de operaciones
                    'For en el que sumo los valores del array
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            media += array(i, j) / 9
                        Next
                    Next
                    'Aquí calculo la media de los valores del array
                    media = media
                    minimo = array(0, 0)
                    'For en el que calculo tanto el valor máximo como el valor mínimo del array
                    For g = 0 To array.GetUpperBound(0)
                        For h = 0 To array.GetUpperBound(1)
                            If maximo < array(g, h) Then
                                maximo = array(g, h)
                                posicionmax = g
                                posicionmax2 = h
                            End If
                            If minimo > array(g, h) Then
                                minimo = array(g, h)
                                posicionmin = g
                                posicionmin2 = h
                            End If
                        Next
                    Next
                    Console.WriteLine("La media es " & media & ".")
                    desviacion = media - maximo
                    Console.WriteLine("La desviación máxima es de " & desviacion & ".")
                    desviacion2 = media - minimo
                    Console.WriteLine("La desviación mínima es de " & desviacion2 & ".")
                    Console.WriteLine("La posición del valor más grande es " & posicionmax & ", " & posicionmax2 & ".")
                    Console.WriteLine("La posición del valor más pequeño es " & posicionmin & ", " & posicionmin2 & ".")
                    Console.ReadLine()

                Case 9
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 9.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Detectar si una matriz 3x3 tiene una fila compuesta sólo por ceros.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2) As Integer
                    array(0, 0) = 1
                    array(0, 1) = 2
                    array(0, 2) = 3
                    array(1, 0) = 0
                    array(1, 1) = 0
                    array(1, 2) = 0
                    array(2, 0) = 7
                    array(2, 1) = 8
                    array(2, 2) = 9
                    Dim cont As Double

                    'Zona de operaciones
                    'For en el que muestro por pantalla el array
                    For ñ = 0 To array.GetUpperBound(0)
                        For P = 0 To array.GetUpperBound(1)
                            Console.Write(array(ñ, P) & " ")
                        Next
                        Console.WriteLine("")
                    Next
                    'For en el que voy contando los ceros del array y compruebo si es una fila entera compuesta por ceros.
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            If array(i, j) = 0 Then
                                cont += 1
                            End If
                        Next
                        If cont = array.GetUpperBound(1) + 1 Then
                            Console.WriteLine("Hay un total de " & i & " fiLa/s compuesta/s por cero/s.")
                        End If
                        cont = 0
                    Next
                    Console.ReadLine()

                Case 10
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 10.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Calcular la suma de dos matrices 3x3 cuyos datos son introducidos por teclado.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2) As Integer
                    Dim array2(2, 2) As Integer
                    Dim suma, suma2, sumatotal As Double

                    'Zona de operaciones
                    'For para dar valor a cada posición del array
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            Console.WriteLine("Dame un valor para colocar en el array.")
                            array(i, j) = Convert.ToInt32(Console.ReadLine)
                            'Suma digitos array
                            suma += array(i, j)
                        Next
                    Next
                    'For para ver que se hayan colocado todos los valores en sus posiciones correspondientes
                    For a = 0 To array.GetUpperBound(0)
                        For c = 0 To array.GetUpperBound(1)
                            Console.Write(array(a, c) & " ")
                        Next
                        Console.WriteLine("")
                    Next
                    Console.WriteLine("")
                    'For para dar valor a cada posición del array2
                    For h = 0 To array.GetUpperBound(0)
                        For k = 0 To array.GetUpperBound(1)
                            Console.WriteLine("Dame un valor para colocar en el array.")
                            array(h, k) = Convert.ToInt32(Console.ReadLine)
                            suma2 += array(h, k)
                        Next
                    Next
                    'For para ver que se hayan colocado todos los valores en sus posiciones correspondientes del array2
                    For x = 0 To array.GetUpperBound(0)
                        For z = 0 To array.GetUpperBound(1)
                            Console.Write(array(x, z) & " ")
                        Next
                        Console.WriteLine("")
                    Next
                    'Sumar arrays
                    Console.WriteLine("La suma total de los valores del primer array es " & suma & ".")
                    Console.WriteLine("La suma total de los valores del segundo array es " & suma2 & ".")
                    sumatotal = suma + suma2
                    Console.WriteLine("La suma total de todos los valores de los 2 arrays es " & sumatotal & ".")
                    Console.ReadLine()

                Case 11
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 11.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'El algoritmo debe pasar a la primera posición el primer número negativo que haya en el array.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2), guardar As Integer
                    Dim aleat As New Random
                    Dim negativo As Boolean = False

                    'Zona de operaciones
                    'For en el que se pones valores aleatorios en cada posición
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            array(i, j) = aleat.Next(-5, 10)
                        Next
                    Next
                    'For en el que lo muestro en pantalla, para ver que se creó bien
                    For l = 0 To array.GetUpperBound(0)
                        For ñ = 0 To array.GetUpperBound(1)
                            Console.Write(array(l, ñ) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine("")
                    'For en el que intercambio el primer negativo a la primera posición
                    For z = 0 To array.GetUpperBound(0)
                        For x = 0 To array.GetUpperBound(1)
                            If array(z, x) < 0 Then
                                guardar = array(0, 0)
                                array(0, 0) = array(z, x)
                                array(z, x) = guardar
                                negativo = True
                                Exit For
                            End If
                        Next
                        If negativo Then
                            Exit For
                        End If
                    Next
                    'For en el que lo muestro en pantalla, para ver que se cambió correctamente
                    For c = 0 To array.GetUpperBound(0)
                        For o = 0 To array.GetUpperBound(1)
                            Console.Write(array(c, o) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.ReadLine()

                Case 12
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 12.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'El algoritmo debe pasar a la última posición el primer número superior a 100.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2), guardar As Integer
                    Dim aleat As New Random
                    Dim numsup As Boolean = False

                    'Zona de operaciones
                    'For en el que se pones valores aleatorios en cada posición
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            array(i, j) = aleat.Next(0, 200)
                        Next
                    Next
                    'For en el que lo muestro en pantalla, para ver que se creó bien
                    For l = 0 To array.GetUpperBound(0)
                        For ñ = 0 To array.GetUpperBound(1)
                            Console.Write(array(l, ñ) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine("")
                    'For en el que intercambio el primer número > 100 a la última posición
                    For z = 0 To array.GetUpperBound(0)
                        For x = 0 To array.GetUpperBound(1)
                            If array(z, x) > 100 Then
                                guardar = array(2, 2)
                                array(2, 2) = array(z, x)
                                array(z, x) = guardar
                                numsup = True
                                Exit For
                            End If
                        Next
                        If numsup Then
                            Exit For
                        End If
                    Next
                    'For en el que lo muestro en pantalla, para ver que se cambió correctamente
                    For c = 0 To array.GetUpperBound(0)
                        For o = 0 To array.GetUpperBound(1)
                            Console.Write(array(c, o) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.ReadLine()

                Case 13
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 13.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'El algoritmo debe detectar si una matriz 4x4 es triangular inferior o superior.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(3, 3), cont, cont2 As Integer
                    Dim aleat As New Random
                    cont = 0
                    cont2 = 0

                    'Zona de operaciones
                    'For en el que doy valores a las posiciones del array
                    For v = 0 To array.GetUpperBound(0)
                        For g = 0 To array.GetUpperBound(1)
                            array(v, g) = aleat.Next(0, 2)
                        Next
                    Next
                        'For en el que lo muestro en pantalla, para ver que se creó bien
                        For l = 0 To array.GetUpperBound(0)
                        For ñ = 0 To array.GetUpperBound(1)
                            Console.Write(array(l, ñ) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine("")
                    'For que lee el array y dice si es triangular inferior
                    For c = 0 To array.GetUpperBound(0)
                        For f = c + 1 To array.GetUpperBound(1)
                            If array(c, f) = 0 Then
                                cont += 1
                            End If
                        Next
                    Next
                    If cont = 6 Then
                        Console.WriteLine("Es triangular inferior.")
                    End If

                    'For que lee el array y dice si es triangular superior
                    For n = 0 To array.GetUpperBound(0)
                        For m = n + 1 To array.GetUpperBound(1)
                            If array(m, n) = 0 Then
                                cont2 += 1
                            End If
                        Next
                    Next
                    If cont2 = 6 Then
                        Console.WriteLine("Es triangular superior.")
                    End If

                    Console.ReadLine()

                Case 14
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 14.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Diseñar un algoritmo que verifique si una matriz es cuadrada,
                    'en cuyo caso muestra los elementos de la diagonal principal resaltados en rojo

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim v, b As Integer
                    Console.WriteLine("Dime la cantidad de posiciones de la fila.")
                    v = Int32.Parse(Console.ReadLine)
                    Console.WriteLine("Dime la cantidad de posiciones de la columna.")
                    b = Int32.Parse(Console.ReadLine)
                    Dim array(v, b), cont As Integer
                    Dim aleat As New Random
                    Console.WriteLine("")

                    'For en el que se pones valores aleatorios en cada posición
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            array(i, j) = aleat.Next(0, 10)
                        Next
                    Next
                    'For en el que lo muestro en pantalla, para ver que se creó bien
                    For l = 0 To array.GetUpperBound(0)
                        For ñ = 0 To array.GetUpperBound(1)
                            Console.Write(array(l, ñ) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    'For que cambia el color de la diagonal
                    Console.WriteLine("")
                    For g = 0 To array.GetUpperBound(0)
                        For t = 0 To array.GetUpperBound(1)
                            If g = t Then
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                Console.Write(array(g, t) & " ")
                                Console.ResetColor()
                            Else
                                Console.Write(array(g, t) & " ")
                            End If
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine("")
                    'If que dice si el array es cuadrado o no lo es
                    If array.GetUpperBound(0) = array.GetUpperBound(1) Then
                        Console.WriteLine("El array es cuadrado.")
                        Console.WriteLine("")
                    ElseIf array.GetUpperBound(0) <> array.GetUpperBound(1) Then
                        Console.WriteLine("El array no es cuadrado.")
                    End If
                    Console.ReadLine()

                Case 15
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 15.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'Rellenar una matriz con 25 valores aleatorios entre -5 y 5. Mostrar por pantalla aquellos valores de la matriz que no están repetidos.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(2, 2), cont As Integer
                    Dim aleat As New Random

                    'Zona de operaciones
                    'For en el que se pones valores aleatorios en cada posición
                    For i = 0 To array.GetUpperBound(0)
                        For j = 0 To array.GetUpperBound(1)
                            array(i, j) = aleat.Next(-5, 5)
                        Next
                    Next
                    'For en el que lo muestro en pantalla, para ver que se creó bien
                    For l = 0 To array.GetUpperBound(0)
                        For ñ = 0 To array.GetUpperBound(1)
                            Console.Write(array(l, ñ) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine("")
                    'For donde hago que detecte los número repetidos y me los exponga en la consola.
                    For g = -5 To 5
                        cont = 0
                        For f = 0 To array.GetUpperBound(0)
                            For t = 0 To array.GetUpperBound(1)
                                If array(f, t) = g Then
                                    cont += 1
                                End If
                            Next
                        Next
                        If cont < 2 And cont > 0 Then
                            Console.WriteLine("El/los número/s es/son " & g & ".")
                        End If
                    Next
                    Console.ReadLine()

                Case 16
                    'Elección de ejercicio
                    Console.WriteLine("")
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Ejercicio 16.")
                    Console.ResetColor()
                    Console.WriteLine("")
                    'Enunciado Joel Fernández Solino

                    'El programa debe llenar una matriz 5x5 con números generados aleatoriamente, menos 3 posiciones que son llenadas con el número 0.
                    'A continuación se va solicitando al usuario que introduzca las coordenadas donde cree que hay un cero.
                    'El usuario tiene 6 vidas cada vez que falla se le resta una.

                    'Resolución del ejercicio

                    'Zona de declaración y valoración de variables
                    Dim array(4, 4), vidas, opti, cont, conts, posifila, posicolu, posifila2, posicolu2, posifila3, posicolu3 As Integer
                    Dim aleat As New Random
                    Dim opc As String

                    'Zona de operaciones
                    'For en el que hago que se pongan 3 ceros aleatoriamente y valores aleatorios en el resto de posiciones
                    For t = 0 To array.GetUpperBound(0)
                        For k = 0 To array.GetUpperBound(1)
                            array(t, k) = 0
                            array(t, k) = aleat.Next(0, 20)
                            cont += 1
                            If cont = 1 Then
                                t = posifila
                                k = posicolu
                            End If
                            If cont = 2 Then
                                t = posifila2
                                k = posicolu2
                            End If
                            If cont = 3 Then
                                t = posifila3
                                k = posicolu3
                            End If
                            If cont = 3 Then
                                Exit For
                            End If
                        Next
                    Next
                    'For en el que lo muestro en pantalla, para ver que se creó bien
                    For l = 0 To array.GetUpperBound(0)
                        For ñ = 0 To array.GetUpperBound(1)
                            Console.Write(array(l, ñ) & " ")
                        Next
                        Console.WriteLine()
                    Next
                    Console.WriteLine("")
                    Do
                        'Zona declaración y valoración de variables
                        Dim coord1, coord2 As Integer
                        vidas = 6
                        conts = 0
                        opti = 1

                        'Inicio del juego
                        Console.WriteLine("")
                        Console.ForegroundColor = ConsoleColor.DarkYellow
                        Console.WriteLine("Empiezas teniendo 6 vidas. Cada vez que falles pierdes 1 y cuando llegues a 0.")
                        Console.ResetColor()
                        Console.WriteLine("")
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        Console.WriteLine("GAME OVER AMIGOU")
                        Console.ResetColor()
                        Console.WriteLine("")
                        'For en el que voy preguntando las coordenadas
                        For y = 0 To array.GetUpperBound(0)
                            For z = 0 To array.GetUpperBound(1)
                                Console.WriteLine("Dime la fila que deseas comprobar.")
                                coord1 = Int32.Parse(Console.ReadLine)
                                Console.WriteLine("Dime la columna que deseas comprobar.")
                                coord2 = Int32.Parse(Console.ReadLine)
                                If array(coord1, coord2) = 0 Then
                                    Console.WriteLine("Has acertado.")
                                End If
                                If array(coord1, coord2) <> 0 Then
                                    vidas -= 1
                                    Console.ForegroundColor = ConsoleColor.Red
                                    Console.WriteLine("No has acertado. Pierdes una vida. Te quedan: " & vidas & ".")
                                    Console.ResetColor()
                                End If
                            Next
                        Next
                        Console.WriteLine("")
                        If vidas = 0 Then
                            opti -= 1
                        End If
                        Console.ReadLine()
                    Loop While opti = 0
                    Console.ReadLine()
            End Select
            Console.Clear()
        Loop While opcion <> 99
    End Sub
End Module