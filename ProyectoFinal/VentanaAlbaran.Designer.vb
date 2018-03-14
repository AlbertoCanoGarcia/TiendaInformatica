<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaAlbaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaAlbaran))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.textodatobuscar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textobuscar = New System.Windows.Forms.ComboBox()
        Me.botonbuscar = New System.Windows.Forms.Button()
        Me.textodescripcion = New System.Windows.Forms.ComboBox()
        Me.textopvp = New System.Windows.Forms.TextBox()
        Me.textounidad = New System.Windows.Forms.TextBox()
        Me.textocliente = New System.Windows.Forms.RichTextBox()
        Me.mensajeVentana = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.tablalineaventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mensajeVentana.SuspendLayout()
        Me.SuspendLayout()
        '
        'textoporcentajeiva
        '
        Me.textoporcentajeiva.Enabled = False
        Me.textoporcentajeiva.FormattingEnabled = True
        Me.textoporcentajeiva.Location = New System.Drawing.Point(395, 525)
        Me.textoporcentajeiva.Name = "textoporcentajeiva"
        Me.textoporcentajeiva.Size = New System.Drawing.Size(41, 21)
        Me.textoporcentajeiva.TabIndex = 110
        '
        'botonfacturadirecta
        '
        Me.botonfacturadirecta.Enabled = False
        Me.botonfacturadirecta.Location = New System.Drawing.Point(22, 564)
        Me.botonfacturadirecta.Name = "botonfacturadirecta"
        Me.botonfacturadirecta.Size = New System.Drawing.Size(63, 47)
        Me.botonfacturadirecta.TabIndex = 109
        Me.botonfacturadirecta.Text = "Factura Directa"
        Me.botonfacturadirecta.UseVisualStyleBackColor = True
        '
        'textoformadepago
        '
        Me.textoformadepago.DisplayMember = "Contado"
        Me.textoformadepago.Enabled = False
        Me.textoformadepago.FormattingEnabled = True
        Me.textoformadepago.Items.AddRange(New Object() {"Contado", "30-60 DIAS 2 partes", "30-60-90 DIAS 3", "30-120 DIAS 2", "A 30 DIAS 1"})
        Me.textoformadepago.Location = New System.Drawing.Point(100, 408)
        Me.textoformadepago.Name = "textoformadepago"
        Me.textoformadepago.Size = New System.Drawing.Size(111, 21)
        Me.textoformadepago.TabIndex = 104
        Me.textoformadepago.Text = "Contado"
        '
        'botonterminarlineas
        '
        Me.botonterminarlineas.Enabled = False
        Me.botonterminarlineas.Image = CType(resources.GetObject("botonterminarlineas.Image"), System.Drawing.Image)
        Me.botonterminarlineas.Location = New System.Drawing.Point(543, 369)
        Me.botonterminarlineas.Name = "botonterminarlineas"
        Me.botonterminarlineas.Size = New System.Drawing.Size(26, 26)
        Me.botonterminarlineas.TabIndex = 103
        Me.botonterminarlineas.UseVisualStyleBackColor = True
        '
        'botonlimpiarlinea
        '
        Me.botonlimpiarlinea.BackgroundImage = CType(resources.GetObject("botonlimpiarlinea.BackgroundImage"), System.Drawing.Image)
        Me.botonlimpiarlinea.Enabled = False
        Me.botonlimpiarlinea.Image = CType(resources.GetObject("botonlimpiarlinea.Image"), System.Drawing.Image)
        Me.botonlimpiarlinea.Location = New System.Drawing.Point(512, 369)
        Me.botonlimpiarlinea.Name = "botonlimpiarlinea"
        Me.botonlimpiarlinea.Size = New System.Drawing.Size(26, 26)
        Me.botonlimpiarlinea.TabIndex = 102
        Me.botonlimpiarlinea.UseVisualStyleBackColor = True
        '
        'botoninsertarfila
        '
        Me.botoninsertarfila.BackgroundImage = CType(resources.GetObject("botoninsertarfila.BackgroundImage"), System.Drawing.Image)
        Me.botoninsertarfila.Enabled = False
        Me.botoninsertarfila.Image = CType(resources.GetObject("botoninsertarfila.Image"), System.Drawing.Image)
        Me.botoninsertarfila.Location = New System.Drawing.Point(480, 369)
        Me.botoninsertarfila.Name = "botoninsertarfila"
        Me.botoninsertarfila.Size = New System.Drawing.Size(26, 26)
        Me.botoninsertarfila.TabIndex = 101
        Me.botoninsertarfila.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botoninsertarfila.UseVisualStyleBackColor = True
        '
        'textoimportelinea
        '
        Me.textoimportelinea.Enabled = False
        Me.textoimportelinea.Location = New System.Drawing.Point(490, 344)
        Me.textoimportelinea.Name = "textoimportelinea"
        Me.textoimportelinea.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoimportelinea.Size = New System.Drawing.Size(83, 20)
        Me.textoimportelinea.TabIndex = 100
        '
        'textoproductodescuento
        '
        Me.textoproductodescuento.Enabled = False
        Me.textoproductodescuento.Location = New System.Drawing.Point(429, 344)
        Me.textoproductodescuento.Name = "textoproductodescuento"
        Me.textoproductodescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoproductodescuento.Size = New System.Drawing.Size(61, 20)
        Me.textoproductodescuento.TabIndex = 99
        '
        'textototalimpuestos
        '
        Me.textototalimpuestos.Enabled = False
        Me.textototalimpuestos.Location = New System.Drawing.Point(516, 547)
        Me.textototalimpuestos.Name = "textototalimpuestos"
        Me.textototalimpuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textototalimpuestos.Size = New System.Drawing.Size(54, 20)
        Me.textototalimpuestos.TabIndex = 93
        '
        'textoiva
        '
        Me.textoiva.Enabled = False
        Me.textoiva.Location = New System.Drawing.Point(516, 521)
        Me.textoiva.Name = "textoiva"
        Me.textoiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoiva.Size = New System.Drawing.Size(54, 20)
        Me.textoiva.TabIndex = 92
        '
        'botonnuevo
        '
        Me.botonnuevo.Location = New System.Drawing.Point(272, 588)
        Me.botonnuevo.Name = "botonnuevo"
        Me.botonnuevo.Size = New System.Drawing.Size(75, 23)
        Me.botonnuevo.TabIndex = 91
        Me.botonnuevo.Text = "Nuevo"
        Me.botonnuevo.UseVisualStyleBackColor = True
        '
        'textobaseimponible
        '
        Me.textobaseimponible.Enabled = False
        Me.textobaseimponible.Location = New System.Drawing.Point(516, 491)
        Me.textobaseimponible.Name = "textobaseimponible"
        Me.textobaseimponible.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textobaseimponible.Size = New System.Drawing.Size(54, 20)
        Me.textobaseimponible.TabIndex = 90
        '
        'textoportes
        '
        Me.textoportes.Enabled = False
        Me.textoportes.Location = New System.Drawing.Point(516, 463)
        Me.textoportes.Name = "textoportes"
        Me.textoportes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoportes.Size = New System.Drawing.Size(54, 20)
        Me.textoportes.TabIndex = 89
        '
        'textodescuento
        '
        Me.textodescuento.Enabled = False
        Me.textodescuento.Location = New System.Drawing.Point(516, 434)
        Me.textodescuento.Name = "textodescuento"
        Me.textodescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textodescuento.Size = New System.Drawing.Size(54, 20)
        Me.textodescuento.TabIndex = 88
        '
        'textoporcentajedescuento
        '
        Me.textoporcentajedescuento.Enabled = False
        Me.textoporcentajedescuento.Location = New System.Drawing.Point(395, 434)
        Me.textoporcentajedescuento.Name = "textoporcentajedescuento"
        Me.textoporcentajedescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoporcentajedescuento.Size = New System.Drawing.Size(43, 20)
        Me.textoporcentajedescuento.TabIndex = 87
        '
        'textosuma
        '
        Me.textosuma.Enabled = False
        Me.textosuma.Location = New System.Drawing.Point(516, 409)
        Me.textosuma.Name = "textosuma"
        Me.textosuma.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textosuma.Size = New System.Drawing.Size(54, 20)
        Me.textosuma.TabIndex = 86
        '
        'tablalineaventa
        '
        Me.tablalineaventa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tablalineaventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablalineaventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlinea, Me.Descripcion, Me.PVP, Me.Unidad, Me.PorcentajeDescuento, Me.ImporteLinea})
        Me.tablalineaventa.Location = New System.Drawing.Point(9, 152)
        Me.tablalineaventa.Name = "tablalineaventa"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablalineaventa.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.tablalineaventa.RowHeadersVisible = False
        Me.tablalineaventa.Size = New System.Drawing.Size(564, 181)
        Me.tablalineaventa.TabIndex = 83
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PVP.DefaultCellStyle = DataGridViewCellStyle6
        Me.PVP.HeaderText = "PVP"
        Me.PVP.Name = "PVP"
        Me.PVP.Width = 60
        '
        'Unidad
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Unidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Width = 60
        '
        'PorcentajeDescuento
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PorcentajeDescuento.DefaultCellStyle = DataGridViewCellStyle8
        Me.PorcentajeDescuento.HeaderText = "%Dto"
        Me.PorcentajeDescuento.Name = "PorcentajeDescuento"
        Me.PorcentajeDescuento.Width = 60
        '
        'ImporteLinea
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ImporteLinea.DefaultCellStyle = DataGridViewCellStyle9
        Me.ImporteLinea.HeaderText = "ImporteLinea"
        Me.ImporteLinea.Name = "ImporteLinea"
        Me.ImporteLinea.Width = 80
        '
        'botonsalir
        '
        Me.botonsalir.Location = New System.Drawing.Point(499, 588)
        Me.botonsalir.Name = "botonsalir"
        Me.botonsalir.Size = New System.Drawing.Size(75, 23)
        Me.botonsalir.TabIndex = 82
        Me.botonsalir.Text = "Salir"
        Me.botonsalir.UseVisualStyleBackColor = True
        '
        'botoncancelar
        '
        Me.botoncancelar.Location = New System.Drawing.Point(424, 588)
        Me.botoncancelar.Name = "botoncancelar"
        Me.botoncancelar.Size = New System.Drawing.Size(75, 23)
        Me.botoncancelar.TabIndex = 81
        Me.botoncancelar.Text = "Cancelar"
        Me.botoncancelar.UseVisualStyleBackColor = True
        '
        'botonaceptar
        '
        Me.botonaceptar.Location = New System.Drawing.Point(348, 588)
        Me.botonaceptar.Name = "botonaceptar"
        Me.botonaceptar.Size = New System.Drawing.Size(75, 23)
        Me.botonaceptar.TabIndex = 80
        Me.botonaceptar.Text = "Aceptar"
        Me.botonaceptar.UseVisualStyleBackColor = True
        '
        'botonimprimir
        '
        Me.botonimprimir.Enabled = False
        Me.botonimprimir.Location = New System.Drawing.Point(125, 588)
        Me.botonimprimir.Name = "botonimprimir"
        Me.botonimprimir.Size = New System.Drawing.Size(75, 23)
        Me.botonimprimir.TabIndex = 79
        Me.botonimprimir.Text = "Imprimir"
        Me.botonimprimir.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(425, 554)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Total impuesto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(465, 528)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "I.V.A:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(354, 528)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "%I.V.A:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(354, 441)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "%Dto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(423, 498)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Base imponible:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(458, 470)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Portes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(471, 441)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Dto:"
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(461, 413)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(37, 13)
        Me.Suma.TabIndex = 71
        Me.Suma.Text = "Suma:"
        '
        'textoobservaciones
        '
        Me.textoobservaciones.Location = New System.Drawing.Point(18, 469)
        Me.textoobservaciones.Name = "textoobservaciones"
        Me.textoobservaciones.Size = New System.Drawing.Size(135, 46)
        Me.textoobservaciones.TabIndex = 70
        Me.textoobservaciones.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 450)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Observaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Forma de pago"
        '
        'textodireccionentrega
        '
        Me.textodireccionentrega.Location = New System.Drawing.Point(9, 112)
        Me.textodireccionentrega.Name = "textodireccionentrega"
        Me.textodireccionentrega.Size = New System.Drawing.Size(178, 34)
        Me.textodireccionentrega.TabIndex = 66
        Me.textodireccionentrega.Text = ""
        '
        'textofecha
        '
        Me.textofecha.Location = New System.Drawing.Point(87, 62)
        Me.textofecha.Mask = "00/00/0000"
        Me.textofecha.Name = "textofecha"
        Me.textofecha.Size = New System.Drawing.Size(66, 20)
        Me.textofecha.TabIndex = 63
        Me.textofecha.ValidatingType = GetType(Date)
        '
        'textonumeroalbaran
        '
        Me.textonumeroalbaran.Location = New System.Drawing.Point(88, 36)
        Me.textonumeroalbaran.Name = "textonumeroalbaran"
        Me.textonumeroalbaran.Size = New System.Drawing.Size(53, 20)
        Me.textonumeroalbaran.TabIndex = 62
        Me.textonumeroalbaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Direccion de entrega"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Fecha Albaran:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nº de Albaran:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 24)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Albaran de venta"
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(199, 45)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 112
        Me.Cliente.Text = "Cliente"
        '
        'textodatobuscar
        '
        Me.textodatobuscar.Enabled = False
        Me.textodatobuscar.FormattingEnabled = True
        Me.textodatobuscar.Location = New System.Drawing.Point(203, 96)
        Me.textodatobuscar.Name = "textodatobuscar"
        Me.textodatobuscar.Size = New System.Drawing.Size(145, 21)
        Me.textodatobuscar.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Buscar Por:"
        '
        'textobuscar
        '
        Me.textobuscar.Enabled = False
        Me.textobuscar.FormattingEnabled = True
        Me.textobuscar.Items.AddRange(New Object() {"id"})
        Me.textobuscar.Location = New System.Drawing.Point(268, 66)
        Me.textobuscar.Name = "textobuscar"
        Me.textobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textobuscar.TabIndex = 114
        '
        'botonbuscar
        '
        Me.botonbuscar.Location = New System.Drawing.Point(268, 40)
        Me.botonbuscar.Name = "botonbuscar"
        Me.botonbuscar.Size = New System.Drawing.Size(75, 23)
        Me.botonbuscar.TabIndex = 113
        Me.botonbuscar.Text = "Buscar"
        Me.botonbuscar.UseVisualStyleBackColor = True
        '
        'textodescripcion
        '
        Me.textodescripcion.Enabled = False
        Me.textodescripcion.FormattingEnabled = True
        Me.textodescripcion.Location = New System.Drawing.Point(57, 344)
        Me.textodescripcion.Name = "textodescripcion"
        Me.textodescripcion.Size = New System.Drawing.Size(256, 21)
        Me.textodescripcion.TabIndex = 119
        '
        'textopvp
        '
        Me.textopvp.Enabled = False
        Me.textopvp.Location = New System.Drawing.Point(313, 344)
        Me.textopvp.Name = "textopvp"
        Me.textopvp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textopvp.Size = New System.Drawing.Size(60, 20)
        Me.textopvp.TabIndex = 120
        '
        'textounidad
        '
        Me.textounidad.Enabled = False
        Me.textounidad.Location = New System.Drawing.Point(373, 344)
        Me.textounidad.Name = "textounidad"
        Me.textounidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textounidad.Size = New System.Drawing.Size(56, 20)
        Me.textounidad.TabIndex = 121
        '
        'textocliente
        '
        Me.textocliente.Enabled = False
        Me.textocliente.Location = New System.Drawing.Point(410, 45)
        Me.textocliente.Name = "textocliente"
        Me.textocliente.Size = New System.Drawing.Size(159, 74)
        Me.textocliente.TabIndex = 122
        Me.textocliente.Text = ""
        '
        'mensajeVentana
        '
        Me.mensajeVentana.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.mensajeVentana.Location = New System.Drawing.Point(0, 631)
        Me.mensajeVentana.Name = "mensajeVentana"
        Me.mensajeVentana.Size = New System.Drawing.Size(590, 22)
        Me.mensajeVentana.TabIndex = 123
        Me.mensajeVentana.Text = "asdfsd"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'VentanaAlbaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(590, 653)
        Me.Controls.Add(Me.mensajeVentana)
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
        Me.Name = "VentanaAlbaran"
        Me.Text = "VentanaAlbaran"
        CType(Me.tablalineaventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mensajeVentana.ResumeLayout(False)
        Me.mensajeVentana.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Label1 As Label
    Friend WithEvents Cliente As Label
    Friend WithEvents textodatobuscar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textobuscar As ComboBox
    Friend WithEvents botonbuscar As Button
    Friend WithEvents textodescripcion As ComboBox
    Friend WithEvents textopvp As TextBox
    Friend WithEvents textounidad As TextBox
    Friend WithEvents textocliente As RichTextBox
    Friend WithEvents mensajeVentana As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Nlinea As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PVP As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDescuento As DataGridViewTextBoxColumn
    Friend WithEvents ImporteLinea As DataGridViewTextBoxColumn
End Class
