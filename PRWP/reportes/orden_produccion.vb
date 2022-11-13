Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting
Imports Microsoft.Reporting.WinForms


Public Class orden_produccion

    Dim orden As String = "asc"
    Private Sub orden_produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'prwpDataSet.reporte_orden_produccion' Puede moverla o quitarla según sea necesario.
        'Me.reporte_orden_produccionTableAdapter.Fill(
        '    Me.prwpDataSet.reporte_orden_produccion,
        '    dtpFechaIni.Text,
        '    dtpFechaFin.Text
        ')
        'Me.ReportOP.RefreshReport()

        ''******************

        ejecutar()
    End Sub




    Private Sub ejecutar()

        Dim params(1) As ReportParameter
        params(0) = New ReportParameter("fecha_inicial", dtpFechaIni.Text, False)
        params(1) = New ReportParameter("fecha_final", dtpFechaFin.Text, False)
        'params(2) = New ReportParameter("filtrar_por", cmbFiltrarPor.Text, False)
        'params(3) = New ReportParameter("filtro", txtFiltro.Text, False)
        'params(4) = New ReportParameter("ordenar_por", cmbOrdenarPor.Text, False)
        'params(5) = New ReportParameter("orden", orden, False)
        Me.ReportOP.LocalReport.SetParameters(params)
        'For Each param As WinForms.ReportParameterInfo In ReportOP.LocalReport.GetParameters()
        '    Console.WriteLine(param.Name & ":" & param.Values(0))
        'Next

        Me.reporte_orden_produccionTableAdapter.Fill(
            Me.prwpDataSet.reporte_orden_produccion,
            dtpFechaIni.Text,
            dtpFechaFin.Text
        )
        Me.ReportOP.RefreshReport()

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

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        ejecutar()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

End Class