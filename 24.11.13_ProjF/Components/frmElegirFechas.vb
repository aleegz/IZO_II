Public Class frmElegirFechas
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        wFechaDesde = DateFechaDesde.Value.Date.ToShortDateString
        wFechaHasta = DateFechaHasta.Value.Date.ToShortDateString
        frmVentasFecha.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class