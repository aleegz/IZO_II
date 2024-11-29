Imports System.Data.SqlClient


Public Class frmCrearVenta

    Private cmd As New SqlCommand()
    Private ventaEstaCreada As Boolean = False
    Private importeTotal As Decimal = 0


    'Llenar detalle en datagridview
    Private Sub llenarDetalle()
        Dim sql As String = "SELECT * FROM detalle_ventas WHERE id_venta = " & CInt(Me.LabelVenta.Text) & ""
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("detalles")
        adp.Fill(ds.Tables("detalles"))
        Me.dgvDetalle.DataSource = ds.Tables("detalles")
    End Sub

    Private Sub finalizarVenta()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE ventas SET importe = {CInt(importeTotal)} WHERE id_venta = {CInt(Me.LabelVenta.Text)}"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub frmCrearVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Cargar formas de pago
        Try
            Dim sql As String = "SELECT descrip_forma_pago FROM formas_pago"
            cmd.CommandText = sql

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cbFormaPago.Items.Add(reader("descrip_forma_pago").ToString()) ' Agregar sin vbCrLf
                End While
            End Using

            'MsgBox("Consulta realizada con éxito")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Me.txtId.Text = ObtenerUltimoID("id_cliente", "clientes")
        Me.LabelFecha.Text = DateTime.Now.Date
        Me.LabelVenta.Text = ObtenerUltimoID("id_venta", "ventas")
    End Sub

    Private Function crearVenta()
        ventaEstaCreada = True
        Dim nueva As New ventas
        Dim inputsValidos As Boolean = True
        If Not IsNumeric(CInt(Me.LabelVenta.Text)) Then
            MessageBox.Show("Valor no válido en ID de Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.LabelFecha.Text) Then
            MessageBox.Show("Valor no válido en Fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtId.Text) Then
            MessageBox.Show("Valor no válido en campo ID Identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtId.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(CInt(Me.cbFormaPago.SelectedIndex)) Then
            MessageBox.Show("Valor no válido en campo Forma de Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbFormaPago.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nueva.id_venta = CInt(ObtenerUltimoID("id_venta", "ventas"))
        nueva.fecha = DateTime.Now.Date.ToShortDateString()
        nueva.id_cliente = CInt(Me.txtId.Text)
        nueva.id_forma_pago = (Me.cbFormaPago.SelectedIndex + 1)
        nueva.importe = 0

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"EXEC spu_venta {nueva.id_venta}, '{nueva.fecha}', {nueva.id_cliente}, {nueva.id_forma_pago}, {nueva.importe}"
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Private Function agregarProducto() As Boolean
        Dim nueva As New detalle_ventas
        Dim inputsValidos As Boolean = True

        ' Validaciones de los campos
        If Not IsNumeric(Me.txtCod.Text) Then
            MessageBox.Show("Valor no válido en campo Código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCod.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtTal.Text) Then
            MessageBox.Show("Valor no válido en campo Talle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtTal.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtColor.Text) Then
            MessageBox.Show("Valor no válido en campo Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtColor.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtPrUn.Text) Then
            MessageBox.Show("Valor no válido en campo Precio Unitario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtPrUn.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtCant.Text) Then
            MessageBox.Show("Valor no válido en campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCant.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nueva.id_venta = CInt(Me.LabelVenta.Text)
        nueva.codigo = CInt(Me.txtCod.Text)
        nueva.talle = Me.txtTal.Text.Trim()
        nueva.color = Me.txtColor.Text.Trim()
        nueva.precio = CInt(Me.txtPrUn.Text)
        nueva.cantidad = CInt(Me.txtCant.Text)
        nueva.precio_r = CInt(Me.LabelSubTotal.Text)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        ' Verificar si ya existe un detalle con el mismo producto y venta
        Dim sqlCheck As String = $"SELECT COUNT(*) FROM detalle_ventas WHERE id_venta = {nueva.id_venta} AND codigo = {nueva.codigo} AND talle = '{nueva.talle}' AND color = '{nueva.color}'"
        cmd.CommandText = sqlCheck

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If count > 0 Then
            ' Si ya existe, hacer un UPDATE sumando la cantidad
            Dim sqlUpdate As String = $"UPDATE detalle_ventas SET cantidad = cantidad + {nueva.cantidad} WHERE id_venta = {nueva.id_venta} AND codigo = {nueva.codigo} AND talle = '{nueva.talle}' AND color = '{nueva.color}'"
            cmd.CommandText = sqlUpdate
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Cantidad actualizada correctamente.")
                Return True
            Catch ex As Exception
                MsgBox("Error al actualizar la cantidad: " & ex.ToString())
                Return False
            End Try
        Else
            ' Si no existe, hacer un INSERT
            Dim sqlInsert As String = $"EXEC spu_detalle_venta {nueva.id_venta}, {nueva.codigo}, '{nueva.talle}', '{nueva.color}', {nueva.precio}, {nueva.cantidad}, {nueva.precio_r}"
            cmd.CommandText = sqlInsert
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Producto agregado al detalle.")
                Return True
            Catch ex As Exception
                MsgBox("Error al agregar producto: " & ex.ToString())
                Return False
            End Try
        End If
    End Function


    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New frmClientes

        frm.Size = New Size(770, 580)

        Me.AddOwnedForm(frm)
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
        frm.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frm As New frmElegirPrenda
        Me.AddOwnedForm(frm)
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
        frm.ShowDialog()
    End Sub

    Private Sub txtCant_TextChanged(sender As Object, e As EventArgs) Handles txtCant.TextChanged
        If txtCant.Text = "" Then
            txtCant.BackColor = SystemColors.ScrollBar
        Else
            Dim subtotal = wPrecio * CDec(txtCant.Text())
            LabelSubTotal.Text = subtotal
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.ventaEstaCreada = False Then
            crearVenta()
        End If
        agregarProducto()
        llenarDetalle()
        txtCod.Clear()
        txtTal.Clear()
        txtColor.Clear()
        txtPrUn.Clear()
        txtDescrip.Clear()
        txtCant.Clear()
        LabelSubTotal.Text = 0
        txtId.Enabled = False
        btnClientes.Enabled = False
        txtRS.Enabled = False
        txtTel.Enabled = False
        cbFormaPago.Enabled = False

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"EXEC spu_importeTotal {CInt(LabelVenta.Text)}"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            importeTotal = (cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        LabelTotal.Text = importeTotal
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"EXEC spu_cancelarVenta {CInt(LabelVenta.Text)}"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        Me.Close()
    End Sub

    Private Sub dgvDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellValueChanged
        MsgBox("Pantalla actualizada")
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"EXEC spu_importeTotal {CInt(LabelVenta.Text)}"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox(CDec(cmd.ToString))
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        'LabelTotal.Text = importeTotal
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        finalizarVenta()
        MsgBox($"Venta creada con éxito, importe total ${importeTotal}")
        Me.Close()
    End Sub
End Class