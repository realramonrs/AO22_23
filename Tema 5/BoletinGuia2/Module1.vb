Module Module1

    Sub Main()
        'Ejercicio 21
        Dim ejercicio As Integer
        Console.WriteLine("Introduzca el ejercicio")
        ejercicio = Convert.ToInt32(Console.ReadLine())

        Select Case ejercicio
            Case 21
                'Buscar la primera pos vacía de un array de Strings
                Dim cadenas() As String = {"Pedro", "Javier", Nothing, "Susana"}

                Dim posicion As Integer = -1

                For i As Integer = 0 To cadenas.Length - 1 Step 1
                    'Si hay posicion vacía
                    If cadenas(i) Is Nothing Then
                        posicion = i
                        Exit For
                    End If
                Next
                If posicion < 0 Then
                    Console.WriteLine("el array está lleno")
                Else
                    Console.WriteLine("La primera posición vacía es la : " & posicion)
                End If

                Console.ReadLine()
            Case 25
                Dim arrayejercicio25(29) As Integer
                generarArray(arrayejercicio25, 50)

                'Ver el array
                Console.WriteLine("Array generado: ")
                mostrarArray(arrayejercicio25)

                'Obtener el valor más pequeño
                Dim minimo As Integer = arrayejercicio25(0)

                For i As Integer = 1 To arrayejercicio25.Length - 1 Step 1
                    If minimo > arrayejercicio25(i) Then
                        minimo = arrayejercicio25(i)
                    End If
                Next
                Console.WriteLine("El más pequeño es: " & minimo)

            Case 26
            Case 28
                Dim array1(9) As Integer
                Dim array2(array1.Length - 1) As Integer

                generarArray(array1, 20)

                For i As Integer = 0 To array1.Length - 1 Step 1
                    array2(i) = array1(i)
                Next

                mostrarArray(array1)
                mostrarArray(array2)

                Console.ReadLine()

        End Select
        Console.ReadLine()
    End Sub

End Module
