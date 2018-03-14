<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibroIva
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.totalrepercutido = New System.Windows.Forms.TextBox()
        Me.totaliva = New System.Windows.Forms.TextBox()
        Me.totalbase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tablasoportado = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalsoportado = New System.Windows.Forms.TextBox()
        Me.totaliva2 = New System.Windows.Forms.TextBox()
        Me.totalbase2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tablarepercutido = New System.Windows.Forms.DataGridView()
        Me.NºFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ssa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tablasoportado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablarepercutido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'totalrepercutido
        '
        Me.totalrepercutido.Enabled = False
        Me.totalrepercutido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.totalrepercutido.Location = New System.Drawing.Point(518, 226)
        Me.totalrepercutido.Name = "totalrepercutido"
        Me.totalrepercutido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totalrepercutido.Size = New System.Drawing.Size(82, 20)
        Me.totalrepercutido.TabIndex = 15
        '
        'totaliva
        '
        Me.totaliva.Enabled = False
        Me.totaliva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.totaliva.Location = New System.Drawing.Point(455, 226)
        Me.totaliva.Name = "totaliva"
        Me.totaliva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totaliva.Size = New System.Drawing.Size(63, 20)
        Me.totaliva.TabIndex = 14
        '
        'totalbase
        '
        Me.totalbase.Enabled = False
        Me.totalbase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.totalbase.Location = New System.Drawing.Point(380, 226)
        Me.totalbase.Name = "totalbase"
        Me.totalbase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totalbase.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.totalbase.Size = New System.Drawing.Size(75, 20)
        Me.totalbase.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(282, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total Repercutido"
        '
        'tablasoportado
        '
        Me.tablasoportado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.tablasoportado.ColumnHeadersHeight = 40
        Me.tablasoportado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.tablasoportado.Location = New System.Drawing.Point(7, 291)
        Me.tablasoportado.Name = "tablasoportado"
        Me.tablasoportado.ReadOnly = True
        Me.tablasoportado.RowHeadersVisible = False
        Me.tablasoportado.RowHeadersWidth = 50
        Me.tablasoportado.Size = New System.Drawing.Size(610, 150)
        Me.tablasoportado.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "NºFac"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 62
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "F.Factura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Empresa Proveedora"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "NIFCIF"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "BaseImponible"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 101
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn6.HeaderText = "%IVA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 57
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn7.HeaderText = "IVA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 49
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Soportado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Repercutido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(296, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Libro IVA"
        '
        'totalsoportado
        '
        Me.totalsoportado.Enabled = False
        Me.totalsoportado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.totalsoportado.Location = New System.Drawing.Point(518, 445)
        Me.totalsoportado.Name = "totalsoportado"
        Me.totalsoportado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totalsoportado.Size = New System.Drawing.Size(82, 20)
        Me.totalsoportado.TabIndex = 20
        '
        'totaliva2
        '
        Me.totaliva2.Enabled = False
        Me.totaliva2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.totaliva2.Location = New System.Drawing.Point(455, 445)
        Me.totaliva2.Name = "totaliva2"
        Me.totaliva2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totaliva2.Size = New System.Drawing.Size(63, 20)
        Me.totaliva2.TabIndex = 19
        '
        'totalbase2
        '
        Me.totalbase2.Enabled = False
        Me.totalbase2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.totalbase2.Location = New System.Drawing.Point(380, 445)
        Me.totalbase2.Name = "totalbase2"
        Me.totalbase2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totalbase2.Size = New System.Drawing.Size(75, 20)
        Me.totalbase2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(282, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Total Soportado"
        '
        'total
        '
        Me.total.Enabled = False
        Me.total.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.total.Location = New System.Drawing.Point(518, 496)
        Me.total.Name = "total"
        Me.total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.total.Size = New System.Drawing.Size(82, 20)
        Me.total.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(391, 496)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "TOTAL:"
        '
        'tablarepercutido
        '
        Me.tablarepercutido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablarepercutido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NºFactura, Me.ssa, Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.tablarepercutido.Location = New System.Drawing.Point(7, 76)
        Me.tablarepercutido.Name = "tablarepercutido"
        Me.tablarepercutido.RowHeadersVisible = False
        Me.tablarepercutido.Size = New System.Drawing.Size(610, 150)
        Me.tablarepercutido.TabIndex = 23
        '
        'NºFactura
        '
        Me.NºFactura.HeaderText = "NºFac"
        Me.NºFactura.Name = "NºFactura"
        Me.NºFactura.Width = 60
        '
        'ssa
        '
        Me.ssa.HeaderText = "NºFactura"
        Me.ssa.Name = "ssa"
        Me.ssa.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre y apellidos"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "NIFCIF"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 65
        '
        'Column2
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column2.HeaderText = "Base imponible"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 65
        '
        'Column3
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column3.HeaderText = "%IVA"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column4.HeaderText = "IVA"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 90
        '
        'LibroIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(657, 542)
        Me.Controls.Add(Me.tablarepercutido)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.totalsoportado)
        Me.Controls.Add(Me.totaliva2)
        Me.Controls.Add(Me.totalbase2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totalrepercutido)
        Me.Controls.Add(Me.totaliva)
        Me.Controls.Add(Me.totalbase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tablasoportado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LibroIva"
        Me.Text = "LibroIva"
        CType(Me.tablasoportado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablarepercutido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents totalrepercutido As TextBox
    Friend WithEvents totaliva As TextBox
    Friend WithEvents totalbase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tablasoportado As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalsoportado As TextBox
    Friend WithEvents totaliva2 As TextBox
    Friend WithEvents totalbase2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents total As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tablarepercutido As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents NºFactura As DataGridViewTextBoxColumn
    Friend WithEvents ssa As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
