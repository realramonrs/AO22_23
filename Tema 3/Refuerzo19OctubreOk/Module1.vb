Module Module1

    Sub Main()
        'Programa que calcula el sueldo neto de un trabajador teniendo en cuenta que:
        'Las primeras 20 horas las cobra a una determinada tasa que se debe solicitar por teclado
        'Las 15 siguientes a un 50% más
        ' y el resto a un 75% más
        Dim horasTrabajadas, tasa, salarioBruto, salarioNeto As Double
        Console.WriteLine("Intro horas trabajadas : ")
        horasTrabajadas = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Tasa a la que paga las horas ordinarias: ")
        tasa = Convert.ToDouble(Console.ReadLine())

        If horasTrabajadas <= 20 Then
            salarioBruto = horasTrabajadas * tasa
        ElseIf horasTrabajadas <= 35 Then
            salarioBruto = 20 * tasa + (horasTrabajadas - 20) * tasa * 1.5
        Else
            salarioBruto = 20 * tasa + 15 * tasa * 1.5 + (horasTrabajadas - 35) * tasa * 1.75
        End If

        'Calcular el salario neto: 
        'Si el salario bruto es < 1000 euros --> el salario neto es = salario bruto - 10% del salario bruto
        'Si el salario bruto es < 1700 euros --> salario neto es = salario bruto - 17% del sal bruto
        'Si el salario bruto es < 2200 euros --> salario neto es = salario bruto - 23 %
        'Si es mayor --> salario neto = salario bruto - 35%


        If salarioBruto < 1000 Then
            salarioNeto = salarioBruto - 0.1 * salarioBruto
        ElseIf salarioBruto < 1700 Then
            salarioNeto = salarioBruto - 0.17 * salarioBruto
        ElseIf salarioBruto < 2200 Then
            salarioNeto = salarioBruto - 0.23 * salarioBruto
        Else
            salarioNeto = salarioBruto - 0.35 * salarioBruto
        End If

        Console.WriteLine("El salario bruto es : " & salarioBruto)
        Console.ReadLine()
    End Sub

End Module
