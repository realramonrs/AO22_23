Option Strict On
Module Module1

    Sub Main()
        'Funciones de la librería Math
        'sqrt(numero)--> Raíz de ese número
        Dim n As Integer = 10
        Dim raiz As Double = Math.Sqrt(n)
        Console.WriteLine("La raiz de " & n & " es : " & raiz)

        'pow(base,potencia)--> base elevado a potencia
        Dim resultado As Integer = Convert.ToInt32(Math.Pow(5, 3))
        Dim raizCubica As Double = Math.Pow(150, 1 / 3)

        'Funciones de redondeo
        Dim valor As Double = 3.6141652
        Dim enteroMayor As Integer = Convert.ToInt32(Math.Ceiling(valor))
        Dim enteroMenor As Integer = Convert.ToInt32(Math.Floor(valor))
        Dim enteroCercano As Integer = Convert.ToInt32(Math.Round(valor))

        Console.WriteLine(valor & " redondeo hacia arriba : " & enteroMayor)
        Console.WriteLine(valor & " redondeo hacia abajo : " & enteroMenor)
        Console.WriteLine(valor & " redondeo más cercano : " & enteroCercano)

        'Ajustar a un número de decimales:
        Dim valorCon2Decimales As Double = Math.Round(valor, 2)
        Console.WriteLine(valor & " redondeo con 2 decimales: " & valorCon2Decimales)

        Console.ReadLine()
    End Sub

End Module
