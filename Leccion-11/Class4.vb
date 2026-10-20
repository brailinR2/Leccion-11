Module Program
    Sub Main(args As String())
        Console.Write("Ingresa tu edad: ")
        Dim edad As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa las horas de taller completadas: ")
        Dim horas As Integer = Integer.Parse(Console.ReadLine())

        If edad >= 15 AndAlso horas >= 40 Then
            Console.WriteLine("Certificado")
        Else
            Console.WriteLine("No cumples los requisitos para el certificado")
        End If

        Console.ReadKey()
    End Sub
End Module
