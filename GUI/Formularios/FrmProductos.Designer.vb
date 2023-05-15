<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelTitulo = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        txtProducto = New TextBox()
        Label3 = New Label()
        txtCodigo = New TextBox()
        Label4 = New Label()
        txtProveedor = New TextBox()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnLimpiar = New Button()
        btnMostrar = New Button()
        btnEliminar = New Button()
        txtBuscar = New TextBox()
        Label5 = New Label()
        dgProductos = New DataGridView()
        Panel2 = New Panel()
        btnModificar2 = New Button()
        btnEliminar2 = New Button()
        btnGuardar2 = New Button()
        Label10 = New Label()
        txtStock = New TextBox()
        Label7 = New Label()
        txtP_unitario = New TextBox()
        Label8 = New Label()
        txtCorreo = New TextBox()
        Label9 = New Label()
        txtTelefono = New TextBox()
        Label6 = New Label()
        Panel1 = New Panel()
        dtFechaFinAr = New DateTimePicker()
        FechaInicioAr = New DateTimePicker()
        Label14 = New Label()
        Label13 = New Label()
        cmbProveedor = New ComboBox()
        Label12 = New Label()
        Label11 = New Label()
        cmbArticulos = New ComboBox()
        TabControl1 = New TabControl()
        Stock = New TabPage()
        NuevoArticulo = New TabPage()
        PanelTitulo.SuspendLayout()
        CType(dgProductos, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        Stock.SuspendLayout()
        NuevoArticulo.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        PanelTitulo.Controls.Add(Label1)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(1162, 52)
        PanelTitulo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label1.Location = New Point(549, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 18)
        Label1.TabIndex = 0
        Label1.Text = "Productos"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label2.Location = New Point(13, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 18)
        Label2.TabIndex = 0
        Label2.Text = "Producto"
        ' 
        ' txtProducto
        ' 
        txtProducto.BackColor = Color.WhiteSmoke
        txtProducto.BorderStyle = BorderStyle.FixedSingle
        txtProducto.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtProducto.Location = New Point(13, 78)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(297, 27)
        txtProducto.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label3.Location = New Point(339, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 18)
        Label3.TabIndex = 2
        Label3.Text = "Codigo"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.BackColor = Color.WhiteSmoke
        txtCodigo.BorderStyle = BorderStyle.FixedSingle
        txtCodigo.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodigo.Location = New Point(339, 78)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(99, 27)
        txtCodigo.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label4.Location = New Point(12, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 18)
        Label4.TabIndex = 4
        Label4.Text = "Proveedor"
        ' 
        ' txtProveedor
        ' 
        txtProveedor.BackColor = Color.WhiteSmoke
        txtProveedor.BorderStyle = BorderStyle.FixedSingle
        txtProveedor.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtProveedor.Location = New Point(12, 138)
        txtProveedor.Name = "txtProveedor"
        txtProveedor.Size = New Size(298, 27)
        txtProveedor.TabIndex = 5
        ' 
        ' btnGuardar
        ' 
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnGuardar.FlatAppearance.MouseDownBackColor = Color.Chocolate
        btnGuardar.FlatAppearance.MouseOverBackColor = Color.Chocolate
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnGuardar.Location = New Point(175, 388)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 36)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnModificar.FlatAppearance.MouseDownBackColor = Color.Chocolate
        btnModificar.FlatAppearance.MouseOverBackColor = Color.Chocolate
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnModificar.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnModificar.Location = New Point(94, 388)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 37)
        btnModificar.TabIndex = 7
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.FlatAppearance.BorderColor = Color.Black
        btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.ForeColor = Color.Black
        btnLimpiar.Location = New Point(369, 272)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(72, 36)
        btnLimpiar.TabIndex = 8
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.FlatAppearance.BorderColor = Color.Black
        btnMostrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnMostrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnMostrar.FlatStyle = FlatStyle.Flat
        btnMostrar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnMostrar.ForeColor = Color.Black
        btnMostrar.Location = New Point(234, 272)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(129, 36)
        btnMostrar.TabIndex = 10
        btnMostrar.Text = "Mostrar/Actualizar"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnEliminar.FlatAppearance.MouseDownBackColor = Color.Chocolate
        btnEliminar.FlatAppearance.MouseOverBackColor = Color.Chocolate
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnEliminar.Location = New Point(13, 389)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 36)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(61, 8)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(384, 23)
        txtBuscar.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 13
        Label5.Text = "Buscar"
        ' 
        ' dgProductos
        ' 
        dgProductos.BackgroundColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        dgProductos.BorderStyle = BorderStyle.None
        dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProductos.Location = New Point(13, 149)
        dgProductos.Name = "dgProductos"
        dgProductos.RowTemplate.Height = 25
        dgProductos.Size = New Size(432, 108)
        dgProductos.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(btnModificar2)
        Panel2.Controls.Add(btnEliminar2)
        Panel2.Controls.Add(btnGuardar2)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(txtStock)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtP_unitario)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txtCorreo)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txtTelefono)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtProducto)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(txtCodigo)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtProveedor)
        Panel2.Controls.Add(btnGuardar)
        Panel2.Controls.Add(btnModificar)
        Panel2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel2.Location = New Point(84, 71)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(658, 322)
        Panel2.TabIndex = 15
        ' 
        ' btnModificar2
        ' 
        btnModificar2.Location = New Point(392, 264)
        btnModificar2.Name = "btnModificar2"
        btnModificar2.Size = New Size(75, 23)
        btnModificar2.TabIndex = 25
        btnModificar2.Text = "Modificar"
        btnModificar2.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar2
        ' 
        btnEliminar2.Location = New Point(292, 264)
        btnEliminar2.Name = "btnEliminar2"
        btnEliminar2.Size = New Size(75, 23)
        btnEliminar2.TabIndex = 24
        btnEliminar2.Text = "Eliminar"
        btnEliminar2.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar2
        ' 
        btnGuardar2.Location = New Point(198, 264)
        btnGuardar2.Name = "btnGuardar2"
        btnGuardar2.Size = New Size(75, 23)
        btnGuardar2.TabIndex = 23
        btnGuardar2.Text = "Guardar"
        btnGuardar2.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label10.Location = New Point(494, 117)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 18)
        Label10.TabIndex = 21
        Label10.Text = "Stock"
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = Color.WhiteSmoke
        txtStock.BorderStyle = BorderStyle.FixedSingle
        txtStock.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtStock.Location = New Point(494, 138)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(99, 27)
        txtStock.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label7.Location = New Point(339, 117)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 18)
        Label7.TabIndex = 15
        Label7.Text = "Precio Unitario"
        ' 
        ' txtP_unitario
        ' 
        txtP_unitario.BackColor = Color.WhiteSmoke
        txtP_unitario.BorderStyle = BorderStyle.FixedSingle
        txtP_unitario.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtP_unitario.Location = New Point(339, 138)
        txtP_unitario.Name = "txtP_unitario"
        txtP_unitario.Size = New Size(127, 27)
        txtP_unitario.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label8.Location = New Point(13, 174)
        Label8.Name = "Label8"
        Label8.Size = New Size(146, 18)
        Label8.TabIndex = 17
        Label8.Text = "Correo Electronico"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BackColor = Color.WhiteSmoke
        txtCorreo.BorderStyle = BorderStyle.FixedSingle
        txtCorreo.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtCorreo.Location = New Point(13, 195)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(297, 27)
        txtCorreo.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label9.Location = New Point(339, 174)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 18)
        Label9.TabIndex = 19
        Label9.Text = "Telofono"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.BackColor = Color.WhiteSmoke
        txtTelefono.BorderStyle = BorderStyle.FixedSingle
        txtTelefono.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtTelefono.Location = New Point(339, 195)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(211, 27)
        txtTelefono.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bell MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label6.Location = New Point(13, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(229, 22)
        Label6.TabIndex = 14
        Label6.Text = "Registrar productos nuevos"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(dtFechaFinAr)
        Panel1.Controls.Add(FechaInicioAr)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(cmbProveedor)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(cmbArticulos)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnLimpiar)
        Panel1.Controls.Add(txtBuscar)
        Panel1.Controls.Add(dgProductos)
        Panel1.Controls.Add(btnMostrar)
        Panel1.Location = New Point(176, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(456, 336)
        Panel1.TabIndex = 16
        ' 
        ' dtFechaFinAr
        ' 
        dtFechaFinAr.Format = DateTimePickerFormat.Short
        dtFechaFinAr.Location = New Point(286, 110)
        dtFechaFinAr.Name = "dtFechaFinAr"
        dtFechaFinAr.Size = New Size(95, 23)
        dtFechaFinAr.TabIndex = 22
        ' 
        ' FechaInicioAr
        ' 
        FechaInicioAr.Format = DateTimePickerFormat.Short
        FechaInicioAr.Location = New Point(94, 113)
        FechaInicioAr.Name = "FechaInicioAr"
        FechaInicioAr.Size = New Size(95, 23)
        FechaInicioAr.TabIndex = 21
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(211, 116)
        Label14.Name = "Label14"
        Label14.Size = New Size(69, 15)
        Label14.TabIndex = 20
        Label14.Text = "Fecha hasta"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(13, 116)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 15)
        Label13.TabIndex = 19
        Label13.Text = "Fecha desde"
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.Location = New Point(324, 56)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(121, 23)
        cmbProveedor.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(244, 64)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 15)
        Label12.TabIndex = 17
        Label12.Text = "Proveedor"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(13, 64)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 15)
        Label11.TabIndex = 16
        Label11.Text = "Articulo"
        ' 
        ' cmbArticulos
        ' 
        cmbArticulos.FormattingEnabled = True
        cmbArticulos.Location = New Point(68, 56)
        cmbArticulos.Name = "cmbArticulos"
        cmbArticulos.Size = New Size(121, 23)
        cmbArticulos.TabIndex = 15
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Stock)
        TabControl1.Controls.Add(NuevoArticulo)
        TabControl1.Location = New Point(172, 129)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(844, 491)
        TabControl1.TabIndex = 17
        ' 
        ' Stock
        ' 
        Stock.Controls.Add(Panel1)
        Stock.Location = New Point(4, 24)
        Stock.Name = "Stock"
        Stock.Padding = New Padding(3)
        Stock.Size = New Size(836, 463)
        Stock.TabIndex = 0
        Stock.Text = "Stock "
        Stock.UseVisualStyleBackColor = True
        ' 
        ' NuevoArticulo
        ' 
        NuevoArticulo.Controls.Add(Panel2)
        NuevoArticulo.Location = New Point(4, 24)
        NuevoArticulo.Name = "NuevoArticulo"
        NuevoArticulo.Padding = New Padding(3)
        NuevoArticulo.Size = New Size(836, 463)
        NuevoArticulo.TabIndex = 1
        NuevoArticulo.Text = "Nuevo articulo"
        NuevoArticulo.UseVisualStyleBackColor = True
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1162, 710)
        Controls.Add(TabControl1)
        Controls.Add(PanelTitulo)
        Name = "FrmProductos"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        CType(dgProductos, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        Stock.ResumeLayout(False)
        NuevoArticulo.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgProductos As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtP_unitario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbArticulos As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Stock As TabPage
    Friend WithEvents NuevoArticulo As TabPage
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents dtFechaFinAr As DateTimePicker
    Friend WithEvents FechaInicioAr As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnModificar2 As Button
    Friend WithEvents btnEliminar2 As Button
    Friend WithEvents btnGuardar2 As Button
End Class
