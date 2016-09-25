'Joshua Pickenpaugh
' September 24th, 2016
' "Password"

Public Class frmMain

    'Instantiates the password object:
    Dim pswd As New Password

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares a procedure-level string variable:
        Dim strMyAnswer As String
        Dim strPrintResponse As String

        'Assigns to text box:
        strMyAnswer = txtTypePassword.Text

        'Compares user answer with object answer:
        strPrintResponse = pswd.GetAnswer(strMyAnswer)

        'Prints answer:
        lblShowAnswer.Text = strPrintResponse


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblShowRequest.Text = pswd.GetPassword

    End Sub
End Class
