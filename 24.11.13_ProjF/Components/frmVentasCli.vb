Public Class frmVentasCli

    'Llenar ventas por cliente en datagridview
    Private Sub llenarVentasCli()
        Dim sql As String = $"EXEC spu_ventas_cliente {wCliente}"
        MsgBox(sql)
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("ventas")
        adp.Fill(ds.Tables("ventas"))
        Me.dgvVentasCli.DataSource = ds.Tables("ventas")
    End Sub

    Private Sub frmVentasCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarVentasCli()
    End Sub
End Class