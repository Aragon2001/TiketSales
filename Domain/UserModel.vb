Imports DataAccess

Public Class UserModel
    Dim userDao As New UserDao()
    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.login(user, pass)
    End Function
End Class
