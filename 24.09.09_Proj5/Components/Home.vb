Public Class Home
    Private Sub btnSucursales_Click(sender As Object, e As EventArgs) Handles btnSucursales.Click
        Dim frm As New frmSucursales
        frm.ShowDialog()
    End Sub

    Private Sub btnVendedores_Click(sender As Object, e As EventArgs) Handles btnVendedores.Click
        Dim frm As New frmVendedores
        frm.ShowDialog()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim frm As New frmVentas
        frm.ShowDialog()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub
End Class