Module Ejercicio16
    Sub Main()
        Dim a, b, c, mayor, menor As Integer
        Dim resultado As Double
        Console.WriteLine("Intro n1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Intro n2: ")
        b = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Intro n3: ")
        c = Convert.ToInt32(Console.ReadLine())

        mayor = Math.Max(a, b)
        mayor = Math.Max(mayor, c)

        menor = Math.Min(a, Math.Min(b, c))

        'resultado = Math.Sqrt(mayor ^ menor) + Math.Pow(a, 5)
        resultado = Math.Sqrt(Math.Pow(Math.Max(a, Math.Max(b, c)), Math.Min(a, Math.Min(b, c)))) + a ^ 5




    End Sub
End Module
