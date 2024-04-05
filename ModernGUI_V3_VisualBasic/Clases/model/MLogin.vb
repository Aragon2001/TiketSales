Public Class MLogin
    Public Function ValidarCredenciales(nombreUsuario As String, contraseña As String) As Boolean
        ' Aquí puedes implementar la lógica para validar las credenciales con una base de datos o algún otro método
        ' En este ejemplo, simplemente se comparan las credenciales con valores fijos
        Return nombreUsuario = "usuario" AndAlso contraseña = "contraseña"
    End Function
End Class