Module OpRelacionales
    Sub Main()
        'Relacionales --> Devuelven Boolean 
        ' < , > , <=, >= , = , <>
        Dim x As Integer = 9
        Dim y As Integer = 9

        Dim condicion1 As Boolean = x < y
        Dim condicion2 As Boolean = x >= y

        Dim condicion3 As Boolean = x = y

        Dim condicion4 As Boolean = condicion3 <> True

        'Leer un número si es 3 que la condicion sea true
        Dim numero As Integer
        Console.WriteLine("Intro valor: ")
        numero = Convert.ToInt32(Console.ReadLine())

        Dim condicion5 As Boolean = numero = 3



    End Sub
End Module
