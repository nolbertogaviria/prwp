<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.ListBoxUsuarios = New System.Windows.Forms.ListBox()
        Me.GroupBoxUsuario = New System.Windows.Forms.GroupBox()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.lblFechaConexion = New System.Windows.Forms.Label()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPerfil = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.rdiActivos = New System.Windows.Forms.RadioButton()
        Me.rdiInactivos = New System.Windows.Forms.RadioButton()
        Me.GroupBoxUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxUsuarios
        '
        Me.ListBoxUsuarios.DisplayMember = "id"
        Me.ListBoxUsuarios.FormattingEnabled = True
        Me.ListBoxUsuarios.Location = New System.Drawing.Point(12, 57)
        Me.ListBoxUsuarios.Name = "ListBoxUsuarios"
        Me.ListBoxUsuarios.Size = New System.Drawing.Size(225, 381)
        Me.ListBoxUsuarios.TabIndex = 3
        Me.ListBoxUsuarios.ValueMember = "id"
        '
        'GroupBoxUsuario
        '
        Me.GroupBoxUsuario.Controls.Add(Me.chkActivo)
        Me.GroupBoxUsuario.Controls.Add(Me.lblActivo)
        Me.GroupBoxUsuario.Controls.Add(Me.lblFechaConexion)
        Me.GroupBoxUsuario.Controls.Add(Me.Label1)
        Me.GroupBoxUsuario.Controls.Add(Me.lblFechaCreacion)
        Me.GroupBoxUsuario.Controls.Add(Me.Label2)
        Me.GroupBoxUsuario.Controls.Add(Me.txtPassword1)
        Me.GroupBoxUsuario.Controls.Add(Me.Label7)
        Me.GroupBoxUsuario.Controls.Add(Me.txtPassword2)
        Me.GroupBoxUsuario.Controls.Add(Me.Label6)
        Me.GroupBoxUsuario.Controls.Add(Me.txtNombre)
        Me.GroupBoxUsuario.Controls.Add(Me.Label5)
        Me.GroupBoxUsuario.Controls.Add(Me.txtLogin)
        Me.GroupBoxUsuario.Controls.Add(Me.cmbPerfil)
        Me.GroupBoxUsuario.Controls.Add(Me.Label3)
        Me.GroupBoxUsuario.Controls.Add(Me.Label4)
        Me.GroupBoxUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxUsuario.Location = New System.Drawing.Point(243, 57)
        Me.GroupBoxUsuario.Name = "GroupBoxUsuario"
        Me.GroupBoxUsuario.Size = New System.Drawing.Size(545, 252)
        Me.GroupBoxUsuario.TabIndex = 1
        Me.GroupBoxUsuario.TabStop = False
        Me.GroupBoxUsuario.Text = "Datos de Usuario"
        '
        'lblActivo
        '
        Me.lblActivo.AutoSize = True
        Me.lblActivo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblActivo.Location = New System.Drawing.Point(86, 165)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(40, 13)
        Me.lblActivo.TabIndex = 15
        Me.lblActivo.Text = "Activo:"
        '
        'lblFechaConexion
        '
        Me.lblFechaConexion.AutoSize = True
        Me.lblFechaConexion.Location = New System.Drawing.Point(133, 209)
        Me.lblFechaConexion.Name = "lblFechaConexion"
        Me.lblFechaConexion.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaConexion.TabIndex = 14
        Me.lblFechaConexion.Text = "Fecha Conexión"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.Location = New System.Drawing.Point(133, 187)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaCreacion.TabIndex = 13
        Me.lblFechaCreacion.Text = "Fecha Creación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(49, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Último Acceso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(93, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Perfil:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(16, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirmar Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(62, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(80, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'txtPassword1
        '
        Me.txtPassword1.Location = New System.Drawing.Point(133, 86)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword1.Size = New System.Drawing.Size(143, 20)
        Me.txtPassword1.TabIndex = 6
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(133, 112)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(143, 20)
        Me.txtPassword2.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(133, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(399, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(133, 34)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(127, 20)
        Me.txtLogin.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(42, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha Creación:"
        '
        'cmbPerfil
        '
        Me.cmbPerfil.FormattingEnabled = True
        Me.cmbPerfil.Location = New System.Drawing.Point(133, 138)
        Me.cmbPerfil.Name = "cmbPerfil"
        Me.cmbPerfil.Size = New System.Drawing.Size(143, 21)
        Me.cmbPerfil.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(91, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(133, 165)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(15, 14)
        Me.chkActivo.TabIndex = 9
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Location = New System.Drawing.Point(673, 315)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(109, 27)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNuevo.Location = New System.Drawing.Point(558, 315)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(109, 27)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Location = New System.Drawing.Point(682, 38)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 13)
        Me.txtId.TabIndex = 12
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(246, 371)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(117, 13)
        Me.lblResultado.TabIndex = 13
        Me.lblResultado.Text = "Esperando operación..."
        '
        'rdiActivos
        '
        Me.rdiActivos.AutoSize = True
        Me.rdiActivos.Checked = True
        Me.rdiActivos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rdiActivos.Location = New System.Drawing.Point(13, 34)
        Me.rdiActivos.Name = "rdiActivos"
        Me.rdiActivos.Size = New System.Drawing.Size(60, 17)
        Me.rdiActivos.TabIndex = 1
        Me.rdiActivos.TabStop = True
        Me.rdiActivos.Text = "Activos"
        Me.rdiActivos.UseVisualStyleBackColor = True
        '
        'rdiInactivos
        '
        Me.rdiInactivos.AutoSize = True
        Me.rdiInactivos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rdiInactivos.Location = New System.Drawing.Point(112, 33)
        Me.rdiInactivos.Name = "rdiInactivos"
        Me.rdiInactivos.Size = New System.Drawing.Size(68, 17)
        Me.rdiInactivos.TabIndex = 2
        Me.rdiInactivos.Text = "Inactivos"
        Me.rdiInactivos.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rdiInactivos)
        Me.Controls.Add(Me.rdiActivos)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBoxUsuario)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ListBoxUsuarios)
        Me.Controls.Add(Me.btnNuevo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.TopMost = True
        Me.GroupBoxUsuario.ResumeLayout(False)
        Me.GroupBoxUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxUsuarios As ListBox
    Friend WithEvents GroupBoxUsuario As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents cmbPerfil As ComboBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFechaConexion As Label
    Friend WithEvents lblFechaCreacion As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblActivo As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents rdiActivos As RadioButton
    Friend WithEvents rdiInactivos As RadioButton
End Class
