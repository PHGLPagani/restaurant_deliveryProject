Public Class OrderScreen



    'Variables
    Dim drinkSize As String 'For concatenating txtDrinks





    'Previous/Next Buttons
    Private Sub btnPrevious1_Click(sender As Object, e As EventArgs) Handles btnPrevious1.Click

        InfoScreen.Show()
        Me.Hide()

    End Sub 'Hides Order Screen and opens Info Screen

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click

        My.Forms.ReceiptScreen.txtSubtotal2.Text = txtSubtotal.Text 'Sends the subtotal to Receipt Screen

        ReceiptScreen.Show()
        Me.Hide()

    End Sub 'Hides Order Screen and opens Receipt Screen - Also transfers data





    'Radio Buttons
    Private Sub rdoRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRegular.CheckedChanged

        If rdoRegular.Checked Then
            txtDough.Text = "Regular"
        End If 'If function

    End Sub 'rdoRegular

    Private Sub rdoCauliflower_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCauliflower.CheckedChanged

        If rdoCauliflower.Checked Then
            txtDough.Text = "Cauliflower"
        End If 'If function

    End Sub 'rdoCauliflower

    Private Sub rdoTomato_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTomato.CheckedChanged

        If rdoTomato.Checked Then
            txtSauce.Text = "Tomato"
        End If 'If funtion

    End Sub 'rdoTomato

    Private Sub rdoRanch_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRanch.CheckedChanged

        If rdoRanch.Checked Then
            txtSauce.Text = "Ranch"
        End If 'If funtion

    End Sub 'rdoRanch

    Private Sub rdoAlfredo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAlfredo.CheckedChanged

        If rdoAlfredo.Checked Then
            txtSauce.Text = "Alfredo"
        End If 'If funtion

    End Sub 'rdoAlfredo

    Private Sub rdoCheese_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheese.CheckedChanged

        If rdoCheese.Checked Then
            txtToppings.Text = "Cheese"
        End If 'If function

    End Sub 'rdoCheese

    Private Sub rdoPepperoni_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPepperoni.CheckedChanged

        If rdoPepperoni.Checked Then
            txtToppings.Text = "Pepperoni"
        End If 'If function

    End Sub 'rdoPepperoni

    Private Sub rdoBacon_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBacon.CheckedChanged

        If rdoBacon.Checked Then
            txtToppings.Text = "Bacon"
        End If 'If function

    End Sub 'rdoBacon

    Private Sub rdoChicken_CheckedChanged(sender As Object, e As EventArgs) Handles rdoChicken.CheckedChanged

        If rdoChicken.Checked Then
            txtToppings.Text = "Chicken"
        End If 'If function

    End Sub 'rdoChicken

    Private Sub rdoBroccoli_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBroccoli.CheckedChanged

        If rdoBroccoli.Checked Then
            txtToppings.Text = "Broccoli"
        End If 'If function

    End Sub 'rdoBroccoli

    Private Sub rdoHamburger_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHamburger.CheckedChanged

        If rdoHamburger.Checked Then
            txtToppings.Text = "Hamburger"
        End If 'If function

    End Sub 'rdoHamburger

    Private Sub rdoSmall_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSmall.CheckedChanged

        If rdoSmall.Checked Then
            drinkSize = "Small "
        End If 'If function

        txtDrink.Text = drinkSize

    End Sub 'rdoSmall

    Private Sub rdoLarge_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLarge.CheckedChanged

        If rdoLarge.Checked Then
            drinkSize = "Large "
        End If 'If Function

        txtDrink.Text = drinkSize

    End Sub 'rdolarge

    Private Sub rdoCoke_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCoke.CheckedChanged

        If rdoCoke.Checked Then
            txtDrink.Text = drinkSize & "Coke"
        End If 'If function


    End Sub 'rdoCoke

    Private Sub rdoSprite_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSprite.CheckedChanged

        If rdoSprite.Checked Then
            txtDrink.Text = drinkSize & "Sprite"
        End If 'If function


    End Sub 'rdoSprite

    Private Sub rdoFanta_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFanta.CheckedChanged

        If rdoFanta.Checked Then
            txtDrink.Text = drinkSize & "Fanta"
        End If 'If function


    End Sub 'rdoFanta

    Private Sub rdoGingerAle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGingerAle.CheckedChanged

        If rdoGingerAle.Checked Then
            txtDrink.Text = drinkSize & "Ginger Ale"
        End If 'If function


    End Sub 'rdoGingerAle

    Private Sub rdoOrangeJuice_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOrangeJuice.CheckedChanged

        If rdoOrangeJuice.Checked Then
            txtDrink.Text = drinkSize & "Orange Juice"
        End If 'If function


    End Sub 'rdoOrangeJuice

    Private Sub rdoAppleJuice_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAppleJuice.CheckedChanged

        If rdoAppleJuice.Checked Then
            txtDrink.Text = drinkSize & "Apple Juice"
        End If 'If function


    End Sub 'rdoAppleJuice




    'Subtotal
    Private Sub btnSubtotal_Click(sender As Object, e As EventArgs) Handles btnSubtotal.Click

        'Variables
        Dim totalDough As Double = 0 'For adding costs
        Dim totalSauce As Double = 0
        Dim totalToppings As Double = 0
        Dim totalDrinks As Double = 0

        If rdoCauliflower.Checked Then
            totalDough = totalDough + 12.5
        ElseIf rdoRegular.Checked Then
            totalDough = totalDough + 10.5
        End If 'If function - Cost Dough

        If rdoTomato.Checked Then
            totalSauce = totalSauce + 1
        ElseIf rdoRanch.Checked Then
            totalSauce = totalSauce + 1.5
        ElseIf rdoAlfredo.Checked Then
            totalSauce = totalSauce + 2
        End If 'If function - Cost Sauce

        If rdoCheese.Checked Then
            totalToppings = totalToppings + 1
        ElseIf rdoPepperoni.Checked Then
            totalToppings = totalToppings + 1.5
        ElseIf rdoBacon.Checked Then
            totalToppings = totalToppings + 2.5
        ElseIf rdoChicken.Checked Then
            totalToppings = totalToppings + 3
        ElseIf rdoBroccoli.Checked Then
            totalToppings = totalToppings + 2
        ElseIf rdoHamburger.Checked Then
            totalToppings = totalToppings + 3.5
        End If 'If function - Cost Toppings

        If rdoSmall.Checked Then
            totalDrinks = totalDrinks + 1.5
        ElseIf rdoLarge.Checked Then
            totalDrinks = totalDrinks + 2.5
        End If 'If function - Cost Drinks

        'Adding all costs
        txtSubtotal.Text = "$" & (totalDough + totalSauce + totalToppings + totalDrinks)

        'Enables "Next" button after subtotal is calculated
        If txtSubtotal.Text <> "" Then
            btnNext2.Enabled = True
        End If 'This step is important because if the user clicks "Next" before clicking "Click For Subtotal" the form crashes


    End Sub 'Calculate the subtotal


End Class