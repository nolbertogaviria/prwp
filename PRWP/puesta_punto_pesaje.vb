Imports System.Data.SqlClient

Public Class puesta_punto_pesaje

    Private medidas As New DataTable

    Public Sub populateMedidas()
        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim t As Integer
        Dim DRm As SqlDataReader
        Dim DTm = New DataTable()
        Dim sqlC As String = "select medida
            from orden_produccion_detalle 
            where gramaje = '" & cmbOPGram.Text & "'
            and orden_produccion_id = '" & cmbOP.Text & "'"
        DRm = New SqlCommand(sqlC, myConn).ExecuteReader()

        With DTm.Columns
            .Add("medida", GetType(String))
            .Add("activa", GetType(Integer))
        End With
        If DRm.HasRows Then
            Do While DRm.Read()
                t += 1
                DTm.Rows.Add(
                    DRm.Item("medida"),
                    1
                )
            Loop
        End If
        medidas = DTm
        DRm.Close()
        myConn.Close()
        Console.WriteLine(t & " Medidas")
    End Sub


    Public Sub populateCmbOP()
        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim DRop As SqlDataReader
        Dim DTop = New DataTable()
        Dim sqlC As String = "select op.id from orden_produccion op inner join cliente c on op.cliente_id = c.id  "
        DRop = New SqlCommand(sqlC, myConn).ExecuteReader()

        With DTop.Columns
            .Add("id", GetType(Integer))
        End With
        'DTop.Rows.Add("...")
        If DRop.HasRows Then
            Do While DRop.Read()
                DTop.Rows.Add(DRop.Item("id"))
            Loop
        End If

        DRop.Close()
        With cmbOP
            .ValueMember = "id"
            .DisplayMember = "id"
            .DataSource = DTop
            .SelectedValue = vbNull
        End With
        myConn.Close()
    End Sub

    Public Sub populateCmbOperario()
        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim DRop As SqlDataReader
        Dim DTop = New DataTable()
        Dim sqlC As String = "select operario from operario order by operario"
        DRop = New SqlCommand(sqlC, myConn).ExecuteReader()

        With DTop.Columns
            .Add("operario", GetType(String))
        End With
        'DTop.Rows.Add("...")
        If DRop.HasRows Then
            Do While DRop.Read()
                DTop.Rows.Add(DRop.Item("operario"))
            Loop
        End If

        DRop.Close()
        With cmbOperario
            .ValueMember = "operario"
            .DisplayMember = "operario"
            .DataSource = DTop
            .SelectedValue = vbNull
        End With
        myConn.Close()
    End Sub


    Public Sub populateCmbRebobinadora()
        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim DRop As SqlDataReader
        Dim DTop = New DataTable()
        Dim sqlC As String = "select rebobinadora from rebobinadora order by rebobinadora"
        DRop = New SqlCommand(sqlC, myConn).ExecuteReader()

        With DTop.Columns
            .Add("rebobinadora", GetType(String))
        End With
        'DTop.Rows.Add("...")
        If DRop.HasRows Then
            Do While DRop.Read()
                DTop.Rows.Add(DRop.Item("rebobinadora"))
            Loop
        End If

        DRop.Close()
        With cmbRebobinadora
            .ValueMember = "rebobinadora"
            .DisplayMember = "rebobinadora"
            .DataSource = DTop
            .SelectedValue = vbNull
        End With
        myConn.Close()
    End Sub




    Public Sub populateCmbGram()
        If (myConn.State = ConnectionState.Closed) Then myConn.Open()
        Dim DR As SqlDataReader
        Dim DT As New DataTable()
        Dim sqlC As String = "select gramaje
            from orden_produccion_detalle opd 
            where not exists (
	            select id 
	            from puesta_punto_detalle ppd 
	            where ppd.op_detalle_id = opd.id
            )
            and opd.orden_produccion_id = " & cmbOP.Text & "
            group by gramaje
            order by gramaje"
        DR = New SqlCommand(sqlC, myConn).ExecuteReader()
        DT = New DataTable()
        With DT.Columns
            .Add("gramaje", GetType(String))
        End With
        'DT.Rows.Add("")
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

    Private Sub puesta_punto_pesaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCmbOP()
        populateCmbRebobinadora()
        populateCmbOperario()
    End Sub


    Private Sub cmbOP_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbOP.SelectionChangeCommitted
        Dim sql As String = "select c.nombre from orden_produccion op " _
            & "join cliente c on op.cliente_id = c.id " _
            & "where op.id = '" & cmbOP.SelectedValue & "'"
        txtCliente.Text = sqlScalar(sql)
        populateCmbGram()
    End Sub

    Private Sub med1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles med1.SelectionChangeCommitted
        Dim myRow() As Data.DataRow
        myRow = medidas.Select("medida = '" & med1.Text & "'")
        myRow(0)("activa") = 0
    End Sub

    Private Sub med1_DropDown(sender As Object, e As EventArgs) Handles med1.DropDown
        If (medidas.Rows.Count > 0) Then
            Dim filterDT As DataTable = medidas.Clone()
            Dim rows As DataRow() = medidas.[Select]("[activa]=1")
            For Each row As DataRow In rows
                filterDT.ImportRow(row)
            Next
            med1.DataSource = filterDT
        Else
            MsgBox("Lo siento, no encontre el dataTable para medidas :´(")
        End If
    End Sub

    Private Sub cmbOPGram_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbOPGram.SelectionChangeCommitted
        populateMedidas()
    End Sub
End Class