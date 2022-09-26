Module RepasoMath
    Sub Main()
        Dim numero As Integer = 5

        Dim menor As Integer = Math.Min(numero, 4)
        Dim mayor As Integer = Math.Max(numero, 8)

        'Raiz cuadrada
        Dim raiz As Double = Math.Sqrt(13)
        'Calcular la raiz del valor más alto entre dos variables
        Dim x As Integer = 4
        Dim y As Integer = 9
        Dim z As Integer = 3
        Dim raiz2 As Double = Math.Sqrt(Math.Max(x, Math.Max(y, z)))

        'Calcular potencias
        Dim potencia As Integer = Convert.ToInt32(Math.Pow(x, 3))
        Dim potencia2 As Double = Math.Pow(x, 1 / 4)
        Dim potencia3 As Double = x ^ 3

        'Redondeo --> Math.floor(x) , --> Math.ceiling

    End Sub
End Module
