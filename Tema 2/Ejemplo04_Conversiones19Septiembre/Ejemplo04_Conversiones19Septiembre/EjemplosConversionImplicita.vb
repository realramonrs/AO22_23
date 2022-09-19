Module EjemplosConversionImplicita

    Sub Main()
        'Conversiones implícitas son aquellas que se producen automáticamente
        'sin que el programador tenga que escribir ningún código a mayores
        'Suelen darse cuando asignamos a una variables de mayor tamaño,
        'el valor almacenado en una variable de menor tamaño
        Dim x1 As Byte = 90
        Dim x2 As Short = x1 'Esta operación siempre es segura
        'x1 = x2 'Esta operación no está permitida porque no es segura.

        Dim s1 As Single = 9.45
        Dim d1 As Double = s1

        'Dim d2 As Single = d1 'Esta operación no está permitida porque no es segura.


    End Sub
End Module
