﻿Imports System.Data.SqlClient

Public Class FrmLogin
    Dim conexion As New SqlConnection()
    Dim cmd As New SqlCommand()

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-54PHT7T\SQLEXPRESS;database=GUI;integrated security=TRUE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Open()
        Dim consulta As String = "select * from acceso where usuarios = '" & txtUsuario.Text & "' and pass='" & txtPassword.Text & "'"
        cmd = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = cmd.ExecuteReader

        If lector.HasRows Then
            Form1.ShowDialog()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña incorrecta")
        End If
        conexion.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class