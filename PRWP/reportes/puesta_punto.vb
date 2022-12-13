Public Class puesta_punto
    Private Sub puesta_punto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'prwpDataSet.reporte_puesta_punto' Puede moverla o quitarla según sea necesario.
        Me.reporte_puesta_puntoTableAdapter.Fill(Me.prwpDataSet.reporte_puesta_punto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class