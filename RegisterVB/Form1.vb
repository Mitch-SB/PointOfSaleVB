Public Class Form1

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

    Dim Qty As Integer = 1


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
            Qty = txtInput.Text
            lblQty.Text = "Qty: " & Qty.ToString()
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

End Class
