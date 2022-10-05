Option Strict On
Module Module1

    Sub Main()
        'Leer dos variables de tipo Integer
        Dim a, b As Integer
        Dim x, y, z As Double
        Console.WriteLine("Introduce el valor de a: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Introduce el valor de b: ")
        b = Convert.ToInt32(Console.ReadLine())

        'x = a4/b3

        x = Math.Pow(a, 4) / Math.Pow(b, 3)
        'y = (b5*a3)/10
        y = (Math.Pow(b, 5) * Math.Pow(a, 3)) / 10
        'z = raiz(a2 + 30)
        z = Math.Sqrt(a * a + 30)




    End Sub

End Module
