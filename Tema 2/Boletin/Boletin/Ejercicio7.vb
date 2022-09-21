Module Ejercicio7
    Sub Main()
        Dim gradosCelsius, gradosFahrenheit As Double

        'Entrada: gradosCelsius
        gradosCelsius = Convert.ToDouble(InputBox("Introduzca la temperatura en Celsius"))

        'Cálculo:
        gradosFahrenheit = (9 / 5) * gradosCelsius + 32

        'Salida:
        Console.WriteLine(gradosCelsius & " = " & gradosFahrenheit)
        Console.ReadLine()
    End Sub
End Module
