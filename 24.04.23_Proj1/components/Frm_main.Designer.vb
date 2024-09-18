<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_main))
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnConc = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.username = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(187, 202)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalc.TabIndex = 0
        Me.BtnCalc.Text = "Calcular"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnConc
        '
        Me.BtnConc.Location = New System.Drawing.Point(506, 202)
        Me.BtnConc.Name = "BtnConc"
        Me.BtnConc.Size = New System.Drawing.Size(75, 23)
        Me.BtnConc.TabIndex = 1
        Me.BtnConc.Text = "Concatenar"
        Me.BtnConc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(646, 7)
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
        Me.username.Location = New System.Drawing.Point(678, 9)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(98, 25)
        Me.username.TabIndex = 10
        Me.username.Text = "Username"
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 403)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.BtnConc)
        Me.Controls.Add(Me.BtnCalc)
        Me.Name = "Frm_main"
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnConc As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents username As Label
End Class
