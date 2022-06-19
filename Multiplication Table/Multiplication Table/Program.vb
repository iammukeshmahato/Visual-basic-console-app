Imports System

Module Program
    Sub Main()
        Dim n as Integer
        Console.Write("Enter any number: ")
        n = Console.ReadLine()
        For i = 1 to 10
            Console.WriteLine(n & " x " & i & " = " & i*n)
        Next
'        Console.WriteLine("The sum of " &a & " and " &b & " = " &sum)
'        Console.WriteLine("The sum = " &sum)
        Console.ReadKey()
    End Sub
End Module
