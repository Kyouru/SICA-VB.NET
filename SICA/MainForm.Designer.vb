<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.btDigitalizacion = New FontAwesome.Sharp.IconButton()
        Me.btEntregar = New FontAwesome.Sharp.IconButton()
        Me.btRecibir = New FontAwesome.Sharp.IconButton()
        Me.btConsulta = New FontAwesome.Sharp.IconButton()
        Me.pbLogo = New FontAwesome.Sharp.IconPictureBox()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.btMinimizar = New FontAwesome.Sharp.IconButton()
        Me.btMaximizar = New FontAwesome.Sharp.IconButton()
        Me.btCerrar = New FontAwesome.Sharp.IconButton()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.btDesembolsos = New FontAwesome.Sharp.IconButton()
        Me.LeftPanel.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.btDesembolsos)
        Me.LeftPanel.Controls.Add(Me.btDigitalizacion)
        Me.LeftPanel.Controls.Add(Me.btEntregar)
        Me.LeftPanel.Controls.Add(Me.btRecibir)
        Me.LeftPanel.Controls.Add(Me.btConsulta)
        Me.LeftPanel.Controls.Add(Me.pbLogo)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(200, 690)
        Me.LeftPanel.TabIndex = 0
        '
        'btDigitalizacion
        '
        Me.btDigitalizacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btDigitalizacion.FlatAppearance.BorderSize = 0
        Me.btDigitalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDigitalizacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btDigitalizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDigitalizacion.ForeColor = System.Drawing.Color.LightGray
        Me.btDigitalizacion.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btDigitalizacion.IconColor = System.Drawing.Color.Black
        Me.btDigitalizacion.IconSize = 16
        Me.btDigitalizacion.Location = New System.Drawing.Point(0, 309)
        Me.btDigitalizacion.Name = "btDigitalizacion"
        Me.btDigitalizacion.Rotation = 0R
        Me.btDigitalizacion.Size = New System.Drawing.Size(200, 60)
        Me.btDigitalizacion.TabIndex = 5
        Me.btDigitalizacion.Text = "Digitalizacion"
        Me.btDigitalizacion.UseVisualStyleBackColor = True
        '
        'btEntregar
        '
        Me.btEntregar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btEntregar.FlatAppearance.BorderSize = 0
        Me.btEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEntregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btEntregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEntregar.ForeColor = System.Drawing.Color.LightGray
        Me.btEntregar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btEntregar.IconColor = System.Drawing.Color.Black
        Me.btEntregar.IconSize = 16
        Me.btEntregar.Location = New System.Drawing.Point(0, 249)
        Me.btEntregar.Name = "btEntregar"
        Me.btEntregar.Rotation = 0R
        Me.btEntregar.Size = New System.Drawing.Size(200, 60)
        Me.btEntregar.TabIndex = 3
        Me.btEntregar.Text = "Entregar"
        Me.btEntregar.UseVisualStyleBackColor = True
        '
        'btRecibir
        '
        Me.btRecibir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btRecibir.FlatAppearance.BorderSize = 0
        Me.btRecibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRecibir.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btRecibir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRecibir.ForeColor = System.Drawing.Color.LightGray
        Me.btRecibir.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btRecibir.IconColor = System.Drawing.Color.Black
        Me.btRecibir.IconSize = 16
        Me.btRecibir.Location = New System.Drawing.Point(0, 189)
        Me.btRecibir.Name = "btRecibir"
        Me.btRecibir.Rotation = 0R
        Me.btRecibir.Size = New System.Drawing.Size(200, 60)
        Me.btRecibir.TabIndex = 2
        Me.btRecibir.Text = "Recibir"
        Me.btRecibir.UseVisualStyleBackColor = True
        '
        'btConsulta
        '
        Me.btConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btConsulta.FlatAppearance.BorderSize = 0
        Me.btConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConsulta.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsulta.ForeColor = System.Drawing.Color.LightGray
        Me.btConsulta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btConsulta.IconColor = System.Drawing.Color.Black
        Me.btConsulta.IconSize = 16
        Me.btConsulta.Location = New System.Drawing.Point(0, 129)
        Me.btConsulta.Name = "btConsulta"
        Me.btConsulta.Rotation = 0R
        Me.btConsulta.Size = New System.Drawing.Size(200, 60)
        Me.btConsulta.TabIndex = 1
        Me.btConsulta.Text = "Consulta"
        Me.btConsulta.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbLogo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pbLogo.IconChar = FontAwesome.Sharp.IconChar.None
        Me.pbLogo.IconColor = System.Drawing.SystemColors.ControlText
        Me.pbLogo.IconSize = 129
        Me.pbLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(200, 129)
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.lbTitulo)
        Me.TopPanel.Controls.Add(Me.btMinimizar)
        Me.TopPanel.Controls.Add(Me.btMaximizar)
        Me.TopPanel.Controls.Add(Me.btCerrar)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(200, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(975, 52)
        Me.TopPanel.TabIndex = 1
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.White
        Me.lbTitulo.Location = New System.Drawing.Point(21, 15)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(63, 26)
        Me.lbTitulo.TabIndex = 4
        Me.lbTitulo.Text = "Inicio"
        '
        'btMinimizar
        '
        Me.btMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMinimizar.FlatAppearance.BorderSize = 0
        Me.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btMinimizar.IconColor = System.Drawing.Color.White
        Me.btMinimizar.IconSize = 24
        Me.btMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMinimizar.Location = New System.Drawing.Point(846, 8)
        Me.btMinimizar.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.btMinimizar.Name = "btMinimizar"
        Me.btMinimizar.Rotation = 0R
        Me.btMinimizar.Size = New System.Drawing.Size(39, 24)
        Me.btMinimizar.TabIndex = 3
        Me.btMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMinimizar.UseVisualStyleBackColor = True
        '
        'btMaximizar
        '
        Me.btMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMaximizar.FlatAppearance.BorderSize = 0
        Me.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btMaximizar.IconColor = System.Drawing.Color.White
        Me.btMaximizar.IconSize = 24
        Me.btMaximizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMaximizar.Location = New System.Drawing.Point(888, 8)
        Me.btMaximizar.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.btMaximizar.Name = "btMaximizar"
        Me.btMaximizar.Rotation = 0R
        Me.btMaximizar.Size = New System.Drawing.Size(39, 24)
        Me.btMaximizar.TabIndex = 2
        Me.btMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMaximizar.UseVisualStyleBackColor = True
        '
        'btCerrar
        '
        Me.btCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCerrar.FlatAppearance.BorderSize = 0
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btCerrar.IconColor = System.Drawing.Color.White
        Me.btCerrar.IconSize = 24
        Me.btCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCerrar.Location = New System.Drawing.Point(930, 8)
        Me.btCerrar.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Rotation = 0R
        Me.btCerrar.Size = New System.Drawing.Size(39, 24)
        Me.btCerrar.TabIndex = 1
        Me.btCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCerrar.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(200, 52)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(975, 638)
        Me.MainPanel.TabIndex = 2
        '
        'btDesembolsos
        '
        Me.btDesembolsos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btDesembolsos.FlatAppearance.BorderSize = 0
        Me.btDesembolsos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDesembolsos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btDesembolsos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDesembolsos.ForeColor = System.Drawing.Color.LightGray
        Me.btDesembolsos.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btDesembolsos.IconColor = System.Drawing.Color.Black
        Me.btDesembolsos.IconSize = 16
        Me.btDesembolsos.Location = New System.Drawing.Point(0, 369)
        Me.btDesembolsos.Name = "btDesembolsos"
        Me.btDesembolsos.Rotation = 0R
        Me.btDesembolsos.Size = New System.Drawing.Size(200, 60)
        Me.btDesembolsos.TabIndex = 6
        Me.btDesembolsos.Text = "Desembolsos"
        Me.btDesembolsos.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1175, 690)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.DoubleBuffered = True
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.LeftPanel.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btConsulta As FontAwesome.Sharp.IconButton
    Friend WithEvents pbLogo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btDigitalizacion As FontAwesome.Sharp.IconButton
    Friend WithEvents btEntregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btRecibir As FontAwesome.Sharp.IconButton
    Friend WithEvents lbTitulo As Label
    Friend WithEvents btDesembolsos As FontAwesome.Sharp.IconButton
End Class
