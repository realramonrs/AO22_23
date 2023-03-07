Option Strict On
Imports System
Imports Microsoft.VisualBasic.Logging

Module Ejercicio11
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(10)

        Dim random As New Random()

        For index = 1 To lista.Capacity
            lista.Add(random.Next(1, 26))
        Next

        'a.	Posición en la que se encuentra el valor 2. En caso de que no se encuentre informar.

        Dim posicion As Integer = lista.IndexOf(2)

        If posicion < 0 Then
            Console.WriteLine("El 2 no está en la lista")
        Else
            Console.WriteLine("El 2 está en la posición " & posicion)
        End If

        'b.Calcular la suma de los valores generados.

        Dim suma As Integer = 0

        For Each valor As Integer In lista
            suma += valor
        Next

        Console.WriteLine("La suma es: " & suma)

        'c.Calcular la media de valores generados.

        Dim media As Double

        media = suma / lista.Count

        Console.WriteLine("La media es: " & media)

        'd.Calcular el porcentaje de números superiores a 20 almacenados en la lista.

        Dim contadorMayores20 As Integer = 0
        Dim porcentaje As Double

        For Each numero As Integer In lista
            If numero > 20 Then
                contadorMayores20 += 1
            End If
        Next

        porcentaje = (contadorMayores20 / lista.Count) * 100

        Console.WriteLine("El porcentaje de numeros mayores a 20 es: " & porcentaje)

        'e.Mostrar los valores que están almacenados , sin mostrar las repeticiones, es decir , si el número 2 se encuentra 4 veces en la lista, sólo debe de mostrarse una.

        lista.Sort()

        Dim numeroAnterior As Integer = 0

        For Each numeroAComprobar As Integer In lista
            If numeroAComprobar <> numeroAnterior Then
                Dim contador As Integer = 0

                For Each numero As Integer In lista
                    If numero = numeroAComprobar Then
                        contador += 1
                    End If
                Next
                Console.WriteLine("Numero " & numeroAComprobar & " aparece " & contador & " veces")
                numeroAnterior = numeroAComprobar
            End If
        Next

        Console.ReadKey()
    End Sub
End Module
