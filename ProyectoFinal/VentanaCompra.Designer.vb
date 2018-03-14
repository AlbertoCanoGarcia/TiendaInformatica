<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaCompra))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.textocliente = New System.Windows.Forms.RichTextBox()
        Me.textounidad = New System.Windows.Forms.TextBox()
        Me.textopvp = New System.Windows.Forms.TextBox()
        Me.textodescripcion = New System.Windows.Forms.ComboBox()
        Me.textodatobuscar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textobuscar = New System.Windows.Forms.ComboBox()
        Me.botonbuscar = New System.Windows.Forms.Button()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textoporcentajeiva = New System.Windows.Forms.ComboBox()
        Me.botonfacturadirecta = New System.Windows.Forms.Button()
        Me.textoformadepago = New System.Windows.Forms.ComboBox()
        Me.botonterminarlineas = New System.Windows.Forms.Button()
        Me.botonlimpiarlinea = New System.Windows.Forms.Button()
        Me.botoninsertarfila = New System.Windows.Forms.Button()
        Me.textoimportelinea = New System.Windows.Forms.TextBox()
        Me.textoproductodescuento = New System.Windows.Forms.TextBox()
        Me.textototalimpuestos = New System.Windows.Forms.TextBox()
        Me.textoiva = New System.Windows.Forms.TextBox()
        Me.botonnuevo = New System.Windows.Forms.Button()
        Me.textobaseimponible = New System.Windows.Forms.TextBox()
        Me.textoportes = New System.Windows.Forms.TextBox()
        Me.textodescuento = New System.Windows.Forms.TextBox()
        Me.textoporcentajedescuento = New System.Windows.Forms.TextBox()
        Me.textosuma = New System.Windows.Forms.TextBox()
        Me.tablalineaventa = New System.Windows.Forms.DataGridView()
        Me.Nlinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonsalir = New System.Windows.Forms.Button()
        Me.botoncancelar = New System.Windows.Forms.Button()
        Me.botonaceptar = New System.Windows.Forms.Button()
        Me.botonimprimir = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Suma = New System.Windows.Forms.Label()
        Me.textoobservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textodireccionentrega = New System.Windows.Forms.RichTextBox()
        Me.textofecha = New System.Windows.Forms.MaskedTextBox()
        Me.textonumeroalbaran = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.tablalineaventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textocliente
        '
        Me.textocliente.Enabled = False
        Me.textocliente.Location = New System.Drawing.Point(416, 39)
        Me.textocliente.Name = "textocliente"
        Me.textocliente.Size = New System.Drawing.Size(159, 74)
        Me.textocliente.TabIndex = 170
        Me.textocliente.Text = ""
        '
        'textounidad
        '
        Me.textounidad.Enabled = False
        Me.textounidad.Location = New System.Drawing.Point(375, 346)
        Me.textounidad.Name = "textounidad"
        Me.textounidad.Size = New System.Drawing.Size(56, 20)
        Me.textounidad.TabIndex = 169
        Me.textounidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textopvp
        '
        Me.textopvp.Enabled = False
        Me.textopvp.Location = New System.Drawing.Point(315, 346)
        Me.textopvp.Name = "textopvp"
        Me.textopvp.Size = New System.Drawing.Size(60, 20)
        Me.textopvp.TabIndex = 168
        Me.textopvp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textodescripcion
        '
        Me.textodescripcion.Enabled = False
        Me.textodescripcion.FormattingEnabled = True
        Me.textodescripcion.Location = New System.Drawing.Point(59, 346)
        Me.textodescripcion.Name = "textodescripcion"
        Me.textodescripcion.Size = New System.Drawing.Size(256, 21)
        Me.textodescripcion.TabIndex = 167
        '
        'textodatobuscar
        '
        Me.textodatobuscar.Enabled = False
        Me.textodatobuscar.FormattingEnabled = True
        Me.textodatobuscar.Location = New System.Drawing.Point(274, 92)
        Me.textodatobuscar.Name = "textodatobuscar"
        Me.textodatobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textodatobuscar.TabIndex = 166
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Buscar Por:"
        '
        'textobuscar
        '
        Me.textobuscar.Enabled = False
        Me.textobuscar.FormattingEnabled = True
        Me.textobuscar.Items.AddRange(New Object() {"Razon_Social", "NIF_CIF"})
        Me.textobuscar.Location = New System.Drawing.Point(274, 65)
        Me.textobuscar.Name = "textobuscar"
        Me.textobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textobuscar.TabIndex = 164
        '
        'botonbuscar
        '
        Me.botonbuscar.Location = New System.Drawing.Point(274, 39)
        Me.botonbuscar.Name = "botonbuscar"
        Me.botonbuscar.Size = New System.Drawing.Size(75, 23)
        Me.botonbuscar.TabIndex = 163
        Me.botonbuscar.Text = "Buscar"
        Me.botonbuscar.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(205, 44)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(56, 13)
        Me.Cliente.TabIndex = 162
        Me.Cliente.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(204, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 24)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Albaran de compra"
        '
        'textoporcentajeiva
        '
        Me.textoporcentajeiva.Enabled = False
        Me.textoporcentajeiva.FormattingEnabled = True
        Me.textoporcentajeiva.Location = New System.Drawing.Point(401, 520)
        Me.textoporcentajeiva.Name = "textoporcentajeiva"
        Me.textoporcentajeiva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textoporcentajeiva.Size = New System.Drawing.Size(41, 21)
        Me.textoporcentajeiva.TabIndex = 160
        '
        'botonfacturadirecta
        '
        Me.botonfacturadirecta.Enabled = False
        Me.botonfacturadirecta.Location = New System.Drawing.Point(24, 569)
        Me.botonfacturadirecta.Name = "botonfacturadirecta"
        Me.botonfacturadirecta.Size = New System.Drawing.Size(63, 47)
        Me.botonfacturadirecta.TabIndex = 159
        Me.botonfacturadirecta.Text = "Factura Directa"
        Me.botonfacturadirecta.UseVisualStyleBackColor = True
        Me.botonfacturadirecta.Visible = False
        '
        'textoformadepago
        '
        Me.textoformadepago.DisplayMember = "Contado"
        Me.textoformadepago.Enabled = False
        Me.textoformadepago.FormattingEnabled = True
        Me.textoformadepago.Items.AddRange(New Object() {"Contado", "30-60 DIAS 2 partes", "30-60-90 DIAS 3", "30-120 DIAS 2", "A 30 DIAS 1"})
        Me.textoformadepago.Location = New System.Drawing.Point(106, 403)
        Me.textoformadepago.Name = "textoformadepago"
        Me.textoformadepago.Size = New System.Drawing.Size(111, 21)
        Me.textoformadepago.TabIndex = 158
        Me.textoformadepago.Text = "Contado"
        '
        'botonterminarlineas
        '
        Me.botonterminarlineas.Enabled = False
        Me.botonterminarlineas.Image = CType(resources.GetObject("botonterminarlineas.Image"), System.Drawing.Image)
        Me.botonterminarlineas.Location = New System.Drawing.Point(549, 372)
        Me.botonterminarlineas.Name = "botonterminarlineas"
        Me.botonterminarlineas.Size = New System.Drawing.Size(26, 26)
        Me.botonterminarlineas.TabIndex = 157
        Me.botonterminarlineas.UseVisualStyleBackColor = True
        '
        'botonlimpiarlinea
        '
        Me.botonlimpiarlinea.BackgroundImage = CType(resources.GetObject("botonlimpiarlinea.BackgroundImage"), System.Drawing.Image)
        Me.botonlimpiarlinea.Enabled = False
        Me.botonlimpiarlinea.Image = CType(resources.GetObject("botonlimpiarlinea.Image"), System.Drawing.Image)
        Me.botonlimpiarlinea.Location = New System.Drawing.Point(518, 372)
        Me.botonlimpiarlinea.Name = "botonlimpiarlinea"
        Me.botonlimpiarlinea.Size = New System.Drawing.Size(26, 26)
        Me.botonlimpiarlinea.TabIndex = 156
        Me.botonlimpiarlinea.UseVisualStyleBackColor = True
        '
        'botoninsertarfila
        '
        Me.botoninsertarfila.BackgroundImage = CType(resources.GetObject("botoninsertarfila.BackgroundImage"), System.Drawing.Image)
        Me.botoninsertarfila.Enabled = False
        Me.botoninsertarfila.Image = CType(resources.GetObject("botoninsertarfila.Image"), System.Drawing.Image)
        Me.botoninsertarfila.Location = New System.Drawing.Point(486, 372)
        Me.botoninsertarfila.Name = "botoninsertarfila"
        Me.botoninsertarfila.Size = New System.Drawing.Size(26, 26)
        Me.botoninsertarfila.TabIndex = 155
        Me.botoninsertarfila.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botoninsertarfila.UseVisualStyleBackColor = True
        '
        'textoimportelinea
        '
        Me.textoimportelinea.Enabled = False
        Me.textoimportelinea.Location = New System.Drawing.Point(492, 346)
        Me.textoimportelinea.Name = "textoimportelinea"
        Me.textoimportelinea.Size = New System.Drawing.Size(83, 20)
        Me.textoimportelinea.TabIndex = 154
        Me.textoimportelinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textoproductodescuento
        '
        Me.textoproductodescuento.Enabled = False
        Me.textoproductodescuento.Location = New System.Drawing.Point(431, 346)
        Me.textoproductodescuento.Name = "textoproductodescuento"
        Me.textoproductodescuento.Size = New System.Drawing.Size(61, 20)
        Me.textoproductodescuento.TabIndex = 153
        Me.textoproductodescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textototalimpuestos
        '
        Me.textototalimpuestos.Enabled = False
        Me.textototalimpuestos.Location = New System.Drawing.Point(522, 542)
        Me.textototalimpuestos.Name = "textototalimpuestos"
        Me.textototalimpuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textototalimpuestos.Size = New System.Drawing.Size(54, 20)
        Me.textototalimpuestos.TabIndex = 152
        '
        'textoiva
        '
        Me.textoiva.Enabled = False
        Me.textoiva.Location = New System.Drawing.Point(522, 516)
        Me.textoiva.Name = "textoiva"
        Me.textoiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoiva.Size = New System.Drawing.Size(54, 20)
        Me.textoiva.TabIndex = 151
        '
        'botonnuevo
        '
        Me.botonnuevo.Location = New System.Drawing.Point(274, 593)
        Me.botonnuevo.Name = "botonnuevo"
        Me.botonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.botonnuevo.TabIndex = 150
        Me.botonnuevo.Text = "Nuevo"
        Me.botonnuevo.UseVisualStyleBackColor = True
        '
        'textobaseimponible
        '
        Me.textobaseimponible.Enabled = False
        Me.textobaseimponible.Location = New System.Drawing.Point(522, 486)
        Me.textobaseimponible.Name = "textobaseimponible"
        Me.textobaseimponible.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textobaseimponible.Size = New System.Drawing.Size(54, 20)
        Me.textobaseimponible.TabIndex = 149
        '
        'textoportes
        '
        Me.textoportes.Enabled = False
        Me.textoportes.Location = New System.Drawing.Point(522, 458)
        Me.textoportes.Name = "textoportes"
        Me.textoportes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoportes.Size = New System.Drawing.Size(54, 20)
        Me.textoportes.TabIndex = 148
        '
        'textodescuento
        '
        Me.textodescuento.Enabled = False
        Me.textodescuento.Location = New System.Drawing.Point(522, 429)
        Me.textodescuento.Name = "textodescuento"
        Me.textodescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textodescuento.Size = New System.Drawing.Size(54, 20)
        Me.textodescuento.TabIndex = 147
        '
        'textoporcentajedescuento
        '
        Me.textoporcentajedescuento.Enabled = False
        Me.textoporcentajedescuento.Location = New System.Drawing.Point(401, 429)
        Me.textoporcentajedescuento.Name = "textoporcentajedescuento"
        Me.textoporcentajedescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoporcentajedescuento.Size = New System.Drawing.Size(43, 20)
        Me.textoporcentajedescuento.TabIndex = 146
        '
        'textosuma
        '
        Me.textosuma.Enabled = False
        Me.textosuma.Location = New System.Drawing.Point(522, 404)
        Me.textosuma.Name = "textosuma"
        Me.textosuma.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textosuma.Size = New System.Drawing.Size(54, 20)
        Me.textosuma.TabIndex = 145
        '
        'tablalineaventa
        '
        Me.tablalineaventa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tablalineaventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablalineaventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlinea, Me.Descripcion, Me.PVP, Me.Unidad, Me.PorcentajeDescuento, Me.ImporteLinea})
        Me.tablalineaventa.Location = New System.Drawing.Point(15, 151)
        Me.tablalineaventa.Name = "tablalineaventa"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablalineaventa.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tablalineaventa.RowHeadersVisible = False
        Me.tablalineaventa.Size = New System.Drawing.Size(564, 181)
        Me.tablalineaventa.TabIndex = 144
        '
        'Nlinea
        '
        Me.Nlinea.HeaderText = "Nlinea"
        Me.Nlinea.Name = "Nlinea"
        Me.Nlinea.Width = 50
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 250
        '
        'PVP
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PVP.DefaultCellStyle = DataGridViewCellStyle1
        Me.PVP.HeaderText = "PVP"
        Me.PVP.Name = "PVP"
        Me.PVP.Width = 60
        '
        'Unidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Unidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Width = 60
        '
        'PorcentajeDescuento
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PorcentajeDescuento.DefaultCellStyle = DataGridViewCellStyle3
        Me.PorcentajeDescuento.HeaderText = "%Dto"
        Me.PorcentajeDescuento.Name = "PorcentajeDescuento"
        Me.PorcentajeDescuento.Width = 60
        '
        'ImporteLinea
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ImporteLinea.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteLinea.HeaderText = "ImporteLinea"
        Me.ImporteLinea.Name = "ImporteLinea"
        Me.ImporteLinea.Width = 80
        '
        'botonsalir
        '
        Me.botonsalir.Location = New System.Drawing.Point(501, 593)
        Me.botonsalir.Name = "botonsalir"
        Me.botonsalir.Size = New System.Drawing.Size(75, 23)
        Me.botonsalir.TabIndex = 143
        Me.botonsalir.Text = "Salir"
        Me.botonsalir.UseVisualStyleBackColor = True
        '
        'botoncancelar
        '
        Me.botoncancelar.Location = New System.Drawing.Point(426, 593)
        Me.botoncancelar.Name = "botoncancelar"
        Me.botoncancelar.Size = New System.Drawing.Size(75, 23)
        Me.botoncancelar.TabIndex = 142
        Me.botoncancelar.Text = "Cancelar"
        Me.botoncancelar.UseVisualStyleBackColor = True
        '
        'botonaceptar
        '
        Me.botonaceptar.Location = New System.Drawing.Point(350, 593)
        Me.botonaceptar.Name = "botonaceptar"
        Me.botonaceptar.Size = New System.Drawing.Size(75, 23)
        Me.botonaceptar.TabIndex = 141
        Me.botonaceptar.Text = "Aceptar"
        Me.botonaceptar.UseVisualStyleBackColor = True
        '
        'botonimprimir
        '
        Me.botonimprimir.Enabled = False
        Me.botonimprimir.Location = New System.Drawing.Point(127, 593)
        Me.botonimprimir.Name = "botonimprimir"
        Me.botonimprimir.Size = New System.Drawing.Size(75, 23)
        Me.botonimprimir.TabIndex = 140
        Me.botonimprimir.Text = "Imprimir"
        Me.botonimprimir.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(431, 549)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 139
        Me.Label16.Text = "Total impuesto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(471, 523)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "I.V.A:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(360, 523)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "%I.V.A:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(360, 436)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "%Dto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(429, 493)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "Base imponible:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(464, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Portes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(477, 436)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Dto:"
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(467, 408)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(37, 13)
        Me.Suma.TabIndex = 132
        Me.Suma.Text = "Suma:"
        '
        'textoobservaciones
        '
        Me.textoobservaciones.Location = New System.Drawing.Point(24, 464)
        Me.textoobservaciones.Name = "textoobservaciones"
        Me.textoobservaciones.Size = New System.Drawing.Size(135, 46)
        Me.textoobservaciones.TabIndex = 131
        Me.textoobservaciones.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Observaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Forma de pago"
        '
        'textodireccionentrega
        '
        Me.textodireccionentrega.Location = New System.Drawing.Point(15, 111)
        Me.textodireccionentrega.Name = "textodireccionentrega"
        Me.textodireccionentrega.Size = New System.Drawing.Size(178, 34)
        Me.textodireccionentrega.TabIndex = 128
        Me.textodireccionentrega.Text = ""
        '
        'textofecha
        '
        Me.textofecha.Location = New System.Drawing.Point(93, 61)
        Me.textofecha.Mask = "00/00/0000"
        Me.textofecha.Name = "textofecha"
        Me.textofecha.Size = New System.Drawing.Size(66, 20)
        Me.textofecha.TabIndex = 127
        Me.textofecha.ValidatingType = GetType(Date)
        '
        'textonumeroalbaran
        '
        Me.textonumeroalbaran.Location = New System.Drawing.Point(94, 35)
        Me.textonumeroalbaran.Name = "textonumeroalbaran"
        Me.textonumeroalbaran.Size = New System.Drawing.Size(53, 20)
        Me.textonumeroalbaran.TabIndex = 126
        Me.textonumeroalbaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Direccion de entrega"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Fecha Compra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Nº de Compra:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(587, 22)
        Me.StatusStrip1.TabIndex = 171
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'VentanaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(587, 652)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.textocliente)
        Me.Controls.Add(Me.textounidad)
        Me.Controls.Add(Me.textopvp)
        Me.Controls.Add(Me.textodescripcion)
        Me.Controls.Add(Me.textodatobuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textobuscar)
        Me.Controls.Add(Me.botonbuscar)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textoporcentajeiva)
        Me.Controls.Add(Me.botonfacturadirecta)
        Me.Controls.Add(Me.textoformadepago)
        Me.Controls.Add(Me.botonterminarlineas)
        Me.Controls.Add(Me.botonlimpiarlinea)
        Me.Controls.Add(Me.botoninsertarfila)
        Me.Controls.Add(Me.textoimportelinea)
        Me.Controls.Add(Me.textoproductodescuento)
        Me.Controls.Add(Me.textototalimpuestos)
        Me.Controls.Add(Me.textoiva)
        Me.Controls.Add(Me.botonnuevo)
        Me.Controls.Add(Me.textobaseimponible)
        Me.Controls.Add(Me.textoportes)
        Me.Controls.Add(Me.textodescuento)
        Me.Controls.Add(Me.textoporcentajedescuento)
        Me.Controls.Add(Me.textosuma)
        Me.Controls.Add(Me.tablalineaventa)
        Me.Controls.Add(Me.botonsalir)
        Me.Controls.Add(Me.botoncancelar)
        Me.Controls.Add(Me.botonaceptar)
        Me.Controls.Add(Me.botonimprimir)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Suma)
        Me.Controls.Add(Me.textoobservaciones)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textodireccionentrega)
        Me.Controls.Add(Me.textofecha)
        Me.Controls.Add(Me.textonumeroalbaran)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "VentanaCompra"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "VentanaCompra"
        CType(Me.tablalineaventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textocliente As RichTextBox
    Friend WithEvents textounidad As TextBox
    Friend WithEvents textopvp As TextBox
    Friend WithEvents textodescripcion As ComboBox
    Friend WithEvents textodatobuscar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textobuscar As ComboBox
    Friend WithEvents botonbuscar As Button
    Friend WithEvents Cliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textoporcentajeiva As ComboBox
    Friend WithEvents botonfacturadirecta As Button
    Friend WithEvents textoformadepago As ComboBox
    Friend WithEvents botonterminarlineas As Button
    Friend WithEvents botonlimpiarlinea As Button
    Friend WithEvents botoninsertarfila As Button
    Friend WithEvents textoimportelinea As TextBox
    Friend WithEvents textoproductodescuento As TextBox
    Friend WithEvents textototalimpuestos As TextBox
    Friend WithEvents textoiva As TextBox
    Friend WithEvents botonnuevo As Button
    Friend WithEvents textobaseimponible As TextBox
    Friend WithEvents textoportes As TextBox
    Friend WithEvents textodescuento As TextBox
    Friend WithEvents textoporcentajedescuento As TextBox
    Friend WithEvents textosuma As TextBox
    Friend WithEvents tablalineaventa As DataGridView
    Friend WithEvents botonsalir As Button
    Friend WithEvents botoncancelar As Button
    Friend WithEvents botonaceptar As Button
    Friend WithEvents botonimprimir As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Suma As Label
    Friend WithEvents textoobservaciones As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textodireccionentrega As RichTextBox
    Friend WithEvents textofecha As MaskedTextBox
    Friend WithEvents textonumeroalbaran As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Nlinea As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PVP As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDescuento As DataGridViewTextBoxColumn
    Friend WithEvents ImporteLinea As DataGridViewTextBoxColumn
End Class
