<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_conc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_conc))
        Me.Value1 = New System.Windows.Forms.TextBox()
        Me.Btn_conc = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.username = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Value1
        '
        Me.Value1.Location = New System.Drawing.Point(346, 159)
        Me.Value1.Name = "Value1"
        Me.Value1.Size = New System.Drawing.Size(100, 20)
        Me.Value1.TabIndex = 0
        '
        'Btn_conc
        '
        Me.Btn_conc.Location = New System.Drawing.Point(346, 220)
        Me.Btn_conc.Name = "Btn_conc"
        Me.Btn_conc.Size = New System.Drawing.Size(100, 23)
        Me.Btn_conc.TabIndex = 1
        Me.Btn_conc.Text = "Concatenar"
        Me.Btn_conc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(744, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(644, 13)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(98, 25)
        Me.username.TabIndex = 10
        Me.username.Text = "Username"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(348, 265)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 25)
        Me.result.TabIndex = 12
        '
        'Frm_conc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 404)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Btn_conc)
        Me.Controls.Add(Me.Value1)
        Me.Name = "Frm_conc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concatenar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Value1 As TextBox
    Friend WithEvents Btn_conc As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents username As Label
    Friend WithEvents result As Label
End Class
