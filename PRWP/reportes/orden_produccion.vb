Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class orden_produccion

    Dim orden As String = "asc"
    Private Sub orden_produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'prwpDataSet.report_op' Puede moverla o quitarla según sea necesario.
        Me.report_opTableAdapter.Fill(Me.prwpDataSet.report_op)
        'ReportOP.da

        Dim params(4) As ReportParameter
        params(0) = New ReportParameter("fecha_inicial", dtpFechaIni.Text, False)
        params(1) = New ReportParameter("fecha_final", dtpFechaFin.Text, False)
        params(2) = New ReportParameter("filtrar_por", cmbFiltrarPor.Text, False)
        params(3) = New ReportParameter("filtro", txtFiltro.Text, False)
        params(4) = New ReportParameter("ordenar_por", cmbOrdenarPor.Text, False)
        params(4) = New ReportParameter("orden", orden, False)

        Me.ReportOP.RefreshReport()
        'ejecutar()
    End Sub




    Private Sub ejecutar()

        '-------------------
        Dim sql As String = "select login, nombre, fecha_conexion from usuario"

        myConn.Open
        Dim DR As SqlDataReader = New SqlCommand(sql, myConn).ExecuteReader()
        Dim DT As New DataTable()
        With DT.Columns
            .Add("Usuario", GetType(String))
            .Add("Nombre", GetType(String))
            .Add("Fecha_Conexión", GetType(String))
        End With
        If DR.HasRows Then
            Do While DR.Read()
                DT.Rows.Add(
                    DR.Item("login"),
                    DR.Item("nombre"),
                    DR.Item("fecha_conexion")
                )

            Loop
        End If

        'Dim DS As DataSet = New DataSet("datosReporte")

        'prwpDataSet.Tables.Add(DT)

        'Dim ta As New OleDb.OleDbDataAdapter(cmd)
        'Dim ta As New 
        'ta.Fill(dt)
        With Me.ReportOP.LocalReport
            .DataSources.Clear()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetOP", DT))
        End With
        Me.ReportOP.RefreshReport()


        DR.Close()
        DR = Nothing
        DT = Nothing
        myConn.Close
        '----------------

    End Sub

    Private Sub radAsc_CheckedChanged(sender As Object, e As EventArgs) Handles radAsc.CheckedChanged
        If (radAsc.Checked = True) Then
            radDesc.Checked = False
            orden = "asc"
        End If
    End Sub

    Private Sub radDesc_CheckedChanged(sender As Object, e As EventArgs) Handles radDesc.CheckedChanged
        If (radDesc.Checked = True) Then
            radAsc.Checked = False
            orden = "desc"
        End If
    End Sub
End Class