Public Class frmMarcas
    'Variable acción a realizar
    Dim action As String
    Private Sub frmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarMarcas()
    End Sub

    'Llenar marcas en datagridview
    Private Sub llenarMarcas()
        Dim sql As String = "EXEC spu_mostrar_marcas"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("marcas")
        adp.Fill(ds.Tables("marcas"))
        Me.dgvMarcas.DataSource = ds.Tables("marcas")
    End Sub

    Private Function agregarMarca()
        Dim nueva As New marcas
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

        nueva.id_marca = CInt(Me.txtId.Text)
        nueva.descrip_marca = (Me.txtDescripcion.Text.Trim())

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_marca " & nueva.id_marca & ", " & $"'{nueva.descrip_marca}'" & ""
        cmd.CommandText = sql
        MsgBox("SE DARÁ DE ALTA LA MARCA: " & nueva.id_marca & ", " & nueva.descrip_marca & "")

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Marca agregada con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Eliminar marcas
    Private Sub eliminarMarca()
        Dim eliminar As New marcas
        eliminar.id_marca = Me.dgvMarcas.CurrentRow.Cells(0).Value
        Dim sql As String = "EXEC spu_eliminar_marca " & eliminar.id_marca & ""
        cmd.CommandText = sql
        MsgBox("SE DARA DE BAJA LA MARCA: " & eliminar.id_marca & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        llenarMarcas()
    End Sub

    'Actualizar marcas
    Private Function actualizarMarca()
        Dim actualizar As New marcas
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

        actualizar.id_marca = CInt(Me.txtId.Text)
        actualizar.descrip_marca = (Me.txtDescripcion.Text.Trim())

        Dim sql As String = "EXEC spu_actualizar_marca " & actualizar.id_marca & ", " & $"'{actualizar.descrip_marca}'" & ""
        cmd.CommandText = sql
        MsgBox("SE ACTUALIZARÁ LA MARCA: " & actualizar.descrip_marca & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
            MsgBox("MARCA ACTUALIZADA CON ÉXITO")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub pasarDatos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text

        Dim sql As String = "EXEC spu_obtener_marca " + Me.dgvMarcas.CurrentRow.Cells(0).Value.ToString + ""
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtId.Clear()
        txtDescripcion.Clear()
        desplegar(Me)

        ' Establecer ID en campo
        Me.txtId.Text = ObtenerUltimoID("id_marca", "marcas")

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
        eliminarMarca()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim success As Boolean
        If action = "add" Then
            success = agregarMarca()
        ElseIf action = "update" Then
            success = actualizarMarca()
        Else
            MessageBox.Show("Seleccione una acción a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not success Then
            Return
        End If

        llenarMarcas()
        txtId.Clear()
        txtDescripcion.Clear()
        action = ""
        txtId.Enabled = True

        ' Reestablecer color
        btnAgregar.BackColor = SystemColors.Highlight

        ' Reestablecer color
        btnModificar.BackColor = SystemColors.Highlight
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged, txtDescripcion.TextChanged
        Dim txtBox As TextBox = sender
        txtBox.BackColor = SystemColors.Window
    End Sub

    Private Function aumentar()
        Dim input = InputBox("Indique el porcentaje de aumento")

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"EXEC spu_aumento_masivo {Me.dgvMarcas.CurrentRow.Cells(0).Value}, {input}"
        cmd.CommandText = sql
        MsgBox($"Se aumentarán los precios de las prendas de la marca {Me.dgvMarcas.CurrentRow.Cells(1).Value} en un {input}%")

        Try
            cmd.ExecuteNonQuery()
            MsgBox("PRECIOS AUMENTADOS CON ÉXITO")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub btnAumento_Click(sender As Object, e As EventArgs) Handles btnAumento.Click
        aumentar()
    End Sub
End Class