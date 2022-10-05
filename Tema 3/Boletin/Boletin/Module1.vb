Option Strict On
Module Module1

    Sub Main()

        Dim ejercicio As Integer
        Do

            Console.WriteLine("Escoje el ejercicio del boletín 3: 4 - 12")
            Console.WriteLine("Pulsa 1 si quieres salir del programa.")
            ejercicio = Convert.ToInt32(Console.ReadLine())
            If ejercicio <> 1 Then


                If ejercicio = 4 Then
                    'Resolver el ejercicio 4: Cálculo del menor de 4 variables
                    Dim a, b, c, d, menor As Integer
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Programa que calcula el menor de 4 números.")
                    Console.ForegroundColor = ConsoleColor.White

                    Console.WriteLine("Introduce un número")
                    a = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduce un número")
                    b = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduce un número")
                    c = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduce un número")
                    d = Convert.ToInt32(Console.ReadLine())

                    If a > b Then
                        menor = b
                    Else
                        menor = a
                    End If

                    If c < menor Then
                        menor = c
                    End If

                    If d < menor Then
                        menor = d
                    End If

                    Console.WriteLine("El menor es : " & menor)

                ElseIf ejercicio = 5 Then
                    'Variable local al ejercicio 5
                    Dim numero As Integer
                    Console.WriteLine("Introduce un número")
                    numero = Convert.ToInt32(Console.ReadLine())

                    If numero Mod 2 = 0 Then
                        Console.WriteLine("Par")
                    Else
                        Console.WriteLine("Impar")
                    End If

                ElseIf ejercicio = 6 Then
                    'Calcular la media de 3 valores:
                    Dim nota1, nota2, nota3, media As Single
                    Console.WriteLine("Intro nota 1:")
                    nota1 = Convert.ToSingle(Console.ReadLine())
                    Console.WriteLine("Intro nota 2:")
                    nota2 = Convert.ToSingle(Console.ReadLine())
                    Console.WriteLine("Intro nota 3:")
                    nota3 = Convert.ToSingle(Console.ReadLine())

                    media = (nota1 + nota2 + nota3) / 3

                    If media >= 5 Then
                        Console.WriteLine("Aprobado")
                    Else
                        Console.WriteLine("Suspenso")
                    End If

                ElseIf ejercicio = 7 Then
                Else

                End If
            End If

        Loop While ejercicio <> 1

        Console.ReadLine()
    End Sub

End Module
