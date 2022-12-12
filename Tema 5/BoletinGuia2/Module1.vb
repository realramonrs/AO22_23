Module Module1

    Sub Main()
        'Ejercicio 21
        Dim ejercicio As Integer
        Do
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
                    Dim a1() As Integer = {9, 5, 4}
                    Dim a2() As Integer = {4, 5, 2}

                    Dim iguales As Boolean

                    For i As Integer = 0 To a1.Length - 1 Step 1
                        If a1(i) <> a2(i) Then
                            iguales = False
                            Exit For
                        End If
                    Next
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
                Case 30
                    Dim emails(1) As String
                    Dim guardado As Boolean = False
                    Dim contador As Integer = 0
                    Dim nEmails As Integer
                    Console.WriteLine("Cuantos emails quiere guardar")
                    nEmails = Convert.ToInt32(Console.ReadLine())
                    Do

                        Console.WriteLine("Introduce tu email:")
                        Dim email As String = Console.ReadLine()
                        guardado = False
                        For i As Integer = 0 To emails.Length - 1 Step 1
                            If emails(i) Is Nothing Then
                                emails(i) = email
                                guardado = True
                                Exit For
                            End If
                        Next

                        If Not guardado Then

                            ReDim Preserve emails(emails.Length + 9)
                            Console.WriteLine("Como no hay espacio , aumentamos la capcidad")
                            Console.WriteLine("Nueva capacidad: " & emails.Length)
                            For i As Integer = 0 To emails.Length - 1 Step 1
                                If emails(i) Is Nothing Then
                                    emails(i) = email
                                    guardado = True
                                    Exit For
                                End If
                            Next
                        End If
                        contador += 1
                    Loop While contador < nEmails
                    'Mostrar la lista de correos
                    For Each email As String In emails
                        Console.WriteLine(email)
                    Next
            End Select
            Console.ReadLine()
        Loop While ejercicio <= 30
    End Sub

End Module
