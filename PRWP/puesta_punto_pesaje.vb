﻿Imports System.Data.SqlClient

Public Class puesta_punto_pesaje

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
End Class