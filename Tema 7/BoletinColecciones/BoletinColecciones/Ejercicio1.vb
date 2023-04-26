Option Strict On
Imports System

Module Ejercicio1
    Sub Main(args As String())

        Console.WriteLine("Introduce un ejercicio: ")
        Dim ejercicio As Integer = Convert.ToInt32(Console.ReadLine())

        Select Case ejercicio
            Case 1

                Dim lista As ArrayList = New ArrayList(10)

                'a.	Capacidad de la lista.
                Console.WriteLine("a. Capacidad de la lista: " & lista.Capacity)

                'b.Número de elementos almacenados realmente.
                Console.WriteLine("b. Número de elementos almacenados realmente: " & lista.Count)

                'Llenamos la lista con valores aleatorios

                Dim random As New Random()

                For index = 1 To lista.Capacity
                    lista.Add(random.Next(1, 51))
                Next

                'c.	Capacidad de la lista.
                Console.WriteLine("c. Capacidad de la lista: " & lista.Capacity)

                'd.Número de elementos almacenados realmente.
                Console.WriteLine("d. Número de elementos almacenados realmente: " & lista.Count)

                Console.WriteLine("Muestro la lista")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next

                'e.Obtener la posición de un determinado valor.
                Console.WriteLine()
                Console.WriteLine("Introduce un valor para buscar: ")
                Dim valorPosicion As Integer = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine("El valor " & valorPosicion & " está en la posición " & lista.IndexOf(valorPosicion))

                'f.Comprobar si está un determinado valor.
                Console.WriteLine("Introduce un valor para comprobar si está: ")
                Dim valorBusqueda As Integer = Convert.ToInt32(Console.ReadLine())

                If lista.Contains(valorBusqueda) Then
                    Console.WriteLine("El valor " & valorBusqueda & " está dentro del ArrayList")
                Else
                    Console.WriteLine("El valor " & valorBusqueda & " NO está dentro del ArrayList")
                End If

                'g.Eliminar un determinado valor.
                Console.WriteLine("Introduce un valor para borrarlo de la lista: ")
                Dim valorABorrar As Integer = Convert.ToInt32(Console.ReadLine())

                lista.Remove(valorABorrar)

                Console.WriteLine("Muestro la lista")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next

                'g2. Eliminar un valor en la posicion que le pasemos
                Console.WriteLine()
                Console.WriteLine("Introduce una posición en la que quieras borrar el valor: ")
                Dim posicionABorrar As Integer = Convert.ToInt32(Console.ReadLine())

                lista.RemoveAt(posicionABorrar)

                Console.WriteLine("Muestro la lista")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next

                'h.Realizar una copia en otra lista (FORMA 1)
                Dim lista2 As ArrayList = New ArrayList(lista)

                Console.WriteLine()
                Console.WriteLine("Muestro la lista 1")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next
                Console.WriteLine()
                Console.WriteLine("Muestro la lista 2")
                For Each numero In lista2
                    Console.Write(numero.ToString() & ",")
                Next

                'h.Realizar una copia en otra lista (FORMA 2)
                Dim lista3 As ArrayList = New ArrayList()

                For Each numero In lista
                    lista3.Add(numero)
                Next

                Console.WriteLine()
                Console.WriteLine("Muestro la lista 1")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next
                Console.WriteLine()
                Console.WriteLine("Muestro la lista 3")
                For Each numero In lista2
                    Console.Write(numero.ToString() & ",")
                Next

                'i.Ordenar la lista original.

                Console.WriteLine()
                Console.WriteLine("Muestro la lista sin ordenar")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next

                lista.Sort()

                Console.WriteLine()
                Console.WriteLine("Muestro la lista ordenada")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next

                'j. Eliminar todos los valores pasados por pantalla.
                Console.WriteLine("Introduce un valor para borrar todas sus ocurrencias de la lista: ")
                Dim valorABorrar2 As Integer = Convert.ToInt32(Console.ReadLine())

                While lista.Contains(valorABorrar2)
                    lista.Remove(valorABorrar2)
                End While

                Console.WriteLine("Muestro la lista")
                For Each numero In lista
                    Console.Write(numero.ToString() & ",")
                Next

            Case 2

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

                'e.Obtener la posición de un determinado valor.
                Console.WriteLine()
                Console.WriteLine("Introduce un valor para buscar: ")
                Dim valorPosicion As Double = Convert.ToDouble(Console.ReadLine())

                Console.WriteLine("El valor " & valorPosicion & " está en la posición " & lista.IndexOf(valorPosicion))

        End Select


        Console.ReadKey()
    End Sub
End Module
