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
        Panel1 = New Panel()
        btnEliminar = New Button()
        btnMostrar = New Button()
        dgProductos = New DataGridView()
        btnLimpiar = New Button()
        btnModificar = New Button()
        btnGuardar = New Button()
        txtCliente = New TextBox()
        Label4 = New Label()
        txtCodigo = New TextBox()
        Label3 = New Label()
        txtProducto = New TextBox()
        Label2 = New Label()
        PanelTitulo.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.Sienna
        PanelTitulo.Controls.Add(Label1)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(800, 52)
        PanelTitulo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(326, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 25)
        Label1.TabIndex = 0
        Label1.Text = "Modulo de Ayuda"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnEliminar)
        Panel1.Controls.Add(btnMostrar)
        Panel1.Controls.Add(dgProductos)
        Panel1.Controls.Add(btnLimpiar)
        Panel1.Controls.Add(btnModificar)
        Panel1.Controls.Add(btnGuardar)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtCodigo)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtProducto)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 341)
        Panel1.TabIndex = 2
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(527, 311)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Location = New Point(37, 311)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(129, 23)
        btnMostrar.TabIndex = 10
        btnMostrar.Text = "Mostrar/Actualizar"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' dgProductos
        ' 
        dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProductos.Location = New Point(37, 35)
        dgProductos.Name = "dgProductos"
        dgProductos.RowTemplate.Height = 25
        dgProductos.Size = New Size(409, 270)
        dgProductos.TabIndex = 9
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(172, 311)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(75, 23)
        btnLimpiar.TabIndex = 8
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(608, 311)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 23)
        btnModificar.TabIndex = 7
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(689, 311)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(557, 225)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(160, 23)
        txtCliente.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(616, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 4
        Label4.Text = "Cliente"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(556, 143)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(159, 23)
        txtCodigo.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(614, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 2
        Label3.Text = "Codigo"
        ' 
        ' txtProducto
        ' 
        txtProducto.Location = New Point(557, 64)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(158, 23)
        txtProducto.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(614, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 0
        Label2.Text = "Producto"
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PanelTitulo)
        Name = "FrmProductos"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents dgProductos As DataGridView
    Friend WithEvents btnEliminar As Button
End Class
