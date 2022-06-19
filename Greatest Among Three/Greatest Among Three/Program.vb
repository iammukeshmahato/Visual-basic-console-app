Imports System

Module Program
    Sub Main()
        Dim a, b, c as Integer
        Console.Write("Enter first number: ")
        a = Console.ReadLine()
        Console.Write("Enter second number: ")
        b = Console.ReadLine()
        Console.Write("Enter third number: ")
        c = Console.ReadLine()

        If a > b And a > c Then 
            Console.WriteLine(a & " is greatest among " & a & ", " & b & " and " & c)
        ElseIf b > a And b > c Then
            Console.WriteLine(b & " is greatest among " & a & ", " & b & " and " & c)
        Else
            Console.WriteLine(c & " is greatest among " & a & ", " & b & " and " & c)
        End If
'        Console.ReadKey()
    End Sub
End Module
