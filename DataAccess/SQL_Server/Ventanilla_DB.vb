Imports System.Data
Imports System.Data.SqlClient
Imports Common

Public Class Ventanilla_DB
    Inherits Conexion_DB

    Public Function GuardarVentanilla(NumeroVentanilla As Integer, Nombre_empleado As String, Cedula_Empleado As Integer, Hora_Apertura As String, Linea_aerea As String, Fecha As String)
        Using connection = GetConecction()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "insert into Ventanillas (NumeroVentanilla, Nombre_empleado, Cedula_Empleado, Hora_Apertura, Linea_aerea, Fecha) values 
                                                               (@NumeroVentanilla, @Nombre_empleado, @Cedula_Empleado, @Hora_Apertura,@Linea_aerea, @Fecha)"
                Command.Parameters.AddWithValue("@NumeroVentanilla", NumeroVentanilla)
                Command.Parameters.AddWithValue("@Nombre_empleado", Nombre_empleado)
                Command.Parameters.AddWithValue("@Cedula_Empleado", Cedula_Empleado)
                Command.Parameters.AddWithValue("@Hora_Apertura", Hora_Apertura)
                Command.Parameters.AddWithValue("@Fecha", Fecha)
                Command.Parameters.AddWithValue("@linea_aerea", Linea_aerea)

                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
            End Using
        End Using

    End Function
    Public Sub GuardarPasajero(Nombre As String, Num_identificacion As Integer, Apellido1 As String, Apellido2 As String, Destino As String, Precio_tiquete As Decimal, Hora_atencion As DateTime, Fecha_salida As DateTime, Nacionalidad As String)
        Dim personaGuardada As Boolean = False
        Dim tipoP As Boolean = True
        Try
            Using connection = GetConecction()
                connection.Open()
                ' Guardar datos de persona
                Using commandPersona = New SqlCommand()
                    commandPersona.Connection = connection
                    commandPersona.CommandText = "INSERT INTO Persona (Nombre, Num_identificacion, Tipo, Apellido1, Apellido2) VALUES 
                                   (@Nombre, @Num_identificacion, @Tipo, @Apellido1, @Apellido2)"
                    commandPersona.Parameters.AddWithValue("@Nombre", Nombre)
                    commandPersona.Parameters.AddWithValue("@Num_identificacion", Num_identificacion)
                    commandPersona.Parameters.AddWithValue("@Tipo", tipoP)
                    commandPersona.Parameters.AddWithValue("@Apellido1", Apellido1)
                    commandPersona.Parameters.AddWithValue("@Apellido2", Apellido2)

                    commandPersona.CommandType = CommandType.Text
                    commandPersona.ExecuteNonQuery()
                    personaGuardada = True
                End Using

                ' Guardar datos de pasajero
                If personaGuardada Then
                    Dim Ppresente As Boolean = True


                    Using commandPasajero = New SqlCommand()
                        commandPasajero.Connection = connection
                        commandPasajero.CommandText = "INSERT INTO Pasajero (Destino, Hora_atencion, Fecha_salida, Presente,  Nacionalidad, pasaporte) VALUES 
                               (@Destino, @Hora_atencion, @Fecha_salida, @Presente, @Nacionalidad, @Pasaporte)"
                        commandPasajero.Parameters.AddWithValue("@Destino", Destino)
                        commandPasajero.Parameters.AddWithValue("@Hora_atencion", Hora_atencion)
                        commandPasajero.Parameters.AddWithValue("@Fecha_salida", Fecha_salida)
                        commandPasajero.Parameters.AddWithValue("@Presente", Ppresente)

                        commandPasajero.Parameters.AddWithValue("@Nacionalidad", Nacionalidad)
                        commandPasajero.Parameters.AddWithValue("@Pasaporte", Num_identificacion)


                        commandPasajero.CommandType = CommandType.Text
                        commandPasajero.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            If personaGuardada Then
                Throw New Exception("Error al guardar los datos del pasajero en la base de datos", ex)
            Else
                Throw New Exception("Error al guardar los datos de la persona en la base de datos", ex)
            End If
        End Try
    End Sub


    Public Sub GuardarVenta(ID_pasajero As Integer, ID_avion As Integer, Hora_venta As DateTime, Monto_total As Decimal, Num_identificacion As Integer, ID_vuelo As Integer)
        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO Venta (ID_pasajero, ID_avion, Hora_venta, Monto_total) 
                       VALUES ((SELECT ID_pasajero FROM Pasajero WHERE pasaporte = @Num_identificacion), 
                               (SELECT ID_avion FROM Vuelos WHERE ID_vuelo = @ID_vuelo),
                               @Hora_venta, @Monto_total)"

                    command.Parameters.AddWithValue("@ID_pasajero", ID_pasajero)
                    command.Parameters.AddWithValue("@ID_avion", ID_avion)
                    command.Parameters.AddWithValue("@Hora_venta", Hora_venta)
                    command.Parameters.AddWithValue("@Monto_total", Monto_total)


                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            Throw New Exception("Error al guardar la venta en la base de datos", ex)
        End Try
    End Sub


End Class
