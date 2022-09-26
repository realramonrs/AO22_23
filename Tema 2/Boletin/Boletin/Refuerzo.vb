Module Refuerzo
    Sub Main()
        'Programa que calcula la velocidad de un proyectil
        ' a partir del tiempo y la distancia recorrida
        'v = s/t
        Dim velocidad, tiempo, distancia As Double

        'Entrada : tiempo y la distancia
        Console.WriteLine("Indica el tiempo : ")
        tiempo = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Indica la distancia: ")
        distancia = Convert.ToDouble(Console.ReadLine())

        'Calculo
        velocidad = distancia / tiempo

        'Salida
        Console.WriteLine("Velocidad: " & velocidad & "m/s")
        Console.ReadLine()

    End Sub
End Module
