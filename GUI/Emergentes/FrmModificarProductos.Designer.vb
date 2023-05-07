<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarProductos
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
        btnActualizar = New Button()
        txtCliente = New TextBox()
        Label4 = New Label()
        txtCodigo = New TextBox()
        Label3 = New Label()
        txtProducto = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        txtId = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(200, 287)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 15
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(69, 228)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(160, 23)
        txtCliente.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(128, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 13
        Label4.Text = "Cliente"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(68, 156)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(159, 23)
        txtCodigo.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(126, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 11
        Label3.Text = "Codigo"
        ' 
        ' txtProducto
        ' 
        txtProducto.Location = New Point(69, 90)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(158, 23)
        txtProducto.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(126, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 9
        Label2.Text = "Producto"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtProducto)
        Panel1.Controls.Add(btnActualizar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtCodigo)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(304, 345)
        Panel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 18
        Label1.Text = "Nro.Registro"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(16, 31)
        txtId.Name = "txtId"
        txtId.Size = New Size(73, 23)
        txtId.TabIndex = 19
        ' 
        ' FrmModificarProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Sienna
        ClientSize = New Size(324, 367)
        Controls.Add(Panel1)
        Name = "FrmModificarProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Actualizar Productos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
End Class
