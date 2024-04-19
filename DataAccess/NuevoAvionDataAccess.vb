Imports System.Data
Imports System.Data.SqlClient

Public Class NuevoAvionDataAccess
    Inherits Conexion_DB ' Suponiendo que Conexion_DB es una clase que maneja la conexion a la base de datos

    Public Sub InsertarNuevoAvion(marcaAvion As String, idAerolinea As Integer, capacidad As Integer, nombrePiloto As String)
        Using connection = GetConecction()
            connection.Open()

            Dim query As String = "INSERT INTO Avion (Marca_avion, ID_aerolinea, Capacidad, Nombre_piloto) VALUES (@MarcaAvion, @IDAerolinea, @Capacidad, @NombrePiloto)"

            Using command As New SqlCommand(query, connection)
                ' Parametros de la consulta SQL
                command.Parameters.AddWithValue("@MarcaAvion", marcaAvion)
                command.Parameters.AddWithValue("@IDAerolinea", idAerolinea)
                command.Parameters.AddWithValue("@Capacidad", capacidad)
                command.Parameters.AddWithValue("@NombrePiloto", nombrePiloto)

                ' Ejecutar la consulta SQL
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class