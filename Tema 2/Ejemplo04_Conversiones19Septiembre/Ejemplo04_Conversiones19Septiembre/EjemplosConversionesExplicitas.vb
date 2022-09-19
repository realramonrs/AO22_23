Module EjemplosConversionesExplicitas
    Sub Main()
        'Se producen cuando queremos asignar el valor de una variable en una variable
        'de menor capacidad o precisión

        Dim numero As Integer = 9
        Dim raiz As Integer = Convert.ToInt32(Math.Sqrt(numero))

        Dim b As Integer = 90
        Dim c As Byte = Convert.ToByte(b)





    End Sub
End Module
