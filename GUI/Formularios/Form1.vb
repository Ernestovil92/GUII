
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Public Class Form1
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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
    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 10
        End If
    End Sub

    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 10
        End If
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormEnPanel(New FrmProductos)
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormEnPanel(New FrmCompras)
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        AbrirFormEnPanel(New FrmDelivery)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormEnPanel(New FrmClientes)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        AbrirFormEnPanel(New FrmReportes)
    End Sub



    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



    ''   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ''     conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
    ''
    '' End Sub

    ''    Private Sub MostrarNombreUsuario()
    ''      conexion.Open()
    ''Dim consulta As String = "select * from acceso"
    ''Dim adapter As New SqlDataAdapter(consulta, conexion)
    ''Dim dt As New DataTable
    ''  adapter.Fill(dt)
    ''DataGridView1.DataSource = dt
    ''conexion.Close()
    ''   End Sub

    ''   Private Sub CargarRegistros()
    ''     conexion.Open()
    ''Dim consulta As String = "INSERT INTO acceso(usuarios,pass,Nombre_usuario)VALUES('" & txtUsuario.Text & "','" & txtPass.Text & "','" & txtNombre.Text & "')"
    '' Dim comando As New SqlCommand(consulta, conexion)
    ''Dim lector As SqlDataReader
    ''   lector = comando.ExecuteReader
    ''  conexion.Close()
    ''End Sub


    ''Private Sub Modificar()
    ''  conexion.Open()
    '' Dim consulta As String = "UPDATE acceso SET usuarios='" & txtUsuario.Text & "',pass='" & txtPass.Text & "',Nombre_usuario='" & txtNombre.Text & "' where id = '" & txtId.Text & "'"
    '' Dim comando As New SqlCommand(consulta, conexion)
    '' Dim lector As SqlDataReader
    ''    lector = comando.ExecuteReader
    ''   conexion.Close()
    '' End Sub

    ''    Private Sub Eliminar()
    ''      conexion.Open()
    ''Dim consulta As String = "DELETE acceso where id = '" & txtId.Text & "'"
    ''Dim comando As New SqlCommand(consulta, conexion)
    ''Dim lector As SqlDataReader
    ''  lector = comando.ExecuteReader
    '' conexion.Close()
    '' End Sub
    ''Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''   CargarRegistros()
    ''End Sub

    '' Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    ''    Modificar()
    ''End Sub

    ''  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    ''    MostrarNombreUsuario()
    '' End Sub
    '
    '' Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    ''    DataGridView1.DataSource = " "
    ''End Sub



    ''Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    ''   Eliminar()
    ''End Sub
End Class
