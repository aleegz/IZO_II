Public Class frmElegirPrenda
    Private Sub frmElegirPrenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarPrendas()
    End Sub

    'Llenar prendas en datagridview
    Private Sub llenarPrendas()
        Dim sql As String = "EXEC spu_detalle_prenda"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("prendas")
        adp.Fill(ds.Tables("prendas"))
        Me.dgvElegir.DataSource = ds.Tables("prendas")
    End Sub

    Private Sub dgvElegir_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvElegir.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Agregar dueño
            Dim frm As frmCrearVenta = CType(Owner, frmCrearVenta)
            wPrecio = Me.dgvElegir.CurrentRow.Cells(3).Value.ToString()
            frm.txtCod.Text = Me.dgvElegir.CurrentRow.Cells(0).Value.ToString()
            frm.txtTal.Text = Me.dgvElegir.CurrentRow.Cells(1).Value.ToString()
            frm.txtColor.Text = Me.dgvElegir.CurrentRow.Cells(2).Value.ToString()
            frm.txtPrUn.Text = Me.dgvElegir.CurrentRow.Cells(3).Value.ToString()
            frm.txtDescrip.Text = Me.dgvElegir.CurrentRow.Cells(4).Value.ToString()
            Me.Close()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class