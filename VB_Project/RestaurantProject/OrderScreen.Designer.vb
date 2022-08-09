<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderScreen))
        Me.btnShape2 = New System.Windows.Forms.Button()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblDough = New System.Windows.Forms.Label()
        Me.lblSauce = New System.Windows.Forms.Label()
        Me.lblToppings = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.rdoLarge = New System.Windows.Forms.RadioButton()
        Me.btnPrevious1 = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.txtInfoAll = New System.Windows.Forms.TextBox()
        Me.lblInfoAll = New System.Windows.Forms.Label()
        Me.txtDough = New System.Windows.Forms.TextBox()
        Me.txtDrink = New System.Windows.Forms.TextBox()
        Me.txtSauce = New System.Windows.Forms.TextBox()
        Me.rdoCauliflower = New System.Windows.Forms.RadioButton()
        Me.rdoRegular = New System.Windows.Forms.RadioButton()
        Me.rdoTomato = New System.Windows.Forms.RadioButton()
        Me.rdoRanch = New System.Windows.Forms.RadioButton()
        Me.rdoAlfredo = New System.Windows.Forms.RadioButton()
        Me.gbxDough = New System.Windows.Forms.GroupBox()
        Me.gbxSauce = New System.Windows.Forms.GroupBox()
        Me.txtToppings = New System.Windows.Forms.TextBox()
        Me.rdoCheese = New System.Windows.Forms.RadioButton()
        Me.rdoPepperoni = New System.Windows.Forms.RadioButton()
        Me.rdoBacon = New System.Windows.Forms.RadioButton()
        Me.rdoChicken = New System.Windows.Forms.RadioButton()
        Me.rdoBroccoli = New System.Windows.Forms.RadioButton()
        Me.rdoHamburger = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoCoke = New System.Windows.Forms.RadioButton()
        Me.rdoAppleJuice = New System.Windows.Forms.RadioButton()
        Me.rdoSprite = New System.Windows.Forms.RadioButton()
        Me.rdoOrangeJuice = New System.Windows.Forms.RadioButton()
        Me.rdoFanta = New System.Windows.Forms.RadioButton()
        Me.rdoGingerAle = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.btnSubtotal = New System.Windows.Forms.Button()
        Me.gbxDough.SuspendLayout()
        Me.gbxSauce.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShape2
        '
        Me.btnShape2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnShape2.Enabled = False
        Me.btnShape2.Location = New System.Drawing.Point(34, 74)
        Me.btnShape2.Name = "btnShape2"
        Me.btnShape2.Size = New System.Drawing.Size(628, 482)
        Me.btnShape2.TabIndex = 0
        Me.btnShape2.UseVisualStyleBackColor = False
        '
        'lblBuild
        '
        Me.lblBuild.AutoSize = True
        Me.lblBuild.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBuild.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBuild.Location = New System.Drawing.Point(54, 97)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(216, 18)
        Me.lblBuild.TabIndex = 3
        Me.lblBuild.Text = """Build Your Pizza"" Combo"
        '
        'lblDough
        '
        Me.lblDough.AutoSize = True
        Me.lblDough.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDough.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDough.Location = New System.Drawing.Point(54, 129)
        Me.lblDough.Name = "lblDough"
        Me.lblDough.Size = New System.Drawing.Size(54, 16)
        Me.lblDough.TabIndex = 4
        Me.lblDough.Text = "Dough:"
        '
        'lblSauce
        '
        Me.lblSauce.AutoSize = True
        Me.lblSauce.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSauce.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSauce.Location = New System.Drawing.Point(54, 189)
        Me.lblSauce.Name = "lblSauce"
        Me.lblSauce.Size = New System.Drawing.Size(54, 16)
        Me.lblSauce.TabIndex = 8
        Me.lblSauce.Text = "Sauce:"
        '
        'lblToppings
        '
        Me.lblToppings.AutoSize = True
        Me.lblToppings.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblToppings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblToppings.Location = New System.Drawing.Point(54, 257)
        Me.lblToppings.Name = "lblToppings"
        Me.lblToppings.Size = New System.Drawing.Size(71, 16)
        Me.lblToppings.TabIndex = 12
        Me.lblToppings.Text = "Toppings:"
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDrinks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDrinks.Location = New System.Drawing.Point(54, 369)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(52, 16)
        Me.lblDrinks.TabIndex = 19
        Me.lblDrinks.Text = "Drinks:"
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSmall.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoSmall.Location = New System.Drawing.Point(4, 11)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(57, 17)
        Me.rdoSmall.TabIndex = 23
        Me.rdoSmall.TabStop = True
        Me.rdoSmall.Text = "Small"
        Me.rdoSmall.UseVisualStyleBackColor = False
        '
        'rdoLarge
        '
        Me.rdoLarge.AutoSize = True
        Me.rdoLarge.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLarge.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoLarge.Location = New System.Drawing.Point(66, 11)
        Me.rdoLarge.Name = "rdoLarge"
        Me.rdoLarge.Size = New System.Drawing.Size(57, 17)
        Me.rdoLarge.TabIndex = 24
        Me.rdoLarge.TabStop = True
        Me.rdoLarge.Text = "Large"
        Me.rdoLarge.UseVisualStyleBackColor = False
        '
        'btnPrevious1
        '
        Me.btnPrevious1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious1.Location = New System.Drawing.Point(47, 523)
        Me.btnPrevious1.Name = "btnPrevious1"
        Me.btnPrevious1.Size = New System.Drawing.Size(298, 23)
        Me.btnPrevious1.TabIndex = 28
        Me.btnPrevious1.Text = "Previous"
        Me.btnPrevious1.UseVisualStyleBackColor = True
        '
        'btnNext2
        '
        Me.btnNext2.Enabled = False
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext2.Location = New System.Drawing.Point(351, 523)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(298, 23)
        Me.btnNext2.TabIndex = 29
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'txtInfoAll
        '
        Me.txtInfoAll.Location = New System.Drawing.Point(436, 208)
        Me.txtInfoAll.Multiline = True
        Me.txtInfoAll.Name = "txtInfoAll"
        Me.txtInfoAll.Size = New System.Drawing.Size(192, 179)
        Me.txtInfoAll.TabIndex = 30
        '
        'lblInfoAll
        '
        Me.lblInfoAll.AutoSize = True
        Me.lblInfoAll.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInfoAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfoAll.Location = New System.Drawing.Point(436, 166)
        Me.lblInfoAll.Name = "lblInfoAll"
        Me.lblInfoAll.Size = New System.Drawing.Size(192, 39)
        Me.lblInfoAll.TabIndex = 31
        Me.lblInfoAll.Text = "Please use this space to indicate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "any special instructions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or allergies..."
        '
        'txtDough
        '
        Me.txtDough.Enabled = False
        Me.txtDough.Location = New System.Drawing.Point(131, 122)
        Me.txtDough.Name = "txtDough"
        Me.txtDough.Size = New System.Drawing.Size(105, 23)
        Me.txtDough.TabIndex = 32
        Me.txtDough.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDrink
        '
        Me.txtDrink.Enabled = False
        Me.txtDrink.Location = New System.Drawing.Point(131, 364)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.Size = New System.Drawing.Size(108, 23)
        Me.txtDrink.TabIndex = 33
        Me.txtDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSauce
        '
        Me.txtSauce.Enabled = False
        Me.txtSauce.Location = New System.Drawing.Point(131, 182)
        Me.txtSauce.Name = "txtSauce"
        Me.txtSauce.Size = New System.Drawing.Size(105, 23)
        Me.txtSauce.TabIndex = 34
        Me.txtSauce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdoCauliflower
        '
        Me.rdoCauliflower.AutoSize = True
        Me.rdoCauliflower.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCauliflower.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoCauliflower.Location = New System.Drawing.Point(103, 12)
        Me.rdoCauliflower.Name = "rdoCauliflower"
        Me.rdoCauliflower.Size = New System.Drawing.Size(89, 17)
        Me.rdoCauliflower.TabIndex = 35
        Me.rdoCauliflower.TabStop = True
        Me.rdoCauliflower.Text = "Cauliflower"
        Me.rdoCauliflower.UseVisualStyleBackColor = False
        '
        'rdoRegular
        '
        Me.rdoRegular.AutoSize = True
        Me.rdoRegular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRegular.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoRegular.Location = New System.Drawing.Point(6, 12)
        Me.rdoRegular.Name = "rdoRegular"
        Me.rdoRegular.Size = New System.Drawing.Size(69, 17)
        Me.rdoRegular.TabIndex = 36
        Me.rdoRegular.TabStop = True
        Me.rdoRegular.Text = "Regular"
        Me.rdoRegular.UseVisualStyleBackColor = False
        '
        'rdoTomato
        '
        Me.rdoTomato.AutoSize = True
        Me.rdoTomato.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTomato.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoTomato.Location = New System.Drawing.Point(4, 12)
        Me.rdoTomato.Name = "rdoTomato"
        Me.rdoTomato.Size = New System.Drawing.Size(67, 17)
        Me.rdoTomato.TabIndex = 37
        Me.rdoTomato.TabStop = True
        Me.rdoTomato.Text = "Tomato"
        Me.rdoTomato.UseVisualStyleBackColor = False
        '
        'rdoRanch
        '
        Me.rdoRanch.AutoSize = True
        Me.rdoRanch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRanch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoRanch.Location = New System.Drawing.Point(103, 12)
        Me.rdoRanch.Name = "rdoRanch"
        Me.rdoRanch.Size = New System.Drawing.Size(60, 17)
        Me.rdoRanch.TabIndex = 38
        Me.rdoRanch.TabStop = True
        Me.rdoRanch.Text = "Ranch"
        Me.rdoRanch.UseVisualStyleBackColor = False
        '
        'rdoAlfredo
        '
        Me.rdoAlfredo.AutoSize = True
        Me.rdoAlfredo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAlfredo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoAlfredo.Location = New System.Drawing.Point(204, 12)
        Me.rdoAlfredo.Name = "rdoAlfredo"
        Me.rdoAlfredo.Size = New System.Drawing.Size(66, 17)
        Me.rdoAlfredo.TabIndex = 39
        Me.rdoAlfredo.TabStop = True
        Me.rdoAlfredo.Text = "Alfredo"
        Me.rdoAlfredo.UseVisualStyleBackColor = False
        '
        'gbxDough
        '
        Me.gbxDough.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxDough.Controls.Add(Me.rdoCauliflower)
        Me.gbxDough.Controls.Add(Me.rdoRegular)
        Me.gbxDough.Location = New System.Drawing.Point(47, 145)
        Me.gbxDough.Name = "gbxDough"
        Me.gbxDough.Size = New System.Drawing.Size(203, 34)
        Me.gbxDough.TabIndex = 40
        Me.gbxDough.TabStop = False
        '
        'gbxSauce
        '
        Me.gbxSauce.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxSauce.Controls.Add(Me.rdoTomato)
        Me.gbxSauce.Controls.Add(Me.rdoRanch)
        Me.gbxSauce.Controls.Add(Me.rdoAlfredo)
        Me.gbxSauce.Location = New System.Drawing.Point(47, 205)
        Me.gbxSauce.Name = "gbxSauce"
        Me.gbxSauce.Size = New System.Drawing.Size(277, 36)
        Me.gbxSauce.TabIndex = 37
        Me.gbxSauce.TabStop = False
        '
        'txtToppings
        '
        Me.txtToppings.Enabled = False
        Me.txtToppings.Location = New System.Drawing.Point(131, 250)
        Me.txtToppings.Name = "txtToppings"
        Me.txtToppings.Size = New System.Drawing.Size(105, 23)
        Me.txtToppings.TabIndex = 41
        Me.txtToppings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdoCheese
        '
        Me.rdoCheese.AutoSize = True
        Me.rdoCheese.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCheese.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoCheese.Location = New System.Drawing.Point(4, 13)
        Me.rdoCheese.Name = "rdoCheese"
        Me.rdoCheese.Size = New System.Drawing.Size(68, 17)
        Me.rdoCheese.TabIndex = 40
        Me.rdoCheese.TabStop = True
        Me.rdoCheese.Text = "Cheese"
        Me.rdoCheese.UseVisualStyleBackColor = False
        '
        'rdoPepperoni
        '
        Me.rdoPepperoni.AutoSize = True
        Me.rdoPepperoni.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPepperoni.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoPepperoni.Location = New System.Drawing.Point(107, 13)
        Me.rdoPepperoni.Name = "rdoPepperoni"
        Me.rdoPepperoni.Size = New System.Drawing.Size(82, 17)
        Me.rdoPepperoni.TabIndex = 42
        Me.rdoPepperoni.TabStop = True
        Me.rdoPepperoni.Text = "Pepperoni"
        Me.rdoPepperoni.UseVisualStyleBackColor = False
        '
        'rdoBacon
        '
        Me.rdoBacon.AutoSize = True
        Me.rdoBacon.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBacon.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoBacon.Location = New System.Drawing.Point(208, 13)
        Me.rdoBacon.Name = "rdoBacon"
        Me.rdoBacon.Size = New System.Drawing.Size(60, 17)
        Me.rdoBacon.TabIndex = 43
        Me.rdoBacon.TabStop = True
        Me.rdoBacon.Text = "Bacon"
        Me.rdoBacon.UseVisualStyleBackColor = False
        '
        'rdoChicken
        '
        Me.rdoChicken.AutoSize = True
        Me.rdoChicken.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChicken.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoChicken.Location = New System.Drawing.Point(3, 36)
        Me.rdoChicken.Name = "rdoChicken"
        Me.rdoChicken.Size = New System.Drawing.Size(71, 17)
        Me.rdoChicken.TabIndex = 44
        Me.rdoChicken.TabStop = True
        Me.rdoChicken.Text = "Chicken"
        Me.rdoChicken.UseVisualStyleBackColor = False
        '
        'rdoBroccoli
        '
        Me.rdoBroccoli.AutoSize = True
        Me.rdoBroccoli.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBroccoli.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoBroccoli.Location = New System.Drawing.Point(107, 36)
        Me.rdoBroccoli.Name = "rdoBroccoli"
        Me.rdoBroccoli.Size = New System.Drawing.Size(70, 17)
        Me.rdoBroccoli.TabIndex = 45
        Me.rdoBroccoli.TabStop = True
        Me.rdoBroccoli.Text = "Broccoli"
        Me.rdoBroccoli.UseVisualStyleBackColor = False
        '
        'rdoHamburger
        '
        Me.rdoHamburger.AutoSize = True
        Me.rdoHamburger.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHamburger.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoHamburger.Location = New System.Drawing.Point(208, 36)
        Me.rdoHamburger.Name = "rdoHamburger"
        Me.rdoHamburger.Size = New System.Drawing.Size(89, 17)
        Me.rdoHamburger.TabIndex = 46
        Me.rdoHamburger.TabStop = True
        Me.rdoHamburger.Text = "Hamburger"
        Me.rdoHamburger.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.rdoCheese)
        Me.GroupBox1.Controls.Add(Me.rdoHamburger)
        Me.GroupBox1.Controls.Add(Me.rdoPepperoni)
        Me.GroupBox1.Controls.Add(Me.rdoBroccoli)
        Me.GroupBox1.Controls.Add(Me.rdoBacon)
        Me.GroupBox1.Controls.Add(Me.rdoChicken)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 63)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.rdoCoke)
        Me.GroupBox2.Controls.Add(Me.rdoAppleJuice)
        Me.GroupBox2.Controls.Add(Me.rdoSprite)
        Me.GroupBox2.Controls.Add(Me.rdoOrangeJuice)
        Me.GroupBox2.Controls.Add(Me.rdoFanta)
        Me.GroupBox2.Controls.Add(Me.rdoGingerAle)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 411)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 63)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'rdoCoke
        '
        Me.rdoCoke.AutoSize = True
        Me.rdoCoke.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCoke.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoCoke.Location = New System.Drawing.Point(4, 13)
        Me.rdoCoke.Name = "rdoCoke"
        Me.rdoCoke.Size = New System.Drawing.Size(55, 17)
        Me.rdoCoke.TabIndex = 40
        Me.rdoCoke.TabStop = True
        Me.rdoCoke.Text = "Coke"
        Me.rdoCoke.UseVisualStyleBackColor = False
        '
        'rdoAppleJuice
        '
        Me.rdoAppleJuice.AutoSize = True
        Me.rdoAppleJuice.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAppleJuice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoAppleJuice.Location = New System.Drawing.Point(208, 36)
        Me.rdoAppleJuice.Name = "rdoAppleJuice"
        Me.rdoAppleJuice.Size = New System.Drawing.Size(89, 17)
        Me.rdoAppleJuice.TabIndex = 46
        Me.rdoAppleJuice.TabStop = True
        Me.rdoAppleJuice.Text = "Apple Juice"
        Me.rdoAppleJuice.UseVisualStyleBackColor = False
        '
        'rdoSprite
        '
        Me.rdoSprite.AutoSize = True
        Me.rdoSprite.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSprite.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoSprite.Location = New System.Drawing.Point(107, 13)
        Me.rdoSprite.Name = "rdoSprite"
        Me.rdoSprite.Size = New System.Drawing.Size(59, 17)
        Me.rdoSprite.TabIndex = 42
        Me.rdoSprite.TabStop = True
        Me.rdoSprite.Text = "Sprite"
        Me.rdoSprite.UseVisualStyleBackColor = False
        '
        'rdoOrangeJuice
        '
        Me.rdoOrangeJuice.AutoSize = True
        Me.rdoOrangeJuice.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOrangeJuice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoOrangeJuice.Location = New System.Drawing.Point(107, 36)
        Me.rdoOrangeJuice.Name = "rdoOrangeJuice"
        Me.rdoOrangeJuice.Size = New System.Drawing.Size(99, 17)
        Me.rdoOrangeJuice.TabIndex = 45
        Me.rdoOrangeJuice.TabStop = True
        Me.rdoOrangeJuice.Text = "Orange Juice"
        Me.rdoOrangeJuice.UseVisualStyleBackColor = False
        '
        'rdoFanta
        '
        Me.rdoFanta.AutoSize = True
        Me.rdoFanta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFanta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoFanta.Location = New System.Drawing.Point(208, 13)
        Me.rdoFanta.Name = "rdoFanta"
        Me.rdoFanta.Size = New System.Drawing.Size(55, 17)
        Me.rdoFanta.TabIndex = 43
        Me.rdoFanta.TabStop = True
        Me.rdoFanta.Text = "Fanta"
        Me.rdoFanta.UseVisualStyleBackColor = False
        '
        'rdoGingerAle
        '
        Me.rdoGingerAle.AutoSize = True
        Me.rdoGingerAle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGingerAle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdoGingerAle.Location = New System.Drawing.Point(3, 36)
        Me.rdoGingerAle.Name = "rdoGingerAle"
        Me.rdoGingerAle.Size = New System.Drawing.Size(85, 17)
        Me.rdoGingerAle.TabIndex = 44
        Me.rdoGingerAle.TabStop = True
        Me.rdoGingerAle.Text = "Ginger Ale"
        Me.rdoGingerAle.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.rdoLarge)
        Me.GroupBox3.Controls.Add(Me.rdoSmall)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 34)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(559, 452)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(69, 23)
        Me.txtSubtotal.TabIndex = 2
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSubtotal
        '
        Me.btnSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubtotal.Location = New System.Drawing.Point(436, 443)
        Me.btnSubtotal.Name = "btnSubtotal"
        Me.btnSubtotal.Size = New System.Drawing.Size(113, 38)
        Me.btnSubtotal.TabIndex = 48
        Me.btnSubtotal.Text = "Click for Subtotal"
        Me.btnSubtotal.UseVisualStyleBackColor = True
        '
        'OrderScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 582)
        Me.Controls.Add(Me.btnSubtotal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtToppings)
        Me.Controls.Add(Me.gbxSauce)
        Me.Controls.Add(Me.gbxDough)
        Me.Controls.Add(Me.txtSauce)
        Me.Controls.Add(Me.txtDrink)
        Me.Controls.Add(Me.txtDough)
        Me.Controls.Add(Me.lblInfoAll)
        Me.Controls.Add(Me.txtInfoAll)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.btnPrevious1)
        Me.Controls.Add(Me.lblDrinks)
        Me.Controls.Add(Me.lblToppings)
        Me.Controls.Add(Me.lblSauce)
        Me.Controls.Add(Me.lblDough)
        Me.Controls.Add(Me.lblBuild)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnShape2)
        Me.Name = "OrderScreen"
        Me.Text = "OrderScreen"
        Me.gbxDough.ResumeLayout(False)
        Me.gbxDough.PerformLayout()
        Me.gbxSauce.ResumeLayout(False)
        Me.gbxSauce.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShape2 As Button
    Friend WithEvents lblBuild As Label
    Friend WithEvents lblDough As Label
    Friend WithEvents lblSauce As Label
    Friend WithEvents lblToppings As Label
    Friend WithEvents lblDrinks As Label
    Friend WithEvents rdoSmall As RadioButton
    Friend WithEvents rdoLarge As RadioButton
    Friend WithEvents btnPrevious1 As Button
    Friend WithEvents btnNext2 As Button
    Friend WithEvents txtInfoAll As TextBox
    Friend WithEvents lblInfoAll As Label
    Friend WithEvents txtDough As TextBox
    Friend WithEvents txtDrink As TextBox
    Friend WithEvents txtSauce As TextBox
    Friend WithEvents rdoCauliflower As RadioButton
    Friend WithEvents rdoRegular As RadioButton
    Friend WithEvents rdoTomato As RadioButton
    Friend WithEvents rdoRanch As RadioButton
    Friend WithEvents rdoAlfredo As RadioButton
    Friend WithEvents gbxDough As GroupBox
    Friend WithEvents gbxSauce As GroupBox
    Friend WithEvents txtToppings As TextBox
    Friend WithEvents rdoCheese As RadioButton
    Friend WithEvents rdoPepperoni As RadioButton
    Friend WithEvents rdoBacon As RadioButton
    Friend WithEvents rdoChicken As RadioButton
    Friend WithEvents rdoBroccoli As RadioButton
    Friend WithEvents rdoHamburger As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoCoke As RadioButton
    Friend WithEvents rdoAppleJuice As RadioButton
    Friend WithEvents rdoSprite As RadioButton
    Friend WithEvents rdoOrangeJuice As RadioButton
    Friend WithEvents rdoFanta As RadioButton
    Friend WithEvents rdoGingerAle As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents btnSubtotal As Button
End Class
