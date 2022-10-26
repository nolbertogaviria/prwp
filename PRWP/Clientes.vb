Imports System.Data.SqlClient


Public Class Clientes


    Private Sub limpiar()
        txtNit.Text = ""
        txtDv.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        txtObservaciones.Text = ""
        resFechaCreacion.Text = ""
        chkActivo.Checked = True
        cmbMunicipio.SelectedItem = 0
        txtId.Text = ""
        lblResultado.Text = "Esperando operación..."
        lblResultado.ForeColor = Color.Gray
    End Sub



    Private Sub populateClientes()

        Dim act As String = "1"
        If (rdiInactivos.Checked) Then act = "0"

        myConn.Open()

        ' Listbox Clientes
        Dim cliDR As SqlDataReader = New SqlCommand("SELECT id, nombre FROM cliente where activo = " & act & "order by nombre ", myConn).ExecuteReader()
        Dim cliDT As New DataTable()
        With cliDT.Columns
            .Add("id", GetType(Integer))
            .Add("nombre", GetType(String))
        End With

        cliDT.Rows.Add(0, "Seleccionar Cliente...")

        If cliDR.HasRows Then
            Do While cliDR.Read()
                Dim itemId = cliDR.Item("id")
                Dim itemValue = cliDR.Item("nombre")
                cliDT.Rows.Add(itemId, itemValue)
            Loop
        End If
        cliDR.Close()

        ListBoxClientes.ValueMember = "id"
        ListBoxClientes.DisplayMember = "nombre"
        ListBoxClientes.DataSource = cliDT

        myConn.Close()

    End Sub


    Private Sub populateMunicipios()

        'Combo Perfil
        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("SELECT municipio.codigo_dane, concat(municipio.municipio, ', ', departamento.departamento) as mundpto FROM municipio inner join departamento on municipio.departamento_codigo_dane = departamento.codigo_dane order by municipio.municipio", myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("codigo_dane", GetType(String))
            .Add("mundpto", GetType(String))
        End With

        DT.Rows.Add("0", "Seleccionar Municipio...")

        If DR.HasRows Then
            Do While DR.Read()
                Dim itemId = DR.Item("codigo_dane")
                Dim itemValue = DR.Item("mundpto")
                DT.Rows.Add(itemId, itemValue)
            Loop
        End If
        DR.Close()

        cmbMunicipio.ValueMember = "codigo_dane"
        cmbMunicipio.DisplayMember = "mundpto"
        cmbMunicipio.DataSource = DT

        cmbMunicipio.AutoCompleteMode = AutoCompleteMode.Append
        cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDown
        cmbMunicipio.AutoCompleteSource = AutoCompleteSource.ListItems

        myConn.Close()

    End Sub







    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateClientes()
        populateMunicipios()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim txtError As String = ""
        Dim activo = 0

        If (txtNit.Text.Length < 5) Then txtError = txtError & "- NIT no válido" & vbCrLf
        If (txtNombre.Text.Length < 6) Then txtError = txtError & "- Nombre no válido" & vbCrLf
        If (txtDireccion.Text.Length < 6) Then txtError = txtError & "- Dirección no válida" & vbCrLf
        If (txtTelefono.Text.Length < 10) Then txtError = txtError & "- Teléfono no valido" & vbCrLf
        If (cmbMunicipio.SelectedValue = "0") Then txtError = txtError & "- Debe seleccionar un municipio" & vbCrLf
        If (chkActivo.Checked) Then activo = 1

        If (txtError = "") Then
            Dim hm As String = Format(Now, "hh:mm:ss tt")
            'Try
            Dim sqlS
            If (txtId.Text <> "") Then
                sqlS = $"UPDATE cliente SET 
                        nit = '{txtNit.Text}', 
                        dv = '{txtDv.Text}', 
                        nombre = '{txtNombre.Text}', 
                        direccion = '{txtDireccion.Text}', 
                        email = '{txtEmail.Text}', 
                        telefono = '{txtTelefono.Text}', 
                        municipio = '{cmbMunicipio.SelectedValue}', 
                        observaciones = '{txtObservaciones.Text}', 
                        activo = {activo} 
                        WHERE id = {txtId.Text}"
            Else
                sqlS = $"INSERT INTO cliente (
                        nit,
                        dv,
                        nombre, 
                        direccion,
                        email, 
                        telefono,
                        municipio,
                        observaciones,
                        activo
                    ) VALUES (
                        '{txtNit.Text}', 
                        '{txtDv.Text}', 
                        '{txtNombre.Text}', 
                        '{txtDireccion.Text}', 
                        '{txtEmail.Text}', 
                        '{txtTelefono.Text}', 
                        '{cmbMunicipio.SelectedValue}', 
                        '{txtObservaciones.Text}', 
                        {activo}
                    )"
            End If

            Dim exe = sqlNonQuery(sqlS)

            If (exe > 0) Then
                populateClientes()
                lblResultado.Text = hm & " Información de cliente guardada correctamente"
                lblResultado.ForeColor = Color.Green
                lblResultado.BackColor = Color.Transparent
            Else
                lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar la información del cliente"
                lblResultado.ForeColor = Color.Red
                lblResultado.BackColor = Color.Transparent
            End If


        Else
            MsgBox("Error: " & vbCrLf & txtError)
        End If
    End Sub

    Private Sub ListBoxClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxClientes.SelectedIndexChanged
        Dim id = ListBoxClientes.SelectedValue


        If (id > 0) Then

            myConn.Open()
            myCmd = New SqlCommand("SELECT top(1) nit, dv, nombre, direccion, municipio, email, telefono, observaciones, fecha_creacion, activo FROM cliente WHERE id = " & id, myConn)
            Dim dr As SqlDataReader
            dr = myCmd.ExecuteReader()

            While dr.Read
                txtNit.Text = dr.Item("nit")
                txtDv.Text = dr.Item("dv")
                txtNombre.Text = dr.Item("nombre")
                txtDireccion.Text = dr.Item("direccion")
                txtEmail.Text = dr.Item("email")
                txtTelefono.Text = dr.Item("telefono")
                txtObservaciones.Text = dr.Item("observaciones")
                resFechaCreacion.Text = dr.Item("fecha_creacion")
                If (dr.Item("activo")) Then chkActivo.Checked = True Else chkActivo.Checked = False
                cmbMunicipio.AutoCompleteMode = False
                cmbMunicipio.SelectedValue = dr.Item("municipio")
                txtId.Text = id
            End While

            dr.Close()
            myCmd.Dispose()
            myConn.Close()


        Else
            'MsgBox("NO ID:" & vbCrLf & "[" & id & "]")
            limpiar()
        End If
    End Sub

    Private Sub rdiActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rdiActivos.CheckedChanged
        populateClientes()
    End Sub

    Private Sub rdiInactivos_CheckedChanged(sender As Object, e As EventArgs) Handles rdiInactivos.CheckedChanged
        populateClientes()
    End Sub

    Private Sub txtFiltrarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrarCliente.TextChanged
        ListBoxClientes.DataSource.DefaultView.RowFilter = "[nombre] like '%" & txtFiltrarCliente.Text.Trim() & "%'"
    End Sub


End Class