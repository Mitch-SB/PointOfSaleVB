Imports System.Text

Public Class Register

    Const _tax As Decimal = 0.07

    Dim total As Decimal = 0.00
    Dim subTotal As Decimal = 0.00
    Dim qty As Integer = 1
    Dim coupon As Decimal = 0.00
    Dim taxTotal As Decimal = 0.00

    Public Shared _cashier As String
    Public Shared _cashNumber As Integer
    Public Shared _password As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize the ListView Control
        listViewGrocery.View = View.Details
        listViewGrocery.GridLines = True
        listViewGrocery.FullRowSelect = True

        'Add column header
        listViewGrocery.Columns.Add("Product Name", 100)
        listViewGrocery.Columns.Add("Price", 70)
        listViewGrocery.Columns.Add("Quantity", 70)
        listViewGrocery.Columns.Add("Sub Total", 70)
        listViewGrocery.Columns.Add("Tax", 45)
    End Sub

    Public Function TotalCount()
        total = 0

        'adds up the value on the 4th column index for each item inside the ListView
        For i = 0 To listViewGrocery.Items.Count Step 1
            If i < listViewGrocery.Items.Count Then
                total += listViewGrocery.Items(i).SubItems(3).Text
                Continue For
            End If

        Next
        TxtTotal.Text = "$" + total.ToString()
        Return total
    End Function

    Public Function TaxCount()
        taxTotal = 0

        'Multiplies the value on the 4th column index with my tax constant if the value for Tax on the 5th column equals "Y"
        For i = 0 To listViewGrocery.Items.Count Step 1
            If i < listViewGrocery.Items.Count Then
                If listViewGrocery.Items(i).SubItems(4).Text = "Y" Then
                    taxTotal += listViewGrocery.Items(i).SubItems(1).Text * listViewGrocery.Items(i).SubItems(2).Text * _tax
                End If
            End If
        Next
        Return taxTotal
    End Function

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 And TxtCashOut.Text <> "" Then
                TxtCashOut.Text += "0"
            End If
        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "0"
            End If

        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then
            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "1"
            End If
        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "1"
            End If

        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then
            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "2"
            End If
        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "2"
            End If
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "3"
            End If

        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "3"
            End If
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "4"
            End If

        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "4"
            End If
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "5"
            End If

        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "5"
            End If
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "6"
            End If

        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "6"
            End If
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "7"
            End If

        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "7"
            End If
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "8"
            End If

        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "8"
            End If
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If TxtCashOut.Visible = True Then

            If TxtCashOut.TextLength < 6 Then
                TxtCashOut.Text += "9"
            End If

        Else
            If txtInput.TextLength <= 11 Then
                txtInput.Text += "9"
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Clear the current text input
        txtInput.Clear()
        TxtCashOut.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As String = txtInput.Text
        Dim o As String = TxtCashOut.Text

        Dim result As String

        If TxtCashOut.Visible = True Then
            If o.Length > 0 Then
                result = o.Remove(o.Length - 1) 'delete the current text based on the length of the string minus one
                TxtCashOut.Text = result 'reasign the new value to the textbox
            End If
        Else
            'Delete the preceding text on the txtInput textbox
            If i.Length > 0 Then
                result = i.Remove(i.Length - 1) 'delete the current text based on the length of the string minus one
                txtInput.Text = result 'reasign the new value to the textbox
            End If
        End If
    End Sub

    Private Sub BtnQty_Click(sender As Object, e As EventArgs) Handles BtnQty.Click
        'Set quantity for items "scanned" | Cannot exceed 100 units
        If txtInput.TextLength < 3 And txtInput.TextLength > 0 Then
            qty = txtInput.Text
            lblQty.Text = "Qty: " & qty.ToString()
            lblQty.Visible = True
            txtInput.Clear()
        ElseIf txtInput.TextLength > 3 Then
            MessageBox.Show("Quatity Over Exceeded!")
            txtInput.Clear()
        Else
            MessageBox.Show("Invalid Quantity!")
            txtInput.Clear()
        End If
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        'Establish connection
        Dim db As DataAccess = New DataAccess()
        Dim strInput = txtInput.Text

        Dim grocery As Grocery = db.GetGrocery(txtInput.Text)

        If grocery.Name <> "" Then
            txtInput.Clear()
            lblQty.Visible = False
            label1.Text = "Total:"

            'Set up array for the ListView
            Dim arr(5) As String
            Dim itm As ListViewItem
            Dim result As Decimal
            Dim id18 As Boolean
            Dim id21 As Boolean
            Dim taxable As Boolean
            Dim price As Decimal
            Dim tax As Decimal

            'TRY Parse the boolean data for validation
            Boolean.TryParse(grocery.Identification18.ToString(), id18)
            Boolean.TryParse(grocery.Identification21.ToString(), id21)

            If id18 = True And id21 = True Then
                Dim dialogResult21 As DialogResult = MessageBox.Show("Is the customer 21 years or older?", "Please Ask For ID", MessageBoxButtons.YesNo)
                If dialogResult21 = DialogResult.Yes Then
                    'will resume as normal if the customer is 21 years or older
                Else
                    Return 'Ends execution
                End If
            End If

            If id18 = True And id21 = False Then
                Dim dialogResult18 As DialogResult = MessageBox.Show("Is the customer 18 years or older?", "Please Ask For ID", MessageBoxButtons.YesNo)
                If dialogResult18 = DialogResult.Yes Then
                    'will resume as normal if the customer is 21 years or older
                Else
                    Return 'Ends execution
                End If
            End If

            'assign the data to the appropriate fileds
            arr(0) = grocery.Name
            arr(1) = grocery.Price.ToString("#.##")
            arr(2) = qty.ToString()

            'TRY Parse the boolean data for validation
            Boolean.TryParse(grocery.Taxable.ToString(), taxable)

            'Parse Price into a decimal for calculations
            Decimal.TryParse(grocery.Price.ToString(), price)

            'if taxable, will calculate the price of the item, quantity, and the tax constant
            If taxable = True Then
                arr(4) = "Y"
                tax = (price * qty * _tax)
                Decimal.Round(tax, 2, MidpointRounding.AwayFromZero)
                result = ((price * qty) + tax)
            Else
                arr(4) = "N"
                result = price * qty
            End If

            arr(3) = result.ToString("#.##")

            'add items inside arr array into the ListView
            itm = New ListViewItem(arr)
            listViewGrocery.Items.Add(itm)
        Else
            MessageBox.Show("Invalid Input!")
            txtInput.Clear()
        End If
        qty = 1

        TotalCount()
        BtnBack_Click(sender, e)
    End Sub

    Private Sub BtnVoid_Click(sender As Object, e As EventArgs) Handles BtnVoid.Click
        'removes the selected items inside the list view
        For Each eachItem As ListViewItem In listViewGrocery.SelectedItems
            listViewGrocery.Items.Remove(eachItem)
        Next

        TotalCount()
        TxtTotal.Text = "$" + total.ToString()
        qty = 1

    End Sub

    Private Sub BtnTender_Click(sender As Object, e As EventArgs) Handles BtnTender.Click
        'Will only allow transaction to be tendered if there is a scanned item inside the ListView
        If listViewGrocery.Items.Count = 0 Then
            MessageBox.Show("Start A New Order To Tender")
        Else
            'Sets the Tender groupbox visibility to true and hides certain buttons to continue transaction
            BtnCash.Visible = True
            BtnEFT.Visible = True

            BtnCoupon.Visible = False
            BtnLock.Visible = False
            BtnVoid.Visible = False
            BtnRegOptions.Visible = False
            BtnTender.Visible = False

            groupBoxTenderTotal.Visible = True

            TotalCount()
            TaxCount()

            'Calculates the amount of savings/coupons in the transaction
            coupon = 0.00 'reset to zero for proper calculation

            For i = 0 To listViewGrocery.Items.Count Step 1
                If i < listViewGrocery.Items.Count Then
                    If listViewGrocery.Items(i).SubItems(0).Text = "Coupon" Then
                        coupon += listViewGrocery.Items(i).SubItems(3).Text
                    End If
                End If
            Next

            lblSavings.Text = "$" & coupon
            lblTax.Text = "$" + taxTotal.ToString("0.00")

            'Calculates the subtotal of the current transaction
            subTotal = 0.00 'reset to zero for proper calculation

            For i = 0 To listViewGrocery.Items.Count Step 1
                If i < listViewGrocery.Items.Count Then
                    If listViewGrocery.Items(i).SubItems(0).Text <> "Coupon" Then
                        subTotal += listViewGrocery.Items(i).SubItems(1).Text * listViewGrocery.Items(i).SubItems(2).Text
                    End If
                End If
            Next

            lblSubTotal.Text = "$" + subTotal.ToString("#.##")
            lblTotal.Text = TxtTotal.Text

        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        'enables and disables the visibility option of certain buttons based on what needs to be displayed
        'Prioritizing the default view
        'If BtnCash.Visible = True Then     ''''Remove current if statement and keep it simple?
        '    BtnCash.Visible = False
        '    BtnEFT.Visible = False
        '    BtnPay.Visible = False
        '    BtnLogOff.Visible = False

        '    BtnCoupon.Visible = True
        '    BtnLock.Visible = True
        '    BtnVoid.Visible = True
        '    BtnRegOptions.Visible = True
        '    BtnTender.Visible = True
        '    BtnLock.Enabled = True

        '    groupBoxTenderTotal.Visible = False
        'End If
        BtnCash.Visible = False
        BtnEFT.Visible = False
        BtnPay.Visible = False
        BtnLogOff.Visible = False
        BtnEnterCoupon.Visible = False
        TxtCashOut.Visible = False

        BtnCoupon.Visible = True
        BtnLock.Visible = True
        BtnVoid.Visible = True
        BtnRegOptions.Visible = True
        BtnTender.Visible = True
        BtnLock.Enabled = True

        groupBoxTenderTotal.Visible = False
    End Sub

    Private Sub BtnCoupon_Click(sender As Object, e As EventArgs) Handles BtnCoupon.Click
        'enables and disables the visibility option of certain buttons based on what needs to be displayed
        BtnCoupon.Visible = False
        BtnLock.Visible = False
        BtnVoid.Visible = False
        BtnRegOptions.Visible = False
        BtnTender.Visible = False

        BtnEnterCoupon.Visible = True
        TxtCashOut.Visible = True
    End Sub

    Private Sub BtnEnterCoupon_Click(sender As Object, e As EventArgs) Handles BtnEnterCoupon.Click
        'New array for coupon entry
        Dim arr(5) As String
        Dim itm As ListViewItem

        'New String Builder for coupon entry
        Dim couponBuilder As StringBuilder = New StringBuilder(TxtCashOut.Text)

        'capture text as string to use the contain method
        Dim couponStr As String = TxtCashOut.Text

        arr(0) = "Coupon"
        arr(1) = ""
        arr(2) = ""
        arr(4) = ""

        'allows insertion of a decimal point depending on how many characters are inside the string
        If couponStr.Contains(".") = False Then
            If TxtCashOut.TextLength < 3 Then
                If TxtCashOut.TextLength = 2 Then
                    couponBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.")
                    TxtCashOut.Text = couponBuilder.ToString()
                Else
                    couponBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.0")
                    TxtCashOut.Text = couponBuilder.ToString()
                End If
            Else
                couponBuilder.Insert((TxtCashOut.TextLength - 2), ".")
                TxtCashOut.Text = couponBuilder.ToString()
            End If
        Else
            If TxtCashOut.Text < 0 Then
                TxtCashOut.Text = ""
            Else
                arr(3) = "-" & TxtCashOut.Text

                itm = New ListViewItem(arr)
                listViewGrocery.Items.Add(itm)

                BtnClear_Click(sender, e)
                BtnBack_Click(sender, e)
                TotalCount()

            End If
        End If
    End Sub
End Class
