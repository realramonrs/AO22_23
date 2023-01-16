Module Module1

    Sub Main()
        Dim n As Integer
        Console.WriteLine("Indica el número de elementos : ")
        n = Convert.ToInt32(Console.ReadLine())
        Dim matriz1(n - 1) As Integer
        generarArray(matriz1, 0, 10)
        Dim suma As Integer
        Dim media As Double

        For i As Integer = 0 To matriz1.Length - 1 Step 1
            suma = suma + matriz1(i)
        Next
        media = suma / matriz1.Length
        Console.WriteLine("La media es : " & media)

        Dim contador As Integer
        Dim porcentaje As Double
        For u As Integer = 0 To matriz1.Length - 1 Step 1
            If matriz1(u) > media Then
                contador += 1
            End If
        Next

        porcentaje = (contador / matriz1.Length) * 100
        Console.WriteLine("Porcentaje de valores > media : " & porcentaje & "%")



        Console.WriteLine(" ******************* FIN EJERCICIO 1 *****************************")
        'Cálculo de las desviaciones
        Dim desviaciones(matriz1.Length - 1) As Double

        For i As Integer = 0 To matriz1.Length - 1 Step 1
            desviaciones(i) = Math.Abs(media - matriz1(i))

        Next
        Console.WriteLine("Desviaciones calculadas: ")
        mostrarArray(desviaciones)
        Console.WriteLine()
        'cálculo desviacion media
        Dim desvMedia As Double = 0
        Dim sumaDesv As Double = 0
        For i As Integer = 0 To desviaciones.Length - 1 Step 1
            sumaDesv = sumaDesv + desviaciones(i)
        Next

        desvMedia = sumaDesv / desviaciones.Length
        Console.WriteLine("La desviación media es : " & desvMedia)
        Console.WriteLine("********************** FIN EJERCICIO 2 *******************")

        'Ejercicio 3
        Dim a1(3) As Integer
        Dim a2(3) As Integer
        'Solicitar al usuario datos del primero
        For i As Integer = 0 To a1.Length - 1 Step 1
            Console.WriteLine("Intro valor posición: " & i)
            a1(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For i As Integer = 0 To a1.Length - 1 Step 1
            a2(i) = a1(i) + 10
        Next

        mostrarArray(a1)
        mostrarArray(a2)
        Console.WriteLine("*********************** FIN EJERCICIO 3********************")

        Dim matriz4(9) As Integer
        generarArray(matriz4, 1, 10)
        Dim sumaCuadrados As Integer
        Dim modulo As Double

        For i As Integer = 0 To matriz4.Length - 1 Step 1
            sumaCuadrados = sumaCuadrados + matriz4(i) * matriz4(i)
        Next

        modulo = Math.Sqrt(sumaCuadrados)
        Console.WriteLine("El modulo es : " & modulo)

        Console.WriteLine("******************** FIN EJERCICIO 4***************************")

        Dim matriz5(9) As Integer
        generarArray(matriz5, -10, 10)
        Console.WriteLine("Array ejercicio 5: ")
        mostrarArray(matriz5)

        Dim posicion As Integer = -1

        For i As Integer = 0 To matriz5.Length - 1 Step 1
            If matriz5(i) < 0 Then
                posicion = i
                Exit For
            End If
        Next
        If posicion = 0 Then
            Console.WriteLine("No hay números negativos")
        Else
            Console.WriteLine("El primer número negativo está en la pos: " & posicion)
        End If

        Console.WriteLine("****************** FIN EJERCICIO 5 *****************************")
        Console.WriteLine()
        Dim matriz6() As Integer = {3, 4, 5, 4, 3, 2, 1}
        ' generarArray(matriz6, 1, 10)
        Console.WriteLine("array ejercicio 6")
        mostrarArray(matriz6)
        Dim valorBuscado As Integer = 3
        Console.WriteLine("Valor buscado: " & valorBuscado)
        Dim encontrado As Boolean = False
        Console.WriteLine("Posiciones: ")
        For i As Integer = 0 To matriz6.Length - 1 Step 1
            If valorBuscado = matriz6(i) Then
                Console.Write(i & " ")
                encontrado = True
            End If

        Next

        If Not encontrado Then
            Console.WriteLine(valorBuscado & " no está en la matriz.")
        End If
        Console.WriteLine()

        Console.WriteLine("*****************FIN EJERCICIO 6 ******************")

        Dim matriz9(9) As Integer
        generarArray(matriz9, 1, 20)
        Console.WriteLine("Matriz ejercicio 9: ")
        mostrarArray(matriz9)
        Dim maximo As Integer = matriz9(0)

        For u As Integer = 1 To matriz9.Length - 1 Step 1
            If maximo < matriz9(u) Then
                maximo = matriz9(u)
            End If
        Next
        Console.WriteLine("El máximo es : " & maximo)





        Console.ReadLine()




    End Sub

End Module
