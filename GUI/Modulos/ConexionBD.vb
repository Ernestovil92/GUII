Imports System.Data.SqlClient

Module ConexionBD
    Dim conexion As New SqlConnection()
    Dim cmd As New SqlCommand()
    Public Function conexionSQL() As SqlConnection
        Dim conexion As New SqlConnection("Data Source=DESKTOP-54PHT7T\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Try
            conexion.Open()
            Console.WriteLine("Conexión exitosa.")
        Catch ex As Exception
            Console.WriteLine("Error de conexión: " & ex.Message)
        End Try
        Return conexion
    End Function


End Module