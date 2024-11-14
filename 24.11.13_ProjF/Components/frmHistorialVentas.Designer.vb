<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtTalle = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnVentasxFecha = New System.Windows.Forms.Button()
        Me.btnVentasCli = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(568, 582)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(535, 598)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(463, 582)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStock.Location = New System.Drawing.Point(429, 598)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(341, 582)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(323, 598)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(251, 582)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Color"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtColor.Location = New System.Drawing.Point(217, 598)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 38
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(36, 583)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(40, 13)
        Me.lblID.TabIndex = 48
        Me.lblID.Text = "Código"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(5, 598)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(146, 582)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Talle"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Location = New System.Drawing.Point(646, 583)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(105, 35)
        Me.btnConfirmar.TabIndex = 42
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'txtTalle
        '
        Me.txtTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTalle.Location = New System.Drawing.Point(111, 598)
        Me.txtTalle.Name = "txtTalle"
        Me.txtTalle.Size = New System.Drawing.Size(100, 20)
        Me.txtTalle.TabIndex = 37
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(770, 339)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(180, 40)
        Me.btnEliminar.TabIndex = 46
        Me.btnEliminar.Text = "Eliminar Venta"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Location = New System.Drawing.Point(770, 61)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(180, 40)
        Me.btnModificar.TabIndex = 45
        Me.btnModificar.Text = "Modificar Venta"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'dgvVentas
        '
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(14, 12)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(750, 550)
        Me.dgvVentas.TabIndex = 43
        '
        'btnVentasxFecha
        '
        Me.btnVentasxFecha.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVentasxFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentasxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVentasxFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVentasxFecha.Location = New System.Drawing.Point(770, 200)
        Me.btnVentasxFecha.Name = "btnVentasxFecha"
        Me.btnVentasxFecha.Size = New System.Drawing.Size(180, 40)
        Me.btnVentasxFecha.TabIndex = 53
        Me.btnVentasxFecha.Text = "Ventas Por Fecha"
        Me.btnVentasxFecha.UseVisualStyleBackColor = False
        '
        'btnVentasCli
        '
        Me.btnVentasCli.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVentasCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentasCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVentasCli.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVentasCli.Location = New System.Drawing.Point(770, 478)
        Me.btnVentasCli.Name = "btnVentasCli"
        Me.btnVentasCli.Size = New System.Drawing.Size(180, 40)
        Me.btnVentasCli.TabIndex = 54
        Me.btnVentasCli.Text = "Ventas Por Cliente"
        Me.btnVentasCli.UseVisualStyleBackColor = False
        '
        'frmHistorialVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 580)
        Me.Controls.Add(Me.btnVentasCli)
        Me.Controls.Add(Me.btnVentasxFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtTalle)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.dgvVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistorialVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtTalle As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnVentasxFecha As Button
    Friend WithEvents btnVentasCli As Button
End Class
