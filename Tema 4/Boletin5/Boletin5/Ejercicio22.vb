Module Module3
    Sub mAIN()
        'EJERCICIO 22
        'apartado a

        For i = 7 To 1 Step -1
            Console.WriteLine("-----------------------")
            For B = 1 To i
                Console.WriteLine("*")
            Next
        Next
        Console.ReadLine()

        Console.WriteLine("-----------------------")

        'apartado b
        For i = 1 To 5
            Console.WriteLine("-----------------------")
            For B = 1 To i
                Console.WriteLine("*")
            Next
        Next
        Console.ReadLine()

        Console.WriteLine("-----------------------")

        'apartado c
        For i = 1 To 5
            Console.WriteLine("-----------------------")
            For B = 1 To i
                Console.WriteLine("*")
            Next
        Next
        For i = 4 To 1 Step -1
            Console.WriteLine("-----------------------")
            For B = 1 To i
                Console.WriteLine("*")
            Next
        Next
        Console.ReadLine()

        'Apartado d
        For i = 7 To 1 Step -1
            Console.WriteLine("-----------------------")
            For b = 1 To i
                Console.WriteLine(b)
            Next
        Next
        Console.ReadLine()
    End Sub
End Module
