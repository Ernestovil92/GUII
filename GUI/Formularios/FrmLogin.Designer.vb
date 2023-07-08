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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Button1 = New Button()
        Label3 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtUsuario = New TextBox()
        txtPassword = New TextBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(22, 280)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 33)
        Button1.TabIndex = 2
        Button1.Text = "Iniciar Sesion"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(110, 338)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 7
        Label3.Text = "Version: 1.0.0.2"
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.Icono_cerrar_FN
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(182, -3)
        Button2.Name = "Button2"
        Button2.Size = New Size(39, 39)
        Button2.TabIndex = 8
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(22, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 19)
        Label2.TabIndex = 6
        Label2.Text = "Clave"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(22, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 19)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.DarkSlateGray
        txtUsuario.BorderStyle = BorderStyle.FixedSingle
        txtUsuario.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsuario.ForeColor = Color.White
        txtUsuario.Location = New Point(22, 158)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(172, 25)
        txtUsuario.TabIndex = 3
        txtUsuario.Text = "admin"
        txtUsuario.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.DarkSlateGray
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(22, 234)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(172, 25)
        txtPassword.TabIndex = 4
        txtPassword.Text = "123"
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(6), CByte(70), CByte(64))
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(36, 34)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(140, 85)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Location = New Point(22, 149)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(86, 3)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Location = New Point(22, 225)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(86, 3)
        Panel2.TabIndex = 10
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(215, 362)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(PictureBox2)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
