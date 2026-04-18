Public Class Form1
    ' Глобальная переменная для накопления общей суммы заказа
    Dim totalOrderSum As Double = 0

    ' Обработчик кнопки "Посчитать выбор"
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim price As Double = 0
            Dim quantity As Integer = 0
            Dim subTotal As Double = 0
            Dim tax As Double = 0

            ' 1. Определение цены в зависимости от выбранного RadioButton
            If rbWhite.Checked Then
                price = 50 ' Цена за Белое
            ElseIf rbChoco.Checked Then
                price = 60 ' Цена за Шоколадное
            ElseIf rbVanilla.Checked Then
                price = 55 ' Цена за Ванильное
            ElseIf rbCreme.Checked Then
                price = 65 ' Цена за Крем-Брюле
            End If

            ' 2. Чтение количества и расчет
            If Integer.TryParse(txtQuantity.Text, quantity) Then
                subTotal = price * quantity

                ' 3. Расчет налога, если выбрано "С собой" (например, 10% за упаковку)
                If chkTakeAway.Checked Then
                    tax = subTotal * 0.1
                End If

                ' 4. Обновление итогов
                totalOrderSum += (subTotal + tax)

                ' 5. Вывод данных в текстовые поля
                txtPrice.Text = price.ToString("F2")
                txtSubTotal.Text = subTotal.ToString("F2")
                txtTax.Text = tax.ToString("F2")
                txtTotalSum.Text = totalOrderSum.ToString("F2")
            Else
                MessageBox.Show("Пожалуйста, введите корректное количество.", "Ошибка ввода")
            End If
        Catch ex As Exception
            MessageBox.Show("Произошла ошибка при расчете: " & ex.Message)
        End Try
    End Sub

    ' Очистка полей для ввода следующей позиции мороженого
    Private Sub btnClearSelection_Click(sender As Object, e As EventArgs) Handles btnClearSelection.Click
        txtQuantity.Clear()
        txtPrice.Clear()
        txtSubTotal.Clear()
        txtTax.Clear()
        ' Сброс RadioButtons
        rbWhite.Checked = False
        rbChoco.Checked = False
        rbVanilla.Checked = False
        rbCreme.Checked = False
    End Sub

    ' Сброс всего заказа (Новый заказ)
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        totalOrderSum = 0
        txtTotalSum.Text = "0"
        btnClearSelection_Click(sender, e)
    End Sub

    ' Выход из программы
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class