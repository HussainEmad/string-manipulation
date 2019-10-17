Module Module1

    Sub Main()
        Dim BinaryCode As String
        Dim Counter As Integer
        Dim ValidBinaryString As Boolean

        BinaryCode = ""
        Counter = 0
        ValidBinaryString = True

        Console.WriteLine("Enter Binary number")
        BinaryCode = Console.ReadLine

        For Counter = 1 To Len(BinaryCode)
            If Len(BinaryCode) <> 8 Then

                ValidBinaryString = False

            Else
                If Mid(BinaryCode, Counter, 1) > 1 Or Mid(BinaryCode, Counter, 1) < 0 Then

                    ValidBinaryString = False

                End If


            End If
        Next

        Console.WriteLine("Not a valid Binary number... " & Not ValidBinaryString)
        Console.ReadLine()
    End Sub

End Module
