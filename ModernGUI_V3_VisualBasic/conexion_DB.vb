Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient


Public Class Conexion_DB
    Private Connect As New SqlConnection("Data Source=ING-JOSTIN\SQLEXPRESS;Initial Catalog=Vuelos;Integrated Security=true")

    'Funcion para abrir la conexion a la db

    Public Function Conectar() As SqlConnection
        Try
            Connect.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Connect



    End Function

    Public Function Desconectar() As SqlConnection
        Try
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Connect



    End Function
End Class