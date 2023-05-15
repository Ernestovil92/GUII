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
        Label16 = New Label()
        Label9 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        DateTimePicker2 = New DateTimePicker()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label8 = New Label()
        Label7 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        btnGuardar = New Button()
        btnCancelar = New Button()
        btnNuevo = New Button()
        txtNumero = New TextBox()
        txtCliente = New TextBox()
        txtCodigo = New TextBox()
        Label2 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label19 = New Label()
        DataGridView2 = New DataGridView()
        CheckBox1 = New CheckBox()
        Button6 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label18 = New Label()
        Label17 = New Label()
        DateTimePicker4 = New DateTimePicker()
        DateTimePicker3 = New DateTimePicker()
        PanelTitulo.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        PanelTitulo.Controls.Add(Label1)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(808, 52)
        PanelTitulo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label1.Location = New Point(382, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 18)
        Label1.TabIndex = 0
        Label1.Text = "Ventas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnGuardar)
        Panel1.Controls.Add(btnCancelar)
        Panel1.Controls.Add(btnNuevo)
        Panel1.Controls.Add(txtNumero)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(txtCodigo)
        Panel1.Location = New Point(12, 67)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(784, 282)
        Panel1.TabIndex = 1
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
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 78)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(754, 75)
        DataGridView1.TabIndex = 18
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(590, 14)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(153, 23)
        DateTimePicker2.TabIndex = 17
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(529, 44)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 11
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(345, 42)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(345, 17)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(83, 44)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(84, 14)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 7
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
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(467, 10)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(98, 23)
        DateTimePicker1.TabIndex = 16
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
        ' TextBox2
        ' 
        TextBox2.Location = New Point(320, 49)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(54, 23)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(279, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(35, 23)
        TextBox1.TabIndex = 12
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
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(109, 49)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(100, 23)
        ComboBox1.TabIndex = 9
        ComboBox1.Text = "Factura"
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
        ' txtNumero
        ' 
        txtNumero.Location = New Point(467, 44)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(100, 23)
        txtNumero.TabIndex = 2
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(274, 10)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(100, 23)
        txtCliente.TabIndex = 1
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
        Label2.Location = New Point(24, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 0
        Label2.Text = "Ventas"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(13, 354)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(783, 248)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label19)
        TabPage1.Controls.Add(DataGridView2)
        TabPage1.Controls.Add(CheckBox1)
        TabPage1.Controls.Add(Button6)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(Label18)
        TabPage1.Controls.Add(Label17)
        TabPage1.Controls.Add(DateTimePicker4)
        TabPage1.Controls.Add(DateTimePicker3)
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
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(10, 82)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(754, 132)
        DataGridView2.TabIndex = 19
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(18, 57)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(69, 19)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Eliminar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(537, 25)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 10
        Button6.Text = "Imprimir"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(350, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(431, 25)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 23)
        Button2.TabIndex = 8
        Button2.Text = "Comprobante"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(269, 25)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 7
        Button3.Text = "Buscar"
        Button3.UseVisualStyleBackColor = True
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
        ' DateTimePicker4
        ' 
        DateTimePicker4.Format = DateTimePickerFormat.Short
        DateTimePicker4.Location = New Point(133, 25)
        DateTimePicker4.Name = "DateTimePicker4"
        DateTimePicker4.Size = New Size(102, 23)
        DateTimePicker4.TabIndex = 1
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Format = DateTimePickerFormat.Short
        DateTimePicker3.Location = New Point(10, 25)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(102, 23)
        DateTimePicker3.TabIndex = 0
        ' 
        ' FrmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(808, 614)
        Controls.Add(TabControl1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(PanelTitulo)
        Name = "FrmClientes"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label19 As Label
End Class
