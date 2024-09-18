Public Class frmVentasLoc
    Private Sub frmVentasLoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarVentaPorLocalidad()
    End Sub

    'Llenar ventas por localidad en datagridview
    Private Sub llenarVentaPorLocalidad()
        Dim sql As String = "EXEC spu_ventas_localidad"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("ventasLoc")
        adp.Fill(ds.Tables("ventasLoc"))
        Me.dgvVentasLoc.DataSource = ds.Tables("ventasLoc")
    End Sub
End Class