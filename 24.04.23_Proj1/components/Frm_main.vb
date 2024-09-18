Public Class Frm_main

    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = SavedUsername
    End Sub
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Frm_calc.Show()
    End Sub

    Private Sub BtnConc_Click(sender As Object, e As EventArgs) Handles BtnConc.Click
        Frm_conc.Show()
    End Sub
End Class