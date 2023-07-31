Imports System.Data.SqlClient

Public Class FrmModificarPedido
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()


    Private Sub FrmModificarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    ''-------------

    Private Sub ModificarPedido()
        conexion.Open()
        If conexion.State = 1 Then
            Dim consulta As String = "UPDATE pedidos SET Producto = '" & txtProducto.Text & "', precio = '" & txtPrecio.Text & "', correo = '" & txtCE.Text & "', telefono = '" & txtTelefono.Text & "', fecha = getdate()"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se ha actualizado el registro Nro.: " + txtId.Text)
        Else
            MsgBox("Error no se pudo actualizar")
        End If

        conexion.Close()
        limpiar()
    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtProducto.Text = ""
        txtCE.Text = ""
        txtPrecio.Text = ""
        txtTelefono.Text = ""

    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub

    Private Sub MostrarProductos()
        txtProducto.Text = SelectResult("select producto from Pedidos WHERE id = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtPrecio.Text = SelectResult("select precio from Pedidos WHERE id = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtCE.Text = SelectResult("select correo from Pedidos WHERE id = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtTelefono.Text = SelectResult("select telefono from Pedidos WHERE id = '" & txtId.Text & "'").Rows(0).Item(0).ToString
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarProductos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ModificarPedido()
        limpiar()
    End Sub


End Class