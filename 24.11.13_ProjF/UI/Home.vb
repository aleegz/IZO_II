Public Class Home
    Public Sub AbrirFrm(FormHijo As Form)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        FormHijo.TopLevel = False
        Me.PanelContenedor.Controls.Add(FormHijo)
        Me.PanelContenedor.Tag = FormHijo
        FormHijo.Show()
    End Sub

    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        AbrirFrm(New frmMarcas)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrendas_Click(sender As Object, e As EventArgs) Handles btnPrendas.Click
        AbrirFrm(New frmPrendas)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFrm(New frmHistorialVentas)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        AbrirFrm(New frmCrearVenta)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFrm(New frmClientes)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        AbrirFrm(New frmFactura)
    End Sub

    Private Sub btnFormasPago_Click(sender As Object, e As EventArgs) Handles btnFormasPago.Click
        AbrirFrm(New frmFormasPago)
    End Sub
End Class