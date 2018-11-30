﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Register


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

    Dim total = 0
    Dim qty As Integer = 1
    Const _tax As Decimal = 0.07

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

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        'Insert button value to the txtInput string
        txtInput.Text += "0"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        'Insert button value to the txtInput string
        txtInput.Text += "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        'Insert button value to the txtInput string
        txtInput.Text += "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        'Insert button value to the txtInput string
        txtInput.Text += "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        'Insert button value to the txtInput string
        txtInput.Text += "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        'Insert button value to the txtInput string
        txtInput.Text += "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        'Insert button value to the txtInput string
        txtInput.Text += "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        'Insert button value to the txtInput string
        txtInput.Text += "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        'Insert button value to the txtInput string
        txtInput.Text += "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        'Insert button value to the txtInput string
        txtInput.Text += "9"
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Clear the current text input
        txtInput.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As String = txtInput.Text
        Dim result As String

        'Delete the preceding text on the txtInput textbox
        If i.Length > 0 Then
            result = i.Remove(i.Length - 1) 'delete the current text based on the length of the string minus one
            txtInput.Text = result 'reasign the new value to the textbox
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
End Class
