<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orden_produccion
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.report_opBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.prwpDataSet = New PRWP.prwpDataSet()
        Me.ReportOP = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.report_opTableAdapter = New PRWP.prwpDataSetTableAdapters.report_opTableAdapter()
        Me.prwpDataSet1 = New PRWP.prwpDataSet1()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.report_opBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prwpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prwpDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'report_opBindingSource
        '
        Me.report_opBindingSource.DataMember = "report_op"
        Me.report_opBindingSource.DataSource = Me.prwpDataSet
        '
        'prwpDataSet
        '
        Me.prwpDataSet.DataSetName = "prwpDataSet"
        Me.prwpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportOP
        '
        Me.ReportOP.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetOP"
        ReportDataSource2.Value = Me.report_opBindingSource
        Me.ReportOP.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportOP.LocalReport.ReportEmbeddedResource = "PRWP.orden_produccion.rdlc"
        Me.ReportOP.Location = New System.Drawing.Point(3, 63)
        Me.ReportOP.Name = "ReportOP"
        Me.ReportOP.ServerReport.BearerToken = Nothing
        Me.ReportOP.Size = New System.Drawing.Size(794, 384)
        Me.ReportOP.TabIndex = 0
        '
        'report_opTableAdapter
        '
        Me.report_opTableAdapter.ClearBeforeFill = True
        '
        'prwpDataSet1
        '
        Me.prwpDataSet1.DataSetName = "prwpDataSet1"
        Me.prwpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportOP, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'orden_produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "orden_produccion"
        Me.Text = "orden_produccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.report_opBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prwpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prwpDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportOP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents report_opBindingSource As BindingSource
    Friend WithEvents prwpDataSet As prwpDataSet
    Friend WithEvents report_opTableAdapter As prwpDataSetTableAdapters.report_opTableAdapter
    Friend WithEvents prwpDataSet1 As prwpDataSet1
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
