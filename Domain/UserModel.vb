Imports DataAccess

Public Class UserModel
    Private userDao As New UserDao()

    ' Atributos
    Private idUser
    Private identificacion
    Private contraseña
    Private nombre
    Private apellido1
    Private apellido2
    Private tipo
    Private email
    Private linea_aerea

    Public Sub New()
    End Sub

    Public Sub New(idUser As Integer, identificacion As Integer, contraseña As String, apellido1 As String, nombre As String, apellido2 As String, tipo As Integer, email As String, linea_aerea As String)
        Me.IdUser1 = idUser
        Me.Identificacion1 = identificacion
        Me.Contraseña1 = contraseña
        Me.Apellido11 = apellido1
        Me.Nombre1 = nombre
        Me.Apellido21 = apellido2
        Me.Tipo1 = tipo
        Me.Email1 = email
        Me.linea_aerea1 = linea_aerea
    End Sub

    Public Property linea_aerea1 As String
        Get
            Return linea_aerea
        End Get
        Set(value As String)
            linea_aerea = value
        End Set
    End Property

    Public Property IdUser1 As Integer
        Get
            Return idUser
        End Get
        Set(value As Integer)
            idUser = value
        End Set
    End Property

    Public Property Identificacion1 As Integer
        Get
            Return identificacion
        End Get
        Set(value As Integer)
            identificacion = value
        End Set
    End Property

    Public Property Contraseña1 As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property

    Public Property Apellido11 As String
        Get
            Return apellido1
        End Get
        Set(value As String)
            apellido1 = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido21 As String
        Get
            Return apellido2
        End Get
        Set(value As String)
            apellido2 = value
        End Set
    End Property

    Public Property Tipo1 As Integer
        Get
            Return tipo
        End Get
        Set(value As Integer)
            tipo = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Function editarPerfilUser(identificacion As String, pass As String, nombre As String, apellido1 As String, apellido2 As String, email As String, tipo As Integer, linea_aerea As String) As String
        Try
            ' Llama al método editarPerfil de UserDao para actualizar el perfil del usuario
            userDao.editarPerfil(pass, nombre, apellido1, apellido2, email, tipo, identificacion, linea_aerea)

            ' Vuelve a iniciar sesión para reflejar los cambios en el objeto ActiveUser
            Login(identificacion, pass)

            Return "Su perfil de usuario fue actualizado"
        Catch ex As Exception
            Return "Error al actualizar el perfil del usuario: " & ex.Message
        End Try
    End Function

    Public Function agregarUser(identificacion As String, pass As String, nombre As String, apellido1 As String, apellido2 As String, email As String, tipo As Integer, linea_aerea As String) As String
        Try
            ' Llama al método editarPerfil de UserDao para actualizar el perfil del usuario
            userDao.agregarUser(pass, nombre, apellido1, apellido2, email, tipo, identificacion, linea_aerea)


            Return "El Usuario fue Agregado exitosamente"
        Catch ex As Exception
            Return "Error al agregar el perfil del usuario: " & ex.Message
        End Try

    End Function


    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.login(user, pass)
    End Function
End Class
