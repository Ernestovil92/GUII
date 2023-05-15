<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAyuda
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmAyuda))
        PanelTitulo = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PanelTitulo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        PanelTitulo.Controls.Add(Label1)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(1162, 52)
        PanelTitulo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.RosyBrown
        Label1.Location = New Point(382, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 18)
        Label1.TabIndex = 0
        Label1.Text = "Soporte Tecnico"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(344, 141)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(452, 351)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(344, 498)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(452, 128)
        Panel1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 15)
        Label4.TabIndex = 2
        Label4.Text = "Telefono : (+595) 986 649 570"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(267, 15)
        Label3.TabIndex = 1
        Label3.Text = "Correo electronico: ernestovillalba05@gmail.com"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(52, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(353, 15)
        Label2.TabIndex = 0
        Label2.Text = "Cualquier inconveniente con el sistema no dudes al contactarnos "
        ' 
        ' FrmAyuda
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1162, 710)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(PanelTitulo)
        Name = "FrmAyuda"
        Text = "FrmAyuda"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
