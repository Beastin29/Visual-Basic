
    Dim tax, subTotal, total As Decimal

    Dim taxRate As Decimal = 0.08 '8.0% tax rate
    Dim priceHamburger As Decimal = 3.95
    Dim priceCheeseburger As Decimal = 4.49
    Dim priceChickenSandWich As Decimal = 1.49
    Dim priceSpicyChickenSandWich As Decimal = 2.49
    Dim priceBeanAndCheeseBurrito As Decimal = 1.99
    Dim priceCarneAsadaFries As Decimal = 5.49
    Dim priceFries As Decimal = 1.29
    Dim priceBacon As Decimal = 1.49
    Dim priceMashedPotatoes As Decimal = 2.49
    Dim priceBakedPotato As Decimal = 2.49
    Dim priceHashBrown As Decimal = 1.49
    Dim priceCocaCola As Decimal = 1.09
    Dim priceSprite As Decimal = 1.09
    Dim pricePhdPepper As Decimal = 1.09
    Dim priceSevenup As Decimal = 1.09
    Dim priceRaspberryTea As Decimal = 1.09

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        initializeVariables()
        clearTheCustomerSelections()
        clearReceipt()

    End Sub

    Private Sub initializeVariables() 'for each new customer

        subTotal = 0
        tax = 0
        total = 0

    End Sub

    Private Sub clearTheCustomerSelections() 'for each new customer


        btnHamburger.Checked = False
        btnCheeseburger.Checked = False
        btnChickenSandwich.Checked = False
        btnSpicyChickenSandwich.Checked = False
        btnBeanAndCheeseBurrito.Checked = False
        btnCarneAsadaFries.Checked = False
        btnBacon.Checked = False
        btnFries.Checked = False
        btnMashedPotatoes.Checked = False
        btnBakedPotato.Checked = False
        btnHashBrown.Checked = False
        btnCocaCola.Checked = False
        btnSprite.Checked = False
        btnPhdPepper.Checked = False
        btnSevenUp.Checked = False
        btnRaspberryTea.Checked = False




    End Sub

    Private Sub clearReceipt() 'for each new customer

        listBoxDisplay.Items.Clear() 'clear the customer checked
        listBoxTotal.Items.Clear()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        initializeVariables()
        clearTheCustomerSelections()
        clearReceipt()

    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click

        computeCurrentSelection()
        updateTotal()
        clearTheCustomerSelections()

    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click

        Me.Close()

    End Sub

    Private Sub computeCurrentSelection()

        'Hamburger Item was selected
        If btnHamburger.Checked Then
            subTotal += priceHamburger 'subtotal= subtotal + priceHamburger

            Dim hamburgerItem As String = priceHamburger.ToString("C") & " Hamburger"
            listBoxDisplay.Items.Add(hamburgerItem)

        End If

        'Cheeseburger Item was selected
        If btnCheeseburger.Checked Then
            subTotal += priceCheeseburger 'subtotal= subtotal + pricecheeseburger

            Dim cheeseburgerItem As String = priceCheeseburger.ToString("C") & " Cheeseburger"
            listBoxDisplay.Items.Add(cheeseburgerItem)
        End If

        'ChickenSandwich Item was selected
        If btnChickenSandwich.Checked Then
            subTotal += priceChickenSandWich 'subtotal= subtotal + priceHamburger

            Dim chickenSandwichItem As String = priceChickenSandWich.ToString("C") & " Chicken Sandwich"
            listBoxDisplay.Items.Add(chickenSandwichItem)
        End If

        'SpicyChickenSandwich Item was selected
        If btnSpicyChickenSandwich.Checked Then
            subTotal += priceSpicyChickenSandWich 'subtotal= subtotal + priceSpicyChichenSandwich

            Dim spicyChickenSandwichItem As String = priceChickenSandWich.ToString("C") & " Spicy ChickenSandwich"
            listBoxDisplay.Items.Add(spicyChickenSandwichItem)
        End If

        'beanAndCheeseBurrito Item was selected
        If btnBeanAndCheeseBurrito.Checked Then
            subTotal += priceBeanAndCheeseBurrito 'subtotal= subtotal + priceBeanAndCheeseBurrito

            Dim beanAndCheeseBurritoItem As String = priceBeanAndCheeseBurrito.ToString("C") & " Bean And Cheese Burrito"
            listBoxDisplay.Items.Add(beanAndCheeseBurritoItem)
        End If

        'CarneAsadaFries Item was selected
        If btnCarneAsadaFries.Checked Then
            subTotal += priceCarneAsadaFries 'subtotal= subtotal + priceCarneAsadaFries

            Dim carneAsadaFriesItem As String = priceCarneAsadaFries.ToString("C") & " Carne Asada Fries"
            listBoxDisplay.Items.Add(carneAsadaFriesItem)
        End If

        'Fries Item was selected
        If btnFries.Checked Then
            subTotal += priceFries 'subtotal= subtotal + priceFries

            Dim friesItem As String = priceFries.ToString("C") & " Fries"
            listBoxDisplay.Items.Add(friesItem)
        End If

        'Bacon Item was selected
        If btnBacon.Checked Then
            subTotal += priceBacon 'subtotal= subtotal + priceBacon

            Dim baconItem As String = priceBacon.ToString("C") & " Bacon"
            listBoxDisplay.Items.Add(baconItem)
        End If

        'MashedPotatoes Item was selected
        If btnMashedPotatoes.Checked Then
            subTotal += priceMashedPotatoes 'subtotal= subtotal + priceMashedPotatoes

            Dim mashedPotatoesItem As String = priceMashedPotatoes.ToString("C") & " Mashed Potatoes"
            listBoxDisplay.Items.Add(mashedPotatoesItem)
        End If

        'BakedPotato Item was selected
        If btnBakedPotato.Checked Then
            subTotal += priceBakedPotato 'subtotal= subtotal + priceBakedPotato

            Dim bakedPotatoItem As String = priceBakedPotato.ToString("C") & " Baked Potato"
            listBoxDisplay.Items.Add(bakedPotatoItem)
        End If

        'HashBrown Item was selected
        If btnHashBrown.Checked Then
            subTotal += priceHashBrown 'subtotal= subtotal + priceHashBrown

            Dim hashBrownItem As String = priceHashBrown.ToString("C") & " Hash Brown"
            listBoxDisplay.Items.Add(hashBrownItem)
        End If

        'CocaCola Item was selected
        If btnCocaCola.Checked Then
            subTotal += priceCocaCola 'subtotal= subtotal + priceCocaCola

            Dim cocaColaItem As String = priceCocaCola.ToString("C") & " Coca Cola"
            listBoxDisplay.Items.Add(cocaColaItem)
        End If

        'PhDPepper Item was selected
        If btnPhdPepper.Checked Then
            subTotal += pricePhdPepper 'subtotal= subtotal + pricePhDPepper

            Dim phDPepperItem As String = priceSprite.ToString("C") & " PhD Pepper"
            listBoxDisplay.Items.Add(phDPepperItem)
        End If

        'SevenUP Item was selected
        If btnSevenUp.Checked Then
            subTotal += priceSevenup 'subtotal= subtotal + priceSevenUP

            Dim sevenUPItem As String = priceSprite.ToString("C") & " 7UP"
            listBoxDisplay.Items.Add(sevenUPItem)
        End If

        'RaspberryTea Item was selected
        If btnRaspberryTea.Checked Then
            subTotal += priceRaspberryTea 'subtotal= subtotal + priceRaspberryTea

            Dim raspberryTeaItem As String = priceRaspberryTea.ToString("C") & " Raspberry Tea"
            listBoxDisplay.Items.Add(raspberryTeaItem)
        End If
    End Sub

    Private Sub updateTotal()

        'Clear the previous subtotal, tax, and total
        listBoxTotal.Items.Clear()

        'Compute and display the subtotal
        listBoxTotal.Items.Add("SUB TOTAL = " & subTotal.ToString("C"))

        'Compute and display the tax
        tax = subTotal * taxRate
        listBoxTotal.Items.Add("    TAX = " & tax.ToString("C"))

        'Compute and display the total 
        total = subTotal + tax
        listBoxTotal.Items.Add("    TOTAL = " & total.ToString("C"))

        'Separate each person's order on the next receipt
        listBoxDisplay.Items.Add("------------------------")

    End Sub
