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



    Private Sub btnClickTipoPapel(m As String)
        Dim hm As String = Format(Now, "hh:mm:ss tt")
        Dim result As DialogResult = MsgBox("Eliminar tipo papel " & m & "?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim sSql = "DELETE TOP(1) FROM tipo_papel WHERE tipo_papel = '" & m & "'"
            Dim exe = sqlNonQuery(sSql)
            If (exe > 0) Then
                populateTiposPapel()
                lblResultado.Text = hm & " Tipo papel " & m & " eliminado correctamente"
                lblResultado.ForeColor = Color.Green
                lblResultado.BackColor = Color.Transparent
            Else
                lblResultado.Text = hm & " Ha ocurrido un error al tratar de eliminar el tipo papel " & m & ""
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


    Private Sub populateTiposPapel()
        FlowLayoutPanel3.Controls.Clear()

        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("SELECT tipo_papel FROM tipo_papel order by tipo_papel ", myConn).ExecuteReader()

        If DR.HasRows Then
            Do While DR.Read()
                Dim b As New Button
                b.Text = DR.Item("tipo_papel")
                b.Name = DR.Item("tipo_papel")
                FlowLayoutPanel3.Controls.Add(b)
                AddHandler b.Click, Sub(sender2, eventargs2) btnClickTipoPapel(b.Text)
            Loop
        End If
        DR.Close()
        myConn.Close()
    End Sub

    Private Sub medidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateMedidas()
        populateGramajes()
        populateTiposPapel()
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

    Private Sub btnGuardarNuevoTipo_Click(sender As Object, e As EventArgs) Handles btnGuardarNuevoTipo.Click
        Dim terror As String = ""

        If (Len(txtTipoPapel.Text) = 0) Then terror &= "- Tipo papel vacío" & vbCrLf

        If (terror = "") Then
            Dim xg As Integer = sqlScalar("SELECT count(tipo_papel) from tipo_papel where tipo_papel = '" & txtTipoPapel.Text & "'")
            If (Not xg > 0) Then
                txtTipoPapel.Text = txtTipoPapel.Text.ToUpper()
                Dim sqlS
                sqlS = $"INSERT INTO tipo_papel (tipo_papel) values ('{txtTipoPapel.Text}')"
                Dim exe = sqlNonQuery(sqlS)

                Dim hm As String = Format(Now, "hh:mm:ss tt")
                If (exe > 0) Then
                    populateTiposPapel()
                    txtTipoPapel.Text = ""
                    lblResultado.Text = hm & " Tipo papel guardado correctamente"
                    lblResultado.ForeColor = Color.Green
                    lblResultado.BackColor = Color.Transparent
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar el tipo de papel"
                    lblResultado.ForeColor = Color.Red
                    lblResultado.BackColor = Color.Transparent
                End If
            Else
                MsgBox("Ya existe este tipo de papel")
            End If
        Else
            MsgBox(terror)
        End If
    End Sub
End Class