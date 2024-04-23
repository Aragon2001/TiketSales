Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess

Public Class NuevoAvionDataAccess
    Inherits Conexion_DB ' Suponiendo que Conexion_DB es una clase que maneja la conexion a la base de datos

    Public Sub InsertarNuevoAvion(marcaAvion As String, idAerolinea As Integer, capacidad As Integer, nombrePiloto As String, ciudadOrigen As String, ciudadDestino As String, horaSalida As DateTime, horaLlegada As DateTime, tieneEscala As Boolean, ciudadesEscala As String)
        Using connection = GetConecction()
            connection.Open()

            Dim query As String = "INSERT INTO Avion (Marca_avion, ID_aerolinea, Capacidad, Nombre_piloto, Ciudad_origen, Ciudad_destino, Hora_salida, Hora_llegada, Escala, Ciudades_escala) VALUES (@MarcaAvion, @IDAerolinea, @Capacidad, @NombrePiloto, @CiudadOrigen, @CiudadDestino, @HoraSalida, @HoraLlegada, @TieneEscala, @CiudadesEscala)"

            Using command As New SqlCommand(query, connection)
                ' Parametros de la consulta SQL
                command.Parameters.AddWithValue("@MarcaAvion", marcaAvion)
                command.Parameters.AddWithValue("@IDAerolinea", idAerolinea)
                command.Parameters.AddWithValue("@Capacidad", capacidad)
                command.Parameters.AddWithValue("@NombrePiloto", nombrePiloto)
                command.Parameters.AddWithValue("@CiudadOrigen", ciudadOrigen)
                command.Parameters.AddWithValue("@CiudadDestino", ciudadDestino)
                command.Parameters.AddWithValue("@HoraSalida", horaSalida)
                command.Parameters.AddWithValue("@HoraLlegada", horaLlegada)
                command.Parameters.AddWithValue("@TieneEscala", tieneEscala)
                command.Parameters.AddWithValue("@CiudadesEscala", ciudadesEscala)

                ' Ejecutar la consulta SQL
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class