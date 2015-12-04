
    'Inventory Pay Calculator
    'Programmer:    Daniel Beas
    'Date           Nov 9, 2015
    'Purpose:       This app will calculate the amount of money made from inventory items.

        Dim itemInHand As Integer
        Dim unitCost, totalCost, margin, sellingPrice, totalValue, totalProfit As Double
    Private Sub calculateInventoryCalculator()
        margin = (marginProfit.Value / 100)
        unitCost = unitCostValue.Value
        itemInHand = itemInHandValue.Value

        'Calculate the total cost 
        totalCost = itemInHand * unitCost
        labelTotalCost.Text = Format(totalCost, "Currency")

        'Calculate total value 
        totalValue = sellingPrice * itemInHand
        labelTotalValue.Text = Format(totalValue, "Currency")

        'Calculate sell price
        sellingPrice = unitCostValue.Value / (1 - margin)
        labelSellingPrice.Text = Format(sellingPrice, "Currency")

        'Calculate total Profit
        totalProfit = totalValue * totalCost
        labelTotalProfit.Text = Format(totalProfit, "Currency")



    End Sub

    Private Sub labelTotalCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelTotalCost.Click
        calculateInventoryCalculator()
    End Sub

    Private Sub labelSellingPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelSellingPrice.Click
        calculateInventoryCalculator()
    End Sub

    Private Sub labelTotalValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelTotalValue.Click
        calculateInventoryCalculator()
    End Sub

    Private Sub labelTotalProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelTotalProfit.Click
        calculateInventoryCalculator()
    End Sub

    Private Sub marginTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marginProfit.Scroll
        calculateInventoryCalculator()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        marginProfit.Value = 30
        margin = marginProfit.Value
        lblMarginValue.Text = (margin & "%")
    End Sub

    Private Sub lblMarginValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMarginValue.Click
        calculateInventoryCalculator()
        lblMarginValue.Text = (margin & "%")
    End Sub
