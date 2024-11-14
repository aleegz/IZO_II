Public Class frmFormasPago
    ' Variable acción a realizar
    Dim action As String

    Private Sub frmFormasPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarFormasPago()
    End Sub

    ' Llenar formas de pago en datagridview
    Private Sub llenarFormasPago()
        Dim sql As String = "EXEC spu_mostrar_formas_pago"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("formas_pago")
        adp.Fill(ds.Tables("formas_pago"))
        Me.dgvFormasPago.DataSource = ds.Tables("formas_pago")
    End Sub

    ' Agregar forma de pago
    Private Function agregarFormaPago() As Boolean
        Dim nueva As New formas_pago
        Dim inputsValidos As Boolean = True

        If Not IsNumeric(Me.txtId.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtId.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
            MessageBox.Show("Valor no válido en campo Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nueva.id_forma_pago = CInt(Me.txtId.Text)
        nueva.descrip_forma_pago = Me.txtDescripcion.Text.Trim()

        ' Ejecutar el SP para agregar la forma de pago
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_forma_pago " & nueva.id_forma_pago & ", " & $"'{nueva.descrip_forma_pago}'"
        cmd.CommandText = sql
        MsgBox("SE DARÁ DE ALTA LA FORMA DE PAGO: " & nueva.id_forma_pago & ", " & nueva.descrip_forma_pago)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Forma de pago agregada con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    ' Eliminar forma de pago
    Private Sub eliminarFormaPago()
        Dim eliminar As New formas_pago
        eliminar.id_forma_pago = Me.dgvFormasPago.CurrentRow.Cells(0).Value
        Dim sql As String = "EXEC spu_eliminar_forma_pago " & eliminar.id_forma_pago
        cmd.CommandText = sql
        MsgBox("SE DARA DE BAJA LA FORMA DE PAGO: " & eliminar.id_forma_pago)

        ' Validación de la eliminación
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        llenarFormasPago()
    End Sub

    ' Actualizar forma de pago
    Private Function actualizarFormaPago() As Boolean
        Dim actualizar As New formas_pago
        Dim inputsValidos As Boolean = True

        If Not IsNumeric(Me.txtId.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtId.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
            MessageBox.Show("Valor no válido en campo Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        actualizar.id_forma_pago = CInt(Me.txtId.Text)
        actualizar.descrip_forma_pago = Me.txtDescripcion.Text.Trim()

        ' Ejecutar el SP para actualizar la forma de pago
        Dim sql As String = "EXEC spu_actualizar_forma_pago " & actualizar.id_forma_pago & ", " & $"'{actualizar.descrip_forma_pago}'"
        cmd.CommandText = sql
        MsgBox("SE ACTUALIZARÁ LA FORMA DE PAGO: " & actualizar.descrip_forma_pago)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Forma de pago actualizada con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    ' Pasar los datos del DataGridView a los controles del formulario
    Private Sub pasarDatos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "EXEC spu_obtener_forma_pago " + Me.dgvFormasPago.CurrentRow.Cells(0).Value.ToString
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.txtId.Text = dr(0).ToString
                    Me.txtDescripcion.Text = dr(1).ToString
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Botón Agregar
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtId.Clear()
        txtDescripcion.Clear()
        desplegar(Me)

        ' Establecer ID en campo
        Me.txtId.Text = ObtenerUltimoID("id_forma_pago", "formas_pago")

        ' Establecer acción a agregar
        action = "add"

        ' Reestablecer color de la acción actualizar
        btnModificar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnAgregar.BackColor = Color.Green
    End Sub

    ' Botón Modificar
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pasarDatos()
        txtId.Enabled = False
        desplegar(Me)

        ' Establecer acción a actualizar
        action = "update"

        ' Reestablecer color de la acción agregar
        btnAgregar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnModificar.BackColor = Color.Green
    End Sub

    ' Botón Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarFormaPago()
    End Sub

    ' Botón Confirmar (Agregar o Modificar)
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim success As Boolean
        If action = "add" Then
            success = agregarFormaPago()
        ElseIf action = "update" Then
            success = actualizarFormaPago()
        Else
            MessageBox.Show("Seleccione una acción a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not success Then
            Return
        End If

        llenarFormasPago()
        txtId.Clear()
        txtDescripcion.Clear()
        action = ""
        txtId.Enabled = True

        ' Reestablecer color
        btnAgregar.BackColor = SystemColors.Highlight
        btnModificar.BackColor = SystemColors.Highlight
    End Sub

    ' Limpiar el color de fondo de los campos de texto cuando se cambian
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged, txtDescripcion.TextChanged
        Dim txtBox As TextBox = sender
        txtBox.BackColor = SystemColors.Window
    End Sub
End Class
