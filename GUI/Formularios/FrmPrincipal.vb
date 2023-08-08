
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Reflection.Module
Imports System

'Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar


Public Class FrmPrincipal

    Dim conexion As New SqlConnection()
    Dim cmd As New SqlCommand()
    Dim cc As New FrmLogin

    Public Function SelectResult(ByVal cadConsul As String) As DataTable

        Dim dtTabla As New DataTable
        Try
            conexion.Open()
            cmd = New SqlClient.SqlCommand(cadConsul, conexion)
            Dim da As New SqlDataAdapter(cmd)
            cmd.CommandTimeout = 0
            da.Fill(dtTabla)
            conexion.Close()
        Catch
            conexion.Close()
            ' //MessageBox.Show(ex.Message)
        End Try
        Return dtTabla
    End Function

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''  PAdmin.Hide()
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
        Timer1.Enabled = True
        prueba()
        cargarCombosProducto()
        cargarCombosProveedores()
        filtarProveedor()
        cargarCombosPedido()
        LLenar_grid()
        ComprobarFechas()

        '------------  EVITAR DATOS INCORRECTOS EN PEDIDOS ---------
        AddHandler txtPrecioP.KeyPress, AddressOf TextBox_KeyPress
        AddHandler txtteleP.KeyPress, AddressOf TextBox_KeyPress
        AddHandler txtidP.KeyPress, AddressOf TextBox_KeyPress
    End Sub



    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If menuContenedor.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf menuContenedor.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    '------------------------------ CAMBIAR COLOR DE PESTAñA   -----------------------
    Private Sub CambiarColorYSeleccionarPestaña(ByVal boton As Button, ByVal indice As Integer)
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray

        boton.BackColor = Color.Teal
        TabControl1.SelectedIndex = indice
    End Sub
    ''HOME
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        CambiarColorYSeleccionarPestaña(btnHome, 0)
    End Sub

    ''PRODUCTOS
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click, btnProductos.Click
        CambiarColorYSeleccionarPestaña(btnProductos, 1)
    End Sub

    ''CLIENTES
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click, btnClientes.Click
        CambiarColorYSeleccionarPestaña(btnClientes, 2)
    End Sub

    ''PEDIDOS
    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        CambiarColorYSeleccionarPestaña(btnPedidos, 3)
    End Sub

    ''PENDIENTES
    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        CambiarColorYSeleccionarPestaña(btnPendientes, 4)
    End Sub

    ''REPORTES
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        CambiarColorYSeleccionarPestaña(btnReportes, 5)
    End Sub

    ''AYUDA
    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        CambiarColorYSeleccionarPestaña(btnAyuda, 6)
    End Sub

    ''CERRAR SESION
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        CambiarColorYSeleccionarPestaña(btnCerrarSesion, 7)
        Close()
    End Sub


    Private Sub PanelContenedor_MouseHover(sender As Object, e As EventArgs) Handles PanelContenedor.MouseHover
        ''   PAdmin.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub


    Private Sub prueba()
        TabControl1.SelectedIndex = 2S
    End Sub

    ''-----------------------------------   Formulario de producto  -----------------------------------------
    Private Sub MostrarNombreUsuarioProducto()
        conexion.Open()
        Dim consulta As String = "select codigo_barra as Codigo,nombre_producto as Producto, Proveedor as Proveedores, Precio_unitario,stock,createDate as Fecha from Productos"
        Dim adapter As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgProductos.DataSource = dt
        conexion.Close()
    End Sub
    '----------------------------- LLENAR GRID DE PEDIDOS  --------------------------'
    Public Function LLenar_grid() As DataTable
        Try
            conexion.Open()
            Dim consulta As String = "SELECT id, Producto, precio, correo, telefono, fecha FROM Pedidos"
            Dim adapter As New SqlDataAdapter(consulta, conexion)
            Dim dt As New DataTable
            adapter.Fill(dt)
            datapedidos.DataSource = dt
            Return dt ' Devuelve el DataTable lleno con los datos
        Catch ex As Exception
            MessageBox.Show("Error al llenar el DataGridView: " & ex.Message)
            Return Nothing ' En caso de error, devuelve un DataTable vacío 
        Finally
            conexion.Close()
        End Try
    End Function



    Private Sub CargarRegistrosProducto()
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
        CargarRegistrosProducto()
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
        MostrarNombreUsuarioProducto()
    End Sub

    ''-----------------------------------   Formulario de cliente  -----------------------------------------

    Private Sub MostrarNombreUsuarioCliente()
        conexion.Open()
        Dim consulta As String = "Select Cliente,Ruc,Correo_Electronico as Correo,Telefono,CreateDate as Fecha_Insercion from Clientes"
        Dim adapter As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgClientes.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub btnActualizarCliente_Click(sender As Object, e As EventArgs) Handles btnActualizarCliente.Click
        MostrarNombreUsuarioCliente()
    End Sub


    Private Sub CargarRegistrosCliente()
        Dim consulta As String = "INSERT INTO Clientes(Codigo_cliente, Cliente, Ruc, Correo_Electronico, Telefono) VALUES (@Codigo, @Cliente, @Ruc, @Correo, @Telefono)"
        Dim connectionString As String = "server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE"

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@Codigo", txtId.Text)
                comando.Parameters.AddWithValue("@Cliente", txtClienteNuevo.Text)
                comando.Parameters.AddWithValue("@Ruc", txtRuc.Text)
                comando.Parameters.AddWithValue("@Correo", txtCorreo.Text)
                comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MsgBox("Se registró correctamente")
                Catch ex As Exception
                    MsgBox("Hubo un error al registrar")
                End Try
            End Using
        End Using
    End Sub


    Private Sub BtnGuardarCliente_Click(sender As Object, e As EventArgs) Handles BtnGuardarCliente.Click
        CargarRegistrosCliente()
    End Sub

    ''-----------------------------------   Formulario de Pedido  -----------------------------------------
    Private Sub cargarCombosPedido()

        cmbArticulos.DataSource = SelectResult("SELECT '' id,'' nombre_producto UNION SELECT id, nombre_producto from Productos")
        With (cmbArticulos)
            .DisplayMember = "nombre_producto"
            .ValueMember = "id"
        End With
    End Sub

    '----------------   GUARDAR PEDIDOS   ------------------------------'


    Private frmModificarPedidoInstance As FrmModificarPedido

    Private Sub BtnAbrirModificarPedido_Click(sender As Object, e As EventArgs)
        ' Abre el formulario FrmModificarPedido
        frmModificarPedidoInstance = New FrmModificarPedido()
        frmModificarPedidoInstance.Show()
    End Sub

    '---------     EJECUTAR FUNCIONES DE PEDIDOS   ------------'
    Private Sub EjecutarFuncionGuardar()
        Dim form2 As New FrmModificarPedido()
        form2.GuardarPedidos()
        form2.limpiarPedidos()
    End Sub

    Private Sub ejecutarfuncionactualizar()
        Dim form2 As New FrmModificarPedido()
        form2.ModificarPedido()
        form2.limpiarPedidos()
    End Sub

    Private Sub EjecutarFuncionEliminar()
        Dim form2 As New FrmModificarPedido()
        form2.Eliminar()
        form2.limpiarPedidos()
    End Sub

    '-----------------   BOTONES DE PEDIDO ----------------------'

    Private Sub btnMoficarPedido_Click(sender As Object, e As EventArgs) Handles btnMoficarPedido.Click
        ejecutarfuncionactualizar()
    End Sub

    Private Sub Guardar_Pedidos_Click(sender As Object, e As EventArgs) Handles Guardar_Pedidos.Click
        EjecutarFuncionGuardar()
    End Sub

    Private Sub eliminar_pedido_Click(sender As Object, e As EventArgs) Handles eliminar_pedido.Click
        EjecutarFuncionEliminar()
    End Sub


    '------------  CARGAR DATAGRID DE PEDIDOS ----------------------'
    Private Sub datapedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datapedidos.CellContentClick
        Try

            Dim cells As DataGridViewCellCollection = datapedidos.CurrentRow.Cells
            txtidP.Text = cells(0).Value.ToString()
            txtproductoP.Text = cells(1).Value.ToString()
            txtPrecioP.Text = cells(2).Value.ToString()
            txtcorreoP.Text = cells(3).Value.ToString()
            txtteleP.Text = cells(4).Value.ToString()

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    '----------------- RESTRINGIR DATOS EN PEDIDOS -----------------------;
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    '-------------------- COMPROBAR FECHA -----------------------

    Public Function ComprobarFechaCercana(fechaDada As DateTime) As Boolean
        ' Obtenemos la fecha actual
        Dim fechaActual As DateTime = DateTime.Now

        ' Calculamos la diferencia en días entre la fecha dada y la fecha actual
        Dim diferenciaDias As Integer = (fechaDada - fechaActual).Days

        ' Verificamos si la diferencia es menor o igual a 3 días
        If diferenciaDias <= 3 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ComprobarFechas()
        ' Obtener los productos y fechas de la tabla Pedidos
        Dim connectionString As String = "server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE"
        Dim consulta As String = "SELECT Producto, fecha FROM Pedidos"

        Dim fechasCercanas As New List(Of (String, DateTime))()

        Using conexion As New SqlConnection(connectionString)
            Dim comando As New SqlCommand(consulta, conexion)

            conexion.Open()

            Dim lector As SqlDataReader = comando.ExecuteReader()

            While lector.Read()
                Dim producto As String = lector.GetString(0) ' El producto está en la primera columna (columna 0)
                Dim fechaPedido As DateTime = lector.GetDateTime(1) ' La fecha del pedido está en la segunda columna (columna 1)

                ' Verificar si la fecha del pedido está a menos de tres días de la fecha actual
                If ComprobarFechaCercana(fechaPedido) Then
                    fechasCercanas.Add((producto, fechaPedido))
                End If
            End While

            lector.Close()
        End Using

        ' Procesar las fechas y productos encontrados
        If fechasCercanas.Count > 0 Then

            Dim mensaje As String = "Los siguientes productos están a menos de tres días de vencer:" & vbCrLf

            For Each item As (String, DateTime) In fechasCercanas
                mensaje += item.Item1 & " - " & item.Item2.ToString("dd/MM/yyyy") & vbCrLf
            Next

            MessageBox.Show(mensaje)
        Else
            MessageBox.Show("No se encontraron productos a menos de tres días de la fecha actual.")
        End If
    End Sub


End Class
