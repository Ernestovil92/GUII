Imports System.Data.SqlClient

Public Class FrmModificarProductos
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub Modificar()
        conexion.Open()
        If conexion.State = 1 Then
            Dim consulta As String = "UPDATE Productos SET nombre_producto='" & txtProducto.Text & "',Proveedor='" & txtProveedores.Text & "',C_electronico='" & txtCE.Text & "',Precio_unitario='" & txtPU.Text & "',stock='" & txtStock.Text & "',telefono='" & txtTelefono.Text & "' where codigo_barra = '" & txtId.Text & "'"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se ha actualizado el registro Nro.: " + txtId.Text)
            limpiar()

        Else
            MsgBox("Error no se pudo actualizar")
        End If

        conexion.Close()
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

    Private Sub FrmModificarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Modificar()
        limpiar()
        Me.Hide()
    End Sub

    Private Sub MostrarProductos()
        txtProducto.Text = SelectResult("select nombre_producto from Productos WHERE codigo_barra = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtProveedores.Text = SelectResult("select Proveedor from Productos WHERE codigo_barra = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtCE.Text = SelectResult("select C_electronico from Productos WHERE codigo_barra = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtPU.Text = SelectResult("select Precio_unitario from Productos WHERE codigo_barra = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtStock.Text = SelectResult("select stock from Productos WHERE codigo_barra = '" & txtId.Text & "'").Rows(0).Item(0).ToString
        txtTelefono.Text = SelectResult("select telefono from Productos WHERE codigo_barra = '" & txtId.Text & "'").Rows(0).Item(0).ToString
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarProductos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Hide()
    End Sub

    Private Sub limpiar()
        txtId.Text = ""
        txtProducto.Text = ""
        txtCE.Text = ""
        txtProveedores.Text = ""
        txtPU.Text = ""
        txtStock.Text = ""
        txtTelefono.Text = ""
    End Sub

End Class