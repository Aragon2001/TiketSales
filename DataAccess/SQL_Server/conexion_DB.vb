Imports System.Data.SqlClient ' Importa el espacio de nombres necesario para trabajar con SQL Server

Public MustInherit Class Conexion_DB ' Define una clase abstracta llamada Conexion_DB
    Private Connect As String ' Declara una variable privada para almacenar la cadena de conexión

    Protected Sub New() ' Constructor de la clase
        Connect = ("Data Source=DESKTOP-T8C8ADQ\SQLEXPRESS;Initial Catalog=vuelos;Integrated Security=true") ' Asigna la cadena de conexión
    End Sub

    ' Función para abrir la conexión a la base de datos
    Protected Function GetConecction() As SqlConnection
        Return New SqlConnection(Connect) ' Retorna una nueva instancia de SqlConnection con la cadena de conexión
    End Function
End Class


'la cadena de conexion es privada, el constructor es protegido, y el metodo tambien protegido ya que deseo que se acceda unicamente de la clase deriavada dominio  