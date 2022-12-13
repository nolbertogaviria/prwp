Imports System.Data.SqlClient





Public Class MedidasYGramajes


    Private Sub btnClick(m As Integer)
        Dim hm As String = Format(Now, "hh:mm:ss tt")
        Dim result As DialogResult = MsgBox("Proceder a eliminar medida " & m & "?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim sSql = "DELETE TOP(1) FROM medida WHERE medida = " & m
            Dim exe = sqlNonQuery(sSql)
            If (exe > 0) Then
                populateMedidas()
                lblResultado.Text = hm & " Medida " & m & " eliminada correctamente"
                lblResultado.ForeColor = Color.Green
                lblResultado.BackColor = Color.Transparent
            Else
                lblResultado.Text = hm & " Ha ocurrido un error al tratar de eliminar la medida " & m & ""
                lblResultado.ForeColor = Color.Red
                lblResultado.BackColor = Color.Transparent
            End If
        Else
            Console.WriteLine("No pasa nada")
        End If
    End Sub


    Private Sub btnClickGramaje(m As String)
        Dim hm As String = Format(Now, "hh:mm:ss tt")
        Dim result As DialogResult = MsgBox("Proceder a eliminar gramaje " & m & "?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim sSql = "DELETE TOP(1) FROM gramaje WHERE gramaje = '" & m & "'"
            Dim exe = sqlNonQuery(sSql)
            If (exe > 0) Then
                populateGramajes()
                lblResultado.Text = hm & " Gramaje " & m & " eliminado correctamente"
                lblResultado.ForeColor = Color.Green
                lblResultado.BackColor = Color.Transparent
            Else
                lblResultado.Text = hm & " Ha ocurrido un error al tratar de eliminar el gramaje " & m & ""
                lblResultado.ForeColor = Color.Red
                lblResultado.BackColor = Color.Transparent
            End If
        Else
            Console.WriteLine("No pasa nada")
        End If
    End Sub



    Private Sub btnClickOperario(m As String)
        Dim hm As String = Format(Now, "hh:mm:ss tt")
        Dim result As DialogResult = MsgBox("Eliminar operario " & m & "?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim sSql = "DELETE TOP(1) FROM operario WHERE operario = '" & m & "'"
            Dim exe = sqlNonQuery(sSql)
            If (exe > 0) Then
                populateOperarios()
                lblResultado.Text = hm & " Operario " & m & " eliminado correctamente"
                lblResultado.ForeColor = Color.Green
                lblResultado.BackColor = Color.Transparent
            Else
                lblResultado.Text = hm & " Ha ocurrido un error al tratar de eliminar el operario " & m & ""
                lblResultado.ForeColor = Color.Red
                lblResultado.BackColor = Color.Transparent
            End If
        Else
            Console.WriteLine("No pasa nada")
        End If
    End Sub


    Private Sub btnClickRebobinadora(m As String)
        Dim hm As String = Format(Now, "hh:mm:ss tt")
        Dim result As DialogResult = MsgBox("Eliminar rebobinadora " & m & "?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim sSql = "DELETE TOP(1) FROM rebobinadora WHERE rebobinadora = '" & m & "'"
            Dim exe = sqlNonQuery(sSql)
            If (exe > 0) Then
                populateRebobinadoras()
                lblResultado.Text = hm & " Rebobinadora " & m & " eliminada correctamente"
                lblResultado.ForeColor = Color.Green
                lblResultado.BackColor = Color.Transparent
            Else
                lblResultado.Text = hm & " Ha ocurrido un error al tratar de eliminar la rebobinadora " & m & ""
                lblResultado.ForeColor = Color.Red
                lblResultado.BackColor = Color.Transparent
            End If
        Else
            Console.WriteLine("No pasa nada")
        End If
    End Sub


    Private Sub populateMedidas()
        FlowLayoutPanel1.Controls.Clear()

        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("SELECT medida FROM medida order by medida ", myConn).ExecuteReader()

        If DR.HasRows Then
            Do While DR.Read()
                Dim b As New Button
                b.Text = DR.Item("medida")
                b.Name = DR.Item("medida")
                FlowLayoutPanel1.Controls.Add(b)
                AddHandler b.Click, Sub(sender2, eventargs2) btnClick(b.Text)
            Loop
        End If
        DR.Close()
        myConn.Close()
    End Sub


    Private Sub populateGramajes()
        FlowLayoutPanel2.Controls.Clear()

        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("SELECT gramaje FROM gramaje order by gramaje ", myConn).ExecuteReader()

        If DR.HasRows Then
            Do While DR.Read()
                Dim b As New Button
                b.Text = DR.Item("gramaje")
                b.Name = DR.Item("gramaje")
                FlowLayoutPanel2.Controls.Add(b)
                AddHandler b.Click, Sub(sender2, eventargs2) btnClickGramaje(b.Text)
            Loop
        End If
        DR.Close()
        myConn.Close()
    End Sub


    Private Sub populateOperarios()
        dgvOperarios.DataSource = Nothing
        Dim cmdsop As String
        cmdsop = $"SELECT operario FROM operario order by operario "
        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim DRop As SqlDataReader = New SqlCommand(cmdsop, myConn).ExecuteReader()
        Dim DTop As New DataTable()
        DTop.Columns.Add("Operario", GetType(String))
        If DRop.HasRows Then
            Do While DRop.Read()
                DTop.Rows.Add(DRop.Item("operario"))
            Loop
        End If
        DRop.Close()
        myConn.Close()
        dgvOperarios.DataSource = DTop
    End Sub


    Private Sub populateRebobinadoras()
        dgvRebobinadoras.DataSource = Nothing
        Dim cmdsre As String
        cmdsre = $"SELECT rebobinadora FROM rebobinadora order by rebobinadora "
        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim DRre As SqlDataReader = New SqlCommand(cmdsre, myConn).ExecuteReader()
        Dim DTre As New DataTable()
        DTre.Columns.Add("Rebobinadora", GetType(String))
        If DRre.HasRows Then
            Do While DRre.Read()
                DTre.Rows.Add(DRre.Item("rebobinadora"))
            Loop
        End If
        DRre.Close()
        myConn.Close()
        dgvRebobinadoras.DataSource = DTre
    End Sub

    Private Sub inicial()
        populateMedidas()
        populateGramajes()
        populateOperarios()
        populateRebobinadoras()
    End Sub


    Private Sub medidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial()
    End Sub



    Private Sub txtMedida_KeyPress(sender As Object, e As KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If (Len(txtMedida.Text) > 4) Then
            MsgBox("No puedes escribir mas de 4 numeros")
            txtMedida.Text = ""
        End If
    End Sub

    Private Sub txtGramaje_KeyPress(sender As Object, e As KeyPressEventArgs)

        If (Len(txtGramaje.Text) > 8) Then
            MsgBox("No puedes escribir mas de 8 digitos")
            txtGramaje.Text = ""
        End If
    End Sub





    Private Sub btnGuardarGramaje_Click(sender As Object, e As EventArgs) Handles btnGuardarGramaje.Click
        Dim terror As String = ""
        Dim v As Integer
        Dim valid As Boolean = Int32.TryParse(txtGramaje.Text, v)

        If (Len(txtGramaje.Text) = 0) Then terror &= "- Gramaje vacío" & vbCrLf
        If (terror = "") Then
            Dim sqlS
            Dim xg As Integer = sqlScalar("SELECT count(gramaje) from gramaje where gramaje = '" & txtGramaje.Text & "'")
            If (Not xg > 0) Then
                txtGramaje.Text = txtGramaje.Text.ToUpper()
                sqlS = $"INSERT INTO gramaje (gramaje) values ('{txtGramaje.Text}')"
                Dim exe = sqlNonQuery(sqlS)

                Dim hm As String = Format(Now, "hh:mm:ss tt")
                If (exe > 0) Then
                    populateGramajes()
                    txtGramaje.Text = ""
                    lblResultado.Text = hm & " Gramaje guardado correctamente"
                    lblResultado.ForeColor = Color.Green
                    lblResultado.BackColor = Color.Transparent
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar el gramaje"
                    lblResultado.ForeColor = Color.Red
                    lblResultado.BackColor = Color.Transparent
                End If
            Else
                MsgBox("Ya existe gramaje")
            End If
        Else
            MsgBox(terror)
        End If
    End Sub



    Private Sub btnGuardarMedida_Click(sender As Object, e As EventArgs) Handles btnGuardarMedida.Click
        Dim terror As String = ""
        Dim v As Integer
        Dim valid As Boolean = Int32.TryParse(txtMedida.Text, v)

        If (Len(txtMedida.Text) = 0) Then terror &= "- Medida vacía" & vbCrLf
        If (Not valid) Then terror &= "- Solo números" & vbCrLf
        If (terror = "") Then
            Dim xg As Integer = sqlScalar("SELECT count(medida) from medida where medida = '" & txtMedida.Text & "'")
            If (Not xg > 0) Then
                Dim sqlS
                sqlS = $"INSERT INTO medida (medida) values ({txtMedida.Text})"
                Dim exe = sqlNonQuery(sqlS)

                Dim hm As String = Format(Now, "hh:mm:ss tt")
                If (exe > 0) Then
                    populateMedidas()
                    txtMedida.Text = ""
                    lblResultado.Text = hm & " Medida guardada correctamente"
                    lblResultado.ForeColor = Color.Green
                    lblResultado.BackColor = Color.Transparent
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar la medida"
                    lblResultado.ForeColor = Color.Red
                    lblResultado.BackColor = Color.Transparent
                End If
            Else
                MsgBox("Ya existe medida")
            End If
        Else
            MsgBox(terror)
        End If
    End Sub

    Private Sub btnGuardarOperario_Click(sender As Object, e As EventArgs) Handles btnGuardarOperario.Click
        Dim terror As String = ""

        If (Len(txtOperario.Text) = 0) Then terror &= "- Operario vacío" & vbCrLf

        If (terror = "") Then
            Dim xg As Integer = sqlScalar("SELECT count(operario) from operario where operario = '" & txtOperario.Text & "'")
            If (Not xg > 0) Then
                txtOperario.Text = txtOperario.Text.ToUpper()
                Dim sqlS
                sqlS = $"INSERT INTO operario (operario) values ('{txtOperario.Text}')"
                Dim exe = sqlNonQuery(sqlS)

                Dim hm As String = Format(Now, "hh:mm:ss tt")
                If (exe > 0) Then
                    populateOperarios()
                    txtOperario.Text = ""
                    lblResultado.Text = hm & " Operario guardado correctamente"
                    lblResultado.ForeColor = Color.Green
                    lblResultado.BackColor = Color.Transparent
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar el operario"
                    lblResultado.ForeColor = Color.Red
                    lblResultado.BackColor = Color.Transparent
                End If
            Else
                MsgBox("Ya existe este operario")
            End If
        Else
            MsgBox(terror)
        End If
    End Sub

    Private Sub btnGuardarRebob_Click(sender As Object, e As EventArgs) Handles btnGuardarRebob.Click
        Dim terror As String = ""

        If (Len(txtRebobinadora.Text) = 0) Then terror &= "- Campo Rebobinadora vacío" & vbCrLf

        If (terror = "") Then
            Dim xg As Integer = sqlScalar("SELECT count(rebobinadora) from rebobinadora where rebobinadora = '" & txtRebobinadora.Text & "'")
            If (Not xg > 0) Then
                txtRebobinadora.Text = txtRebobinadora.Text.ToUpper()
                Dim sqlS
                sqlS = $"INSERT INTO rebobinadora (rebobinadora) values ('{txtRebobinadora.Text}')"
                Dim exe = sqlNonQuery(sqlS)

                Dim hm As String = Format(Now, "hh:mm:ss tt")
                If (exe > 0) Then
                    populateRebobinadoras()
                    txtRebobinadora.Text = ""
                    lblResultado.Text = hm & " Rebobinadora guardada correctamente"
                    lblResultado.ForeColor = Color.Green
                    lblResultado.BackColor = Color.Transparent
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar la rebobinadora"
                    lblResultado.ForeColor = Color.Red
                    lblResultado.BackColor = Color.Transparent
                End If
            Else
                MsgBox("Ya existe esta rebobinadora")
            End If
        Else
            MsgBox(terror)
        End If
    End Sub

    Private Sub dgvRebobinadoras_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvRebobinadoras.UserDeletingRow
        If e.Row.Index >= 0 Then
            btnClickRebobinadora(e.Row.Cells(0).Value)
        End If
    End Sub

    Private Sub dgvOperarios_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvOperarios.UserDeletingRow
        If e.Row.Index >= 0 Then
            btnClickOperario(e.Row.Cells(0).Value)
        End If
    End Sub
End Class