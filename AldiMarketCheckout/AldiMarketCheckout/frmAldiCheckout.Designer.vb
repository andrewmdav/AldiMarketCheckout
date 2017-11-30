<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAldiCheckout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.grpInputMode = New System.Windows.Forms.GroupBox()
        Me.radSubtractItems = New System.Windows.Forms.RadioButton()
        Me.radAddItems = New System.Windows.Forms.RadioButton()
        Me.grpProducts = New System.Windows.Forms.GroupBox()
        Me.btnMilk = New System.Windows.Forms.Button()
        Me.btnFruit = New System.Windows.Forms.Button()
        Me.btnEggs = New System.Windows.Forms.Button()
        Me.btnCrackers = New System.Windows.Forms.Button()
        Me.btnChips = New System.Windows.Forms.Button()
        Me.btnChicken = New System.Windows.Forms.Button()
        Me.btnCheese = New System.Windows.Forms.Button()
        Me.btnBread = New System.Windows.Forms.Button()
        Me.btnSignOff = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboQuantity = New System.Windows.Forms.ComboBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.grpFruit = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBlueberries = New System.Windows.Forms.Button()
        Me.btnOranges = New System.Windows.Forms.Button()
        Me.btnBananas = New System.Windows.Forms.Button()
        Me.btnApples = New System.Windows.Forms.Button()
        Me.grpSignOn = New System.Windows.Forms.GroupBox()
        Me.btnSignOn = New System.Windows.Forms.Button()
        Me.cboUserName = New System.Windows.Forms.ComboBox()
        Me.mtbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.picLogo1 = New System.Windows.Forms.PictureBox()
        Me.mnuAldi = New System.Windows.Forms.MenuStrip()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSignOnHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.grpInputMode.SuspendLayout()
        Me.grpProducts.SuspendLayout()
        Me.grpFruit.SuspendLayout()
        Me.grpSignOn.SuspendLayout()
        CType(Me.picLogo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAldi.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(200, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(466, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SPEEDY CUSTOMER CHECKOUT"
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 17
        Me.lstDisplay.Location = New System.Drawing.Point(12, 257)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(320, 225)
        Me.lstDisplay.TabIndex = 1
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(12, 512)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(320, 22)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpInputMode
        '
        Me.grpInputMode.Controls.Add(Me.radSubtractItems)
        Me.grpInputMode.Controls.Add(Me.radAddItems)
        Me.grpInputMode.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInputMode.Location = New System.Drawing.Point(484, 192)
        Me.grpInputMode.Name = "grpInputMode"
        Me.grpInputMode.Size = New System.Drawing.Size(317, 54)
        Me.grpInputMode.TabIndex = 2
        Me.grpInputMode.TabStop = False
        Me.grpInputMode.Text = "Input Mode"
        '
        'radSubtractItems
        '
        Me.radSubtractItems.AutoSize = True
        Me.radSubtractItems.Location = New System.Drawing.Point(149, 21)
        Me.radSubtractItems.Name = "radSubtractItems"
        Me.radSubtractItems.Size = New System.Drawing.Size(131, 21)
        Me.radSubtractItems.TabIndex = 1
        Me.radSubtractItems.TabStop = True
        Me.radSubtractItems.Text = "Subtract Items"
        Me.radSubtractItems.UseVisualStyleBackColor = True
        '
        'radAddItems
        '
        Me.radAddItems.AutoSize = True
        Me.radAddItems.Location = New System.Drawing.Point(21, 21)
        Me.radAddItems.Name = "radAddItems"
        Me.radAddItems.Size = New System.Drawing.Size(100, 21)
        Me.radAddItems.TabIndex = 0
        Me.radAddItems.TabStop = True
        Me.radAddItems.Text = "Add Items"
        Me.radAddItems.UseVisualStyleBackColor = True
        '
        'grpProducts
        '
        Me.grpProducts.BackColor = System.Drawing.Color.Green
        Me.grpProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpProducts.Controls.Add(Me.btnMilk)
        Me.grpProducts.Controls.Add(Me.btnFruit)
        Me.grpProducts.Controls.Add(Me.btnEggs)
        Me.grpProducts.Controls.Add(Me.btnCrackers)
        Me.grpProducts.Controls.Add(Me.btnChips)
        Me.grpProducts.Controls.Add(Me.btnChicken)
        Me.grpProducts.Controls.Add(Me.btnCheese)
        Me.grpProducts.Controls.Add(Me.btnBread)
        Me.grpProducts.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProducts.ForeColor = System.Drawing.SystemColors.Control
        Me.grpProducts.Location = New System.Drawing.Point(340, 257)
        Me.grpProducts.Name = "grpProducts"
        Me.grpProducts.Size = New System.Drawing.Size(461, 277)
        Me.grpProducts.TabIndex = 4
        Me.grpProducts.TabStop = False
        Me.grpProducts.Text = "Select Products"
        '
        'btnMilk
        '
        Me.btnMilk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMilk.Image = Global.AldiMarketCheckout.My.Resources.Resources.milk
        Me.btnMilk.Location = New System.Drawing.Point(350, 151)
        Me.btnMilk.Name = "btnMilk"
        Me.btnMilk.Size = New System.Drawing.Size(90, 91)
        Me.btnMilk.TabIndex = 7
        Me.btnMilk.UseVisualStyleBackColor = True
        '
        'btnFruit
        '
        Me.btnFruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFruit.Image = Global.AldiMarketCheckout.My.Resources.Resources.fruit
        Me.btnFruit.Location = New System.Drawing.Point(29, 43)
        Me.btnFruit.Name = "btnFruit"
        Me.btnFruit.Size = New System.Drawing.Size(90, 91)
        Me.btnFruit.TabIndex = 0
        Me.btnFruit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnFruit.UseVisualStyleBackColor = True
        '
        'btnEggs
        '
        Me.btnEggs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEggs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEggs.Image = Global.AldiMarketCheckout.My.Resources.Resources.eggs
        Me.btnEggs.Location = New System.Drawing.Point(245, 151)
        Me.btnEggs.Name = "btnEggs"
        Me.btnEggs.Size = New System.Drawing.Size(90, 91)
        Me.btnEggs.TabIndex = 6
        Me.btnEggs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEggs.UseVisualStyleBackColor = True
        '
        'btnCrackers
        '
        Me.btnCrackers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrackers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrackers.Image = Global.AldiMarketCheckout.My.Resources.Resources.crackers
        Me.btnCrackers.Location = New System.Drawing.Point(134, 151)
        Me.btnCrackers.Name = "btnCrackers"
        Me.btnCrackers.Size = New System.Drawing.Size(90, 91)
        Me.btnCrackers.TabIndex = 5
        Me.btnCrackers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCrackers.UseVisualStyleBackColor = True
        '
        'btnChips
        '
        Me.btnChips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChips.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChips.Image = Global.AldiMarketCheckout.My.Resources.Resources.chips
        Me.btnChips.Location = New System.Drawing.Point(29, 151)
        Me.btnChips.Name = "btnChips"
        Me.btnChips.Size = New System.Drawing.Size(90, 91)
        Me.btnChips.TabIndex = 4
        Me.btnChips.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnChips.UseVisualStyleBackColor = True
        '
        'btnChicken
        '
        Me.btnChicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChicken.Image = Global.AldiMarketCheckout.My.Resources.Resources.chicken
        Me.btnChicken.Location = New System.Drawing.Point(245, 43)
        Me.btnChicken.Name = "btnChicken"
        Me.btnChicken.Size = New System.Drawing.Size(90, 91)
        Me.btnChicken.TabIndex = 2
        Me.btnChicken.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnChicken.UseVisualStyleBackColor = True
        '
        'btnCheese
        '
        Me.btnCheese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheese.Image = Global.AldiMarketCheckout.My.Resources.Resources.cheese
        Me.btnCheese.Location = New System.Drawing.Point(134, 43)
        Me.btnCheese.Name = "btnCheese"
        Me.btnCheese.Size = New System.Drawing.Size(90, 91)
        Me.btnCheese.TabIndex = 1
        Me.btnCheese.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCheese.UseVisualStyleBackColor = True
        '
        'btnBread
        '
        Me.btnBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBread.Image = Global.AldiMarketCheckout.My.Resources.Resources.bread
        Me.btnBread.Location = New System.Drawing.Point(350, 43)
        Me.btnBread.Name = "btnBread"
        Me.btnBread.Size = New System.Drawing.Size(90, 91)
        Me.btnBread.TabIndex = 3
        Me.btnBread.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnBread.UseVisualStyleBackColor = True
        '
        'btnSignOff
        '
        Me.btnSignOff.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSignOff.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOff.ForeColor = System.Drawing.Color.White
        Me.btnSignOff.Location = New System.Drawing.Point(243, 574)
        Me.btnSignOff.Name = "btnSignOff"
        Me.btnSignOff.Size = New System.Drawing.Size(89, 40)
        Me.btnSignOff.TabIndex = 6
        Me.btnSignOff.Text = "Sign Off"
        Me.btnSignOff.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(131, 574)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 40)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(726, 727)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cboQuantity
        '
        Me.cboQuantity.FormattingEnabled = True
        Me.cboQuantity.Location = New System.Drawing.Point(340, 223)
        Me.cboQuantity.Name = "cboQuantity"
        Me.cboQuantity.Size = New System.Drawing.Size(58, 24)
        Me.cboQuantity.TabIndex = 1
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(337, 192)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(69, 17)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity"
        '
        'grpFruit
        '
        Me.grpFruit.BackColor = System.Drawing.Color.DarkRed
        Me.grpFruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpFruit.Controls.Add(Me.btnBack)
        Me.grpFruit.Controls.Add(Me.btnBlueberries)
        Me.grpFruit.Controls.Add(Me.btnOranges)
        Me.grpFruit.Controls.Add(Me.btnBananas)
        Me.grpFruit.Controls.Add(Me.btnApples)
        Me.grpFruit.Enabled = False
        Me.grpFruit.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFruit.ForeColor = System.Drawing.SystemColors.Control
        Me.grpFruit.Location = New System.Drawing.Point(340, 540)
        Me.grpFruit.Name = "grpFruit"
        Me.grpFruit.Size = New System.Drawing.Size(461, 181)
        Me.grpFruit.TabIndex = 5
        Me.grpFruit.TabStop = False
        Me.grpFruit.Text = "Select Fruit"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkBlue
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(29, 140)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(78, 35)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnBlueberries
        '
        Me.btnBlueberries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBlueberries.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlueberries.Image = Global.AldiMarketCheckout.My.Resources.Resources.blueberries
        Me.btnBlueberries.Location = New System.Drawing.Point(350, 43)
        Me.btnBlueberries.Name = "btnBlueberries"
        Me.btnBlueberries.Size = New System.Drawing.Size(90, 91)
        Me.btnBlueberries.TabIndex = 6
        Me.btnBlueberries.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnBlueberries.UseVisualStyleBackColor = True
        '
        'btnOranges
        '
        Me.btnOranges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOranges.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOranges.Image = Global.AldiMarketCheckout.My.Resources.Resources.oranges
        Me.btnOranges.Location = New System.Drawing.Point(245, 43)
        Me.btnOranges.Name = "btnOranges"
        Me.btnOranges.Size = New System.Drawing.Size(90, 91)
        Me.btnOranges.TabIndex = 2
        Me.btnOranges.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnOranges.UseVisualStyleBackColor = True
        '
        'btnBananas
        '
        Me.btnBananas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBananas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBananas.Image = Global.AldiMarketCheckout.My.Resources.Resources.bananas
        Me.btnBananas.Location = New System.Drawing.Point(134, 43)
        Me.btnBananas.Name = "btnBananas"
        Me.btnBananas.Size = New System.Drawing.Size(90, 91)
        Me.btnBananas.TabIndex = 1
        Me.btnBananas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnBananas.UseVisualStyleBackColor = True
        '
        'btnApples
        '
        Me.btnApples.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnApples.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnApples.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApples.Image = Global.AldiMarketCheckout.My.Resources.Resources.apples
        Me.btnApples.Location = New System.Drawing.Point(29, 43)
        Me.btnApples.Name = "btnApples"
        Me.btnApples.Size = New System.Drawing.Size(90, 91)
        Me.btnApples.TabIndex = 0
        Me.btnApples.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnApples.UseVisualStyleBackColor = True
        '
        'grpSignOn
        '
        Me.grpSignOn.Controls.Add(Me.btnSignOn)
        Me.grpSignOn.Controls.Add(Me.cboUserName)
        Me.grpSignOn.Controls.Add(Me.mtbPassword)
        Me.grpSignOn.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSignOn.Location = New System.Drawing.Point(12, 79)
        Me.grpSignOn.Name = "grpSignOn"
        Me.grpSignOn.Size = New System.Drawing.Size(308, 100)
        Me.grpSignOn.TabIndex = 0
        Me.grpSignOn.TabStop = False
        Me.grpSignOn.Text = "User Sign On"
        '
        'btnSignOn
        '
        Me.btnSignOn.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSignOn.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOn.ForeColor = System.Drawing.Color.White
        Me.btnSignOn.Location = New System.Drawing.Point(177, 30)
        Me.btnSignOn.Name = "btnSignOn"
        Me.btnSignOn.Size = New System.Drawing.Size(100, 62)
        Me.btnSignOn.TabIndex = 2
        Me.btnSignOn.Text = "Sign On"
        Me.btnSignOn.UseVisualStyleBackColor = False
        '
        'cboUserName
        '
        Me.cboUserName.FormattingEnabled = True
        Me.cboUserName.Location = New System.Drawing.Point(6, 30)
        Me.cboUserName.Name = "cboUserName"
        Me.cboUserName.Size = New System.Drawing.Size(145, 24)
        Me.cboUserName.TabIndex = 0
        Me.cboUserName.Text = "Select Employee#"
        '
        'mtbPassword
        '
        Me.mtbPassword.Location = New System.Drawing.Point(6, 69)
        Me.mtbPassword.Mask = "00-0000-0000"
        Me.mtbPassword.Name = "mtbPassword"
        Me.mtbPassword.Size = New System.Drawing.Size(92, 23)
        Me.mtbPassword.TabIndex = 1
        Me.mtbPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(9, 192)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(113, 18)
        Me.lblMessage.TabIndex = 10
        Me.lblMessage.Text = "User Messages"
        '
        'picLogo1
        '
        Me.picLogo1.Image = Global.AldiMarketCheckout.My.Resources.Resources.aldi1
        Me.picLogo1.Location = New System.Drawing.Point(690, 79)
        Me.picLogo1.Name = "picLogo1"
        Me.picLogo1.Size = New System.Drawing.Size(111, 100)
        Me.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo1.TabIndex = 11
        Me.picLogo1.TabStop = False
        '
        'mnuAldi
        '
        Me.mnuAldi.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuAldi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp})
        Me.mnuAldi.Location = New System.Drawing.Point(0, 0)
        Me.mnuAldi.Name = "mnuAldi"
        Me.mnuAldi.Size = New System.Drawing.Size(829, 28)
        Me.mnuAldi.TabIndex = 12
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator5, Me.mnuSignOnHelp, Me.ToolStripSeparator1, Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "&Help"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(169, 6)
        '
        'mnuSignOnHelp
        '
        Me.mnuSignOnHelp.Name = "mnuSignOnHelp"
        Me.mnuSignOnHelp.Size = New System.Drawing.Size(172, 26)
        Me.mnuSignOnHelp.Text = "Sign On Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(172, 26)
        Me.mnuAbout.Text = "&About..."
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.DarkBlue
        Me.btnPayment.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(12, 574)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(89, 40)
        Me.btnPayment.TabIndex = 13
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'frmAldiCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(829, 764)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.picLogo1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.grpSignOn)
        Me.Controls.Add(Me.grpFruit)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.cboQuantity)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSignOff)
        Me.Controls.Add(Me.grpProducts)
        Me.Controls.Add(Me.grpInputMode)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuAldi)
        Me.MainMenuStrip = Me.mnuAldi
        Me.Name = "frmAldiCheckout"
        Me.Text = "ALDI Market Checkout"
        Me.grpInputMode.ResumeLayout(False)
        Me.grpInputMode.PerformLayout()
        Me.grpProducts.ResumeLayout(False)
        Me.grpFruit.ResumeLayout(False)
        Me.grpSignOn.ResumeLayout(False)
        Me.grpSignOn.PerformLayout()
        CType(Me.picLogo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAldi.ResumeLayout(False)
        Me.mnuAldi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents grpInputMode As GroupBox
    Friend WithEvents radSubtractItems As RadioButton
    Friend WithEvents radAddItems As RadioButton
    Friend WithEvents grpProducts As GroupBox
    Friend WithEvents btnSignOff As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBread As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEggs As Button
    Friend WithEvents btnCrackers As Button
    Friend WithEvents btnChips As Button
    Friend WithEvents btnChicken As Button
    Friend WithEvents btnCheese As Button
    Friend WithEvents btnMilk As Button
    Friend WithEvents btnFruit As Button
    Friend WithEvents cboQuantity As ComboBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents grpFruit As GroupBox
    Friend WithEvents btnBlueberries As Button
    Friend WithEvents btnOranges As Button
    Friend WithEvents btnBananas As Button
    Friend WithEvents btnApples As Button
    Friend WithEvents grpSignOn As GroupBox
    Friend WithEvents btnSignOn As Button
    Friend WithEvents cboUserName As ComboBox
    Friend WithEvents mtbPassword As MaskedTextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents picLogo1 As PictureBox
    Friend WithEvents mnuAldi As MenuStrip
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuSignOnHelp As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPayment As Button
End Class
