Imports System.Data.SqlClient

Public Class FrmClientes
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
        MostrarNombreUsuario()
    End Sub

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

            Dim consulta As String = "INSERT INTO Clientes(Cliente,Ruc,Correo_Electronico,Telefono)VALUES('" & txtClienteNuevo.Text & "','" & txtRuc.Text & "','" & txtCorreo.Text & "','" & txtTelefono.Text & "')"
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

