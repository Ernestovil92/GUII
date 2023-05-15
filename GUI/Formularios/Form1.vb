
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()


    ''    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    ''  Private Shared Sub ReleaseCapture()
    ''End Sub

    ''<DllImport("user32.DLL", EntryPoint:="SendMessage")>
    ''Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    ''End Sub


    '' Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
    ''     Application.Exit()
    ''   End Sub

    ''   Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
    '' btnMaximizar.Visible = False
    ''     btnRestaurar.Visible = True
    ''  End Sub

    '' Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
    ''  Me.WindowState = FormWindowState.Minimized
    ''  End Sub
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
    ''Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
    ''If PanelMenu.Width <= 60 Then
    ''Me.tmOCULTAR.Enabled = False
    ''Else
    ''Me.PanelMenu.Width = PanelMenu.Width - 10
    ''End If
    ''End Sub

    ''    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
    ''  If PanelMenu.Width >= 220 Then
    ''Me.tmMOSTRAR.Enabled = False
    ''Else
    ''Me.PanelMenu.Width = PanelMenu.Width + 10
    ''End If
    '' End Sub

    '' Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
    ''  Me.WindowState = FormWindowState.Normal
    ''      btnRestaurar.Visible = False
    ''       btnMaximizar.Visible = True
    ''  End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub



    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        AbrirFormEnPanel(New FrmProductos)
    End Sub



    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        AbrirFormEnPanel(New FrmReportes)
    End Sub



    ''   Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
    ''       ReleaseCapture()
    ''     SendMessage(Me.Handle, &H112&, &HF012&, 0)
    ''  End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        AbrirFormEnPanel(New FrmClientes)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Close()
    End Sub

    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        AbrirFormEnPanel(New FrmPendientes)
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        AbrirFormEnPanel(New FrmAyuda)
    End Sub
End Class
