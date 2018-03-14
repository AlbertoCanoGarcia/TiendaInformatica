<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantenimientoCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tablacliente = New System.Windows.Forms.DataGridView()
        Me.idcolumna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colummadni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnatelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnadireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnalocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaprovincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnacp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnacuentabancaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Ult_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaDireccionEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonanadircliente = New System.Windows.Forms.Button()
        Me.botonmodificar = New System.Windows.Forms.Button()
        Me.botonborrar = New System.Windows.Forms.Button()
        Me.botonbuscar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Bcancelar = New System.Windows.Forms.Button()
        Me.Baceptar = New System.Windows.Forms.Button()
        Me.textobuscar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textodatobuscar = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablacliente
        '
        Me.tablacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablacliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcolumna, Me.columnaNombre, Me.colummadni, Me.columnatelefono, Me.columnaemail, Me.columnadireccion, Me.columnalocalidad, Me.columnaprovincia, Me.columnacp, Me.columnacuentabancaria, Me.Fecha_Ult_Venta, Me.columnaFechaAlta, Me.columnaDireccionEntrega})
        Me.tablacliente.Location = New System.Drawing.Point(12, 43)
        Me.tablacliente.Name = "tablacliente"
        Me.tablacliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tablacliente.RowHeadersVisible = False
        Me.tablacliente.Size = New System.Drawing.Size(1088, 250)
        Me.tablacliente.TabIndex = 0
        '
        'idcolumna
        '
        Me.idcolumna.HeaderText = "ID"
        Me.idcolumna.Name = "idcolumna"
        Me.idcolumna.Width = 50
        '
        'columnaNombre
        '
        Me.columnaNombre.HeaderText = "Nombre"
        Me.columnaNombre.Name = "columnaNombre"
        '
        'colummadni
        '
        Me.colummadni.HeaderText = "NIF_CIF"
        Me.colummadni.Name = "colummadni"
        Me.colummadni.Width = 80
        '
        'columnatelefono
        '
        Me.columnatelefono.HeaderText = "Telefono"
        Me.columnatelefono.Name = "columnatelefono"
        Me.columnatelefono.Width = 80
        '
        'columnaemail
        '
        Me.columnaemail.HeaderText = "Email"
        Me.columnaemail.Name = "columnaemail"
        Me.columnaemail.Width = 120
        '
        'columnadireccion
        '
        Me.columnadireccion.HeaderText = "Direccion"
        Me.columnadireccion.Name = "columnadireccion"
        Me.columnadireccion.Width = 120
        '
        'columnalocalidad
        '
        Me.columnalocalidad.HeaderText = "Localidad"
        Me.columnalocalidad.Name = "columnalocalidad"
        '
        'columnaprovincia
        '
        Me.columnaprovincia.HeaderText = "Provincia"
        Me.columnaprovincia.Name = "columnaprovincia"
        Me.columnaprovincia.Width = 70
        '
        'columnacp
        '
        Me.columnacp.HeaderText = "CP"
        Me.columnacp.Name = "columnacp"
        Me.columnacp.Width = 40
        '
        'columnacuentabancaria
        '
        Me.columnacuentabancaria.HeaderText = "CuentaBancaria"
        Me.columnacuentabancaria.Name = "columnacuentabancaria"
        '
        'Fecha_Ult_Venta
        '
        Me.Fecha_Ult_Venta.HeaderText = "Fecha_Ult_Venta"
        Me.Fecha_Ult_Venta.Name = "Fecha_Ult_Venta"
        '
        'columnaFechaAlta
        '
        Me.columnaFechaAlta.HeaderText = "FechaAlta"
        Me.columnaFechaAlta.Name = "columnaFechaAlta"
        Me.columnaFechaAlta.Width = 70
        '
        'columnaDireccionEntrega
        '
        Me.columnaDireccionEntrega.HeaderText = "Direccion Entrega"
        Me.columnaDireccionEntrega.Name = "columnaDireccionEntrega"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(427, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mantenimiento Cliente"
        '
        'botonanadircliente
        '
        Me.botonanadircliente.Location = New System.Drawing.Point(14, 356)
        Me.botonanadircliente.Name = "botonanadircliente"
        Me.botonanadircliente.Size = New System.Drawing.Size(86, 23)
        Me.botonanadircliente.TabIndex = 2
        Me.botonanadircliente.Text = "Añadir Cliente"
        Me.botonanadircliente.UseVisualStyleBackColor = True
        '
        'botonmodificar
        '
        Me.botonmodificar.Location = New System.Drawing.Point(128, 356)
        Me.botonmodificar.Name = "botonmodificar"
        Me.botonmodificar.Size = New System.Drawing.Size(100, 23)
        Me.botonmodificar.TabIndex = 3
        Me.botonmodificar.Text = "Modificar Cliente"
        Me.botonmodificar.UseVisualStyleBackColor = True
        '
        'botonborrar
        '
        Me.botonborrar.Location = New System.Drawing.Point(280, 356)
        Me.botonborrar.Name = "botonborrar"
        Me.botonborrar.Size = New System.Drawing.Size(75, 23)
        Me.botonborrar.TabIndex = 4
        Me.botonborrar.Text = "Dar de baja "
        Me.botonborrar.UseVisualStyleBackColor = True
        '
        'botonbuscar
        '
        Me.botonbuscar.Location = New System.Drawing.Point(12, 316)
        Me.botonbuscar.Name = "botonbuscar"
        Me.botonbuscar.Size = New System.Drawing.Size(75, 23)
        Me.botonbuscar.TabIndex = 5
        Me.botonbuscar.Text = "Buscar"
        Me.botonbuscar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(942, 359)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 49
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Bcancelar
        '
        Me.Bcancelar.Enabled = False
        Me.Bcancelar.Location = New System.Drawing.Point(717, 359)
        Me.Bcancelar.Name = "Bcancelar"
        Me.Bcancelar.Size = New System.Drawing.Size(62, 23)
        Me.Bcancelar.TabIndex = 48
        Me.Bcancelar.Text = "Cancelar"
        Me.Bcancelar.UseVisualStyleBackColor = True
        Me.Bcancelar.Visible = False
        '
        'Baceptar
        '
        Me.Baceptar.Enabled = False
        Me.Baceptar.Location = New System.Drawing.Point(628, 359)
        Me.Baceptar.Name = "Baceptar"
        Me.Baceptar.Size = New System.Drawing.Size(60, 23)
        Me.Baceptar.TabIndex = 47
        Me.Baceptar.Text = "Aceptar"
        Me.Baceptar.UseVisualStyleBackColor = True
        Me.Baceptar.Visible = False
        '
        'textobuscar
        '
        Me.textobuscar.Enabled = False
        Me.textobuscar.FormattingEnabled = True
        Me.textobuscar.Location = New System.Drawing.Point(161, 318)
        Me.textobuscar.Name = "textobuscar"
        Me.textobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textobuscar.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Buscar Por:"
        '
        'textodatobuscar
        '
        Me.textodatobuscar.FormattingEnabled = True
        Me.textodatobuscar.Location = New System.Drawing.Point(311, 318)
        Me.textodatobuscar.Name = "textodatobuscar"
        Me.textodatobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textodatobuscar.TabIndex = 53
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 390)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1112, 22)
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'MantenimientoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1112, 412)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.textodatobuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textobuscar)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.Bcancelar)
        Me.Controls.Add(Me.Baceptar)
        Me.Controls.Add(Me.botonbuscar)
        Me.Controls.Add(Me.botonborrar)
        Me.Controls.Add(Me.botonmodificar)
        Me.Controls.Add(Me.botonanadircliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tablacliente)
        Me.Name = "MantenimientoCliente"
        Me.Text = "MantenimientoCliente"
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tablacliente As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents botonanadircliente As Button
    Friend WithEvents botonmodificar As Button
    Friend WithEvents botonborrar As Button
    Friend WithEvents botonbuscar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents Bcancelar As Button
    Friend WithEvents Baceptar As Button
    Friend WithEvents textobuscar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textodatobuscar As ComboBox
    Friend WithEvents idcolumna As DataGridViewTextBoxColumn
    Friend WithEvents columnaNombre As DataGridViewTextBoxColumn
    Friend WithEvents colummadni As DataGridViewTextBoxColumn
    Friend WithEvents columnatelefono As DataGridViewTextBoxColumn
    Friend WithEvents columnaemail As DataGridViewTextBoxColumn
    Friend WithEvents columnadireccion As DataGridViewTextBoxColumn
    Friend WithEvents columnalocalidad As DataGridViewTextBoxColumn
    Friend WithEvents columnaprovincia As DataGridViewTextBoxColumn
    Friend WithEvents columnacp As DataGridViewTextBoxColumn
    Friend WithEvents columnacuentabancaria As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Ult_Venta As DataGridViewTextBoxColumn
    Friend WithEvents columnaFechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents columnaDireccionEntrega As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
