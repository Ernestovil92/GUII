Imports System.Data.SqlClient
Public Class FrmProductos
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")

    End Sub

    Private Sub MostrarNombreUsuario()
        conexion.Open()
        Dim consulta As String = "select id as Nro_Registro, nombre_producto as Producto,codigo_barra as Codigo, Proveedor as Proveedores,C_electronico as Correo_electronico,telefono, Precio_unitario,stock from Productos"
        Dim adapter As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgProductos.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub CargarRegistros()
        conexion.Open()
        If conexion.State = 1 Then
            Dim consulta As String = "INSERT INTO Productos(nombre_producto,codigo_barra,Proveedor,C_electronico,telefono, Precio_unitario,stock)VALUES('" & txtProducto.Text & "','" & txtCodigo.Text & "','" & txtProveedor.Text & "','" & txtCorreo.Text & "','" & txtTelefono.Text & "'," & txtP_unitario.Text & "," & txtStock.Text & ")"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se registro correctamente")
        Else

            MsgBox("Hubo un error al registrar")
        End If
        conexion.Close()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarNombreUsuario()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgProductos.DataSource = " "
    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        CargarRegistros()
        txtProducto.Text = " "
        txtCodigo.Text = " "
        txtProveedor.Text = " "
    End Sub

    Private Sub btnModificar2_Click(sender As Object, e As EventArgs) Handles btnModificar2.Click
        FrmModificarProductos.ShowDialog()
    End Sub

    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        FrmEliminarProductos.ShowDialog()
    End Sub

    Private Sub btnBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress

        Dim ad = New SqlDataAdapter("SELECT * FROM Productos where nombre_producto like '" + txtBuscar.Text + "%'", conexion)
        Dim dt = New DataTable
        ad.Fill(dt)
        Me.dgProductos.DataSource = dt
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class