Imports System.Data
Imports System.Data.SqlClient
Imports Common

Public Class UserDao
    Inherits Conexion_DB

    Public Function agregarUser(pass As String, nombre As String, apellido1 As String, apellido2 As String, email As String, tipo As Integer, identificacion As String, linea_aerea As String)

        Using connection = GetConecction()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "INSERT INTO persona (nombre, apellido1, apellido2, Num_identificacion, tipo) VALUES (@nombre, @apellido1, @apellido2, @identificacion, @tipo); " &
                                  "DECLARE @ID_persona INT; " &
                                  "SET @ID_persona = SCOPE_IDENTITY(); " &
                                  "INSERT INTO empleado (contraseña, email, tipo, identificacion, ID_persona,linea_aerea) VALUES (@pass, @email, @tipo, @identificacion, @ID_persona,@linea_aerea);"

                Command.Parameters.AddWithValue("@pass", pass)
                Command.Parameters.AddWithValue("@nombre", nombre)
                Command.Parameters.AddWithValue("@apellido1", apellido1)
                Command.Parameters.AddWithValue("@apellido2", apellido2)
                Command.Parameters.AddWithValue("@email", email)
                Command.Parameters.AddWithValue("@tipo", tipo)
                Command.Parameters.AddWithValue("@identificacion", identificacion)
                Command.Parameters.AddWithValue("@linea_aerea", linea_aerea)

                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
            End Using
        End Using


    End Function


    Public Sub editarPerfil(pass As String, nombre As String, apellido1 As String, apellido2 As String, email As String, tipo As Integer, identificacion As String, linea_aerea As String)
        Using connection = GetConecction()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "UPDATE p " &
                        "SET " &
                        "    p.nombre = @nombre, " &
                        "    p.apellido1 = @apellido1, " &
                        "    p.apellido2 = @apellido2 " &
                        "FROM persona AS p " &
                        "INNER JOIN empleado AS e ON p.ID_persona = e.ID_persona " &
                        "WHERE " &
                        "    e.identificacion = @identificacion; " &
                        " " &
                        "UPDATE empleado " &
                        "SET " &
                        "    contraseña = @pass, " &
                        "    email = @email, " &
                        "    linea_aerea = @linea_aerea, " &
                        "    tipo = @tipo " &
                        "WHERE " &
                        "    identificacion = @identificacion;"

                Command.Parameters.AddWithValue("@pass", pass)
                Command.Parameters.AddWithValue("@nombre", nombre)
                Command.Parameters.AddWithValue("@apellido1", apellido1)
                Command.Parameters.AddWithValue("@apellido2", apellido2)
                Command.Parameters.AddWithValue("@email", email)
                Command.Parameters.AddWithValue("@tipo", tipo)
                Command.Parameters.AddWithValue("@identificacion", identificacion)
                Command.Parameters.AddWithValue("@linea_aerea", linea_aerea)

                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Public Function Login(user As String, pass As String) As Boolean
        Using connection = GetConecction()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "SELECT p.ID_persona, p.nombre, p.apellido1, p.apellido2, e.identificacion, e.email, e.tipo, e.contraseña, e.linea_aerea " &
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
                        ActiveUser.tipo = reader.GetInt32(reader.GetOrdinal("tipo"))
                        ActiveUser.lineaaerea = reader.GetString(reader.GetOrdinal("Linea_aerea"))
                        ActiveUser.pass = reader.GetString(reader.GetOrdinal("contraseña"))
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