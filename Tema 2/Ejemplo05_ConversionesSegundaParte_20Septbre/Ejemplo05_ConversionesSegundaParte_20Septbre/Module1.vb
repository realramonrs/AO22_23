Option Strict On
Module Module1

    Sub Main()
        'Con option strict off , visual realiza conversiones de tipo sin avisar
        Dim numero As Integer = Convert.ToInt32(4.567)
        Console.WriteLine("Numero: " & numero)

        Dim x As Byte
        Dim y As Integer = 456


        x = Convert.ToByte(y)

        Console.WriteLine("X = " & x) 'OverflowException

        Dim n1 As Integer = 51
        Dim resultado As Integer = Convert.ToInt32(n1 / 7)

        Dim v As Byte = 245
        v = Convert.ToByte(v + 100) 'OverflowException


        Console.ReadLine()

    End Sub

End Module
