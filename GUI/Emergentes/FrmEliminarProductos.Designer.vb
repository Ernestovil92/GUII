<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarProductos
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
        btnEliminar = New Button()
        Label1 = New Label()
        txtId = New TextBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(46, 61)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(110, 23)
        btnEliminar.TabIndex = 0
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nro. de registro"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(46, 32)
        txtId.Name = "txtId"
        txtId.Size = New Size(110, 23)
        txtId.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnEliminar)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 3
        ' 
        ' FrmEliminarProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Sienna
        ClientSize = New Size(229, 124)
        Controls.Add(Panel1)
        Name = "FrmEliminarProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Eliminar Registros"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Panel1 As Panel
End Class
