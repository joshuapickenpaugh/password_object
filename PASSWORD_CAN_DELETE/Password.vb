Public Class Password

    Public Function GetPassword() As String

        'Prints questions (answer should be "2"):
        Return "What is 10/5?"

    End Function

    Public Function GetAnswer(ByVal strAnswr As String) As String

        'Declares local, procedure-level variable:
        Dim strRspns As String

        'Decision structure:
        If (strAnswr > 2) Then
            strRspns = "Your answer is too high!"
        ElseIf (strAnswr < 2) Then
            strRspns = "Your answer is too low!"
        Else
            strRspns = "Correct!"
        End If

        'Returns the answer:
        Return strRspns

    End Function

End Class
