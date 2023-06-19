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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Label2 = New Label()
        txtProducto = New TextBox()
        Label3 = New Label()
        txtCodigo = New TextBox()
        Label4 = New Label()
        txtProveedor = New TextBox()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        dgProductos = New DataGridView()
        Panel2 = New Panel()
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
        FiltrarPro = New Button()
        FiltrarAr = New Button()
        btnMostrar = New Button()
        btnModificar2 = New Button()
        btnEliminar2 = New Button()
        txtCantidadRegistros = New TextBox()
        Label5 = New Label()
        cmbProveedor = New ComboBox()
        Label12 = New Label()
        Label11 = New Label()
        cmbArticulos = New ComboBox()
        TabControl1 = New TabControl()
        Stock = New TabPage()
        NuevoArticulo = New TabPage()
        Panel9 = New Panel()
        Button8 = New Button()
        Button9 = New Button()
        Label15 = New Label()
        Button10 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button7 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label13 = New Label()
        Label14 = New Label()
        Button3 = New Button()
        Button6 = New Button()
        Panel10 = New Panel()
        Button11 = New Button()
        Button12 = New Button()
        Label16 = New Label()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Label17 = New Label()
        Button16 = New Button()
        CType(dgProductos, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        Stock.SuspendLayout()
        NuevoArticulo.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
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
        Label3.ForeColor = Color.White
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
        Label4.ForeColor = Color.White
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
        ' dgProductos
        ' 
        dgProductos.BackgroundColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProductos.GridColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        dgProductos.Location = New Point(54, 116)
        dgProductos.Name = "dgProductos"
        dgProductos.RowTemplate.Height = 25
        dgProductos.Size = New Size(644, 219)
        dgProductos.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
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
        Panel2.Location = New Point(243, 134)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(658, 322)
        Panel2.TabIndex = 15
        ' 
        ' btnGuardar2
        ' 
        btnGuardar2.ForeColor = Color.Black
        btnGuardar2.Location = New Point(557, 264)
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
        Label10.ForeColor = Color.White
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
        Label7.ForeColor = Color.White
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
        Label8.ForeColor = Color.White
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
        Label9.ForeColor = Color.White
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
        Label6.ForeColor = Color.White
        Label6.Location = New Point(13, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(229, 22)
        Label6.TabIndex = 14
        Label6.Text = "Registrar productos nuevos"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(FiltrarPro)
        Panel1.Controls.Add(FiltrarAr)
        Panel1.Controls.Add(btnMostrar)
        Panel1.Controls.Add(btnModificar2)
        Panel1.Controls.Add(btnEliminar2)
        Panel1.Controls.Add(txtCantidadRegistros)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(cmbProveedor)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(cmbArticulos)
        Panel1.Controls.Add(dgProductos)
        Panel1.Location = New Point(189, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(737, 449)
        Panel1.TabIndex = 16
        ' 
        ' FiltrarPro
        ' 
        FiltrarPro.Location = New Point(504, 72)
        FiltrarPro.Name = "FiltrarPro"
        FiltrarPro.Size = New Size(75, 23)
        FiltrarPro.TabIndex = 31
        FiltrarPro.Text = "Filtrar"
        FiltrarPro.UseVisualStyleBackColor = True
        ' 
        ' FiltrarAr
        ' 
        FiltrarAr.Location = New Point(211, 72)
        FiltrarAr.Name = "FiltrarAr"
        FiltrarAr.Size = New Size(75, 23)
        FiltrarAr.TabIndex = 30
        FiltrarAr.Text = "Filtrar"
        FiltrarAr.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Location = New Point(472, 387)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(75, 23)
        btnMostrar.TabIndex = 28
        btnMostrar.Text = "Actualizar "
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar2
        ' 
        btnModificar2.Location = New Point(634, 387)
        btnModificar2.Name = "btnModificar2"
        btnModificar2.Size = New Size(75, 23)
        btnModificar2.TabIndex = 27
        btnModificar2.Text = "Modificar"
        btnModificar2.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar2
        ' 
        btnEliminar2.Location = New Point(553, 387)
        btnEliminar2.Name = "btnEliminar2"
        btnEliminar2.Size = New Size(75, 23)
        btnEliminar2.TabIndex = 26
        btnEliminar2.Text = "Eliminar"
        btnEliminar2.UseVisualStyleBackColor = True
        ' 
        ' txtCantidadRegistros
        ' 
        txtCantidadRegistros.Location = New Point(179, 353)
        txtCantidadRegistros.Name = "txtCantidadRegistros"
        txtCantidadRegistros.Size = New Size(41, 25)
        txtCantidadRegistros.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(54, 356)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 17)
        Label5.TabIndex = 24
        Label5.Text = "Cantidad de registros"
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.Location = New Point(377, 72)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(121, 25)
        cmbProveedor.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(310, 75)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 17)
        Label12.TabIndex = 17
        Label12.Text = "Proveedor"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(29, 75)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 17)
        Label11.TabIndex = 16
        Label11.Text = "Articulo"
        ' 
        ' cmbArticulos
        ' 
        cmbArticulos.FormattingEnabled = True
        cmbArticulos.Location = New Point(84, 72)
        cmbArticulos.Name = "cmbArticulos"
        cmbArticulos.Size = New Size(121, 25)
        cmbArticulos.TabIndex = 15
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Stock)
        TabControl1.Controls.Add(NuevoArticulo)
        TabControl1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.ImeMode = ImeMode.NoControl
        TabControl1.Location = New Point(12, 56)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeft = RightToLeft.No
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1124, 617)
        TabControl1.TabIndex = 17
        ' 
        ' Stock
        ' 
        Stock.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        Stock.Controls.Add(Panel1)
        Stock.Location = New Point(4, 26)
        Stock.Name = "Stock"
        Stock.Padding = New Padding(3)
        Stock.Size = New Size(1116, 587)
        Stock.TabIndex = 0
        Stock.Text = "Stock "
        ' 
        ' NuevoArticulo
        ' 
        NuevoArticulo.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        NuevoArticulo.Controls.Add(Panel2)
        NuevoArticulo.Location = New Point(4, 26)
        NuevoArticulo.Name = "NuevoArticulo"
        NuevoArticulo.Padding = New Padding(3)
        NuevoArticulo.Size = New Size(1116, 587)
        NuevoArticulo.TabIndex = 1
        NuevoArticulo.Text = "Nuevo articulo"
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel9.Controls.Add(Button8)
        Panel9.Controls.Add(Button9)
        Panel9.Controls.Add(Label15)
        Panel9.Controls.Add(Button10)
        Panel9.Controls.Add(Button1)
        Panel9.Controls.Add(Button2)
        Panel9.Controls.Add(Label1)
        Panel9.Controls.Add(Button7)
        Panel9.Controls.Add(Button4)
        Panel9.Controls.Add(Button5)
        Panel9.Controls.Add(Label13)
        Panel9.Controls.Add(Label14)
        Panel9.Controls.Add(Button3)
        Panel9.Controls.Add(Button6)
        Panel9.Location = New Point(1, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1135, 50)
        Panel9.TabIndex = 18
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
        Button8.Location = New Point(949, 12)
        Button8.Name = "Button8"
        Button8.Size = New Size(29, 28)
        Button8.TabIndex = 27
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
        Button9.Location = New Point(977, 12)
        Button9.Name = "Button9"
        Button9.Size = New Size(29, 28)
        Button9.TabIndex = 28
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.ForeColor = Color.White
        Label15.Location = New Point(1003, 17)
        Label15.Name = "Label15"
        Label15.Size = New Size(98, 17)
        Label15.TabIndex = 29
        Label15.Text = "Ernesto Villalba"
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
        Button10.Location = New Point(1103, 12)
        Button10.Name = "Button10"
        Button10.Size = New Size(29, 28)
        Button10.TabIndex = 26
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1911, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 28)
        Button1.TabIndex = 23
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1939, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(29, 28)
        Button2.TabIndex = 24
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1965, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 17)
        Label1.TabIndex = 25
        Label1.Text = "Ernesto Villalba"
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button7.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(2059, 14)
        Button7.Name = "Button7"
        Button7.Size = New Size(29, 28)
        Button7.TabIndex = 22
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(2638, 10)
        Button4.Name = "Button4"
        Button4.Size = New Size(29, 28)
        Button4.TabIndex = 8
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button5.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(2666, 10)
        Button5.Name = "Button5"
        Button5.Size = New Size(29, 28)
        Button5.TabIndex = 9
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(2692, 15)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 17)
        Label13.TabIndex = 21
        Label13.Text = "Ernesto Villalba"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(46, 17)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 17)
        Label14.TabIndex = 20
        Label14.Text = "Productos"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(2786, 12)
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
        ' Panel10
        ' 
        Panel10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel10.BackColor = Color.FromArgb(CByte(0), CByte(20), CByte(20))
        Panel10.Controls.Add(Button11)
        Panel10.Controls.Add(Button12)
        Panel10.Controls.Add(Label16)
        Panel10.Controls.Add(Button13)
        Panel10.Controls.Add(Button14)
        Panel10.Controls.Add(Button15)
        Panel10.Controls.Add(Label17)
        Panel10.Controls.Add(Button16)
        Panel10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel10.Location = New Point(0, 50)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(1135, 5)
        Panel10.TabIndex = 27
        ' 
        ' Button11
        ' 
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button11.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button11.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button11.FlatStyle = FlatStyle.Flat
        Button11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.Location = New Point(4797, 12)
        Button11.Name = "Button11"
        Button11.Size = New Size(29, 28)
        Button11.TabIndex = 23
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button12.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button12.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button12.FlatStyle = FlatStyle.Flat
        Button12.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.Image = CType(resources.GetObject("Button12.Image"), Image)
        Button12.Location = New Point(4825, 12)
        Button12.Name = "Button12"
        Button12.Size = New Size(29, 28)
        Button12.TabIndex = 24
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(4851, 17)
        Label16.Name = "Label16"
        Label16.Size = New Size(98, 17)
        Label16.TabIndex = 25
        Label16.Text = "Ernesto Villalba"
        ' 
        ' Button13
        ' 
        Button13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button13.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button13.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button13.FlatStyle = FlatStyle.Flat
        Button13.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(4951, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(29, 28)
        Button13.TabIndex = 22
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button14.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button14.FlatStyle = FlatStyle.Flat
        Button14.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button14.Image = CType(resources.GetObject("Button14.Image"), Image)
        Button14.Location = New Point(5524, 10)
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
        Button15.Location = New Point(5552, 10)
        Button15.Name = "Button15"
        Button15.Size = New Size(29, 28)
        Button15.TabIndex = 9
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.ForeColor = Color.White
        Label17.Location = New Point(5578, 15)
        Label17.Name = "Label17"
        Label17.Size = New Size(98, 17)
        Label17.TabIndex = 21
        Label17.Text = "Ernesto Villalba"
        ' 
        ' Button16
        ' 
        Button16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button16.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button16.FlatStyle = FlatStyle.Flat
        Button16.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button16.Image = CType(resources.GetObject("Button16.Image"), Image)
        Button16.Location = New Point(5672, 12)
        Button16.Name = "Button16"
        Button16.Size = New Size(29, 28)
        Button16.TabIndex = 7
        Button16.UseVisualStyleBackColor = False
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        ClientSize = New Size(1135, 678)
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        Controls.Add(TabControl1)
        Name = "FrmProductos"
        StartPosition = FormStartPosition.CenterScreen
        CType(dgProductos, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        Stock.ResumeLayout(False)
        NuevoArticulo.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
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
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbArticulos As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Stock As TabPage
    Friend WithEvents NuevoArticulo As TabPage
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents btnGuardar2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidadRegistros As TextBox
    Friend WithEvents btnModificar2 As Button
    Friend WithEvents btnEliminar2 As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents FiltrarPro As Button
    Friend WithEvents FiltrarAr As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Button16 As Button
End Class
