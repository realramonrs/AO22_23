Module ExamenCorreccion

    Sub Main()

        Dim numeros As ArrayList = New ArrayList(10)
        Dim opcion As Char
        Dim finalizaBucle As Boolean = False

        While finalizaBucle = False
            Console.WriteLine("a) Rellena el array con números aleatorios negativos y positivos
b) Mostrar la suma de los números
c) Mostrar el promedio de los números
d) Mostrar el número menor y mayor
e) Muestra por pantalla la cantidad de números primos que hay en el ArrayList
f) Cuenta cuántos números hay por encima del promedio del ArrayList
g) Sustituye todos los números negativos por el mismo número en positivo.
h) Muestra por pantalla la posición del último número impar del ArrayList
i) Muestra por pantalla la cantidad de veces que aparece cada número, ordenado de menor a mayor.
j) Salir")

            opcion = Convert.ToChar(Console.ReadLine)

            Select Case opcion
                Case "a"c
                    Dim rand As New Random

                    For index = 1 To numeros.Capacity
                        numeros.Add(rand.Next(-10, 10))
                    Next

                    For Each numero In numeros
                        Console.WriteLine(numero)
                    Next

                Case "b"c
                    Dim sumaNumeros As Integer = 0
                    For Each numero In numeros
                        sumaNumeros += numero
                    Next

                    Console.WriteLine("La suma de los números es: " & sumaNumeros)

                Case "c"c

                    Dim promedioNumeros As Double = 0
                    Dim sumaNumeros As Integer = 0

                    For Each numero In numeros
                        sumaNumeros += numero
                    Next

                    promedioNumeros = sumaNumeros / numeros.Count

                    Console.WriteLine("El promedio de los números es: " & promedioNumeros)

                Case "d"c

                    numeros.Sort()

                    Console.WriteLine("El número menor es: " & numeros(0))
                    Console.WriteLine("El número mayor es: " & numeros(numeros.Count - 1))

                Case "e"c

                    Dim contadorPrimos As Integer = 0
                    Dim contadorDivisores As Integer = 0

                    For Each numero In numeros
                        For divisor = 1 To numero
                            If numero Mod divisor = 0 Then
                                contadorDivisores += 1
                            End If
                        Next
                        If contadorDivisores <= 2 Then
                            contadorPrimos += 1
                        End If
                        contadorDivisores = 0
                    Next

                    Console.WriteLine("La cantidad de numeros primos es: " & contadorPrimos)

                Case "f"c
                    Dim promedioNumeros As Double = 0
                    Dim sumaNumeros As Integer = 0
                    Dim contadorNumerosSobrePromedio As Integer = 0

                    For Each numero In numeros
                        sumaNumeros += numero
                    Next

                    promedioNumeros = sumaNumeros / numeros.Count

                    For Each numero In numeros
                        If numero > promedioNumeros Then
                            contadorNumerosSobrePromedio += 1
                        End If
                    Next

                    Console.WriteLine("La cantidad de numeros sobre el promedio es: " & contadorNumerosSobrePromedio)

                Case "g"c
                    For index = 0 To numeros.Count - 1
                        If numeros(index) < 1 Then
                            numeros(index) = Math.Abs(numeros(index))
                        End If
                    Next

                Case "h"c
                    Dim ultimoImpar As Integer = Integer.MaxValue
                    For Each numero In numeros
                        If numero Mod 2 = 1 Then
                            ultimoImpar = numero
                        End If
                    Next

                    Console.WriteLine("La posicion del ultimo numero impar es: " & numeros.LastIndexOf(ultimoImpar))

                Case "i"c

                    Dim contador As Integer = 0
                    Dim numeroAnterior As Integer = Integer.MaxValue

                    numeros.Sort()

                    For Each numeroAComparar In numeros
                        If numeroAComparar <> numeroAnterior Then
                            For Each numero In numeros
                                If numeroAComparar = numero Then
                                    contador += 1
                                End If
                            Next
                            Console.WriteLine("El numero {0} aparece {1} veces", numeroAComparar, contador)
                            contador = 0
                            numeroAnterior = numeroAComparar
                        End If
                    Next

                Case "j"c
                    finalizaBucle = True

                Case Else
                    Console.WriteLine("Selecciona una opción correcta")
            End Select
            Console.ReadKey()
            Console.Clear()
        End While


    End Sub

End Module
