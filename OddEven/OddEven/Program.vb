Imports System

Module Program
    Sub Main()
        Dim n as Integer
        Console.Write("Enter first number: ")
        n = Console.ReadLine()
        If n Mod 2 = 0 Then
            Console.WriteLine(n & " is even")
        Else
            Console.WriteLine(n & " is odd")
        End If
'        Console.ReadKey()
    End Sub
End Module
