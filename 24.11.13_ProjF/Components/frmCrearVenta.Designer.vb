<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtRS = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelVenta = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.txtPrUn = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.LabelSubTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.txtTal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.PanelFormulario.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(392, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(189, 33)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Nueva venta"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(205, 59)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(92, 20)
        Me.txtId.TabIndex = 10
        '
        'txtRS
        '
        Me.txtRS.Location = New System.Drawing.Point(342, 58)
        Me.txtRS.Name = "txtRS"
        Me.txtRS.Size = New System.Drawing.Size(177, 20)
        Me.txtRS.TabIndex = 11
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(525, 58)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(125, 20)
        Me.txtTel.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(379, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Razón Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(552, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(206, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "N° Identificación"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Location = New System.Drawing.Point(656, 57)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(183, 21)
        Me.cbFormaPago.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(688, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Forma de Pago"
        '
        'PanelFormulario
        '
        Me.PanelFormulario.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PanelFormulario.Controls.Add(Me.LabelTotal)
        Me.PanelFormulario.Controls.Add(Me.Label15)
        Me.PanelFormulario.Controls.Add(Me.LabelVenta)
        Me.PanelFormulario.Controls.Add(Me.Label13)
        Me.PanelFormulario.Controls.Add(Me.txtDescrip)
        Me.PanelFormulario.Controls.Add(Me.Label11)
        Me.PanelFormulario.Controls.Add(Me.dgvDetalle)
        Me.PanelFormulario.Controls.Add(Me.btnAgregar)
        Me.PanelFormulario.Controls.Add(Me.txtPrUn)
        Me.PanelFormulario.Controls.Add(Me.Label12)
        Me.PanelFormulario.Controls.Add(Me.txtCant)
        Me.PanelFormulario.Controls.Add(Me.Label9)
        Me.PanelFormulario.Controls.Add(Me.btnClientes)
        Me.PanelFormulario.Controls.Add(Me.btnConfirmar)
        Me.PanelFormulario.Controls.Add(Me.btnCancelar)
        Me.PanelFormulario.Controls.Add(Me.LabelSubTotal)
        Me.PanelFormulario.Controls.Add(Me.Label10)
        Me.PanelFormulario.Controls.Add(Me.LabelFecha)
        Me.PanelFormulario.Controls.Add(Me.txtTal)
        Me.PanelFormulario.Controls.Add(Me.Label8)
        Me.PanelFormulario.Controls.Add(Me.Label7)
        Me.PanelFormulario.Controls.Add(Me.txtColor)
        Me.PanelFormulario.Controls.Add(Me.Label6)
        Me.PanelFormulario.Controls.Add(Me.btnBuscar)
        Me.PanelFormulario.Controls.Add(Me.Label5)
        Me.PanelFormulario.Controls.Add(Me.txtCod)
        Me.PanelFormulario.Controls.Add(Me.Label2)
        Me.PanelFormulario.Controls.Add(Me.Label4)
        Me.PanelFormulario.Controls.Add(Me.txtId)
        Me.PanelFormulario.Controls.Add(Me.cbFormaPago)
        Me.PanelFormulario.Controls.Add(Me.txtRS)
        Me.PanelFormulario.Controls.Add(Me.txtTel)
        Me.PanelFormulario.Controls.Add(Me.Label3)
        Me.PanelFormulario.Controls.Add(Me.Label1)
        Me.PanelFormulario.Location = New System.Drawing.Point(12, 59)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(946, 499)
        Me.PanelFormulario.TabIndex = 21
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelTotal.Location = New System.Drawing.Point(517, 467)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(14, 20)
        Me.LabelTotal.TabIndex = 48
        Me.LabelTotal.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(413, 467)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 20)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Importe Total:"
        '
        'LabelVenta
        '
        Me.LabelVenta.AutoSize = True
        Me.LabelVenta.BackColor = System.Drawing.Color.Transparent
        Me.LabelVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVenta.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelVenta.Location = New System.Drawing.Point(137, 56)
        Me.LabelVenta.Name = "LabelVenta"
        Me.LabelVenta.Size = New System.Drawing.Size(14, 20)
        Me.LabelVenta.TabIndex = 46
        Me.LabelVenta.Text = "-"
        Me.LabelVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(107, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Venta N°"
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(493, 115)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(281, 20)
        Me.txtDescrip.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(543, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Descripción del Producto"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(5, 199)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(936, 252)
        Me.dgvDetalle.TabIndex = 42
        '
        'txtPrUn
        '
        Me.txtPrUn.Location = New System.Drawing.Point(362, 116)
        Me.txtPrUn.Name = "txtPrUn"
        Me.txtPrUn.Size = New System.Drawing.Size(125, 20)
        Me.txtPrUn.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(369, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Precio Unitario"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(780, 115)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(125, 20)
        Me.txtCant.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(804, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Cantidad"
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(295, 58)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(34, 22)
        Me.btnClientes.TabIndex = 35
        Me.btnClientes.Text = "..."
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'LabelSubTotal
        '
        Me.LabelSubTotal.AutoSize = True
        Me.LabelSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.LabelSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelSubTotal.Location = New System.Drawing.Point(277, 466)
        Me.LabelSubTotal.Name = "LabelSubTotal"
        Me.LabelSubTotal.Size = New System.Drawing.Size(14, 20)
        Me.LabelSubTotal.TabIndex = 32
        Me.LabelSubTotal.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(200, 467)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "SubTotal:"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.BackColor = System.Drawing.Color.Transparent
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelFecha.Location = New System.Drawing.Point(59, 467)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(14, 20)
        Me.LabelFecha.TabIndex = 30
        Me.LabelFecha.Text = "-"
        '
        'txtTal
        '
        Me.txtTal.Location = New System.Drawing.Point(176, 116)
        Me.txtTal.Name = "txtTal"
        Me.txtTal.Size = New System.Drawing.Size(49, 20)
        Me.txtTal.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(178, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Talle"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(6, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Fecha:"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(231, 115)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(125, 20)
        Me.txtColor.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(268, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(42, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Código Producto"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(46, 115)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(92, 20)
        Me.txtCod.TabIndex = 21
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(131, 115)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(36, 21)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(394, 152)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(159, 35)
        Me.btnAgregar.TabIndex = 40
        Me.btnAgregar.Text = "Agregar a la compra"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Location = New System.Drawing.Point(742, 457)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 35)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.Location = New System.Drawing.Point(843, 457)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(95, 35)
        Me.btnConfirmar.TabIndex = 34
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'frmCrearVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_Final.My.Resources.Resources.bg_home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(970, 650)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCrearVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Venta"
        Me.PanelFormulario.ResumeLayout(False)
        Me.PanelFormulario.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtRS As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents LabelSubTotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents txtTal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents txtPrUn As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelVenta As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnConfirmar As Button
End Class
