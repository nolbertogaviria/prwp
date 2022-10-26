Imports System.Data.SqlClient


Public Class OrdenProduccion



    Private Sub populateCmbCliente()
        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("SELECT id, nombre FROM cliente where activo = 1 order by nombre", myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("id", GetType(Integer))
            .Add("nombre", GetType(String))
        End With

        DT.Rows.Add(0, "")

        If DR.HasRows Then
            Do While DR.Read()
                Dim itemId = DR.Item("id")
                Dim itemValue = DR.Item("nombre")
                DT.Rows.Add(itemId, itemValue)
            Loop
        End If
        DR.Close()
        DR = Nothing

        cmbCliente.ValueMember = "id"
        cmbCliente.DisplayMember = "nombre"
        cmbCliente.DataSource = DT
        DT = Nothing
        myConn.Close()

    End Sub

    Private Sub populateEstado()
        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("select id, estado from estado order by estado asc", myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("id", GetType(Integer))
            .Add("estado", GetType(String))
        End With
        DT.Rows.Add(0, "Seleccionar estado...")
        If DR.HasRows Then
            Do While DR.Read()
                Dim itemId = DR.Item("id")
                Dim itemValue = DR.Item("estado")
                DT.Rows.Add(itemId, itemValue)
            Loop
        End If
        DR.Close()

        With cmbEstado
            .ValueMember = "id"
            .DisplayMember = "estado"
            .DataSource = DT
        End With
        DT = Nothing



        DR = New SqlCommand("select medida from medida order by medida asc", myConn).ExecuteReader()
        DT = New DataTable()
        With DT.Columns
            .Add("medida", GetType(String))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(DR.Item("medida"))
            Loop
        End If
        DR.Close()
        With cmbMedida
            .ValueMember = "medida"
            .DisplayMember = "medida"
            .DataSource = DT
            .SelectedValue = vbNull
        End With

        DR = New SqlCommand("select gramaje from gramaje order by gramaje asc", myConn).ExecuteReader()
        DT = New DataTable()
        With DT.Columns
            .Add("gramaje", GetType(String))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(DR.Item("gramaje"))
            Loop
        End If
        DR.Close()
        With cmbGramaje
            .ValueMember = "gramaje"
            .DisplayMember = "gramaje"
            .DataSource = DT
            .SelectedValue = vbNull
        End With


        DR = New SqlCommand("select tipo_papel from tipo_papel order by tipo_papel asc", myConn).ExecuteReader()
        DT = New DataTable()
        With DT.Columns
            .Add("tipo_papel", GetType(String))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(DR.Item("tipo_papel"))
            Loop
        End If
        DR.Close()
        myConn.Close()
    End Sub

    Private Sub populateDetalle()
        dgvDetalle.DataSource = cargarDetalle(idOrdenProduccion)
        With dgvDetalle
            .Columns("ID").Visible = False
            .Columns("Medida").Width = 50
            .Columns("Gramaje").Width = 50
            .Columns("Peso Rq.").Width = 100
        End With
    End Sub


    Private Sub limpiarAddDetalle()
        cmbMedida.SelectedValue = vbNull
        cmbGramaje.SelectedValue = vbNull
        cmbGramaje.Text = 0
    End Sub



    Private Sub populateOP()

        If (idOrdenProduccion = 0) Then
            Me.Text = "Crear Orden de Producción"
            cmbEstado.SelectedValue = 1
        Else
            Me.Text = "Editar Orden de Producción " & idOrdenProduccion.ToString.PadLeft(4, "0") & ""
            panelDetalle.Visible = True

            Dim ssql = "
                select
                    id,
                    cliente_id,
                    consecutivo,
                    fecha,
                    usuario_login,
                    observaciones,
                    estado_id
                from orden_produccion
                where id = " & idOrdenProduccion & "
            "


            Dim idOP As Int32
            myConn.Open()
            Dim DR As SqlDataReader = New SqlCommand(ssql, myConn).ExecuteReader()


            If DR.HasRows Then
                Do While DR.Read()
                    idOP = DR.Item("id")
                    cmbCliente.SelectedValue = DR.Item("cliente_id")
                    txtConsecutivo.Text = DR.Item("id").ToString.PadLeft(4, "0")
                    txtFecha.Text = DR.Item("fecha")
                    txtUsuario.Text = DR.Item("usuario_login")
                    txtObservaciones.Text = DR.Item("observaciones")
                    cmbEstado.SelectedValue = DR.Item("estado_id")
                Loop
            End If
            DR.Close()
            myConn.Close()
            populateDetalle()
        End If




    End Sub






    Private Sub OrdenProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCmbCliente()
        populateEstado()
        populateOP()
    End Sub

    Private Sub btnGuardarMedida_Click(sender As Object, e As EventArgs) Handles btnGuardarMedida.Click

        Dim txtError As String = ""
        If (cmbCliente.SelectedValue = 0) Then txtError &= "- Debes seleccionar un cliente" & vbCrLf
        If (cmbEstado.SelectedValue = 0) Then txtError &= "- Debes seleccionar un estado valido" & vbCrLf

        If (txtError <> "") Then
            MsgBox(txtError)
        Else
            Dim hm As String = Format(Now, "hh:mm:ss tt")
            Try
                'buscar consecutivo
                Dim nuevoCons As String
                Dim consecutivo As String = sqlScalar("select top(1) consecutivo from orden_produccion where year(fecha) = year(GETDATE()) order by fecha desc")
                If (consecutivo <> "") Then
                    nuevoCons = consecutivo + 1
                Else
                    Dim y As String = Year(Date.Now())
                    nuevoCons = y.Substring(y.Length - 1) & "001"
                End If

                Dim sqlS
                Dim exe
                If (idOrdenProduccion > 0) Then
                    sqlS = $"UPDATE orden_produccion SET 
                    cliente_id = {cmbCliente.SelectedValue}, 
                    usuario_login = '{loginUsuario}',
                    observaciones = '{txtObservaciones.Text}', 
                    estado_id = {cmbEstado.SelectedValue}
                    WHERE id = {idOrdenProduccion}"

                    myConn.Open()
                    myCmd = New SqlCommand(sqlS, myConn)
                    exe = myCmd.ExecuteNonQuery()
                    myCmd.Dispose()
                    myConn.Close()

                Else
                    sqlS = $"INSERT INTO orden_produccion 
                        (consecutivo, cliente_id, usuario_login, observaciones, estado_id)
                        VALUES (
                        '{nuevoCons}', 
                        '{cmbCliente.SelectedValue}', 
                        '{loginUsuario}', 
                        '{txtObservaciones.Text}', 
                        {cmbEstado.SelectedValue}
                        ); SELECT SCOPE_IDENTITY()"

                    myConn.Open()
                    myCmd = New SqlCommand(sqlS, myConn)
                    exe = myCmd.ExecuteScalar()
                    myCmd.Dispose()
                    myConn.Close()
                End If




                If (exe > 0) Then
                    idOrdenProduccion = exe
                    populateOP()
                    Principal.populateOP()
                    lblResultado.Text = hm & " Información de Orden de Producción guardada correctamente"
                    lblResultado.ForeColor = Color.Green
                    panelDetalle.Visible = True
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar la información de la Orden de Producción"
                    lblResultado.ForeColor = Color.Red
                End If
            Catch ex As Exception
                lblResultado.Text = hm & " " & ex.Message
                lblResultado.ForeColor = Color.Red
            Finally
                If myConn IsNot Nothing AndAlso myConn.State <> ConnectionState.Closed Then
                    myConn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim txtError As String = ""
        If (idOrdenProduccion < 1) Then txtError &= "- Parece que hay un error con esta O.P. Por favor cierra esta ventana y vuelve a intentarlo" & vbCrLf
        If (Not cmbMedida.SelectedValue <> "") Then txtError &= "- No has seleccionado medida" & vbCrLf
        If (Not cmbGramaje.SelectedValue <> "") Then txtError &= "- No has seleccionado gramaje" & vbCrLf
        'If (Not cmbTipoPapel.SelectedValue <> "") Then txtError &= "- No has seleccionado tipo de papel" & vbCrLf
        If (txtPeso.Text.Length = 0) Then txtError &= "- Debes digitar el peso" & vbCrLf
        If (Not esNumero(txtPeso.Text)) Then txtError &= "- Solo se admiten números"

        If (txtError = "") Then
            Dim hm As String = Format(Now, "hh:mm:ss tt")
            Try

                Dim sql As String = $"
                insert into orden_produccion_detalle
                    (medida, gramaje, peso, orden_produccion_id, usuario_login, activa) values
                    (
                     '{cmbMedida.SelectedValue.ToString}', 
                     '{cmbGramaje.SelectedValue}', 
                     '{txtPeso.Text}', 
                     {idOrdenProduccion},
                     '{loginUsuario}', 
                     1
                    )
                "

                myConn.Open()
                myCmd = New SqlCommand(sql, myConn)
                Dim exe = myCmd.ExecuteNonQuery()
                myCmd.Dispose()
                myConn.Close()

                If (exe > 0) Then
                    populateDetalle()
                    limpiarAddDetalle()
                    lblResultado.Text = hm & " Detalle de Orden de Producción guardado correctamente"
                    lblResultado.ForeColor = Color.Green
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar el detalle de la Orden de Producción"
                    lblResultado.ForeColor = Color.Red
                End If
            Catch ex As Exception
                lblResultado.Text = hm & " " & ex.Message
                lblResultado.ForeColor = Color.Red
            End Try

        Else
            MsgBox(txtError)
        End If
    End Sub



    Private Sub dgvDetalle_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvDetalle.UserDeletingRow

        If Not MessageBox.Show("Esta Seguro?", "Va a eliminar esta fila " & e.Row.Cells(0).Value, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = True
        Else
            If e.Row.Index >= 0 Then
                Dim sql As String = "delete top(1) from orden_produccion_detalle where id = " & e.Row.Cells(0).Value
                'Console.WriteLine(sql)
                If (sqlNonQuery(sql)) Then
                    Principal.populateOP()
                    Principal.populateDgvEstado()
                End If
            End If
        End If
    End Sub

    Private Sub OrdenProduccion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        idOrdenProduccion = 0
    End Sub
End Class