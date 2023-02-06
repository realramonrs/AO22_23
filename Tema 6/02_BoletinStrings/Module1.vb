Option Strict On
Imports System.IO
Imports System.Text
Module Module1

    Sub Main()


        Dim matriculas(19) As String
        matriculas(0) = "1264-POI"
        matriculas(1) = "9087-CTR"
        matriculas(2) = "0934-SWZ"
        matriculas(3) = "2945-CVT"
        matriculas(4) = "5001-BGT"
        matriculas(5) = "8870-ZZC"
        matriculas(6) = "1123-CVB"
        matriculas(7) = "0423-MOI"
        matriculas(8) = "0088-CXZ"
        matriculas(9) = "1934-BMD"


        'Mostrar las matrículas que acaban por z
        Console.WriteLine("Matrículas que acaban por Z: ")
        'For i As Integer = 0 To matriculas.Length - 1 Step 1
        '    If Not matriculas(i) Is Nothing Then
        '        If matriculas(i).EndsWith("Z") Then
        '            Console.WriteLine(matriculas(i))
        '        End If
        '    End If

        'Next

        For Each matricula As String In matriculas
            If Not matricula Is Nothing Then
                If matricula.EndsWith("Z") Then
                    Console.WriteLine(matricula)
                End If
            End If
        Next


        'Matrículas que contienen el número 34
        Console.WriteLine("Matrículas que tienen el número 34:")
        Dim m34 As Boolean = False
        For Each matricula As String In matriculas
            If Not matricula Is Nothing Then
                If matricula.Contains("34") Then
                    Console.WriteLine(matricula)
                    m34 = True
                End If
            End If
        Next

        If m34 = False Then
            Console.WriteLine("No hay matrículas que contengan el 34")
        End If

        'Mostrar parte numérica
        Console.WriteLine()
        Console.WriteLine("Parte numérica: ")
        For Each mat As String In matriculas
            If Not mat Is Nothing Then
                Dim parteNumerica As String = mat.Substring(0, 4)
                Console.WriteLine(parteNumerica)
            End If
        Next

        Console.WriteLine()
        Console.WriteLine("Parte letras: ")
        For Each mat As String In matriculas
            If Not mat Is Nothing Then
                Dim parteLetras As String = mat.Substring(5)
                Console.WriteLine(parteLetras)
            End If
        Next

        'Apartado E: Volcar datos matrículas a un Fichero
        Dim escritor As New StreamWriter(Directory.GetCurrentDirectory() + "\matriculas.txt", False)

        For Each matricula As String In matriculas
            If matricula Is Nothing Then
                Exit For
            End If
            escritor.WriteLine(matricula)
        Next

        escritor.WriteLine("Adios")
        'Cerramos el escritor
        escritor.Close()



        'Ejercicio 2
        Dim frase As String
        Console.WriteLine(" ********************* EJERCICIO 2 ***********************")
        Console.WriteLine("introduzca una frase")

        frase = Console.ReadLine()
        Dim caracter As Char
        Console.WriteLine("Que caracter quieres buscar: ?")
        caracter = Convert.ToChar(Console.ReadLine())

        'Ejercicio 3
        'Volcar los datos del fichero accesos a una matriz de Stirngs
        Dim accesos(99) As String

        Dim lector As StreamReader = New StreamReader(Directory.GetCurrentDirectory() + "\accesos.txt")
        Dim posicion As Integer = 0
        While Not lector.EndOfStream
            accesos(posicion) = lector.ReadLine()
            posicion += 1
        End While
        lector.Close()


        Console.WriteLine(" *********************** EJERCICIO 3 **********************")
        Dim letras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}
        Dim mistake As Boolean = False

        Dim dni As String
        Console.WriteLine("Introduce el DNI: ")
        dni = Console.ReadLine()

        '1º Verificamos que está compuesto por 9 caracteres -> 8 dígitos + 1 letra
        If dni.Length <> 9 Then
            mistake = True
            Console.WriteLine("Error en el formato, no hay 9 caracteres")
        Else

            'Verifico que tiene 8 dígitos y una letra
            For i As Integer = 0 To 7 Step 1
                If Not Char.IsDigit(dni(i)) Then
                    mistake = True
                    Console.WriteLine("Los primeros 8 caracteres deben ser dígitos.")
                    Exit For
                End If

            Next
            If mistake = False Then
                If Not Char.IsLetter(dni(8)) Then
                    mistake = True
                    Console.WriteLine("El último caracter debe ser una letra")
                End If
            End If
        End If

        '2º Comprobar la letra

        'Obtener la parte numérica del dni
        If mistake = False Then
            Dim numeroDNI As Integer = Convert.ToInt32(dni.Substring(0, 8))
            Dim resto As Integer = numeroDNI Mod 23
            Dim letraCorrecta As Char = letras(resto)
            Dim letraDNI As Char = dni(8)

            If letraDNI = letraCorrecta Then
                Console.WriteLine("El DNI es correcto.")
                'Esto es a mayores, no es necesario saberlo lo importante es lo anterior
                'Buscar si ya está en el fichero de accesos
                'Contamos número de accesos
                Dim contadorAccesos As Integer
                For Each acceso As String In accesos
                    If acceso Is Nothing Then
                        Exit For
                    End If
                    If dni = acceso.Split("*"c)(0) Then
                        '  If Date.Today.ToShortDateString = acceso.Split("*"c)(1).Split(" "c)(0) Then
                        If Date.Today.ToShortDateString = acceso.Substring(10, 10) Then
                            contadorAccesos += 1

                        End If
                    End If
                Next
                Console.WriteLine("Ha accedido : " & contadorAccesos & " veces")

                'Fin del apartado a mayores

                Dim escritorDNIs As StreamWriter = New StreamWriter(Directory.GetCurrentDirectory() + "\accesos.txt", True)
                escritorDNIs.WriteLine(dni + "*" + Date.Now.ToString)
                escritorDNIs.Close()

            Else
                Console.WriteLine("Error en la letra del DNI")
                mistake = True
            End If

        End If

        Console.WriteLine(" ********************* EJERCICIO 4 ********************")
        'Ejercicio 4: Mostrar palabras que tienen b
        Dim fraseej4 As String = "Voy bien en programacion, busco soluciones a los problemas"
        Dim palabras() As String = fraseej4.Split(" "c)
        Console.WriteLine("Palabras que empiezan por b: ")
        For Each palabra As String In palabras
            If palabra.StartsWith("b") Then
                Console.WriteLine(palabra)
            End If
        Next

        Console.ReadLine()
    End Sub

End Module
