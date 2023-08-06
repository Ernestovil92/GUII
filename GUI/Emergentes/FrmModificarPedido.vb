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


    ''-------------------- MODIFICAR PEDIDO ------------------------------ '
    Public Sub ModificarPedido()
        Dim consulta As String = "UPDATE pedidos SET id = @id, Producto = @Producto, precio = @Precio, correo = @Correo, telefono = @Telefono, fecha = getdate() WHERE Id = @Id"
        Dim connectionString As String = "server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE"
        Try
            Using conexion As New SqlConnection(connectionString)

                conexion.Open()
                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id", FrmPrincipal.txtidP.Text)
                    comando.Parameters.AddWithValue("@Producto", FrmPrincipal.txtproductoP.Text)
                    comando.Parameters.AddWithValue("@Precio", FrmPrincipal.txtPrecioP.Text)
                    comando.Parameters.AddWithValue("@Correo", FrmPrincipal.txtcorreoP.Text)
                    comando.Parameters.AddWithValue("@Telefono", FrmPrincipal.txtteleP.Text)

                    Dim filasActualizadas As Integer = comando.ExecuteNonQuery()

                    If filasActualizadas > 0 Then
                        MsgBox("Se ha actualizado el registro Nro.: " & FrmPrincipal.txtidP.Text)
                    Else
                        MsgBox("No se encontró ningún registro con el Id proporcionado.")
                    End If
                End Using

            End Using

        Catch ex As Exception
            MsgBox("Error al actualizar el registro: " & ex.Message)
        End Try
        FrmPrincipal.datapedidos.DataSource = FrmPrincipal.LLenar_grid()
        limpiarPedidos()
    End Sub

    '------------GUARDAR--------------------------'
    Public Sub GuardarPedidos()
        Dim connectionString As String = "server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE"

        Using conexion As New SqlConnection(connectionString)
            Dim consulta As String = "INSERT INTO pedidos(id,Producto, precio, correo, telefono, fecha) VALUES(@id,@Producto, @Precio, @Correo, @Telefono, GETDATE())"
            Dim comando As New SqlCommand(consulta, conexion)

            comando.Parameters.AddWithValue("@id", FrmPrincipal.txtidP.Text)
            comando.Parameters.AddWithValue("@Producto", FrmPrincipal.txtproductoP.Text)
            comando.Parameters.AddWithValue("@Precio", FrmPrincipal.txtPrecioP.Text)
            comando.Parameters.AddWithValue("@Correo", FrmPrincipal.txtcorreoP.Text)
            comando.Parameters.AddWithValue("@Telefono", FrmPrincipal.txtteleP.Text)
            Try
                conexion.Open()
                Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
                If filasAfectadas > 0 Then
                    MsgBox("Se registró correctamente.")
                Else
                    MsgBox("Hubo un error al registrar.")
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
            FrmPrincipal.datapedidos.DataSource = FrmPrincipal.LLenar_grid()
        End Using
    End Sub

    '-----------------    ELIMINAR    ---------------------------------'

    Public Sub Eliminar()
        If String.IsNullOrWhiteSpace(FrmPrincipal.txtidP.Text) Then
            MsgBox("Error: el campo de ID está vacío.")
            Return
        End If

        Dim id As Integer
        If Not Integer.TryParse(FrmPrincipal.txtidP.Text, id) Then
            MsgBox("Error: el ID debe ser un valor numérico válido.")
            Return
        End If

        Dim respuesta As DialogResult = MsgBox("¿Está seguro de eliminar permanentemente este registro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Dim connectionString As String = "server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE"
        If respuesta = DialogResult.OK Then
            Try
                Using conexion As New SqlConnection(connectionString)
                    conexion.Open()

                    Dim consulta As String = "DELETE FROM pedidos WHERE id = @Id"
                    Using comando As New SqlCommand(consulta, conexion)
                        comando.Parameters.AddWithValue("@Id", id)
                        Dim filasAfectadas As Integer = comando.ExecuteNonQuery()

                        If filasAfectadas > 0 Then
                            MsgBox("Se ha eliminado el registro Nro.: " + id.ToString())
                        Else
                            MsgBox("No se encontró ningún registro con el ID especificado.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al intentar eliminar el registro: " + ex.Message)
            End Try
        End If
        FrmPrincipal.datapedidos.DataSource = FrmPrincipal.LLenar_grid()
    End Sub


    Public Sub limpiarPedidos()
        FrmPrincipal.txtidP.Text = ""
        FrmPrincipal.txtproductoP.Text = ""
        FrmPrincipal.txtPrecioP.Text = ""
        FrmPrincipal.txtcorreoP.Text = ""
        FrmPrincipal.txtteleP.Text = ""

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
        limpiarPedidos()
    End Sub


End Class