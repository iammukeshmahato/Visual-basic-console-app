'Imports System
'
'Module Program
'    Sub Main()
'        Dim numList(10), greatest, n as Integer
'        n = 4
'        Console.WriteLine("Enter 10 numbers:")
'        For i = 0 to n-1
'            numList(i) = Console.ReadLine()
'        Next 
'        
''        greatest = numList(0)
'        For i = 0 to n-1
'            If numList(i) > greatest Then
'                greatest = numList(i)
'            End If
'        Next
'            
'        Console.WriteLine("Greatest = " & greatest)
'    End Sub
'End Module


Imports System

Module Program
    Sub Main()
        Dim numList(10), greatest as Integer
        Console.WriteLine("Enter 10 numbers:")
        For i = 0 to 9
            numList(i) = Console.ReadLine()
        Next 
        
'        greatest = numList(0)
        For i = 0 to 9
            If numList(i) > greatest Then
                greatest = numList(i)
            End If
        Next
            
        Console.WriteLine("Greatest = " & greatest)
    End Sub
End Module
