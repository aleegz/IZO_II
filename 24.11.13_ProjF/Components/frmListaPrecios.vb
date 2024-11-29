Public Class frmListaPrecios
    Private Sub frmListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tienda_ropaDataSet1.spu_lista_precios' Puede moverla o quitarla según sea necesario.
        Me.Spu_lista_preciosTableAdapter.Fill(Me.Tienda_ropaDataSet1.spu_lista_precios)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class