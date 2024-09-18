<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnVentasLoc = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(12, 12)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(600, 300)
        Me.dgvVentas.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Location = New System.Drawing.Point(660, 188)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 35)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificar.Location = New System.Drawing.Point(660, 100)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 35)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(660, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(105, 35)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(495, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Vendedor"
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.Location = New System.Drawing.Point(471, 346)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVendedor.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(381, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Importe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(98, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(275, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Location = New System.Drawing.Point(590, 331)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(105, 35)
        Me.btnConfirmar.TabIndex = 23
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(352, 346)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 22
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(233, 346)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVenta.TabIndex = 20
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Location = New System.Drawing.Point(14, 346)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 29
        Me.dtpFecha.Value = New Date(2024, 8, 28, 11, 42, 41, 0)
        '
        'btnVentasLoc
        '
        Me.btnVentasLoc.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVentasLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentasLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVentasLoc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVentasLoc.Location = New System.Drawing.Point(660, 276)
        Me.btnVentasLoc.Name = "btnVentasLoc"
        Me.btnVentasLoc.Size = New System.Drawing.Size(105, 35)
        Me.btnVentasLoc.TabIndex = 30
        Me.btnVentasLoc.Text = "Ventas Loc"
        Me.btnVentasLoc.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Project5.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(804, 391)
        Me.Controls.Add(Me.btnVentasLoc)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtIdVenta)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvVentas)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnVentasLoc As Button
End Class
