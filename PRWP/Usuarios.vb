Imports System.Data.SqlClient

Public Class Usuarios

    Private Sub limpiar()
        txtLogin.Text = ""
        txtNombre.Text = ""
        lblFechaCreacion.Text = ""
        lblFechaConexion.Text = ""
        chkActivo.Checked = True
        cmbPerfil.SelectedItem = 0
        txtId.Text = "0"
        lblResultado.Text = "Esperando operación..."
        lblResultado.ForeColor = Color.Gray
    End Sub


    Private Sub pUsers()

        Dim act As String = "1"
        If (rdiInactivos.Checked) Then act = "0"

        myConn.Open()

        ' Listbox Usuarios
        Dim usrDR As SqlDataReader = New SqlCommand("SELECT id, nombre FROM usuario where activo = " & act & "order by nombre ", myConn).ExecuteReader()
        Dim usrDT As New DataTable()
        With usrDT.Columns
            .Add("id", GetType(Integer))
            .Add("nombre", GetType(String))
        End With

        usrDT.Rows.Add(0, "Seleccionar Usuario...")

        If usrDR.HasRows Then
            Do While usrDR.Read()
                Dim itemId = usrDR.Item("id")
                Dim itemValue = usrDR.Item("nombre")
                usrDT.Rows.Add(itemId, itemValue)
            Loop
        End If
        usrDR.Close()

        ListBoxUsuarios.ValueMember = "id"
        ListBoxUsuarios.DisplayMember = "nombre"
        ListBoxUsuarios.DataSource = usrDT

        myConn.Close()

    End Sub


    Private Sub pPerfil()

        'Combo Perfil
        myConn.Open()
        Dim prfDR As SqlDataReader = New SqlCommand("SELECT id, descripcion FROM perfil WHERE id > 1 order by descripcion", myConn).ExecuteReader()
        Dim prfDT As New DataTable()
        With prfDT.Columns
            .Add("id", GetType(Integer))
            .Add("descripcion", GetType(String))
        End With

        prfDT.Rows.Add(0, "Seleccionar Perfil...")

        If prfDR.HasRows Then
            Do While prfDR.Read()
                Dim itemId = prfDR.Item("id")
                Dim itemValue = prfDR.Item("descripcion")
                prfDT.Rows.Add(itemId, itemValue)
            Loop
        End If
        prfDR.Close()

        cmbPerfil.ValueMember = "id"
        cmbPerfil.DisplayMember = "descripcion"
        cmbPerfil.DataSource = prfDT

        myConn.Close()

    End Sub



    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        limpiar()
        pUsers()
        pPerfil()

    End Sub




    Private Sub ListBoxUsuarios_Click(sender As Object, e As EventArgs) Handles ListBoxUsuarios.Click
        Dim id = ListBoxUsuarios.SelectedValue


        If (id > 0) Then
            Try
                myConn.Open()
                myCmd = New SqlCommand("SELECT top(1) login, nombre, fecha_creacion, fecha_conexion as fecha_conexion, perfil, activo FROM usuario WHERE id = " & id, myConn)
                Dim dr As SqlDataReader
                dr = myCmd.ExecuteReader()

                While dr.Read
                    limpiar()
                    txtLogin.Text = dr.Item("login")
                    txtNombre.Text = dr.Item("nombre")
                    lblFechaCreacion.Text = dr.Item("fecha_creacion")
                    If (Not IsDBNull(dr.Item("fecha_conexion"))) Then
                        lblFechaConexion.Text = dr.Item("fecha_conexion")
                    End If
                    If (dr.Item("activo")) Then chkActivo.Checked = True Else chkActivo.Checked = False
                    'cmbPerfil.SelectedItem = dr.Item("perfil")
                    cmbPerfil.AutoCompleteMode = False
                    cmbPerfil.SelectedValue = dr.Item("perfil")
                    txtId.Text = id
                End While

                dr.Close()
                myCmd.Dispose()
                myConn.Close()

                'MsgBox(sqlDR("SELECT login FROM usuario WHERE id = " & id))
            Catch ex As Exception
                MsgBox("Exception::ListBoxUsuarios_Click::Error: " & vbCrLf & ex.Message)
            End Try
        Else
            'MsgBox("NO ID:" & vbCrLf & "[" & id & "]")
            limpiar()
        End If
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim txtError As String = ""
        Dim activo = 0
        Dim sqlUPassword = ""

        If (txtLogin.Text.Length < 5) Then txtError &= "- Login no válido" & vbCrLf
        If (txtNombre.Text.Length < 6) Then txtError &= "- Nombre no válido" & vbCrLf
        If (txtPassword1.Text.Length > 0 Or txtId.Text = "0") Then
            If (txtPassword1.Text.Length < 6) Then
                txtError &= "- Contraseña muy corta" & vbCrLf
            Else
                If (txtPassword1.Text <> txtPassword2.Text) Then
                    txtError &= "- Las contraseñas deben ser iguales" & vbCrLf
                Else
                    sqlUPassword = $" password = HASHBYTES('SHA2_512','{txtPassword1.Text}'), "
                End If
            End If
        End If
        If (cmbPerfil.SelectedValue = 0) Then txtError &= "- Debe seleccionar un perfil" & vbCrLf
        If (chkActivo.Checked) Then activo = 1


        If (txtError = "") Then
            Dim hm As String = Format(Now, "hh:mm:ss tt")
            Try
                Dim sqlS
                If (txtId.Text > 0) Then
                    sqlS = $"UPDATE usuario SET 
                    login = '{txtLogin.Text}', 
                    nombre = '{txtNombre.Text }',{sqlUPassword}
                    perfil = {cmbPerfil.SelectedValue}, 
                    activo = {activo} 
                    WHERE id = {txtId.Text}"
                Else
                    sqlS = $"INSERT INTO usuario (login, nombre, password, perfil, activo)
                        VALUES ('{txtLogin.Text}', 
                        '{txtNombre.Text}', 
                        HASHBYTES(
                            'SHA2_512', 
                            '{txtPassword1.Text}'
                        ), 
                        {cmbPerfil.SelectedValue}, 
                        {activo})"
                End If

                myConn.Open()
                myCmd = New SqlCommand(sqlS, myConn)
                Dim exe = myCmd.ExecuteNonQuery()
                myCmd.Dispose()
                myConn.Close()


                If (exe > 0) Then
                    pUsers()
                    lblResultado.Text = hm & " Información de usuario guardada correctamente"
                    lblResultado.ForeColor = Color.Green
                Else
                    lblResultado.Text = hm & " Ha ocurrido un error al tratar de guardar la información del usuario"
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
        Else
            MsgBox("Error: " & vbCrLf & txtError)
        End If
    End Sub

    Private Sub rdiActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rdiActivos.CheckedChanged
        pUsers()
    End Sub

    Private Sub rdiInactivos_CheckedChanged(sender As Object, e As EventArgs) Handles rdiInactivos.CheckedChanged
        pUsers()
    End Sub
End Class