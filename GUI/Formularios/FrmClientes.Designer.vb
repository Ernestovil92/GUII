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
        PanelTitulo = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        cmbCliente = New ComboBox()
        Label16 = New Label()
        Label9 = New Label()
        Panel2 = New Panel()
        dgArticulos = New DataGridView()
        dtFechaVen = New DateTimePicker()
        txtDescuento = New TextBox()
        txtPrecioVenta = New TextBox()
        txtPrecionCompra = New TextBox()
        txtCantdidad = New TextBox()
        txtArticulo = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        dtFecha = New DateTimePicker()
        Label8 = New Label()
        Label7 = New Label()
        txtNum2 = New TextBox()
        txtNum1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        cmbFactura = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        btnGuardar = New Button()
        btnCancelar = New Button()
        btnNuevo = New Button()
        txtImpuesto = New TextBox()
        txtCodigo = New TextBox()
        Label2 = New Label()
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
        PanelTitulo.SuspendLayout()
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
        PanelTitulo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label1.Location = New Point(626, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 18)
        Label1.TabIndex = 0
        Label1.Text = "Ventas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(cmbCliente)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(dtFecha)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtNum2)
        Panel1.Controls.Add(txtNum1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(cmbFactura)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnGuardar)
        Panel1.Controls.Add(btnCancelar)
        Panel1.Controls.Add(btnNuevo)
        Panel1.Controls.Add(txtImpuesto)
        Panel1.Controls.Add(txtCodigo)
        Panel1.Location = New Point(19, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(784, 282)
        Panel1.TabIndex = 1
        ' 
        ' cmbCliente
        ' 
        cmbCliente.FormattingEnabled = True
        cmbCliente.Location = New Point(279, 10)
        cmbCliente.Name = "cmbCliente"
        cmbCliente.Size = New Size(121, 23)
        cmbCliente.TabIndex = 19
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(3, 260)
        Label16.Name = "Label16"
        Label16.Size = New Size(110, 15)
        Label16.TabIndex = 18
        Label16.Text = "Total pagado S/ 500"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 92)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 15)
        Label9.TabIndex = 0
        Label9.Text = "Articulos"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(dgArticulos)
        Panel2.Controls.Add(dtFechaVen)
        Panel2.Controls.Add(txtDescuento)
        Panel2.Controls.Add(txtPrecioVenta)
        Panel2.Controls.Add(txtPrecionCompra)
        Panel2.Controls.Add(txtCantdidad)
        Panel2.Controls.Add(txtArticulo)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Location = New Point(12, 101)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(760, 156)
        Panel2.TabIndex = 17
        ' 
        ' dgArticulos
        ' 
        dgArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgArticulos.Location = New Point(3, 78)
        dgArticulos.Name = "dgArticulos"
        dgArticulos.RowTemplate.Height = 25
        dgArticulos.Size = New Size(754, 75)
        dgArticulos.TabIndex = 18
        ' 
        ' dtFechaVen
        ' 
        dtFechaVen.Format = DateTimePickerFormat.Short
        dtFechaVen.Location = New Point(590, 14)
        dtFechaVen.Name = "dtFechaVen"
        dtFechaVen.Size = New Size(99, 23)
        dtFechaVen.TabIndex = 17
        ' 
        ' txtDescuento
        ' 
        txtDescuento.Location = New Point(589, 47)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(100, 23)
        txtDescuento.TabIndex = 11
        ' 
        ' txtPrecioVenta
        ' 
        txtPrecioVenta.Location = New Point(345, 42)
        txtPrecioVenta.Name = "txtPrecioVenta"
        txtPrecioVenta.Size = New Size(100, 23)
        txtPrecioVenta.TabIndex = 10
        ' 
        ' txtPrecionCompra
        ' 
        txtPrecionCompra.Location = New Point(345, 17)
        txtPrecionCompra.Name = "txtPrecionCompra"
        txtPrecionCompra.Size = New Size(100, 23)
        txtPrecionCompra.TabIndex = 9
        ' 
        ' txtCantdidad
        ' 
        txtCantdidad.Location = New Point(83, 44)
        txtCantdidad.Name = "txtCantdidad"
        txtCantdidad.Size = New Size(100, 23)
        txtCantdidad.TabIndex = 8
        ' 
        ' txtArticulo
        ' 
        txtArticulo.Location = New Point(84, 14)
        txtArticulo.Name = "txtArticulo"
        txtArticulo.Size = New Size(100, 23)
        txtArticulo.TabIndex = 7
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(461, 50)
        Label15.Name = "Label15"
        Label15.Size = New Size(63, 15)
        Label15.TabIndex = 6
        Label15.Text = "Descuento"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(13, 17)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 15)
        Label14.TabIndex = 5
        Label14.Text = "Articulo"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(12, 44)
        Label13.Name = "Label13"
        Label13.Size = New Size(55, 15)
        Label13.TabIndex = 4
        Label13.Text = "Cantidad"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(219, 17)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 15)
        Label12.TabIndex = 3
        Label12.Text = "Precio de Compra"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(219, 50)
        Label11.Name = "Label11"
        Label11.Size = New Size(88, 15)
        Label11.TabIndex = 2
        Label11.Text = "Precio de venta"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(461, 17)
        Label10.Name = "Label10"
        Label10.Size = New Size(123, 15)
        Label10.TabIndex = 1
        Label10.Text = "Fecha de Vencimiento"
        ' 
        ' dtFecha
        ' 
        dtFecha.Format = DateTimePickerFormat.Short
        dtFecha.Location = New Point(467, 10)
        dtFecha.Name = "dtFecha"
        dtFecha.Size = New Size(98, 23)
        dtFecha.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(423, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 15
        Label8.Text = "Fecha"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(404, 52)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 15)
        Label7.TabIndex = 14
        Label7.Text = "Impuesto"
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(320, 49)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(54, 23)
        txtNum2.TabIndex = 13
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(279, 49)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(35, 23)
        txtNum1.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(222, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 11
        Label6.Text = "Numero"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(222, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 15)
        Label5.TabIndex = 10
        Label5.Text = "Cliente"
        ' 
        ' cmbFactura
        ' 
        cmbFactura.FormattingEnabled = True
        cmbFactura.Location = New Point(109, 49)
        cmbFactura.Name = "cmbFactura"
        cmbFactura.Size = New Size(100, 23)
        cmbFactura.TabIndex = 9
        cmbFactura.Text = "Factura"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 15)
        Label4.TabIndex = 8
        Label4.Text = "Comprobante"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 7
        Label3.Text = "Codigo"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(697, 39)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(697, 68)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 5
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(697, 10)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 4
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' txtImpuesto
        ' 
        txtImpuesto.Location = New Point(467, 44)
        txtImpuesto.Name = "txtImpuesto"
        txtImpuesto.Size = New Size(100, 23)
        txtImpuesto.TabIndex = 2
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(109, 10)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(100, 23)
        txtCodigo.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 0
        Label2.Text = "Ventas"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(20, 314)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(783, 248)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
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
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(775, 220)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Listado"
        TabPage1.UseVisualStyleBackColor = True
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
        tbNuevoCliente.Location = New Point(195, 99)
        tbNuevoCliente.Name = "tbNuevoCliente"
        tbNuevoCliente.SelectedIndex = 0
        tbNuevoCliente.Size = New Size(828, 630)
        tbNuevoCliente.TabIndex = 6
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel1)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(TabControl1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(820, 602)
        TabPage2.TabIndex = 0
        TabPage2.Text = "Ventas"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Panel3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(820, 602)
        TabPage3.TabIndex = 1
        TabPage3.Text = "Nuevo cliente"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
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
        Panel3.Size = New Size(687, 411)
        Panel3.TabIndex = 1
        ' 
        ' btnActualizarCliente
        ' 
        btnActualizarCliente.Location = New Point(77, 359)
        btnActualizarCliente.Name = "btnActualizarCliente"
        btnActualizarCliente.Size = New Size(75, 23)
        btnActualizarCliente.TabIndex = 10
        btnActualizarCliente.Text = "Actualizar"
        btnActualizarCliente.UseVisualStyleBackColor = True
        ' 
        ' dgClientes
        ' 
        dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgClientes.Location = New Point(77, 203)
        dgClientes.Name = "dgClientes"
        dgClientes.RowTemplate.Height = 25
        dgClientes.Size = New Size(532, 150)
        dgClientes.TabIndex = 9
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(511, 95)
        Label23.Name = "Label23"
        Label23.Size = New Size(52, 15)
        Label23.TabIndex = 8
        Label23.Text = "Telefono"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(200, 95)
        Label22.Name = "Label22"
        Label22.Size = New Size(105, 15)
        Label22.TabIndex = 7
        Label22.Text = "Correo Electronico"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(77, 95)
        Label21.Name = "Label21"
        Label21.Size = New Size(27, 15)
        Label21.TabIndex = 6
        Label21.Text = "Ruc"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(77, 44)
        Label20.Name = "Label20"
        Label20.Size = New Size(44, 15)
        Label20.TabIndex = 5
        Label20.Text = "Cliente"
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New Point(77, 113)
        txtRuc.Name = "txtRuc"
        txtRuc.Size = New Size(100, 23)
        txtRuc.TabIndex = 4
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(200, 113)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(288, 23)
        txtCorreo.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(511, 113)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(98, 23)
        txtTelefono.TabIndex = 2
        ' 
        ' txtClienteNuevo
        ' 
        txtClienteNuevo.Location = New Point(77, 62)
        txtClienteNuevo.Name = "txtClienteNuevo"
        txtClienteNuevo.Size = New Size(532, 23)
        txtClienteNuevo.TabIndex = 1
        ' 
        ' BtnGuardarCliente
        ' 
        BtnGuardarCliente.Location = New Point(534, 158)
        BtnGuardarCliente.Name = "BtnGuardarCliente"
        BtnGuardarCliente.Size = New Size(75, 23)
        BtnGuardarCliente.TabIndex = 0
        BtnGuardarCliente.Text = "Guardar"
        BtnGuardarCliente.UseVisualStyleBackColor = True
        ' 
        ' FrmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1162, 710)
        Controls.Add(tbNuevoCliente)
        Controls.Add(PanelTitulo)
        Name = "FrmClientes"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
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
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtFechaVen As DateTimePicker
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
    Friend WithEvents Label10 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbFactura As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
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
    Friend WithEvents cmbCliente As ComboBox
End Class
