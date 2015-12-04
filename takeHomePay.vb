 'Take Home Pay Calculator
    'Programmer:    Daniel Beas
    'Date           Nov 5, 2015
    'Purpose:       This app will calculator a worker's take-home pay.

    Private Sub calculateTakeHomePay()

        Dim dblSocial, dblFed, dblState, dblMedicare, dblWeeklyPay As Double
        Dim dblRetirement, dblInsurance, dblTakeHomePay As Double

        'Calculate gross paycheck amount
        dblWeeklyPay = Convert.ToDouble(salaryList.Value) / 52.0

        'Calculate individual deductions from gross paycheck amount
        dblSocial = dblWeeklyPay * 0.062
        dblFed = dblWeeklyPay * 0.018
        dblState = dblWeeklyPay * 0.025
        dblMedicare = dblWeeklyPay * 0.045

        'Calculate retirement contribution from user input
        dblRetirement = dblWeeklyPay * (TrackBoxValue.Value / 100)

        'Calculate insurance cost based on user input
        If radioButtonNone.Checked = True Then
            dblInsurance = 0
        ElseIf radioButtonIndividual.Checked = True Then
            dblInsurance = 20.0
        Else
            dblInsurance = 30.0

        End If

        'Subtract all deductions from the gross paycheck amount and display the results
        dblTakeHomePay = dblWeeklyPay - dblSocial - dblFed - dblState - dblMedicare - dblRetirement - dblInsurance

        labelTakeHomePay.Text = Format(dblTakeHomePay, "Currency")

    End Sub

    Private Sub salaryList_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salaryList.ValueChanged
        calculateTakeHomePay()
    End Sub

    Private Sub TrackBoxValue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBoxValue.Scroll
        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonIndividual.CheckedChanged
        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonNone.CheckedChanged
        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonFamily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonFamily.CheckedChanged
        calculateTakeHomePay()
    End Sub

    Private Sub labelTakeHomePay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelTakeHomePay.Click
        calculateTakeHomePay()
    End Sub
