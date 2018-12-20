Public Class LogIn
    Dim register As Register = New Register

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "0"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "0"
            End If
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "1"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "1"
            End If
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "2"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "2"
            End If
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "3"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "3"
            End If
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "4"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "4"
            End If
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "5"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "5"
            End If
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "6"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "6"
            End If
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "7"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "7"
            End If
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "8"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "8"
            End If
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        'Insert button value into either TxtCashier or TxtPassword textboxes if enabled
        If TxtCashier.Enabled = True Then
            If TxtCashier.TextLength <= 2 Then
                TxtCashier.Text += "9"
            End If
        Else
            If TxtPassword.TextLength <= 3 Then
                TxtPassword.Text += "9"
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtCashier.Clear()
        TxtPassword.Clear()

        TxtCashier.Enabled = True
        TxtPassword.Enabled = False

        LblCashier.Text = "Cashier"
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As String = TxtCashier.Text
        Dim o As String = TxtPassword.Text

        Dim result As String

        If TxtCashier.Enabled = True Then
            If i.Length > 0 Then
                result = i.Remove(i.Length - 1) 'delete the current text based on the length of the string minus one
                TxtCashier.Text = result 'reasign the new value to the textbox
            End If
        Else
            'Delete the preceding text on the TxtPassword textbox
            If o.Length > 0 Then
                result = o.Remove(o.Length - 1) 'delete the current text based on the length of the string minus one
                TxtPassword.Text = result 'reasign the new value to the textbox
            End If
        End If
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        If TxtCashier.Enabled = True Then
            'Establish connection
            Dim db As DataAccess = New DataAccess
            Dim c As Cashiers = db.GetCashier(TxtCashier.Text)

            'If user enters an invalid cashier number, cashier name will turn up null and will not run. clears
            If c.Name = "" Then
                MessageBox.Show("Invalid Cashier!")
                BtnClear_Click(sender, e)
                Return
            Else
                'sets the variables for password entry and stores cashier name
                LblCashier.Text = c.Name
                TxtCashier.Enabled = False
                TxtPassword.Enabled = True
                Register._cashier = c.Name
                Register._cashNumber = c.CashNumber
                Register._password = c.UserPassword
                Return
            End If
        End If

        If TxtPassword.Enabled = True Then
            If TxtPassword.Text <> Register._password Then
                MessageBox.Show("Invalid Password!")
                BtnClear_Click(sender, e)
            Else
                'runs if the password entered matches the users password
                MessageBox.Show("Whoohoo!")

                'Hides the current form
                Hide()

                'launches main form
                register.Show()
            End If
        End If
    End Sub
End Class