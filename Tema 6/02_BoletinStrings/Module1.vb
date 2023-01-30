Imports System.IO
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
        Console.WriteLine("introduzca una frase")
        frase = Console.ReadLine()
        Dim caracter As Char
        Console.WriteLine("Que caracter quieres buscar: ?")
        caracter = Convert.ToChar(Console.ReadLine())


        Console.ReadLine()
    End Sub

End Module
