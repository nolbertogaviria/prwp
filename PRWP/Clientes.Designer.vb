<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.rdiInactivos = New System.Windows.Forms.RadioButton()
        Me.rdiActivos = New System.Windows.Forms.RadioButton()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBoxUsuario = New System.Windows.Forms.GroupBox()
        Me.resFechaCreacion = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDv = New System.Windows.Forms.Label()
        Me.txtDv = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.lblNit = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ListBoxClientes = New System.Windows.Forms.ListBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtFiltrarCliente = New System.Windows.Forms.TextBox()
        Me.lblFiltrarCliente = New System.Windows.Forms.Label()
        Me.GroupBoxUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdiInactivos
        '
        Me.rdiInactivos.AutoSize = True
        Me.rdiInactivos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rdiInactivos.Location = New System.Drawing.Point(111, 63)
        Me.rdiInactivos.Name = "rdiInactivos"
        Me.rdiInactivos.Size = New System.Drawing.Size(68, 17)
        Me.rdiInactivos.TabIndex = 3
        Me.rdiInactivos.Text = "Inactivos"
        Me.rdiInactivos.UseVisualStyleBackColor = True
        '
        'rdiActivos
        '
        Me.rdiActivos.AutoSize = True
        Me.rdiActivos.Checked = True
        Me.rdiActivos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rdiActivos.Location = New System.Drawing.Point(12, 64)
        Me.rdiActivos.Name = "rdiActivos"
        Me.rdiActivos.Size = New System.Drawing.Size(60, 17)
        Me.rdiActivos.TabIndex = 2
        Me.rdiActivos.TabStop = True
        Me.rdiActivos.Text = "Activos"
        Me.rdiActivos.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(12, 9)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(117, 13)
        Me.lblResultado.TabIndex = 21
        Me.lblResultado.Text = "Esperando operación..."
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Location = New System.Drawing.Point(682, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 13)
        Me.txtId.TabIndex = 8
        Me.txtId.TabStop = False
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBoxUsuario
        '
        Me.GroupBoxUsuario.Controls.Add(Me.resFechaCreacion)
        Me.GroupBoxUsuario.Controls.Add(Me.txtObservaciones)
        Me.GroupBoxUsuario.Controls.Add(Me.Label2)
        Me.GroupBoxUsuario.Controls.Add(Me.cmbMunicipio)
        Me.GroupBoxUsuario.Controls.Add(Me.lblEmail)
        Me.GroupBoxUsuario.Controls.Add(Me.txtEmail)
        Me.GroupBoxUsuario.Controls.Add(Me.Label1)
        Me.GroupBoxUsuario.Controls.Add(Me.txtDireccion)
        Me.GroupBoxUsuario.Controls.Add(Me.lblDv)
        Me.GroupBoxUsuario.Controls.Add(Me.txtDv)
        Me.GroupBoxUsuario.Controls.Add(Me.chkActivo)
        Me.GroupBoxUsuario.Controls.Add(Me.lblActivo)
        Me.GroupBoxUsuario.Controls.Add(Me.txtTelefono)
        Me.GroupBoxUsuario.Controls.Add(Me.txtNombre)
        Me.GroupBoxUsuario.Controls.Add(Me.lblObservaciones)
        Me.GroupBoxUsuario.Controls.Add(Me.lblTelefono)
        Me.GroupBoxUsuario.Controls.Add(Me.lblNombre)
        Me.GroupBoxUsuario.Controls.Add(Me.lblFechaCreacion)
        Me.GroupBoxUsuario.Controls.Add(Me.lblNit)
        Me.GroupBoxUsuario.Controls.Add(Me.txtNit)
        Me.GroupBoxUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxUsuario.Location = New System.Drawing.Point(243, 37)
        Me.GroupBoxUsuario.Name = "GroupBoxUsuario"
        Me.GroupBoxUsuario.Size = New System.Drawing.Size(566, 358)
        Me.GroupBoxUsuario.TabIndex = 5
        Me.GroupBoxUsuario.TabStop = False
        Me.GroupBoxUsuario.Text = "Datos de Cliente"
        '
        'resFechaCreacion
        '
        Me.resFechaCreacion.AutoSize = True
        Me.resFechaCreacion.Location = New System.Drawing.Point(88, 269)
        Me.resFechaCreacion.Name = "resFechaCreacion"
        Me.resFechaCreacion.Size = New System.Drawing.Size(82, 13)
        Me.resFechaCreacion.TabIndex = 42
        Me.resFechaCreacion.Text = "Fecha Creación"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(91, 190)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(463, 50)
        Me.txtObservaciones.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(30, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Municipio:"
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(91, 110)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(233, 21)
        Me.cmbMunicipio.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEmail.Location = New System.Drawing.Point(50, 141)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 38
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(91, 138)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(463, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(30, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(91, 84)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(463, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'lblDv
        '
        Me.lblDv.AutoSize = True
        Me.lblDv.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblDv.Location = New System.Drawing.Point(220, 35)
        Me.lblDv.Name = "lblDv"
        Me.lblDv.Size = New System.Drawing.Size(10, 13)
        Me.lblDv.TabIndex = 34
        Me.lblDv.Text = "-"
        '
        'txtDv
        '
        Me.txtDv.Location = New System.Drawing.Point(233, 32)
        Me.txtDv.Name = "txtDv"
        Me.txtDv.Size = New System.Drawing.Size(24, 20)
        Me.txtDv.TabIndex = 2
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(91, 246)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(15, 14)
        Me.chkActivo.TabIndex = 9
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblActivo
        '
        Me.lblActivo.AutoSize = True
        Me.lblActivo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblActivo.Location = New System.Drawing.Point(45, 246)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(40, 13)
        Me.lblActivo.TabIndex = 31
        Me.lblActivo.Text = "Activo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(91, 164)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(411, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(91, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(463, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblObservaciones.Location = New System.Drawing.Point(4, 193)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 25
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTelefono.Location = New System.Drawing.Point(33, 167)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 24
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNombre.Location = New System.Drawing.Point(38, 61)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 23
        Me.lblNombre.Text = "Nombre:"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFechaCreacion.Location = New System.Drawing.Point(0, 269)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaCreacion.TabIndex = 27
        Me.lblFechaCreacion.Text = "Fecha Creación:"
        '
        'lblNit
        '
        Me.lblNit.AutoSize = True
        Me.lblNit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNit.Location = New System.Drawing.Point(57, 35)
        Me.lblNit.Name = "lblNit"
        Me.lblNit.Size = New System.Drawing.Size(28, 13)
        Me.lblNit.TabIndex = 22
        Me.lblNit.Text = "NIT:"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(91, 32)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(127, 20)
        Me.txtNit.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Location = New System.Drawing.Point(679, 401)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(109, 27)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'ListBoxClientes
        '
        Me.ListBoxClientes.DisplayMember = "id"
        Me.ListBoxClientes.FormattingEnabled = True
        Me.ListBoxClientes.Location = New System.Drawing.Point(12, 86)
        Me.ListBoxClientes.Name = "ListBoxClientes"
        Me.ListBoxClientes.Size = New System.Drawing.Size(225, 342)
        Me.ListBoxClientes.TabIndex = 4
        Me.ListBoxClientes.ValueMember = "id"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNuevo.Location = New System.Drawing.Point(564, 401)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(109, 27)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtFiltrarCliente
        '
        Me.txtFiltrarCliente.Location = New System.Drawing.Point(53, 38)
        Me.txtFiltrarCliente.Name = "txtFiltrarCliente"
        Me.txtFiltrarCliente.Size = New System.Drawing.Size(184, 20)
        Me.txtFiltrarCliente.TabIndex = 0
        '
        'lblFiltrarCliente
        '
        Me.lblFiltrarCliente.AutoSize = True
        Me.lblFiltrarCliente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFiltrarCliente.Location = New System.Drawing.Point(12, 41)
        Me.lblFiltrarCliente.Name = "lblFiltrarCliente"
        Me.lblFiltrarCliente.Size = New System.Drawing.Size(35, 13)
        Me.lblFiltrarCliente.TabIndex = 23
        Me.lblFiltrarCliente.Text = "Filtrar:"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 450)
        Me.Controls.Add(Me.lblFiltrarCliente)
        Me.Controls.Add(Me.txtFiltrarCliente)
        Me.Controls.Add(Me.rdiInactivos)
        Me.Controls.Add(Me.rdiActivos)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBoxUsuario)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ListBoxClientes)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.GroupBoxUsuario.ResumeLayout(False)
        Me.GroupBoxUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdiInactivos As RadioButton
    Friend WithEvents rdiActivos As RadioButton
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents GroupBoxUsuario As GroupBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDv As Label
    Friend WithEvents txtDv As TextBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents lblActivo As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFechaCreacion As Label
    Friend WithEvents lblNit As Label
    Friend WithEvents txtNit As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ListBoxClientes As ListBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtFiltrarCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMunicipio As ComboBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents resFechaCreacion As Label
    Friend WithEvents lblFiltrarCliente As Label
End Class
