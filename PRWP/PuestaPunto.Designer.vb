<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PuestaPunto
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblPP = New System.Windows.Forms.TableLayoutPanel()
        Me.grpDetallePP = New System.Windows.Forms.GroupBox()
        Me.dgvDetallePP = New System.Windows.Forms.DataGridView()
        Me.grpOP = New System.Windows.Forms.GroupBox()
        Me.tblOPp = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvOP = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbOPGram = New System.Windows.Forms.ComboBox()
        Me.lblGramaje = New System.Windows.Forms.Label()
        Me.grpOPDetalle = New System.Windows.Forms.GroupBox()
        Me.lblMedidas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotalMeds = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtOperario = New System.Windows.Forms.TextBox()
        Me.lblOperario = New System.Windows.Forms.Label()
        Me.txtRebobinadora = New System.Windows.Forms.TextBox()
        Me.lblRebob = New System.Windows.Forms.Label()
        Me.tblPP.SuspendLayout()
        Me.grpDetallePP.SuspendLayout()
        CType(Me.dgvDetallePP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOP.SuspendLayout()
        Me.tblOPp.SuspendLayout()
        CType(Me.dgvOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpOPDetalle.SuspendLayout()
        CType(Me.lblMedidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblPP
        '
        Me.tblPP.ColumnCount = 2
        Me.tblPP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPP.Controls.Add(Me.grpDetallePP, 0, 1)
        Me.tblPP.Controls.Add(Me.grpOP, 0, 0)
        Me.tblPP.Controls.Add(Me.grpOPDetalle, 1, 0)
        Me.tblPP.Controls.Add(Me.Panel1, 0, 2)
        Me.tblPP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPP.Location = New System.Drawing.Point(0, 0)
        Me.tblPP.Name = "tblPP"
        Me.tblPP.RowCount = 3
        Me.tblPP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tblPP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tblPP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblPP.Size = New System.Drawing.Size(800, 562)
        Me.tblPP.TabIndex = 0
        '
        'grpDetallePP
        '
        Me.tblPP.SetColumnSpan(Me.grpDetallePP, 2)
        Me.grpDetallePP.Controls.Add(Me.dgvDetallePP)
        Me.grpDetallePP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDetallePP.Location = New System.Drawing.Point(3, 255)
        Me.grpDetallePP.Name = "grpDetallePP"
        Me.grpDetallePP.Size = New System.Drawing.Size(794, 246)
        Me.grpDetallePP.TabIndex = 3
        Me.grpDetallePP.TabStop = False
        Me.grpDetallePP.Text = "Detalle de la Puesta a Punto"
        '
        'dgvDetallePP
        '
        Me.dgvDetallePP.AllowUserToAddRows = False
        Me.dgvDetallePP.AllowUserToOrderColumns = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetallePP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetallePP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetallePP.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDetallePP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetallePP.Location = New System.Drawing.Point(3, 16)
        Me.dgvDetallePP.Name = "dgvDetallePP"
        Me.dgvDetallePP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetallePP.Size = New System.Drawing.Size(788, 227)
        Me.dgvDetallePP.TabIndex = 2
        '
        'grpOP
        '
        Me.grpOP.Controls.Add(Me.tblOPp)
        Me.grpOP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOP.Location = New System.Drawing.Point(3, 3)
        Me.grpOP.Name = "grpOP"
        Me.grpOP.Size = New System.Drawing.Size(394, 246)
        Me.grpOP.TabIndex = 0
        Me.grpOP.TabStop = False
        Me.grpOP.Text = "Listado de OPs Pendientes"
        '
        'tblOPp
        '
        Me.tblOPp.ColumnCount = 1
        Me.tblOPp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblOPp.Controls.Add(Me.dgvOP, 0, 1)
        Me.tblOPp.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tblOPp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblOPp.Location = New System.Drawing.Point(3, 16)
        Me.tblOPp.Name = "tblOPp"
        Me.tblOPp.RowCount = 2
        Me.tblOPp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tblOPp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblOPp.Size = New System.Drawing.Size(388, 227)
        Me.tblOPp.TabIndex = 0
        '
        'dgvOP
        '
        Me.dgvOP.AllowUserToAddRows = False
        Me.dgvOP.AllowUserToDeleteRows = False
        Me.dgvOP.AllowUserToOrderColumns = True
        Me.dgvOP.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOP.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvOP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOP.Location = New System.Drawing.Point(3, 35)
        Me.dgvOP.MultiSelect = False
        Me.dgvOP.Name = "dgvOP"
        Me.dgvOP.ReadOnly = True
        Me.dgvOP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOP.Size = New System.Drawing.Size(382, 189)
        Me.dgvOP.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOPGram, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGramaje, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(382, 26)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'cmbOPGram
        '
        Me.cmbOPGram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOPGram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOPGram.FormattingEnabled = True
        Me.cmbOPGram.Location = New System.Drawing.Point(63, 3)
        Me.cmbOPGram.Name = "cmbOPGram"
        Me.cmbOPGram.Size = New System.Drawing.Size(79, 21)
        Me.cmbOPGram.TabIndex = 63
        '
        'lblGramaje
        '
        Me.lblGramaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGramaje.AutoSize = True
        Me.lblGramaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblGramaje.Location = New System.Drawing.Point(3, 0)
        Me.lblGramaje.Name = "lblGramaje"
        Me.lblGramaje.Size = New System.Drawing.Size(54, 27)
        Me.lblGramaje.TabIndex = 62
        Me.lblGramaje.Text = "Gramaje:"
        '
        'grpOPDetalle
        '
        Me.grpOPDetalle.Controls.Add(Me.lblMedidas)
        Me.grpOPDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOPDetalle.Location = New System.Drawing.Point(403, 3)
        Me.grpOPDetalle.Name = "grpOPDetalle"
        Me.grpOPDetalle.Size = New System.Drawing.Size(394, 246)
        Me.grpOPDetalle.TabIndex = 2
        Me.grpOPDetalle.TabStop = False
        Me.grpOPDetalle.Text = "Detalle de la OP"
        '
        'lblMedidas
        '
        Me.lblMedidas.AllowUserToAddRows = False
        Me.lblMedidas.AllowUserToDeleteRows = False
        Me.lblMedidas.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lblMedidas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.lblMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lblMedidas.DefaultCellStyle = DataGridViewCellStyle12
        Me.lblMedidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMedidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lblMedidas.Location = New System.Drawing.Point(3, 16)
        Me.lblMedidas.Name = "lblMedidas"
        Me.lblMedidas.ReadOnly = True
        Me.lblMedidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lblMedidas.Size = New System.Drawing.Size(388, 227)
        Me.lblMedidas.TabIndex = 1
        '
        'Panel1
        '
        Me.tblPP.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.txtTotalMeds)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.txtOperario)
        Me.Panel1.Controls.Add(Me.lblOperario)
        Me.Panel1.Controls.Add(Me.txtRebobinadora)
        Me.Panel1.Controls.Add(Me.lblRebob)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 507)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 52)
        Me.Panel1.TabIndex = 4
        '
        'txtTotalMeds
        '
        Me.txtTotalMeds.Enabled = False
        Me.txtTotalMeds.Location = New System.Drawing.Point(89, 3)
        Me.txtTotalMeds.Name = "txtTotalMeds"
        Me.txtTotalMeds.Size = New System.Drawing.Size(134, 20)
        Me.txtTotalMeds.TabIndex = 53
        Me.txtTotalMeds.Text = "0"
        Me.txtTotalMeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Total Medidas:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnGuardar.Location = New System.Drawing.Point(710, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 49
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtOperario
        '
        Me.txtOperario.Location = New System.Drawing.Point(550, 5)
        Me.txtOperario.Name = "txtOperario"
        Me.txtOperario.Size = New System.Drawing.Size(139, 20)
        Me.txtOperario.TabIndex = 48
        '
        'lblOperario
        '
        Me.lblOperario.AutoSize = True
        Me.lblOperario.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblOperario.Location = New System.Drawing.Point(494, 8)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(50, 13)
        Me.lblOperario.TabIndex = 47
        Me.lblOperario.Text = "Operario:"
        '
        'txtRebobinadora
        '
        Me.txtRebobinadora.Location = New System.Drawing.Point(344, 3)
        Me.txtRebobinadora.Name = "txtRebobinadora"
        Me.txtRebobinadora.Size = New System.Drawing.Size(134, 20)
        Me.txtRebobinadora.TabIndex = 46
        '
        'lblRebob
        '
        Me.lblRebob.AutoSize = True
        Me.lblRebob.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblRebob.Location = New System.Drawing.Point(261, 6)
        Me.lblRebob.Name = "lblRebob"
        Me.lblRebob.Size = New System.Drawing.Size(77, 13)
        Me.lblRebob.TabIndex = 45
        Me.lblRebob.Text = "Rebobinadora:"
        '
        'PuestaPunto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.tblPP)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PuestaPunto"
        Me.ShowIcon = False
        Me.Text = "Puesta a Punto"
        Me.tblPP.ResumeLayout(False)
        Me.grpDetallePP.ResumeLayout(False)
        CType(Me.dgvDetallePP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOP.ResumeLayout(False)
        Me.tblOPp.ResumeLayout(False)
        CType(Me.dgvOP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpOPDetalle.ResumeLayout(False)
        CType(Me.lblMedidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblPP As TableLayoutPanel
    Friend WithEvents grpDetallePP As GroupBox
    Friend WithEvents grpOP As GroupBox
    Friend WithEvents grpOPDetalle As GroupBox
    Friend WithEvents dgvDetallePP As DataGridView
    Friend WithEvents lblMedidas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtOperario As TextBox
    Friend WithEvents lblOperario As Label
    Friend WithEvents txtRebobinadora As TextBox
    Friend WithEvents lblRebob As Label
    Friend WithEvents txtTotalMeds As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tblOPp As TableLayoutPanel
    Friend WithEvents dgvOP As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblGramaje As Label
    Friend WithEvents cmbOPGram As ComboBox
End Class
