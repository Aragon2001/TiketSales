Imports System.Data
Imports System.Data.SqlClient

Public Class Reportes_DB
    Inherits Conexion_DB

    Public Function ObtenerVuelosYDestinos() As DataTable
        Dim query As String = "EXEC ObtenerVuelosYDestinos"
        Return EjecutarStoredProc(query)
    End Function

    Public Function ObtenerRecolectadoVentanilla(nombreVentanilla As String) As DataTable
        Dim query As String = "EXEC ObtenerRecolectadoVentanilla @NombreVentanilla"
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@NombreVentanilla", nombreVentanilla)
        }
        Return EjecutarStoredProc(query, parametros)
    End Function

    Public Function ObtenerPasajerosPorVuelo(idVuelo As Integer) As DataTable
        Dim query As String = "EXEC ObtenerPasajerosPorVuelo @IDVuelo"
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@IDVuelo", idVuelo)
        }
        Return EjecutarStoredProc(query, parametros)
    End Function

    Public Function ObtenerPasajerosBajados(idEscala As Integer) As DataTable
        Dim query As String = "EXEC ObtenerPasajerosBajados @IDEscala"
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@IDEscala", idEscala)
        }
        Return EjecutarStoredProc(query, parametros)
    End Function

    Public Function ObtenerPasajerosLlegaronDestino(idVuelo As Integer) As DataTable
        Dim query As String = "EXEC ObtenerPasajerosLlegaronDestino @IDVuelo"
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@IDVuelo", idVuelo)
        }
        Return EjecutarStoredProc(query, parametros)
    End Function

    Private Function EjecutarStoredProc(query As String, Optional parametros As List(Of SqlParameter) = Nothing) As DataTable
        Dim dataTable As New DataTable()
        Using connection As SqlConnection = GetConecction()
            Using command As New SqlCommand(query, connection)
                If parametros IsNot Nothing Then
                    command.Parameters.AddRange(parametros.ToArray())
                End If
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                dataTable.Load(reader)
            End Using
        End Using
        Return dataTable
    End Function
End Class
