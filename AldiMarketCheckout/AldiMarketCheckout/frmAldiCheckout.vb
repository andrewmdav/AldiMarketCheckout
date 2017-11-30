'This front-end program represents an initial sign on and customer checkout application at a  
'grocery store. Cashier can add/subtract different quantities of various products in the store by
'pressing the image of the item to check out.  A fruit selection enables the fruit 
'subcategory selection screen.  Totals for individual products and the final bill amount are 
'updated on the display as checkout occurs.  User can ultimately initiate payment, clear the screen 
'for the next customer, or sign off.  File clsProducts.vb contains the core product prices and 
'quantities, while file clsProducts.Fruit.vb contains the same information for fruit subcategory items.

Public Class frmAldiCheckout

    Dim isFormLoaded As Boolean = False     'flag indicating initial form load has occurred
    Dim decBillTotal As Decimal = 0.00D     'total grocery bill amount
    Dim intNewItemQuant As Integer          'newly selected product quantity
    Dim decNewAmount As Decimal             'new item amount for bill    
    Dim strQuantPrice As String             'string to display in list box (bill)

    'clear the form, mark the initial load, and set quantity & username combo boxes
    Private Sub frmAldiCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clear the form and set flag indicating initial form load has occurred
        btnClear_Click(sender, e)
        isFormLoaded = True

        'fill combo boxes and set display
        For index = 1 To 10
            cboQuantity.Items.Add(index)
            cboQuantity.SelectedIndex = 0

            cboUserName.Items.Add("#" & index)
        Next

        'disable form items except items needed to sign on
        InitiateSignOn()

        'sign on instructions for testing purposes
        MsgBox("Sign on with ""11-1111-1111"" for employees 1 through 5 or ""22-2222-2222"" " &
                "for employees 6 through 10.", MsgBoxStyle.Information, "User Sign On Help Message")

    End Sub

    Private Sub btnBread_Click(sender As Object, e As EventArgs) Handles btnBread.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.BreadPrice, clsProducts.BreadQuant) Then
            DisplayItem("Bread", clsProducts.BreadPrice.ToString())
        End If

    End Sub

    Private Sub btnCheese_Click(sender As Object, e As EventArgs) Handles btnCheese.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.CheesePrice, clsProducts.CheeseQuant) Then
            DisplayItem("Cheese", clsProducts.CheesePrice.ToString())
        End If
    End Sub

    Private Sub btnChicken_Click(sender As Object, e As EventArgs) Handles btnChicken.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.ChickenPrice, clsProducts.ChickenQuant) Then
            DisplayItem("Chicken", clsProducts.ChickenPrice.ToString())
        End If
    End Sub

    Private Sub btnChips_Click(sender As Object, e As EventArgs) Handles btnChips.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.ChipsPrice, clsProducts.ChipsQuant) Then
            DisplayItem("Chips", clsProducts.ChipsPrice.ToString())
        End If
    End Sub

    Private Sub btnCrackers_Click(sender As Object, e As EventArgs) Handles btnCrackers.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.CrackerPrice, clsProducts.CrackersQuant) Then
            DisplayItem("Crackers", clsProducts.CrackerPrice.ToString())
        End If
    End Sub

    Private Sub btnEggs_Click(sender As Object, e As EventArgs) Handles btnEggs.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.EggPrice, clsProducts.EggsQuant) Then
            DisplayItem("Eggs", clsProducts.EggPrice.ToString())
        End If
    End Sub

    Private Sub btnMilk_Click(sender As Object, e As EventArgs) Handles btnMilk.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.MilkPrice, clsProducts.MilkQuant) Then
            DisplayItem("Milk", clsProducts.MilkPrice.ToString())
        End If
    End Sub

    Private Sub btnApples_Click(sender As Object, e As EventArgs) Handles btnApples.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.Fruit.ApplesPrice, clsProducts.Fruit.ApplesQuant) Then
            DisplayItem("Apples", clsProducts.Fruit.ApplesPrice.ToString())
        End If
    End Sub

    Private Sub btnBananas_Click(sender As Object, e As EventArgs) Handles btnBananas.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.Fruit.BananasPrice, clsProducts.Fruit.BananasQuant) Then
            DisplayItem("Bananas", clsProducts.Fruit.BananasPrice.ToString())
        End If
    End Sub

    Private Sub btnOranges_Click(sender As Object, e As EventArgs) Handles btnOranges.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.Fruit.OrangesPrice, clsProducts.Fruit.OrangesQuant) Then
            DisplayItem("Oranges", clsProducts.Fruit.OrangesPrice.ToString())
        End If
    End Sub

    Private Sub btnBlueberries_Click(sender As Object, e As EventArgs) Handles btnBlueberries.Click
        'validate a positive quantity, showing error message, or add item to bill and 
        'update the display
        If isValidAmount(clsProducts.Fruit.BlueberriesPrice, clsProducts.Fruit.BlueberriesQuant) Then
            DisplayItem("Blueberries", clsProducts.Fruit.BlueberriesPrice.ToString())
        End If
    End Sub

    'button opens up the fruit sub-category screen, bringing it into focus, and displaying a user message to select a fruit
    Private Sub btnFruit_Click(sender As Object, e As EventArgs) Handles btnFruit.Click
        grpFruit.Enabled = True
        grpProducts.Enabled = False
        btnApples.Focus()
        lblMessage.Text = "Select fruit category in the ""Select Fruit""" & vbCrLf & "group box."
    End Sub

    'call form closing event
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'confirm decision to close
    Private Sub frmAldiCheckout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim drResponse As DialogResult      'user response

        'confirm closing of form with a message box
        drResponse = MsgBox("Please confirm form closing.", MsgBoxStyle.OkCancel, "Exit Form")

        If drResponse = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    'if form has not initially loaded, clear w/o user confirmation, else ask user to confirm form clearing
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim isOkToClear As Boolean = True   'flags form as ok to clear
        Dim drResponse As DialogResult      'receives message box decision

        If isFormLoaded Then
            isOkToClear = False

            drResponse = MsgBox("Please confirm form clearing.", MessageBoxButtons.OKCancel, "Clear Form")

            If drResponse = DialogResult.OK Then
                isOkToClear = True
            End If
        End If

        'reset form
        If isOkToClear Then
            lstDisplay.Items.Clear()
            txtTotal.Text = ""
            radAddItems.Checked = True
            decBillTotal = 0.00D
            grpFruit.Enabled = False
            grpProducts.Enabled = True
            lblMessage.Text = ""
            clearProductQuantities()
            btnFruit.Focus()
        End If

    End Sub

    'enable password entry and sign on button (if selected index is not changed because of a sign off,
    ' which sets an index of -1)
    Private Sub cboUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserName.SelectedIndexChanged
        If Not cboUserName.SelectedIndex = -1 Then
            mtbPassword.Enabled = True
            btnSignOn.Enabled = True
        End If
    End Sub

    'validate masked text box employee ID input and check for correct employee number/ID combinations
    Private Sub btnSignOn_Click(sender As Object, e As EventArgs) Handles btnSignOn.Click
        Dim index As Integer = cboUserName.SelectedIndex    'set index as the index of the chosen employee

        If Not mtbPassword.Text.Length = 10 Then
            lblMessage.Text = "Employee number must be 10 digits"
        ElseIf Not IsNumeric(mtbPassword.Text) Then
            lblMessage.Text = "Employee number must be numeric"
        ElseIf index < 5 And Convert.ToInt64(mtbPassword.Text) = 1111111111 Then
            CompletedSignOn()
            lblMessage.Text = ""
        ElseIf index >= 5 And index <= 9 And Convert.ToInt64(mtbPassword.Text) = 2222222222 Then
            CompletedSignOn()
            lblMessage.Text = ""
        Else
            lblMessage.Text = "Invalid employee id entered."
        End If
    End Sub

    'confirm user sign off and disable form items not needed to sign on again
    Private Sub btnSignOff_Click(sender As Object, e As EventArgs) Handles btnSignOff.Click
        Dim drResponse As DialogResult      'user response

        drResponse = MsgBox("Please confirm sign off.", MessageBoxButtons.OKCancel, "Sign Off Confirmation")

        If drResponse = DialogResult.OK Then
            InitiateSignOn()
        End If

        'Reset cboUsername
        cboUserName.SelectedIndex = -1
        cboUserName.Text = "Select Employee#"

    End Sub

    'simple message about the program
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim strAbout As String

        strAbout = "Aldi Market Checkout" & vbCrLf &
            "Version 1.0" & vbCrLf &
            "Created by Andrew Davison"

        MsgBox(strAbout, MsgBoxStyle.Information, "About Aldi Market Checkout")
    End Sub

    'note to a test user about logging in
    Private Sub SignOnHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuSignOnHelp.Click
        MsgBox("Sign on with ""11-1111-1111"" for employees 1 through 5 or ""22-2222-2222"" " &
                "for employees 6 through 10.", MsgBoxStyle.Information, "User Sign On Help Message")
    End Sub

    'exit fruit subcategory and return to main product section
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        grpFruit.Enabled = False
        grpProducts.Enabled = True
        lblMessage.Text = ""
        btnFruit.Focus()
    End Sub

    'simple message for cashier to customer.  Section not built out in this example.
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If decBillTotal > 0 Then
            lblMessage.Text = "Have customer make payment selection" & vbCrLf & "on credit card screen."
        Else
            lblMessage.Text = "Bill amount must be greater than" & vbCrLf & "zero to pay."
        End If

    End Sub

    'validates the new quantity (cannot become negative for a given product) and calculates
    'the new billing total    
    Private Function isValidAmount(decPrice As Decimal, ByRef decOldQuant As Decimal) As Boolean

        'calculate new quantity, accounting for input type (+/-)
        intNewItemQuant = cboQuantity.SelectedItem * If(radAddItems.Checked, 1, -1)

        'validate new product quantity at greater than zero
        If intNewItemQuant + decOldQuant < 0 Then
            MsgBox("Cannot have negative item quantity.", MsgBoxStyle.Critical, "Negative Product Quantity Warning")
            Return False
        Else
            'calculate new amount
            decNewAmount = decPrice * Convert.ToDecimal(intNewItemQuant)

            'update product quantity
            decOldQuant += intNewItemQuant

            'update billing total
            decBillTotal += decNewAmount

            Return True
        End If
    End Function

    'display the newly checked out item and new total bill amount
    Private Sub DisplayItem(strProduct As String, decPrice As Decimal)

        'adjust quantity/price string based on +/- sign for "cleaner" display
        If radAddItems.Checked Then
            strQuantPrice = "+" & intNewItemQuant.ToString() & " x " & decPrice.ToString("F2") & " = " & "+" & decNewAmount.ToString("F2")
        Else
            strQuantPrice = intNewItemQuant.ToString() & " x " & decPrice.ToString("F2") & " = " & decNewAmount.ToString("F2")
        End If

        'display product and quantity/price display in list box (right justified with padding)
        lstDisplay.Items.Add(strProduct & ":" & strQuantPrice.PadLeft(30 - strProduct.Length))

        'scroll the list box down as items are added
        lstDisplay.TopIndex = lstDisplay.Items.Count - 1

        'display bill total in text box
        txtTotal.Text = "Total:          " & decBillTotal.ToString() & "       "

        'enable main products category, disable subcategory, and reset focus to quantity     
        lblMessage.Text = ""
        cboQuantity.Focus()
    End Sub

    'disable all controls except the necessary sign on controls
    Private Sub InitiateSignOn()
        For Each Control As Control In Me.Controls
            Select Case Control.Name
                Case "lblTitle", "grpSignOn", "cboUserName", "btnExit", "lblMessage", "picLogo1", "mnuAldi"
                    Control.Enabled = True
                Case Else
                    Control.Enabled = False
            End Select
        Next

        'Clear display and user message
        lstDisplay.Items.Clear()
        txtTotal.Text = ""
        lblMessage.Text = ""

        'display the group box sign on        
        ' grpSignOn.Visible = True

        'disable the password and sign on button (at least until an employee is selected)
        mtbPassword.Enabled = False
        btnSignOn.Enabled = False

        'clear product quantities
        clearProductQuantities()
    End Sub

    'enable all controls after sign on, except the Fruit subcategory
    Private Sub CompletedSignOn()
        For Each Control As Control In Me.Controls
            Select Case Control.Name
                Case "grpFruit"
                Case Else
                    Control.Enabled = True
            End Select
        Next

        'reset password
        mtbPassword.Clear()
        cboUserName.Text = "Select Employee#"

        'remove sign on section of form
        grpSignOn.Enabled = False

    End Sub

    'clear product quantities
    Private Sub clearProductQuantities()
        clsProducts.BreadQuant = 0
        clsProducts.CheeseQuant = 0
        clsProducts.ChickenQuant = 0
        clsProducts.ChipsQuant = 0
        clsProducts.CrackersQuant = 0
        clsProducts.EggsQuant = 0
        clsProducts.Fruit.ApplesQuant = 0
        clsProducts.Fruit.BananasQuant = 0
        clsProducts.Fruit.OrangesQuant = 0
        clsProducts.Fruit.BlueberriesQuant = 0

    End Sub
End Class
