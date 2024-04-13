Imports System.Data
Imports System.Data.SqlClient
Imports Common

Public Class UserDao
    Inherits Conexion_DB

    Public Function login(user As String, pass As String) As Boolean
        Using connection = GetConecction()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "SELECT p.ID_persona, p.nombre, p.apellido1, p.apellido2, e.identificacion, e.email, e.tipo " &
                      "FROM persona AS p " &
                      "INNER JOIN empleado AS e ON p.ID_persona = e.ID_persona " &
                      "WHERE p.tipo = 0 AND e.identificacion = @identificacion AND e.contraseña = @contraseña;"
                'tipo 0 = empleado, tipo= 1 persona

                Command.Parameters.AddWithValue("@identificacion", user)
                Command.Parameters.AddWithValue("@contraseña", pass)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.idUser = reader.GetInt32(reader.GetOrdinal("ID_persona"))
                        ActiveUser.nombre = reader.GetString(reader.GetOrdinal("nombre"))
                        ActiveUser.apellido1 = reader.GetString(reader.GetOrdinal("apellido1"))
                        ActiveUser.apellido2 = reader.GetString(reader.GetOrdinal("apellido2"))
                        ActiveUser.identificacion = reader.GetInt32(reader.GetOrdinal("identificacion"))
                        ActiveUser.email = reader.GetString(reader.GetOrdinal("email"))
                        ActiveUser.tipo = reader.GetBoolean(reader.GetOrdinal("tipo"))
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

End Class
