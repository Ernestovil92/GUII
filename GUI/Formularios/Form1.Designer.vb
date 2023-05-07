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
        btnCerrarSesion = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        btnReportes = New Button()
        btnProducto = New Button()
        btnDelivery = New Button()
        btnPendientes = New Button()
        btnAyuda = New Button()
        btnMenu = New PictureBox()
        PanelContenedor = New Panel()
        PictureBox3 = New PictureBox()
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
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelMenu.BackColor = Color.Sienna
        PanelMenu.Controls.Add(btnCerrarSesion)
        PanelMenu.Controls.Add(Label3)
        PanelMenu.Controls.Add(PictureBox1)
        PanelMenu.Controls.Add(btnReportes)
        PanelMenu.Controls.Add(btnProducto)
        PanelMenu.Controls.Add(btnDelivery)
        PanelMenu.Controls.Add(btnPendientes)
        PanelMenu.Controls.Add(btnAyuda)
        PanelMenu.Controls.Add(btnMenu)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 54)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(220, 546)
        PanelMenu.TabIndex = 1
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCerrarSesion.ForeColor = SystemColors.ActiveCaptionText
        btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), Image)
        btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft
        btnCerrarSesion.Location = New Point(0, 444)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.RightToLeft = RightToLeft.No
        btnCerrarSesion.Size = New Size(220, 61)
        btnCerrarSesion.TabIndex = 9
        btnCerrarSesion.Text = "Cerrar Sesion"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(130, 522)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 8
        Label3.Text = "Version: 1.0.0.2"
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
        btnReportes.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnReportes.FlatStyle = FlatStyle.Flat
        btnReportes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnReportes.ForeColor = SystemColors.Control
        btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), Image)
        btnReportes.ImageAlign = ContentAlignment.MiddleLeft
        btnReportes.Location = New Point(0, 224)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(220, 50)
        btnReportes.TabIndex = 4
        btnReportes.Text = "Reportes"
        btnReportes.UseVisualStyleBackColor = True
        ' 
        ' btnProducto
        ' 
        btnProducto.FlatAppearance.BorderSize = 0
        btnProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnProducto.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnProducto.FlatStyle = FlatStyle.Flat
        btnProducto.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnProducto.ForeColor = SystemColors.Control
        btnProducto.Image = CType(resources.GetObject("btnProducto.Image"), Image)
        btnProducto.ImageAlign = ContentAlignment.MiddleLeft
        btnProducto.Location = New Point(3, 168)
        btnProducto.Name = "btnProducto"
        btnProducto.Size = New Size(217, 50)
        btnProducto.TabIndex = 3
        btnProducto.Text = "Clientes"
        btnProducto.UseVisualStyleBackColor = True
        ' 
        ' btnDelivery
        ' 
        btnDelivery.FlatAppearance.BorderSize = 0
        btnDelivery.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnDelivery.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnDelivery.FlatStyle = FlatStyle.Flat
        btnDelivery.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelivery.ForeColor = SystemColors.Control
        btnDelivery.Image = CType(resources.GetObject("btnDelivery.Image"), Image)
        btnDelivery.ImageAlign = ContentAlignment.MiddleLeft
        btnDelivery.Location = New Point(0, 112)
        btnDelivery.Name = "btnDelivery"
        btnDelivery.Size = New Size(217, 50)
        btnDelivery.TabIndex = 2
        btnDelivery.Text = "Producto"
        btnDelivery.UseVisualStyleBackColor = True
        ' 
        ' btnPendientes
        ' 
        btnPendientes.FlatAppearance.BorderSize = 0
        btnPendientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnPendientes.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnPendientes.FlatStyle = FlatStyle.Flat
        btnPendientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPendientes.ForeColor = SystemColors.Control
        btnPendientes.Image = CType(resources.GetObject("btnPendientes.Image"), Image)
        btnPendientes.ImageAlign = ContentAlignment.MiddleLeft
        btnPendientes.Location = New Point(0, 280)
        btnPendientes.Name = "btnPendientes"
        btnPendientes.Size = New Size(220, 43)
        btnPendientes.TabIndex = 1
        btnPendientes.Text = "  Pendiente"
        btnPendientes.UseVisualStyleBackColor = True
        ' 
        ' btnAyuda
        ' 
        btnAyuda.FlatAppearance.BorderSize = 0
        btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(145), CByte(110), CByte(21))
        btnAyuda.FlatAppearance.MouseOverBackColor = Color.Goldenrod
        btnAyuda.FlatStyle = FlatStyle.Flat
        btnAyuda.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAyuda.ForeColor = SystemColors.Control
        btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), Image)
        btnAyuda.ImageAlign = ContentAlignment.MiddleLeft
        btnAyuda.Location = New Point(0, 329)
        btnAyuda.Name = "btnAyuda"
        btnAyuda.RightToLeft = RightToLeft.No
        btnAyuda.Size = New Size(220, 50)
        btnAyuda.TabIndex = 0
        btnAyuda.Text = "Ayuda"
        btnAyuda.UseVisualStyleBackColor = True
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
        PanelContenedor.BackColor = Color.White
        PanelContenedor.Controls.Add(PictureBox3)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(220, 54)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(930, 546)
        PanelContenedor.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.LOGO
        PictureBox3.Location = New Point(325, 224)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(373, 117)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
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
        PanelMenu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).EndInit()
        PanelContenedor.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents tmOCULTAR As Timer
    Friend WithEvents tmMOSTRAR As Timer
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnPendientes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Label3 As Label
End Class
