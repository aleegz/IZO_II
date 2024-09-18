Public Class frmVentas

    'Variable acción a realizar
    Dim action As String

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarVentas()
    End Sub

    'Llenar ventas en datagridview
    Private Sub llenarVentas()
        Dim sql As String = "EXEC spu_mostrar_ventas"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("ventas")
        adp.Fill(ds.Tables("ventas"))
        Me.dgvVentas.DataSource = ds.Tables("ventas")
    End Sub


    Private Function agregarVenta()
        Dim nueva As New ventas

        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtIdVenta.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdVenta.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtImporte.Text) Then
            MessageBox.Show("Valor no válido en campo Importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtImporte.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtIdVendedor.Text) Then
            MessageBox.Show("Valor no válido en campo Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdVendedor.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nueva.id_venta = CInt(Me.txtIdVenta.Text)
        nueva.fecha = CDate(Me.dtpFecha.Text)
        nueva.importe = CDec(Me.txtImporte.Text)
        nueva.id_vendedor = CInt(Me.txtIdVendedor.Text)
        'MsgBox(nueva.id_venta.ToString + " " + nueva.fecha + " " + nueva.importe.ToString + " " + nueva.id_vendedor.ToString)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_venta " & nueva.id_venta & ", '" & nueva.fecha & "'," & $"'{nueva.importe}'" & "," & nueva.id_vendedor & ""
        cmd.CommandText = sql
        MsgBox("Se dará de alta la venta: " & nueva.id_venta & ", " & nueva.fecha & ", " & nueva.importe & ", " & nueva.id_vendedor & "")

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Venta registrada con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Eliminar sucursales
    Private Sub eliminarVenta()
        Dim eliminar As New ventas
        eliminar.id_venta = Me.dgvVentas.CurrentRow.Cells(0).Value
        'MsgBox(eliminar.id_venta)
        Dim sql As String = "EXEC spu_eliminar_venta " & eliminar.id_venta & ""
        cmd.CommandText = sql
        MsgBox("SE DARA DE BAJA LA VENTA: " & eliminar.id_venta & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        llenarVentas()
    End Sub

    'Actualizar cuentas
    Private Function actualizarVenta()
        Dim actualizar As New ventas

        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtIdVenta.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdVenta.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtImporte.Text) Then
            MessageBox.Show("Valor no válido en campo Importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtImporte.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtIdVendedor.Text) Then
            MessageBox.Show("Valor no válido en campo Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdVendedor.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        actualizar.id_venta = CInt(Me.txtIdVenta.Text)
        actualizar.fecha = Me.dtpFecha.Text
        actualizar.importe = CDec(Me.txtImporte.Text)
        actualizar.id_vendedor = CInt(Me.txtIdVendedor.Text)

        Dim sql As String = "EXEC spu_actualizar_venta " & actualizar.id_venta & "," & $"'{actualizar.fecha}'" & "," & $"'{actualizar.importe}'" & "," & actualizar.id_vendedor & ""
        cmd.CommandText = sql
        'MsgBox(sql)
        MsgBox("SE ACTUALIZARÁ LA VENTA: " & actualizar.id_venta & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
            MsgBox("VENTA ACTUALIZADA CON ÉXITO")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub pasarDatos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "EXEC spu_obtener_id_venta " + Me.dgvVentas.CurrentRow.Cells(0).Value.ToString + ""
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.txtIdVenta.Text = dr(0).ToString
                    Me.dtpFecha.Text = dr(1).ToString
                    Me.txtImporte.Text = dr(2).ToString
                    Me.txtIdVendedor.Text = dr(3).ToString
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtIdVenta.Clear()
        txtImporte.Clear()
        txtIdVendedor.Clear()

        ' Establecer acción a actualizar
        action = "add"

        ' Reestablecer color de la acción actualizar
        btnModificar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnAgregar.BackColor = Color.Green
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pasarDatos()
        txtIdVenta.Enabled = False

        ' Establecer acción a actualizar
        action = "update"

        ' Reestablecer color de la acción agregar
        btnAgregar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnModificar.BackColor = Color.Green
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarVenta()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim success As Boolean
        If action = "add" Then
            success = agregarVenta()
        ElseIf action = "update" Then
            success = actualizarVenta()
        Else
            MessageBox.Show("Seleccione una acción a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not success Then
            Return
        End If

        llenarVentas()
        txtIdVenta.Clear()
        txtImporte.Clear()
        txtIdVendedor.Clear()
        Action = ""
        txtIdVendedor.Enabled = True

        ' Reestablecer color
        btnAgregar.BackColor = SystemColors.Highlight

        ' Reestablecer color
        btnModificar.BackColor = SystemColors.Highlight
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtIdVenta.TextChanged, txtImporte.TextChanged, txtIdVendedor.TextChanged
        Dim txtBox As TextBox = sender
        txtBox.BackColor = SystemColors.Window
    End Sub

    Private Sub btnVentasLoc_Click(sender As Object, e As EventArgs) Handles btnVentasLoc.Click
        Dim frm As New frmVentasLoc
        frm.ShowDialog()
    End Sub
End Class