Module alphabets


    Function HasAllAlphabets(inputString As String) As Boolean
        Dim uniqueCharacterCount = inputString.ToLower().Where(Function(character) Char.IsLetter(character)).Distinct().Count()
        Return uniqueCharacterCount = 26
    End Function

    Function ReplaceCharacter(inputString As String, oldChar As Char, newChar As Char) As String
        Return inputString.Replace(oldChar, newChar)
    End Function

    Function CharacterCounts(inputString As String, targetChar As Char) As (Integer, Integer, Integer, Integer)
        Dim targetCharCount = inputString.Count(Function(character) character = targetChar)
        Dim alphabetCharCount = inputString.Count(Function(character) Char.IsLetter(character))
        Dim digitCharCount = inputString.Count(Function(character) Char.IsDigit(character))
        Dim otherCharCount = inputString.Length - alphabetCharCount - digitCharCount
        Return (targetCharCount, alphabetCharCount, digitCharCount, otherCharCount)
    End Function

    Function MostCommonCharacter(inputString As String) As Char
        Dim charFrequency = New Dictionary(Of Char, Integer)()
        For Each character As Char In inputString
            If charFrequency.ContainsKey(character) Then
                charFrequency(character) += 1
            Else
                charFrequency.Add(character, 1)
            End If
        Next
        Return charFrequency.OrderByDescending(Function(entry) entry.Value).First().Key
    End Function

    Function CountVowels(inputString As String) As Integer
        Dim vowels = "aeiouAEIOU"
        Return inputString.Count(Function(character) vowels.Contains(character))
    End Function

    Function Donuts(count As Integer) As String
        If count < 10 Then
            Return $"Number of donuts: {count}"
        Else
            Return "Number of donuts: many"
        End If
    End Function

    Function BothEnds(s As String) As String
        If s.Length >= 2 Then
            Return s.Substring(0, 2) & s.Substring(s.Length - 2)
        Else
            Return s
        End If
    End Function

    Function ReplaceFirstCharacter(s As String) As String
        Dim firstChar As Char = s(0)
        Return firstChar & s.Substring(1).Replace(firstChar, "*")
    End Function

    Function MixUpStrings(a As String, b As String) As String
        Return $"{b.Substring(0, 2)}{a.Substring(2)} {a.Substring(0, 2)}{b.Substring(2)}"
    End Function

    Function ModifyString(s As String) As String
        If s.Length >= 3 Then
            If s.EndsWith("ing") Then
                Return $"{s}ly"
            Else
                Return $"{s}ing"
            End If
        Else
            Return s
        End If
    End Function

    Function ReplaceSubstring(s As String) As String
        Dim notIndex As Integer = s.IndexOf("not")
        Dim badIndex As Integer = s.IndexOf("bad")
        If notIndex <> -1 AndAlso badIndex <> -1 AndAlso notIndex < badIndex Then
            Return $"{s.Substring(0, notIndex)}good{s.Substring(badIndex + 3)}"
        Else
            Return s
        End If
    End Function

End Module
