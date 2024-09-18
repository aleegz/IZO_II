Imports System.Data.SqlClient

Public Class frmVendedores

    'Variable acción a realizar
    Dim action As String
    Private Sub Vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarVendedores()
    End Sub

    'Llenar vendedores en datagridview
    Private Sub llenarVendedores()
        Dim sql As String = "EXEC spu_mostrar_vendedores"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("vendedores")
        adp.Fill(ds.Tables("vendedores"))
        Me.dgvVendedores.DataSource = ds.Tables("vendedores")
    End Sub

    Private Function agregarVendedor()
        Dim nueva As New vendedores

        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtIdVendedor.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdVendedor.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtNombre.Text) Then
            MessageBox.Show("Valor no válido en campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNombre.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtContraseña.Text) Then
            MessageBox.Show("Valor no válido en campo Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtContraseña.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtIdSucursal.Text) Then
            MessageBox.Show("Valor no válido en campo Sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdSucursal.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nueva.id_vendedor = CInt(Me.txtIdVendedor.Text)
        nueva.nombre = (Me.txtNombre.Text.Trim())
        nueva.contraseña = (Me.txtContraseña.Text.Trim())
        nueva.id_sucursal = CInt(Me.txtIdSucursal.Text)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_vendedor " & nueva.id_vendedor & "," & $"'{nueva.nombre}'" & "," & $"'{nueva.contraseña}'" & "," & nueva.id_sucursal & ""
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Vendedor registrado con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Eliminar sucursales
    Private Sub eliminarSucursal()
        Dim eliminar As New vendedores
        eliminar.id_vendedor = Me.dgvVendedores.CurrentRow.Cells(0).Value
        MsgBox(eliminar.id_vendedor)
        Dim sql As String = "EXEC spu_eliminar_vendedor " & eliminar.id_vendedor & ""
        cmd.CommandText = sql
        MsgBox("SE DARA DE BAJA EL VENDEDOR: " & eliminar.id_vendedor & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        llenarVendedores()
    End Sub

    'Actualizar cuentas
    Private Function actualizarVendedor()
        Dim actualizar As New vendedores

        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtIdVendedor.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdVendedor.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtNombre.Text) Then
            MessageBox.Show("Valor no válido en campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNombre.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtContraseña.Text) Then
            MessageBox.Show("Valor no válido en campo Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtContraseña.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtIdSucursal.Text) Then
            MessageBox.Show("Valor no válido en campo Sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtIdSucursal.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        actualizar.id_vendedor = CInt(Me.txtIdVendedor.Text)
        actualizar.nombre = (Me.txtNombre.Text.Trim())
        actualizar.contraseña = (Me.txtContraseña.Text.Trim())
        actualizar.id_sucursal = CInt(Me.txtIdSucursal.Text)

        Dim sql As String = "EXEC spu_actualizar_vendedor " & actualizar.id_vendedor & ", " & $"'{actualizar.nombre}'" & ", " & $"'{actualizar.contraseña}'" & ", " & actualizar.id_sucursal & ""
        cmd.CommandText = sql
        MsgBox("SE ACTUALIZARÁ EL VENDEDOR: " & actualizar.id_vendedor & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
            MsgBox("VENDEDOR ACTUALIZADO CON ÉXITO")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub pasarDatos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "EXEC spu_obtener_id_vendedor " + Me.dgvVendedores.CurrentRow.Cells(0).Value.ToString + ""
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.txtIdVendedor.Text = dr(0).ToString
                    Me.txtNombre.Text = dr(1).ToString
                    Me.txtContraseña.Text = dr(2).ToString
                    Me.txtIdSucursal.Text = dr(3).ToString
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtIdVendedor.Clear()
        txtNombre.Clear()
        txtContraseña.Clear()
        txtIdSucursal.Clear()

        ' Establecer acción a actualizar
        action = "add"

        ' Reestablecer color de la acción actualizar
        btnModificar.BackColor = SystemColors.Highlight

        ' Establecer color de fondo al botón
        btnAgregar.BackColor = Color.Green
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pasarDatos()
        txtIdVendedor.Enabled = False

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
            success = agregarVendedor()
        ElseIf action = "update" Then
            success = actualizarVendedor()
        Else
            MessageBox.Show("Seleccione una acción a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not success Then
            Return
        End If

        llenarVendedores()
        txtIdVendedor.Clear()
        txtNombre.Clear()
        txtContraseña.Clear()
        action = ""
        txtIdVendedor.Enabled = True

        ' Reestablecer color
        btnAgregar.BackColor = SystemColors.Highlight

        ' Reestablecer color
        btnModificar.BackColor = SystemColors.Highlight
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtIdVendedor.TextChanged, txtNombre.TextChanged, txtContraseña.TextChanged, txtIdSucursal.TextChanged
        Dim txtBox As TextBox = sender
        txtBox.BackColor = SystemColors.Window
    End Sub

    ' --------------------------------------------------

    Private Sub mostrarPromedio()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "EXEC spu_promedio " + Me.dgvVendedores.CurrentRow.Cells(0).Value.ToString + ""
        MsgBox(sql)

        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    MsgBox("El promedio vendido por el vendedor " + Me.dgvVendedores.CurrentRow.Cells(0).Value.ToString + " es de $" + Convert.ToDouble(dr(0)).ToString("F2"))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnPromedio_Click(sender As Object, e As EventArgs) Handles btnPromedio.Click
        mostrarPromedio()
    End Sub
End Class