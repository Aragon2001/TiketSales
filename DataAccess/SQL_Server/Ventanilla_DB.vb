Imports System.Data
Imports System.Data.SqlClient
Imports Common
Imports System.Windows.Forms



Public Class Ventanilla_DB
    Inherits Conexion_DB

    Public Sub GuardarVentanilla()
        Try
            Using connection = GetConecction()
                connection.Open()
                Using Command = New SqlCommand("INSERT INTO Ventanilla (ID_Ventanilla, Nombre_empleado, Numero_cedula, Hora_apertura, Linea_aerea) VALUES 
                                                   (@ID_Ventanilla, @Nombre_empleado, @Numero_cedula, @Hora_apertura, @Linea_aerea)", connection)
                    Command.Parameters.AddWithValue("@ID_Ventanilla", VentanillaAbierta.NumeroVentanilla)
                    Command.Parameters.AddWithValue("@Nombre_empleado", VentanillaAbierta.Nombre_empleado)
                    Command.Parameters.AddWithValue("@Numero_cedula", VentanillaAbierta.Cedula_Empleado)
                    Command.Parameters.AddWithValue("@Hora_Apertura", VentanillaAbierta.fecha)
                    Command.Parameters.AddWithValue("@Linea_aerea", VentanillaAbierta.Linea_aerea)
                    Command.CommandType = CommandType.Text
                    Command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al guardar la ventanilla en la base de datos: " & ex.Message, ex)
        End Try
    End Sub



    Public Sub GuardarPasajero()
        Dim personaGuardada As Boolean = False
        Try
            Using connection = GetConecction()
                connection.Open()

                ' Guardar datos de persona
                Using commandPersona = New SqlCommand()
                    commandPersona.Connection = connection
                    commandPersona.CommandText = "INSERT INTO Persona (Nombre, Num_identificacion, Tipo, Apellido1, Apellido2) VALUES 
                              (@Nombre, @Num_identificacion, @Tipo, @Apellido1, @Apellido2)"
                    commandPersona.Parameters.AddWithValue("@Nombre", VentanillaAbierta.nombrePasajero)
                    commandPersona.Parameters.AddWithValue("@Num_identificacion", VentanillaAbierta.passport)
                    commandPersona.Parameters.AddWithValue("@Tipo", 1) ' False para indicar tipo de persona pasajero
                    commandPersona.Parameters.AddWithValue("@Apellido1", VentanillaAbierta.Apellido1)
                    commandPersona.Parameters.AddWithValue("@Apellido2", VentanillaAbierta.Apellido2)

                    commandPersona.CommandType = CommandType.Text
                    commandPersona.ExecuteNonQuery()
                    personaGuardada = True
                End Using

                ' Guardar datos de pasajero
                If personaGuardada Then
                    Dim presente As Boolean = True

                    Using commandPasajero = New SqlCommand()
                        commandPasajero.Connection = connection
                        commandPasajero.CommandText = "INSERT INTO Pasajero (Destino, Hora_atencion, Fecha_salida, Presente, Nacionalidad, pasaporte, ID_persona) VALUES 
                              (@Destino, @Hora_atencion, @Fecha_salida, @Presente, @Nacionalidad, @Pasaporte, @ID_persona)"
                        commandPasajero.Parameters.AddWithValue("@Destino", VentanillaAbierta.destino)
                        commandPasajero.Parameters.AddWithValue("@Hora_atencion", VentanillaAbierta.fecha)
                        commandPasajero.Parameters.AddWithValue("@Fecha_salida", VentanillaAbierta.FechaSalida)
                        commandPasajero.Parameters.AddWithValue("@Presente", 1)
                        commandPasajero.Parameters.AddWithValue("@Nacionalidad", VentanillaAbierta.nacionalidadPasajero)
                        commandPasajero.Parameters.AddWithValue("@Pasaporte", VentanillaAbierta.passport)
                        commandPasajero.Parameters.AddWithValue("@ID_Persona", ObtenerIdPersona())

                        commandPasajero.CommandType = CommandType.Text
                        commandPasajero.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            If personaGuardada Then
                Throw New Exception("Error al guardar los datos del pasajero en la base de datos: " & ex.Message, ex)
            Else
                Throw New Exception("Error al guardar los datos de la persona en la base de datos: " & ex.Message, ex)
            End If
        End Try
    End Sub



    Public Sub GuardarVenta()
        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO Venta (ID_pasajero, ID_avion, Hora_venta, Monto_total, ID_ventanilla) 
                   VALUES ((SELECT ID_pasajero FROM Pasajero WHERE pasaporte = @Num_identificacion), 
                           @ID_avion, @Hora_venta, @Monto_total, @ID_ventanilla)"

                    command.Parameters.AddWithValue("@Num_identificacion", VentanillaAbierta.passport)
                    command.Parameters.AddWithValue("@ID_ventanilla", VentanillaAbierta.NumeroVentanilla)
                    command.Parameters.AddWithValue("@ID_avion", VentanillaAbierta.idAvion)
                    command.Parameters.AddWithValue("@Hora_venta", DateTime.Now)
                    command.Parameters.AddWithValue("@Monto_total", VentanillaAbierta.PrecioTiquete)

                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            Throw New Exception("Error al guardar la venta en la base de datos: " & ex.Message, ex)
        End Try
    End Sub




    Public Function ObtenerDestinos() As List(Of String)
        Dim destinos As New List(Of String)()

        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT DISTINCT Destino FROM Vuelos"

                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada destino a la lista
                            destinos.Add(reader("Destino").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            Throw New Exception("Error al obtener los destinos desde la base de datos", ex)
        End Try

        Return destinos
    End Function

    Public Sub ObtenerDetallesVuelosPorDestino(destino As String)
        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT V.Hora_salida, V.Hora_llegada, V.precio, V.ID_vuelo, A.Escala, A.Ciudades_escala, A.Ciudad_origen , A.ID_avion " &
                            "FROM Vuelos V " &
                            "INNER JOIN Avion A ON V.ID_avion = A.ID_avion " &
                            "WHERE V.Destino = @Destino"

                    command.Parameters.AddWithValue("@Destino", destino)

                    Using reader = command.ExecuteReader()
                        If reader.Read() Then

                            VentanillaAbierta.HoraSalida = Convert.ToDateTime(reader("Hora_salida"))
                            VentanillaAbierta.HoraLlegada = Convert.ToDateTime(reader("Hora_llegada"))
                            VentanillaAbierta.PrecioTiquete = Convert.ToDecimal(reader("precio"))
                            VentanillaAbierta.Escala = Convert.ToBoolean(reader("Escala"))
                            VentanillaAbierta.LugarEscala = reader("Ciudades_escala").ToString()
                            VentanillaAbierta.CiudadOrigen = reader("Ciudad_origen").ToString()
                            VentanillaAbierta.idVuelo = Convert.ToInt32(reader("ID_vuelo"))
                            VentanillaAbierta.idAvion = Convert.ToInt32(reader("ID_avion"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            Throw New Exception("Error al obtener los detalles de los vuelos por destino desde la base de datos", ex)
        End Try
    End Sub

    Public Function ObtenerAsientosDisponiblesPorDestino(destino As String) As List(Of String)
        Dim asientosDisponibles As New List(Of String)()

        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT A.Num_asiento " &
                                          "FROM Asiento A " &
                                          "INNER JOIN Avion AV ON A.ID_avion = AV.ID_avion " &
                                          "INNER JOIN Vuelos V ON AV.ID_avion = V.ID_avion " &
                                          "WHERE V.Destino = @Destino AND A.Estado = 0"

                    command.Parameters.AddWithValue("@Destino", destino)

                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            ' Agregar el número de asiento a la lista de asientos disponibles
                            asientosDisponibles.Add(reader("Num_asiento").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Manejar la excepción según sea necesario
            Throw New Exception("Error al obtener los asientos disponibles por destino desde la base de datos", ex)
        End Try

        Return asientosDisponibles
    End Function

    Public Sub GuardarTiquete()
        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO Tiquete (ID_venta, ID_pasajero, ID_vuelo, ID_avion, ID_ventanilla, Hora_venta, Monto_total) VALUES 
                                                               (@ID_venta, @ID_pasajero, @ID_vuelo, @ID_avion, @ID_ventanilla, @Hora_venta, @Monto_total)"

                    ' Asignar los parámetros
                    command.Parameters.AddWithValue("@ID_venta", ObtenerIdVenta())
                    command.Parameters.AddWithValue("@ID_pasajero", ObtenerIdPasajero())
                    command.Parameters.AddWithValue("@ID_vuelo", VentanillaAbierta.idVuelo)
                    command.Parameters.AddWithValue("@ID_avion", VentanillaAbierta.idAvion)
                    command.Parameters.AddWithValue("@ID_ventanilla", VentanillaAbierta.NumeroVentanilla)
                    command.Parameters.AddWithValue("@Hora_venta", VentanillaAbierta.fecha)
                    command.Parameters.AddWithValue("@Monto_total", VentanillaAbierta.PrecioTiquete)

                    ' Ejecutar el comando
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir al guardar el tiquete en la base de datos
            Throw New Exception("Error al guardar el tiquete en la base de datos: " & ex.Message)
        End Try
    End Sub


    Private Function ObtenerIdpasajero() As Integer
        Dim Idpasajero As Integer = 0

        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT MAX(ID_pasajero) FROM pasajero"

                    ' Obtener el ID de venta máximo
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Idpasajero = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir al obtener el ID de venta desde la base de datos
            Throw New Exception("Error al obtener el ID de pasajero desde la base de datos: ", ex)
        End Try

        Return Idpasajero
    End Function

    Private Function ObtenerIdVenta() As Integer
        Dim idVenta As Integer = 0

        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT MAX(ID_venta) FROM Venta"

                    ' Obtener el ID de venta máximo
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        idVenta = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir al obtener el ID de venta desde la base de datos
            Throw New Exception("Error al obtener el ID de venta desde la base de datos: ", ex)
        End Try

        Return idVenta
    End Function
    Private Function ObtenerIdPersona() As Integer
        Dim IdPersona As Integer = 0

        Try
            Using connection = GetConecction()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT MAX(ID_persona) FROM Persona"

                    ' Obtener el ID de venta máximo
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        IdPersona = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir al obtener el ID de venta desde la base de datos
            Throw New Exception("Error al obtener el ID de persona desde la base de datos: ", ex)
        End Try

        Return IdPersona
    End Function





End Class
