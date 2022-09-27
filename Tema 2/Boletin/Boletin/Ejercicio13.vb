Module Ejercicio13
    Sub Main()
        Dim catetoA, catetoB, hipotenusa As Double
        Dim radicando As Double
        'Entrada :
        Console.WriteLine("Introduzca valor cateto A:")
        catetoA = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Introduzca valor cateto B: ")
        catetoB = Convert.ToDouble(Console.ReadLine())

        'Cálcula
        'radicando = catetoA ^ 2 + Math.Pow(catetoB, 2)
        'hipotenusa = Math.Sqrt(radicando)
        hipotenusa = Math.Sqrt(catetoA ^ 2 + Math.Pow(catetoB, 2))
        hipotenusa = Math.Round(hipotenusa, 2)
        Console.WriteLine("La hipotenusa es : " & hipotenusa)
        Console.ReadLine()


    End Sub
End Module
