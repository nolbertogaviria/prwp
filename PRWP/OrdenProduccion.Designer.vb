<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenProduccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblConsecutivo = New System.Windows.Forms.Label()
        Me.btnGuardarMedida = New System.Windows.Forms.Button()
        Me.txtConsecutivo = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.panelDetalle = New System.Windows.Forms.Panel()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbGramaje = New System.Windows.Forms.ComboBox()
        Me.lblGramaje = New System.Windows.Forms.Label()
        Me.cmbMedida = New System.Windows.Forms.ComboBox()
        Me.lblMedida = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.panelDetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConsecutivo
        '
        Me.lblConsecutivo.AutoSize = True
        Me.lblConsecutivo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblConsecutivo.Location = New System.Drawing.Point(12, 41)
        Me.lblConsecutivo.Name = "lblConsecutivo"
        Me.lblConsecutivo.Size = New System.Drawing.Size(69, 13)
        Me.lblConsecutivo.TabIndex = 30
        Me.lblConsecutivo.Text = "Consecutivo:"
        '
        'btnGuardarMedida
        '
        Me.btnGuardarMedida.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarMedida.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarMedida.Location = New System.Drawing.Point(288, 197)
        Me.btnGuardarMedida.Name = "btnGuardarMedida"
        Me.btnGuardarMedida.Size = New System.Drawing.Size(70, 32)
        Me.btnGuardarMedida.TabIndex = 7
        Me.btnGuardarMedida.Text = "Guardar"
        Me.btnGuardarMedida.UseVisualStyleBackColor = False
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(99, 39)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(259, 20)
        Me.txtConsecutivo.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCliente.Location = New System.Drawing.Point(12, 15)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 42
        Me.lblCliente.Text = "Cliente:"
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(99, 12)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(259, 21)
        Me.cmbCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(12, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(99, 144)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(259, 47)
        Me.txtObservaciones.TabIndex = 6
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFecha.Location = New System.Drawing.Point(12, 67)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 55
        Me.lblFecha.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(99, 65)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(259, 20)
        Me.txtFecha.TabIndex = 3
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblUsuario.Location = New System.Drawing.Point(12, 93)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 57
        Me.lblUsuario.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(99, 91)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(259, 20)
        Me.txtUsuario.TabIndex = 4
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEstado.Location = New System.Drawing.Point(12, 120)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 58
        Me.lblEstado.Text = "Estado:"
        '
        'panelDetalle
        '
        Me.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalle.Controls.Add(Me.txtPeso)
        Me.panelDetalle.Controls.Add(Me.Label2)
        Me.panelDetalle.Controls.Add(Me.dgvDetalle)
        Me.panelDetalle.Controls.Add(Me.btnAdd)
        Me.panelDetalle.Controls.Add(Me.cmbGramaje)
        Me.panelDetalle.Controls.Add(Me.lblGramaje)
        Me.panelDetalle.Controls.Add(Me.cmbMedida)
        Me.panelDetalle.Controls.Add(Me.lblMedida)
        Me.panelDetalle.Location = New System.Drawing.Point(369, 12)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Size = New System.Drawing.Size(422, 434)
        Me.panelDetalle.TabIndex = 61
        Me.panelDetalle.Visible = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToOrderColumns = True
        Me.dgvDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        Me.dgvDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetalle.Location = New System.Drawing.Point(7, 48)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(406, 377)
        Me.dgvDetalle.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Location = New System.Drawing.Point(336, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 22)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmbGramaje
        '
        Me.cmbGramaje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGramaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGramaje.FormattingEnabled = True
        Me.cmbGramaje.Location = New System.Drawing.Point(79, 20)
        Me.cmbGramaje.Name = "cmbGramaje"
        Me.cmbGramaje.Size = New System.Drawing.Size(66, 21)
        Me.cmbGramaje.TabIndex = 9
        '
        'lblGramaje
        '
        Me.lblGramaje.AutoSize = True
        Me.lblGramaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblGramaje.Location = New System.Drawing.Point(76, 4)
        Me.lblGramaje.Name = "lblGramaje"
        Me.lblGramaje.Size = New System.Drawing.Size(49, 13)
        Me.lblGramaje.TabIndex = 63
        Me.lblGramaje.Text = "Gramaje:"
        '
        'cmbMedida
        '
        Me.cmbMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMedida.FormattingEnabled = True
        Me.cmbMedida.Location = New System.Drawing.Point(7, 20)
        Me.cmbMedida.Name = "cmbMedida"
        Me.cmbMedida.Size = New System.Drawing.Size(66, 21)
        Me.cmbMedida.TabIndex = 8
        '
        'lblMedida
        '
        Me.lblMedida.AutoSize = True
        Me.lblMedida.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMedida.Location = New System.Drawing.Point(4, 4)
        Me.lblMedida.Name = "lblMedida"
        Me.lblMedida.Size = New System.Drawing.Size(45, 13)
        Me.lblMedida.TabIndex = 61
        Me.lblMedida.Text = "Medida:"
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(8, 394)
        Me.lblResultado.Multiline = True
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.ReadOnly = True
        Me.lblResultado.Size = New System.Drawing.Size(353, 52)
        Me.lblResultado.TabIndex = 62
        Me.lblResultado.Text = "Esperando operación..."
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(99, 117)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(173, 21)
        Me.cmbEstado.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(154, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Peso Requerido:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(157, 20)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtPeso.TabIndex = 65
        '
        'OrdenProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.panelDetalle)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.lblConsecutivo)
        Me.Controls.Add(Me.btnGuardarMedida)
        Me.Controls.Add(Me.txtConsecutivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "OrdenProduccion"
        Me.ShowIcon = False
        Me.Text = "Nueva Orden de Producción"
        Me.TopMost = True
        Me.panelDetalle.ResumeLayout(False)
        Me.panelDetalle.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConsecutivo As Label
    Friend WithEvents btnGuardarMedida As Button
    Friend WithEvents txtConsecutivo As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents panelDetalle As Panel
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbGramaje As ComboBox
    Friend WithEvents lblGramaje As Label
    Friend WithEvents cmbMedida As ComboBox
    Friend WithEvents lblMedida As Label
    Friend WithEvents lblResultado As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label2 As Label
End Class
