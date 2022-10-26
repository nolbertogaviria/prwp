﻿

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing.Printing


Public Class Principal


    Dim ppdIdSel, seconds As Integer


    Function leerCom() As String

        Dim salida As String = ""
        Dim bascula As String = ""
        Dim arrl
        Dim lrga
        Dim puerto As IO.Ports.SerialPort = Nothing
        Dim txtbsc = "bascula.dat"



        Try
            If My.Computer.FileSystem.FileExists(txtbsc) Then
                Dim bsc As String = My.Computer.FileSystem.ReadAllText(txtbsc)

                Console.WriteLine("bascula.dat: [" & bsc & "]")
                If (bsc.Length >= 14) Then
                    Dim port, baudRate, dataBits, stopBits, resCom As String
                    Dim parity As Ports.Parity
                    Dim absc As Array = bsc.Split(",")
                    resCom = "Port: " & absc(0) & ", BaudRate: " & absc(1) & ", DataBits: " & absc(2) & ", Parity: " & absc(3) & ", StopBits: " & absc(4) & ""
                    estCom.Text = "Enviando comando '" & resCom & "'"
                    port = absc(0)
                    baudRate = absc(1)
                    dataBits = absc(2)
                    puerto = My.Computer.Ports.OpenSerialPort(port)
                    Select Case absc(3)
                        Case "e"
                            parity = Ports.Parity.Even
                        Case "m"
                            parity = Ports.Parity.Mark
                        Case "n"
                            parity = Ports.Parity.None
                        Case "o"
                            parity = Ports.Parity.Odd
                        Case "s"
                            parity = Ports.Parity.Space
                    End Select
                    stopBits = absc(4)
                    bascula = absc(5)
                    valBascula.Text = bascula
                    Console.WriteLine("ejecutado desde: " & System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase))
                    'Console.WriteLine("bsc: " & bsc & vbCrLf & "absc len: " & absc.Length)
                    With puerto
                        .ReadTimeout = 1000
                        .BaudRate = baudRate
                        .DataBits = dataBits
                        .Parity = parity
                        .StopBits = stopBits
                    End With
                    Dim lectura = puerto.ReadLine()
                    lectura = lectura.Trim() 'limpiar
                    lectura = lectura.Replace(vbCr, "") 'remover carrier return
                    lectura = lectura.Replace(vbLf, "") 'remover line feed
                    lectura = Regex.Replace(lectura, " {2,}", " ") 'reemplazar espacios continuos por uno
                    lectura = Regex.Replace(lectura, "[^0-9|,|.]", "") 'Remover letras
                    Console.WriteLine("lectura:--->" & lectura)
                    Console.WriteLine(Regex.Match(lectura, "\d").Success)
                    If (lectura <> "") Then
                        lectura = Decimal.Parse(lectura)
                        lectura = Format(lectura, "Standard")
                        'Dim lectura As String = Trim(Regex.Replace(puerto.ReadLine(), " {2,}", " "))
                        If (lectura.IndexOf(" ") > 0) Then
                            arrl = Split(lectura, " ")
                            lrga = arrl.Length
                            salida &= arrl(lrga - 1)
                        Else
                            salida = lectura
                        End If
                        'estCom.Text = "Lectura recibida: " & salida
                    Else
                        lectura = -1
                    End If
                Else
                        MsgBox("Error: Parece que la cadena en el archivo de la báscula no se encuentra bien formado")
                End If
            Else
                MsgBox("Error: No ha sido posible abrir el archivo de configuración de la báscula")
            End If

        Catch ex As TimeoutException
            salida = "Error: Tiempo de respuesta superado"
        Finally
            If puerto IsNot Nothing Then puerto.Close()
            System.Threading.Thread.Sleep(1500)

        End Try

        Return salida
    End Function






    Public Sub populateDgvEstado()


        Dim sql As String = "select es.estado, count(op.id) as cant
            from orden_produccion op join estado es on op.estado_id = es.id
            group by es.estado, op.estado_id, es.id
            order by es.id"
        Dim Total As Integer = 0

        myConn.Open
        Dim DR As SqlDataReader = New SqlCommand(sql, myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("Estado", GetType(String))
            .Add("Cant.", GetType(Integer))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(
                    DR.Item("estado"),
                    DR.Item("cant")
                )
                Total += DR.Item("cant")
            Loop
        End If
        DR.Close()
        DR = Nothing
        DT.Rows.Add("Total", Total)
        dgvEstado.DataSource = DT
        DT = Nothing
        myConn.Close

        With dgvEstado
            With .Columns("Estado")
                .Width = 80
            End With
            With .Columns("Cant.")
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .ValueType = GetType(Integer)
                .DefaultCellStyle.Format = "N0"
            End With
            .RowHeadersVisible = False
            .AutoResizeRows()
        End With

    End Sub


    Public Sub populateOP()

        populateDgvEstado()

        'populate DataGridView de Ordenes de Produccion
        Dim cmds As String

        cmds = $"
            select
                orden_produccion.id, 
                cliente.nombre,
                estado.estado,
                orden_produccion.fecha
            from orden_produccion 
            inner join cliente on orden_produccion.cliente_id = cliente.id
            inner join estado on orden_produccion.estado_id = estado.id
            where estado_id = 1
            order by fecha asc"

        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand(cmds, myConn).ExecuteReader()

        Dim DT As New DataTable()
        With DT.Columns
            .Add("ID OP", GetType(String))
            .Add("Cliente", GetType(String))
            .Add("Estado", GetType(String))
            .Add("Fecha", GetType(String))
        End With

        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(
                    DR.Item("id").ToString.PadLeft(4, "0"),
                    DR.Item("nombre"),
                    DR.Item("estado"),
                    DR.Item("fecha")
                )
            Loop
        End If
        DR.Close()
        DR = Nothing
        myConn.Close()

        dgvOrdenes.DataSource = DT

        With dgvOrdenes
            With .Columns("ID OP")
                .Width = 80
                .DefaultCellStyle.ForeColor = Color.Blue
            End With

        End With
    End Sub


    Private Sub populateDetalle(op As Int32)
        'populate DataGridView de Detalles
        dgvDetalle.DataSource = cargarDetalle(op)


        With dgvDetalle
            .Columns("ID").Visible = False
            .Columns("Medida").Width = 50
            .Columns("Gramaje").Width = 50
            .Columns("Usuario").Visible = False
        End With

    End Sub






    Public Sub populateDgvPuestaPunto()


        Dim sql As String = "
            select
	            id,
	            (
		            select top(1) opd.gramaje from orden_produccion_detalle opd
		            join puesta_punto_detalle ppd on ppd.op_detalle_id = opd.id
		            join puesta_punto pp1 on ppd.puesta_punto_id = pp1.id
		            where pp1.id = pp0.id
	            ) as gramaje,
	            (
		            select concat(sum(cast(opd.medida as int)), ' = ', string_agg(opd.medida, '+')) from orden_produccion_detalle opd
		            join puesta_punto_detalle ppd on ppd.op_detalle_id = opd.id
		            join puesta_punto pp1 on ppd.puesta_punto_id = pp1.id
		            where pp1.id = pp0.id
	            ) as medidas,
                (select sum(cantidad) from puesta_punto_detalle where puesta_punto_detalle.puesta_punto_id = pp0.id) cantidad,
	            rebobinadora,
	            operario,
                fecha
            from puesta_punto pp0
        "

        myConn.Open
        Dim DR As SqlDataReader = New SqlCommand(sql, myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("ID", GetType(String))
            .Add("Gramaje", GetType(String))
            .Add("Medidas", GetType(String))
            .Add("Cant.", GetType(String))
            .Add("Rebob.", GetType(String))
            .Add("Operario", GetType(String))
            .Add("Fecha", GetType(String))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(
                    DR.Item("id"),
                    DR.Item("gramaje"),
                    DR.Item("medidas"),
                    DR.Item("cantidad"),
                    DR.Item("rebobinadora"),
                    DR.Item("operario"),
                    DR.Item("fecha")
                )
            Loop
        End If
        DR.Close()
        DR = Nothing
        dgvPP.DataSource = DT
        DT = Nothing
        myConn.Close

        With dgvPP
            With .Columns("ID")
                .Width = 40
            End With
            With .Columns("ID")
                .Width = 60
            End With
            With .Columns("Rebob.")
                .Width = 60
            End With
            With .Columns("Operario")
                .Width = 60
            End With
            With .Columns("Cant.")
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .ValueType = GetType(Integer)
                .DefaultCellStyle.Format = "N0"
            End With
            .RowHeadersVisible = False
            .AutoResizeRows()
        End With

    End Sub



    Public Sub populateDgvPeso()


        Dim sql As String = "select
            ppd.id as ppd_id,
	        pp.id,
	        pp.rebobinadora,
	        pp.operario,
	        ppd.cantidad,
            (select count(id) from pesaje p where p.pp_detalle_id = ppd.id ) as rollos,
            (select iif(sum(peso)>0,sum(peso),0) from pesaje p1 where p1.pp_detalle_id = ppd.id) as pesado,
	        opd.gramaje,
            opd.medida
        from puesta_punto pp
        inner join puesta_punto_detalle ppd on pp.id = ppd.puesta_punto_id
        inner join orden_produccion_detalle opd on ppd.op_detalle_id = opd.id
        group by
            ppd.id,
	        pp.id,
	        pp.rebobinadora,
	        pp.operario,
	        ppd.cantidad,
	        opd.gramaje,
            opd.medida
        having ppd.cantidad > (select count(id) from pesaje p where p.pp_detalle_id = ppd.id)
        "
        Dim Total As Integer = 0

        myConn.Open
        Dim DR As SqlDataReader = New SqlCommand(sql, myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("ID", GetType(String))
            .Add("P.P. ID", GetType(String))
            .Add("Rebobinadora", GetType(String))
            .Add("Operario", GetType(String))
            .Add("Cant.", GetType(Integer))
            .Add("Rollos", GetType(Integer))
            .Add("Pesado", GetType(Decimal))
            .Add("Gramaje", GetType(String))
            .Add("Medida", GetType(String))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(
                    DR.Item("ppd_id"),
                    DR.Item("id"),
                    DR.Item("rebobinadora"),
                    DR.Item("operario"),
                    DR.Item("cantidad"),
                    DR.Item("rollos"),
                    DR.Item("pesado"),
                    DR.Item("gramaje"),
                    DR.Item("medida")
                )
            Loop
        End If
        DR.Close()
        DR = Nothing
        dgvPesaje.DataSource = DT
        DT = Nothing
        myConn.Close

        With dgvPesaje
            With .Columns("ID")
                .Width = 80
            End With
            With .Columns("P.P. ID")
                .Width = 80
            End With
            With .Columns("Medida")
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .ValueType = GetType(Integer)
                .DefaultCellStyle.Format = "N0"
            End With
            With .Columns("Cant.")
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .ValueType = GetType(Integer)
                .DefaultCellStyle.Format = "N0"
            End With
            With .Columns("Rollos")
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .ValueType = GetType(Integer)
                .DefaultCellStyle.Format = "N0"
            End With
            With .Columns("Pesado")
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .ValueType = GetType(Decimal)
                .DefaultCellStyle.Format = "N0"
            End With
            .RowHeadersVisible = False
            .AutoResizeRows()
        End With

    End Sub


    Public Sub populateDgvDetallePP()



        Dim sql As String = "select
            p.peso,
	        p.fecha,
            p.bascula,
            p.destino
        from pesaje p
        where pp_detalle_id = " & lblPPId.Text & "
        "
        Dim Total As Integer = 0

        myConn.Open
        Dim DR As SqlDataReader = New SqlCommand(sql, myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("Peso", GetType(Decimal))
            .Add("Fecha", GetType(String))
            .Add("Bascula", GetType(String))
            .Add("Destino", GetType(String))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(
                    DR.Item("peso"),
                    DR.Item("fecha"),
                    DR.Item("bascula"),
                    DR.Item("destino")
                )
            Loop
        End If
        DR.Close()
        DR = Nothing
        dgvDetallePP.DataSource = DT
        DT = Nothing
        myConn.Close

    End Sub








    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Aplicar permisos
        If (perfilUsuario > 2) Then
            btnPuestaP.Enabled = False
            btnOrdenProduccion.Enabled = False
            btnInformes.Enabled = False
            btnClientes.Enabled = False
            btnMedidas.Enabled = False
            btn_usuarios.Enabled = False

            btnPuestaP.BackColor = Color.LightGray
            btnOrdenProduccion.BackColor = Color.LightGray
            btnInformes.BackColor = Color.LightGray
            btnClientes.BackColor = Color.LightGray
            btnMedidas.BackColor = Color.LightGray
            btn_usuarios.BackColor = Color.LightGray

            'bloquearTabs.Enabled = True
        Else
            bloquearTabs.Visible = False

            btnPuestaP.Enabled = True
            btnOrdenProduccion.Enabled = True
            btnInformes.Enabled = True
            btnClientes.Enabled = True
            btnMedidas.Enabled = True
            btn_usuarios.Enabled = True

        End If


        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Dim textCerrarS As String = "Cerrar sesión '" & loginUsuario & "'"
        Dim textW As Integer = textCerrarS.Length * 8

        Dim textX As Integer = x - textW
        With btnCerrarS
            .Text = textCerrarS
            .Width = textW
            .Location = New Point((x - textW) - 2, 2)
        End With


        populateOP()
        populateDgvPuestaPunto()
        populateDgvPeso()
    End Sub


    Private Sub Principal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm.Close()
    End Sub


    Private Sub btnPesaje_Click(sender As Object, e As EventArgs) Handles btnPesaje.Click
        tabsPrincipal.SelectedTab = tabPesaje
        populateDgvPeso()
    End Sub


    Private Sub btnOrdenProduccion_Click(sender As Object, e As EventArgs) Handles btnOrdenProduccion.Click
        tabsPrincipal.SelectedTab = tabOrdenProduccion
        populateOP()
    End Sub


    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        tabsPrincipal.SelectedTab = tabInformes
    End Sub


    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Clientes.Show()
    End Sub


    Private Sub btnMedidas_Click(sender As Object, e As EventArgs) Handles btnMedidas.Click
        MedidasYGramajes.Show()
    End Sub


    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        Usuarios.Show()
    End Sub


    Private Sub btnNuevaOP_Click(sender As Object, e As EventArgs) Handles btnNuevaOP.Click
        OrdenProduccion.Show()
        idOrdenProduccion = 0
    End Sub


    Private Sub dgvOrdenes_Click(sender As Object, e As EventArgs) Handles dgvOrdenes.Click
        'MsgBox(sender)
    End Sub


    Private Sub dgvOrdenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdenes.CellClick
        If e.RowIndex >= 0 Then
            Dim id As String = dgvOrdenes.Item(0, e.RowIndex).Value
            'MsgBox("yes: " + id.ToString())
            populateDetalle(id)
        End If
    End Sub


    Private Sub dgvOrdenes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdenes.CellDoubleClick
        If e.RowIndex >= 0 Then
            idOrdenProduccion = CInt(dgvOrdenes.Item(0, e.RowIndex).Value)
            OrdenProduccion.Show()
        End If
    End Sub

    Private Sub btnCerrarS_Click(sender As Object, e As EventArgs) Handles btnCerrarS.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.salir()
    End Sub

    Private Sub btnPP_Click(sender As Object, e As EventArgs) Handles btnPP.Click
        populateDgvPuestaPunto()
        PuestaPunto.Show()
    End Sub

    Private Sub btnPuestaP_Click(sender As Object, e As EventArgs) Handles btnPuestaP.Click
        populateDgvPuestaPunto()
        tabsPrincipal.SelectedTab = tabPuestaPunto
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds -= 1
        contador.Text = seconds
        If (seconds <= 0) Then
            If (btnExe.Text = "Capturar Peso") Then
                Timer1.Stop()
                btnExe.Text = "Continuar"
                btnExe.Enabled = True
                btnExe.BackColor = Color.Red
                estCom.ForeColor = Color.Red
                seconds = 10
                Timer1.Start()
            ElseIf (btnExe.Text = "Continuar") Then
                Timer1.Stop()
                btnExe.BackColor = Color.Green
                btnExe.Text = "Capturar Peso"
                estCom.Text = "Esperando ejecución de lectura de báscula..."
                capturaPeso.Text = "0"
                contador.Text = "..."
                estCom.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        If (btnExe.Text = "Capturar Peso") Then
            btnExe.Enabled = False
            btnExe.BackColor = Color.LightSlateGray
            estCom.Text = "Por favor verifique que en el área de la báscula solo se encuentre el rollo a pesar"
            estCom.Font = Font
            estCom.ForeColor = Color.Red
            Timer1.Start()
        ElseIf (btnExe.Text = "Continuar") Then
            capturaPeso.Text = leerCom()
            btnExe.Enabled = True
            btnExe.BackColor = Color.Green
            btnExe.Text = "Capturar Peso"
            Timer1.Stop()
            contador.Text = "..."
            estCom.Text = "Esperando ejecución de lectura de báscula..."
        End If

        seconds = 4

    End Sub



    Private Sub dgvPesaje_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesaje.CellClick
        If e.RowIndex >= 0 Then
            Dim id As String = dgvPesaje.Item(0, e.RowIndex).Value
            lblPPId.Text = id
            populateDgvDetallePP()

            'cliente = dgvOP.Item(1, e.RowIndex).Value
            'idOrdenProduccion = id
            'cdetalleOP(id)
        End If
    End Sub





    Private Sub tabsPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabsPrincipal.SelectedIndexChanged
        If (perfilUsuario > 2 And tabsPrincipal.SelectedIndex > 0) Then
            tabsPrincipal.SelectedIndex = 0
            'MsgBox("Fuera Niga!")
        End If
    End Sub

    Private Sub dgvDetallePP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetallePP.CellDoubleClick

        'PrintPreviewDialog1.Document = PrintSticker
        'PrintPreviewDialog1.Show()
        'DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        'If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then
        'PrintDocument1.Print()

        'PrintSticker.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Sticker", 300, 150)
        PrintSticker.Print()
        'End If
    End Sub

    Private Sub PrintSticker_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintSticker.PrintPage
        'PrintSticker.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Sticker", 200, 50)
        PrintSticker.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Sticker", 300, 150)
        Dim myFont As Font = New Font("Arial", 14, FontStyle.Regular)
        'e.Graphics.DrawRectangle(New Pen(Color.Black, 3), New Rectangle(0, 0, 300, 150))
        e.Graphics.DrawString("PR-RB-OP-MESDIA/CONS-GRAM", myFont, Brushes.Black, 10, 10)
        '.Graphics.DrawImage()
        'PrintDocument1.Print()
    End Sub

    Private Sub btnRP1_Click(sender As Object, e As EventArgs) Handles btnRP1.Click
        orden_produccion.Show()
    End Sub

    Private Sub btnGuardarPeso_Click(sender As Object, e As EventArgs) Handles btnGuardarPeso.Click
        Dim txtError As String = ""
        If (lblPPId.Text = 0) Then txtError &= "- No has seleccionado un item de puesta a punto válida" & vbCrLf
        If (capturaPeso.Text <= 0) Then txtError &= "- Peso no válido" & vbCrLf
        If (cmbDestino.Text.Length <= 0) Then txtError &= "- Destino no válido" & vbCrLf
        If (txtError = "") Then
            'MsgBox("Todo bien... procediendo con el resto")
            Dim sqlS As String
            Dim exe
            sqlS = $"insert into pesaje (
                pp_detalle_id, bascula, peso, destino, usuario_login) values (
                {lblPPId.Text}, '{valBascula.Text}', '{capturaPeso.Text.Replace(".", "").Replace(",", ".")}', '{cmbDestino.Text}', '{loginUsuario}')"
            Console.WriteLine(sqlS)
            myConn.Open()
            myCmd = New SqlCommand(sqlS, myConn)
            exe = myCmd.ExecuteScalar()
            myCmd.Dispose()
            myConn.Close()
            'If (exe) Then
            populateDgvPeso()
            populateDgvDetallePP()
            sticker.Show() 'Imprimir sticker
            cmbDestino.SelectedValue = ""
            capturaPeso.Text = "0"
            'Else
            '    MsgBox("Ha ocurrido un error al tratar de guardar la información")
            'End If
        Else
                MsgBox("Error:" & vbCrLf & txtError)
        End If
    End Sub
End Class
