<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidos
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
        Panel1 = New Panel()
        Label1 = New Label()
        TabControl1 = New TabControl()
        NuevoArticulo = New TabPage()
        Panel3 = New Panel()
        cmbArticulos = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        btnGuardar2 = New Button()
        Label7 = New Label()
        txtPrecio = New TextBox()
        Label8 = New Label()
        txtCorreo = New TextBox()
        Label9 = New Label()
        txtTelefono = New TextBox()
        Label6 = New Label()
        Label2 = New Label()
        btnEliminar = New Button()
        btnGuardar = New Button()
        btnModificar = New Button()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        NuevoArticulo.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1162, 52)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label1.Location = New Point(541, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 18)
        Label1.TabIndex = 1
        Label1.Text = "Pendientes"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(NuevoArticulo)
        TabControl1.Location = New Point(129, 78)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(841, 550)
        TabControl1.TabIndex = 18
        ' 
        ' NuevoArticulo
        ' 
        NuevoArticulo.Controls.Add(Panel3)
        NuevoArticulo.Location = New Point(4, 24)
        NuevoArticulo.Name = "NuevoArticulo"
        NuevoArticulo.Padding = New Padding(3)
        NuevoArticulo.Size = New Size(833, 522)
        NuevoArticulo.TabIndex = 1
        NuevoArticulo.Text = "Nuevo pedido"
        NuevoArticulo.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(cmbArticulos)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(btnGuardar2)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(txtPrecio)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(txtCorreo)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(txtTelefono)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(btnEliminar)
        Panel3.Controls.Add(btnGuardar)
        Panel3.Controls.Add(btnModificar)
        Panel3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel3.Location = New Point(235, 100)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(409, 322)
        Panel3.TabIndex = 15
        ' 
        ' cmbArticulos
        ' 
        cmbArticulos.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbArticulos.FormattingEnabled = True
        cmbArticulos.Location = New Point(13, 87)
        cmbArticulos.Name = "cmbArticulos"
        cmbArticulos.Size = New Size(208, 25)
        cmbArticulos.TabIndex = 26
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(13, 223)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label3.Location = New Point(13, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 18)
        Label3.TabIndex = 24
        Label3.Text = "Fecha de entrega"
        ' 
        ' btnGuardar2
        ' 
        btnGuardar2.Location = New Point(304, 282)
        btnGuardar2.Name = "btnGuardar2"
        btnGuardar2.Size = New Size(75, 23)
        btnGuardar2.TabIndex = 23
        btnGuardar2.Text = "Guardar"
        btnGuardar2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label7.Location = New Point(252, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 18)
        Label7.TabIndex = 15
        Label7.Text = "Precio "
        ' 
        ' txtPrecio
        ' 
        txtPrecio.BackColor = Color.WhiteSmoke
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPrecio.Location = New Point(252, 219)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(127, 27)
        txtPrecio.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label8.Location = New Point(13, 126)
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
        txtCorreo.Location = New Point(13, 147)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(211, 27)
        txtCorreo.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label9.Location = New Point(252, 126)
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
        txtTelefono.Location = New Point(252, 147)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(130, 27)
        txtTelefono.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bell MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label6.Location = New Point(13, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(210, 22)
        Label6.TabIndex = 14
        Label6.Text = "Realizar un nuevo Pedido"
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
        ' FrmPedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(1162, 710)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Name = "FrmPedidos"
        Text = "FrmPedidos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        NuevoArticulo.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents NuevoArticulo As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnGuardar2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbArticulos As ComboBox
End Class
