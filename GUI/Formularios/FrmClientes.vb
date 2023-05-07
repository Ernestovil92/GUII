Public Class FrmClientes
    Private Sub btnPetinax_Click(sender As Object, e As EventArgs) Handles btnPetinax.Click
        lblPertinax.Text = "PERTINAX"
        btnGuardar.Show()
    End Sub

    Private Sub btnNoAplica_Click(sender As Object, e As EventArgs) Handles btnNoAplica.Click
        lblNoAplica.Text = "NO APLICA"
        btnGuardar2.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lblPertinax.Text = "PERTINAX" Then
            MsgBox("Registro Guardado!")
        Else
            MsgBox("Debes de seleccionar una de las opciones.")
        End If

    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        If lblNoAplica.Text = "NO APLICA" Then
            MsgBox("Registro Guardado!")
        Else
            MsgBox("Debes de seleccionar una de las opciones.")
        End If
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnGuardar.Hide()
        btnGuardar2.Hide()
    End Sub


End Class