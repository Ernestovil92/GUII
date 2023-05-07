Imports System.Data.SqlClient
Public Class FrmProductos
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")

    End Sub

    Private Sub MostrarNombreUsuario()
        conexion.Open()
        Dim consulta As String = "select id as Nro_Registro, nombre_producto as Producto,codigo_barra as Codigo, U_cliente as Clientes from Productos"
        Dim adapter As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgProductos.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub CargarRegistros()
        conexion.Open()
        If conexion.State = 1 Then
            Dim consulta As String = "INSERT INTO Productos(nombre_producto,codigo_barra,U_cliente)VALUES('" & txtProducto.Text & "','" & txtCodigo.Text & "','" & txtCliente.Text & "')"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se registro correctamente")
        Else

            MsgBox("Hubo un error al registrar")
        End If
        conexion.Close()
    End Sub


    ''    Private Sub Modificar()
    ''      conexion.Open()
    ''Dim consulta As String = "UPDATE Productos SET nombre_producto='" & txtProducto.Text & "',codigo_barra='" & txtCodigo.Text & "',U_cliente='" & txtCliente.Text & "' where id = '" & txtId.Text & "'"
    '' Dim comando As New SqlCommand(consulta, conexion)
    '' Dim lector As SqlDataReader
    ''    lector = comando.ExecuteReader
    ''   conexion.Close()
    ''End Sub

    '' Private Sub Eliminar()
    ''   conexion.Open()
    '' Dim consulta As String = "DELETE acceso where id = '" & txtId.Text & "'"
    ''Dim comando As New SqlCommand(consulta, conexion)
    ''Dim lector As SqlDataReader
    ''   lector = comando.ExecuteReader
    ''  conexion.Close()
    ''End Sub


    ''Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    ''   Modificar()
    ''End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarNombreUsuario()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgProductos.DataSource = " "
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CargarRegistros()
        txtProducto.Text = " "
        txtCodigo.Text = " "
        txtCliente.Text = " "
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        FrmModificarProductos.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        FrmEliminarProductos.ShowDialog()
    End Sub
End Class