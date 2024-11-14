<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnPrendas = New System.Windows.Forms.Button()
        Me.btnMarcas = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnFormasPago = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(610, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(273, 33)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "TIENDA DE ROPA"
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClientes.Location = New System.Drawing.Point(1, 349)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(270, 74)
        Me.btnClientes.TabIndex = 6
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnPrendas
        '
        Me.btnPrendas.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPrendas.FlatAppearance.BorderSize = 0
        Me.btnPrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrendas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrendas.Location = New System.Drawing.Point(1, 269)
        Me.btnPrendas.Name = "btnPrendas"
        Me.btnPrendas.Size = New System.Drawing.Size(270, 74)
        Me.btnPrendas.TabIndex = 5
        Me.btnPrendas.Text = "Prendas"
        Me.btnPrendas.UseVisualStyleBackColor = False
        '
        'btnMarcas
        '
        Me.btnMarcas.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnMarcas.FlatAppearance.BorderSize = 0
        Me.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMarcas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMarcas.Location = New System.Drawing.Point(1, 189)
        Me.btnMarcas.Name = "btnMarcas"
        Me.btnMarcas.Size = New System.Drawing.Size(270, 74)
        Me.btnMarcas.TabIndex = 4
        Me.btnMarcas.Text = "Marcas"
        Me.btnMarcas.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVentas.Location = New System.Drawing.Point(1, 429)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(270, 74)
        Me.btnVentas.TabIndex = 8
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnFormasPago
        '
        Me.btnFormasPago.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnFormasPago.FlatAppearance.BorderSize = 0
        Me.btnFormasPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormasPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnFormasPago.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFormasPago.Location = New System.Drawing.Point(1, 509)
        Me.btnFormasPago.Name = "btnFormasPago"
        Me.btnFormasPago.Size = New System.Drawing.Size(270, 74)
        Me.btnFormasPago.TabIndex = 9
        Me.btnFormasPago.Text = "Formas de pago"
        Me.btnFormasPago.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimir.Location = New System.Drawing.Point(1, 589)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(270, 74)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprimir Factura"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelContenedor.BackColor = System.Drawing.Color.Transparent
        Me.PanelContenedor.BackgroundImage = Global.Project_Final.My.Resources.Resources.bg_home
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenedor.Location = New System.Drawing.Point(277, 93)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(970, 650)
        Me.PanelContenedor.TabIndex = 11
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1214, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 31)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DarkGreen
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCrear.Location = New System.Drawing.Point(1, 669)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(270, 74)
        Me.btnCrear.TabIndex = 13
        Me.btnCrear.Text = "Nueva Venta"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1270, 750)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnFormasPago)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnPrendas)
        Me.Controls.Add(Me.btnMarcas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnPrendas As Button
    Friend WithEvents btnMarcas As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnFormasPago As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
