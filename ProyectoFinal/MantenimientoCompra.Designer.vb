<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenimientoCompra
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opcionNoFacturado = New System.Windows.Forms.CheckBox()
        Me.opcionFacturado = New System.Windows.Forms.CheckBox()
        Me.botonbuscar = New System.Windows.Forms.Button()
        Me.textodatobuscar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textobuscar = New System.Windows.Forms.ComboBox()
        Me.tablaventas = New System.Windows.Forms.DataGridView()
        Me.Nventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrecliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importetotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tablaventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(284, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 24)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Mantenimiento de compras"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.botonbuscar)
        Me.GroupBox2.Controls.Add(Me.textodatobuscar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.textobuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 221)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda Proveedores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opcionNoFacturado)
        Me.GroupBox1.Controls.Add(Me.opcionFacturado)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 74)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura"
        '
        'opcionNoFacturado
        '
        Me.opcionNoFacturado.AutoSize = True
        Me.opcionNoFacturado.Location = New System.Drawing.Point(6, 42)
        Me.opcionNoFacturado.Name = "opcionNoFacturado"
        Me.opcionNoFacturado.Size = New System.Drawing.Size(88, 17)
        Me.opcionNoFacturado.TabIndex = 124
        Me.opcionNoFacturado.Text = "No facturado"
        Me.opcionNoFacturado.UseVisualStyleBackColor = True
        '
        'opcionFacturado
        '
        Me.opcionFacturado.AutoSize = True
        Me.opcionFacturado.Location = New System.Drawing.Point(6, 19)
        Me.opcionFacturado.Name = "opcionFacturado"
        Me.opcionFacturado.Size = New System.Drawing.Size(74, 17)
        Me.opcionFacturado.TabIndex = 123
        Me.opcionFacturado.Text = "Facturado"
        Me.opcionFacturado.UseVisualStyleBackColor = True
        '
        'botonbuscar
        '
        Me.botonbuscar.Enabled = False
        Me.botonbuscar.Location = New System.Drawing.Point(13, 166)
        Me.botonbuscar.Name = "botonbuscar"
        Me.botonbuscar.Size = New System.Drawing.Size(75, 23)
        Me.botonbuscar.TabIndex = 120
        Me.botonbuscar.Text = "Buscar"
        Me.botonbuscar.UseVisualStyleBackColor = True
        '
        'textodatobuscar
        '
        Me.textodatobuscar.FormattingEnabled = True
        Me.textodatobuscar.Location = New System.Drawing.Point(13, 56)
        Me.textodatobuscar.Name = "textodatobuscar"
        Me.textodatobuscar.Size = New System.Drawing.Size(155, 21)
        Me.textodatobuscar.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Buscar Por:"
        '
        'textobuscar
        '
        Me.textobuscar.FormattingEnabled = True
        Me.textobuscar.Items.AddRange(New Object() {"NIF_CIF", "Razon_social"})
        Me.textobuscar.Location = New System.Drawing.Point(88, 24)
        Me.textobuscar.Name = "textobuscar"
        Me.textobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textobuscar.TabIndex = 117
        '
        'tablaventas
        '
        Me.tablaventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nventa, Me.nombrecliente, Me.cliente, Me.direccion, Me.fecha, Me.importetotal})
        Me.tablaventas.Location = New System.Drawing.Point(267, 67)
        Me.tablaventas.Name = "tablaventas"
        Me.tablaventas.RowHeadersVisible = False
        Me.tablaventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tablaventas.Size = New System.Drawing.Size(577, 347)
        Me.tablaventas.TabIndex = 127
        '
        'Nventa
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Nventa.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nventa.HeaderText = "Nº"
        Me.Nventa.Name = "Nventa"
        Me.Nventa.ReadOnly = True
        Me.Nventa.Width = 40
        '
        'nombrecliente
        '
        Me.nombrecliente.HeaderText = "NIF Proveedor"
        Me.nombrecliente.Name = "nombrecliente"
        Me.nombrecliente.ReadOnly = True
        Me.nombrecliente.Width = 70
        '
        'cliente
        '
        Me.cliente.HeaderText = "Empresa"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 140
        '
        'direccion
        '
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 180
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 80
        '
        'importetotal
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.importetotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.importetotal.HeaderText = "Importe"
        Me.importetotal.Name = "importetotal"
        Me.importetotal.ReadOnly = True
        Me.importetotal.Width = 60
        '
        'MantenimientoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(853, 420)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tablaventas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MantenimientoCompra"
        Me.Text = "MantenimientoCompra"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tablaventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents opcionNoFacturado As CheckBox
    Friend WithEvents opcionFacturado As CheckBox
    Friend WithEvents botonbuscar As Button
    Friend WithEvents textodatobuscar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textobuscar As ComboBox
    Friend WithEvents tablaventas As DataGridView
    Friend WithEvents Nventa As DataGridViewTextBoxColumn
    Friend WithEvents nombrecliente As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents importetotal As DataGridViewTextBoxColumn
End Class
