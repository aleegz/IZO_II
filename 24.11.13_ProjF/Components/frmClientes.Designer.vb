<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblRS = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtRS = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 12)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.Size = New System.Drawing.Size(750, 550)
        Me.dgvClientes.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(102, 590)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 26
        Me.lblID.Text = "ID"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(58, 606)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 35)
        Me.txtId.TabIndex = 0
        '
        'lblRS
        '
        Me.lblRS.AutoSize = True
        Me.lblRS.BackColor = System.Drawing.Color.Transparent
        Me.lblRS.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRS.Location = New System.Drawing.Point(346, 591)
        Me.lblRS.Name = "lblRS"
        Me.lblRS.Size = New System.Drawing.Size(70, 13)
        Me.lblRS.TabIndex = 24
        Me.lblRS.Text = "Razón Social"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Location = New System.Drawing.Point(777, 596)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(180, 40)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'txtRS
        '
        Me.txtRS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRS.Location = New System.Drawing.Point(330, 607)
        Me.txtRS.Multiline = True
        Me.txtRS.Name = "txtRS"
        Me.txtRS.Size = New System.Drawing.Size(100, 35)
        Me.txtRS.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(777, 465)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(180, 40)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar Cliente"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Location = New System.Drawing.Point(777, 249)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(180, 40)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar Cliente"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Location = New System.Drawing.Point(777, 33)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(180, 40)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar Cliente"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.BackColor = System.Drawing.Color.Transparent
        Me.lblTel.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTel.Location = New System.Drawing.Point(630, 585)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(49, 13)
        Me.lblTel.TabIndex = 28
        Me.lblTel.Text = "Teléfono"
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(602, 601)
        Me.txtTel.Multiline = True
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 35)
        Me.txtTel.TabIndex = 2
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 580)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblRS)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtRS)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents lblID As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblRS As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtRS As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblTel As Label
    Friend WithEvents txtTel As TextBox
End Class
