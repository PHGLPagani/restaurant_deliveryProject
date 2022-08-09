Public Class ReceiptScreen

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        InfoScreen.Show()
        MessageBox.Show("You may edit your order, if you wish!")
    End Sub 'Closing program

    Private Sub btnPO_Click(sender As Object, e As EventArgs) Handles btnPO.Click

        'Calculates total (this is here as well as ReceiptScreen_Load in case user goes back and makes edits to their order)
        Dim taxValue As Double = 0.0625 'Sets tax rate
        Dim subTotal As Integer = txtSubtotal2.Text

        txtTotal.Text = "$" & Math.Round((subTotal * (1 + taxValue)), 2)


        'Clearing the receipt first in case button is pressed more than once
        lstReceipt.Items.Clear()

        'Printing the receipt - line by line

        'Info Screen
        lstReceipt.Items.Add("Thank you, " & My.Forms.InfoScreen.txtName.Text & "!")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Here is your order summary:")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Customer Name: " & My.Forms.InfoScreen.txtName.Text)
        lstReceipt.Items.Add("Address: " & My.Forms.InfoScreen.txtAddress.Text & ", " & My.Forms.InfoScreen.txtCity.Text & ", " & My.Forms.InfoScreen.txtState.Text)
        lstReceipt.Items.Add("")
        'Order Screen
        lstReceipt.Items.Add("Pizza:")
        lstReceipt.Items.Add(My.Forms.OrderScreen.txtDough.Text & " Dough")
        lstReceipt.Items.Add(My.Forms.OrderScreen.txtSauce.Text & " Sauce")
        lstReceipt.Items.Add(My.Forms.OrderScreen.txtToppings.Text & " Topping")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Drink:")
        lstReceipt.Items.Add(My.Forms.OrderScreen.txtDrink.Text)
        lstReceipt.Items.Add("Your total is: " & txtTotal.Text)
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Special Instructions:")
        lstReceipt.Items.Add(My.Forms.OrderScreen.txtInfoAll.Text)

    End Sub 'Printing Receipt

    Private Sub btnPrevious2_Click(sender As Object, e As EventArgs) Handles btnPrevious2.Click

        Me.Hide()
        OrderScreen.Show()

    End Sub 'Hides Receipt Screen and opens Order Screen

    Private Sub ReceiptScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim taxValue As Double = 0.0625 'Sets tax rate
        Dim subTotal As Integer = txtSubtotal2.Text

        txtTotal.Text = "$" & Math.Round((subTotal * (1 + taxValue)), 2)

    End Sub 'Calculates total automatically


End Class