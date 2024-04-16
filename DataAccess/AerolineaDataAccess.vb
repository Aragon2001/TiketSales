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
End Class

