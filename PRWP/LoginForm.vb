Imports System.Reflection
Imports System.Data.SqlClient

Public Class LoginForm

    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String


    Public Sub salir()
        Application.Exit()
        End
    End Sub




    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim s = "SELECT perfil FROM usuario where login = '" & username.Text & "' and password = HASHBYTES('SHA2_512','" & password.Text & "')"
        'Dim count As Int32 = Convert.ToInt32(sqlScalar(s))
        Dim res As Integer = Convert.ToInt32(sqlScalar(s))
        Dim hm As String = Format(Now, "hh:mm:ss tt")
        If (res > 0) Then
            loginUsuario = username.Text
            perfilUsuario = res
            estadoValidacion.Text = hm & ": Validaciones correctas, procediendo a la pantalla principal"
            estadoValidacion.ForeColor = Color.Green

            'guardar ultima conexion en tabla [usuario]
            sqlNonQuery("UPDATE usuario SET fecha_conexion = CURRENT_TIMESTAMP")

            'Abrir formulario principal
            Dim f As New Principal
            f.Show()
            'Ocultarme
            username.Text = ""
            password.Text = ""
            estadoValidacion.Text = "Esperando operación..."
            Me.Hide()
        Else
            'MsgBox("Error de Autenticacion")
            estadoValidacion.Text = hm & ": Error al validar las credenciales de autenticación"
            estadoValidacion.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        salir()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim compDate = IO.File.GetLastWriteTime(Application.ExecutablePath)
        lblCompDate.Text = "Fecha compilación: " & compDate.ToShortDateString & " " & compDate.ToShortTimeString
    End Sub

End Class
