<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.contMenu = New System.Windows.Forms.Panel()
        Me.btnPuestaP = New System.Windows.Forms.Button()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        Me.btnPesaje = New System.Windows.Forms.Button()
        Me.btnOrdenProduccion = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnMedidas = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btnCerrarS = New System.Windows.Forms.Button()
        Me.tabsPrincipal = New System.Windows.Forms.TabControl()
        Me.tabPesaje = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.estCom = New System.Windows.Forms.TextBox()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEstCom = New System.Windows.Forms.Label()
        Me.contador = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPPId = New System.Windows.Forms.Label()
        Me.lblPesoRbdo = New System.Windows.Forms.Label()
        Me.lblPPS = New System.Windows.Forms.Label()
        Me.capturaPeso = New System.Windows.Forms.Label()
        Me.btnGuardarPeso = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.valBascula = New System.Windows.Forms.Label()
        Me.lblBascula = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.cmbDestino = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPesaje = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDetallePP = New System.Windows.Forms.DataGridView()
        Me.tabOrdenProduccion = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvEstado = New System.Windows.Forms.DataGridView()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.dpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.btnNuevaOP = New System.Windows.Forms.Button()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.grpOP = New System.Windows.Forms.GroupBox()
        Me.dgvOrdenes = New System.Windows.Forms.DataGridView()
        Me.grpDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.tabInformes = New System.Windows.Forms.TabPage()
        Me.btnRP1 = New System.Windows.Forms.Button()
        Me.tabPuestaPunto = New System.Windows.Forms.TabPage()
        Me.tblPP = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvPP = New System.Windows.Forms.DataGridView()
        Me.btnPP = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintSticker = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.bloquearTabs = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.contMenu.SuspendLayout()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabsPrincipal.SuspendLayout()
        Me.tabPesaje.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPesaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetallePP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrdenProduccion.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.grpOP.SuspendLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInformes.SuspendLayout()
        Me.tabPuestaPunto.SuspendLayout()
        Me.tblPP.SuspendLayout()
        CType(Me.dgvPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contMenu
        '
        Me.contMenu.Controls.Add(Me.btnPuestaP)
        Me.contMenu.Controls.Add(Me.pctLogo)
        Me.contMenu.Controls.Add(Me.btnPesaje)
        Me.contMenu.Controls.Add(Me.btnOrdenProduccion)
        Me.contMenu.Controls.Add(Me.btnInformes)
        Me.contMenu.Controls.Add(Me.btnMedidas)
        Me.contMenu.Controls.Add(Me.btnClientes)
        Me.contMenu.Controls.Add(Me.btn_usuarios)
        Me.contMenu.Location = New System.Drawing.Point(6, 9)
        Me.contMenu.Name = "contMenu"
        Me.contMenu.Size = New System.Drawing.Size(170, 537)
        Me.contMenu.TabIndex = 3
        '
        'btnPuestaP
        '
        Me.btnPuestaP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPuestaP.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPuestaP.Enabled = False
        Me.btnPuestaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPuestaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuestaP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPuestaP.Location = New System.Drawing.Point(3, 138)
        Me.btnPuestaP.Name = "btnPuestaP"
        Me.btnPuestaP.Size = New System.Drawing.Size(164, 50)
        Me.btnPuestaP.TabIndex = 11
        Me.btnPuestaP.Text = "Puesta a Punto"
        Me.btnPuestaP.UseVisualStyleBackColor = False
        '
        'pctLogo
        '
        Me.pctLogo.Image = Global.PRWP.My.Resources.Resources.logo
        Me.pctLogo.Location = New System.Drawing.Point(1, 2)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(167, 74)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctLogo.TabIndex = 10
        Me.pctLogo.TabStop = False
        '
        'btnPesaje
        '
        Me.btnPesaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesaje.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPesaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesaje.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPesaje.Location = New System.Drawing.Point(3, 82)
        Me.btnPesaje.Name = "btnPesaje"
        Me.btnPesaje.Size = New System.Drawing.Size(164, 50)
        Me.btnPesaje.TabIndex = 9
        Me.btnPesaje.Text = "Pesaje"
        Me.btnPesaje.UseVisualStyleBackColor = False
        '
        'btnOrdenProduccion
        '
        Me.btnOrdenProduccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrdenProduccion.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnOrdenProduccion.Enabled = False
        Me.btnOrdenProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenProduccion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOrdenProduccion.Location = New System.Drawing.Point(4, 194)
        Me.btnOrdenProduccion.Name = "btnOrdenProduccion"
        Me.btnOrdenProduccion.Size = New System.Drawing.Size(164, 50)
        Me.btnOrdenProduccion.TabIndex = 8
        Me.btnOrdenProduccion.Text = "Orden de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producción"
        Me.btnOrdenProduccion.UseVisualStyleBackColor = False
        '
        'btnInformes
        '
        Me.btnInformes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInformes.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnInformes.Enabled = False
        Me.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInformes.Location = New System.Drawing.Point(4, 250)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(164, 50)
        Me.btnInformes.TabIndex = 7
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.UseVisualStyleBackColor = False
        '
        'btnMedidas
        '
        Me.btnMedidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMedidas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnMedidas.Enabled = False
        Me.btnMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedidas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMedidas.Location = New System.Drawing.Point(4, 362)
        Me.btnMedidas.Name = "btnMedidas"
        Me.btnMedidas.Size = New System.Drawing.Size(164, 50)
        Me.btnMedidas.TabIndex = 5
        Me.btnMedidas.Text = "Medidas, Gramajes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y Tipos de Papel"
        Me.btnMedidas.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientes.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnClientes.Enabled = False
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClientes.Location = New System.Drawing.Point(4, 306)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(164, 50)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_usuarios.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_usuarios.Enabled = False
        Me.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuarios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_usuarios.Location = New System.Drawing.Point(4, 418)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(164, 50)
        Me.btn_usuarios.TabIndex = 3
        Me.btn_usuarios.Text = "Usuarios"
        Me.btn_usuarios.UseVisualStyleBackColor = False
        '
        'btnCerrarS
        '
        Me.btnCerrarS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarS.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarS.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrarS.Location = New System.Drawing.Point(900, 4)
        Me.btnCerrarS.Name = "btnCerrarS"
        Me.btnCerrarS.Size = New System.Drawing.Size(164, 28)
        Me.btnCerrarS.TabIndex = 6
        Me.btnCerrarS.Text = "Cerrar Sesión"
        Me.btnCerrarS.UseVisualStyleBackColor = False
        '
        'tabsPrincipal
        '
        Me.tabsPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabsPrincipal.Controls.Add(Me.tabPesaje)
        Me.tabsPrincipal.Controls.Add(Me.tabOrdenProduccion)
        Me.tabsPrincipal.Controls.Add(Me.tabInformes)
        Me.tabsPrincipal.Controls.Add(Me.tabPuestaPunto)
        Me.tabsPrincipal.Location = New System.Drawing.Point(179, 38)
        Me.tabsPrincipal.Multiline = True
        Me.tabsPrincipal.Name = "tabsPrincipal"
        Me.tabsPrincipal.SelectedIndex = 0
        Me.tabsPrincipal.Size = New System.Drawing.Size(884, 631)
        Me.tabsPrincipal.TabIndex = 4
        Me.tabsPrincipal.TabStop = False
        '
        'tabPesaje
        '
        Me.tabPesaje.Controls.Add(Me.TableLayoutPanel1)
        Me.tabPesaje.Location = New System.Drawing.Point(4, 22)
        Me.tabPesaje.Name = "tabPesaje"
        Me.tabPesaje.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPesaje.Size = New System.Drawing.Size(876, 605)
        Me.tabPesaje.TabIndex = 1
        Me.tabPesaje.Text = "Pesaje"
        Me.tabPesaje.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 599.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(870, 599)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.estCom, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExe, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnGuardarPeso, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(612, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(255, 411)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'estCom
        '
        Me.estCom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.estCom.Enabled = False
        Me.estCom.Location = New System.Drawing.Point(3, 91)
        Me.estCom.Multiline = True
        Me.estCom.Name = "estCom"
        Me.estCom.Size = New System.Drawing.Size(249, 59)
        Me.estCom.TabIndex = 13
        Me.estCom.Text = "Esperando ejecución de lectura de báscula..."
        '
        'btnExe
        '
        Me.btnExe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExe.BackColor = System.Drawing.Color.Green
        Me.btnExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExe.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExe.Location = New System.Drawing.Point(3, 11)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(249, 46)
        Me.btnExe.TabIndex = 10
        Me.btnExe.Text = "Capturar Peso"
        Me.btnExe.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblEstCom, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.contador, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 71)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(249, 14)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'lblEstCom
        '
        Me.lblEstCom.AutoSize = True
        Me.lblEstCom.Location = New System.Drawing.Point(3, 0)
        Me.lblEstCom.Name = "lblEstCom"
        Me.lblEstCom.Size = New System.Drawing.Size(46, 13)
        Me.lblEstCom.TabIndex = 12
        Me.lblEstCom.Text = "Estado: "
        '
        'contador
        '
        Me.contador.AutoSize = True
        Me.contador.Dock = System.Windows.Forms.DockStyle.Right
        Me.contador.Location = New System.Drawing.Point(230, 0)
        Me.contador.Name = "contador"
        Me.contador.Size = New System.Drawing.Size(16, 14)
        Me.contador.TabIndex = 13
        Me.contador.Text = "..."
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblPPId, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblPesoRbdo, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblPPS, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.capturaPeso, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 156)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(249, 90)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'lblPPId
        '
        Me.lblPPId.AutoSize = True
        Me.lblPPId.BackColor = System.Drawing.Color.DimGray
        Me.lblPPId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPPId.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPId.ForeColor = System.Drawing.Color.Cyan
        Me.lblPPId.Location = New System.Drawing.Point(3, 20)
        Me.lblPPId.Name = "lblPPId"
        Me.lblPPId.Size = New System.Drawing.Size(81, 70)
        Me.lblPPId.TabIndex = 15
        Me.lblPPId.Text = "0"
        Me.lblPPId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPesoRbdo
        '
        Me.lblPesoRbdo.AutoSize = True
        Me.lblPesoRbdo.Location = New System.Drawing.Point(90, 0)
        Me.lblPesoRbdo.Name = "lblPesoRbdo"
        Me.lblPesoRbdo.Size = New System.Drawing.Size(82, 13)
        Me.lblPesoRbdo.TabIndex = 14
        Me.lblPesoRbdo.Text = "Peso Recibido: "
        '
        'lblPPS
        '
        Me.lblPPS.AutoSize = True
        Me.lblPPS.Location = New System.Drawing.Point(3, 0)
        Me.lblPPS.Name = "lblPPS"
        Me.lblPPS.Size = New System.Drawing.Size(80, 13)
        Me.lblPPS.TabIndex = 13
        Me.lblPPS.Text = "Puesta P. Sel.: "
        '
        'capturaPeso
        '
        Me.capturaPeso.AutoSize = True
        Me.capturaPeso.BackColor = System.Drawing.Color.DimGray
        Me.capturaPeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.capturaPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.capturaPeso.ForeColor = System.Drawing.Color.Yellow
        Me.capturaPeso.Location = New System.Drawing.Point(90, 20)
        Me.capturaPeso.Name = "capturaPeso"
        Me.capturaPeso.Size = New System.Drawing.Size(156, 70)
        Me.capturaPeso.TabIndex = 2
        Me.capturaPeso.Text = "0"
        Me.capturaPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardarPeso
        '
        Me.btnGuardarPeso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarPeso.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPeso.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarPeso.Location = New System.Drawing.Point(3, 345)
        Me.btnGuardarPeso.Name = "btnGuardarPeso"
        Me.btnGuardarPeso.Size = New System.Drawing.Size(249, 43)
        Me.btnGuardarPeso.TabIndex = 15
        Me.btnGuardarPeso.Text = "Guardar peso de Rollo"
        Me.btnGuardarPeso.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.valBascula, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblBascula, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lblDestino, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cmbDestino, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 252)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.23232!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.76768!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(249, 61)
        Me.TableLayoutPanel6.TabIndex = 17
        '
        'valBascula
        '
        Me.valBascula.AutoSize = True
        Me.valBascula.BackColor = System.Drawing.Color.Transparent
        Me.valBascula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.valBascula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valBascula.ForeColor = System.Drawing.Color.Black
        Me.valBascula.Location = New System.Drawing.Point(3, 14)
        Me.valBascula.Name = "valBascula"
        Me.valBascula.Size = New System.Drawing.Size(81, 47)
        Me.valBascula.TabIndex = 17
        Me.valBascula.Text = "0"
        '
        'lblBascula
        '
        Me.lblBascula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBascula.Location = New System.Drawing.Point(3, 0)
        Me.lblBascula.Name = "lblBascula"
        Me.lblBascula.Size = New System.Drawing.Size(81, 14)
        Me.lblBascula.TabIndex = 0
        Me.lblBascula.Text = "Bascula:"
        '
        'lblDestino
        '
        Me.lblDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDestino.Location = New System.Drawing.Point(90, 0)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(156, 14)
        Me.lblDestino.TabIndex = 0
        Me.lblDestino.Text = "Destino:"
        '
        'cmbDestino
        '
        Me.cmbDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Items.AddRange(New Object() {"Planta", "Cliente", "Recuperar", "Otro Cliente"})
        Me.cmbDestino.Location = New System.Drawing.Point(90, 17)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(156, 21)
        Me.cmbDestino.TabIndex = 18
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(603, 593)
        Me.TableLayoutPanel5.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPesaje)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 290)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Puesta a Punto"
        '
        'dgvPesaje
        '
        Me.dgvPesaje.AllowUserToAddRows = False
        Me.dgvPesaje.AllowUserToDeleteRows = False
        Me.dgvPesaje.AllowUserToOrderColumns = True
        Me.dgvPesaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPesaje.Location = New System.Drawing.Point(3, 16)
        Me.dgvPesaje.Name = "dgvPesaje"
        Me.dgvPesaje.ReadOnly = True
        Me.dgvPesaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPesaje.Size = New System.Drawing.Size(591, 271)
        Me.dgvPesaje.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDetallePP)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 291)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles Puesta a Punto"
        '
        'dgvDetallePP
        '
        Me.dgvDetallePP.AllowUserToAddRows = False
        Me.dgvDetallePP.AllowUserToDeleteRows = False
        Me.dgvDetallePP.AllowUserToOrderColumns = True
        Me.dgvDetallePP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetallePP.Location = New System.Drawing.Point(3, 16)
        Me.dgvDetallePP.Name = "dgvDetallePP"
        Me.dgvDetallePP.ReadOnly = True
        Me.dgvDetallePP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetallePP.Size = New System.Drawing.Size(591, 272)
        Me.dgvDetallePP.TabIndex = 0
        '
        'tabOrdenProduccion
        '
        Me.tabOrdenProduccion.Controls.Add(Me.SplitContainer1)
        Me.tabOrdenProduccion.Location = New System.Drawing.Point(4, 22)
        Me.tabOrdenProduccion.Name = "tabOrdenProduccion"
        Me.tabOrdenProduccion.Size = New System.Drawing.Size(876, 605)
        Me.tabOrdenProduccion.TabIndex = 2
        Me.tabOrdenProduccion.Text = "Orden Prod."
        Me.tabOrdenProduccion.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvEstado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnFiltrar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dpFechaFinal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dpFechaInicial)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnNuevaOP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFechaInicial)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbMunicipio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCliente)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(876, 605)
        Me.SplitContainer1.SplitterDistance = 76
        Me.SplitContainer1.TabIndex = 0
        '
        'dgvEstado
        '
        Me.dgvEstado.AllowUserToAddRows = False
        Me.dgvEstado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        Me.dgvEstado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEstado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEstado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEstado.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEstado.Location = New System.Drawing.Point(437, 6)
        Me.dgvEstado.Name = "dgvEstado"
        Me.dgvEstado.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEstado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstado.Size = New System.Drawing.Size(188, 67)
        Me.dgvEstado.TabIndex = 34
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnFiltrar.Enabled = False
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFiltrar.Location = New System.Drawing.Point(362, 30)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(71, 43)
        Me.btnFiltrar.TabIndex = 33
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'dpFechaFinal
        '
        Me.dpFechaFinal.Enabled = False
        Me.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaFinal.Location = New System.Drawing.Point(190, 53)
        Me.dpFechaFinal.Name = "dpFechaFinal"
        Me.dpFechaFinal.Size = New System.Drawing.Size(98, 20)
        Me.dpFechaFinal.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(115, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Fecha inicial:"
        '
        'dpFechaInicial
        '
        Me.dpFechaInicial.Enabled = False
        Me.dpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaInicial.Location = New System.Drawing.Point(190, 30)
        Me.dpFechaInicial.Name = "dpFechaInicial"
        Me.dpFechaInicial.Size = New System.Drawing.Size(98, 20)
        Me.dpFechaInicial.TabIndex = 28
        '
        'btnNuevaOP
        '
        Me.btnNuevaOP.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnNuevaOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnNuevaOP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNuevaOP.Location = New System.Drawing.Point(7, 7)
        Me.btnNuevaOP.Name = "btnNuevaOP"
        Me.btnNuevaOP.Size = New System.Drawing.Size(100, 61)
        Me.btnNuevaOP.TabIndex = 26
        Me.btnNuevaOP.Text = "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producción"
        Me.btnNuevaOP.UseVisualStyleBackColor = False
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFechaInicial.Location = New System.Drawing.Point(115, 32)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(69, 13)
        Me.lblFechaInicial.TabIndex = 27
        Me.lblFechaInicial.Text = "Fecha inicial:"
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMunicipio.Enabled = False
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(190, 6)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(241, 21)
        Me.cmbMunicipio.TabIndex = 25
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCliente.Location = New System.Drawing.Point(142, 9)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 24
        Me.lblCliente.Text = "Cliente:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpOP)
        Me.SplitContainer2.Panel1MinSize = 50
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.grpDetalle)
        Me.SplitContainer2.Panel2MinSize = 50
        Me.SplitContainer2.Size = New System.Drawing.Size(876, 525)
        Me.SplitContainer2.SplitterDistance = 456
        Me.SplitContainer2.TabIndex = 2
        '
        'grpOP
        '
        Me.grpOP.Controls.Add(Me.dgvOrdenes)
        Me.grpOP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOP.Location = New System.Drawing.Point(0, 0)
        Me.grpOP.Name = "grpOP"
        Me.grpOP.Size = New System.Drawing.Size(456, 525)
        Me.grpOP.TabIndex = 3
        Me.grpOP.TabStop = False
        Me.grpOP.Text = "Ordenes de Producción"
        '
        'dgvOrdenes
        '
        Me.dgvOrdenes.AllowUserToAddRows = False
        Me.dgvOrdenes.AllowUserToDeleteRows = False
        Me.dgvOrdenes.AllowUserToOrderColumns = True
        Me.dgvOrdenes.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        Me.dgvOrdenes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrdenes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrdenes.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrdenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOrdenes.Location = New System.Drawing.Point(3, 16)
        Me.dgvOrdenes.MultiSelect = False
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrdenes.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvOrdenes.RowHeadersVisible = False
        Me.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrdenes.Size = New System.Drawing.Size(450, 506)
        Me.dgvOrdenes.TabIndex = 1
        '
        'grpDetalle
        '
        Me.grpDetalle.Controls.Add(Me.dgvDetalle)
        Me.grpDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDetalle.Location = New System.Drawing.Point(0, 0)
        Me.grpDetalle.Name = "grpDetalle"
        Me.grpDetalle.Size = New System.Drawing.Size(416, 525)
        Me.grpDetalle.TabIndex = 4
        Me.grpDetalle.TabStop = False
        Me.grpDetalle.Text = "Detalle Orden de Producción"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToOrderColumns = True
        Me.dgvDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        Me.dgvDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 16)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(410, 506)
        Me.dgvDetalle.TabIndex = 4
        '
        'tabInformes
        '
        Me.tabInformes.Controls.Add(Me.btnRP1)
        Me.tabInformes.Location = New System.Drawing.Point(4, 22)
        Me.tabInformes.Name = "tabInformes"
        Me.tabInformes.Size = New System.Drawing.Size(876, 605)
        Me.tabInformes.TabIndex = 3
        Me.tabInformes.Text = "Informes"
        Me.tabInformes.UseVisualStyleBackColor = True
        '
        'btnRP1
        '
        Me.btnRP1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRP1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRP1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRP1.Location = New System.Drawing.Point(3, 3)
        Me.btnRP1.Name = "btnRP1"
        Me.btnRP1.Size = New System.Drawing.Size(164, 50)
        Me.btnRP1.TabIndex = 10
        Me.btnRP1.Text = "Ordenes de Producción"
        Me.btnRP1.UseVisualStyleBackColor = False
        '
        'tabPuestaPunto
        '
        Me.tabPuestaPunto.Controls.Add(Me.tblPP)
        Me.tabPuestaPunto.Location = New System.Drawing.Point(4, 22)
        Me.tabPuestaPunto.Name = "tabPuestaPunto"
        Me.tabPuestaPunto.Size = New System.Drawing.Size(876, 605)
        Me.tabPuestaPunto.TabIndex = 4
        Me.tabPuestaPunto.Text = "Puesta Punto"
        Me.tabPuestaPunto.UseVisualStyleBackColor = True
        '
        'tblPP
        '
        Me.tblPP.ColumnCount = 2
        Me.tblPP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblPP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblPP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblPP.Controls.Add(Me.dgvPP, 0, 0)
        Me.tblPP.Controls.Add(Me.btnPP, 1, 0)
        Me.tblPP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPP.Location = New System.Drawing.Point(0, 0)
        Me.tblPP.Name = "tblPP"
        Me.tblPP.RowCount = 1
        Me.tblPP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPP.Size = New System.Drawing.Size(876, 605)
        Me.tblPP.TabIndex = 0
        '
        'dgvPP
        '
        Me.dgvPP.AllowUserToAddRows = False
        Me.dgvPP.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPP.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvPP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPP.Location = New System.Drawing.Point(3, 3)
        Me.dgvPP.MultiSelect = False
        Me.dgvPP.Name = "dgvPP"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPP.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvPP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPP.Size = New System.Drawing.Size(607, 599)
        Me.dgvPP.TabIndex = 12
        '
        'btnPP
        '
        Me.btnPP.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPP.Location = New System.Drawing.Point(616, 3)
        Me.btnPP.Name = "btnPP"
        Me.btnPP.Size = New System.Drawing.Size(257, 50)
        Me.btnPP.TabIndex = 11
        Me.btnPP.Text = "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Puesta a Punto"
        Me.btnPP.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintSticker
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'bloquearTabs
        '
        Me.bloquearTabs.Location = New System.Drawing.Point(179, 37)
        Me.bloquearTabs.Name = "bloquearTabs"
        Me.bloquearTabs.Size = New System.Drawing.Size(612, 21)
        Me.bloquearTabs.TabIndex = 7
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 681)
        Me.Controls.Add(Me.bloquearTabs)
        Me.Controls.Add(Me.tabsPrincipal)
        Me.Controls.Add(Me.contMenu)
        Me.Controls.Add(Me.btnCerrarS)
        Me.Name = "Principal"
        Me.Text = "Papeles Regionales - Producción v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.contMenu.ResumeLayout(False)
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabsPrincipal.ResumeLayout(False)
        Me.tabPesaje.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPesaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDetallePP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrdenProduccion.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.grpOP.ResumeLayout(False)
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInformes.ResumeLayout(False)
        Me.tabPuestaPunto.ResumeLayout(False)
        Me.tblPP.ResumeLayout(False)
        CType(Me.dgvPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents contMenu As Panel
    Friend WithEvents btnMedidas As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btnCerrarS As Button
    Friend WithEvents btnInformes As Button
    Friend WithEvents btnOrdenProduccion As Button
    Friend WithEvents btnPesaje As Button
    Friend WithEvents tabsPrincipal As TabControl
    Friend WithEvents tabPesaje As TabPage
    Friend WithEvents capturaPeso As Label
    Friend WithEvents tabInformes As TabPage
    Friend WithEvents tabOrdenProduccion As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblCliente As Label
    Friend WithEvents cmbMunicipio As ComboBox
    Friend WithEvents dpFechaFinal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dpFechaInicial As DateTimePicker
    Friend WithEvents lblFechaInicial As Label
    Friend WithEvents btnNuevaOP As Button
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents grpOP As GroupBox
    Friend WithEvents dgvOrdenes As DataGridView
    Friend WithEvents grpDetalle As GroupBox
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents pctLogo As PictureBox
    Friend WithEvents dgvEstado As DataGridView
    Friend WithEvents tabPuestaPunto As TabPage
    Friend WithEvents tblPP As TableLayoutPanel
    Friend WithEvents btnPP As Button
    Friend WithEvents btnPuestaP As Button
    Friend WithEvents dgvPP As DataGridView
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnExe As Button
    Friend WithEvents lblEstCom As Label
    Friend WithEvents estCom As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvPesaje As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents contador As Label
    Friend WithEvents btnGuardarPeso As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblPesoRbdo As Label
    Friend WithEvents lblPPS As Label
    Friend WithEvents lblPPId As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvDetallePP As DataGridView
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintSticker As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents bloquearTabs As Panel
    Friend WithEvents btnRP1 As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents valBascula As Label
    Friend WithEvents lblBascula As Label
    Friend WithEvents lblDestino As Label
    Friend WithEvents cmbDestino As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
