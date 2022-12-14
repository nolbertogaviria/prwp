<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedidasYGramajes
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
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFiltrarCliente = New System.Windows.Forms.Label()
        Me.btnGuardarMedida = New System.Windows.Forms.Button()
        Me.txtMedida = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblGramaje = New System.Windows.Forms.Label()
        Me.btnGuardarGramaje = New System.Windows.Forms.Button()
        Me.txtGramaje = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvOperarios = New System.Windows.Forms.DataGridView()
        Me.lblNuevoTipo = New System.Windows.Forms.Label()
        Me.btnGuardarOperario = New System.Windows.Forms.Button()
        Me.txtOperario = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvRebobinadoras = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarRebob = New System.Windows.Forms.Button()
        Me.txtRebobinadora = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvOperarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvRebobinadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(14, 382)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(148, 16)
        Me.lblResultado.TabIndex = 25
        Me.lblResultado.Text = "Esperando operación..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFiltrarCliente)
        Me.GroupBox1.Controls.Add(Me.btnGuardarMedida)
        Me.GroupBox1.Controls.Add(Me.txtMedida)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 356)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medidas"
        '
        'lblFiltrarCliente
        '
        Me.lblFiltrarCliente.AutoSize = True
        Me.lblFiltrarCliente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFiltrarCliente.Location = New System.Drawing.Point(6, 26)
        Me.lblFiltrarCliente.Name = "lblFiltrarCliente"
        Me.lblFiltrarCliente.Size = New System.Drawing.Size(79, 13)
        Me.lblFiltrarCliente.TabIndex = 27
        Me.lblFiltrarCliente.Text = "Nueva medida:"
        '
        'btnGuardarMedida
        '
        Me.btnGuardarMedida.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarMedida.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarMedida.Location = New System.Drawing.Point(197, 19)
        Me.btnGuardarMedida.Name = "btnGuardarMedida"
        Me.btnGuardarMedida.Size = New System.Drawing.Size(70, 27)
        Me.btnGuardarMedida.TabIndex = 26
        Me.btnGuardarMedida.Text = "Guardar"
        Me.btnGuardarMedida.UseVisualStyleBackColor = False
        '
        'txtMedida
        '
        Me.txtMedida.Location = New System.Drawing.Point(91, 23)
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.Size = New System.Drawing.Size(100, 20)
        Me.txtMedida.TabIndex = 25
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 52)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(262, 296)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblGramaje)
        Me.GroupBox2.Controls.Add(Me.btnGuardarGramaje)
        Me.GroupBox2.Controls.Add(Me.txtGramaje)
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 356)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gramajes"
        '
        'lblGramaje
        '
        Me.lblGramaje.AutoSize = True
        Me.lblGramaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblGramaje.Location = New System.Drawing.Point(6, 26)
        Me.lblGramaje.Name = "lblGramaje"
        Me.lblGramaje.Size = New System.Drawing.Size(82, 13)
        Me.lblGramaje.TabIndex = 27
        Me.lblGramaje.Text = "Nuevo gramaje:"
        '
        'btnGuardarGramaje
        '
        Me.btnGuardarGramaje.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarGramaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarGramaje.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarGramaje.Location = New System.Drawing.Point(197, 19)
        Me.btnGuardarGramaje.Name = "btnGuardarGramaje"
        Me.btnGuardarGramaje.Size = New System.Drawing.Size(70, 27)
        Me.btnGuardarGramaje.TabIndex = 26
        Me.btnGuardarGramaje.Text = "Guardar"
        Me.btnGuardarGramaje.UseVisualStyleBackColor = False
        '
        'txtGramaje
        '
        Me.txtGramaje.Location = New System.Drawing.Point(91, 23)
        Me.txtGramaje.Name = "txtGramaje"
        Me.txtGramaje.Size = New System.Drawing.Size(100, 20)
        Me.txtGramaje.TabIndex = 25
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(5, 52)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(262, 296)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvOperarios)
        Me.GroupBox3.Controls.Add(Me.lblNuevoTipo)
        Me.GroupBox3.Controls.Add(Me.btnGuardarOperario)
        Me.GroupBox3.Controls.Add(Me.txtOperario)
        Me.GroupBox3.Location = New System.Drawing.Point(573, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 356)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operarios"
        '
        'dgvOperarios
        '
        Me.dgvOperarios.AllowUserToAddRows = False
        Me.dgvOperarios.AllowUserToOrderColumns = True
        Me.dgvOperarios.AllowUserToResizeRows = False
        Me.dgvOperarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvOperarios.Location = New System.Drawing.Point(3, 57)
        Me.dgvOperarios.Name = "dgvOperarios"
        Me.dgvOperarios.ReadOnly = True
        Me.dgvOperarios.RowHeadersVisible = False
        Me.dgvOperarios.RowHeadersWidth = 36
        Me.dgvOperarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOperarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOperarios.Size = New System.Drawing.Size(268, 296)
        Me.dgvOperarios.TabIndex = 29
        '
        'lblNuevoTipo
        '
        Me.lblNuevoTipo.AutoSize = True
        Me.lblNuevoTipo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNuevoTipo.Location = New System.Drawing.Point(6, 26)
        Me.lblNuevoTipo.Name = "lblNuevoTipo"
        Me.lblNuevoTipo.Size = New System.Drawing.Size(85, 13)
        Me.lblNuevoTipo.TabIndex = 27
        Me.lblNuevoTipo.Text = "Nuevo Operario:"
        '
        'btnGuardarOperario
        '
        Me.btnGuardarOperario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarOperario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarOperario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarOperario.Location = New System.Drawing.Point(197, 19)
        Me.btnGuardarOperario.Name = "btnGuardarOperario"
        Me.btnGuardarOperario.Size = New System.Drawing.Size(70, 27)
        Me.btnGuardarOperario.TabIndex = 26
        Me.btnGuardarOperario.Text = "Guardar"
        Me.btnGuardarOperario.UseVisualStyleBackColor = False
        '
        'txtOperario
        '
        Me.txtOperario.Location = New System.Drawing.Point(91, 23)
        Me.txtOperario.Name = "txtOperario"
        Me.txtOperario.Size = New System.Drawing.Size(100, 20)
        Me.txtOperario.TabIndex = 25
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvRebobinadoras)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.btnGuardarRebob)
        Me.GroupBox4.Controls.Add(Me.txtRebobinadora)
        Me.GroupBox4.Location = New System.Drawing.Point(853, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(274, 356)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rebobinadoras"
        '
        'dgvRebobinadoras
        '
        Me.dgvRebobinadoras.AllowUserToAddRows = False
        Me.dgvRebobinadoras.AllowUserToOrderColumns = True
        Me.dgvRebobinadoras.AllowUserToResizeRows = False
        Me.dgvRebobinadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRebobinadoras.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvRebobinadoras.Location = New System.Drawing.Point(3, 57)
        Me.dgvRebobinadoras.Name = "dgvRebobinadoras"
        Me.dgvRebobinadoras.ReadOnly = True
        Me.dgvRebobinadoras.RowHeadersVisible = False
        Me.dgvRebobinadoras.RowHeadersWidth = 36
        Me.dgvRebobinadoras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRebobinadoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRebobinadoras.Size = New System.Drawing.Size(268, 296)
        Me.dgvRebobinadoras.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nueva Rebob.:"
        '
        'btnGuardarRebob
        '
        Me.btnGuardarRebob.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarRebob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarRebob.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarRebob.Location = New System.Drawing.Point(197, 19)
        Me.btnGuardarRebob.Name = "btnGuardarRebob"
        Me.btnGuardarRebob.Size = New System.Drawing.Size(70, 27)
        Me.btnGuardarRebob.TabIndex = 26
        Me.btnGuardarRebob.Text = "Guardar"
        Me.btnGuardarRebob.UseVisualStyleBackColor = False
        '
        'txtRebobinadora
        '
        Me.txtRebobinadora.Location = New System.Drawing.Point(91, 23)
        Me.txtRebobinadora.Name = "txtRebobinadora"
        Me.txtRebobinadora.Size = New System.Drawing.Size(100, 20)
        Me.txtRebobinadora.TabIndex = 25
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRefresh.Location = New System.Drawing.Point(1023, 374)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(101, 27)
        Me.btnRefresh.TabIndex = 29
        Me.btnRefresh.Text = "Refrescar"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'MedidasYGramajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 504)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MedidasYGramajes"
        Me.Text = "Medidas, Gramajes, Operarios y Rebobinadoras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvOperarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvRebobinadoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResultado As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFiltrarCliente As Label
    Friend WithEvents btnGuardarMedida As Button
    Friend WithEvents txtMedida As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblGramaje As Label
    Friend WithEvents btnGuardarGramaje As Button
    Friend WithEvents txtGramaje As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblNuevoTipo As Label
    Friend WithEvents btnGuardarOperario As Button
    Friend WithEvents txtOperario As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardarRebob As Button
    Friend WithEvents txtRebobinadora As TextBox
    Friend WithEvents dgvRebobinadoras As DataGridView
    Friend WithEvents dgvOperarios As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
