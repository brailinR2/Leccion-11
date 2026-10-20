Module Program
    Sub Main(args As String())
        Console.Write("Escribe el número del mes (1-12): ")
        Dim mes As Integer = Integer.Parse(Console.ReadLine())

        Select Case mes
            Case 1 To 6, 8 To 11
                Console.WriteLine("Clases")
            Case 7, 12
                Console.WriteLine("Vacaciones")
            Case Else
                Console.WriteLine("Mes no válido")
        End Select

        Console.ReadKey()
    End Sub
End Module
