﻿Imports System.Data.SqlClient

Public Class FrmPendientes
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
        Pendientes()
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


    Private Sub Pendientes()
        Dim query2 As String = "select codigo_barra as Codigo, nombre_producto as Producto, Proveedor as Proveedores, Precio_unitario,stock,createDate as Fecha from Productos"
        Dim dt2 As DataTable = SelectResult(query2)
        Dim DV As New DataView(dt2)
        dgPendientes.DataSource = DV
    End Sub


End Class