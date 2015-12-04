   Dim score As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindYourScore.Click

        If textBoxAge.Text < 20 Then
            'If the user is less than 20 then put 1 point
            score = score + 1

        ElseIf textBoxAge.Text > 19 And textBoxAge.Text < 30 Then
            'If the user is greater than 20 but less than 30, they gain 2 points
            score = score + 2

        Else
            'If the user is greater than 30, they gain 3 points
            score = score + 3
        End If

        If radioButtonFatDietYes.Checked Then
            score = score + 1

        End If

        If radioButtonSmokerYes.Checked Then
            score = score + 4

        End If

        If radioButtonHighBloodPressureYes.Checked Then
            score = score + 2

        End If

        labelScore.Text = CStr(score)

    End Sub

    Private Sub initializeVariables() 'For each new customer

        score = 0

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        'Clear the customers score in the Reset label, reset score =0
        labelScore.Text = "Score"
        textBoxAge.Text = " "
        score = 0

        'clear radio buttons
        radioButtonFatDietYes.Checked = False
        radioButtonFatDietNo.Checked = False
        radioButtonSmokerYes.Checked = False
        radioButtonSmokerNo.Checked = False
        radioButtonHighBloodPressureYes.Checked = False
        radioButtonHighBloodPressureNo.Checked = False

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
