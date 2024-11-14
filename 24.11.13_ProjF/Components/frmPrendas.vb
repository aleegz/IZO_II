Public Class frmPrendas
    'Variable acción a realizar
    Dim action As String
    Private Sub frmPrendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarPrendas()
    End Sub

    'Llenar prendas en datagridview
    Private Sub llenarPrendas()
        Dim sql As String = "EXEC spu_mostrar_prendas"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
        Dim ds As New DataSet
        ds.Tables.Add("prendas")
        adp.Fill(ds.Tables("prendas"))
        Me.dgvPrendas.DataSource = ds.Tables("prendas")
    End Sub

    Private Function agregarPrenda()
        Dim nueva As New prendas
        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtId.Text) Then
            MessageBox.Show("Valor no válido en campo Código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtId.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtTalle.Text) Then
            MessageBox.Show("Valor no válido en campo Talle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtTalle.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtColor.Text) Then
            MessageBox.Show("Valor no válido en campo Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtColor.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
            MessageBox.Show("Valor no válido en campo Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtStock.Text) Then
            MessageBox.Show("Valor no válido en campo Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtStock.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtPrecio.Text) Then
            MessageBox.Show("Valor no válido en campo Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtPrecio.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        nueva.codigo = CInt(Me.txtId.Text)
        nueva.talle = (Me.txtTalle.Text.Trim())
        nueva.color = (Me.txtColor.Text.Trim())
        nueva.descrip_prenda = (Me.txtDescripcion.Text.Trim())
        nueva.stock = CInt(Me.txtStock.Text)
        nueva.precio = CDec(Me.txtPrecio.Text)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_prenda " & nueva.codigo & ", " & $"'{nueva.talle}'" & ", " & $"'{nueva.color}'" & ", " & $"'{nueva.descrip_prenda}'" & ", " & nueva.stock & ", " & nueva.precio & ""
        cmd.CommandText = sql
        MsgBox("SE DARÁ DE ALTA LA PRENDA: " & nueva.codigo & ", " & nueva.descrip_prenda & "")

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Prenda agregada con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Eliminar marcas
    Private Sub eliminarPrenda()
        Dim eliminar As New prendas
        eliminar.codigo = Me.dgvPrendas.CurrentRow.Cells(0).Value.ToString
        eliminar.talle = Me.dgvPrendas.CurrentRow.Cells(1).Value.ToString
        eliminar.color = Me.dgvPrendas.CurrentRow.Cells(2).Value.ToString
        Dim sql As String = "EXEC spu_eliminar_prenda " & eliminar.codigo & ", " & $"'{eliminar.talle}'" & ", " & $"{eliminar.color}" & ""
        cmd.CommandText = sql
        MsgBox(sql)
        MsgBox("SE DARA DE BAJA LA PRENDA: " & eliminar.codigo & "")

        'validacion 
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        llenarPrendas()
    End Sub

    'Actualizar marcas
    Private Function actualizarPrenda()
        Dim actualizar As New prendas
        Dim inputsValidos As Boolean = True
        If Not IsNumeric(Me.txtId.Text) Then
            MessageBox.Show("Valor no válido en campo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtId.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtTalle.Text) Then
            MessageBox.Show("Valor no válido en campo Talle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtColor.Text) Then
            MessageBox.Show("Valor no válido en campo Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If String.IsNullOrEmpty(Me.txtDescripcion.Text) Then
            MessageBox.Show("Valor no válido en campo Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtStock.Text) Then
            MessageBox.Show("Valor no válido en campo Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtStock.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not IsNumeric(Me.txtPrecio.Text) Then
            MessageBox.Show("Valor no válido en campo Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtPrecio.BackColor = Color.Red
            inputsValidos = False
        End If

        If Not inputsValidos Then
            Return False
        End If

        actualizar.codigo = CInt(Me.txtId.Text)
        actualizar.talle = (Me.txtTalle.Text.Trim())
        actualizar.color = (Me.txtColor.Text.Trim())
        actualizar.descrip_prenda = (Me.txtDescripcion.Text.Trim())
        actualizar.stock = CInt(Me.txtStock.Text)
        actualizar.precio = CDec(Me.txtPrecio.Text)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "EXEC spu_agregar_prenda " & actualizar.codigo & ", " & $"'{actualizar.talle}'" & ", " & $"'{actualizar.color}'" & ", " & $"'{actualizar.descrip_prenda}'" & ", " & actualizar.stock & ", " & actualizar.precio & ""
        cmd.CommandText = sql
        MsgBox("SE DARÁ DE MODIFICARÁ LA PRENDA: " & actualizar.codigo & ", " & actualizar.descrip_prenda & "")

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

        Dim sql As String = "EXEC spu_obtener_prenda " + Me.dgvPrendas.CurrentRow.Cells(0).Value.ToString + ", " + Me.dgvPrendas.CurrentRow.Cells(1).Value.ToString + ", " + Me.dgvPrendas.CurrentRow.Cells(2).Value.ToString
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.txtId.Text = dr(0).ToString
                    Me.txtTalle.Text = dr(1).ToString
                    Me.txtColor.Text = dr(2).ToString
                    Me.txtDescripcion.Text = dr(3).ToString
                    Me.txtStock.Text = dr(4).ToString
                    Me.txtPrecio.Text = dr(5).ToString
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtId.Clear()
        txtTalle.Clear()
        txtColor.Clear()
        txtDescripcion.Clear()
        txtStock.Clear()
        txtPrecio.Clear()
        desplegar(Me)

        ' Establecer ID en campo
        Me.txtId.Text = ObtenerUltimoID("codigo", "prendas")

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
        eliminarPrenda()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim success As Boolean
        If action = "add" Then
            success = agregarPrenda()
        ElseIf action = "update" Then
            success = actualizarPrenda()
        Else
            MessageBox.Show("Seleccione una acción a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If Not success Then
            Return
        End If

        llenarPrendas()
        txtId.Clear()
        txtTalle.Clear()
        txtColor.Clear()
        txtDescripcion.Clear()
        txtStock.Clear()
        txtPrecio.Clear()

        action = ""
        txtId.Enabled = True

        ' Reestablecer color
        btnAgregar.BackColor = SystemColors.Highlight

        ' Reestablecer color
        btnModificar.BackColor = SystemColors.Highlight
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged, txtTalle.TextChanged, txtColor.TextChanged, txtDescripcion.TextChanged, txtStock.TextChanged, txtPrecio.TextChanged
        Dim txtBox As TextBox = sender
        txtBox.BackColor = SystemColors.Window
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmListaPrecios
        frm.Show()
    End Sub
End Class