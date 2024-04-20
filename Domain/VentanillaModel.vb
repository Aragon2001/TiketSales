Imports DataAccess

Public Class VentanillaModel

    Private Ventanilla_DB As New Ventanilla_DB

    Private fecha
    Private Linea_aerea
    Private Hora_Apertura
    Private Cedula_Empleado
    Private Nombre_empleado
    Private NumeroVentanilla
    Private nombrePasajero
    Private nacionalidad
    Private passport
    Private destino


    Public Sub New()
    End Sub

    Public Sub New(fecha As Object, linea_aerea As Object, hora_Apertura As Object, cedula_Empleado As Object, nombre_empleado As Object, numeroVentanilla As Object, nombrePasajero As Object, nacionalidad As Object, passport As Object, destino As Object)
        Me.fecha1 = fecha
        Me.linea_aerea1 = linea_aerea
        Me.Hora_Apertura1 = hora_Apertura
        Me.Cedula_Empleado1 = cedula_Empleado
        Me.Nombre_empleado1 = nombre_empleado
        Me.NumeroVentanilla1 = numeroVentanilla
        Me.nombrePasajero1 = nombrePasajero
        Me.nacionalidad1 = nacionalidad
        Me.passport1 = passport
        Me.destino1 = destino
    End Sub
    Public Property nombrePasajero1 As String
        Get
            Return nombrePasajero
        End Get
        Set(value As String)
            nombrePasajero = value
        End Set
    End Property
    Public Property nacionalidad1 As String
        Get
            Return nacionalidad
        End Get
        Set(value As String)
            nacionalidad = value
        End Set
    End Property
    Public Property passport1 As String
        Get
            Return passport
        End Get
        Set(value As String)
            passport = value
        End Set
    End Property
    Public Property destino1 As String
        Get
            Return destino
        End Get
        Set(value As String)
            destino = value
        End Set
    End Property
    Public Property linea_aerea1 As String
        Get
            Return Linea_aerea
        End Get
        Set(value As String)
            Linea_aerea = value
        End Set
    End Property
    Public Property fecha1 As String
        Get
            Return fecha
        End Get
        Set(value As String)
            fecha = value
        End Set
    End Property
    Public Property Hora_Apertura1 As String
        Get
            Return Hora_Apertura
        End Get
        Set(value As String)
            Hora_Apertura = value
        End Set
    End Property
    Public Property Cedula_Empleado1 As String
        Get
            Return Cedula_Empleado
        End Get
        Set(value As String)
            Cedula_Empleado = value
        End Set
    End Property
    Public Property NumeroVentanilla1 As String
        Get
            Return NumeroVentanilla
        End Get
        Set(value As String)
            NumeroVentanilla = value
        End Set
    End Property
    Public Property Nombre_empleado1 As String
        Get
            Return Nombre_empleado
        End Get
        Set(value As String)
            Nombre_empleado = value
        End Set
    End Property






    Public Function ConfirmarVentanilla(NumeroVentanilla As Integer, Nombre_empleado As String, Cedula_Empleado As Integer, Hora_Apertura As String, Linea_aerea As String, Fecha As String) As String
            Try
            ' Confirma la ventanilla
            Ventanilla_DB.GuardarVentanilla(NumeroVentanilla, Nombre_empleado, Cedula_Empleado, Hora_Apertura, Linea_aerea, Fecha)
            Return "Ventanilla Abierta"
            Catch ex As Exception
                Return "Error al abrir: " & ex.Message
            End Try
        End Function

    Public Function GuardarVenta(ID_pasajero As Integer, ID_avion As Integer, Hora_venta As DateTime, Monto_total As Decimal, Num_identificacion As Integer, ID_vuelo As Integer) As String
        Try
            Ventanilla_DB.GuardarVenta(ID_pasajero, ID_avion, Hora_venta, Monto_total, Num_identificacion, ID_vuelo)
            Return ""
        Catch ex As Exception
            Return "Error al guardar la venta: " & ex.Message
        End Try
    End Function

    Public Function GuardarPasajero(Nombre As String, Num_identificacion As Integer, Apellido1 As String, Apellido2 As String, Destino As String, Precio_tiquete As Decimal, Hora_atencion As DateTime, Fecha_salida As DateTime, Nacionalidad As String) As String
            Try
            Ventanilla_DB.GuardarPasajero(Nombre, Num_identificacion, Apellido1, Apellido2, Destino, Precio_tiquete, Hora_atencion, Fecha_salida, Nacionalidad)
            Return ""
            Catch ex As Exception
                Return "Error al guardar el pasajero: " & ex.Message
            End Try
        End Function




    End Class


