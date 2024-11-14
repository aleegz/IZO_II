Public Class frmClientes
    'Variable acción a realizar
    Dim action As String

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarClientes()
    End Sub

    'Llenar clientes en datagridview
    Private Sub llenarClientes()
        Dim sql As String = "EXEC spu_mostrar_clientes"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("clientes")
        adp.Fill(ds.Tables("clientes"))
        Me.dgvClientes.DataSource = ds.Tables("clientes")
    End Sub

    Private Function agregarCliente()
        Dim nuevo As New clientes
        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtId.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtId.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtRS.Text) Then
            MessageBox.Show("Valor no válido en campo Razón Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtRS.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtTel.Text) Then
            MessageBox.Show("Valor no válido en campo Teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtTel.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nuevo.id_cliente = CInt(Me.txtId.Text)
        nuevo.razon_social = (Me.txtRS.Text.Trim())
        nuevo.telefono = (Me.txtTel.Text.Trim())

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_cliente " & nuevo.id_cliente & ", " & $"'{nuevo.razon_social}'" & ", " & $"'{nuevo.telefono}'" & ""
        cmd.CommandText = sql
        MsgBox("SE DARÁ DE ALTA EL CLIENTE: " & nuevo.id_cliente & ", " & nuevo.razon_social & "")

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Cliente agregado con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Eliminar marcas
    Private Sub eliminarCliente()
        Dim eliminar As New clientes
        eliminar.id_cliente = Me.dgvClientes.CurrentRow.Cells(0).Value
        Dim sql As String = "EXEC spu_eliminar_cliente " & eliminar.id_cliente & ""
        cmd.CommandText = sql
        MsgBox("SE DARA DE BAJA EL CLIENTE: " & eliminar.id_cliente & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        llenarClientes()
    End Sub

    'Actualizar marcas
    Private Function actualizarCliente()
        Dim actualizar As New clientes
        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtId.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtId.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtRS.Text) Then
            MessageBox.Show("Valor no válido en campo Razón Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtRS.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtTel.Text) Then
            MessageBox.Show("Valor no válido en campo Teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtTel.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        actualizar.id_cliente = CInt(Me.txtId.Text)
        actualizar.razon_social = (Me.txtRS.Text.Trim())
        actualizar.telefono = (Me.txtTel.Text.Trim())

        Dim sql As String = "EXEC spu_actualizar_cliente " & actualizar.id_cliente & ", " & $"'{actualizar.razon_social}'" & $"'{actualizar.telefono}'" & ""
        cmd.CommandText = sql
        MsgBox("SE ACTUALIZARÁ EL CLIENTE: " & actualizar.razon_social & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
            MsgBox("CLIENTE ACTUALIZADO CON ÉXITO")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub pasarDatos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "EXEC spu_obtener_cliente " + Me.dgvClientes.CurrentRow.Cells(0).Value.ToString + ""
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.txtId.Text = dr(0).ToString
                    Me.txtRS.Text = dr(1).ToString
                    Me.txtTel.Text = dr(2).ToString
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        desplegar(Me)
        txtId.Clear()
        txtRS.Clear()
        txtTel.Clear()

        ' Establecer ID en campo
        Me.txtId.Text = ObtenerUltimoID("id_cliente", "clientes")

        ' Establecer acción a actualizar
        action = "add"

        ' Reestablecer color de la acción actualizar
        btnModificar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnAgregar.BackColor = Color.Green
    End Sub

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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarCliente()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim success As Boolean
        If action = "add" Then
            success = agregarCliente()
        ElseIf action = "update" Then
            success = actualizarCliente()
        Else
            MessageBox.Show("Seleccione una acción a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not success Then
            Return
        End If

        llenarClientes()
        txtId.Clear()
        txtRS.Clear()
        txtTel.Clear()
        action = ""
        txtId.Enabled = True

        ' Reestablecer color
        btnAgregar.BackColor = SystemColors.Highlight

        ' Reestablecer color
        btnModificar.BackColor = SystemColors.Highlight
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged, txtRS.TextChanged, txtTel.TextChanged
        Dim txtBox As TextBox = sender
        txtBox.BackColor = SystemColors.Window
    End Sub

    Private Sub dgvClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvClientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Agregar dueño
            Dim frm As frmCrearVenta = CType(Owner, frmCrearVenta)
            frm.txtId.Text = Me.dgvClientes.CurrentRow.Cells(0).Value.ToString()
            frm.txtRS.Text = Me.dgvClientes.CurrentRow.Cells(1).Value.ToString()
            frm.txtTel.Text = Me.dgvClientes.CurrentRow.Cells(2).Value.ToString()
            Me.Close()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class