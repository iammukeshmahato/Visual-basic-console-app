Imports System

Module Program
    Sub Main()
        Dim n, a, b, c as Integer
        Console.Write("Enter number of terms of fibonacci series: ")
        n = Console.ReadLine()
        
        a = 0
        b = 1
        c = 0
        
        For i = 1 to n
            If(i < n) Then
            Console.Write(c & ", ")
            Else
                Console.Writeline(c)
            End If
            
            c = a + b
            b = a
            a = c
        Next
        
        Console.ReadKey()
    End Sub
End Module
