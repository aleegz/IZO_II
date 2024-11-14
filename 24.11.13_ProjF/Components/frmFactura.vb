Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Diagnostics.Internal
Public Class frmFactura
    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim input = InputBox("Indique el N° de identificación de la venta")

        Dim reporteDataSet1 As New DataTable
        Dim reporteDataSet2 As New DataTable
        Dim id_venta As Integer = CInt(input)

        Using command1 As New SqlCommand("spu_factura", conexion.conexion)
            command1.CommandType = CommandType.StoredProcedure
            command1.Parameters.AddWithValue("@id_venta", input)
            Using adapter As New SqlDataAdapter(command1)
                adapter.Fill(reporteDataSet1)
            End Using
        End Using

        Using command2 As New SqlCommand("spu_detalle_factura", conexion.conexion)
            command2.CommandType = CommandType.StoredProcedure
            command2.Parameters.AddWithValue("@id_venta", input)
            Using adapter As New SqlDataAdapter(command2)
                adapter.Fill(reporteDataSet2)
            End Using
        End Using

        Dim datasource1 As New ReportDataSource("DataSetFactura", reporteDataSet1)
        Dim datasource2 As New ReportDataSource("DataSetDetalleFactura", reporteDataSet2)

        rptFactura.LocalReport.DataSources.Clear()
        rptFactura.LocalReport.DataSources.Add(datasource1)
        rptFactura.LocalReport.DataSources.Add(datasource2)

        Dim parametroReporte1 As New ReportParameter("id_venta", input.ToString())
        rptFactura.LocalReport.SetParameters(New ReportParameter() {parametroReporte1})

        Me.rptFactura.RefreshReport()
    End Sub
End Class