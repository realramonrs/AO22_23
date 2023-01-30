Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim registros(9) As String
        'Necesitamos ruta a la carpeta debug, que es donde vamos a guardar los ficheros:
        ' Dim ruta As String = Directory.GetCurrentDirectory() + "\productos.txt"
        Console.WriteLine(ruta)
        registros(0) = "45TR*HP Omen*1350"
        registros(1) = "34FG*Lenovo Yoga*1560"
        registros(2) = "56YU*Acer Compact*670"

        '1º Necesito un StreamWriter
        'Hay que indicarle la ruta al fichero y el modo de escritura
        'False--> Sobreescribe el fichero
        'True --> Anexa datos al fichero.
        Dim escritor As New StreamWriter(ruta, True)
        '2º Con la función writeLine escribimos registros en el fichero
        escritor.WriteLine(registros(0))
        escritor.WriteLine(registros(1))
        escritor.WriteLine(registros(2))
        'Cerrar la conexión al fichero
        escritor.Close()


        Console.ReadLine()
    End Sub

End Module
