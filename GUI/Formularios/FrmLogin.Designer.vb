<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        txtUsuario = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.LOGO
        PictureBox2.Location = New Point(32, 42)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(172, 115)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Sienna
        Button1.Location = New Point(32, 326)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 33)
        Button1.TabIndex = 2
        Button1.Text = "Iniciar Sesion"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.Sienna
        txtUsuario.BorderStyle = BorderStyle.FixedSingle
        txtUsuario.Font = New Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsuario.ForeColor = Color.Black
        txtUsuario.Location = New Point(32, 208)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(172, 27)
        txtUsuario.TabIndex = 3
        txtUsuario.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Sienna
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(32, 274)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(172, 27)
        txtPassword.TabIndex = 4
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(145, 376)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 7
        Label3.Text = "Version: 1.0.0.2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(32, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 6
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, 190)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.Icono_cerrar_FN
        Button2.FlatAppearance.BorderColor = Color.Sienna
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(207, -2)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 38)
        Button2.TabIndex = 8
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Sienna
        ClientSize = New Size(241, 402)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
