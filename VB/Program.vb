Imports System

Module Program
    Sub Main(args As String())
        Dim variable1 = 10
        Dim variable2 = "Hello World"
        ' Integer Parameter
        Dim result1 As Integer = AddNumbers(variable1, 20)
        ' String Parameter
        Dim result2 As String = ConcatenateStrings(variable2, " from VB.NET")

    End Sub
    Private Function AddNumbers(number1 As Integer, number2 As Integer) As Integer
        Return number1 + number2
    End Function
    Private Function ConcatenateStrings(string1 As String, string2 As String) As String
        Return string1 & string2
    End Function
End Module




