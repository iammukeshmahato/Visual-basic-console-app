Module Module1

    Function sumOfNaturalNumber(ByVal n As Integer)
        Dim sum As Integer = 0
        For i = 1 To n
            sum += i
        Next
        Return sum
    End Function
    Sub Main()
        Dim input As Integer
        Console.Write("Enter any number: ")
        input = Console.ReadLine()
        Console.WriteLine("The sum of first " & input & " natural number is " & sumOfNaturalNumber(input))
        Console.ReadKey()
    End Sub

End Module
