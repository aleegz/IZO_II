Public Class Frm_conc
    Private Sub Btn_conc_Click(sender As Object, e As EventArgs) Handles Btn_conc.Click
        result.Text = SavedUsername + " " + Value1.Text
    End Sub

    Private Sub Frm_conc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = SavedUsername
    End Sub
End Class