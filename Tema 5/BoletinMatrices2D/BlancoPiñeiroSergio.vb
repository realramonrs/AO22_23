Option Strict On
Module BlancoPiñeiroSergio

    Sub Main()
        Dim ejercicio As String

        Console.Write("Que ejercicio quieres hacer: ")
        ejercicio = Console.ReadLine()

        Select Case ejercicio
            Case "1"

                Dim matriz(,) As Integer = {{0, 6, 9}, {0, 2, 6}, {7, 10, 9}}
                Dim seleccion As Integer

                Console.Write("Que fila deseas mostrar: ")
                seleccion = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine(" ")

                For i = seleccion - 1 To seleccion - 1
                    For b = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, b) & " ")
                    Next
                Next

                Console.WriteLine("Apartado B")

                For i = 0 To 2
                    For b = 0 To 2
                        Console.Write(matriz(i, b) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine("")

                Console.WriteLine("ARRAY 2D MODIFICADO")

                matriz(0, 2) = 0
                matriz(1, 2) = 0
                matriz(2, 2) = 0


                For i = 0 To 2
                    For b = 0 To 2
                        Console.Write(matriz(i, b) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine("")
                Console.WriteLine("Apartado C")


                Dim suma As Integer

                For i = 0 To matriz.GetUpperBound(0)
                    Console.Write(matriz(0, i) & " ")
                    suma += matriz(0, i)
                Next

                Console.WriteLine("")
                Console.WriteLine("La suma de todos los valores de la primera fila es: " & suma)

                Console.WriteLine("APARTADO D")
                Dim contarCero As Integer = 0
                For i = 0 To matriz.GetUpperBound(1)
                    If matriz(i, 0) = 0 Then
                        contarCero += 1
                    End If

                Next

                Console.WriteLine("En la segunda columna hay un total de " & contarCero & " cero/s ")

            Case "2"

                Dim matriz(2, 2) As Integer
                Dim aleatorio As New Random

                Console.WriteLine(" ")

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        matriz(i, j) = aleatorio.Next(1, 100)
                    Next
                Next


                For i = 0 To 2
                    For j = 0 To 2
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine(" ")
                Next

                Dim suma As Integer

                For i = 0 To 2
                    For j = 0 To 2
                        suma += matriz(i, j)
                    Next
                Next

                Console.WriteLine("La media de los elementos es: " & Math.Round(suma / matriz.Length))

            Case "3"

                Dim temperatura(11, 29) As Integer

                GenerarTemperatura(temperatura, -10, 40)

                For i = 0 To temperatura.GetUpperBound(0)
                    For j = 0 To temperatura.GetUpperBound(1)
                        Console.Write(temperatura(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Case "4"

                Dim matriz(3, 3) As Integer
                Dim contador As Integer
                GenerarMatriz(matriz, 0, 0)


                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        If matriz(i, j) = 0 Then
                            contador += 1
                        End If
                    Next
                Next

                Console.WriteLine("El " & (contador * matriz.Length) / 100 & " % de numeros que son cero")


            Case "5"

                Dim matriz(3, 3) As Integer
                Dim matriztranspuesta(3, 3) As Integer
                Dim simetrico As Boolean = False

                GenerarMatriz(matriz, 1, 20)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        matriztranspuesta(j, i) = matriz(i, j)
                    Next
                Next



                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine(" ")

                For i = 0 To matriztranspuesta.GetUpperBound(0)
                    For j = 0 To matriztranspuesta.GetUpperBound(1)
                        Console.Write(matriztranspuesta(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                For i = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriztranspuesta.GetUpperBound(1)
                        If matriz(i, b) <> matriz(b, i) Then
                            simetrico = False
                            Exit For
                        End If
                    Next
                    If simetrico = False Then
                        Console.WriteLine()
                        Console.WriteLine("La matriz no es simetrica")
                        Exit For
                    End If
                Next

            Case "6"

                Dim matriz(2, 9) As Integer
                Dim suma As Integer

                GenerarMatriz(matriz, 1, 5)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                For i = 0 To matriz.GetUpperBound(1)
                    suma = suma + matriz(0, i)
                Next

                Console.WriteLine("La suma de la primera fila es: " & suma)

            Case "7"

                Dim matriz(2, 9) As Integer
                Dim suma As Integer

                GenerarMatriz(matriz, 1, 5)

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                For i = 0 To matriz.GetUpperBound(0)
                    suma = suma + matriz(i, 9)
                Next

                Console.WriteLine("La suma de la ultima columna es: " & suma)

            Case "8"



            Case "9"

                Dim contador As Integer = 0
                Dim matriz1(2, 2) As Integer


                GenerarMatriz(matriz1, 0, 15)

                For i = 0 To matriz1.GetUpperBound(0)
                    For j = 0 To matriz1.GetUpperBound(1)
                        Console.Write(matriz1(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine()

                For i = 0 To matriz1.GetUpperBound(0)
                    For b = 0 To matriz1.GetUpperBound(1)
                        If matriz1(i, b) = 0 Then
                            contador += 1
                        End If

                    Next
                    If contador = 3 Then
                        Exit For
                    Else
                        contador = 0
                    End If
                Next

                If contador = 3 Then
                    Console.WriteLine("La matriz tiene una fila compuesta por ceros")
                Else
                    Console.WriteLine("La matriz no tiene ninguna fila compuesta por ceros")
                End If

            Case "10"

                Dim matriz1(4, 4) As Integer
                Dim matriz2(4, 4) As Integer
                Dim matriz3(4, 4) As Integer

                GenerarMatriz(matriz1, 1, 10)
                GenerarMatriz(matriz2, 1, 10)

                For i = 0 To matriz1.GetUpperBound(0)
                    For b = 0 To matriz1.GetUpperBound(1)
                        matriz3(i, b) = matriz1(i, b) + matriz2(i, b)
                    Next
                Next

                For i = 0 To matriz1.GetUpperBound(0)
                    For j = 0 To matriz1.GetUpperBound(1)
                        Console.Write(matriz1(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine("")

                For i = 0 To matriz2.GetUpperBound(0)
                    For j = 0 To matriz2.GetUpperBound(1)
                        Console.Write(matriz2(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine("")

                For i = 0 To matriz3.GetUpperBound(0)
                    For j = 0 To matriz3.GetUpperBound(1)
                        Console.Write(matriz3(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next


            Case "11"

                Dim matriz(4, 4) As Integer
                Dim salvar(1, 1) As Integer
                Dim cambiar As Boolean = False
                GenerarMatriz(matriz, -5, 10)
                matriz(0, 0) = 12

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine()

                For i = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriz.GetUpperBound(1)
                        If matriz(i, b) < 0 Then
                            salvar(0, 0) = matriz(0, 0)
                            matriz(0, 0) = matriz(i, b)
                            matriz(i, b) = salvar(0, 0)
                            cambiar = True
                            Exit For
                        End If
                    Next
                    If cambiar Then
                        Exit For
                    End If
                Next

                Console.WriteLine()

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Case "12"

                Dim matriz(4, 4) As Integer
                Dim salvar(1, 1) As Integer
                Dim cambiar As Boolean = False
                GenerarMatriz(matriz, -5, 200)
                matriz(0, 0) = 12

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine()

                For i = 0 To matriz.GetUpperBound(0)
                    For b = 0 To matriz.GetUpperBound(1)
                        If matriz(i, b) > 100 Then
                            salvar(0, 0) = matriz(matriz.GetUpperBound(0), matriz.GetUpperBound(1))
                            matriz(matriz.GetUpperBound(0), matriz.GetUpperBound(1)) = matriz(i, b)
                            matriz(i, b) = salvar(0, 0)
                            cambiar = True
                            Exit For
                        End If
                    Next
                    If cambiar Then
                        Exit For
                    End If
                Next

                Console.WriteLine()

                For i = 0 To matriz.GetUpperBound(0)
                    For j = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Case "13"

                Dim matriz(4, 4) As Integer
                Dim acabado As Boolean = False
				GenerarMatriz(matriz, 0, 3)

				For i = 0 To matriz.GetUpperBound(0)
					For b = 0 To matriz.GetUpperBound(1)
						If matriz(0, 1) = 0 And matriz(0, 2) = 0 And matriz(1, 2) = 0 Then
							Console.WriteLine("La matriz es triangular inferior")
							acabado = True
							Exit For

						ElseIf matriz(1, 0) = 0 And matriz(2, 0) = 0 And matriz(2, 1) = 0 Then
							Console.WriteLine("La matriz es triangular superior")
							acabado = True
							Exit For
						Else
							Console.WriteLine("No es ninguna de las 2")
							acabado = True
							Exit For
						End If
					Next
					If acabado Then
						Exit For
					End If
				Next

			Case "14"

				Dim matriz(4, 4) As Integer
				GenerarMatriz(matriz, 1, 10)

				If matriz.GetUpperBound(0) = matriz.GetUpperBound(1) Then
					Console.WriteLine("La matriz es cuadrada")
					For i = 0 To matriz.GetUpperBound(0)
						For b = 0 To matriz.GetUpperBound(1)
							If i = b Then
								Console.ForegroundColor = ConsoleColor.Red
								Console.Write(matriz(i, b) & " ")
							Else
								Console.ForegroundColor = ConsoleColor.White
								Console.Write(matriz(i, b) & " ")
							End If
						Next
						Console.WriteLine()
					Next
				End If

			Case "15"

				Dim matriz(4, 4) As Integer
				GenerarMatriz(matriz, -5, 5)
				For i As Integer = 0 To matriz.GetUpperBound(0)
					For j As Integer = 0 To matriz.GetUpperBound(1)
						Dim repetido As Boolean = False
						For x As Integer = 0 To matriz.GetUpperBound(0)
							For y As Integer = 0 To matriz.GetUpperBound(1)
								If matriz(i, j) = matriz(x, y) And i <> x And j <> y Then
									repetido = True
									Exit For
								End If
							Next
							If repetido Then Exit For
						Next
						If Not repetido Then
							Console.WriteLine(matriz(i, j))
						End If
					Next
				Next

			Case "16"

				Dim matriz(5, 5) As Integer
				GenerarMatriz(matriz, 1, 20)
				matriz(0, 0) = 0
				Dim random As New Random
				Dim contador As Integer = 0
				For i = 0 To matriz.GetUpperBound(0)
					For b = 0 To matriz.GetUpperBound(1)
						matriz(random.Next(0, 5), random.Next(0, 5)) = 0
						contador += 1
						If contador = 3 Then
							Exit For
						End If
					Next
					If contador = 3 Then
						Exit For
					End If
				Next

				Dim x, y As Integer
				Dim vida As Integer = 6
				Dim seleccionUser(5, 5) As Integer
				Dim win As Boolean
				Dim repetir As Boolean = False

				Do
					Console.WriteLine("Tienes " & vida & " vidas restantes")
					Console.Write("Elige la X del numero: ")
					x = Convert.ToInt32(Console.ReadLine())
					Console.WriteLine()
					Console.Write("Elige la Y del numero: ")
					x = Convert.ToInt32(Console.ReadLine())

					For i = 0 To matriz.GetUpperBound(0)
						For b = 0 To matriz.GetUpperBound(1)
							If matriz(x, y) = 0 Then
								Console.WriteLine("Has ganado")
								win = True
								Exit Do
							Else
								Console.WriteLine("Has fallado, pruebalo de nuevo")
								vida -= 1
								repetir = True
								Exit For
							End If
						Next
						If repetir Then
							Exit For
						End If
					Next
					repetir = False
					Console.WriteLine()
					Console.WriteLine()

				Loop While vida <> 0

				If vida = 0 Then
					Console.WriteLine("Has perdido todas tus vidas")
				ElseIf win Then
					Console.WriteLine("Felicidades por tu victoria")
				End If


			Case "reto1"

                Dim a As Integer = 0

                Dim b As Integer = 5

                Dim matriz(b - a) As Integer

                For i As Integer = 0 To matriz.Length - 1
                    matriz(i) = a
                    a = a + 1
                Next

                For i = 0 To matriz.Length - 1
                    Console.Write(matriz(i) & " ")
                Next

			Case "reto2"

				Dim salvar As Integer
                Dim test As Integer = 0
                Dim numeros(4, 4) As Integer
                GenerarTemperatura(numeros, -5, 10)

                Console.WriteLine("SIN ORDENAR")

                For i = 0 To numeros.GetUpperBound(0)
                    For j = 0 To numeros.GetUpperBound(1)
                        Console.Write(numeros(i, j) & " ")
                    Next
                    Console.WriteLine("")
                Next

                Console.WriteLine("ORDENADO")

                For h = 0 To numeros.GetUpperBound(0)
                    For i = 0 To numeros.GetUpperBound(1)
                        For j = 0 To numeros.GetUpperBound(0)
                            For k = 0 To numeros.GetUpperBound(1)
                                If numeros(j, k) > numeros(h, i) Then
                                    salvar = numeros(j, k)
                                    numeros(j, k) = numeros(h, i)
                                    numeros(h, i) = salvar
                                End If
                            Next
                        Next
                    Next
                Next

                For i = 0 To numeros.GetUpperBound(0)
                    For j = 0 To numeros.GetUpperBound(1)
                        Console.Write(numeros(i, j) & " ")
                    Next
                    Console.WriteLine("")
                Next



        End Select

        Console.ReadLine()
    End Sub

	Public Sub GenerarTemperatura(ByRef matriz(,) As Integer, ByVal tempmin As Integer, ByVal tempmax As Integer)

		Dim aleatorio As New Random

		For i = 0 To matriz.GetUpperBound(0)
			For j = 0 To matriz.GetUpperBound(1)
				matriz(i, j) = aleatorio.Next(tempmin, tempmax)
			Next
		Next

	End Sub

	Public Sub GenerarMatriz(ByRef matriz(,) As Integer, ByVal tempmin As Integer, ByVal tempmax As Integer)

		Dim aleatorio As New Random

		For i = 0 To matriz.GetUpperBound(0)
			For j = 0 To matriz.GetUpperBound(1)
				matriz(i, j) = aleatorio.Next(tempmin, tempmax)
			Next
		Next

	End Sub

	Public Sub GenerarMatriz1D(ByRef matriz() As Integer, ByVal tempmin As Integer, ByVal tempmax As Integer)

		Dim aleatorio As New Random

		For i = 0 To matriz.GetUpperBound(0)
			matriz(i) = aleatorio.Next(tempmin, tempmax)
		Next

	End Sub

End Module
