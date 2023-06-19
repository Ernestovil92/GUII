<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendientes
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmPendientes))
        dgPendientes = New DataGridView()
        Panel9 = New Panel()
        Button8 = New Button()
        Button9 = New Button()
        Label4 = New Label()
        Button10 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Button7 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        Button6 = New Button()
        Panel7 = New Panel()
        Button11 = New Button()
        Button12 = New Button()
        Label5 = New Label()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Label6 = New Label()
        Button16 = New Button()
        CType(dgPendientes, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgPendientes
        ' 
        dgPendientes.BackgroundColor = Color.Silver
        dgPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPendientes.Location = New Point(259, 106)
        dgPendientes.Name = "dgPendientes"
        dgPendientes.RowTemplate.Height = 25
        dgPendientes.Size = New Size(707, 354)
        dgPendientes.TabIndex = 2
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel9.Controls.Add(Button8)
        Panel9.Controls.Add(Button9)
        Panel9.Controls.Add(Label4)
        Panel9.Controls.Add(Button10)
        Panel9.Controls.Add(Button1)
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
        Panel9.TabIndex = 8
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
        Button8.Location = New Point(976, 12)
        Button8.Name = "Button8"
        Button8.Size = New Size(29, 28)
        Button8.TabIndex = 27
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
        Button9.Location = New Point(1004, 12)
        Button9.Name = "Button9"
        Button9.Size = New Size(29, 28)
        Button9.TabIndex = 28
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(1030, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 17)
        Label4.TabIndex = 29
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
        Button10.Location = New Point(1130, 12)
        Button10.Name = "Button10"
        Button10.Size = New Size(29, 28)
        Button10.TabIndex = 26
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1938, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 28)
        Button1.TabIndex = 23
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1966, 12)
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
        Label3.Location = New Point(1992, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 17)
        Label3.TabIndex = 25
        Label3.Text = "Ernesto Villalba"
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button7.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(2086, 14)
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
        Button4.Location = New Point(2665, 10)
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
        Button5.Location = New Point(2693, 10)
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
        Label2.Location = New Point(2719, 15)
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
        Label1.Size = New Size(64, 17)
        Label1.TabIndex = 20
        Label1.Text = "Pedientes"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(2813, 12)
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
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel7.BackColor = Color.FromArgb(CByte(0), CByte(20), CByte(20))
        Panel7.Controls.Add(Button11)
        Panel7.Controls.Add(Button12)
        Panel7.Controls.Add(Label5)
        Panel7.Controls.Add(Button13)
        Panel7.Controls.Add(Button14)
        Panel7.Controls.Add(Button15)
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(Button16)
        Panel7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel7.Location = New Point(0, 50)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1162, 5)
        Panel7.TabIndex = 10
        ' 
        ' Button11
        ' 
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button11.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button11.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button11.FlatStyle = FlatStyle.Flat
        Button11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.Location = New Point(3862, 12)
        Button11.Name = "Button11"
        Button11.Size = New Size(29, 28)
        Button11.TabIndex = 23
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button12.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button12.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button12.FlatStyle = FlatStyle.Flat
        Button12.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button12.Image = CType(resources.GetObject("Button12.Image"), Image)
        Button12.Location = New Point(3890, 12)
        Button12.Name = "Button12"
        Button12.Size = New Size(29, 28)
        Button12.TabIndex = 24
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(3916, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 17)
        Label5.TabIndex = 25
        Label5.Text = "Ernesto Villalba"
        ' 
        ' Button13
        ' 
        Button13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button13.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        Button13.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        Button13.FlatStyle = FlatStyle.Flat
        Button13.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(4016, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(29, 28)
        Button13.TabIndex = 22
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button14.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button14.FlatStyle = FlatStyle.Flat
        Button14.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button14.Image = CType(resources.GetObject("Button14.Image"), Image)
        Button14.Location = New Point(4589, 10)
        Button14.Name = "Button14"
        Button14.Size = New Size(29, 28)
        Button14.TabIndex = 8
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button15.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button15.FlatStyle = FlatStyle.Flat
        Button15.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button15.Image = CType(resources.GetObject("Button15.Image"), Image)
        Button15.Location = New Point(4617, 10)
        Button15.Name = "Button15"
        Button15.Size = New Size(29, 28)
        Button15.TabIndex = 9
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(4643, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 17)
        Label6.TabIndex = 21
        Label6.Text = "Ernesto Villalba"
        ' 
        ' Button16
        ' 
        Button16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button16.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button16.FlatStyle = FlatStyle.Flat
        Button16.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button16.Image = CType(resources.GetObject("Button16.Image"), Image)
        Button16.Location = New Point(4737, 12)
        Button16.Name = "Button16"
        Button16.Size = New Size(29, 28)
        Button16.TabIndex = 7
        Button16.UseVisualStyleBackColor = False
        ' 
        ' FrmPendientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(50), CByte(55))
        ClientSize = New Size(1162, 710)
        Controls.Add(Panel7)
        Controls.Add(Panel9)
        Controls.Add(dgPendientes)
        Name = "FrmPendientes"
        CType(dgPendientes, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgPendientes As DataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button16 As Button
End Class
