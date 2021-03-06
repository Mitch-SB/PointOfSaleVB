﻿Imports System.Text

Public Class Register

    Const _tax As Decimal = 0.07

    Dim total As Decimal = 0.00
    Dim subTotal As Decimal = 0.00
    Dim qty As Integer = 1
    Dim coupon As Decimal = 0.00
    Dim cash As Decimal = 0.00
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

        LblLockCashier.Text = _cashier.ToString()
        CheckBoxLock.Checked = False
    End Sub

    Public Sub TotalCount()
        total = 0

        'adds up the value on the 4th column index for each item inside the ListView
        For i = 0 To listViewGrocery.Items.Count Step 1
            If i < listViewGrocery.Items.Count Then
                total += listViewGrocery.Items(i).SubItems(3).Text
                Continue For
            End If

        Next
        TxtTotal.Text = "$" + total.ToString()

    End Sub

    Public Sub TaxCount()
        taxTotal = 0

        'Multiplies the value on the 4th column index with my tax constant if the value for Tax on the 5th column equals "Y"
        For i = 0 To listViewGrocery.Items.Count Step 1
            If i < listViewGrocery.Items.Count Then
                If listViewGrocery.Items(i).SubItems(4).Text = "Y" Then
                    taxTotal += listViewGrocery.Items(i).SubItems(1).Text * listViewGrocery.Items(i).SubItems(2).Text * _tax
                End If
            End If
        Next
    End Sub

    Public Sub ResetForm()
        qty = 1
        total = 0
        subTotal = 0

        taxTotal = 0
        coupon = 0

        label1.Text = "Start New Order"
        TxtTotal.Clear()

        rtxtReceipt.Clear()
        rtxtReceipt.Visible = False

        'Empties out the ListView control
        For Each eachItem As ListViewItem In listViewGrocery.Items
            listViewGrocery.Items.Remove(eachItem)
        Next


    End Sub

    Public Sub SaveReceipt()
        'Checks to see if my richTextBox control has value
        'If it does, it saves it to a specified path
        If rtxtReceipt.Text <> String.Empty Then
            'Set directory
            Dim dir As String = "C:\Users\Jack of Dunces\Source\Repos\Mitch-SB\RegisterVB\ReceiptHistory\" & DateTime.Today.ToString("dd_MMM_yy") 'add unique time format

            Dim path As String = "C:\Users\Jack of Dunces\Source\Repos\Mitch-SB\RegisterVB\ReceiptHistory\" & DateTime.Today.ToString("dd_MMM_yy") & "\\" & DateTime.Now.ToString("HH.mm.ss") & ".rtxt"

            If Not IO.Directory.Exists(dir) Then
                IO.Directory.CreateDirectory(dir) 'creates path if it does not exist
            End If

            If Not IO.File.Exists(path) Then
                Using IO.File.Create(path)

                End Using
                rtxtReceipt.SaveFile(path, RichTextBoxStreamType.RichText) 'saves richtextbox to file path
            End If
        Else
            MessageBox.Show("ERROR - Failed To Save Receipt!")
        End If

    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "0"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 And TxtCashOut.Text <> "" Then
                    TxtCashOut.Text += "0"
                End If
            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "0"
                End If

            End If
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "1"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "1"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "1"
                End If
            End If
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "2"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "2"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "2"
                End If
            End If
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "3"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "3"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "3"
                End If
            End If
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "4"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "4"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "4"
                End If
            End If
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "5"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "5"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "5"
                End If
            End If
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "6"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "6"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "6"
                End If
            End If
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "7"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "7"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "7"
                End If
            End If
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "8"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "8"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "8"
                End If
            End If
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        'Insert button value to the txtInput string
        'Prioritize current visible text box
        If groupBoxUnlock.Visible = True Then
            If TxtUnlock.TextLength < 4 Then
                TxtUnlock.Text += "9"
            End If
        Else
            If TxtCashOut.Visible = True Then

                If TxtCashOut.TextLength < 6 Then
                    TxtCashOut.Text += "9"
                End If

            Else
                If txtInput.TextLength <= 11 Then
                    txtInput.Text += "9"
                End If
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Clear the current text input
        txtInput.Clear()
        TxtCashOut.Clear()
        TxtUnlock.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As String = txtInput.Text
        Dim o As String = TxtCashOut.Text
        Dim u As String = TxtUnlock.Text

        Dim result As String

        If groupBoxUnlock.Visible = True Then
            If u.Length > 0 Then
                result = u.Remove(u.Length - 1) 'delete the current text based on the length of the string minus one
                TxtUnlock.Text = result 'reasign the new value to the textbox
            End If
        Else
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
        'Unlock register
        If groupBoxUnlock.Visible = True Then
            If LblUnlock.Text = "Unlock" Then
                If TxtUnlock.Text = _password.ToString() Then
                    groupBoxLock.Visible = False
                    groupBoxUnlock.Visible = False

                    BtnCoupon.Enabled = True
                    BtnVoid.Enabled = True
                    BtnTender.Enabled = True
                    BtnQty.Enabled = True
                    BtnBack.Enabled = True
                    BtnRegOptions.Enabled = True
                    groupBoxPad.Enabled = True

                    CheckBoxLock.Checked = False
                    BtnLock.Text = "Lock"
                    BtnClear_Click(sender, e)
                    Return
                Else
                    MessageBox.Show("Incorrect Password!")
                    BtnClear_Click(sender, e)
                    Return
                End If
            ElseIf LblUnlock.Text = "Log Off" Then
                If TxtUnlock.Text = _password.ToString() Then
                    'Hide register
                    Hide()

                    'launch LogIn form
                    Dim logIn As LogIn = New LogIn
                    logIn.Show()
                    Return
                Else
                    MessageBox.Show("Incorrect Password!")
                    BtnClear_Click(sender, e)
                    Return
                End If
            End If

        End If

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

            'Calculates the amount of cash in the transaction
            cash = 0.00 'reset to zero for proper calculation

            For i = 0 To listViewGrocery.Items.Count Step 1
                If i < listViewGrocery.Items.Count Then
                    If listViewGrocery.Items(i).SubItems(0).Text = "Cash" Then
                        cash += listViewGrocery.Items(i).SubItems(3).Text
                    End If
                End If
            Next

            lblSavings.Text = "$" & coupon
            LblCash.Text = "$" & cash
            lblTax.Text = "$" + taxTotal.ToString("0.00")

            'Calculates the subtotal of the current transaction
            subTotal = 0.00 'reset to zero for proper calculation

            For i = 0 To listViewGrocery.Items.Count Step 1
                If i < listViewGrocery.Items.Count Then
                    If listViewGrocery.Items(i).SubItems(0).Text <> "Coupon" And listViewGrocery.Items(i).SubItems(0).Text <> "Cash" Then
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
        If LblUnlock.Text = "Log Off" Then
            groupBoxUnlock.Visible = False
        End If
        If CheckBoxLock.Checked = True Then
            groupBoxLock.Visible = True
            BtnBack.Enabled = False
        End If

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

        TxtCashOut.Clear()
        txtInput.Clear()
        TxtUnlock.Clear()

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

    Private Sub BtnLock_Click(sender As Object, e As EventArgs) Handles BtnLock.Click
        'Lock current instance
        If BtnLock.Text = "Lock" Then
            'check lock checkbox to know if the form is locked
            CheckBoxLock.Checked = True

            groupBoxLock.Visible = True
            groupBoxUnlock.Visible = False

            BtnCoupon.Enabled = False
            BtnVoid.Enabled = False
            BtnTender.Enabled = False
            BtnQty.Enabled = False
            BtnBack.Enabled = False
            groupBoxPad.Enabled = False
            BtnRegOptions.Enabled = True

            LblLockCashier.Text = _cashier.ToString()
            BtnLock.Text = "Unlock"
            BtnBack_Click(sender, e)
        ElseIf BtnLock.Text = "Unlock" Then
            BtnLock.Text = "Lock"
            LblUnlock.Text = "Unlock"
            groupBoxUnlock.Visible = True
            groupBoxLock.Visible = False

            BtnBack.Enabled = False
            BtnRegOptions.Enabled = False
            groupBoxPad.Enabled = True
        End If
    End Sub

    Private Sub BtnRegOptions_Click(sender As Object, e As EventArgs) Handles BtnRegOptions.Click
        BtnTender.Visible = False
        BtnCoupon.Visible = False
        BtnVoid.Visible = False
        BtnLogOff.Visible = True
        BtnBack.Enabled = True
        BtnLock.Enabled = False
    End Sub

    Private Sub BtnLogOff_Click(sender As Object, e As EventArgs) Handles BtnLogOff.Click
        If listViewGrocery.Items.Count < 1 Then
            groupBoxUnlock.Visible = True
            groupBoxLock.Visible = False

            LblUnlock.Text = "Log Off"
        Else
            MessageBox.Show("Transaction in Progress!" & Environment.NewLine & "Unable to Log Out!")
            BtnBack_Click(sender, e)
        End If
    End Sub

    Private Sub BtnCash_Click(sender As Object, e As EventArgs) Handles BtnCash.Click
        'enables and disables the visibility option of certain buttons based on what needs to be displayed
        BtnCoupon.Visible = False
        BtnLock.Visible = False
        BtnVoid.Visible = False
        BtnRegOptions.Visible = False
        BtnTender.Visible = False
        BtnCash.Visible = False
        BtnEFT.Visible = False

        BtnPay.Visible = True
        TxtCashOut.Visible = True
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        'New array for cash entry
        Dim arr(5) As String
        Dim itm As ListViewItem

        'New String Builder for cash entry
        Dim cashBuilder As StringBuilder = New StringBuilder(TxtCashOut.Text)

        'String builder for my rich text box
        Dim rtfTable As StringBuilder = New StringBuilder()

        'Header for my receipt
        Dim header As String = "Mitch's Grocery & Mercantile Supply" & Environment.NewLine & "1234 Best Damn Groceries Rd" &
            Environment.NewLine & "Vieques, PR 00765" & Environment.NewLine & "407-555-5555" &
            Environment.NewLine & Environment.NewLine
        'Footer for my receipt
        Dim footer As String = Environment.NewLine & "Thank You Very Much For Shopping With Us" & Environment.NewLine &
                    "Your Cashier was: " & _cashier & Environment.NewLine &
                    "We Hope To See You Again!" & Environment.NewLine & Environment.NewLine & "Mitch's Grocery & Mercantile Supply"
        'Tender time for my receipt
        Dim tenderTime As String = Environment.NewLine & DateTime.Now() + Environment.NewLine

        'capture text as string to use the 'contain' method
        Dim cashStr As String = TxtCashOut.Text

        arr(0) = "Cash"
        arr(1) = ""
        arr(2) = ""
        arr(4) = ""

        'allows insertion of a decimal point depending on how many characters are inside the string
        If cashStr.Contains(".") = False Then
            If TxtCashOut.TextLength < 3 Then
                If TxtCashOut.TextLength = 2 Then
                    cashBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.")
                    TxtCashOut.Text = cashBuilder.ToString()
                Else
                    cashBuilder.Insert((TxtCashOut.TextLength - TxtCashOut.TextLength), "0.0")
                    TxtCashOut.Text = cashBuilder.ToString()
                End If
            Else
                cashBuilder.Insert((TxtCashOut.TextLength - 2), ".")
                TxtCashOut.Text = cashBuilder.ToString()
            End If
        Else
            'array set up to input a cash entry into the ListView if the amount entered is less than the total amount
            If TxtCashOut.Text < total Then
                If TxtCashOut.Text <= 0 Then
                    TxtCashOut.Text = ""
                Else
                    arr(3) = "-" & TxtCashOut.Text

                    itm = New ListViewItem(arr)
                    listViewGrocery.Items.Add(itm)

                    BtnClear_Click(sender, e)
                    BtnBack_Click(sender, e)
                    TotalCount()

                End If
            Else
                'Runs if the amount entered is greater than the total
                'Renders everything back into the default view And reveals the richtextbox receipt
                If TxtCashOut.Text > total Then
                    rtxtReceipt.Visible = True

                    'Custom font style and text alignment
                    rtxtReceipt.SelectionFont = New Font(rtxtReceipt.Font, FontStyle.Bold)
                    rtxtReceipt.SelectionAlignment = HorizontalAlignment.Center

                    'Grabs selection and applies it
                    '******************************** Maybe concatenate with mess of string builder**************
                    rtxtReceipt.SelectedText = header

                    'Appends each item inside the ListView into my table string builder
                    rtfTable.Append("{\rtf1 ")
                    For i = 0 To listViewGrocery.Items.Count Step 1
                        If i < listViewGrocery.Items.Count Then
                            rtfTable.Append("\trowd")
                            rtfTable.Append("\cellx1500" & listViewGrocery.Items(i).SubItems(0).Text)
                            rtfTable.Append("\intbl\cell")
                            rtfTable.Append("\cellx3000" & "")
                            rtfTable.Append("\intbl\cell")
                            rtfTable.Append("\cellx4500" & "x" & listViewGrocery.Items(i).SubItems(2).Text)
                            rtfTable.Append("\intbl\cell")
                            rtfTable.Append("\cellx6000" & "$" & listViewGrocery.Items(i).SubItems(3).Text)
                            rtfTable.Append("\intbl\cell")
                            rtfTable.Append("\cellx7500" & listViewGrocery.Items(i).SubItems(4).Text)
                            rtfTable.Append("\intbl\cell\row")
                        End If
                    Next
                    'Appends the order total, Sales Tax, Grand Total, Cash Payment, Change, and savings into the table
                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "Order Total")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "$" & (total - taxTotal).ToString("#.##"))
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "Sales Tax")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & lblTax.Text)
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "Grand Total")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "$" & total.ToString("#.##"))
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "Cash")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "Payment")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "$" & TxtCashOut.Text)
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "Change")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "$" & (total - Decimal.Parse(TxtCashOut.Text)).ToString("#.##"))
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\trowd")
                    rtfTable.Append("\cellx1500" & "Savings")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & "")
                    rtfTable.Append("\intbl\cell")
                    rtfTable.Append("\cellx1500" & lblSavings.Text)
                    rtfTable.Append("\intbl\cell\row")

                    rtfTable.Append("\pard")
                    rtfTable.Append("}")

                    'trims any trailing occurance of the specified character
                    Dim rtf1 As String = rtxtReceipt.Rtf.Trim().TrimEnd("}")
                    Dim rtf2 As String = rtfTable.ToString()

                    'Place all text entries in a specified order into the rich text box
                    rtxtReceipt.Select(header.ToString().Count(), 0)
                    rtxtReceipt.SelectedRtf = rtf2

                    'Append DateTime and Footer
                    rtxtReceipt.Text += tenderTime & footer

                    rtxtReceipt.BringToFront()

                    label1.Text = "Change"
                    TxtTotal.Text = (total - Decimal.Parse(TxtCashOut.Text)).ToString("#.##")

                    BtnBack_Click(sender, e)
                    SaveReceipt()
                    ResetForm()

                End If
            End If
        End If



    End Sub
End Class
