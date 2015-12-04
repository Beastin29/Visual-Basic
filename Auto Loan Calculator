    'Chapter 4      Auto Loan Calculator
    'Programmer:    Daniel Beas
    'Date           December 2, 2015
    'Purpose:       Calculates the monthly payment for a loan based on the loan amount.

    Dim globalMonths As Double = 60.0
    Const maxLoanAmountAllowed As Decimal = 25000
    Const maxCreditAllowed As Double = 5000

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nudLoanAmount.Maximum = maxLoanAmountAllowed
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        nudLoanAmount.Value = 0.0
        nudRate.Value = 5.0
        fiveYears.Checked = True
        monthlyPayment.Text = "$0.00"
    End Sub

    Private Sub threeYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles threeYears.CheckedChanged
        globalMonths = 36
    End Sub

    Private Sub fiveYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fiveYears.CheckedChanged
        globalMonths = 60
    End Sub

    Private Sub sevenYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sevenYears.CheckedChanged
        globalMonths = 84
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim dblRate, dblMonths, dblPayment As Double
        Dim dblLoanAmount As Double, strPayment As String
        Dim dblAdjustRate As Double, strFrontMessage As String

        dblLoanAmount = Convert.ToDouble(nudLoanAmount.Value)

        dblRate = (Convert.ToDouble(nudRate.Value) / 100) / 12

        If cmbCreditRating.Text = "" Then
            MessageBox.Show("Please enter the customer's credit rating in the credit rating box", "No Credit Rating")
            cmbCreditRating.Focus()
        End If

        dblPayment = Pmt(dblAdjustRate, globalMonths, -dblLoanAmount)
        strPayment = Format$(dblPayment, "Currency")
        monthlyPayment.Text = strPayment

        Select Case cmbCreditRating.SelectedIndex
            Case 0 'Credit Rating of A
                dblAdjustRate = dblRate
            Case 1 'Credit Rating of B
                dblAdjustRate = dblRate * 1.1
            Case 2 'Credit Rating of C
                dblAdjustRate = dblRate * 1.15
            Case 3 'Credit Rating of D
                dblAdjustRate = dblRate * 1.17
            Case 4 'Credit Rating of E
                dblAdjustRate = dblRate * 1.25
        End Select

    End Sub
