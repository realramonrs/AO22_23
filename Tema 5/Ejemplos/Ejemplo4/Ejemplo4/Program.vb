Imports System
Imports System.IO
Imports System.Runtime.Intrinsics

'Ejemplo 4:
'Crea 3 matrices y guarda la info de los alumnos
'Queremos guardar la siguiente informaci�n: Nombre, Edad, Videojuego favorito
'Elige el tipo de dato que necesites

'  Nombres: Anxo, Sergio, Mart�n, Hugo, Boris
'  Edades: 16, 17, 17, 16, 18
'  Videojuegos favs: Rust, Zelda: Ocarina of Time , ARK, Stray, Dragon Ball

'Ejemplo de lo que debe salir: Sergio, 17, Zelda: Ocarina of Time

Module Program
    Sub Main(args As String())

        'Una forma de crear y rellenar los arrays
        Dim nombres() As String = {"Anxo", "Sergio", "Mart�n", "Hugo", "Boris", "Alberto", "Don Ram�n"}
        Dim edades() As Integer = {16, 17, 17, 16, 18, 36, 29}
        Dim videojuegos() As String = {"Rust", "Zelda: Ocarina of Time", "ARK", "Stray", "Dragon Ball", "Asteroids", "Minecraft Education"}

        'Otra forma de crear y rellenar los arrays
        Dim deporteFav(nombres.Length - 1) As String
        deporteFav(0) = "F�tbol"
        deporteFav(1) = "P�del"
        deporteFav(2) = "Boxeo"
        deporteFav(3) = "Danza"
        deporteFav(4) = "F�tbol 7"
        deporteFav(5) = "Basket"
        deporteFav(6) = "SENDERISMO"

        'Mostramos la informaci�n
        For i = 0 To nombres.Length - 1
            Console.WriteLine(nombres(i) & ", " & edades(i) & ", " & videojuegos(i) & ", " & deporteFav(i))
        Next

        Console.ReadLine()
    End Sub
End Module
