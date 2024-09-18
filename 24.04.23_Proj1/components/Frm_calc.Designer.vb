<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_calc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_calc))
        Me.Value1 = New System.Windows.Forms.TextBox()
        Me.Value2 = New System.Windows.Forms.TextBox()
        Me.Btn_sum = New System.Windows.Forms.Button()
        Me.Btn_res = New System.Windows.Forms.Button()
        Me.Btn_div = New System.Windows.Forms.Button()
        Me.Btn_mult = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.result = New System.Windows.Forms.Label()
        Me.Btn_clear = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Value1
        '
        Me.Value1.Location = New System.Drawing.Point(352, 142)
        Me.Value1.Name = "Value1"
        Me.Value1.Size = New System.Drawing.Size(100, 20)
        Me.Value1.TabIndex = 0
        '
        'Value2
        '
        Me.Value2.Location = New System.Drawing.Point(352, 181)
        Me.Value2.Name = "Value2"
        Me.Value2.Size = New System.Drawing.Size(100, 20)
        Me.Value2.TabIndex = 1
        '
        'Btn_sum
        '
        Me.Btn_sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_sum.Location = New System.Drawing.Point(303, 233)
        Me.Btn_sum.Name = "Btn_sum"
        Me.Btn_sum.Size = New System.Drawing.Size(32, 31)
        Me.Btn_sum.TabIndex = 2
        Me.Btn_sum.Text = "+"
        Me.Btn_sum.UseVisualStyleBackColor = True
        '
        'Btn_res
        '
        Me.Btn_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_res.Location = New System.Drawing.Point(359, 233)
        Me.Btn_res.Name = "Btn_res"
        Me.Btn_res.Size = New System.Drawing.Size(32, 31)
        Me.Btn_res.TabIndex = 3
        Me.Btn_res.Text = "-"
        Me.Btn_res.UseVisualStyleBackColor = True
        '
        'Btn_div
        '
        Me.Btn_div.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_div.Location = New System.Drawing.Point(414, 233)
        Me.Btn_div.Name = "Btn_div"
        Me.Btn_div.Size = New System.Drawing.Size(32, 31)
        Me.Btn_div.TabIndex = 4
        Me.Btn_div.Text = "/"
        Me.Btn_div.UseVisualStyleBackColor = True
        '
        'Btn_mult
        '
        Me.Btn_mult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_mult.Location = New System.Drawing.Point(468, 233)
        Me.Btn_mult.Name = "Btn_mult"
        Me.Btn_mult.Size = New System.Drawing.Size(32, 31)
        Me.Btn_mult.TabIndex = 5
        Me.Btn_mult.Text = "*"
        Me.Btn_mult.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(673, 14)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(98, 25)
        Me.username.TabIndex = 8
        Me.username.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(641, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(373, 292)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 25)
        Me.result.TabIndex = 10
        '
        'Btn_clear
        '
        Me.Btn_clear.Location = New System.Drawing.Point(352, 343)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(100, 23)
        Me.Btn_clear.TabIndex = 6
        Me.Btn_clear.Text = "Limpiar"
        Me.Btn_clear.UseVisualStyleBackColor = True
        '
        'Frm_calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 405)
        Me.Controls.Add(Me.Btn_clear)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Btn_mult)
        Me.Controls.Add(Me.Btn_div)
        Me.Controls.Add(Me.Btn_res)
        Me.Controls.Add(Me.Btn_sum)
        Me.Controls.Add(Me.Value2)
        Me.Controls.Add(Me.Value1)
        Me.Name = "Frm_calc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Value1 As TextBox
    Friend WithEvents Value2 As TextBox
    Friend WithEvents Btn_sum As Button
    Friend WithEvents Btn_res As Button
    Friend WithEvents Btn_div As Button
    Friend WithEvents Btn_mult As Button
    Friend WithEvents username As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents result As Label
    Friend WithEvents Btn_clear As Button
End Class
