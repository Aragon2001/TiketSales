Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class Aerolinea
    Public Property Nombre As String
    Public Property PaisOrigen As String
End Class
Public Class AerolineaDataAccess
    Inherits Conexion_DB ' Suponiendo que Conexion_DB es una clase que maneja la conexión a la base de datos
    ' Método para obtener las líneas aéreas desde la base de datos
    Public Function ObtenerLineasAereas() As List(Of Aerolinea)
        Dim lineasAereas As New List(Of Aerolinea)()

        ' Utilizar la conexión establecida en la clase base (Conexion_DB)
        Using connection = GetConecction()
            connection.Open()

            Dim query As String = "SELECT Nombre, Pais_origen FROM Aerolineas"

            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim aerolinea As New Aerolinea()
                        aerolinea.Nombre = reader("Nombre").ToString()
                        aerolinea.PaisOrigen = reader("Pais_origen").ToString()
                        lineasAereas.Add(aerolinea)
                    End While
                End Using
            End Using
        End Using

        Return lineasAereas
    End Function

    Public Sub InsertarNuevaAerolinea(nombreAerolinea As String, paisOrigen As String)
        Using connection = GetConecction()
            connection.Open()

            Dim query As String = "INSERT INTO Aerolineas (Nombre, Pais_origen) VALUES (@NombreAerolinea, @PaisOrigen)"

            Using command As New SqlCommand(query, connection)
                ' Parámetros de la consulta SQL
                command.Parameters.AddWithValue("@NombreAerolinea", nombreAerolinea)
                command.Parameters.AddWithValue("@PaisOrigen", paisOrigen)

                ' Ejecutar la consulta SQL
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class