<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCreme = New System.Windows.Forms.RadioButton()
        Me.rbVanilla = New System.Windows.Forms.RadioButton()
        Me.rbChoco = New System.Windows.Forms.RadioButton()
        Me.rbWhite = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotalSum = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClearSelection = New System.Windows.Forms.Button()
        Me.chkTakeAway = New System.Windows.Forms.CheckBox()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCreme)
        Me.GroupBox1.Controls.Add(Me.rbVanilla)
        Me.GroupBox1.Controls.Add(Me.rbChoco)
        Me.GroupBox1.Controls.Add(Me.rbWhite)
        Me.GroupBox1.Location = New System.Drawing.Point(534, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сорты"
        '
        'rbCreme
        '
        Me.rbCreme.AutoSize = True
        Me.rbCreme.Location = New System.Drawing.Point(20, 185)
        Me.rbCreme.Name = "rbCreme"
        Me.rbCreme.Size = New System.Drawing.Size(169, 29)
        Me.rbCreme.TabIndex = 3
        Me.rbCreme.TabStop = True
        Me.rbCreme.Text = "Крем-Брюле"
        Me.rbCreme.UseVisualStyleBackColor = True
        '
        'rbVanilla
        '
        Me.rbVanilla.AutoSize = True
        Me.rbVanilla.Location = New System.Drawing.Point(20, 138)
        Me.rbVanilla.Name = "rbVanilla"
        Me.rbVanilla.Size = New System.Drawing.Size(152, 29)
        Me.rbVanilla.TabIndex = 2
        Me.rbVanilla.TabStop = True
        Me.rbVanilla.Text = "Ванильное"
        Me.rbVanilla.UseVisualStyleBackColor = True
        '
        'rbChoco
        '
        Me.rbChoco.AutoSize = True
        Me.rbChoco.Location = New System.Drawing.Point(20, 92)
        Me.rbChoco.Name = "rbChoco"
        Me.rbChoco.Size = New System.Drawing.Size(168, 29)
        Me.rbChoco.TabIndex = 1
        Me.rbChoco.TabStop = True
        Me.rbChoco.Text = "Шоколадное"
        Me.rbChoco.UseVisualStyleBackColor = True
        '
        'rbWhite
        '
        Me.rbWhite.AutoSize = True
        Me.rbWhite.Location = New System.Drawing.Point(20, 47)
        Me.rbWhite.Name = "rbWhite"
        Me.rbWhite.Size = New System.Drawing.Size(105, 29)
        Me.rbWhite.TabIndex = 0
        Me.rbWhite.TabStop = True
        Me.rbWhite.Text = "Белое"
        Me.rbWhite.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Мороженое"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Количество"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(206, 69)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 31)
        Me.txtQuantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Стоимость"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(260, 235)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 31)
        Me.txtPrice.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Сумма"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Налог (если с собой)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Общая сумма"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(260, 287)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 31)
        Me.txtSubTotal.TabIndex = 9
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(260, 337)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 31)
        Me.txtTax.TabIndex = 10
        '
        'txtTotalSum
        '
        Me.txtTotalSum.Location = New System.Drawing.Point(260, 387)
        Me.txtTotalSum.Name = "txtTotalSum"
        Me.txtTotalSum.Size = New System.Drawing.Size(100, 31)
        Me.txtTotalSum.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 119)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(202, 45)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Посчитать выбор"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClearSelection
        '
        Me.btnClearSelection.Location = New System.Drawing.Point(220, 119)
        Me.btnClearSelection.Name = "btnClearSelection"
        Me.btnClearSelection.Size = New System.Drawing.Size(296, 45)
        Me.btnClearSelection.TabIndex = 13
        Me.btnClearSelection.Text = "Очистить для след. выбора"
        Me.btnClearSelection.UseVisualStyleBackColor = True
        '
        'chkTakeAway
        '
        Me.chkTakeAway.AutoSize = True
        Me.chkTakeAway.Location = New System.Drawing.Point(139, 181)
        Me.chkTakeAway.Name = "chkTakeAway"
        Me.chkTakeAway.Size = New System.Drawing.Size(124, 29)
        Me.chkTakeAway.TabIndex = 14
        Me.chkTakeAway.Text = "С собой"
        Me.chkTakeAway.UseVisualStyleBackColor = True
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(441, 299)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(184, 50)
        Me.btnNewOrder.TabIndex = 15
        Me.btnNewOrder.Text = "Новый заказ"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(441, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(184, 48)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Выход"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.chkTakeAway)
        Me.Controls.Add(Me.btnClearSelection)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotalSum)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCreme As RadioButton
    Friend WithEvents rbVanilla As RadioButton
    Friend WithEvents rbChoco As RadioButton
    Friend WithEvents rbWhite As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTotalSum As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClearSelection As Button
    Friend WithEvents chkTakeAway As CheckBox
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnExit As Button
End Class
