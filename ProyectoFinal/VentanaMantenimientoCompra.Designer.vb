﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaMantenimientoCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaMantenimientoCompra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.textocliente = New System.Windows.Forms.RichTextBox()
        Me.textoporcentajeiva = New System.Windows.Forms.ComboBox()
        Me.botonFacturadir = New System.Windows.Forms.Button()
        Me.textoformadepago = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.botoninsertarfila = New System.Windows.Forms.Button()
        Me.textoimportelinea = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.textounidad = New System.Windows.Forms.TextBox()
        Me.textopvp = New System.Windows.Forms.TextBox()
        Me.textodescripcion = New System.Windows.Forms.TextBox()
        Me.textototalimpuestos = New System.Windows.Forms.TextBox()
        Me.textoiva = New System.Windows.Forms.TextBox()
        Me.botonmodificar = New System.Windows.Forms.Button()
        Me.textobaseimponible = New System.Windows.Forms.TextBox()
        Me.textoportes = New System.Windows.Forms.TextBox()
        Me.textodescuento = New System.Windows.Forms.TextBox()
        Me.textoporcentajedescuento = New System.Windows.Forms.TextBox()
        Me.textosuma = New System.Windows.Forms.TextBox()
        Me.tablalineaventa = New System.Windows.Forms.DataGridView()
        Me.Nlinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codprod = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.StatusStrip1.SuspendLayout()
        CType(Me.tablalineaventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 633)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(616, 22)
        Me.StatusStrip1.TabIndex = 219
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'textocliente
        '
        Me.textocliente.Enabled = False
        Me.textocliente.Location = New System.Drawing.Point(385, 51)
        Me.textocliente.Name = "textocliente"
        Me.textocliente.Size = New System.Drawing.Size(197, 92)
        Me.textocliente.TabIndex = 218
        Me.textocliente.Text = ""
        '
        'textoporcentajeiva
        '
        Me.textoporcentajeiva.Enabled = False
        Me.textoporcentajeiva.FormattingEnabled = True
        Me.textoporcentajeiva.Location = New System.Drawing.Point(408, 522)
        Me.textoporcentajeiva.Name = "textoporcentajeiva"
        Me.textoporcentajeiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoporcentajeiva.Size = New System.Drawing.Size(52, 21)
        Me.textoporcentajeiva.TabIndex = 217
        '
        'botonFacturadir
        '
        Me.botonFacturadir.Location = New System.Drawing.Point(25, 599)
        Me.botonFacturadir.Name = "botonFacturadir"
        Me.botonFacturadir.Size = New System.Drawing.Size(100, 23)
        Me.botonFacturadir.TabIndex = 216
        Me.botonFacturadir.Text = "Factura directa"
        Me.botonFacturadir.UseVisualStyleBackColor = True
        '
        'textoformadepago
        '
        Me.textoformadepago.DisplayMember = "Contado"
        Me.textoformadepago.Enabled = False
        Me.textoformadepago.FormattingEnabled = True
        Me.textoformadepago.Items.AddRange(New Object() {"Contado"})
        Me.textoformadepago.Location = New System.Drawing.Point(113, 409)
        Me.textoformadepago.Name = "textoformadepago"
        Me.textoformadepago.Size = New System.Drawing.Size(115, 21)
        Me.textoformadepago.TabIndex = 215
        Me.textoformadepago.Text = "Contado"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(556, 370)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(26, 26)
        Me.Button6.TabIndex = 214
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Enabled = False
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(525, 370)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 26)
        Me.Button5.TabIndex = 213
        Me.Button5.UseVisualStyleBackColor = True
        '
        'botoninsertarfila
        '
        Me.botoninsertarfila.BackgroundImage = CType(resources.GetObject("botoninsertarfila.BackgroundImage"), System.Drawing.Image)
        Me.botoninsertarfila.Enabled = False
        Me.botoninsertarfila.Image = CType(resources.GetObject("botoninsertarfila.Image"), System.Drawing.Image)
        Me.botoninsertarfila.Location = New System.Drawing.Point(493, 370)
        Me.botoninsertarfila.Name = "botoninsertarfila"
        Me.botoninsertarfila.Size = New System.Drawing.Size(26, 26)
        Me.botoninsertarfila.TabIndex = 212
        Me.botoninsertarfila.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botoninsertarfila.UseVisualStyleBackColor = True
        '
        'textoimportelinea
        '
        Me.textoimportelinea.Enabled = False
        Me.textoimportelinea.Location = New System.Drawing.Point(503, 344)
        Me.textoimportelinea.Name = "textoimportelinea"
        Me.textoimportelinea.Size = New System.Drawing.Size(83, 20)
        Me.textoimportelinea.TabIndex = 211
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(442, 344)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(61, 20)
        Me.TextBox4.TabIndex = 210
        '
        'textounidad
        '
        Me.textounidad.Enabled = False
        Me.textounidad.Location = New System.Drawing.Point(385, 344)
        Me.textounidad.Name = "textounidad"
        Me.textounidad.Size = New System.Drawing.Size(57, 20)
        Me.textounidad.TabIndex = 209
        '
        'textopvp
        '
        Me.textopvp.Enabled = False
        Me.textopvp.Location = New System.Drawing.Point(324, 344)
        Me.textopvp.Name = "textopvp"
        Me.textopvp.Size = New System.Drawing.Size(61, 20)
        Me.textopvp.TabIndex = 208
        '
        'textodescripcion
        '
        Me.textodescripcion.Enabled = False
        Me.textodescripcion.Location = New System.Drawing.Point(128, 344)
        Me.textodescripcion.Name = "textodescripcion"
        Me.textodescripcion.Size = New System.Drawing.Size(198, 20)
        Me.textodescripcion.TabIndex = 207
        '
        'textototalimpuestos
        '
        Me.textototalimpuestos.Enabled = False
        Me.textototalimpuestos.Location = New System.Drawing.Point(529, 548)
        Me.textototalimpuestos.Name = "textototalimpuestos"
        Me.textototalimpuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textototalimpuestos.Size = New System.Drawing.Size(54, 20)
        Me.textototalimpuestos.TabIndex = 206
        '
        'textoiva
        '
        Me.textoiva.Enabled = False
        Me.textoiva.Location = New System.Drawing.Point(529, 522)
        Me.textoiva.Name = "textoiva"
        Me.textoiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoiva.Size = New System.Drawing.Size(54, 20)
        Me.textoiva.TabIndex = 205
        '
        'botonmodificar
        '
        Me.botonmodificar.Location = New System.Drawing.Point(281, 599)
        Me.botonmodificar.Name = "botonmodificar"
        Me.botonmodificar.Size = New System.Drawing.Size(75, 23)
        Me.botonmodificar.TabIndex = 204
        Me.botonmodificar.Text = "Modificar"
        Me.botonmodificar.UseVisualStyleBackColor = True
        '
        'textobaseimponible
        '
        Me.textobaseimponible.Enabled = False
        Me.textobaseimponible.Location = New System.Drawing.Point(529, 492)
        Me.textobaseimponible.Name = "textobaseimponible"
        Me.textobaseimponible.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textobaseimponible.Size = New System.Drawing.Size(54, 20)
        Me.textobaseimponible.TabIndex = 203
        '
        'textoportes
        '
        Me.textoportes.Enabled = False
        Me.textoportes.Location = New System.Drawing.Point(529, 464)
        Me.textoportes.Name = "textoportes"
        Me.textoportes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoportes.Size = New System.Drawing.Size(54, 20)
        Me.textoportes.TabIndex = 202
        '
        'textodescuento
        '
        Me.textodescuento.Enabled = False
        Me.textodescuento.Location = New System.Drawing.Point(529, 435)
        Me.textodescuento.Name = "textodescuento"
        Me.textodescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textodescuento.Size = New System.Drawing.Size(54, 20)
        Me.textodescuento.TabIndex = 201
        '
        'textoporcentajedescuento
        '
        Me.textoporcentajedescuento.Enabled = False
        Me.textoporcentajedescuento.Location = New System.Drawing.Point(408, 435)
        Me.textoporcentajedescuento.Name = "textoporcentajedescuento"
        Me.textoporcentajedescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textoporcentajedescuento.Size = New System.Drawing.Size(52, 20)
        Me.textoporcentajedescuento.TabIndex = 200
        '
        'textosuma
        '
        Me.textosuma.Enabled = False
        Me.textosuma.Location = New System.Drawing.Point(529, 410)
        Me.textosuma.Name = "textosuma"
        Me.textosuma.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.textosuma.Size = New System.Drawing.Size(54, 20)
        Me.textosuma.TabIndex = 199
        '
        'tablalineaventa
        '
        Me.tablalineaventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablalineaventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlinea, Me.Codprod, Me.Descripcion, Me.PVP, Me.Unidad, Me.PorcentajeDescuento, Me.ImporteLinea})
        Me.tablalineaventa.Location = New System.Drawing.Point(22, 157)
        Me.tablalineaventa.Name = "tablalineaventa"
        Me.tablalineaventa.RowHeadersVisible = False
        Me.tablalineaventa.Size = New System.Drawing.Size(564, 181)
        Me.tablalineaventa.TabIndex = 198
        '
        'Nlinea
        '
        Me.Nlinea.HeaderText = "Nlinea"
        Me.Nlinea.Name = "Nlinea"
        Me.Nlinea.Width = 50
        '
        'Codprod
        '
        Me.Codprod.HeaderText = "Codprod"
        Me.Codprod.Name = "Codprod"
        Me.Codprod.Width = 50
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 200
        '
        'PVP
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PVP.DefaultCellStyle = DataGridViewCellStyle1
        Me.PVP.HeaderText = "PVP"
        Me.PVP.Name = "PVP"
        Me.PVP.Width = 60
        '
        'Unidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Unidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Width = 60
        '
        'PorcentajeDescuento
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PorcentajeDescuento.DefaultCellStyle = DataGridViewCellStyle3
        Me.PorcentajeDescuento.HeaderText = "%Dto"
        Me.PorcentajeDescuento.Name = "PorcentajeDescuento"
        Me.PorcentajeDescuento.Width = 60
        '
        'ImporteLinea
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ImporteLinea.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteLinea.HeaderText = "ImporteLinea"
        Me.ImporteLinea.Name = "ImporteLinea"
        Me.ImporteLinea.Width = 80
        '
        'botonsalir
        '
        Me.botonsalir.Location = New System.Drawing.Point(508, 599)
        Me.botonsalir.Name = "botonsalir"
        Me.botonsalir.Size = New System.Drawing.Size(75, 23)
        Me.botonsalir.TabIndex = 197
        Me.botonsalir.Text = "Salir"
        Me.botonsalir.UseVisualStyleBackColor = True
        '
        'botoncancelar
        '
        Me.botoncancelar.Enabled = False
        Me.botoncancelar.Location = New System.Drawing.Point(433, 599)
        Me.botoncancelar.Name = "botoncancelar"
        Me.botoncancelar.Size = New System.Drawing.Size(75, 23)
        Me.botoncancelar.TabIndex = 196
        Me.botoncancelar.Text = "Cancelar"
        Me.botoncancelar.UseVisualStyleBackColor = True
        '
        'botonaceptar
        '
        Me.botonaceptar.Enabled = False
        Me.botonaceptar.Location = New System.Drawing.Point(357, 599)
        Me.botonaceptar.Name = "botonaceptar"
        Me.botonaceptar.Size = New System.Drawing.Size(75, 23)
        Me.botonaceptar.TabIndex = 195
        Me.botonaceptar.Text = "Aceptar"
        Me.botonaceptar.UseVisualStyleBackColor = True
        '
        'botonimprimir
        '
        Me.botonimprimir.Location = New System.Drawing.Point(176, 599)
        Me.botonimprimir.Name = "botonimprimir"
        Me.botonimprimir.Size = New System.Drawing.Size(75, 23)
        Me.botonimprimir.TabIndex = 194
        Me.botonimprimir.Text = "Imprimir"
        Me.botonimprimir.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(438, 555)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 193
        Me.Label16.Text = "Total impuesto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(478, 529)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 192
        Me.Label15.Text = "I.V.A:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(367, 529)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "%I.V.A:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(367, 442)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 190
        Me.Label13.Text = "%Dto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(436, 499)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Base imponible:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(471, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 188
        Me.Label11.Text = "Portes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(484, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "Dto:"
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(474, 414)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(37, 13)
        Me.Suma.TabIndex = 186
        Me.Suma.Text = "Suma:"
        '
        'textoobservaciones
        '
        Me.textoobservaciones.Enabled = False
        Me.textoobservaciones.Location = New System.Drawing.Point(31, 470)
        Me.textoobservaciones.Name = "textoobservaciones"
        Me.textoobservaciones.Size = New System.Drawing.Size(135, 46)
        Me.textoobservaciones.TabIndex = 185
        Me.textoobservaciones.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 451)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "Observaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Forma de pago"
        '
        'textodireccionentrega
        '
        Me.textodireccionentrega.Enabled = False
        Me.textodireccionentrega.Location = New System.Drawing.Point(22, 117)
        Me.textodireccionentrega.Name = "textodireccionentrega"
        Me.textodireccionentrega.Size = New System.Drawing.Size(178, 34)
        Me.textodireccionentrega.TabIndex = 182
        Me.textodireccionentrega.Text = ""
        '
        'textofecha
        '
        Me.textofecha.Enabled = False
        Me.textofecha.Location = New System.Drawing.Point(100, 69)
        Me.textofecha.Mask = "00/00/0000"
        Me.textofecha.Name = "textofecha"
        Me.textofecha.Size = New System.Drawing.Size(66, 20)
        Me.textofecha.TabIndex = 181
        Me.textofecha.ValidatingType = GetType(Date)
        '
        'textonumeroalbaran
        '
        Me.textonumeroalbaran.Enabled = False
        Me.textonumeroalbaran.Location = New System.Drawing.Point(100, 47)
        Me.textonumeroalbaran.Name = "textonumeroalbaran"
        Me.textonumeroalbaran.Size = New System.Drawing.Size(53, 20)
        Me.textonumeroalbaran.TabIndex = 180
        Me.textonumeroalbaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Direccion de entrega"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Fecha Albaran:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Nº de Albaran:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 24)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Datos de Compra"
        '
        'VentanaMantenimientoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(616, 655)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.textocliente)
        Me.Controls.Add(Me.textoporcentajeiva)
        Me.Controls.Add(Me.botonFacturadir)
        Me.Controls.Add(Me.textoformadepago)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.botoninsertarfila)
        Me.Controls.Add(Me.textoimportelinea)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.textounidad)
        Me.Controls.Add(Me.textopvp)
        Me.Controls.Add(Me.textodescripcion)
        Me.Controls.Add(Me.textototalimpuestos)
        Me.Controls.Add(Me.textoiva)
        Me.Controls.Add(Me.botonmodificar)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "VentanaMantenimientoCompra"
        Me.Text = "VentanaMantenimientoCompra"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.tablalineaventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents textocliente As RichTextBox
    Friend WithEvents textoporcentajeiva As ComboBox
    Friend WithEvents botonFacturadir As Button
    Friend WithEvents textoformadepago As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents botoninsertarfila As Button
    Friend WithEvents textoimportelinea As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents textounidad As TextBox
    Friend WithEvents textopvp As TextBox
    Friend WithEvents textodescripcion As TextBox
    Friend WithEvents textototalimpuestos As TextBox
    Friend WithEvents textoiva As TextBox
    Friend WithEvents botonmodificar As Button
    Friend WithEvents textobaseimponible As TextBox
    Friend WithEvents textoportes As TextBox
    Friend WithEvents textodescuento As TextBox
    Friend WithEvents textoporcentajedescuento As TextBox
    Friend WithEvents textosuma As TextBox
    Friend WithEvents tablalineaventa As DataGridView
    Friend WithEvents Nlinea As DataGridViewTextBoxColumn
    Friend WithEvents Codprod As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PVP As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDescuento As DataGridViewTextBoxColumn
    Friend WithEvents ImporteLinea As DataGridViewTextBoxColumn
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
End Class
