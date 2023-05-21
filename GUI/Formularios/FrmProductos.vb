Imports System.Data.SqlClient
Public Class FrmProductos
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
        cargarCombosProducto()
        cargarCombosProveedores()
        filtarProveedor()
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
        Dim consulta As String = "select codigo_barra as Codigo,nombre_producto as Producto, Proveedor as Proveedores, Precio_unitario,stock,createDate as Fecha from Productos"
        Dim adapter As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgProductos.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub CargarRegistros()
        conexion.Open()
        If conexion.State = 1 Then
            Dim consulta As String = "INSERT INTO Productos(nombre_producto,codigo_barra,Proveedor,C_electronico,telefono, Precio_unitario,stock,createDate)VALUES('" & txtProducto.Text & "','" & txtCodigo.Text & "','" & txtProveedor.Text & "','" & txtCorreo.Text & "','" & txtTelefono.Text & "'," & txtP_unitario.Text & "," & txtStock.Text & ",getdate())"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se registro correctamente")
        Else

            MsgBox("Hubo un error al registrar")
        End If
        conexion.Close()
    End Sub


    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        CargarRegistros()
        txtProducto.Text = " "
        txtCodigo.Text = " "
        txtProveedor.Text = " "
        txtP_unitario.Text = " "
        txtTelefono.Text = " "
        txtStock.Text = " "
        txtCorreo.Text = " "
    End Sub

    Private Sub filtarArticulos()
        Dim query2 As String = "select codigo_barra as Codigo, nombre_producto as Producto, Proveedor as Proveedores,Precio_unitario,stock,createDate as Fecha from Productos WHERE nombre_producto = '" & cmbArticulos.Text & "'"
        Dim dt2 As DataTable = SelectResult(query2)
        Dim DV As New DataView(dt2)
        dgProductos.DataSource = DV
        txtCantidadRegistros.Text = SelectResult("select count(*) from Productos").Rows(0).Item(0).ToString
    End Sub

    Private Sub filtarProveedor()
        Dim query2 As String = "select codigo_barra as Codigo, nombre_producto as Producto, Proveedor as Proveedores, Precio_unitario,stock,createDate as Fecha from Productos WHERE Proveedor = '" & cmbProveedor.Text & "'"
        Dim dt2 As DataTable = SelectResult(query2)
        Dim DV As New DataView(dt2)
        dgProductos.DataSource = DV
        txtCantidadRegistros.Text = SelectResult("select count(*) from Productos").Rows(0).Item(0).ToString
    End Sub



    Private Sub cargarCombosProducto()
        cmbArticulos.Items.Clear()
        cmbArticulos.DataSource = Nothing
        cmbArticulos.DataSource = SelectResult("SELECT '' id,'' nombre_producto UNION SELECT id, nombre_producto from Productos")
        With (cmbArticulos)
            .DisplayMember = "nombre_producto"
            .ValueMember = "id"
        End With
    End Sub

    Private Sub cargarCombosProveedores()
        cmbProveedor.Items.Clear()
        cmbProveedor.DataSource = Nothing
        cmbProveedor.DataSource = SelectResult("SELECT '' id,'' Proveedor UNION SELECT id, Proveedor from Productos")
        With (cmbProveedor)
            .DisplayMember = "Proveedor"
            .ValueMember = "id"
        End With
    End Sub

    Private Sub btnEliminar2_Click_1(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        FrmEliminarProductos.ShowDialog()
    End Sub

    Private Sub btnModificar2_Click_1(sender As Object, e As EventArgs) Handles btnModificar2.Click
        FrmModificarProductos.ShowDialog()
    End Sub

    Private Sub FiltrarAr_Click(sender As Object, e As EventArgs) Handles FiltrarAr.Click
        filtarArticulos()
    End Sub

    Private Sub FiltrarPro_Click(sender As Object, e As EventArgs) Handles FiltrarPro.Click
        filtarProveedor()
    End Sub

    Private Sub btnMostrar_Click_1(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarNombreUsuario()
    End Sub


End Class