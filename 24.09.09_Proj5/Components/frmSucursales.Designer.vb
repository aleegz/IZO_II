<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursales))
        Me.dgvSucursales = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtIdSucursal = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.Location = New System.Drawing.Point(12, 12)
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.Size = New System.Drawing.Size(600, 300)
        Me.dgvSucursales.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Noto Sans Cond", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(660, 30)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(105, 35)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Noto Sans Cond", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificar.Location = New System.Drawing.Point(660, 143)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 35)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Noto Sans Cond", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Location = New System.Drawing.Point(660, 256)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 35)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtIdSucursal
        '
        Me.txtIdSucursal.Location = New System.Drawing.Point(14, 346)
        Me.txtIdSucursal.Name = "txtIdSucursal"
        Me.txtIdSucursal.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSucursal.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(133, 346)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(252, 346)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.txtLocalidad.TabIndex = 6
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Noto Sans Cond", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Location = New System.Drawing.Point(376, 331)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(105, 35)
        Me.btnConfirmar.TabIndex = 7
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(56, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(153, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(276, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Localidad"
        '
        'frmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(804, 391)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdSucursal)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvSucursales)
        Me.Name = "frmSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursales"
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSucursales As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtIdSucursal As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
