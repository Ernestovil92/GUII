﻿
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()

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

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        AbrirFormEnPanel(New FrmPedidos)
    End Sub
End Class
