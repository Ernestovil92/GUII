﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        txtProveedores = New TextBox()
        Label4 = New Label()
        txtPU = New TextBox()
        Label3 = New Label()
        txtProducto = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        btnCancelar = New Button()
        btnMostrar = New Button()
        txtTelefono = New TextBox()
        Label8 = New Label()
        txtStock = New TextBox()
        Label5 = New Label()
        txtCE = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
        txtId = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(283, 296)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 15
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' txtProveedores
        ' 
        txtProveedores.Location = New Point(16, 168)
        txtProveedores.Name = "txtProveedores"
        txtProveedores.Size = New Size(160, 23)
        txtProveedores.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(20, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 13
        Label4.Text = "Proveedor"
        ' 
        ' txtPU
        ' 
        txtPU.Location = New Point(16, 233)
        txtPU.Name = "txtPU"
        txtPU.Size = New Size(159, 23)
        txtPU.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(19, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 11
        Label3.Text = "Precio Unitario"
        ' 
        ' txtProducto
        ' 
        txtProducto.Location = New Point(14, 103)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(158, 23)
        txtProducto.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 9
        Label2.Text = "Producto"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        Panel1.Controls.Add(btnCancelar)
        Panel1.Controls.Add(btnMostrar)
        Panel1.Controls.Add(txtTelefono)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtStock)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtCE)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(txtProveedores)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtProducto)
        Panel1.Controls.Add(btnActualizar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtPU)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(380, 345)
        Panel1.TabIndex = 18
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(199, 296)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 29
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Location = New Point(95, 31)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(114, 23)
        btnMostrar.TabIndex = 28
        btnMostrar.Text = "Cargar producto"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(200, 103)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(160, 23)
        txtTelefono.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(200, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 15)
        Label8.TabIndex = 26
        Label8.Text = "Telefono"
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(199, 233)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(160, 23)
        txtStock.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(200, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 15)
        Label5.TabIndex = 20
        Label5.Text = "Correo Electronico"
        ' 
        ' txtCE
        ' 
        txtCE.Location = New Point(199, 168)
        txtCE.Name = "txtCE"
        txtCE.Size = New Size(159, 23)
        txtCE.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(200, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 22
        Label6.Text = "Stock"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 18
        Label1.Text = "Codigo"
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
        BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        ClientSize = New Size(403, 367)
        Controls.Add(Panel1)
        Name = "FrmModificarProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Actualizar Productos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtProveedores As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnCancelar As Button
End Class
