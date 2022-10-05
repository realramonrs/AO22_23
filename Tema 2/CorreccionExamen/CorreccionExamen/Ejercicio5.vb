Module Ejercicio5
    Sub Main()
        Const IMPUESTOREVAL As Double = 3.4
        Dim precioVenta, importe, CI, antiguedad, precioCatastral As Double
        importe = 200000
        precioCatastral = 130000
        antiguedad = 45
        CI = 0.03 * importe

        precioVenta = importe + CI + (IMPUESTOREVAL * antiguedad / 100) * precioCatastral

    End Sub
End Module
