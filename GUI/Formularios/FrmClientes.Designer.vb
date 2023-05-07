<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnGuardar2 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCanaleta = New System.Windows.Forms.Button()
        Me.btnPetinax = New System.Windows.Forms.Button()
        Me.btnNoAplica = New System.Windows.Forms.Button()
        Me.lblPertinax = New System.Windows.Forms.Label()
        Me.lblNoAplica = New System.Windows.Forms.Label()
        Me.PanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnGuardar)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(800, 52)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnGuardar2
        '
        Me.btnGuardar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar2.Location = New System.Drawing.Point(745, 58)
        Me.btnGuardar2.Name = "btnGuardar2"
        Me.btnGuardar2.Size = New System.Drawing.Size(55, 46)
        Me.btnGuardar2.TabIndex = 6
        Me.btnGuardar2.Text = "->"
        Me.btnGuardar2.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(742, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(55, 46)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "->"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(356, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modulo de cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCanaleta
        '
        Me.btnCanaleta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCanaleta.Location = New System.Drawing.Point(125, 170)
        Me.btnCanaleta.Name = "btnCanaleta"
        Me.btnCanaleta.Size = New System.Drawing.Size(126, 125)
        Me.btnCanaleta.TabIndex = 1
        Me.btnCanaleta.Text = "Canaleta"
        Me.btnCanaleta.UseVisualStyleBackColor = False
        '
        'btnPetinax
        '
        Me.btnPetinax.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPetinax.Location = New System.Drawing.Point(325, 170)
        Me.btnPetinax.Name = "btnPetinax"
        Me.btnPetinax.Size = New System.Drawing.Size(134, 125)
        Me.btnPetinax.TabIndex = 2
        Me.btnPetinax.Text = "Pertinax"
        Me.btnPetinax.UseVisualStyleBackColor = False
        '
        'btnNoAplica
        '
        Me.btnNoAplica.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNoAplica.Location = New System.Drawing.Point(525, 170)
        Me.btnNoAplica.Name = "btnNoAplica"
        Me.btnNoAplica.Size = New System.Drawing.Size(126, 125)
        Me.btnNoAplica.TabIndex = 3
        Me.btnNoAplica.Text = "No aplica"
        Me.btnNoAplica.UseVisualStyleBackColor = False
        '
        'lblPertinax
        '
        Me.lblPertinax.AutoSize = True
        Me.lblPertinax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPertinax.Location = New System.Drawing.Point(341, 126)
        Me.lblPertinax.Name = "lblPertinax"
        Me.lblPertinax.Size = New System.Drawing.Size(95, 21)
        Me.lblPertinax.TabIndex = 4
        Me.lblPertinax.Text = "sinNombres"
        '
        'lblNoAplica
        '
        Me.lblNoAplica.AutoSize = True
        Me.lblNoAplica.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNoAplica.Location = New System.Drawing.Point(545, 126)
        Me.lblNoAplica.Name = "lblNoAplica"
        Me.lblNoAplica.Size = New System.Drawing.Size(95, 21)
        Me.lblNoAplica.TabIndex = 5
        Me.lblNoAplica.Text = "sinNombres"
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGuardar2)
        Me.Controls.Add(Me.lblNoAplica)
        Me.Controls.Add(Me.lblPertinax)
        Me.Controls.Add(Me.btnNoAplica)
        Me.Controls.Add(Me.btnPetinax)
        Me.Controls.Add(Me.btnCanaleta)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Name = "FrmClientes"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCanaleta As Button
    Friend WithEvents btnPetinax As Button
    Friend WithEvents btnNoAplica As Button
    Friend WithEvents lblPertinax As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblNoAplica As Label
    Friend WithEvents btnGuardar2 As Button
End Class
