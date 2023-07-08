
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Reflection.Module
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

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
        Timer1.Enabled = True
        prueba()
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

    ''HOME
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.btnHome.BackColor = Color.Teal
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray
        TabControl1.SelectedIndex = 0
    End Sub

    ''PRODUCTOS
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click, btnProductos.Click
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.Teal
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray
        TabControl1.SelectedIndex = 1
    End Sub

    ''CLIENTES
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click, btnClientes.Click
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.Teal
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray
        TabControl1.SelectedIndex = 2
    End Sub

    ''PEDIDOS
    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.Teal
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray
        TabControl1.SelectedIndex = 3
    End Sub

    ''PENDIENTES
    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.Teal
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray
        TabControl1.SelectedIndex = 4
    End Sub

    ''REPORTES
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.Teal
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray
        TabControl1.SelectedIndex = 5
    End Sub

    ''AYUDA
    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.Teal
        Me.btnCerrarSesion.BackColor = Color.DarkSlateGray

        TabControl1.SelectedIndex = 6
    End Sub

    ''CERRAR SESION
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.btnHome.BackColor = Color.DarkSlateGray
        Me.btnProductos.BackColor = Color.DarkSlateGray
        Me.btnClientes.BackColor = Color.DarkSlateGray
        Me.btnPedidos.BackColor = Color.DarkSlateGray
        Me.btnPendientes.BackColor = Color.DarkSlateGray
        Me.btnReportes.BackColor = Color.DarkSlateGray
        Me.btnAyuda.BackColor = Color.DarkSlateGray
        Me.btnCerrarSesion.BackColor = Color.Teal
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


End Class
