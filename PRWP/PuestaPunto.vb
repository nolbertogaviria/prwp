Imports System.Data.SqlClient


Public Class PuestaPunto


    Private detalleOP As New DataTable
    Private detallePP As New DataTable
    Private cliente As String



    Public Sub cdetalleOP(id)
        Dim filterDT As DataTable = detalleOP.Clone()
        Dim rows As DataRow() = detalleOP.[Select]("[O.P.]=" & id & " And [activa]=1 And [Gramaje]='" & cmbOPGram.SelectedValue & "'")
        For Each row As DataRow In rows
            filterDT.ImportRow(row)
        Next

        lblMedidas.DataSource = filterDT
        With lblMedidas
            '.Columns("ID").Visible = False
            .Columns("Medida").Width = 50
            .Columns("Gramaje").Width = 50
            'With .Columns("Peso")
            '    .Width = 50
            '    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .ValueType = GetType(Integer)
            '    .DefaultCellStyle.Format = "N0"
            'End With
            '.Columns("Usuario").Visible = False
        End With
    End Sub



    Public Sub populateCmbGram()
        myConn.Open()

        Dim DR As SqlDataReader
        Dim DT As New DataTable()
        Dim sqlC As String = "select gramaje
            from orden_produccion_detalle opd 
            where not exists (
	            select id 
	            from puesta_punto_detalle ppd 
	            where ppd.op_detalle_id = opd.id
            )
            group by gramaje
            order by gramaje"
        '"select gramaje from orden_produccion_detalle group by gramaje order by gramaje"
        DR = New SqlCommand(sqlC, myConn).ExecuteReader()
        DT = New DataTable()
        With DT.Columns
            .Add("gramaje", GetType(String))
        End With
        DT.Rows.Add("")
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(DR.Item("gramaje"))
            Loop
        End If
        DR.Close()
        With cmbOPGram
            .ValueMember = "gramaje"
            .DisplayMember = "gramaje"
            .DataSource = DT
            .SelectedValue = vbNull
        End With

        myConn.Close()
    End Sub




    Public Sub populateOPs(gramaje As String)
        Dim ids As String = ""
        Dim dataOP As New DataTable()
        dataOP = dtOP(gramaje, 1)

        dgvOP.DataSource = dataOP

        'ReDim ids(dataOP.Rows.Count)
        For Each row As DataRow In dataOP.Rows
            ids &= CInt(row("ID OP")) & ","
        Next row
        ids = ids.Substring(0, ids.Length - 1)

        detalleOP = cargarDetalle(ids)
    End Sub

    Private Sub populateDetalle(op As Integer)
        'populate DataGridView de Detalles
        'dgvDetalleOP.DataSource = cargarDetalle(op)


        With lblMedidas
            '.Columns("ID").Visible = False
            .Columns("Medida").Width = 50
            .Columns("Gramaje").Width = 50
            'With .Columns("Peso")
            '    .Width = 50
            '    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .ValueType = GetType(Integer)
            '    .DefaultCellStyle.Format = "N0"
            'End With
            '.Columns("Usuario").Visible = False
        End With

    End Sub

    Private Sub PuestaPunto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Height = intY
        Me.Width = intX
        Me.Top = 0
        Me.Left = 0


        populateCmbGram()
        'preparar el datatable del detalle de la OP
        'Dim detallePP As New DataTable

        With detallePP.Columns
            .Add("Cliente", GetType(String))
            .Add("Orden Prod.", GetType(String))
            .Add("ID", GetType(String))
            .Add("Medida", GetType(String))
            .Add("Gramaje", GetType(String))
            .Add("Cantidad", GetType(String))
        End With

        dgvDetallePP.DataSource = detallePP

    End Sub



    Private Sub dgvDetalleOP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles lblMedidas.CellDoubleClick
        'adicionar al detalle de la PP

        If e.RowIndex >= 0 Then
            'Console.WriteLine("La fila es: " & e.RowIndex)
            Dim R As DataRow = detallePP.NewRow
            R("Cliente") = cliente
            R("Orden Prod.") = idOrdenProduccion.ToString.PadLeft(4, "0")
            R("ID") = CInt(lblMedidas.Item(0, e.RowIndex).Value)
            R("Medida") = lblMedidas.Item(2, e.RowIndex).Value
            R("Gramaje") = lblMedidas.Item(3, e.RowIndex).Value
            R("Cantidad") = 0

            detallePP.Rows.Add(R)
            dgvDetallePP.DataSource = detallePP

            With dgvDetallePP.Columns
                .Item("Cliente").ReadOnly = True
                .Item("Orden Prod.").ReadOnly = True
                .Item("ID").ReadOnly = True
                .Item("Medida").ReadOnly = True
                .Item("Gramaje").ReadOnly = True
                .Item("Cantidad").ReadOnly = False
            End With


            'detalleOP.Rows(e.RowIndex)("activa") = 0
            Dim myRow() As Data.DataRow
            myRow = detalleOP.Select("id = " & lblMedidas.Item(0, e.RowIndex).Value & "")
            myRow(0)("activa") = 0
            txtTotalMeds.Text = Convert.ToInt32(txtTotalMeds.Text) + Convert.ToInt32(myRow(0)("Medida"))

            If (Convert.ToInt32(txtTotalMeds.Text) > 0) Then
                cmbOPGram.Enabled = False
            Else
                cmbOPGram.Enabled = True
            End If

            cdetalleOP(idOrdenProduccion)
        End If

    End Sub

    Private Sub dgvDetallePP_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvDetallePP.UserDeletingRow
        If e.Row.Index >= 0 Then
            Dim myRow() As Data.DataRow
            myRow = detalleOP.Select("id = " & e.Row.Cells(2).Value & "")
            myRow(0)("activa") = 1
            txtTotalMeds.Text = Convert.ToInt32(txtTotalMeds.Text) - Convert.ToInt32(myRow(0)("Medida"))
            If (Convert.ToInt32(txtTotalMeds.Text) = 0) Then
                cmbOPGram.Enabled = True
            End If
            cdetalleOP(idOrdenProduccion)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim txtError As String = ""
        Dim medsPP As Integer = 0
        Dim cansPP As Integer = 0
        Dim cansError As String = ""

        For Each row As DataRow In detallePP.Rows
            medsPP += row.Item("Medida")
            If (row.Item("Cantidad") > 0) Then
                cansPP += row.Item("Cantidad")
            Else
                cansError &= row.Item("ID") & ", "
            End If
        Next row

        If (medsPP = 0) Then txtError &= "- No hay medidas para continuar" & vbCrLf
        If (cansError <> "") Then txtError &= "- Falta cantidad en ID(s) " & cansError & vbCrLf
        If (txtRebobinadora.Text.Length < 1) Then txtError &= "- Debe escribir la Rebobinadora" & vbCrLf
        If (txtOperario.Text.Length < 1) Then txtError &= "- Debe escribir el Operario" & vbCrLf



        If (txtError = "") Then
            'Guardar

            Dim ttlRows As Integer = detallePP.Rows.Count
            Dim pos As Integer = 0
            Dim ids As String = ""

            Dim sqlS
            Dim exe
            sqlS = $"INSERT INTO puesta_punto (
                    rebobinadora,
                    operario,
                    usuario_login
                ) values (
                '{txtRebobinadora.Text}',
                '{txtOperario.Text}',
                '{loginUsuario}'
                ); SELECT SCOPE_IDENTITY()"

            myConn.Open()
            myCmd = New SqlCommand(sqlS, myConn)
            exe = myCmd.ExecuteScalar()
            myCmd.Dispose()
            myConn.Close()

            Dim exeD
            For Each row As DataRow In detallePP.Rows
                sqlS = $"INSERT INTO puesta_punto_detalle 
                    (op_detalle_id, puesta_punto_id, cantidad, usuario_login) VALUES 
                    ({row("id")}, {exe}, {row("cantidad")},'{loginUsuario}')
                "
                exeD = sqlNonQuery(sqlS)
            Next row


            'Console.WriteLine(sqlS)

            Dim hm As String = Format(Now, "hh:mm:ss tt")
            If (exe > 0) Then
                Principal.populateDgvPuestaPunto()
                MsgBox("Se ha creado la puesta a punto")
                Me.Close()
            Else
                MsgBox("Ha ocurrido un error al tratar de guardar la información del detalle")
            End If

        Else
            MsgBox("Error:" & vbCrLf & vbCrLf & txtError)
        End If
    End Sub



    Private Sub cmbOPGram_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbOPGram.SelectedValueChanged
        Dim v As String = cmbOPGram.SelectedValue
        If (v <> "") Then
            populateOPs(v)
            lblMedidas.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvOP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOP.CellClick
        If e.RowIndex >= 0 Then
            Dim id As String = dgvOP.Item(0, e.RowIndex).Value
            'MsgBox("yes: " + id.ToString())
            cliente = dgvOP.Item(1, e.RowIndex).Value
            idOrdenProduccion = id
            cdetalleOP(id)
        End If
    End Sub

    Private Sub PuestaPunto_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim intX As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim intY As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Height = intY - 100
        Me.Width = intX - 100
        Me.Top = 0
        Me.Left = 100
    End Sub

    Private Sub PuestaPunto_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        'Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        'Me.Height = intY
        'Me.Width = intX
        'Me.Top = 0
        'Me.Left = 0
    End Sub
End Class