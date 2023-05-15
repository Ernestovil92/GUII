Imports System.Data.SqlClient
Public Class FrmProductos
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
        cargarCombosProducto()
        cargarCombosProveedores()
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

End Class