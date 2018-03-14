<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim IdArticulosLabel As System.Windows.Forms.Label
        Dim IdProveedoresLabel As System.Windows.Forms.Label
        Dim IdMarcaLabel As System.Windows.Forms.Label
        Dim IdTipoArticuloLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioCompraLabel As System.Windows.Forms.Label
        Dim PvpLabel As System.Windows.Forms.Label
        Dim StockActualLabel As System.Windows.Forms.Label
        Dim StockMinimoLabel As System.Windows.Forms.Label
        Dim Pvp1Label As System.Windows.Forms.Label
        Dim Pvp2Label As System.Windows.Forms.Label
        Dim Pvp3Label As System.Windows.Forms.Label
        Dim GarantiaLabel As System.Windows.Forms.Label
        Me.ArticulosDataSet = New ProyectoFinal.ArticulosDataSet()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ProyectoFinal.ArticulosDataSetTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager = New ProyectoFinal.ArticulosDataSetTableAdapters.TableAdapterManager()
        Me.textoIdArticulos = New System.Windows.Forms.TextBox()
        Me.textoDescripcion = New System.Windows.Forms.TextBox()
        Me.textoPrecioCompra = New System.Windows.Forms.TextBox()
        Me.textoPvp = New System.Windows.Forms.TextBox()
        Me.textoStockActual = New System.Windows.Forms.TextBox()
        Me.textoStockMinimo = New System.Windows.Forms.TextBox()
        Me.textoPvp1 = New System.Windows.Forms.TextBox()
        Me.textoPvp2 = New System.Windows.Forms.TextBox()
        Me.textoPvp3 = New System.Windows.Forms.TextBox()
        Me.textoGarantia = New System.Windows.Forms.TextBox()
        Me.Baceptar = New System.Windows.Forms.Button()
        Me.Bcancelar = New System.Windows.Forms.Button()
        Me.Bultimo = New System.Windows.Forms.Button()
        Me.BSiguiente = New System.Windows.Forms.Button()
        Me.BAnterior = New System.Windows.Forms.Button()
        Me.Bprimero = New System.Windows.Forms.Button()
        Me.Bmodifi = New System.Windows.Forms.Button()
        Me.Bbaja = New System.Windows.Forms.Button()
        Me.Bconsulta = New System.Windows.Forms.Button()
        Me.textoproveedor = New System.Windows.Forms.ComboBox()
        Me.textomarca = New System.Windows.Forms.ComboBox()
        Me.textotipoarticulo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BAlta = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.textobuscar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botonok = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        IdArticulosLabel = New System.Windows.Forms.Label()
        IdProveedoresLabel = New System.Windows.Forms.Label()
        IdMarcaLabel = New System.Windows.Forms.Label()
        IdTipoArticuloLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioCompraLabel = New System.Windows.Forms.Label()
        PvpLabel = New System.Windows.Forms.Label()
        StockActualLabel = New System.Windows.Forms.Label()
        StockMinimoLabel = New System.Windows.Forms.Label()
        Pvp1Label = New System.Windows.Forms.Label()
        Pvp2Label = New System.Windows.Forms.Label()
        Pvp3Label = New System.Windows.Forms.Label()
        GarantiaLabel = New System.Windows.Forms.Label()
        CType(Me.ArticulosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdArticulosLabel
        '
        IdArticulosLabel.AutoSize = True
        IdArticulosLabel.Location = New System.Drawing.Point(13, 25)
        IdArticulosLabel.Name = "IdArticulosLabel"
        IdArticulosLabel.Size = New System.Drawing.Size(45, 13)
        IdArticulosLabel.TabIndex = 1
        IdArticulosLabel.Text = "Articulo:"
        '
        'IdProveedoresLabel
        '
        IdProveedoresLabel.AutoSize = True
        IdProveedoresLabel.Location = New System.Drawing.Point(13, 51)
        IdProveedoresLabel.Name = "IdProveedoresLabel"
        IdProveedoresLabel.Size = New System.Drawing.Size(59, 13)
        IdProveedoresLabel.TabIndex = 3
        IdProveedoresLabel.Text = "Proveedor:"
        '
        'IdMarcaLabel
        '
        IdMarcaLabel.AutoSize = True
        IdMarcaLabel.Location = New System.Drawing.Point(13, 77)
        IdMarcaLabel.Name = "IdMarcaLabel"
        IdMarcaLabel.Size = New System.Drawing.Size(40, 13)
        IdMarcaLabel.TabIndex = 5
        IdMarcaLabel.Text = "Marca:"
        '
        'IdTipoArticuloLabel
        '
        IdTipoArticuloLabel.AutoSize = True
        IdTipoArticuloLabel.Location = New System.Drawing.Point(13, 103)
        IdTipoArticuloLabel.Name = "IdTipoArticuloLabel"
        IdTipoArticuloLabel.Size = New System.Drawing.Size(69, 13)
        IdTipoArticuloLabel.TabIndex = 7
        IdTipoArticuloLabel.Text = "Tipo Articulo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(13, 131)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 9
        DescripcionLabel.Text = "Descripcion:"
        '
        'PrecioCompraLabel
        '
        PrecioCompraLabel.AutoSize = True
        PrecioCompraLabel.Location = New System.Drawing.Point(7, 62)
        PrecioCompraLabel.Name = "PrecioCompraLabel"
        PrecioCompraLabel.Size = New System.Drawing.Size(79, 13)
        PrecioCompraLabel.TabIndex = 11
        PrecioCompraLabel.Text = "Precio Compra:"
        '
        'PvpLabel
        '
        PvpLabel.AutoSize = True
        PvpLabel.Location = New System.Drawing.Point(6, 88)
        PvpLabel.Name = "PvpLabel"
        PvpLabel.Size = New System.Drawing.Size(31, 13)
        PvpLabel.TabIndex = 13
        PvpLabel.Text = "PVP:"
        '
        'StockActualLabel
        '
        StockActualLabel.AutoSize = True
        StockActualLabel.Location = New System.Drawing.Point(7, 114)
        StockActualLabel.Name = "StockActualLabel"
        StockActualLabel.Size = New System.Drawing.Size(71, 13)
        StockActualLabel.TabIndex = 15
        StockActualLabel.Text = "Stock Actual:"
        '
        'StockMinimoLabel
        '
        StockMinimoLabel.AutoSize = True
        StockMinimoLabel.Location = New System.Drawing.Point(205, 36)
        StockMinimoLabel.Name = "StockMinimoLabel"
        StockMinimoLabel.Size = New System.Drawing.Size(74, 13)
        StockMinimoLabel.TabIndex = 17
        StockMinimoLabel.Text = "Stock Minimo:"
        '
        'Pvp1Label
        '
        Pvp1Label.AutoSize = True
        Pvp1Label.Location = New System.Drawing.Point(205, 62)
        Pvp1Label.Name = "Pvp1Label"
        Pvp1Label.Size = New System.Drawing.Size(37, 13)
        Pvp1Label.TabIndex = 19
        Pvp1Label.Text = "PVP1:"
        '
        'Pvp2Label
        '
        Pvp2Label.AutoSize = True
        Pvp2Label.Location = New System.Drawing.Point(205, 88)
        Pvp2Label.Name = "Pvp2Label"
        Pvp2Label.Size = New System.Drawing.Size(37, 13)
        Pvp2Label.TabIndex = 21
        Pvp2Label.Text = "PVP2:"
        '
        'Pvp3Label
        '
        Pvp3Label.AutoSize = True
        Pvp3Label.Location = New System.Drawing.Point(205, 114)
        Pvp3Label.Name = "Pvp3Label"
        Pvp3Label.Size = New System.Drawing.Size(37, 13)
        Pvp3Label.TabIndex = 23
        Pvp3Label.Text = "PVP3:"
        '
        'GarantiaLabel
        '
        GarantiaLabel.AutoSize = True
        GarantiaLabel.Location = New System.Drawing.Point(7, 35)
        GarantiaLabel.Name = "GarantiaLabel"
        GarantiaLabel.Size = New System.Drawing.Size(50, 13)
        GarantiaLabel.TabIndex = 25
        GarantiaLabel.Text = "Garantia:"
        '
        'ArticulosDataSet
        '
        Me.ArticulosDataSet.DataSetName = "ArticulosDataSet"
        Me.ArticulosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.ArticulosDataSet
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ProyectoFinal.ArticulosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'textoIdArticulos
        '
        Me.textoIdArticulos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "IdArticulos", True))
        Me.textoIdArticulos.Location = New System.Drawing.Point(100, 22)
        Me.textoIdArticulos.Name = "textoIdArticulos"
        Me.textoIdArticulos.Size = New System.Drawing.Size(52, 20)
        Me.textoIdArticulos.TabIndex = 2
        '
        'textoDescripcion
        '
        Me.textoDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "descripcion", True))
        Me.textoDescripcion.Location = New System.Drawing.Point(100, 128)
        Me.textoDescripcion.Name = "textoDescripcion"
        Me.textoDescripcion.Size = New System.Drawing.Size(133, 20)
        Me.textoDescripcion.TabIndex = 10
        '
        'textoPrecioCompra
        '
        Me.textoPrecioCompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "precioCompra", True))
        Me.textoPrecioCompra.Location = New System.Drawing.Point(94, 59)
        Me.textoPrecioCompra.Name = "textoPrecioCompra"
        Me.textoPrecioCompra.Size = New System.Drawing.Size(44, 20)
        Me.textoPrecioCompra.TabIndex = 12
        '
        'textoPvp
        '
        Me.textoPvp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "pvp", True))
        Me.textoPvp.Location = New System.Drawing.Point(94, 85)
        Me.textoPvp.Name = "textoPvp"
        Me.textoPvp.Size = New System.Drawing.Size(44, 20)
        Me.textoPvp.TabIndex = 14
        '
        'textoStockActual
        '
        Me.textoStockActual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "stockActual", True))
        Me.textoStockActual.Location = New System.Drawing.Point(94, 110)
        Me.textoStockActual.Name = "textoStockActual"
        Me.textoStockActual.Size = New System.Drawing.Size(44, 20)
        Me.textoStockActual.TabIndex = 16
        '
        'textoStockMinimo
        '
        Me.textoStockMinimo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "stockMinimo", True))
        Me.textoStockMinimo.Location = New System.Drawing.Point(279, 33)
        Me.textoStockMinimo.Name = "textoStockMinimo"
        Me.textoStockMinimo.Size = New System.Drawing.Size(44, 20)
        Me.textoStockMinimo.TabIndex = 18
        '
        'textoPvp1
        '
        Me.textoPvp1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "pvp1", True))
        Me.textoPvp1.Location = New System.Drawing.Point(279, 59)
        Me.textoPvp1.Name = "textoPvp1"
        Me.textoPvp1.Size = New System.Drawing.Size(44, 20)
        Me.textoPvp1.TabIndex = 20
        '
        'textoPvp2
        '
        Me.textoPvp2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "pvp2", True))
        Me.textoPvp2.Location = New System.Drawing.Point(279, 85)
        Me.textoPvp2.Name = "textoPvp2"
        Me.textoPvp2.Size = New System.Drawing.Size(44, 20)
        Me.textoPvp2.TabIndex = 22
        '
        'textoPvp3
        '
        Me.textoPvp3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "pvp3", True))
        Me.textoPvp3.Location = New System.Drawing.Point(279, 111)
        Me.textoPvp3.Name = "textoPvp3"
        Me.textoPvp3.Size = New System.Drawing.Size(44, 20)
        Me.textoPvp3.TabIndex = 24
        '
        'textoGarantia
        '
        Me.textoGarantia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "garantia", True))
        Me.textoGarantia.Location = New System.Drawing.Point(94, 32)
        Me.textoGarantia.Name = "textoGarantia"
        Me.textoGarantia.Size = New System.Drawing.Size(61, 20)
        Me.textoGarantia.TabIndex = 26
        '
        'Baceptar
        '
        Me.Baceptar.Enabled = False
        Me.Baceptar.Location = New System.Drawing.Point(301, 257)
        Me.Baceptar.Name = "Baceptar"
        Me.Baceptar.Size = New System.Drawing.Size(60, 23)
        Me.Baceptar.TabIndex = 27
        Me.Baceptar.Text = "Aceptar"
        Me.Baceptar.UseVisualStyleBackColor = True
        '
        'Bcancelar
        '
        Me.Bcancelar.Enabled = False
        Me.Bcancelar.Location = New System.Drawing.Point(390, 257)
        Me.Bcancelar.Name = "Bcancelar"
        Me.Bcancelar.Size = New System.Drawing.Size(62, 23)
        Me.Bcancelar.TabIndex = 28
        Me.Bcancelar.Text = "Cancelar"
        Me.Bcancelar.UseVisualStyleBackColor = True
        '
        'Bultimo
        '
        Me.Bultimo.Location = New System.Drawing.Point(550, 211)
        Me.Bultimo.Name = "Bultimo"
        Me.Bultimo.Size = New System.Drawing.Size(36, 23)
        Me.Bultimo.TabIndex = 37
        Me.Bultimo.Text = ">>"
        Me.Bultimo.UseVisualStyleBackColor = True
        '
        'BSiguiente
        '
        Me.BSiguiente.Location = New System.Drawing.Point(502, 211)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(42, 23)
        Me.BSiguiente.TabIndex = 36
        Me.BSiguiente.Text = ">"
        Me.BSiguiente.UseVisualStyleBackColor = True
        '
        'BAnterior
        '
        Me.BAnterior.Location = New System.Drawing.Point(457, 211)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(39, 23)
        Me.BAnterior.TabIndex = 35
        Me.BAnterior.Text = "<"
        Me.BAnterior.UseVisualStyleBackColor = True
        '
        'Bprimero
        '
        Me.Bprimero.Location = New System.Drawing.Point(407, 211)
        Me.Bprimero.Name = "Bprimero"
        Me.Bprimero.Size = New System.Drawing.Size(44, 23)
        Me.Bprimero.TabIndex = 34
        Me.Bprimero.Text = "<<"
        Me.Bprimero.UseVisualStyleBackColor = True
        '
        'Bmodifi
        '
        Me.Bmodifi.Location = New System.Drawing.Point(180, 257)
        Me.Bmodifi.Name = "Bmodifi"
        Me.Bmodifi.Size = New System.Drawing.Size(67, 23)
        Me.Bmodifi.TabIndex = 38
        Me.Bmodifi.Text = "Modificar"
        Me.Bmodifi.UseVisualStyleBackColor = True
        '
        'Bbaja
        '
        Me.Bbaja.Location = New System.Drawing.Point(105, 257)
        Me.Bbaja.Name = "Bbaja"
        Me.Bbaja.Size = New System.Drawing.Size(69, 23)
        Me.Bbaja.TabIndex = 39
        Me.Bbaja.Text = "Baja"
        Me.Bbaja.UseVisualStyleBackColor = True
        '
        'Bconsulta
        '
        Me.Bconsulta.Location = New System.Drawing.Point(12, 209)
        Me.Bconsulta.Name = "Bconsulta"
        Me.Bconsulta.Size = New System.Drawing.Size(75, 23)
        Me.Bconsulta.TabIndex = 40
        Me.Bconsulta.Text = "Buscar"
        Me.Bconsulta.UseVisualStyleBackColor = True
        '
        'textoproveedor
        '
        Me.textoproveedor.FormattingEnabled = True
        Me.textoproveedor.Location = New System.Drawing.Point(100, 48)
        Me.textoproveedor.Name = "textoproveedor"
        Me.textoproveedor.Size = New System.Drawing.Size(129, 21)
        Me.textoproveedor.TabIndex = 41
        '
        'textomarca
        '
        Me.textomarca.FormattingEnabled = True
        Me.textomarca.Location = New System.Drawing.Point(100, 73)
        Me.textomarca.Name = "textomarca"
        Me.textomarca.Size = New System.Drawing.Size(105, 21)
        Me.textomarca.TabIndex = 42
        '
        'textotipoarticulo
        '
        Me.textotipoarticulo.FormattingEnabled = True
        Me.textotipoarticulo.Location = New System.Drawing.Point(100, 99)
        Me.textotipoarticulo.Name = "textotipoarticulo"
        Me.textotipoarticulo.Size = New System.Drawing.Size(105, 21)
        Me.textotipoarticulo.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(206, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Gestion de productos"
        '
        'BAlta
        '
        Me.BAlta.Location = New System.Drawing.Point(17, 257)
        Me.BAlta.Name = "BAlta"
        Me.BAlta.Size = New System.Drawing.Size(75, 23)
        Me.BAlta.TabIndex = 45
        Me.BAlta.Text = "Alta"
        Me.BAlta.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(532, 257)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 46
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'textobuscar
        '
        Me.textobuscar.FormattingEnabled = True
        Me.textobuscar.Location = New System.Drawing.Point(205, 211)
        Me.textobuscar.Name = "textobuscar"
        Me.textobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textobuscar.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Introducir nombre"
        '
        'botonok
        '
        Me.botonok.Location = New System.Drawing.Point(341, 211)
        Me.botonok.Name = "botonok"
        Me.botonok.Size = New System.Drawing.Size(41, 23)
        Me.botonok.TabIndex = 49
        Me.botonok.Text = "Ok"
        Me.botonok.UseVisualStyleBackColor = True
        Me.botonok.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textotipoarticulo)
        Me.GroupBox1.Controls.Add(Me.textomarca)
        Me.GroupBox1.Controls.Add(Me.textoproveedor)
        Me.GroupBox1.Controls.Add(IdArticulosLabel)
        Me.GroupBox1.Controls.Add(Me.textoIdArticulos)
        Me.GroupBox1.Controls.Add(IdProveedoresLabel)
        Me.GroupBox1.Controls.Add(IdMarcaLabel)
        Me.GroupBox1.Controls.Add(IdTipoArticuloLabel)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.textoDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 165)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripcion "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(PrecioCompraLabel)
        Me.GroupBox2.Controls.Add(Me.textoPrecioCompra)
        Me.GroupBox2.Controls.Add(PvpLabel)
        Me.GroupBox2.Controls.Add(Me.textoPvp)
        Me.GroupBox2.Controls.Add(StockActualLabel)
        Me.GroupBox2.Controls.Add(Me.textoStockActual)
        Me.GroupBox2.Controls.Add(StockMinimoLabel)
        Me.GroupBox2.Controls.Add(Me.textoStockMinimo)
        Me.GroupBox2.Controls.Add(Pvp1Label)
        Me.GroupBox2.Controls.Add(Me.textoPvp1)
        Me.GroupBox2.Controls.Add(Pvp2Label)
        Me.GroupBox2.Controls.Add(Me.textoPvp2)
        Me.GroupBox2.Controls.Add(Pvp3Label)
        Me.GroupBox2.Controls.Add(Me.textoPvp3)
        Me.GroupBox2.Controls.Add(GarantiaLabel)
        Me.GroupBox2.Controls.Add(Me.textoGarantia)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 151)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 297)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(619, 22)
        Me.StatusStrip1.TabIndex = 52
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'VentanaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(619, 319)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.botonok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textobuscar)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BAlta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bconsulta)
        Me.Controls.Add(Me.Bbaja)
        Me.Controls.Add(Me.Bmodifi)
        Me.Controls.Add(Me.Bultimo)
        Me.Controls.Add(Me.BSiguiente)
        Me.Controls.Add(Me.BAnterior)
        Me.Controls.Add(Me.Bprimero)
        Me.Controls.Add(Me.Bcancelar)
        Me.Controls.Add(Me.Baceptar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "VentanaProductos"
        Me.Text = "VentanaProductos"
        CType(Me.ArticulosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArticulosDataSet As ArticulosDataSet
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As ArticulosDataSetTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager As ArticulosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents textoIdArticulos As TextBox
    Friend WithEvents textoDescripcion As TextBox
    Friend WithEvents textoPrecioCompra As TextBox
    Friend WithEvents textoPvp As TextBox
    Friend WithEvents textoStockActual As TextBox
    Friend WithEvents textoStockMinimo As TextBox
    Friend WithEvents textoPvp1 As TextBox
    Friend WithEvents textoPvp2 As TextBox
    Friend WithEvents textoPvp3 As TextBox
    Friend WithEvents textoGarantia As TextBox
    Friend WithEvents Baceptar As Button
    Friend WithEvents Bcancelar As Button
    Friend WithEvents Bultimo As Button
    Friend WithEvents BSiguiente As Button
    Friend WithEvents BAnterior As Button
    Friend WithEvents Bprimero As Button
    Friend WithEvents Bmodifi As Button
    Friend WithEvents Bbaja As Button
    Friend WithEvents Bconsulta As Button
    Friend WithEvents textoproveedor As ComboBox
    Friend WithEvents textomarca As ComboBox
    Friend WithEvents textotipoarticulo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BAlta As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents textobuscar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents botonok As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
