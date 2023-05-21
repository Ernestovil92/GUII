Imports System.Data.SqlClient

Public Class FrmEliminarProductos
    Dim conexion As New SqlConnection()
    Dim comando As New SqlCommand()
    Private Sub FrmEliminarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;DATABASE=GUI;INTEGRATED SECURITY=TRUE")
    End Sub

    Private Sub Eliminar()
        conexion.Open()
        If txtId.Text = " " Then
            MsgBox("Error 2333: no se pudo eliminar registro")
        ElseIf MsgBox("Está seguro de eliminar permanentemente este registro?", vbOKCancel, "Confirmar") = vbOK Then
            Dim consulta As String = "DELETE Productos where codigo_barra = '" & txtId.Text & "'"
            Dim comando As New SqlCommand(consulta, conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            MsgBox("Se ha eliminado el registro Nro.: " + txtId.Text)
        End If

        conexion.Close()
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        txtId.Text = " "
        Me.Hide()
    End Sub
End Class