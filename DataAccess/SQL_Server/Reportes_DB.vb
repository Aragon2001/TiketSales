Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Sockets

Public Class Reportes_DB
    Inherits Conexion_DB

    Public Function ObtenerVuelosYDestinos() As DataTable
        Dim query As String = "EXEC ObtenerVuelosYDestinos"
        Return EjecutarStoredProc(query)
    End Function
    Public Function ObtenerReporteVentanillasConVentas() As DataTable
        Dim reporteVentanillas As New DataTable()

        Try
            Using connection = GetConecction()
                connection.Open()

                ' Consulta para obtener el reporte de ventanillas con sus ventas
                Dim query As String = "
    SELECT 
        VA.ID_ventanilla, 
        VA.Nombre_empleado AS NombreEmpleado, 
        VA.Numero_cedula AS NumeroCedula, 
        VA.Hora_apertura AS HoraAperturaVentanilla, 
        COUNT(V.ID_venta) AS TotalVentas, 
        SUM(V.Monto_total) AS TotalVentasMonto 
    FROM 
        Ventanilla VA 
    LEFT JOIN 
        Venta V ON VA.ID_ventanilla = V.ID_ventanilla 
    GROUP BY 
        VA.ID_ventanilla, 
        VA.Nombre_empleado, 
        VA.Numero_cedula, 
        VA.Hora_apertura
"
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(reporteVentanillas)
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            Throw New Exception("Error al obtener el reporte de ventanillas con ventas desde la base de datos", ex)
        End Try

        Return reporteVentanillas
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


    Public Function ObtenerTicket(idTicket As Integer) As DataTable
        Dim ticket As New DataTable()

        Try
            Using connection = GetConecction()
                connection.Open()

                ' Obtener información del ticket
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT T.ID_tiquete, T.ID_venta, T.ID_pasajero, T.ID_vuelo, T.ID_avion, T.ID_ventanilla, T.Hora_venta, T.Monto_total, " &
                                      "P.Nombre AS NombrePasajero, P.Num_identificacion AS IdentificacionPasajero, " &
                                      "A.Marca_avion AS MarcaAvion, A.Ciudad_origen AS CiudadOrigen, A.Ciudades_escala AS CiudadesEscala, " &
                                      "V.Hora_salida AS HoraSalidaVuelo, V.Hora_llegada AS HoraLlegadaVuelo, V.Destino AS DestinoVuelo " &
                                      "FROM Tiquete T " &
                                      "INNER JOIN Venta VE ON T.ID_venta = VE.ID_venta " &
                                      "INNER JOIN Pasajero PA ON T.ID_pasajero = PA.ID_pasajero " &
                                      "INNER JOIN Vuelos V ON T.ID_vuelo = V.ID_vuelo " &
                                      "INNER JOIN Avion A ON T.ID_avion = A.ID_avion " &
                                      "INNER JOIN Persona P ON PA.ID_persona = P.ID_persona " &
                                      "WHERE T.ID_tiquete = @ID_tiquete"


                    command.Parameters.AddWithValue("@ID_tiquete", idTicket)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(ticket)
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            Throw New Exception("Error al obtener el ticket desde la base de datos", ex)
        End Try

        Return ticket
    End Function

End Class
