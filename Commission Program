    Dim userSales As Integer
    Dim userCom As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        userSales = 0
        userCom = 0
        textBoxUserSales.Text = "Enter $ amount"
        labelOutput.Text = "User Commission Report"


    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If textBoxUserSales.Text > 40000 Then
            userSales = textBoxUserSales.Text
            userCom = userSales * 0.14
            labelOutput.Text = "Based on your sales of " & userSales & ", your commission is $" & userCom

        ElseIf textBoxUserSales.Text <= 40000 And textBoxUserSales.Text > 25000 Then
            userSales = textBoxUserSales.Text
            userCom = userSales * 0.09
            labelOutput.Text = "Based on your sales of " & userSales & ", your commission is $" & userCom

        ElseIf textBoxUserSales.Text <= 25000 And textBoxUserSales.Text > 10000 Then
            userSales = textBoxUserSales.Text
            userCom = userSales * 0.07
            labelOutput.Text = "Based on your sales of " & userSales & ", your commission is $" & userCom

        Else
            labelOutput.Text = "Based on your sales of " & userSales & ", your commission is $0.00 and you don't have a job anymore :P"
        End If

    End Sub
