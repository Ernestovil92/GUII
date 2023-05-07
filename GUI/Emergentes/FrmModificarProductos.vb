Imports System.Data.SqlClient

Public Class FrmModificarProductos
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub Modificar()
        conexion.Open()
        If conexion.State = 1 Then
            Dim consulta As String = "UPDATE Productos SET nombre_producto='" & txtProducto.Text & "',codigo_barra='" & txtCodigo.Text & "',U_cliente='" & txtCliente.Text & "' where id = '" & txtId.Text & "'"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se ha actualizado el registro Nro.: " + txtId.Text)
        Else
            MsgBox("Error no se pudo actualizar")
        End If

        conexion.Close()
    End Sub

    Private Sub FrmModificarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Modificar()
        txtId.Text = " "
        txtProducto.Text = " "
        txtCodigo.Text = " "
        txtCliente.Text = " "
        Me.Hide()
    End Sub


End Class