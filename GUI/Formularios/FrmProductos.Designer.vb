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
        txtCliente = New TextBox()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnLimpiar = New Button()
        btnMostrar = New Button()
        btnEliminar = New Button()
        txtBuscar = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label6 = New Label()
        dgProductos = New DataGridView()
        PanelTitulo.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        PanelTitulo.Controls.Add(Label1)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(914, 52)
        PanelTitulo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bell MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label1.Location = New Point(419, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 24)
        Label1.TabIndex = 0
        Label1.Text = "Productos"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 0
        Label2.Text = "Producto"
        ' 
        ' txtProducto
        ' 
        txtProducto.Location = New Point(10, 72)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(237, 23)
        txtProducto.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 2
        Label3.Text = "Codigo"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(8, 131)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(237, 23)
        txtCodigo.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 4
        Label4.Text = "Cliente"
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(8, 193)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(237, 23)
        txtCliente.TabIndex = 5
        ' 
        ' btnGuardar
        ' 
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnGuardar.Location = New Point(170, 390)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 36)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnModificar.Location = New Point(91, 390)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 36)
        btnModificar.TabIndex = 7
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnLimpiar.Location = New Point(169, 390)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(72, 36)
        btnLimpiar.TabIndex = 8
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnMostrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnMostrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnMostrar.FlatStyle = FlatStyle.Flat
        btnMostrar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnMostrar.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnMostrar.Location = New Point(34, 390)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(129, 36)
        btnMostrar.TabIndex = 10
        btnMostrar.Text = "Mostrar/Actualizar"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnEliminar.Location = New Point(10, 389)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 36)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(96, 53)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(384, 23)
        txtBuscar.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 13
        Label5.Text = "Buscar"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Chocolate
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtBuscar)
        Panel1.Controls.Add(btnMostrar)
        Panel1.Controls.Add(dgProductos)
        Panel1.Controls.Add(btnLimpiar)
        Panel1.Location = New Point(0, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(657, 457)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtProducto)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(txtCodigo)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtCliente)
        Panel2.Controls.Add(btnGuardar)
        Panel2.Controls.Add(btnModificar)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(653, 52)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(261, 455)
        Panel2.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(49, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 15)
        Label6.TabIndex = 14
        Label6.Text = "Registrar productos nuevos"
        ' 
        ' dgProductos
        ' 
        dgProductos.BackgroundColor = Color.Chocolate
        dgProductos.BorderStyle = BorderStyle.None
        dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProductos.Location = New Point(48, 90)
        dgProductos.Name = "dgProductos"
        dgProductos.RowTemplate.Height = 25
        dgProductos.Size = New Size(442, 241)
        dgProductos.TabIndex = 9
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(914, 507)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PanelTitulo)
        Name = "FrmProductos"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgProductos As DataGridView
End Class
