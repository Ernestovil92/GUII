<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Panel1 = New Panel()
        Label16 = New Label()
        Label9 = New Label()
        Panel2 = New Panel()
        cmbCliente = New ComboBox()
        dgArticulos = New DataGridView()
        txtDescuento = New TextBox()
        txtPrecioVenta = New TextBox()
        txtPrecionCompra = New TextBox()
        txtCantdidad = New TextBox()
        Label5 = New Label()
        txtArticulo = New TextBox()
        Label3 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        txtCodigoCliente = New TextBox()
        Label11 = New Label()
        btnGuardar = New Button()
        btnCancelar = New Button()
        btnNuevo = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label19 = New Label()
        dgListas = New DataGridView()
        chEliminar = New CheckBox()
        btnImprimir = New Button()
        btnEliminar = New Button()
        btnComprobante = New Button()
        btnBuscar = New Button()
        Label18 = New Label()
        Label17 = New Label()
        dtFechaFin = New DateTimePicker()
        dtFechaIni = New DateTimePicker()
        tbNuevoCliente = New TabControl()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        Panel3 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        txtId = New TextBox()
        btnActualizarCliente = New Button()
        dgClientes = New DataGridView()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        txtRuc = New TextBox()
        txtCorreo = New TextBox()
        txtTelefono = New TextBox()
        txtClienteNuevo = New TextBox()
        BtnGuardarCliente = New Button()
        Panel9 = New Panel()
        Button8 = New Button()
        Button9 = New Button()
        Label10 = New Label()
        Button10 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button7 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Button3 = New Button()
        Button6 = New Button()
        Panel7 = New Panel()
        Button11 = New Button()
        Button12 = New Button()
        Label24 = New Label()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Label25 = New Label()
        Button16 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgArticulos, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgListas, ComponentModel.ISupportInitialize).BeginInit()
        tbNuevoCliente.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgClientes, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btnGuardar)
        Panel1.Controls.Add(btnCancelar)
        Panel1.Controls.Add(btnNuevo)
        Panel1.Location = New Point(168, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(780, 282)
        Panel1.TabIndex = 1
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.ForeColor = Color.White
        Label16.Location = New Point(19, 251)
        Label16.Name = "Label16"
        Label16.Size = New Size(110, 15)
        Label16.TabIndex = 18
        Label16.Text = "Total pagado S/ 500"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(28, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 15)
        Label9.TabIndex = 0
        Label9.Text = "Articulos"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(cmbCliente)
        Panel2.Controls.Add(dgArticulos)
        Panel2.Controls.Add(txtDescuento)
        Panel2.Controls.Add(txtPrecioVenta)
        Panel2.Controls.Add(txtPrecionCompra)
        Panel2.Controls.Add(txtCantdidad)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtArticulo)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(txtCodigoCliente)
        Panel2.Controls.Add(Label11)
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(19, 35)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(639, 213)
        Panel2.TabIndex = 17
        ' 
        ' cmbCliente
        ' 
        cmbCliente.FormattingEnabled = True
        cmbCliente.Location = New Point(325, 13)
        cmbCliente.Name = "cmbCliente"
        cmbCliente.Size = New Size(300, 23)
        cmbCliente.TabIndex = 19
        ' 
        ' dgArticulos
        ' 
        dgArticulos.BackgroundColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        dgArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgArticulos.Location = New Point(3, 105)
        dgArticulos.Name = "dgArticulos"
        dgArticulos.RowTemplate.Height = 25
        dgArticulos.Size = New Size(625, 103)
        dgArticulos.TabIndex = 18
        ' 
        ' txtDescuento
        ' 
        txtDescuento.Location = New Point(525, 44)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(100, 23)
        txtDescuento.TabIndex = 11
        ' 
        ' txtPrecioVenta
        ' 
        txtPrecioVenta.Location = New Point(325, 76)
        txtPrecioVenta.Name = "txtPrecioVenta"
        txtPrecioVenta.Size = New Size(100, 23)
        txtPrecioVenta.TabIndex = 10
        ' 
        ' txtPrecionCompra
        ' 
        txtPrecionCompra.Location = New Point(325, 44)
        txtPrecionCompra.Name = "txtPrecionCompra"
        txtPrecionCompra.Size = New Size(100, 23)
        txtPrecionCompra.TabIndex = 9
        ' 
        ' txtCantdidad
        ' 
        txtCantdidad.Location = New Point(84, 76)
        txtCantdidad.Name = "txtCantdidad"
        txtCantdidad.Size = New Size(100, 23)
        txtCantdidad.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(200, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 15)
        Label5.TabIndex = 10
        Label5.Text = "Cliente"
        ' 
        ' txtArticulo
        ' 
        txtArticulo.Location = New Point(84, 44)
        txtArticulo.Name = "txtArticulo"
        txtArticulo.Size = New Size(100, 23)
        txtArticulo.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(13, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 7
        Label3.Text = "Codigo"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(452, 47)
        Label15.Name = "Label15"
        Label15.Size = New Size(63, 15)
        Label15.TabIndex = 6
        Label15.Text = "Descuento"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(13, 47)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 15)
        Label14.TabIndex = 5
        Label14.Text = "Articulo"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(13, 76)
        Label13.Name = "Label13"
        Label13.Size = New Size(55, 15)
        Label13.TabIndex = 4
        Label13.Text = "Cantidad"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(199, 47)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 15)
        Label12.TabIndex = 3
        Label12.Text = "Precio de Compra"
        ' 
        ' txtCodigoCliente
        ' 
        txtCodigoCliente.Location = New Point(84, 13)
        txtCodigoCliente.Name = "txtCodigoCliente"
        txtCodigoCliente.Size = New Size(100, 23)
        txtCodigoCliente.TabIndex = 0
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(200, 79)
        Label11.Name = "Label11"
        Label11.Size = New Size(88, 15)
        Label11.TabIndex = 2
        Label11.Text = "Precio de venta"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(682, 64)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(682, 93)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 5
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(682, 35)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 4
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(169, 323)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(783, 248)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage1.Controls.Add(Label19)
        TabPage1.Controls.Add(dgListas)
        TabPage1.Controls.Add(chEliminar)
        TabPage1.Controls.Add(btnImprimir)
        TabPage1.Controls.Add(btnEliminar)
        TabPage1.Controls.Add(btnComprobante)
        TabPage1.Controls.Add(btnBuscar)
        TabPage1.Controls.Add(Label18)
        TabPage1.Controls.Add(Label17)
        TabPage1.Controls.Add(dtFechaFin)
        TabPage1.Controls.Add(dtFechaIni)
        TabPage1.ForeColor = Color.White
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(775, 220)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Listado"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(299, 58)
        Label19.Name = "Label19"
        Label19.Size = New Size(86, 15)
        Label19.TabIndex = 20
        Label19.Text = "Total registros: "
        ' 
        ' dgListas
        ' 
        dgListas.BackgroundColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        dgListas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgListas.Location = New Point(10, 82)
        dgListas.Name = "dgListas"
        dgListas.RowTemplate.Height = 25
        dgListas.Size = New Size(754, 132)
        dgListas.TabIndex = 19
        ' 
        ' chEliminar
        ' 
        chEliminar.AutoSize = True
        chEliminar.Location = New Point(18, 57)
        chEliminar.Name = "chEliminar"
        chEliminar.Size = New Size(69, 19)
        chEliminar.TabIndex = 11
        chEliminar.Text = "Eliminar"
        chEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnImprimir
        ' 
        btnImprimir.Location = New Point(537, 25)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(75, 23)
        btnImprimir.TabIndex = 10
        btnImprimir.Text = "Imprimir"
        btnImprimir.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(350, 25)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnComprobante
        ' 
        btnComprobante.Location = New Point(431, 25)
        btnComprobante.Name = "btnComprobante"
        btnComprobante.Size = New Size(100, 23)
        btnComprobante.TabIndex = 8
        btnComprobante.Text = "Comprobante"
        btnComprobante.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(269, 25)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 7
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(158, 7)
        Label18.Name = "Label18"
        Label18.Size = New Size(55, 15)
        Label18.TabIndex = 6
        Label18.Text = "Fecha fin"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.ForeColor = Color.White
        Label17.Location = New Point(20, 7)
        Label17.Name = "Label17"
        Label17.Size = New Size(70, 15)
        Label17.TabIndex = 5
        Label17.Text = "Fecha inicio"
        ' 
        ' dtFechaFin
        ' 
        dtFechaFin.Format = DateTimePickerFormat.Short
        dtFechaFin.Location = New Point(133, 25)
        dtFechaFin.Name = "dtFechaFin"
        dtFechaFin.Size = New Size(102, 23)
        dtFechaFin.TabIndex = 1
        ' 
        ' dtFechaIni
        ' 
        dtFechaIni.Format = DateTimePickerFormat.Short
        dtFechaIni.Location = New Point(10, 25)
        dtFechaIni.Name = "dtFechaIni"
        dtFechaIni.Size = New Size(102, 23)
        dtFechaIni.TabIndex = 0
        ' 
        ' tbNuevoCliente
        ' 
        tbNuevoCliente.Controls.Add(TabPage2)
        tbNuevoCliente.Controls.Add(TabPage3)
        tbNuevoCliente.Location = New Point(12, 56)
        tbNuevoCliente.Name = "tbNuevoCliente"
        tbNuevoCliente.SelectedIndex = 0
        tbNuevoCliente.Size = New Size(1124, 617)
        tbNuevoCliente.TabIndex = 6
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        TabPage2.Controls.Add(Panel1)
        TabPage2.Controls.Add(TabControl1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1116, 589)
        TabPage2.TabIndex = 0
        TabPage2.Text = "Ventas"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Panel3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1116, 589)
        TabPage3.TabIndex = 1
        TabPage3.Text = "Nuevo cliente"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtId)
        Panel3.Controls.Add(btnActualizarCliente)
        Panel3.Controls.Add(dgClientes)
        Panel3.Controls.Add(Label23)
        Panel3.Controls.Add(Label22)
        Panel3.Controls.Add(Label21)
        Panel3.Controls.Add(Label20)
        Panel3.Controls.Add(txtRuc)
        Panel3.Controls.Add(txtCorreo)
        Panel3.Controls.Add(txtTelefono)
        Panel3.Controls.Add(txtClienteNuevo)
        Panel3.Controls.Add(BtnGuardarCliente)
        Panel3.Location = New Point(21, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(687, 483)
        Panel3.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bell MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label6.Location = New Point(231, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(209, 22)
        Label6.TabIndex = 15
        Label6.Text = "Registrar clientes nuevos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(75, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 12
        Label4.Text = "Codigo de cliente"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(75, 95)
        txtId.Name = "txtId"
        txtId.Size = New Size(100, 23)
        txtId.TabIndex = 11
        ' 
        ' btnActualizarCliente
        ' 
        btnActualizarCliente.Location = New Point(79, 419)
        btnActualizarCliente.Name = "btnActualizarCliente"
        btnActualizarCliente.Size = New Size(75, 23)
        btnActualizarCliente.TabIndex = 10
        btnActualizarCliente.Text = "Actualizar"
        btnActualizarCliente.UseVisualStyleBackColor = True
        ' 
        ' dgClientes
        ' 
        dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgClientes.Location = New Point(79, 263)
        dgClientes.Name = "dgClientes"
        dgClientes.RowTemplate.Height = 25
        dgClientes.Size = New Size(532, 150)
        dgClientes.TabIndex = 9
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(513, 183)
        Label23.Name = "Label23"
        Label23.Size = New Size(52, 15)
        Label23.TabIndex = 8
        Label23.Text = "Telefono"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(202, 183)
        Label22.Name = "Label22"
        Label22.Size = New Size(105, 15)
        Label22.TabIndex = 7
        Label22.Text = "Correo Electronico"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(79, 183)
        Label21.Name = "Label21"
        Label21.Size = New Size(27, 15)
        Label21.TabIndex = 6
        Label21.Text = "Ruc"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(79, 132)
        Label20.Name = "Label20"
        Label20.Size = New Size(44, 15)
        Label20.TabIndex = 5
        Label20.Text = "Cliente"
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New Point(79, 201)
        txtRuc.Name = "txtRuc"
        txtRuc.Size = New Size(100, 23)
        txtRuc.TabIndex = 4
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(202, 201)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(288, 23)
        txtCorreo.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(513, 201)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(98, 23)
        txtTelefono.TabIndex = 2
        ' 
        ' txtClienteNuevo
        ' 
        txtClienteNuevo.Location = New Point(79, 150)
        txtClienteNuevo.Name = "txtClienteNuevo"
        txtClienteNuevo.Size = New Size(532, 23)
        txtClienteNuevo.TabIndex = 1
        ' 
        ' BtnGuardarCliente
        ' 
        BtnGuardarCliente.Location = New Point(540, 231)
        BtnGuardarCliente.Name = "BtnGuardarCliente"
        BtnGuardarCliente.Size = New Size(75, 23)
        BtnGuardarCliente.TabIndex = 0
        BtnGuardarCliente.Text = "Guardar"
        BtnGuardarCliente.UseVisualStyleBackColor = True
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel9.Controls.Add(Button8)
        Panel9.Controls.Add(Button9)
        Panel9.Controls.Add(Label10)
        Panel9.Controls.Add(Button10)
        Panel9.Controls.Add(Button1)
        Panel9.Controls.Add(Button2)
        Panel9.Controls.Add(Label1)
        Panel9.Controls.Add(Button7)
        Panel9.Controls.Add(Button4)
        Panel9.Controls.Add(Button5)
        Panel9.Controls.Add(Label7)
        Panel9.Controls.Add(Label8)
        Panel9.Controls.Add(Button3)
        Panel9.Controls.Add(Button6)
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1163, 50)
        Panel9.TabIndex = 8
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
        Button8.Location = New Point(976, 12)
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
        Button9.Location = New Point(1004, 12)
        Button9.Name = "Button9"
        Button9.Size = New Size(29, 28)
        Button9.TabIndex = 28
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(1030, 17)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 17)
        Label10.TabIndex = 29
        Label10.Text = "Ernesto Villalba"
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
        Button10.Location = New Point(1124, 14)
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
        Button1.Location = New Point(1939, 12)
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
        Button2.Location = New Point(1967, 12)
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
        Label1.Location = New Point(1993, 17)
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
        Button7.Location = New Point(2087, 14)
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
        Button4.Location = New Point(2666, 10)
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
        Button5.Location = New Point(2694, 10)
        Button5.Name = "Button5"
        Button5.Size = New Size(29, 28)
        Button5.TabIndex = 9
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(2720, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 17)
        Label7.TabIndex = 21
        Label7.Text = "Ernesto Villalba"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(46, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 17)
        Label8.TabIndex = 20
        Label8.Text = "Clientes"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(2814, 12)
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
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel7.BackColor = Color.FromArgb(CByte(0), CByte(20), CByte(20))
        Panel7.Controls.Add(Button11)
        Panel7.Controls.Add(Button12)
        Panel7.Controls.Add(Label24)
        Panel7.Controls.Add(Button13)
        Panel7.Controls.Add(Button14)
        Panel7.Controls.Add(Button15)
        Panel7.Controls.Add(Label25)
        Panel7.Controls.Add(Button16)
        Panel7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel7.Location = New Point(0, 50)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1162, 5)
        Panel7.TabIndex = 10
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
        Button11.Location = New Point(3862, 12)
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
        Button12.Location = New Point(3890, 12)
        Button12.Name = "Button12"
        Button12.Size = New Size(29, 28)
        Button12.TabIndex = 24
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.ForeColor = Color.White
        Label24.Location = New Point(3916, 17)
        Label24.Name = "Label24"
        Label24.Size = New Size(98, 17)
        Label24.TabIndex = 25
        Label24.Text = "Ernesto Villalba"
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
        Button13.Location = New Point(4016, 12)
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
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label25.ForeColor = Color.White
        Label25.Location = New Point(4643, 15)
        Label25.Name = "Label25"
        Label25.Size = New Size(98, 17)
        Label25.TabIndex = 21
        Label25.Text = "Ernesto Villalba"
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
        ' FrmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        ClientSize = New Size(1162, 710)
        Controls.Add(Panel7)
        Controls.Add(Panel9)
        Controls.Add(tbNuevoCliente)
        Name = "FrmClientes"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgArticulos, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgListas, ComponentModel.ISupportInitialize).EndInit()
        tbNuevoCliente.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgClientes, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtPrecionCompra As TextBox
    Friend WithEvents txtCantdidad As TextBox
    Friend WithEvents txtArticulo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgListas As DataGridView
    Friend WithEvents chEliminar As CheckBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnComprobante As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtFechaFin As DateTimePicker
    Friend WithEvents dtFechaIni As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents tbNuevoCliente As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtClienteNuevo As TextBox
    Friend WithEvents BtnGuardarCliente As Button
    Friend WithEvents btnActualizarCliente As Button
    Friend WithEvents dgClientes As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Button16 As Button
End Class
