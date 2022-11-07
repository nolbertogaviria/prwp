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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.report_opBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.prwpDataSet = New PRWP.prwpDataSet()
        Me.ReportOP = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.report_opTableAdapter = New PRWP.prwpDataSetTableAdapters.report_opTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbOrdenarPor = New System.Windows.Forms.ComboBox()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblOrdenarPor = New System.Windows.Forms.Label()
        Me.lblFiltrarPor = New System.Windows.Forms.Label()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.radDesc = New System.Windows.Forms.RadioButton()
        Me.radAsc = New System.Windows.Forms.RadioButton()
        Me.prwpDataSet1 = New PRWP.prwpDataSet1()
        CType(Me.report_opBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prwpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.prwpDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        ReportDataSource1.Name = "DataSetOP"
        ReportDataSource1.Value = Me.report_opBindingSource
        Me.ReportOP.LocalReport.DataSources.Add(ReportDataSource1)
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportOP, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbOrdenarPor, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOrden, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOrdenarPor, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiltrarPor, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFiltro, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFechaFin, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFechaIni, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpFechaIni, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpFechaFin, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFiltro, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbFiltrarPor, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 5, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(694, 54)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'cmbOrdenarPor
        '
        Me.cmbOrdenarPor.FormattingEnabled = True
        Me.cmbOrdenarPor.Items.AddRange(New Object() {"Cliente", "Fecha OP", "Gramaje", "Medida", "Orden de Producción", "Puesta a Punto"})
        Me.cmbOrdenarPor.Location = New System.Drawing.Point(534, 3)
        Me.cmbOrdenarPor.Name = "cmbOrdenarPor"
        Me.cmbOrdenarPor.Size = New System.Drawing.Size(148, 21)
        Me.cmbOrdenarPor.TabIndex = 11
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblOrden.Location = New System.Drawing.Point(489, 27)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(39, 27)
        Me.lblOrden.TabIndex = 10
        Me.lblOrden.Text = "Orden:"
        Me.lblOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOrdenarPor
        '
        Me.lblOrdenarPor.AutoSize = True
        Me.lblOrdenarPor.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblOrdenarPor.Location = New System.Drawing.Point(461, 0)
        Me.lblOrdenarPor.Name = "lblOrdenarPor"
        Me.lblOrdenarPor.Size = New System.Drawing.Size(67, 27)
        Me.lblOrdenarPor.TabIndex = 9
        Me.lblOrdenarPor.Text = "Ordenar Por:"
        Me.lblOrdenarPor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFiltrarPor
        '
        Me.lblFiltrarPor.AutoSize = True
        Me.lblFiltrarPor.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblFiltrarPor.Location = New System.Drawing.Point(204, 0)
        Me.lblFiltrarPor.Name = "lblFiltrarPor"
        Me.lblFiltrarPor.Size = New System.Drawing.Size(54, 27)
        Me.lblFiltrarPor.TabIndex = 3
        Me.lblFiltrarPor.Text = "Filtrar Por:"
        Me.lblFiltrarPor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblFiltro.Location = New System.Drawing.Point(226, 27)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(32, 27)
        Me.lblFiltro.TabIndex = 2
        Me.lblFiltro.Text = "Filtro:"
        Me.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblFechaFin.Location = New System.Drawing.Point(13, 27)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(65, 27)
        Me.lblFechaFin.TabIndex = 1
        Me.lblFechaFin.Text = "Fecha Final:"
        Me.lblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblFechaIni.Location = New System.Drawing.Point(8, 0)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 27)
        Me.lblFechaIni.TabIndex = 0
        Me.lblFechaIni.Text = "Fecha Inicial:"
        Me.lblFechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(84, 3)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaIni.TabIndex = 4
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(84, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaFin.TabIndex = 5
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(264, 30)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(148, 20)
        Me.txtFiltro.TabIndex = 7
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Cliente", "Fecha OP", "Gramaje", "Medida", "Orden de Producción", "Puesta a Punto"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(264, 3)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(148, 21)
        Me.cmbFiltrarPor.TabIndex = 8
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.radDesc, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.radAsc, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(534, 30)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(179, 21)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'radDesc
        '
        Me.radDesc.AutoSize = True
        Me.radDesc.Location = New System.Drawing.Point(92, 3)
        Me.radDesc.Name = "radDesc"
        Me.radDesc.Size = New System.Drawing.Size(53, 15)
        Me.radDesc.TabIndex = 1
        Me.radDesc.Text = "Desc."
        Me.radDesc.UseVisualStyleBackColor = True
        '
        'radAsc
        '
        Me.radAsc.AutoSize = True
        Me.radAsc.Checked = True
        Me.radAsc.Location = New System.Drawing.Point(3, 3)
        Me.radAsc.Name = "radAsc"
        Me.radAsc.Size = New System.Drawing.Size(46, 15)
        Me.radAsc.TabIndex = 0
        Me.radAsc.TabStop = True
        Me.radAsc.Text = "Asc."
        Me.radAsc.UseVisualStyleBackColor = True
        '
        'prwpDataSet1
        '
        Me.prwpDataSet1.DataSetName = "prwpDataSet1"
        Me.prwpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'orden_produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "orden_produccion"
        Me.Text = "P.R. - Reporte General"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.report_opBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prwpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.prwpDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportOP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents report_opBindingSource As BindingSource
    Friend WithEvents prwpDataSet As prwpDataSet
    Friend WithEvents report_opTableAdapter As prwpDataSetTableAdapters.report_opTableAdapter
    Friend WithEvents prwpDataSet1 As prwpDataSet1
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbOrdenarPor As ComboBox
    Friend WithEvents lblOrden As Label
    Friend WithEvents lblOrdenarPor As Label
    Friend WithEvents lblFiltrarPor As Label
    Friend WithEvents lblFiltro As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents dtpFechaIni As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents cmbFiltrarPor As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents radDesc As RadioButton
    Friend WithEvents radAsc As RadioButton
End Class
