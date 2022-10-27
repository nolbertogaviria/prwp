Imports System.Data.SqlClient
'Imports System.Configuration
'Imports System.IO
'Imports System.Configuration.ConfigurationManager

Module Funciones
    'Variables publicas para usar en toda la aplicacion
    Public loginUsuario As String = "developer"
    Public perfilUsuario As Integer = 1
    Public idOrdenProduccion As Int32 = 0

    Dim txtSqlServer As String = My.Computer.FileSystem.ReadAllText("sqlserver.dat")

    'Public strConnection As String = "Initial Catalog=prwp;Data Source=" & txtSqlServer & ";Integrated Security=SSPI;"
    Public strConnection As String = "Data Source=" & txtSqlServer & ";Initial Catalog=prwp;Persist Security Info=True;User ID=sa;Password=Prwp.2022++"

    'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    'config.AppSettings.Settings("radbtnBrowseSLD").Value = "newvalue"
    'config.AppSettings.Settings("connectionStrings").Valu
    'config.Save(ConfigurationSaveMode.Modified)
    'ConfigurationManager.RefreshSection("appSettings")

    Public myConn = New SqlConnection(strConnection)
    Public myCmd = myConn.CreateCommand

    Public Function esNumero(c)
        Dim v As Integer
        Dim validPeso As Boolean = Int32.TryParse(c, v)
        esNumero = validPeso
    End Function


    Public Function sqlScalar(sSql As String)
        Dim myConn, myCmd, res
        myConn = New SqlConnection(strConnection)
        myCmd = myConn.CreateCommand
        myConn.Open()
        myCmd = New SqlCommand(sSql, myConn)
        res = myCmd.ExecuteScalar()
        myCmd.Dispose()
        myConn.Close()

        sqlScalar = res
    End Function

    Public Function sqlDR(sSql As String)
        Dim myConn, myCmd
        myConn = New SqlConnection(strConnection)
        myCmd = myConn.CreateCommand
        myConn.Open()
        myCmd = New SqlCommand(sSql, myConn)
        Dim res As SqlDataReader
        res = myCmd.ExecuteReader()
        myCmd.Dispose()
        myConn.Close()
        sqlDR = res
    End Function


    Public Function sqlNonQuery(sSql As String)
        Console.WriteLine(sSql)
        Dim myConn, myCmd, res
        myConn = New SqlConnection(strConnection)
        myCmd = myConn.CreateCommand
        myConn.Open()
        myCmd = New SqlCommand(sSql, myConn)
        res = myCmd.ExecuteNonQuery()
        myCmd.Dispose()
        myConn.Close()

        sqlNonQuery = res
    End Function


    Public Function cargarDetalle(idOP)
        'Console.WriteLine(idOP)
        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("
            select 
	            opd.id,
                opd.orden_produccion_id,
	            opd.medida,
	            opd.gramaje,
                opd.peso,
	            opd.usuario_login,
	            opd.fecha
            from orden_produccion_detalle opd
            where orden_produccion_id in (" & idOP & ") 
            and not exists (
	            select id 
	            from puesta_punto_detalle ppd 
	            where ppd.op_detalle_id = opd.id
            )
            ", myConn).ExecuteReader()

        Dim DT As New DataTable()
        With DT.Columns
            .Add("ID", GetType(Integer))
            .Add("O.P.", GetType(Integer))
            .Add("Medida", GetType(String))
            .Add("Gramaje", GetType(String))
            .Add("Peso Rq.", GetType(String))
            .Add("Usuario", GetType(String))
            .Add("Fecha", GetType(Date))
            .Add("activa", GetType(Boolean))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(
                    DR.Item("id"),
                    DR.Item("orden_produccion_id"),
                    DR.Item("medida"),
                    DR.Item("gramaje"),
                    DR.Item("peso"),
                    DR.Item("usuario_login"),
                    DR.Item("fecha"),
                    1
                )
            Loop
        End If
        DR.Close()
        DR = Nothing

        cargarDetalle = DT
        myConn.Close()


    End Function




    Public Function dtOP(Optional ByVal gramaje As String = "%", Optional ByVal estado As Integer = 1)
        'Detalle de la Orden de Producción
        Dim cmds As String

        cmds = $"
            select
                orden_produccion.id, 
                cliente.nombre,
                estado.estado,
                (select top(1) fecha from orden_produccion op1 where op1.id = orden_produccion.id) as fecha
            from orden_produccion 
            inner join cliente on orden_produccion.cliente_id = cliente.id
            inner join estado on orden_produccion.estado_id = estado.id
            inner join orden_produccion_detalle on orden_produccion.id = orden_produccion_detalle.orden_produccion_id
            where orden_produccion_detalle.gramaje like '{gramaje}'
            and not exists (
	            select id 
	            from puesta_punto_detalle ppd 
	            where ppd.op_detalle_id = orden_produccion_detalle.id
            )
            group by orden_produccion.id, 
                cliente.nombre,
                estado.estado
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


        dtOP = DT

    End Function



    Public Function dtPP()
        'Detalle de la Puesta a Punto

        myConn.Open()
        Dim DR As SqlDataReader = New SqlCommand("
            select
                orden_produccion.id, 
                cliente.nombre,
                estado.estado,
                orden_produccion.fecha
            from orden_produccion 
            inner join cliente on orden_produccion.cliente_id = cliente.id
            inner join estado on orden_produccion.estado_id = estado.id
            order by fecha asc", myConn).ExecuteReader()

        Dim DT As New DataTable()
        With DT.Columns
            .Add("ID", GetType(String))
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

        dtPP = DT

    End Function


End Module
