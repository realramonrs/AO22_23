Module Module1
    Sub Main()
        'Zona declaración de variables
        Dim base, altura, areaTriangulo As Single

        'Entrada: Leer base,altura
        base = 9
        altura = 4

        'Proceso : area = (base*altura)/2
        areaTriangulo = (base * altura) / 2

        'Salida: Escribir ...
        Console.WriteLine("El area es " & areaTriangulo)

        'Mostrar consola hasta que el usuario pulse Enter
        Console.ReadLine()
    End Sub

End Module
