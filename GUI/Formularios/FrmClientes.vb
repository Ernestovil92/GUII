Imports System.Data.SqlClient

Public Class FrmClientes
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
        MostrarNombreUsuario()
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
    Private Sub MostrarNombreUsuario()
        conexion.Open()
        Dim consulta As String = "Select Cliente,Ruc,Correo_Electronico as Correo,Telefono,CreateDate as Fecha_Insercion from Clientes"
        Dim adapter As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgClientes.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub btnActualizarCliente_Click(sender As Object, e As EventArgs) Handles btnActualizarCliente.Click
        MostrarNombreUsuario()
    End Sub


    Private Sub CargarRegistros()
        conexion.Open()
        If conexion.State = 1 Then

            Dim consulta As String = "INSERT INTO Clientes(Codigo_cliente,Cliente,Ruc,Correo_Electronico,Telefono)VALUES('" & txtId.Text & "','" & txtClienteNuevo.Text & "','" & txtRuc.Text & "','" & txtCorreo.Text & "','" & txtTelefono.Text & "')"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se registro correctamente")
        Else

            MsgBox("Hubo un error al registrar")
        End If
        conexion.Close()
    End Sub

    Private Sub BtnGuardarCliente_Click(sender As Object, e As EventArgs) Handles BtnGuardarCliente.Click
        CargarRegistros()
    End Sub


End Class

