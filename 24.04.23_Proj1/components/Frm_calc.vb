Public Class Frm_calc

    Function IsNum(Value1, Value2) As Decimal
        Return IsNumeric(Value1.Text) And IsNumeric(Value2.Text)
    End Function

    Private Sub Frm_calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = SavedUsername
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_sum.Click
        If IsNum(Value1, Value2) = False Then
            MsgBox("Ingresa un valor válido para continuar")
            limpiar()
        Else
            result.Text = (Convert.ToDecimal(Value1.Text) + Convert.ToDecimal(Value2.Text))
        End If
    End Sub

    Private Sub Btn_res_Click(sender As Object, e As EventArgs) Handles Btn_res.Click
        If IsNum(Value1, Value2) = False Then
            MsgBox("Ingresa un valor válido para continuar")
            limpiar()
        Else
            result.Text = (Convert.ToDecimal(Value1.Text) - Convert.ToDecimal(Value2.Text))
        End If
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs) Handles Btn_div.Click
        If IsNum(Value1, Value2) = False Then
            MsgBox("Ingresa un valor válido para continuar")
            limpiar()
        Else
            result.Text = (Convert.ToDecimal(Value1.Text) / Convert.ToDecimal(Value2.Text))
        End If
    End Sub

    Private Sub Btn_mult_Click(sender As Object, e As EventArgs) Handles Btn_mult.Click
        If IsNum(Value1, Value2) = False Then
            MsgBox("Ingresa un valor válido para continuar")
            limpiar()
        Else
            result.Text = (Convert.ToDecimal(Value1.Text) * Convert.ToDecimal(Value2.Text))
        End If
    End Sub

    Private Sub Btn_clear_Click_1(sender As Object, e As EventArgs) Handles Btn_clear.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        Value1.Text = ""
        Value2.Text = ""
        result.Text = ""
        Value1.Focus()
    End Sub
End Class