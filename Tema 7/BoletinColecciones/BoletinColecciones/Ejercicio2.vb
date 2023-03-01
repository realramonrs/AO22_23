Option Strict On
Imports System

Module Ejercicio2
    Sub Main(args As String())

        Dim lista As ArrayList = New ArrayList(10)

        'Llenamos la lista con valores aleatorios

        Dim random As New Random()

        For index = 1 To lista.Capacity
            lista.Add(random.NextDouble())
        Next

        Console.WriteLine()
        Console.WriteLine("Muestro la lista")
        For Each numero In lista
            Console.WriteLine(numero)
        Next

        'c.Capacidad de la lista.
        Console.WriteLine("La capacidad de la lista es: " & lista.Capacity)

        'd.Número de elementos almacenados realmente.
        Console.WriteLine("El numero de elementos en la lista es: " & lista.Count)

        'e.Obtener la posición de un determinado valor.

        Dim valoraobtener As Double
        Dim posicion As Integer
        Console.Write("Introduce un valor: ")
        valoraobtener = Convert.ToDouble(Console.ReadLine())

        posicion = lista.IndexOf(valoraobtener)

        Console.WriteLine("El valor está en la posición " & posicion)

        Console.ReadKey()
    End Sub
End Module
