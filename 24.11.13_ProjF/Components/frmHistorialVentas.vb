Public Class frmHistorialVentas
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarVentas()
    End Sub

    'Llenar ventas en datagridview
    Private Sub llenarVentas()
        Dim sql As String = "SELECT * FROM ventas"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("ventas")
        adp.Fill(ds.Tables("ventas"))
        Me.dgvVentas.DataSource = ds.Tables("ventas")
    End Sub

    Private Function elegirCli()
        Dim input = InputBox("Indique el N° de identificación del cliente")
        wCliente = input
    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        desplegar(Me)
    End Sub

    Private Sub btnVentasxFecha_Click(sender As Object, e As EventArgs) Handles btnVentasxFecha.Click
        Dim frm As New frmElegirFechas
        frm.Show()
    End Sub

    Private Sub btnVentasCli_Click(sender As Object, e As EventArgs) Handles btnVentasCli.Click
        elegirCli()
        Dim frm As New frmVentasCli
        frm.Show()
    End Sub

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick

    End Sub
End Class