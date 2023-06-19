<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Panel9 = New Panel()
        btnCampanaRoja = New Button()
        btnCampanaBlanca = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Button7 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        Button6 = New Button()
        Panel1 = New Panel()
        Button8 = New Button()
        Button9 = New Button()
        Label4 = New Label()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Label5 = New Label()
        Button13 = New Button()
        Panel11 = New Panel()
        lblHora = New Label()
        lblFecha = New Label()
        Timer1 = New Timer(components)
        PAdmin = New Panel()
        btnCS = New Button()
        btnCuenta = New Button()
        Panel9.SuspendLayout()
        Panel1.SuspendLayout()
        Panel11.SuspendLayout()
        PAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel9.Controls.Add(btnCampanaRoja)
        Panel9.Controls.Add(btnCampanaBlanca)
        Panel9.Controls.Add(Button2)
        Panel9.Controls.Add(Label3)
        Panel9.Controls.Add(Button7)
        Panel9.Controls.Add(Button4)
        Panel9.Controls.Add(Button5)
        Panel9.Controls.Add(Label2)
        Panel9.Controls.Add(Label1)
        Panel9.Controls.Add(Button3)
        Panel9.Controls.Add(Button6)
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1162, 50)
        Panel9.TabIndex = 7
        ' 
        ' btnCampanaRoja
        ' 
        btnCampanaRoja.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCampanaRoja.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCampanaRoja.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCampanaRoja.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        btnCampanaRoja.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        btnCampanaRoja.FlatStyle = FlatStyle.Flat
        btnCampanaRoja.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCampanaRoja.Image = CType(resources.GetObject("btnCampanaRoja.Image"), Image)
        btnCampanaRoja.Location = New Point(976, 12)
        btnCampanaRoja.Name = "btnCampanaRoja"
        btnCampanaRoja.Size = New Size(29, 28)
        btnCampanaRoja.TabIndex = 26
        btnCampanaRoja.UseVisualStyleBackColor = False
        ' 
        ' btnCampanaBlanca
        ' 
        btnCampanaBlanca.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCampanaBlanca.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCampanaBlanca.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCampanaBlanca.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        btnCampanaBlanca.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        btnCampanaBlanca.FlatStyle = FlatStyle.Flat
        btnCampanaBlanca.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCampanaBlanca.Image = CType(resources.GetObject("btnCampanaBlanca.Image"), Image)
        btnCampanaBlanca.Location = New Point(976, 12)
        btnCampanaBlanca.Name = "btnCampanaBlanca"
        btnCampanaBlanca.Size = New Size(29, 28)
        btnCampanaBlanca.TabIndex = 23
        btnCampanaBlanca.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button2.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1004, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(29, 28)
        Button2.TabIndex = 24
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1030, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 17)
        Label3.TabIndex = 25
        Label3.Text = "Ernesto Villalba"
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button7.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button7.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(1130, 12)
        Button7.Name = "Button7"
        Button7.Size = New Size(29, 28)
        Button7.TabIndex = 22
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(1703, 10)
        Button4.Name = "Button4"
        Button4.Size = New Size(29, 28)
        Button4.TabIndex = 8
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button5.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(1731, 10)
        Button5.Name = "Button5"
        Button5.Size = New Size(29, 28)
        Button5.TabIndex = 9
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1757, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 17)
        Label2.TabIndex = 21
        Label2.Text = "Ernesto Villalba"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(46, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 17)
        Label1.TabIndex = 20
        Label1.Text = "Home"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(1851, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 28)
        Button3.TabIndex = 7
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button6.Enabled = False
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(6, 10)
        Button6.Name = "Button6"
        Button6.Size = New Size(29, 28)
        Button6.TabIndex = 10
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(20), CByte(20))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button10)
        Panel1.Controls.Add(Button11)
        Panel1.Controls.Add(Button12)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button13)
        Panel1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Location = New Point(0, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1162, 5)
        Panel1.TabIndex = 8
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button8.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button8.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button8.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button8.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button8.FlatStyle = FlatStyle.Flat
        Button8.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.Location = New Point(1936, 12)
        Button8.Name = "Button8"
        Button8.Size = New Size(29, 28)
        Button8.TabIndex = 23
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button9.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button9.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button9.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button9.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button9.FlatStyle = FlatStyle.Flat
        Button9.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.Location = New Point(1964, 12)
        Button9.Name = "Button9"
        Button9.Size = New Size(29, 28)
        Button9.TabIndex = 24
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(1990, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 17)
        Label4.TabIndex = 25
        Label4.Text = "Ernesto Villalba"
        ' 
        ' Button10
        ' 
        Button10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button10.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button10.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button10.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button10.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button10.FlatStyle = FlatStyle.Flat
        Button10.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.Location = New Point(2090, 12)
        Button10.Name = "Button10"
        Button10.Size = New Size(29, 28)
        Button10.TabIndex = 22
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button11.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.FlatStyle = FlatStyle.Flat
        Button11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.Location = New Point(2663, 10)
        Button11.Name = "Button11"
        Button11.Size = New Size(29, 28)
        Button11.TabIndex = 8
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button12.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.FlatStyle = FlatStyle.Flat
        Button12.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.Image = CType(resources.GetObject("Button12.Image"), Image)
        Button12.Location = New Point(2691, 10)
        Button12.Name = "Button12"
        Button12.Size = New Size(29, 28)
        Button12.TabIndex = 9
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(2717, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 17)
        Label5.TabIndex = 21
        Label5.Text = "Ernesto Villalba"
        ' 
        ' Button13
        ' 
        Button13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button13.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.FlatStyle = FlatStyle.Flat
        Button13.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(2811, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(29, 28)
        Button13.TabIndex = 7
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(lblHora)
        Panel11.Controls.Add(lblFecha)
        Panel11.Location = New Point(293, 316)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(540, 105)
        Panel11.TabIndex = 13
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Perpetua Titling MT", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblHora.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        lblHora.Location = New Point(214, 6)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(127, 38)
        lblHora.TabIndex = 1
        lblHora.Text = "03:05:15"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Perpetua Titling MT", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblFecha.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        lblFecha.Location = New Point(3, 44)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(528, 38)
        lblFecha.TabIndex = 0
        lblFecha.Text = "DOMINGO, 18 DE JUNIO DE 2023"
        ' 
        ' Timer1
        ' 
        ' 
        ' PAdmin
        ' 
        PAdmin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PAdmin.BackColor = Color.Silver
        PAdmin.Controls.Add(btnCS)
        PAdmin.Controls.Add(btnCuenta)
        PAdmin.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        PAdmin.Location = New Point(962, 56)
        PAdmin.Name = "PAdmin"
        PAdmin.Size = New Size(200, 57)
        PAdmin.TabIndex = 26
        ' 
        ' btnCS
        ' 
        btnCS.BackColor = Color.Silver
        btnCS.FlatAppearance.BorderColor = Color.White
        btnCS.FlatAppearance.BorderSize = 0
        btnCS.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        btnCS.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        btnCS.FlatStyle = FlatStyle.Flat
        btnCS.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCS.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCS.Location = New Point(0, 25)
        btnCS.Name = "btnCS"
        btnCS.Size = New Size(200, 25)
        btnCS.TabIndex = 9
        btnCS.Text = "Cerrar Sesion"
        btnCS.UseVisualStyleBackColor = False
        ' 
        ' btnCuenta
        ' 
        btnCuenta.BackColor = Color.Silver
        btnCuenta.FlatAppearance.BorderColor = Color.White
        btnCuenta.FlatAppearance.BorderSize = 0
        btnCuenta.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        btnCuenta.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        btnCuenta.FlatStyle = FlatStyle.Flat
        btnCuenta.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCuenta.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnCuenta.Location = New Point(0, 0)
        btnCuenta.Name = "btnCuenta"
        btnCuenta.Size = New Size(200, 25)
        btnCuenta.TabIndex = 8
        btnCuenta.Text = "Configuracion de cuenta"
        btnCuenta.UseVisualStyleBackColor = False
        ' 
        ' FrmHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        ClientSize = New Size(1162, 710)
        Controls.Add(PAdmin)
        Controls.Add(Panel11)
        Controls.Add(Panel1)
        Controls.Add(Panel9)
        ForeColor = SystemColors.ButtonFace
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmHome"
        Text = "FrmHome"
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        PAdmin.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnCampanaBlanca As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PAdmin As Panel
    Friend WithEvents btnCS As Button
    Friend WithEvents btnCuenta As Button
    Friend WithEvents btnCampanaRoja As Button
End Class
