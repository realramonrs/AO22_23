Module Ejercicio4

    Sub Main()
        Dim radio, longitud, area, volumen As Single
        Const PI As Double = 3.1416


        'Entrada : radio
        Console.WriteLine("Introduzca el radio")
        radio = Convert.ToSingle(Console.ReadLine())



        'Cálculos
        longitud = Convert.ToSingle(2 * PI * radio)

        'area = Convert.ToSingle(PI * radio * radio)
        area = Convert.ToSingle(PI * Math.Pow(radio, 2))
        volumen = Convert.ToSingle((4 / 3) * PI * radio ^ 3)

        Console.WriteLine("El area es : " & area)
        Console.WriteLine("El volumen es : " & volumen)
        Console.WriteLine("La longitud es: " & longitud)


        Console.ReadLine()






    End Sub

End Module
