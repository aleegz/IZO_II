Public Class frmSucursales
    'Variable acción a realizar
    Dim action As String

    Private Sub Sucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarSucursales()
    End Sub

    'Llenar sucursales en datagridview
    Private Sub llenarSucursales()
        Dim sql As String = "EXEC spu_mostrar_sucursales"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("sucursales")
        adp.Fill(ds.Tables("sucursales"))
        Me.dgvSucursales.DataSource = ds.Tables("sucursales")
    End Sub

    Private Function agregarSucursal()
        Dim nueva As New sucursales
        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtIdSucursal.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdSucursal.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
            MessageBox.Show("Valor no válido en campo Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtLocalidad.Text) Then
            MessageBox.Show("Valor no válido en campo Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtLocalidad.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nueva.id_sucursal = CInt(Me.txtIdSucursal.Text)
        nueva.descripcion = (Me.txtDescripcion.Text.Trim())
        nueva.localidad = (Me.txtLocalidad.Text.Trim())
        'MsgBox(nueva.id_sucursal.ToString + " " + nueva.descripcion + " " + nueva.localidad)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_sucursal " & nueva.id_sucursal & "," & $"'{nueva.descripcion}'" & "," & $"'{nueva.localidad}'" & ""
        cmd.CommandText = sql
        MsgBox("SE DARÁ DE ALTA LA SUCURSAL: " & nueva.id_sucursal & ", " & nueva.descripcion & ", " & nueva.localidad & "")

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Sucursal creada con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Eliminar sucursales
    Private Sub eliminarSucursal()
        Dim eliminar As New sucursales
        eliminar.id_sucursal = Me.dgvSucursales.CurrentRow.Cells(0).Value
        Dim sql As String = "EXEC spu_eliminar_sucursal " & eliminar.id_sucursal & ""
        cmd.CommandText = sql
        MsgBox("SE DARA DE BAJA LA SUCURSAL: " & eliminar.id_sucursal & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        llenarSucursales()
    End Sub

    'Actualizar cuentas
    Private Function actualizarSucursal()
        Dim actualizar As New sucursales

        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtIdSucursal.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdSucursal.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
            MessageBox.Show("Valor no válido en campo Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtLocalidad.Text) Then
            MessageBox.Show("Valor no válido en campo Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtLocalidad.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        actualizar.id_sucursal = CInt(Me.txtIdSucursal.Text)
        actualizar.descripcion = (Me.txtDescripcion.Text.Trim())
        actualizar.localidad = (Me.txtLocalidad.Text.Trim())

        Dim sql As String = "EXEC spu_actualizar_sucursal " & actualizar.id_sucursal & ", " & $"'{actualizar.descripcion}'" & ", " & $"'{actualizar.localidad}'" & ""
        cmd.CommandText = sql
        MsgBox("SE ACTUALIZARÁ LA SUCURSAL: " & actualizar.id_sucursal & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
            MsgBox("SUCURSAL ACTUALIZADA CON ÉXITO")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub pasarDatos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "EXEC spu_obtener_id_sucursal " + Me.dgvSucursales.CurrentRow.Cells(0).Value.ToString + ""
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.txtIdSucursal.Text = dr(0).ToString
                    Me.txtDescripcion.Text = dr(1).ToString
                    Me.txtLocalidad.Text = dr(2).ToString
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtIdSucursal.Clear()
        txtDescripcion.Clear()
        txtLocalidad.Clear()

        ' Establecer acción a actualizar
        action = "add"

        ' Reestablecer color de la acción actualizar
        btnModificar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnAgregar.BackColor = Color.Green
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pasarDatos()
        txtIdSucursal.Enabled = False

        ' Establecer acción a actualizar
        action = "update"

        ' Reestablecer color de la acción agregar
        btnAgregar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnModificar.BackColor = Color.Green
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarSucursal()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim success As Boolean
        If action = "add" Then
            success = agregarSucursal()
        ElseIf action = "update" Then
            success = actualizarSucursal()
        Else
            MessageBox.Show("Seleccione una acción a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not success Then
            Return
        End If

        llenarSucursales()
        txtIdSucursal.Clear()
        txtDescripcion.Clear()
        txtLocalidad.Clear()
        action = ""
        txtIdSucursal.Enabled = True

        ' Reestablecer color
        btnAgregar.BackColor = SystemColors.Highlight

        ' Reestablecer color
        btnModificar.BackColor = SystemColors.Highlight
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtIdSucursal.TextChanged, txtDescripcion.TextChanged, txtLocalidad.TextChanged
        Dim txtBox As TextBox = sender
        txtBox.BackColor = SystemColors.Window
    End Sub
End Class