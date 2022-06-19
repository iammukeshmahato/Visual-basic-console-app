Imports System

Module Program
    sub printArray(ByVal arr() as Integer, ByVal size as Integer)
        For i = 0 to size - 1
            Console.Write(arr(i) & " ")
        Next
        Console.WriteLine()
    End sub
    
    sub sortArray(ByVal arr() as Integer, ByVal size as Integer)
        Dim temp as Integer
        For i = 0 to size-1
            For j = 0 to size - 1
                If arr(i) < arr(j) Then
                    temp = arr(i)
                    arr(i) = arr(j)
                    arr(j) = temp
                End If
            Next
        Next
    End sub
    
    Sub Main()
        Dim size, greatest as Integer
        Console.Write("Enter size of array: ")
        size = Console.ReadLine()
        
        Dim arr(size) as Integer
        
        For i = 0 to size-1
            arr(i) = Console.ReadLine()
        Next 
        
        Console.WriteLine("Array before sorting:")
        printArray(arr,size)
        
        sortArray(arr,size)
            
        Console.WriteLine("Array after sorting:")
        printArray(arr,size)
        
    End Sub
End Module
