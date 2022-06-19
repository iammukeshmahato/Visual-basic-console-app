Imports System

Module Program
    sub swap(ByRef a as Integer, ByRef b as Integer)
        Dim temp as Integer
        temp = a
        a = b
        b = temp
    End sub
    Sub Main()
        Dim a, b as Integer
        Console.Write("Enter first number: ")
        a = Console.ReadLine()
        Console.Write("Enter second number: ")
        b = Console.ReadLine()
        Console.WriteLine("Before swapping:")
        Console.WriteLine("a = "&a & " b = " & b)
        swap(a,b)
        Console.WriteLine("After swapping:")
        Console.WriteLine("a = " &a & " b = " & b)
    End Sub
End Module
