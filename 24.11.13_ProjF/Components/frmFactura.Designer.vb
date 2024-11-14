<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura
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
        Me.rptFactura = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rptFactura
        '
        Me.rptFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rptFactura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rptFactura.LocalReport.ReportEmbeddedResource = "Project_Final.rptVenta.rdlc"
        Me.rptFactura.Location = New System.Drawing.Point(0, 0)
        Me.rptFactura.Name = "rptFactura"
        Me.rptFactura.ServerReport.BearerToken = Nothing
        Me.rptFactura.ShowBackButton = False
        Me.rptFactura.ShowExportButton = False
        Me.rptFactura.ShowFindControls = False
        Me.rptFactura.ShowPageNavigationControls = False
        Me.rptFactura.ShowRefreshButton = False
        Me.rptFactura.ShowStopButton = False
        Me.rptFactura.ShowToolBar = False
        Me.rptFactura.Size = New System.Drawing.Size(847, 748)
        Me.rptFactura.TabIndex = 0
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(848, 749)
        Me.Controls.Add(Me.rptFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFactura"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rptFactura As Microsoft.Reporting.WinForms.ReportViewer
End Class
