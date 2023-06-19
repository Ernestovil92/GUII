Public Class FrmHome
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        PAdmin.Hide()
        btnCampanaRoja.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        ModificarCuenta.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PAdmin.Show()
    End Sub
    Private Sub btnCuenta_MouseHover(sender As Object, e As EventArgs) Handles btnCuenta.MouseHover
        btnCuenta.ForeColor = Color.White
        btnCS.ForeColor = Color.DarkSlateGray
    End Sub

    Private Sub btnCS_MouseHover(sender As Object, e As EventArgs) Handles btnCS.MouseHover
        btnCuenta.ForeColor = Color.DarkSlateGray
        btnCS.ForeColor = Color.White
    End Sub


    Private Sub PAdmin_Leave(sender As Object, e As EventArgs) Handles PAdmin.Leave
        PAdmin.Hide()
    End Sub


End Class