Imports System.Data.SqlClient

Public Class FrmPendientes
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")

    End Sub

    Public Function SelectResult(ByVal cadConsul As String) As DataTable
        Dim dtTabla As New DataTable
        Try
            conexion.Open()
            comando = New SqlClient.SqlCommand(cadConsul, conexion)
            Dim da As New SqlDataAdapter(comando)
            comando.CommandTimeout = 0
            da.Fill(dtTabla)
            conexion.Close()
        Catch
            conexion.Close()
            ' //MessageBox.Show(ex.Message)
        End Try
        Return dtTabla
    End Function





End Class