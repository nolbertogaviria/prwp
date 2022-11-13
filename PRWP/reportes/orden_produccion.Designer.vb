<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orden_produccion
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportOP = New Microsoft.Reporting.WinForms.ReportViewer()
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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.reporte_orden_produccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.prwpDataSet = New PRWP.prwpDataSet()
        Me.PrwpDataSet1 = New PRWP.prwpDataSet()
        Me.reporte_orden_produccionTableAdapter = New PRWP.prwpDataSetTableAdapters.reporte_orden_produccionTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.reporte_orden_produccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prwpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrwpDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportOP
        '
        Me.ReportOP.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.reporte_orden_produccionBindingSource
        Me.ReportOP.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportOP.LocalReport.DisplayName = "r0"
        Me.ReportOP.LocalReport.ReportEmbeddedResource = "PRWP.orden_produccion.rdlc"
        Me.ReportOP.Location = New System.Drawing.Point(3, 63)
        Me.ReportOP.Name = "ReportOP"
        Me.ReportOP.ServerReport.BearerToken = Nothing
        Me.ReportOP.Size = New System.Drawing.Size(794, 384)
        Me.ReportOP.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
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
        Me.TableLayoutPanel2.Controls.Add(Me.btnProcesar, 6, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(768, 54)
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
        Me.cmbOrdenarPor.Visible = False
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
        Me.lblOrden.Visible = False
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
        Me.lblOrdenarPor.Visible = False
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
        Me.lblFiltrarPor.Visible = False
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
        Me.lblFiltro.Visible = False
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
        Me.txtFiltro.Visible = False
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Cliente", "Fecha OP", "Gramaje", "Medida", "Orden de Producción", "Puesta a Punto"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(264, 3)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(148, 21)
        Me.cmbFiltrarPor.TabIndex = 8
        Me.cmbFiltrarPor.Visible = False
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(150, 21)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'radDesc
        '
        Me.radDesc.AutoSize = True
        Me.radDesc.Location = New System.Drawing.Point(78, 3)
        Me.radDesc.Name = "radDesc"
        Me.radDesc.Size = New System.Drawing.Size(53, 15)
        Me.radDesc.TabIndex = 1
        Me.radDesc.Text = "Desc."
        Me.radDesc.UseVisualStyleBackColor = True
        Me.radDesc.Visible = False
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
        Me.radAsc.Visible = False
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnProcesar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProcesar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProcesar.Location = New System.Drawing.Point(690, 3)
        Me.btnProcesar.Name = "btnProcesar"
        Me.TableLayoutPanel2.SetRowSpan(Me.btnProcesar, 2)
        Me.btnProcesar.Size = New System.Drawing.Size(75, 48)
        Me.btnProcesar.TabIndex = 13
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'reporte_orden_produccionBindingSource
        '
        Me.reporte_orden_produccionBindingSource.DataMember = "reporte_orden_produccion"
        Me.reporte_orden_produccionBindingSource.DataSource = Me.prwpDataSet
        '
        'prwpDataSet
        '
        Me.prwpDataSet.DataSetName = "prwpDataSet"
        Me.prwpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrwpDataSet1
        '
        Me.PrwpDataSet1.DataSetName = "prwpDataSet"
        Me.PrwpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporte_orden_produccionTableAdapter
        '
        Me.reporte_orden_produccionTableAdapter.ClearBeforeFill = True
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.reporte_orden_produccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prwpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrwpDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents btnProcesar As Button
    Friend WithEvents ReportOP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrwpDataSet1 As prwpDataSet
    Friend WithEvents reporte_orden_produccionBindingSource As BindingSource
    Friend WithEvents prwpDataSet As prwpDataSet
    Friend WithEvents reporte_orden_produccionTableAdapter As prwpDataSetTableAdapters.reporte_orden_produccionTableAdapter
End Class
