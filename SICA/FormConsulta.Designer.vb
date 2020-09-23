<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsulta
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
        Me.tcCustodia = New System.Windows.Forms.TabControl()
        Me.tpExpedientes = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvExpedientes = New System.Windows.Forms.DataGridView()
        Me.tcCustodia.SuspendLayout()
        Me.tpExpedientes.SuspendLayout()
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcCustodia
        '
        Me.tcCustodia.Controls.Add(Me.tpExpedientes)
        Me.tcCustodia.Controls.Add(Me.TabPage2)
        Me.tcCustodia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCustodia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcCustodia.Location = New System.Drawing.Point(0, 0)
        Me.tcCustodia.Name = "tcCustodia"
        Me.tcCustodia.SelectedIndex = 0
        Me.tcCustodia.Size = New System.Drawing.Size(969, 542)
        Me.tcCustodia.TabIndex = 1
        '
        'tpExpedientes
        '
        Me.tpExpedientes.BackColor = System.Drawing.Color.MidnightBlue
        Me.tpExpedientes.Controls.Add(Me.dgvExpedientes)
        Me.tpExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpExpedientes.Location = New System.Drawing.Point(4, 27)
        Me.tpExpedientes.Name = "tpExpedientes"
        Me.tpExpedientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExpedientes.Size = New System.Drawing.Size(961, 511)
        Me.tpExpedientes.TabIndex = 0
        Me.tpExpedientes.Text = "Expedientes Desembolsados"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.MidnightBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(799, 446)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Documentos Post-Desembolso"
        '
        'dgvExpedientes
        '
        Me.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpedientes.Location = New System.Drawing.Point(75, 56)
        Me.dgvExpedientes.Name = "dgvExpedientes"
        Me.dgvExpedientes.Size = New System.Drawing.Size(816, 402)
        Me.dgvExpedientes.TabIndex = 0
        '
        'FormConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(969, 542)
        Me.Controls.Add(Me.tcCustodia)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormConsulta"
        Me.Text = "Form1"
        Me.tcCustodia.ResumeLayout(False)
        Me.tpExpedientes.ResumeLayout(False)
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcCustodia As TabControl
    Friend WithEvents tpExpedientes As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvExpedientes As DataGridView
End Class
