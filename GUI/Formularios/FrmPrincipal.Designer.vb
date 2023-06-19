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
        Panel11 = New Panel()
        lblHora = New Label()
        lblFecha = New Label()
        Panel7 = New Panel()
        Panel10 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        Button7 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Label7 = New Label()
        Button16 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Label4 = New Label()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Label5 = New Label()
        Button13 = New Button()
        PAdmin = New Panel()
        btnCS = New Button()
        btnCuenta = New Button()
        Panel9 = New Panel()
        Button4 = New Button()
        Button5 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        Button6 = New Button()
        Timer1 = New Timer(components)
        menuContenedor.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenedor.SuspendLayout()
        Panel11.SuspendLayout()
        Panel7.SuspendLayout()
        Panel10.SuspendLayout()
        PAdmin.SuspendLayout()
        Panel9.SuspendLayout()
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
        PanelContenedor.Controls.Add(Panel11)
        PanelContenedor.Controls.Add(Panel7)
        PanelContenedor.Controls.Add(PAdmin)
        PanelContenedor.Controls.Add(Panel9)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(220, 0)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(930, 669)
        PanelContenedor.TabIndex = 2
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(lblHora)
        Panel11.Controls.Add(lblFecha)
        Panel11.Location = New Point(293, 316)
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
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel7.BackColor = Color.FromArgb(CByte(0), CByte(20), CByte(20))
        Panel7.Controls.Add(Panel10)
        Panel7.Controls.Add(Button8)
        Panel7.Controls.Add(Button9)
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(Button10)
        Panel7.Controls.Add(Button11)
        Panel7.Controls.Add(Button12)
        Panel7.Controls.Add(Label5)
        Panel7.Controls.Add(Button13)
        Panel7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel7.Location = New Point(0, 50)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1162, 5)
        Panel7.TabIndex = 9
        ' 
        ' Panel10
        ' 
        Panel10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel10.BackColor = Color.FromArgb(CByte(0), CByte(20), CByte(20))
        Panel10.Controls.Add(Button1)
        Panel10.Controls.Add(Button2)
        Panel10.Controls.Add(Label6)
        Panel10.Controls.Add(Button7)
        Panel10.Controls.Add(Button14)
        Panel10.Controls.Add(Button15)
        Panel10.Controls.Add(Label7)
        Panel10.Controls.Add(Button16)
        Panel10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(1162, 5)
        Panel10.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button1.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(3862, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 28)
        Button1.TabIndex = 23
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button2.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(3890, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(29, 28)
        Button2.TabIndex = 24
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(3916, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 17)
        Label6.TabIndex = 25
        Label6.Text = "Ernesto Villalba"
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button7.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button7.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(4016, 12)
        Button7.Name = "Button7"
        Button7.Size = New Size(29, 28)
        Button7.TabIndex = 22
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button14.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button14.FlatStyle = FlatStyle.Flat
        Button14.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button14.Image = CType(resources.GetObject("Button14.Image"), Image)
        Button14.Location = New Point(4589, 10)
        Button14.Name = "Button14"
        Button14.Size = New Size(29, 28)
        Button14.TabIndex = 8
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button15.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button15.FlatStyle = FlatStyle.Flat
        Button15.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button15.Image = CType(resources.GetObject("Button15.Image"), Image)
        Button15.Location = New Point(4617, 10)
        Button15.Name = "Button15"
        Button15.Size = New Size(29, 28)
        Button15.TabIndex = 9
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(4643, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 17)
        Label7.TabIndex = 21
        Label7.Text = "Ernesto Villalba"
        ' 
        ' Button16
        ' 
        Button16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button16.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button16.FlatStyle = FlatStyle.Flat
        Button16.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button16.Image = CType(resources.GetObject("Button16.Image"), Image)
        Button16.Location = New Point(4737, 12)
        Button16.Name = "Button16"
        Button16.Size = New Size(29, 28)
        Button16.TabIndex = 7
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button8.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button8.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button8.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button8.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button8.FlatStyle = FlatStyle.Flat
        Button8.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.Location = New Point(2900, 12)
        Button8.Name = "Button8"
        Button8.Size = New Size(29, 28)
        Button8.TabIndex = 23
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button9.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button9.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button9.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button9.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button9.FlatStyle = FlatStyle.Flat
        Button9.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.Location = New Point(2928, 12)
        Button9.Name = "Button9"
        Button9.Size = New Size(29, 28)
        Button9.TabIndex = 24
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(2954, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 17)
        Label4.TabIndex = 25
        Label4.Text = "Ernesto Villalba"
        ' 
        ' Button10
        ' 
        Button10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button10.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button10.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button10.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button10.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button10.FlatStyle = FlatStyle.Flat
        Button10.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.Location = New Point(3054, 12)
        Button10.Name = "Button10"
        Button10.Size = New Size(29, 28)
        Button10.TabIndex = 22
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button11.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.FlatStyle = FlatStyle.Flat
        Button11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.Location = New Point(3627, 10)
        Button11.Name = "Button11"
        Button11.Size = New Size(29, 28)
        Button11.TabIndex = 8
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button12.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.FlatStyle = FlatStyle.Flat
        Button12.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.Image = CType(resources.GetObject("Button12.Image"), Image)
        Button12.Location = New Point(3655, 10)
        Button12.Name = "Button12"
        Button12.Size = New Size(29, 28)
        Button12.TabIndex = 9
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(3681, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 17)
        Label5.TabIndex = 21
        Label5.Text = "Ernesto Villalba"
        ' 
        ' Button13
        ' 
        Button13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button13.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.FlatStyle = FlatStyle.Flat
        Button13.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(3775, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(29, 28)
        Button13.TabIndex = 7
        Button13.UseVisualStyleBackColor = False
        ' 
        ' PAdmin
        ' 
        PAdmin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PAdmin.BackColor = Color.Silver
        PAdmin.Controls.Add(btnCS)
        PAdmin.Controls.Add(btnCuenta)
        PAdmin.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        PAdmin.Location = New Point(730, 56)
        PAdmin.Name = "PAdmin"
        PAdmin.Size = New Size(200, 57)
        PAdmin.TabIndex = 7
        ' 
        ' btnCS
        ' 
        btnCS.BackColor = Color.Silver
        btnCS.FlatAppearance.BorderColor = Color.White
        btnCS.FlatAppearance.BorderSize = 0
        btnCS.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        btnCS.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        btnCS.FlatStyle = FlatStyle.Flat
        btnCS.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCS.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCS.Location = New Point(0, 25)
        btnCS.Name = "btnCS"
        btnCS.Size = New Size(200, 25)
        btnCS.TabIndex = 9
        btnCS.Text = "Cerrar Sesion"
        btnCS.UseVisualStyleBackColor = False
        ' 
        ' btnCuenta
        ' 
        btnCuenta.BackColor = Color.Silver
        btnCuenta.FlatAppearance.BorderColor = Color.White
        btnCuenta.FlatAppearance.BorderSize = 0
        btnCuenta.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        btnCuenta.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        btnCuenta.FlatStyle = FlatStyle.Flat
        btnCuenta.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCuenta.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCuenta.Location = New Point(0, 0)
        btnCuenta.Name = "btnCuenta"
        btnCuenta.Size = New Size(200, 25)
        btnCuenta.TabIndex = 8
        btnCuenta.Text = "Configuracion de cuenta"
        btnCuenta.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel9.Controls.Add(Button4)
        Panel9.Controls.Add(Button5)
        Panel9.Controls.Add(Label2)
        Panel9.Controls.Add(Label1)
        Panel9.Controls.Add(Button3)
        Panel9.Controls.Add(Button6)
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(930, 50)
        Panel9.TabIndex = 6
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button4.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(741, 10)
        Button4.Name = "Button4"
        Button4.Size = New Size(29, 28)
        Button4.TabIndex = 8
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button5.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button5.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(769, 10)
        Button5.Name = "Button5"
        Button5.Size = New Size(29, 28)
        Button5.TabIndex = 9
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(795, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 17)
        Label2.TabIndex = 21
        Label2.Text = "Ernesto Villalba"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(46, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 17)
        Label1.TabIndex = 20
        Label1.Text = "Home"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button3.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(898, 10)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 28)
        Button3.TabIndex = 7
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button6.Enabled = False
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(6, 10)
        Button6.Name = "Button6"
        Button6.Size = New Size(29, 28)
        Button6.TabIndex = 10
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1150, 669)
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
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        PAdmin.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
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
    Friend WithEvents Panel7 As Panel
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
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PAdmin As Panel
    Friend WithEvents btnCS As Button
    Friend WithEvents btnCuenta As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Timer1 As Timer
End Class
