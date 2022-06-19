Imports System

Module Program
    Function factorial(ByVal n as Integer) As Integer
        If n = 1 Then
            Return 1
        Else 
            Return n * factorial(n - 1)
        End If
    End Function
    
    Sub Main()
        Dim n as Integer
        Console.Write("Enter any number to find factorial: ")
        n = Console.ReadLine()
        Console.WriteLine("The factorial of " & n & " = " & factorial(n))
    End Sub
    
End Module
