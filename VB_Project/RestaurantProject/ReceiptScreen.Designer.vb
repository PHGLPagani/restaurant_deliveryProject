<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceiptScreen))
        Me.btnShape3 = New System.Windows.Forms.Button()
        Me.btnShape4 = New System.Windows.Forms.Button()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSubtotal2 = New System.Windows.Forms.Label()
        Me.txtSubtotal2 = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnPO = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrevious2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShape3
        '
        Me.btnShape3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnShape3.Enabled = False
        Me.btnShape3.Location = New System.Drawing.Point(34, 54)
        Me.btnShape3.Name = "btnShape3"
        Me.btnShape3.Size = New System.Drawing.Size(192, 368)
        Me.btnShape3.TabIndex = 0
        Me.btnShape3.UseVisualStyleBackColor = False
        '
        'btnShape4
        '
        Me.btnShape4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnShape4.Enabled = False
        Me.btnShape4.Location = New System.Drawing.Point(257, 54)
        Me.btnShape4.Name = "btnShape4"
        Me.btnShape4.Size = New System.Drawing.Size(365, 442)
        Me.btnShape4.TabIndex = 1
        Me.btnShape4.UseVisualStyleBackColor = False
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblThanks.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblThanks.Location = New System.Drawing.Point(275, 73)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(334, 17)
        Me.lblThanks.TabIndex = 2
        Me.lblThanks.Text = "Thank You For Choosing Pedro's Pizzeria!"
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReceipt.Location = New System.Drawing.Point(271, 104)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(143, 16)
        Me.lblReceipt.TabIndex = 3
        Me.lblReceipt.Text = "Here is your receipt:"
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 14
        Me.lstReceipt.Location = New System.Drawing.Point(271, 123)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(338, 326)
        Me.lstReceipt.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(271, 455)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(338, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSubtotal2
        '
        Me.lblSubtotal2.AutoSize = True
        Me.lblSubtotal2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSubtotal2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtotal2.Location = New System.Drawing.Point(53, 78)
        Me.lblSubtotal2.Name = "lblSubtotal2"
        Me.lblSubtotal2.Size = New System.Drawing.Size(81, 18)
        Me.lblSubtotal2.TabIndex = 6
        Me.lblSubtotal2.Text = "Subtotal"
        '
        'txtSubtotal2
        '
        Me.txtSubtotal2.Enabled = False
        Me.txtSubtotal2.Location = New System.Drawing.Point(140, 73)
        Me.txtSubtotal2.Name = "txtSubtotal2"
        Me.txtSubtotal2.Size = New System.Drawing.Size(61, 23)
        Me.txtSubtotal2.TabIndex = 7
        Me.txtSubtotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTax.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTax.Location = New System.Drawing.Point(53, 104)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(42, 18)
        Me.lblTax.TabIndex = 8
        Me.lblTax.Text = "Tax"
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(140, 99)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(61, 23)
        Me.txtTax.TabIndex = 9
        Me.txtTax.Text = "6.25%"
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(53, 332)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 18)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(140, 327)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(61, 23)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPO
        '
        Me.btnPO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPO.Location = New System.Drawing.Point(53, 381)
        Me.btnPO.Name = "btnPO"
        Me.btnPO.Size = New System.Drawing.Size(148, 26)
        Me.btnPO.TabIndex = 14
        Me.btnPO.Text = "Place Order"
        Me.btnPO.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(34, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 51)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnPrevious2
        '
        Me.btnPrevious2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious2.Location = New System.Drawing.Point(53, 457)
        Me.btnPrevious2.Name = "btnPrevious2"
        Me.btnPrevious2.Size = New System.Drawing.Size(148, 26)
        Me.btnPrevious2.TabIndex = 16
        Me.btnPrevious2.Text = "Previous"
        Me.btnPrevious2.UseVisualStyleBackColor = True
        '
        'ReceiptScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(675, 560)
        Me.Controls.Add(Me.btnPrevious2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPO)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtSubtotal2)
        Me.Controls.Add(Me.lblSubtotal2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.lblReceipt)
        Me.Controls.Add(Me.lblThanks)
        Me.Controls.Add(Me.btnShape4)
        Me.Controls.Add(Me.btnShape3)
        Me.Name = "ReceiptScreen"
        Me.Text = "ReceiptScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShape3 As Button
    Friend WithEvents btnShape4 As Button
    Friend WithEvents lblThanks As Label
    Friend WithEvents lblReceipt As Label
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblSubtotal2 As Label
    Friend WithEvents txtSubtotal2 As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnPO As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPrevious2 As Button
End Class
