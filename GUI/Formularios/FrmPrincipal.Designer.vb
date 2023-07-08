<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        menuContenedor = New Panel()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel8 = New Panel()
        btnMenu = New PictureBox()
        btnHome = New Button()
        Panel6 = New Panel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        pProducto = New Panel()
        btnPedidos = New Button()
        btnCerrarSesion = New Button()
        Label3 = New Label()
        btnReportes = New Button()
        btnClientes = New Button()
        btnPendientes = New Button()
        btnAyuda = New Button()
        btnProductos = New Button()
        tmOCULTAR = New Timer(components)
        tmMOSTRAR = New Timer(components)
        PanelContenedor = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Panel11 = New Panel()
        lblHora = New Label()
        lblFecha = New Label()
        TabPage2 = New TabPage()
        Label8 = New Label()
        TabPage3 = New TabPage()
        Label9 = New Label()
        TabPage4 = New TabPage()
        Label10 = New Label()
        TabPage5 = New TabPage()
        Label11 = New Label()
        TabPage6 = New TabPage()
        Label12 = New Label()
        TabPage7 = New TabPage()
        Label13 = New Label()
        Timer1 = New Timer(components)
        menuContenedor.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenedor.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel11.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage6.SuspendLayout()
        TabPage7.SuspendLayout()
        SuspendLayout()
        ' 
        ' menuContenedor
        ' 
        menuContenedor.BackColor = Color.DarkSlateGray
        menuContenedor.Controls.Add(PictureBox1)
        menuContenedor.Controls.Add(Panel1)
        menuContenedor.Controls.Add(Panel8)
        menuContenedor.Controls.Add(btnMenu)
        menuContenedor.Controls.Add(btnHome)
        menuContenedor.Controls.Add(Panel6)
        menuContenedor.Controls.Add(Panel5)
        menuContenedor.Controls.Add(Panel4)
        menuContenedor.Controls.Add(Panel3)
        menuContenedor.Controls.Add(Panel2)
        menuContenedor.Controls.Add(pProducto)
        menuContenedor.Controls.Add(btnPedidos)
        menuContenedor.Controls.Add(btnCerrarSesion)
        menuContenedor.Controls.Add(Label3)
        menuContenedor.Controls.Add(btnReportes)
        menuContenedor.Controls.Add(btnClientes)
        menuContenedor.Controls.Add(btnPendientes)
        menuContenedor.Controls.Add(btnAyuda)
        menuContenedor.Controls.Add(btnProductos)
        menuContenedor.Dock = DockStyle.Left
        menuContenedor.Location = New Point(0, 0)
        menuContenedor.Name = "menuContenedor"
        menuContenedor.Size = New Size(220, 669)
        menuContenedor.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(28, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Location = New Point(0, 135)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(13, 50)
        Panel1.TabIndex = 28
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Teal
        Panel8.Location = New Point(0, 588)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(10, 50)
        Panel8.TabIndex = 27
        ' 
        ' btnMenu
        ' 
        btnMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMenu.Cursor = Cursors.Hand
        btnMenu.Image = My.Resources.Resources.Mobile_Menu_Icon
        btnMenu.Location = New Point(188, 3)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(32, 23)
        btnMenu.SizeMode = PictureBoxSizeMode.Zoom
        btnMenu.TabIndex = 0
        btnMenu.TabStop = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.DarkSlateGray
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatAppearance.MouseDownBackColor = Color.Teal
        btnHome.FlatAppearance.MouseOverBackColor = Color.Teal
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnHome.ForeColor = Color.White
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.ImageAlign = ContentAlignment.MiddleLeft
        btnHome.Location = New Point(12, 135)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(208, 50)
        btnHome.TabIndex = 17
        btnHome.Text = "Dashboard"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Teal
        Panel6.Location = New Point(0, 471)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(13, 50)
        Panel6.TabIndex = 16
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Teal
        Panel5.Location = New Point(0, 415)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(13, 50)
        Panel5.TabIndex = 15
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Teal
        Panel4.Location = New Point(0, 359)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(13, 50)
        Panel4.TabIndex = 14
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.Location = New Point(0, 303)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(13, 50)
        Panel3.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Location = New Point(0, 247)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(13, 50)
        Panel2.TabIndex = 12
        ' 
        ' pProducto
        ' 
        pProducto.BackColor = Color.Teal
        pProducto.Location = New Point(0, 191)
        pProducto.Name = "pProducto"
        pProducto.Size = New Size(13, 50)
        pProducto.TabIndex = 11
        ' 
        ' btnPedidos
        ' 
        btnPedidos.FlatAppearance.BorderSize = 0
        btnPedidos.FlatAppearance.MouseDownBackColor = Color.Teal
        btnPedidos.FlatAppearance.MouseOverBackColor = Color.Teal
        btnPedidos.FlatStyle = FlatStyle.Flat
        btnPedidos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPedidos.ForeColor = Color.White
        btnPedidos.Image = CType(resources.GetObject("btnPedidos.Image"), Image)
        btnPedidos.ImageAlign = ContentAlignment.MiddleLeft
        btnPedidos.Location = New Point(12, 303)
        btnPedidos.Name = "btnPedidos"
        btnPedidos.Size = New Size(208, 50)
        btnPedidos.TabIndex = 10
        btnPedidos.Text = "Pedidos"
        btnPedidos.UseVisualStyleBackColor = True
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.Teal
        btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.Teal
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCerrarSesion.ForeColor = Color.White
        btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), Image)
        btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft
        btnCerrarSesion.Location = New Point(12, 588)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.RightToLeft = RightToLeft.No
        btnCerrarSesion.Size = New Size(208, 50)
        btnCerrarSesion.TabIndex = 9
        btnCerrarSesion.Text = "Cerrar Sesion"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(130, 641)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 8
        Label3.Text = "Version: 1.0.0.2"
        ' 
        ' btnReportes
        ' 
        btnReportes.FlatAppearance.BorderSize = 0
        btnReportes.FlatAppearance.MouseDownBackColor = Color.Teal
        btnReportes.FlatAppearance.MouseOverBackColor = Color.Teal
        btnReportes.FlatStyle = FlatStyle.Flat
        btnReportes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnReportes.ForeColor = Color.White
        btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), Image)
        btnReportes.ImageAlign = ContentAlignment.MiddleLeft
        btnReportes.Location = New Point(12, 415)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(208, 50)
        btnReportes.TabIndex = 4
        btnReportes.Text = "Reportes"
        btnReportes.UseVisualStyleBackColor = True
        ' 
        ' btnClientes
        ' 
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatAppearance.MouseDownBackColor = Color.Teal
        btnClientes.FlatAppearance.MouseOverBackColor = Color.Teal
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnClientes.ForeColor = Color.White
        btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), Image)
        btnClientes.ImageAlign = ContentAlignment.MiddleLeft
        btnClientes.Location = New Point(12, 247)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(215, 50)
        btnClientes.TabIndex = 3
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = True
        ' 
        ' btnPendientes
        ' 
        btnPendientes.FlatAppearance.BorderSize = 0
        btnPendientes.FlatAppearance.MouseDownBackColor = Color.Teal
        btnPendientes.FlatAppearance.MouseOverBackColor = Color.Teal
        btnPendientes.FlatStyle = FlatStyle.Flat
        btnPendientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPendientes.ForeColor = Color.White
        btnPendientes.Image = CType(resources.GetObject("btnPendientes.Image"), Image)
        btnPendientes.ImageAlign = ContentAlignment.MiddleLeft
        btnPendientes.Location = New Point(12, 359)
        btnPendientes.Name = "btnPendientes"
        btnPendientes.Size = New Size(208, 50)
        btnPendientes.TabIndex = 1
        btnPendientes.Text = "  Pendiente"
        btnPendientes.UseVisualStyleBackColor = True
        ' 
        ' btnAyuda
        ' 
        btnAyuda.FlatAppearance.BorderSize = 0
        btnAyuda.FlatAppearance.MouseDownBackColor = Color.Teal
        btnAyuda.FlatAppearance.MouseOverBackColor = Color.Teal
        btnAyuda.FlatStyle = FlatStyle.Flat
        btnAyuda.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAyuda.ForeColor = Color.White
        btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), Image)
        btnAyuda.ImageAlign = ContentAlignment.MiddleLeft
        btnAyuda.Location = New Point(12, 471)
        btnAyuda.Name = "btnAyuda"
        btnAyuda.RightToLeft = RightToLeft.No
        btnAyuda.Size = New Size(208, 50)
        btnAyuda.TabIndex = 0
        btnAyuda.Text = "Ayuda"
        btnAyuda.UseVisualStyleBackColor = True
        ' 
        ' btnProductos
        ' 
        btnProductos.BackColor = Color.DarkSlateGray
        btnProductos.FlatAppearance.BorderSize = 0
        btnProductos.FlatAppearance.MouseDownBackColor = Color.Teal
        btnProductos.FlatAppearance.MouseOverBackColor = Color.Teal
        btnProductos.FlatStyle = FlatStyle.Flat
        btnProductos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnProductos.ForeColor = Color.White
        btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), Image)
        btnProductos.ImageAlign = ContentAlignment.MiddleLeft
        btnProductos.Location = New Point(12, 191)
        btnProductos.Name = "btnProductos"
        btnProductos.Size = New Size(208, 50)
        btnProductos.TabIndex = 2
        btnProductos.Text = "Producto"
        btnProductos.UseVisualStyleBackColor = False
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        PanelContenedor.Controls.Add(TabControl1)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(220, 0)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(951, 669)
        PanelContenedor.TabIndex = 2
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Controls.Add(TabPage7)
        TabControl1.Location = New Point(3, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(948, 666)
        TabControl1.TabIndex = 13
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage1.Controls.Add(Panel11)
        TabPage1.ForeColor = Color.Black
        TabPage1.ImeMode = ImeMode.NoControl
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(940, 638)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(lblHora)
        Panel11.Controls.Add(lblFecha)
        Panel11.Location = New Point(248, 260)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(540, 105)
        Panel11.TabIndex = 12
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Perpetua Titling MT", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblHora.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        lblHora.Location = New Point(214, 6)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(127, 38)
        lblHora.TabIndex = 1
        lblHora.Text = "03:05:15"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Perpetua Titling MT", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblFecha.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        lblFecha.Location = New Point(3, 44)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(528, 38)
        lblFecha.TabIndex = 0
        lblFecha.Text = "DOMINGO, 18 DE JUNIO DE 2023"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage2.Controls.Add(Label8)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(940, 582)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Productos"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(420, 288)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 15)
        Label8.TabIndex = 0
        Label8.Text = "PRODUCTOS"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage3.Controls.Add(Label9)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(940, 582)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Clientes"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(433, 284)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 15)
        Label9.TabIndex = 1
        Label9.Text = "CLIENTES"
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage4.Controls.Add(Label10)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(940, 582)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Pedidos"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(433, 284)
        Label10.Name = "Label10"
        Label10.Size = New Size(54, 15)
        Label10.TabIndex = 1
        Label10.Text = "PEDIDOS"
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage5.Controls.Add(Label11)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(940, 582)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Pendiente"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(433, 284)
        Label11.Name = "Label11"
        Label11.Size = New Size(73, 15)
        Label11.TabIndex = 1
        Label11.Text = "PENDIENTES"
        ' 
        ' TabPage6
        ' 
        TabPage6.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage6.Controls.Add(Label12)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Size = New Size(940, 582)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Reportes"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(433, 284)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 15)
        Label12.TabIndex = 1
        Label12.Text = "REPORTES"
        ' 
        ' TabPage7
        ' 
        TabPage7.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage7.Controls.Add(Label13)
        TabPage7.Location = New Point(4, 24)
        TabPage7.Name = "TabPage7"
        TabPage7.Size = New Size(940, 582)
        TabPage7.TabIndex = 6
        TabPage7.Text = "Ayuda"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(433, 284)
        Label13.Name = "Label13"
        Label13.Size = New Size(45, 15)
        Label13.TabIndex = 1
        Label13.Text = "AYUDA"
        ' 
        ' Timer1
        ' 
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1171, 669)
        Controls.Add(PanelContenedor)
        Controls.Add(menuContenedor)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        menuContenedor.ResumeLayout(False)
        menuContenedor.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).EndInit()
        PanelContenedor.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        TabPage6.ResumeLayout(False)
        TabPage6.PerformLayout()
        TabPage7.ResumeLayout(False)
        TabPage7.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents menuContenedor As Panel
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmOCULTAR As Timer
    Friend WithEvents tmMOSTRAR As Timer
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnPendientes As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPedidos As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pProducto As Panel
    Friend WithEvents imgClientes As PictureBox
    Friend WithEvents ImageProducto As PictureBox
    Friend WithEvents imgProductos As PictureBox
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
