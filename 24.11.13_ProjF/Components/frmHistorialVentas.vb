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

    Private Function elegirCli() As Integer
        Dim input As String
        Dim id_cliente As Integer
        Dim validInput As Boolean = False

        Do
            input = InputBox("Indique el N° de identificación del cliente", "Ventas por Cliente")

            If String.IsNullOrWhiteSpace(input) Then
                MessageBox.Show("El proceso ha sido cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return -1
            End If

            If Integer.TryParse(input, id_cliente) AndAlso id_cliente > 0 Then
                validInput = True
            Else
                MessageBox.Show("Por favor ingrese un número entero válido mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Loop While Not validInput

        Return id_cliente
    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        desplegar(Me)
    End Sub

    Private Sub btnVentasxFecha_Click(sender As Object, e As EventArgs) Handles btnVentasxFecha.Click
        Dim frm As New frmElegirFechas
        frm.Show()
    End Sub

    Private Sub btnVentasCli_Click(sender As Object, e As EventArgs) Handles btnVentasCli.Click
        Dim clienteId As Integer = elegirCli()

        If clienteId <> -1 Then
            wCliente = clienteId
            Dim frm As New frmVentasCli
            frm.Show()
        Else
            MessageBox.Show("No se ha seleccionado un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class