Option Strict On
Module Ejercicio10

    Sub Main()
        Dim horas, tasa, irpf, salarioBruto, salarioNeto As Double

        'Entrada:
        Try
            Console.WriteLine("Introduzca las horas trabajadas: ")
            horas = Convert.ToDouble(Console.ReadLine())
        Catch e As FormatException
            Console.WriteLine("No se pudo guardar el valor.")
        End Try
        Console.WriteLine("Introduce la tasa a la que se paga la hora: ")
        tasa = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Intro IRPF:")
        irpf = Convert.ToDouble(Console.ReadLine())

        salarioBruto = horas * tasa
        salarioNeto = salarioBruto - (irpf * salarioBruto) / 100

        Console.WriteLine("Salario Bruto: " & salarioBruto & "€")
        Console.WriteLine("Salario Neto: " & salarioNeto & "€")

        Console.ReadLine()
    End Sub
End Module
