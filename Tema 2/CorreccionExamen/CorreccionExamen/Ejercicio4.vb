Option Strict On
Module Ejercicio4

    Sub Main()
        Dim a, b As Integer
        Dim x, y, z, menor As Double
        Console.WriteLine("Intro a: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Intro b: ")
        b = Convert.ToInt32(Console.ReadLine())

        'Cálculos
        x = Math.Pow(a, 4) / a ^ 3
        y = Math.Sqrt(a + b * b)
        y = Math.Round(y, 1)
        z = Math.Round(Math.Sqrt(3 - a), 2)

        menor = Math.Min(x, Math.Min(y, z))
       // menor = Math.Min(menor, z)





    End Sub

End Module
