<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelBarraTitulo = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        lblUsuario = New Label()
        btnRestaurar = New PictureBox()
        btnMinimizar = New PictureBox()
        btnMaximizar = New PictureBox()
        btnCerrar = New PictureBox()
        PanelMenu = New Panel()
        PictureBox1 = New PictureBox()
        btnReportes = New Button()
        btnClientes = New Button()
        btnDelivery = New Button()
        btnCompras = New Button()
        btnProductos = New Button()
        btnMenu = New PictureBox()
        PanelContenedor = New Panel()
        Button1 = New Button()
        tmOCULTAR = New Timer(components)
        tmMOSTRAR = New Timer(components)
        PanelBarraTitulo.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnRestaurar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenedor.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelBarraTitulo
        ' 
        PanelBarraTitulo.BackColor = Color.Goldenrod
        PanelBarraTitulo.Controls.Add(PictureBox2)
        PanelBarraTitulo.Controls.Add(Label2)
        PanelBarraTitulo.Controls.Add(lblUsuario)
        PanelBarraTitulo.Controls.Add(btnRestaurar)
        PanelBarraTitulo.Controls.Add(btnMinimizar)
        PanelBarraTitulo.Controls.Add(btnMaximizar)
        PanelBarraTitulo.Controls.Add(btnCerrar)
        PanelBarraTitulo.Dock = DockStyle.Top
        PanelBarraTitulo.Location = New Point(0, 0)
        PanelBarraTitulo.Name = "PanelBarraTitulo"
        PanelBarraTitulo.Size = New Size(1150, 54)
        PanelBarraTitulo.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(63, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(81, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 4
        Label2.Text = "Administrador"
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.BackColor = Color.Transparent
        lblUsuario.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsuario.ForeColor = Color.White
        lblUsuario.Location = New Point(81, 9)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(242, 17)
        lblUsuario.TabIndex = 3
        lblUsuario.Text = "VILLALBA GONZALEZ, ERNESTO GABRIEL"
        ' 
        ' btnRestaurar
        ' 
        btnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRestaurar.Cursor = Cursors.Hand
        btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), Image)
        btnRestaurar.Location = New Point(1064, 0)
        btnRestaurar.Name = "btnRestaurar"
        btnRestaurar.Size = New Size(40, 40)
        btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom
        btnRestaurar.TabIndex = 2
        btnRestaurar.TabStop = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.Cursor = Cursors.Hand
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(1018, 0)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(40, 40)
        btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimizar.TabIndex = 1
        btnMinimizar.TabStop = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.Cursor = Cursors.Hand
        btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), Image)
        btnMaximizar.Location = New Point(1064, 0)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(40, 40)
        btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom
        btnMaximizar.TabIndex = 1
        btnMaximizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.Image = My.Resources.Resources.Icono_cerrar_FN1
        btnCerrar.Location = New Point(1110, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(40, 40)
        btnCerrar.SizeMode = PictureBoxSizeMode.Zoom
        btnCerrar.TabIndex = 0
        btnCerrar.TabStop = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        PanelMenu.Controls.Add(PictureBox1)
        PanelMenu.Controls.Add(btnReportes)
        PanelMenu.Controls.Add(btnClientes)
        PanelMenu.Controls.Add(btnDelivery)
        PanelMenu.Controls.Add(btnCompras)
        PanelMenu.Controls.Add(btnProductos)
        PanelMenu.Controls.Add(btnMenu)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 54)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(220, 546)
        PanelMenu.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LOGO
        PictureBox1.Location = New Point(3, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnReportes
        ' 
        btnReportes.FlatAppearance.BorderSize = 0
        btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        btnReportes.FlatStyle = FlatStyle.Flat
        btnReportes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnReportes.ForeColor = SystemColors.Control
        btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), Image)
        btnReportes.ImageAlign = ContentAlignment.MiddleLeft
        btnReportes.Location = New Point(3, 270)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(217, 50)
        btnReportes.TabIndex = 4
        btnReportes.Text = "Reportes"
        btnReportes.UseVisualStyleBackColor = True
        ' 
        ' btnClientes
        ' 
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnClientes.ForeColor = SystemColors.Control
        btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), Image)
        btnClientes.ImageAlign = ContentAlignment.MiddleLeft
        btnClientes.Location = New Point(3, 109)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(217, 50)
        btnClientes.TabIndex = 3
        btnClientes.Text = " Clientes"
        btnClientes.UseVisualStyleBackColor = True
        ' 
        ' btnDelivery
        ' 
        btnDelivery.FlatAppearance.BorderSize = 0
        btnDelivery.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnDelivery.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        btnDelivery.FlatStyle = FlatStyle.Flat
        btnDelivery.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelivery.ForeColor = SystemColors.Control
        btnDelivery.Image = CType(resources.GetObject("btnDelivery.Image"), Image)
        btnDelivery.ImageAlign = ContentAlignment.MiddleLeft
        btnDelivery.Location = New Point(3, 214)
        btnDelivery.Name = "btnDelivery"
        btnDelivery.Size = New Size(217, 50)
        btnDelivery.TabIndex = 2
        btnDelivery.Text = "Envios"
        btnDelivery.UseVisualStyleBackColor = True
        ' 
        ' btnCompras
        ' 
        btnCompras.FlatAppearance.BorderSize = 0
        btnCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        btnCompras.FlatStyle = FlatStyle.Flat
        btnCompras.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCompras.ForeColor = SystemColors.Control
        btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), Image)
        btnCompras.ImageAlign = ContentAlignment.MiddleLeft
        btnCompras.Location = New Point(3, 165)
        btnCompras.Name = "btnCompras"
        btnCompras.Size = New Size(217, 43)
        btnCompras.TabIndex = 1
        btnCompras.Text = "  Pendiente"
        btnCompras.UseVisualStyleBackColor = True
        ' 
        ' btnProductos
        ' 
        btnProductos.FlatAppearance.BorderSize = 0
        btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(55), CByte(70))
        btnProductos.FlatStyle = FlatStyle.Flat
        btnProductos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnProductos.ForeColor = SystemColors.Control
        btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), Image)
        btnProductos.ImageAlign = ContentAlignment.MiddleLeft
        btnProductos.Location = New Point(6, 326)
        btnProductos.Name = "btnProductos"
        btnProductos.RightToLeft = RightToLeft.No
        btnProductos.Size = New Size(208, 50)
        btnProductos.TabIndex = 0
        btnProductos.Text = "Ayuda"
        btnProductos.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMenu.Cursor = Cursors.Hand
        btnMenu.Image = My.Resources.Resources.Mobile_Menu_Icon
        btnMenu.Location = New Point(182, 6)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(32, 32)
        btnMenu.SizeMode = PictureBoxSizeMode.Zoom
        btnMenu.TabIndex = 0
        btnMenu.TabStop = False
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = SystemColors.ActiveBorder
        PanelContenedor.Controls.Add(Button1)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(220, 54)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(930, 546)
        PanelContenedor.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(825, 257)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' tmOCULTAR
        ' 
        ' 
        ' tmMOSTRAR
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1150, 600)
        Controls.Add(PanelContenedor)
        Controls.Add(PanelMenu)
        Controls.Add(PanelBarraTitulo)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PanelBarraTitulo.ResumeLayout(False)
        PanelBarraTitulo.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(btnRestaurar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).EndInit()
        PanelContenedor.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents tmOCULTAR As Timer
    Friend WithEvents tmMOSTRAR As Timer
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Button1 As Button
End Class
