<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCuenta
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ModificarCuenta))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Button4 = New Button()
        PCambiarContra = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PCambiarContra.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(77, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(158, 258)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 26)
        Button1.TabIndex = 6
        Button1.Text = "Cambiar Datos"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(15, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 15)
        Label3.TabIndex = 5
        Label3.Text = "Confirmar contraseña nueva"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(15, 229)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(221, 23)
        TextBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 3
        Label2.Text = "Usuario "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(15, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 2
        Label1.Text = "Contraseña actual"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(15, 167)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(221, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(15, 105)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(221, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button2.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 23)
        Button2.TabIndex = 8
        Button2.Text = "Cambiar contraseña"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button3.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(119, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 23)
        Button3.TabIndex = 9
        Button3.Text = "Agregar notificaciones"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(347, 25)
        Panel1.TabIndex = 11
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button4.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(253, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(95, 23)
        Button4.TabIndex = 10
        Button4.Text = "Cambiar perfil"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PCambiarContra
        ' 
        PCambiarContra.Controls.Add(TextBox2)
        PCambiarContra.Controls.Add(Label1)
        PCambiarContra.Controls.Add(PictureBox1)
        PCambiarContra.Controls.Add(Label2)
        PCambiarContra.Controls.Add(Button1)
        PCambiarContra.Controls.Add(TextBox1)
        PCambiarContra.Controls.Add(Label3)
        PCambiarContra.Controls.Add(TextBox3)
        PCambiarContra.Location = New Point(46, 31)
        PCambiarContra.Name = "PCambiarContra"
        PCambiarContra.Size = New Size(248, 298)
        PCambiarContra.TabIndex = 12
        ' 
        ' ModificarCuenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ClientSize = New Size(347, 339)
        Controls.Add(PCambiarContra)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ModificarCuenta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Configuraciones"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        PCambiarContra.ResumeLayout(False)
        PCambiarContra.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents PCambiarContra As Panel
End Class
