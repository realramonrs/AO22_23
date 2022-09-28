Module Module1

    Sub Main()
        'Siempre es posible asignar el valor de una variable de menor tamaño a
        'una variable de mayor tamaño
        'byte(8 bits)--> short(16bits) --> Integer(32bits) -->Long(64bits)
        Dim b As Byte = 200
        Dim s As Short = b

        'Las asignaciones de variables de mayor tamaño a variables de menor tamaño,
        'no son siempre posibles, y por defecto no nos dejan hacerlo directamente
        Dim s2 As Short = 400
        Dim b2 As Byte = Convert.ToByte(s2)




    End Sub

End Module
