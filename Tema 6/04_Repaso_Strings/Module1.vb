Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        '****************** EJERCICIO 12 ******************
        'Número de vocales que hay en un String
        Dim cadena12 As String = "El murciélago"
        Dim contadorVocales As Integer = 0
        For i As Integer = 0 To cadena12.Length - 1 Step 1
            If cadena12(i) = "a"c Or cadena12(i) = "e"c Or cadena12(i) = "i"c Or cadena12(i) = "o"c Or cadena12(i) = "u"c Then
                contadorVocales += 1

            End If
        Next
        Console.WriteLine("Hay " & contadorVocales & " vocales.")

        'Estrategia 2: 
        Dim letrasBuscadas() As Char = {"a"c, "e"c, "i"c, "o"c, "u"c}
        Dim contadorVocales2 As Integer = 0
        'copright Kevin David
        For i As Integer = 0 To cadena12.Length - 1 Step 1
            For j As Integer = 0 To letrasBuscadas.Length - 1 Step 1
                If cadena12(i) = letrasBuscadas(j) Then
                    contadorVocales2 += 1
                End If
            Next
        Next
        Console.WriteLine("Vocales 2: " & contadorVocales2)

        '********************** EJERCICIO 13 ************************
        'Mostrar posiciones en las que se encuentra un espacio
        Dim cadena13 As String = "El examen es facilisimo"
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Ejercicio 2: Posiciones donde hay un espacio: ")
        Console.ResetColor()
        Console.WriteLine("String de prueba: " & cadena13)
        Console.WriteLine("Posiciones donde hay un espacio: ")
        For i As Integer = 0 To cadena13.Length - 1 Step 1
            If Char.IsWhiteSpace(cadena13(i)) Then
                Console.WriteLine("Posicion: " & i)
            End If
        Next

        '********************** EJERCICIO 14 ****************
        Console.WriteLine()
        Console.WriteLine(" ********************** EJERCICIO 14 ***************")
        Dim cadena14 As String = "Cadena HFHGFcon espacios"
        Dim posPrimerEspacio As Integer = cadena14.IndexOf(" "c)

        Dim vocales() As Char = {"a"c, "e"c, "i"c, "o"c, "u"c}

        Dim posPrimeraVocalDespuesDelEspacio As Integer = cadena14.IndexOfAny(vocales, posPrimerEspacio)

        Dim caracteresBuscados As String = cadena14.Substring(posPrimerEspacio + 1, posPrimeraVocalDespuesDelEspacio - posPrimerEspacio - 1)
        Console.WriteLine("Caracteres entre el espacio y la primera vocal en el string: " & cadena14)
        Console.WriteLine(caracteresBuscados)

        '********************** EJERCICIO 15 ****************
        Console.WriteLine()
        Console.WriteLine(" ********************** EJERCICIO 15 ***************")
        Dim cadena15 As String = "adena con espacios"
        Dim palabras() As String = cadena15.Split(" "c)
        Console.WriteLine()
        Console.WriteLine("Frase: " & cadena15)
        Console.WriteLine("Palabras que tienen al menos una letra mayúscula:")
        Dim encontrado As Boolean = False
        For i As Integer = 0 To palabras.Length - 1 Step 1
            For j As Integer = 0 To palabras(i).Length - 1 Step 1
                If Char.IsUpper(palabras(i)(j)) Then
                    Console.WriteLine(palabras(i))
                    encontrado = True
                End If
            Next
        Next
        If Not encontrado Then
            Console.WriteLine("No hay palabras con mayúsculas")
        End If

        Console.WriteLine()
        Console.WriteLine(" ********************** EJERCICIO 16 ***************")
        Console.WriteLine()
        Dim cadena16 As String = "adena con espacios"
        Dim palabras2() As String = cadena15.Split(" "c)
        Dim palabraMayor As String = palabras2(0)

        For Each cadena As String In palabras2
            If cadena.Length > palabraMayor.Length Then
                palabraMayor = cadena
            End If
        Next
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("La palabra con más caracteres es: " & palabraMayor)
        Console.ResetColor()
        '****************** EJERCICIO REPASO FICHEROS *************************
        Console.WriteLine()
        Console.WriteLine("***************** EJERCICIO REPASO FICHEROS ***************")
        Dim series(99) As String
        Dim ruta As String = Directory.GetCurrentDirectory() + "\Series.txt"
        Try
            Dim lector As StreamReader = New StreamReader(ruta)
            Dim posicion As Integer = 0

            Dim regstros() As String = File.ReadAllLines(ruta)
            While Not lector.EndOfStream
                '  series(posicion) = lector.ReadLine()
                Dim registro As String = lector.ReadLine()

                If registro.Split("*"c)(2) = "Netflix" Then
                    Console.WriteLine(registro)

                End If
                posicion += 1
            End While
            lector.Close()

            'Mostrar series de Netflix
            'For Each serie As String In series
            '    If Not serie Is Nothing Then
            '        If serie.Split("*"c)(2) = "Netflix" Then
            '            Console.WriteLine(serie)
            '        End If
            '    End If

            'Next

        Catch ex As Exception
            Console.WriteLine("Fichero no existe")
        End Try





        Console.ReadLine()

    End Sub

End Module
