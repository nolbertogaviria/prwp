Public Class orden_produccion
    Private Sub orden_produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'prwpDataSet.report_op' Puede moverla o quitarla según sea necesario.
        Me.report_opTableAdapter.Fill(Me.prwpDataSet.report_op)
        'ReportOP.da

        Me.ReportOP.RefreshReport()
    End Sub


End Class