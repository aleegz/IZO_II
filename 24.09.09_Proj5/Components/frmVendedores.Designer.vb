<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedores
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
        Me.dgvVendedores = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.txtIdSucursal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPromedio = New System.Windows.Forms.Button()
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVendedores
        '
        Me.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendedores.Location = New System.Drawing.Point(12, 12)
        Me.dgvVendedores.Name = "dgvVendedores"
        Me.dgvVendedores.Size = New System.Drawing.Size(600, 300)
        Me.dgvVendedores.TabIndex = 0
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(273, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(162, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(56, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Location = New System.Drawing.Point(490, 331)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(105, 35)
        Me.btnConfirmar.TabIndex = 14
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(252, 346)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseña.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 346)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 12
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.Location = New System.Drawing.Point(14, 346)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVendedor.TabIndex = 11
        '
        'txtIdSucursal
        '
        Me.txtIdSucursal.Location = New System.Drawing.Point(371, 346)
        Me.txtIdSucursal.Name = "txtIdSucursal"
        Me.txtIdSucursal.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSucursal.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(390, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ID Sucursal"
        '
        'btnPromedio
        '
        Me.btnPromedio.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPromedio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPromedio.Location = New System.Drawing.Point(660, 276)
        Me.btnPromedio.Name = "btnPromedio"
        Me.btnPromedio.Size = New System.Drawing.Size(105, 35)
        Me.btnPromedio.TabIndex = 20
        Me.btnPromedio.Text = "Promedio"
        Me.btnPromedio.UseVisualStyleBackColor = False
        '
        'frmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project5.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(804, 391)
        Me.Controls.Add(Me.btnPromedio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdSucursal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvVendedores)
        Me.Name = "frmVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedores"
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVendedores As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents txtIdSucursal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPromedio As Button
End Class
