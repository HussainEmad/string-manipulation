Module Module1

    Sub Main()

        Dim str1, str2, NextChar As String
        Dim count, NextNumber, DenNum As Integer

        str1 = ""
        str2 = ""
        NextChar = ""
        count = 0
        NextNumber = 0
        DenNum = 0

        Console.Write("Enter Binary Number: ")
        str1 = Console.ReadLine

            For count = 1 To Len(str1)
                str2 = Mid(str1, count, 1) & str2
            Next

            For count = 1 To Len(str2)
                NextChar = Mid(str2, count, 1)
            NextNumber = 0
                If NextChar = "1" Then
                NextNumber = 1
                End If

                If count = 1 Then
                DenNum = DenNum + NextNumber
                End If

                If count = 2 Then
                DenNum = DenNum + NextNumber * 2
                End If

                If count = 3 Then
                DenNum = DenNum + NextNumber * 4
                End If

                If count = 4 Then
                DenNum = DenNum + NextNumber * 8
                End If

                If count = 5 Then
                DenNum = DenNum + NextNumber * 16
                End If

                If count = 6 Then
                DenNum = DenNum + NextNumber * 32
                End If

                If count = 7 Then
                DenNum = DenNum + NextNumber * 64
                End If

                If count = 8 Then
                DenNum = DenNum + NextNumber * 128
                End If
            Next

        Console.WriteLine(str1 & " = " & DenNum)

        Console.ReadKey()
    End Sub

End Module
