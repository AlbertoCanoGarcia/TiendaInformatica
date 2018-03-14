<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanarProveedores
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
        Dim CodProdLabel As System.Windows.Forms.Label
        Dim Razon_socialLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NIF_CIFLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim PersonaContactoLabel As System.Windows.Forms.Label
        Dim FechaAltaLabel As System.Windows.Forms.Label
        Dim FechaBajaLabel As System.Windows.Forms.Label
        Dim Fecha_ultima_compraLabel As System.Windows.Forms.Label
        Dim Descuento_habitualLabel As System.Windows.Forms.Label
        Dim FormaPagoLabel As System.Windows.Forms.Label
        Dim TarifaLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim AcumuladoComprasLabel As System.Windows.Forms.Label
        Me.ProveedoresDataSet = New ProyectoFinal.ProveedoresDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ProyectoFinal.ProveedoresDataSetTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New ProyectoFinal.ProveedoresDataSetTableAdapters.TableAdapterManager()
        Me.CodProdTextBox = New System.Windows.Forms.TextBox()
        Me.Razon_socialTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.NIF_CIFTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.PersonaContactoTextBox = New System.Windows.Forms.TextBox()
        Me.Descuento_habitualTextBox = New System.Windows.Forms.TextBox()
        Me.FormaPagoTextBox = New System.Windows.Forms.TextBox()
        Me.TarifaTextBox = New System.Windows.Forms.TextBox()
        Me.textoFechaAlta = New System.Windows.Forms.MaskedTextBox()
        Me.textoFechaBaja = New System.Windows.Forms.MaskedTextBox()
        Me.textoFechaUltimaCompra = New System.Windows.Forms.MaskedTextBox()
        Me.AcumuladoComprasTextBox = New System.Windows.Forms.TextBox()
        Me.textoobservaciones = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonok = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textobuscar = New System.Windows.Forms.ComboBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BAlta = New System.Windows.Forms.Button()
        Me.Bconsulta = New System.Windows.Forms.Button()
        Me.Bbaja = New System.Windows.Forms.Button()
        Me.Bmodifi = New System.Windows.Forms.Button()
        Me.Bultimo = New System.Windows.Forms.Button()
        Me.BSiguiente = New System.Windows.Forms.Button()
        Me.BAnterior = New System.Windows.Forms.Button()
        Me.Bprimero = New System.Windows.Forms.Button()
        Me.Bcancelar = New System.Windows.Forms.Button()
        Me.Baceptar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CodProdLabel = New System.Windows.Forms.Label()
        Razon_socialLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NIF_CIFLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        PersonaContactoLabel = New System.Windows.Forms.Label()
        FechaAltaLabel = New System.Windows.Forms.Label()
        FechaBajaLabel = New System.Windows.Forms.Label()
        Fecha_ultima_compraLabel = New System.Windows.Forms.Label()
        Descuento_habitualLabel = New System.Windows.Forms.Label()
        FormaPagoLabel = New System.Windows.Forms.Label()
        TarifaLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        AcumuladoComprasLabel = New System.Windows.Forms.Label()
        CType(Me.ProveedoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodProdLabel
        '
        CodProdLabel.AutoSize = True
        CodProdLabel.Location = New System.Drawing.Point(16, 54)
        CodProdLabel.Name = "CodProdLabel"
        CodProdLabel.Size = New System.Drawing.Size(54, 13)
        CodProdLabel.TabIndex = 1
        CodProdLabel.Text = "Cod Prod:"
        '
        'Razon_socialLabel
        '
        Razon_socialLabel.AutoSize = True
        Razon_socialLabel.Location = New System.Drawing.Point(6, 22)
        Razon_socialLabel.Name = "Razon_socialLabel"
        Razon_socialLabel.Size = New System.Drawing.Size(71, 13)
        Razon_socialLabel.TabIndex = 3
        Razon_socialLabel.Text = "Razon social:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(6, 48)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'NIF_CIFLabel
        '
        NIF_CIFLabel.AutoSize = True
        NIF_CIFLabel.Location = New System.Drawing.Point(6, 74)
        NIF_CIFLabel.Name = "NIF_CIFLabel"
        NIF_CIFLabel.Size = New System.Drawing.Size(46, 13)
        NIF_CIFLabel.TabIndex = 7
        NIF_CIFLabel.Text = "NIF CIF:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(6, 100)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(6, 126)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 11
        TelefonoLabel.Text = "Telefono:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(6, 152)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadLabel.TabIndex = 13
        LocalidadLabel.Text = "Localidad:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(6, 178)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 15
        ProvinciaLabel.Text = "Provincia:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(6, 204)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 17
        CPLabel.Text = "CP:"
        '
        'PersonaContactoLabel
        '
        PersonaContactoLabel.AutoSize = True
        PersonaContactoLabel.Location = New System.Drawing.Point(6, 230)
        PersonaContactoLabel.Name = "PersonaContactoLabel"
        PersonaContactoLabel.Size = New System.Drawing.Size(95, 13)
        PersonaContactoLabel.TabIndex = 19
        PersonaContactoLabel.Text = "Persona Contacto:"
        '
        'FechaAltaLabel
        '
        FechaAltaLabel.AutoSize = True
        FechaAltaLabel.Location = New System.Drawing.Point(14, 25)
        FechaAltaLabel.Name = "FechaAltaLabel"
        FechaAltaLabel.Size = New System.Drawing.Size(61, 13)
        FechaAltaLabel.TabIndex = 21
        FechaAltaLabel.Text = "Fecha Alta:"
        '
        'FechaBajaLabel
        '
        FechaBajaLabel.AutoSize = True
        FechaBajaLabel.Location = New System.Drawing.Point(14, 51)
        FechaBajaLabel.Name = "FechaBajaLabel"
        FechaBajaLabel.Size = New System.Drawing.Size(64, 13)
        FechaBajaLabel.TabIndex = 23
        FechaBajaLabel.Text = "Fecha Baja:"
        '
        'Fecha_ultima_compraLabel
        '
        Fecha_ultima_compraLabel.AutoSize = True
        Fecha_ultima_compraLabel.Location = New System.Drawing.Point(14, 77)
        Fecha_ultima_compraLabel.Name = "Fecha_ultima_compraLabel"
        Fecha_ultima_compraLabel.Size = New System.Drawing.Size(108, 13)
        Fecha_ultima_compraLabel.TabIndex = 25
        Fecha_ultima_compraLabel.Text = "Fecha ultima compra:"
        '
        'Descuento_habitualLabel
        '
        Descuento_habitualLabel.AutoSize = True
        Descuento_habitualLabel.Location = New System.Drawing.Point(17, 30)
        Descuento_habitualLabel.Name = "Descuento_habitualLabel"
        Descuento_habitualLabel.Size = New System.Drawing.Size(102, 13)
        Descuento_habitualLabel.TabIndex = 27
        Descuento_habitualLabel.Text = "Descuento habitual:"
        '
        'FormaPagoLabel
        '
        FormaPagoLabel.AutoSize = True
        FormaPagoLabel.Location = New System.Drawing.Point(17, 82)
        FormaPagoLabel.Name = "FormaPagoLabel"
        FormaPagoLabel.Size = New System.Drawing.Size(67, 13)
        FormaPagoLabel.TabIndex = 31
        FormaPagoLabel.Text = "Forma Pago:"
        '
        'TarifaLabel
        '
        TarifaLabel.AutoSize = True
        TarifaLabel.Location = New System.Drawing.Point(17, 108)
        TarifaLabel.Name = "TarifaLabel"
        TarifaLabel.Size = New System.Drawing.Size(37, 13)
        TarifaLabel.TabIndex = 33
        TarifaLabel.Text = "Tarifa:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(615, 107)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 35
        ObservacionesLabel.Text = "Observaciones:"
        '
        'AcumuladoComprasLabel
        '
        AcumuladoComprasLabel.AutoSize = True
        AcumuladoComprasLabel.Location = New System.Drawing.Point(17, 56)
        AcumuladoComprasLabel.Name = "AcumuladoComprasLabel"
        AcumuladoComprasLabel.Size = New System.Drawing.Size(107, 13)
        AcumuladoComprasLabel.TabIndex = 29
        AcumuladoComprasLabel.Text = "Acumulado Compras:"
        '
        'ProveedoresDataSet
        '
        Me.ProveedoresDataSet.DataSetName = "ProveedoresDataSet"
        Me.ProveedoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ProveedoresDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoFinal.ProveedoresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CodProdTextBox
        '
        Me.CodProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CodProd", True))
        Me.CodProdTextBox.Location = New System.Drawing.Point(76, 51)
        Me.CodProdTextBox.Name = "CodProdTextBox"
        Me.CodProdTextBox.Size = New System.Drawing.Size(51, 20)
        Me.CodProdTextBox.TabIndex = 2
        '
        'Razon_socialTextBox
        '
        Me.Razon_socialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Razon_social", True))
        Me.Razon_socialTextBox.Location = New System.Drawing.Point(105, 19)
        Me.Razon_socialTextBox.Name = "Razon_socialTextBox"
        Me.Razon_socialTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Razon_socialTextBox.TabIndex = 4
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(106, 45)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(185, 20)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'NIF_CIFTextBox
        '
        Me.NIF_CIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "NIF_CIF", True))
        Me.NIF_CIFTextBox.Location = New System.Drawing.Point(106, 71)
        Me.NIF_CIFTextBox.Name = "NIF_CIFTextBox"
        Me.NIF_CIFTextBox.Size = New System.Drawing.Size(87, 20)
        Me.NIF_CIFTextBox.TabIndex = 8
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(106, 97)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(147, 20)
        Me.DireccionTextBox.TabIndex = 10
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(105, 123)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(102, 20)
        Me.TelefonoTextBox.TabIndex = 12
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(104, 149)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(130, 20)
        Me.LocalidadTextBox.TabIndex = 14
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(104, 175)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(68, 20)
        Me.ProvinciaTextBox.TabIndex = 16
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(105, 200)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(51, 20)
        Me.CPTextBox.TabIndex = 18
        '
        'PersonaContactoTextBox
        '
        Me.PersonaContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "PersonaContacto", True))
        Me.PersonaContactoTextBox.Location = New System.Drawing.Point(105, 227)
        Me.PersonaContactoTextBox.Name = "PersonaContactoTextBox"
        Me.PersonaContactoTextBox.Size = New System.Drawing.Size(158, 20)
        Me.PersonaContactoTextBox.TabIndex = 20
        '
        'Descuento_habitualTextBox
        '
        Me.Descuento_habitualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Descuento_habitual", True))
        Me.Descuento_habitualTextBox.Location = New System.Drawing.Point(131, 27)
        Me.Descuento_habitualTextBox.Name = "Descuento_habitualTextBox"
        Me.Descuento_habitualTextBox.Size = New System.Drawing.Size(65, 20)
        Me.Descuento_habitualTextBox.TabIndex = 28
        '
        'FormaPagoTextBox
        '
        Me.FormaPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "FormaPago", True))
        Me.FormaPagoTextBox.Location = New System.Drawing.Point(131, 79)
        Me.FormaPagoTextBox.Name = "FormaPagoTextBox"
        Me.FormaPagoTextBox.Size = New System.Drawing.Size(68, 20)
        Me.FormaPagoTextBox.TabIndex = 32
        '
        'TarifaTextBox
        '
        Me.TarifaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Tarifa", True))
        Me.TarifaTextBox.Location = New System.Drawing.Point(131, 105)
        Me.TarifaTextBox.Name = "TarifaTextBox"
        Me.TarifaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.TarifaTextBox.TabIndex = 34
        '
        'textoFechaAlta
        '
        Me.textoFechaAlta.Enabled = False
        Me.textoFechaAlta.Location = New System.Drawing.Point(128, 19)
        Me.textoFechaAlta.Mask = "00/00/0000"
        Me.textoFechaAlta.Name = "textoFechaAlta"
        Me.textoFechaAlta.Size = New System.Drawing.Size(68, 20)
        Me.textoFechaAlta.TabIndex = 37
        Me.textoFechaAlta.ValidatingType = GetType(Date)
        '
        'textoFechaBaja
        '
        Me.textoFechaBaja.Enabled = False
        Me.textoFechaBaja.Location = New System.Drawing.Point(128, 45)
        Me.textoFechaBaja.Mask = "00/00/0000"
        Me.textoFechaBaja.Name = "textoFechaBaja"
        Me.textoFechaBaja.Size = New System.Drawing.Size(68, 20)
        Me.textoFechaBaja.TabIndex = 38
        Me.textoFechaBaja.ValidatingType = GetType(Date)
        '
        'textoFechaUltimaCompra
        '
        Me.textoFechaUltimaCompra.Enabled = False
        Me.textoFechaUltimaCompra.Location = New System.Drawing.Point(128, 69)
        Me.textoFechaUltimaCompra.Mask = "00/00/0000"
        Me.textoFechaUltimaCompra.Name = "textoFechaUltimaCompra"
        Me.textoFechaUltimaCompra.Size = New System.Drawing.Size(68, 20)
        Me.textoFechaUltimaCompra.TabIndex = 39
        Me.textoFechaUltimaCompra.ValidatingType = GetType(Date)
        '
        'AcumuladoComprasTextBox
        '
        Me.AcumuladoComprasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "AcumuladoCompras", True))
        Me.AcumuladoComprasTextBox.Enabled = False
        Me.AcumuladoComprasTextBox.Location = New System.Drawing.Point(131, 53)
        Me.AcumuladoComprasTextBox.Name = "AcumuladoComprasTextBox"
        Me.AcumuladoComprasTextBox.Size = New System.Drawing.Size(65, 20)
        Me.AcumuladoComprasTextBox.TabIndex = 30
        '
        'textoobservaciones
        '
        Me.textoobservaciones.Enabled = False
        Me.textoobservaciones.Location = New System.Drawing.Point(618, 130)
        Me.textoobservaciones.Name = "textoobservaciones"
        Me.textoobservaciones.Size = New System.Drawing.Size(209, 59)
        Me.textoobservaciones.TabIndex = 40
        Me.textoobservaciones.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Razon_socialLabel)
        Me.GroupBox1.Controls.Add(Me.Razon_socialTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(NIF_CIFLabel)
        Me.GroupBox1.Controls.Add(Me.NIF_CIFTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(LocalidadLabel)
        Me.GroupBox1.Controls.Add(Me.LocalidadTextBox)
        Me.GroupBox1.Controls.Add(ProvinciaLabel)
        Me.GroupBox1.Controls.Add(Me.ProvinciaTextBox)
        Me.GroupBox1.Controls.Add(CPLabel)
        Me.GroupBox1.Controls.Add(Me.CPTextBox)
        Me.GroupBox1.Controls.Add(PersonaContactoLabel)
        Me.GroupBox1.Controls.Add(Me.PersonaContactoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 253)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Contacto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(257, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Gestion de proveedores"
        '
        'botonok
        '
        Me.botonok.Location = New System.Drawing.Point(590, 51)
        Me.botonok.Name = "botonok"
        Me.botonok.Size = New System.Drawing.Size(41, 23)
        Me.botonok.TabIndex = 63
        Me.botonok.Text = "Ok"
        Me.botonok.UseVisualStyleBackColor = True
        Me.botonok.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Introducir nombre"
        '
        'textobuscar
        '
        Me.textobuscar.FormattingEnabled = True
        Me.textobuscar.Location = New System.Drawing.Point(454, 51)
        Me.textobuscar.Name = "textobuscar"
        Me.textobuscar.Size = New System.Drawing.Size(121, 21)
        Me.textobuscar.TabIndex = 61
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(752, 345)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 60
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BAlta
        '
        Me.BAlta.Location = New System.Drawing.Point(245, 345)
        Me.BAlta.Name = "BAlta"
        Me.BAlta.Size = New System.Drawing.Size(75, 23)
        Me.BAlta.TabIndex = 59
        Me.BAlta.Text = "Alta"
        Me.BAlta.UseVisualStyleBackColor = True
        '
        'Bconsulta
        '
        Me.Bconsulta.Location = New System.Drawing.Point(261, 49)
        Me.Bconsulta.Name = "Bconsulta"
        Me.Bconsulta.Size = New System.Drawing.Size(75, 23)
        Me.Bconsulta.TabIndex = 58
        Me.Bconsulta.Text = "Buscar"
        Me.Bconsulta.UseVisualStyleBackColor = True
        '
        'Bbaja
        '
        Me.Bbaja.Location = New System.Drawing.Point(326, 345)
        Me.Bbaja.Name = "Bbaja"
        Me.Bbaja.Size = New System.Drawing.Size(69, 23)
        Me.Bbaja.TabIndex = 57
        Me.Bbaja.Text = "Baja"
        Me.Bbaja.UseVisualStyleBackColor = True
        '
        'Bmodifi
        '
        Me.Bmodifi.Location = New System.Drawing.Point(401, 345)
        Me.Bmodifi.Name = "Bmodifi"
        Me.Bmodifi.Size = New System.Drawing.Size(67, 23)
        Me.Bmodifi.TabIndex = 56
        Me.Bmodifi.Text = "Modificar"
        Me.Bmodifi.UseVisualStyleBackColor = True
        '
        'Bultimo
        '
        Me.Bultimo.Location = New System.Drawing.Point(157, 345)
        Me.Bultimo.Name = "Bultimo"
        Me.Bultimo.Size = New System.Drawing.Size(36, 23)
        Me.Bultimo.TabIndex = 55
        Me.Bultimo.Text = ">>"
        Me.Bultimo.UseVisualStyleBackColor = True
        '
        'BSiguiente
        '
        Me.BSiguiente.Location = New System.Drawing.Point(109, 345)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(42, 23)
        Me.BSiguiente.TabIndex = 54
        Me.BSiguiente.Text = ">"
        Me.BSiguiente.UseVisualStyleBackColor = True
        '
        'BAnterior
        '
        Me.BAnterior.Location = New System.Drawing.Point(64, 345)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(39, 23)
        Me.BAnterior.TabIndex = 53
        Me.BAnterior.Text = "<"
        Me.BAnterior.UseVisualStyleBackColor = True
        '
        'Bprimero
        '
        Me.Bprimero.Location = New System.Drawing.Point(14, 345)
        Me.Bprimero.Name = "Bprimero"
        Me.Bprimero.Size = New System.Drawing.Size(44, 23)
        Me.Bprimero.TabIndex = 52
        Me.Bprimero.Text = "<<"
        Me.Bprimero.UseVisualStyleBackColor = True
        '
        'Bcancelar
        '
        Me.Bcancelar.Enabled = False
        Me.Bcancelar.Location = New System.Drawing.Point(540, 345)
        Me.Bcancelar.Name = "Bcancelar"
        Me.Bcancelar.Size = New System.Drawing.Size(62, 23)
        Me.Bcancelar.TabIndex = 51
        Me.Bcancelar.Text = "Cancelar"
        Me.Bcancelar.UseVisualStyleBackColor = True
        '
        'Baceptar
        '
        Me.Baceptar.Enabled = False
        Me.Baceptar.Location = New System.Drawing.Point(474, 345)
        Me.Baceptar.Name = "Baceptar"
        Me.Baceptar.Size = New System.Drawing.Size(60, 23)
        Me.Baceptar.TabIndex = 50
        Me.Baceptar.Text = "Aceptar"
        Me.Baceptar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 381)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(841, 22)
        Me.StatusStrip1.TabIndex = 64
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textoFechaUltimaCompra)
        Me.GroupBox2.Controls.Add(Me.textoFechaBaja)
        Me.GroupBox2.Controls.Add(Me.textoFechaAlta)
        Me.GroupBox2.Controls.Add(FechaAltaLabel)
        Me.GroupBox2.Controls.Add(FechaBajaLabel)
        Me.GroupBox2.Controls.Add(Fecha_ultima_compraLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 102)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Descuento_habitualLabel)
        Me.GroupBox3.Controls.Add(Me.Descuento_habitualTextBox)
        Me.GroupBox3.Controls.Add(AcumuladoComprasLabel)
        Me.GroupBox3.Controls.Add(Me.AcumuladoComprasTextBox)
        Me.GroupBox3.Controls.Add(FormaPagoLabel)
        Me.GroupBox3.Controls.Add(Me.FormaPagoTextBox)
        Me.GroupBox3.Controls.Add(TarifaLabel)
        Me.GroupBox3.Controls.Add(Me.TarifaTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(330, 201)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 128)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info Compra"
        '
        'VentanarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(841, 403)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.botonok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textobuscar)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BAlta)
        Me.Controls.Add(Me.Bconsulta)
        Me.Controls.Add(Me.Bbaja)
        Me.Controls.Add(Me.Bmodifi)
        Me.Controls.Add(Me.Bultimo)
        Me.Controls.Add(Me.BSiguiente)
        Me.Controls.Add(Me.BAnterior)
        Me.Controls.Add(Me.Bprimero)
        Me.Controls.Add(Me.Bcancelar)
        Me.Controls.Add(Me.Baceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CodProdLabel)
        Me.Controls.Add(Me.CodProdTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.textoobservaciones)
        Me.Controls.Add(ObservacionesLabel)
        Me.Name = "VentanarProveedores"
        Me.Text = "VentanarProveedores"
        CType(Me.ProveedoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProveedoresDataSet As ProveedoresDataSet
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As ProveedoresDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As ProveedoresDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodProdTextBox As TextBox
    Friend WithEvents Razon_socialTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents NIF_CIFTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents CPTextBox As TextBox
    Friend WithEvents PersonaContactoTextBox As TextBox
    Friend WithEvents Descuento_habitualTextBox As TextBox
    Friend WithEvents FormaPagoTextBox As TextBox
    Friend WithEvents TarifaTextBox As TextBox
    Friend WithEvents textoFechaAlta As MaskedTextBox
    Friend WithEvents textoFechaBaja As MaskedTextBox
    Friend WithEvents textoFechaUltimaCompra As MaskedTextBox
    Friend WithEvents AcumuladoComprasTextBox As TextBox
    Friend WithEvents textoobservaciones As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents botonok As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents textobuscar As ComboBox
    Friend WithEvents BSalir As Button
    Friend WithEvents BAlta As Button
    Friend WithEvents Bconsulta As Button
    Friend WithEvents Bbaja As Button
    Friend WithEvents Bmodifi As Button
    Friend WithEvents Bultimo As Button
    Friend WithEvents BSiguiente As Button
    Friend WithEvents BAnterior As Button
    Friend WithEvents Bprimero As Button
    Friend WithEvents Bcancelar As Button
    Friend WithEvents Baceptar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
