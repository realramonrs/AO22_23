
Option Strict On
Module Module1

    Sub Main()
        'Select Case --> Evaluar valores discretos de una variables
        Dim opcion As Char
        Dim contador As Byte
        Do
            'Ejemplo menú:
            Console.WriteLine("Escoja una opción: ")
            Console.WriteLine("a. Calcular la raíz de un número")
            Console.WriteLine("b. Obtener el menor de tres números")
            Console.WriteLine("c. Decir si un número es múltiplo de 7")
            Console.WriteLine("d. Salir")
            opcion = Convert.ToChar(Console.ReadLine())

            'Evaluar la variable opción

            'If opcion = "a"c Then

            'ElseIf opcion = "b"c Then
            'ElseIf opcion = "c"c Then
            'Else

            'End If

            Select Case opcion
                Case "a"c, "A"c
                    Console.WriteLine("Opción a: ")

                Case "b"c, "B"c
                    Console.WriteLine("Opción b")
                Case "c"c, "C"c
                    Console.WriteLine("Opción c")
                    Dim numero As Integer
                    Console.WriteLine("Intro número: ")
                    numero = Convert.ToInt32(Console.ReadLine())

                    If numero Mod 7 = 0 Then
                        Console.WriteLine("Múltiplo de 7")
                    End If

                Case "d"c
                    Console.WriteLine("Adios. Pulse Enter para confirmar.")

                Case Else
                    Select Case contador
                        Case 0
                            Console.WriteLine("Error en la opción, te quedan 2 intentos.")

                        Case 1
                            Console.WriteLine("Error en la opción, te queda 1 intentos.")
                        Case 2
                            Console.WriteLine("Error en la opción, Se acabó.")
                    End Select
                    contador += Convert.ToByte(1)
            End Select



                    Console.ReadLine()
        Loop While opcion <> "d"c And contador < 3

    End Sub

End Module
