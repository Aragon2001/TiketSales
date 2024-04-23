Imports System.Data.SqlClient
Imports DataAccess

Public Class NuevoVueloDataAccess
    Inherits Conexion_DB ' Suponiendo que Conexion_DB es una clase que maneja la conexión a la base de datos

    Public Sub InsertarNuevoVuelo(idAvion As Integer, idAerolinea As Integer, destino As String, horaSalida As DateTime, horaLlegada As DateTime, precio As Decimal)
        Using connection = GetConecction()
            connection.Open()

            Dim query As String = "INSERT INTO Vuelos (ID_avion, ID_aerolinea, Destino, Hora_salida, Hora_llegada, precio) VALUES (@IdAvion, @IdAerolinea, @Destino, @HoraSalida, @HoraLlegada, @Precio)"

            Using command As New SqlCommand(query, connection)
                ' Parametros de la consulta SQL
                command.Parameters.AddWithValue("@IdAvion", idAvion)
                command.Parameters.AddWithValue("@IdAerolinea", idAerolinea)
                command.Parameters.AddWithValue("@Destino", destino)
                command.Parameters.AddWithValue("@HoraSalida", horaSalida)
                command.Parameters.AddWithValue("@HoraLlegada", horaLlegada)
                command.Parameters.AddWithValue("@Precio", precio)

                ' Ejecutar la consulta SQL
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class