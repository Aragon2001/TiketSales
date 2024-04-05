Public Class CLogin
    Private _modelo As MLogin
    Private _vista As Login

    Public Sub New(modelo As MLogin, vista As Login)
        _modelo = modelo
        _vista = vista
    End Sub

    Public Sub IniciarSesion(nombreUsuario As String, contraseña As String)
        If _modelo.ValidarCredenciales(nombreUsuario, contraseña) Then
            _vista.MostrarMensaje("Inicio de sesión exitoso")
        Else
            _vista.MostrarMensaje("Credenciales inválidas")
        End If
    End Sub
End Class
