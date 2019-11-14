Module Module1

    Sub Main()
        Dim Char1, lastcharcount, count As Integer
        Dim str1, nextchar, MostRepeatedChar, str2, fixstr As String

        Char1 = 0
        lastcharcount = 1
        count = 0
        str1 = ""
        nextchar = ""
        MostRepeatedChar = ""
        str2 = ""
        fixstr = ""

        Console.Write("enter a string: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar = " " Then
                nextchar = ""
            End If
            fixstr = fixstr & nextchar
        Next
        str1 = fixstr


        If str1 <> "" Then
            For count = 1 To Len(str1)
                str2 = str1
                nextchar = Mid(str1, count, 1)
                Do Until InStr(str2, nextchar) = 0
                    Char1 = Char1 + 1
                    str2 = Left(str2, InStr(str2, nextchar) - 1) & Right(str2, Len(str2) - InStr(str2, nextchar))
                Loop
                If Char1 > lastcharcount Then
                    MostRepeatedChar = nextchar
                End If
                lastcharcount = Char1
                Char1 = 0
            Next

            If MostRepeatedChar = "" Then
                Console.WriteLine("NO CHARACTERS HAVE BEEN REPEATED")
            End If
            If MostRepeatedChar <> "" Then
                Console.WriteLine("MOST OCCURED CHARACTER IS: " & MostRepeatedChar)
            End If
        Else
            Console.WriteLine("STRING NOT VALID")
        End If

        Console.ReadKey()
    End Sub

End Module
