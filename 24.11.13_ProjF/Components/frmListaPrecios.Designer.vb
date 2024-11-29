<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPrecios
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SpulistapreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tienda_ropaDataSet1 = New Project_Final.tienda_ropaDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Spu_lista_preciosTableAdapter = New Project_Final.tienda_ropaDataSet1TableAdapters.spu_lista_preciosTableAdapter()
        CType(Me.SpulistapreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tienda_ropaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpulistapreciosBindingSource
        '
        Me.SpulistapreciosBindingSource.DataMember = "spu_lista_precios"
        Me.SpulistapreciosBindingSource.DataSource = Me.Tienda_ropaDataSet1
        '
        'Tienda_ropaDataSet1
        '
        Me.Tienda_ropaDataSet1.DataSetName = "tienda_ropaDataSet1"
        Me.Tienda_ropaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetListaPrecios"
        ReportDataSource1.Value = Me.SpulistapreciosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Project_Final.rptListaPrecios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Spu_lista_preciosTableAdapter
        '
        Me.Spu_lista_preciosTableAdapter.ClearBeforeFill = True
        '
        'frmListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmListaPrecios"
        Me.Text = "frmListaPrecios"
        CType(Me.SpulistapreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tienda_ropaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tienda_ropaDataSet1 As tienda_ropaDataSet1
    Friend WithEvents SpulistapreciosBindingSource As BindingSource
    Friend WithEvents Spu_lista_preciosTableAdapter As tienda_ropaDataSet1TableAdapters.spu_lista_preciosTableAdapter
End Class
