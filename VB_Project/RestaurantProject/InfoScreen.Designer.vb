<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoScreen))
        Me.btnShape1 = New System.Windows.Forms.Button()
        Me.lblTYFC = New System.Windows.Forms.Label()
        Me.lblPIYAB = New System.Windows.Forms.Label()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShape1
        '
        Me.btnShape1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnShape1.Enabled = False
        Me.btnShape1.Location = New System.Drawing.Point(83, 39)
        Me.btnShape1.Name = "btnShape1"
        Me.btnShape1.Size = New System.Drawing.Size(366, 351)
        Me.btnShape1.TabIndex = 0
        Me.btnShape1.UseVisualStyleBackColor = False
        '
        'lblTYFC
        '
        Me.lblTYFC.AutoSize = True
        Me.lblTYFC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTYFC.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTYFC.Location = New System.Drawing.Point(157, 76)
        Me.lblTYFC.Name = "lblTYFC"
        Me.lblTYFC.Size = New System.Drawing.Size(205, 18)
        Me.lblTYFC.TabIndex = 1
        Me.lblTYFC.Text = "Thank You For Choosing"
        '
        'lblPIYAB
        '
        Me.lblPIYAB.AutoSize = True
        Me.lblPIYAB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPIYAB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPIYAB.Location = New System.Drawing.Point(95, 164)
        Me.lblPIYAB.Name = "lblPIYAB"
        Me.lblPIYAB.Size = New System.Drawing.Size(290, 16)
        Me.lblPIYAB.TabIndex = 3
        Me.lblPIYAB.Text = "Plese input your name and address bellow:"
        '
        'lblPP
        '
        Me.lblPP.AutoSize = True
        Me.lblPP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPP.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPP.Location = New System.Drawing.Point(139, 94)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(277, 32)
        Me.lblPP.TabIndex = 2
        Me.lblPP.Text = "Alfredo's Pizzeria"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(181, 225)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(245, 23)
        Me.txtAddress.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(181, 258)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(245, 23)
        Me.txtCity.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(181, 196)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(245, 23)
        Me.txtName.TabIndex = 1
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(181, 287)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(245, 23)
        Me.txtState.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(98, 196)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 18)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.Location = New System.Drawing.Point(98, 225)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(73, 18)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCity.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCity.Location = New System.Drawing.Point(98, 258)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(40, 18)
        Me.lblCity.TabIndex = 10
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblState.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblState.Location = New System.Drawing.Point(98, 287)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(52, 18)
        Me.lblState.TabIndex = 11
        Me.lblState.Text = "State"
        '
        'btnNext1
        '
        Me.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext1.Location = New System.Drawing.Point(98, 338)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(328, 23)
        Me.btnNext1.TabIndex = 12
        Me.btnNext1.Text = "Next"
        Me.btnNext1.UseVisualStyleBackColor = True
        '
        'InfoScreen
        '
        Me.AcceptButton = Me.btnNext1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(535, 433)
        Me.Controls.Add(Me.btnNext1)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblPIYAB)
        Me.Controls.Add(Me.lblPP)
        Me.Controls.Add(Me.lblTYFC)
        Me.Controls.Add(Me.btnShape1)
        Me.Name = "InfoScreen"
        Me.Text = "Delivery Information Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShape1 As Button
    Friend WithEvents lblTYFC As Label
    Friend WithEvents lblPIYAB As Label
    Friend WithEvents lblPP As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents btnNext1 As Button
End Class
