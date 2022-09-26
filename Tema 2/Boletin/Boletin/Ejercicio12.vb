Module Ejercicio12
    Sub Main()
        Dim lado, perimetro, diagonal, area As Double
        Dim raiz As Double = Math.Sqrt(2)
        'Entrada
        Console.WriteLine("Introduzca el lado")
        lado = Convert.ToDouble(Console.ReadLine())

        perimetro = 4 * lado
        diagonal = Math.Round(4 * Math.Sqrt(2), 2)
        'area = lado ^ 2
        area = Math.Pow(lado, 2)

        Console.WriteLine("Perimetro: " & perimetro)
        Console.WriteLine("Diagonal : " & diagonal)
        Console.WriteLine("Area : " & area)

        Console.ReadLine()
    End Sub
End Module
