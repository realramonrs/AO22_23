Module Module1

    Sub Main()
        Dim mensaje As String = "El Celta"
        Dim primerCaracter As Char = mensaje(0)
        Dim numeroCaracteres As Integer = mensaje.Length
        Dim ultimoCaracter As Char = mensaje(mensaje.Length - 1)

        'Contar cuantos caracteres hay en un string
        Console.WriteLine("Hay " & numeroCaracteres & " caracteres")


        'Contar las veces que aparece la letra a
        Dim contadorAes As Integer = 0
        For i As Integer = 0 To mensaje.Length - 1 Step 1
            If mensaje(i) = "a"c Then
                contadorAes += 1
            End If
        Next
        'Mostrar en que posiciones aparece la letra a
        Console.WriteLine("Posiciones en las que hay una a: ")
        For i As Integer = 0 To mensaje.Length - 1 Step 1
            If mensaje(i) = "a"c Then
                Console.Write(i & " , ")
            End If
        Next
        Console.WriteLine()

        'Contar caracteres que no son espacio
        Dim contadorNoEspacios As Integer = 0
        For i As Integer = 0 To mensaje.Length - 1 Step 1
            If mensaje(i) <> " "c Then
                contadorNoEspacios += 1
            End If
        Next
        Console.WriteLine("Caracteres no espacio: " & contadorNoEspacios)

        'Funciones comunes de la variable String
        'indexOf --> Saber la primera posición de un char en un String
        Dim mensaje2 As String = "Los pantalones de Elías dan miedo"
        Dim posicionA1 As Integer = mensaje2.IndexOf("o"c)

        If posicionA1 < 0 Then
            Console.WriteLine("No hay oes")
        Else
            Console.WriteLine("La o aparece por primera vez en posicion: " & posicionA1)

        End If

        Dim caracter As Char
        Console.WriteLine("Que caracter quieres buscar ?")
        caracter = Convert.ToChar(Console.ReadLine())

        Dim pos As Integer = mensaje2.IndexOf(caracter)

        If pos < 0 Then
            Console.WriteLine("No está el caracter buscado")
        Else
            Console.WriteLine(caracter & " está en posición: " & pos)
        End If

        'substring --> Obtiene una subcadena 
        Dim cadena3 As String = "Elías me va a contagiar"
        'Obtener los 5 primeros caracteres
        Dim subCadena As String = cadena3.Substring(0, 5)
        Console.WriteLine("Substring(0,5)" & subCadena)

        Dim email As String = "alexandre@ciclosmontecastelo.com"
        Dim posArroba As Integer = email.IndexOf("@"c)
        Dim dominio As String = email.Substring(posArroba + 1)
        Console.WriteLine(dominio)

        'split--> Separar una cadena en palabras-

        Dim palabras() As String = email.Split("@"c)
        Console.WriteLine(palabras(0))
        Console.WriteLine(palabras(1))

        'Cuantas palabras contienen la letra z?
        Dim ejemplo As String = "Esto ez una nueva funzión , no?"
        Dim palabras2() As String = ejemplo.Split(" "c)

        Console.WriteLine()
        Console.WriteLine("Palabras con Z : ")
        For Each p As String In palabras2
            If p.Contains("z") Then
                Console.WriteLine(p)
            End If
        Next

        'Char.isDigit, Char.isLetter, Char.IsUper, Char.toUpper...

        'Cuantos dígitos hay en un string
        Dim ejemplo4 As String = "12345678F"
        Dim cont As Integer
        For i As Integer = 0 To ejemplo.Length - 1 Step 1
            If Char.IsDigit(ejemplo4(i)) Then
                cont += 1
            End If
        Next

        'Cuántas palabras tienen una maýúscula
        Dim serkae As String = "Sergio Intenta acertar esta Vez"
        Dim palabrasSerkae() As String = serkae.Split(" "c)
        Dim cont2 As String
        For Each p As String In palabrasSerkae
            For Each letra As Char In p
                If Char.IsUpper(letra) Then
                    cont2 += 1
                    Exit For
                End If
            Next
        Next
        'Cuántas palabras empiezan por A
        Dim ejemplo10 As String = "Fabián aprende jugando Al LOL"

        Dim ps() As String = ejemplo10.Split(" "c)

        For Each palabra As String In ps
            If palabra.StartsWith("A") Then

            End If
        Next













        Console.ReadLine()
    End Sub

End Module
