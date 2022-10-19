Option Strict On
Module Module1

    Sub Main()
        Dim opcion As Integer
        Console.WriteLine("Escoja el ejercicio: ")
        opcion = Convert.ToInt32(Console.ReadLine())

        Select Case opcion
            Case 5
                Dim nota As Double
                Console.WriteLine("introduce la nota: ")
                nota = Convert.ToDouble(Console.ReadLine())

                If nota < 0 Or nota > 10 Then
                    Console.WriteLine("Error en la nota")
                ElseIf nota < 5 Then
                    Console.WriteLine("Suspenso")
                ElseIf nota < 6.5 Then
                    Console.WriteLine("Aprobado")
                ElseIf nota < 8.5 Then
                    Console.WriteLine("Notable")
                Else
                    Console.WriteLine("Sobresaliente")
                End If

            Case 7
                Dim temperatura As Decimal
                Console.WriteLine("Intro temperatura")
                temperatura = Convert.ToDecimal(Console.ReadLine())

                If temperatura < 0 Then
                    Console.WriteLine("Sólido")

                ElseIf temperatura < 100 Then
                    Console.WriteLine("Líquido")


                ElseIf temperatura < 1000000 Then
                    Console.WriteLine("Vapor")

                Else
                    Console.WriteLine("Plasma")
                End If

            Case 8
                Dim menu, continuar As Char
                Dim num1, num2, resultado As Integer
                Dim division As Double
                Do
                    Console.WriteLine("a. Sumar 2 números")
                    Console.WriteLine("b. restar 2 números")
                    Console.WriteLine("c. multiplicar 2 números")
                    Console.WriteLine("d. dividir 2 números")
                    Console.WriteLine("e. Raiz Cuadrada suma 2 números")
                    menu = Convert.ToChar(Console.ReadLine())

                    Console.WriteLine("Intro numero 1")
                    num1 = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Intro numero 2")
                    num2 = Convert.ToInt32(Console.ReadLine())


                    Select Case menu
                        Case "a"c
                            resultado = num1 + num2
                            Console.WriteLine("Resultado : " & resultado)
                        Case "b"c
                            resultado = num1 - num2
                            Console.WriteLine("Resultado : " & resultado)
                        Case "c"c
                            resultado = num1 * num2
                            Console.WriteLine("Resultado : " & resultado)
                        Case "d"c
                            division = num1 / num2
                            Console.WriteLine("La división es : " & division)
                        Case "e"c

                            Dim raiz As Double = Math.Sqrt(Math.Abs(num1 + num2))
                            Console.WriteLine("Raiz es: " & raiz)

                    End Select
                    Console.WriteLine("Desea continuar: s/n")
                    continuar = Convert.ToChar(Console.ReadLine())
                    Console.Clear()
                Loop While continuar = "s"c Or continuar = "S"c

            Case 9
                Dim litros, pago As Double
                Console.WriteLine("Introduzca los litros: ")
                litros = Convert.ToDouble(Console.ReadLine())

                If litros < 50 Then
                    pago = 0

                ElseIf litros < 200 Then

                    pago = (litros - 50) * 10
                Else
                    pago = (litros - 200) * 20 + 1500
                End If

                If pago < 150 Then
                    pago = 150
                End If
                Console.WriteLine("Debe pagar : " & pago)

            Case 11
                Dim horas, hExtra, tasa, salarioBruto, salarioNeto As Double
                Console.WriteLine("Introduce las horas trabajadas: ")
                horas = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine("Introduce la tasa: ")
                tasa = Convert.ToDouble(Console.ReadLine())

                If horas > 38 Then
                    hExtra = horas - 38
                    salarioBruto = hExtra * 1.5 * tasa + 38 * tasa
                Else
                    salarioBruto = tasa * horas
                End If


                If salarioBruto < 300 Then
                    salarioNeto = salarioBruto
                Else
                    salarioNeto = salarioBruto - 0.1 * salarioBruto
                End If

                Console.WriteLine("Salario Bruto: " & salarioBruto)
                Console.WriteLine("Salario neto: " & salarioNeto)









        End Select
        Console.ReadLine()
    End Sub

End Module
