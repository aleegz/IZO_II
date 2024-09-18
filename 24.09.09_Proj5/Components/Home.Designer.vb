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
        Me.btnSucursales = New System.Windows.Forms.Button()
        Me.btnVendedores = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSucursales
        '
        Me.btnSucursales.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSucursales.Font = New System.Drawing.Font("Noto Sans Cond", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSucursales.Location = New System.Drawing.Point(391, 136)
        Me.btnSucursales.Name = "btnSucursales"
        Me.btnSucursales.Size = New System.Drawing.Size(102, 35)
        Me.btnSucursales.TabIndex = 0
        Me.btnSucursales.Text = "Sucursales"
        Me.btnSucursales.UseVisualStyleBackColor = False
        '
        'btnVendedores
        '
        Me.btnVendedores.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendedores.Font = New System.Drawing.Font("Noto Sans Cond", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVendedores.Location = New System.Drawing.Point(391, 244)
        Me.btnVendedores.Name = "btnVendedores"
        Me.btnVendedores.Size = New System.Drawing.Size(102, 35)
        Me.btnVendedores.TabIndex = 1
        Me.btnVendedores.Text = "Vendedores"
        Me.btnVendedores.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Noto Sans Cond", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVentas.Location = New System.Drawing.Point(391, 352)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(102, 35)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Noto Sans Cond", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(365, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(155, 39)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Bienvenido"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project5.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(884, 430)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnVendedores)
        Me.Controls.Add(Me.btnSucursales)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSucursales As Button
    Friend WithEvents btnVendedores As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents lblTitle As Label
End Class
