Public Class frmVentasFecha

    'Llenar ventas en datagridview
    Private Sub llenarVentas()
        Dim sql As String = "EXEC spu_ventas_fecha '" & wFechaDesde & "', '" & wFechaHasta & "'"
        'Dim sql As String = $"EXEC spu_ventas_fecha {wFechaDesde}, {wFechaHasta}"
        'Dim sql As String = $"EXEC spu_ventas_fecha " & $"{wFechaDesde}" & "," & $"{wFechaHasta}"


        MsgBox(sql)
        cmd.CommandText = sql
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("ventas")
        adp.Fill(ds.Tables("ventas"))
        Me.dgvVentas.DataSource = ds.Tables("ventas")
    End Sub
    Private Sub frmVentasFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarVentas()
    End Sub
End Class