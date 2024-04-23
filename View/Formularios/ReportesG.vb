Imports DataAccess

Public Class ReportesG
    Dim reportesDB As New Reportes_DB()

    Private Sub BtnVuelosDestinos_Click(sender As Object, e As EventArgs) Handles BtnVuelosDestinos.Click
        ' Llamar al procedimiento almacenado correspondiente en la clase Reportes_DB
        Dim dataTable As DataTable = reportesDB.ObtenerVuelosYDestinos()
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnRecolectadoVentanilla_Click(sender As Object, e As EventArgs) Handles BtnRecolectadoVentanilla.Click
        ' Llamar al procedimiento almacenado correspondiente en la clase Reportes_DB
        Dim nombreVentanilla As String = cbVentanilla.Text
        Dim dataTable As DataTable = reportesDB.ObtenerRecolectadoVentanilla(nombreVentanilla)
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnPasajerosPorVuelo_Click(sender As Object, e As EventArgs) Handles BtnPasajerosPorVuelo.Click
        ' Llamar al procedimiento almacenado correspondiente en la clase Reportes_DB
        Dim idVuelo As Integer = Convert.ToInt32(cbVuelo.Text)
        Dim dataTable As DataTable = reportesDB.ObtenerPasajerosPorVuelo(idVuelo)
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnPasajerosBajados_Click(sender As Object, e As EventArgs) Handles BtnPasajerosBajados.Click
        ' Llamar al procedimiento almacenado correspondiente en la clase Reportes_DB
        Dim idEscala As Integer = Convert.ToInt32(cbEscala.Text)
        Dim dataTable As DataTable = reportesDB.ObtenerPasajerosBajados(idEscala)
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnPasajerosLlegaronDestino_Click(sender As Object, e As EventArgs) Handles BtnPasajerosLlegaronDestino.Click
        ' Llamar al procedimiento almacenado correspondiente en la clase Reportes_DB
        Dim idVuelo As Integer = Convert.ToInt32(cbDestino.Text)
        Dim dataTable As DataTable = reportesDB.ObtenerPasajerosLlegaronDestino(idVuelo)
        DataGridView1.DataSource = dataTable
    End Sub
End Class
