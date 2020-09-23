<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportar
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
        Me.tcImportar = New System.Windows.Forms.TabControl()
        Me.tpExpedientes = New System.Windows.Forms.TabPage()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.dgvNDesembolsos = New System.Windows.Forms.DataGridView()
        Me.tpActualizarCancelado = New System.Windows.Forms.TabPage()
        Me.btPrestamosNuevos = New System.Windows.Forms.Button()
        Me.tcImportar.SuspendLayout()
        Me.tpExpedientes.SuspendLayout()
        CType(Me.dgvNDesembolsos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcImportar
        '
        Me.tcImportar.Controls.Add(Me.tpExpedientes)
        Me.tcImportar.Controls.Add(Me.tpActualizarCancelado)
        Me.tcImportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcImportar.Location = New System.Drawing.Point(0, 0)
        Me.tcImportar.Name = "tcImportar"
        Me.tcImportar.SelectedIndex = 0
        Me.tcImportar.Size = New System.Drawing.Size(972, 545)
        Me.tcImportar.TabIndex = 2
        '
        'tpExpedientes
        '
        Me.tpExpedientes.BackColor = System.Drawing.Color.MidnightBlue
        Me.tpExpedientes.Controls.Add(Me.btPrestamosNuevos)
        Me.tpExpedientes.Controls.Add(Me.btBuscar)
        Me.tpExpedientes.Controls.Add(Me.dgvNDesembolsos)
        Me.tpExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpExpedientes.Location = New System.Drawing.Point(4, 27)
        Me.tpExpedientes.Name = "tpExpedientes"
        Me.tpExpedientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExpedientes.Size = New System.Drawing.Size(964, 514)
        Me.tpExpedientes.TabIndex = 0
        Me.tpExpedientes.Text = "Nuevos Desembolsos"
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(726, 6)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(83, 24)
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'dgvNDesembolsos
        '
        Me.dgvNDesembolsos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNDesembolsos.Location = New System.Drawing.Point(8, 36)
        Me.dgvNDesembolsos.Name = "dgvNDesembolsos"
        Me.dgvNDesembolsos.Size = New System.Drawing.Size(865, 470)
        Me.dgvNDesembolsos.TabIndex = 0
        '
        'tpActualizarCancelado
        '
        Me.tpActualizarCancelado.BackColor = System.Drawing.Color.MidnightBlue
        Me.tpActualizarCancelado.Location = New System.Drawing.Point(4, 27)
        Me.tpActualizarCancelado.Name = "tpActualizarCancelado"
        Me.tpActualizarCancelado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpActualizarCancelado.Size = New System.Drawing.Size(964, 514)
        Me.tpActualizarCancelado.TabIndex = 1
        Me.tpActualizarCancelado.Text = "Actualizar Fecha Cancelado"
        '
        'btPrestamosNuevos
        '
        Me.btPrestamosNuevos.Location = New System.Drawing.Point(8, 6)
        Me.btPrestamosNuevos.Name = "btPrestamosNuevos"
        Me.btPrestamosNuevos.Size = New System.Drawing.Size(83, 24)
        Me.btPrestamosNuevos.TabIndex = 3
        Me.btPrestamosNuevos.Text = "Buscar"
        Me.btPrestamosNuevos.UseVisualStyleBackColor = True
        '
        'FormImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(972, 545)
        Me.Controls.Add(Me.tcImportar)
        Me.Name = "FormImportar"
        Me.Text = "Form1"
        Me.tcImportar.ResumeLayout(False)
        Me.tpExpedientes.ResumeLayout(False)
        CType(Me.dgvNDesembolsos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcImportar As TabControl
    Friend WithEvents tpExpedientes As TabPage
    Friend WithEvents dgvNDesembolsos As DataGridView
    Friend WithEvents tpActualizarCancelado As TabPage
    Friend WithEvents btBuscar As Button
    Friend WithEvents btPrestamosNuevos As Button
End Class
