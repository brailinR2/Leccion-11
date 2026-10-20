Imports System

Module Program
    Sub Main(args As String())
        Dim voltaje As Double = 5.5
        Dim corriente As Double = 0.02

        If voltaje > 5 OrElse corriente > 0.03 Then
            Console.WriteLine("LED quemado")
        End If

        Console.ReadKey()
    End Sub
End Module