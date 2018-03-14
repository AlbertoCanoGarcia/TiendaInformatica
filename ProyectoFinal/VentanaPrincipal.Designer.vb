<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProceedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionPorCliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosMasVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeArticulosMasVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibroIvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibroIVAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiaDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListadoFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ProceedoresToolStripMenuItem, Me.VentasToolStripMenuItem, Me.CompraToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.LibroIvaToolStripMenuItem, Me.ToolStripMenuItem1, Me.AcToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(738, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.MantenimientoClienteToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'MantenimientoClienteToolStripMenuItem
        '
        Me.MantenimientoClienteToolStripMenuItem.Name = "MantenimientoClienteToolStripMenuItem"
        Me.MantenimientoClienteToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.MantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaToolStripMenuItem, Me.ListadoProductosToolStripMenuItem, Me.ListadoProductosToolStripMenuItem1, Me.TiposDeArticulosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'MaToolStripMenuItem
        '
        Me.MaToolStripMenuItem.Name = "MaToolStripMenuItem"
        Me.MaToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MaToolStripMenuItem.Text = "Mantenimiento productos"
        '
        'ListadoProductosToolStripMenuItem
        '
        Me.ListadoProductosToolStripMenuItem.Name = "ListadoProductosToolStripMenuItem"
        Me.ListadoProductosToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ListadoProductosToolStripMenuItem.Text = "Listado productos sin stock "
        '
        'ListadoProductosToolStripMenuItem1
        '
        Me.ListadoProductosToolStripMenuItem1.Name = "ListadoProductosToolStripMenuItem1"
        Me.ListadoProductosToolStripMenuItem1.Size = New System.Drawing.Size(221, 22)
        Me.ListadoProductosToolStripMenuItem1.Text = "Listado productos en stock"
        '
        'TiposDeArticulosToolStripMenuItem
        '
        Me.TiposDeArticulosToolStripMenuItem.Name = "TiposDeArticulosToolStripMenuItem"
        Me.TiposDeArticulosToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TiposDeArticulosToolStripMenuItem.Text = "Tipos de articulos"
        '
        'ProceedoresToolStripMenuItem
        '
        Me.ProceedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoProveedoresToolStripMenuItem})
        Me.ProceedoresToolStripMenuItem.Name = "ProceedoresToolStripMenuItem"
        Me.ProceedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProceedoresToolStripMenuItem.Text = "Proveedores"
        '
        'MantenimientoProveedoresToolStripMenuItem
        '
        Me.MantenimientoProveedoresToolStripMenuItem.Name = "MantenimientoProveedoresToolStripMenuItem"
        Me.MantenimientoProveedoresToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.MantenimientoProveedoresToolStripMenuItem.Text = "Mantenimiento Proveedores"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.MantenimientoVentaToolStripMenuItem, Me.ListadoFacturasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva venta"
        '
        'MantenimientoVentaToolStripMenuItem
        '
        Me.MantenimientoVentaToolStripMenuItem.Name = "MantenimientoVentaToolStripMenuItem"
        Me.MantenimientoVentaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MantenimientoVentaToolStripMenuItem.Text = "Mantenimiento venta"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarCompraToolStripMenuItem, Me.MantenimientoCompraToolStripMenuItem})
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'RealizarCompraToolStripMenuItem
        '
        Me.RealizarCompraToolStripMenuItem.Name = "RealizarCompraToolStripMenuItem"
        Me.RealizarCompraToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.RealizarCompraToolStripMenuItem.Text = "Realizar Compra"
        '
        'MantenimientoCompraToolStripMenuItem
        '
        Me.MantenimientoCompraToolStripMenuItem.Name = "MantenimientoCompraToolStripMenuItem"
        Me.MantenimientoCompraToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.MantenimientoCompraToolStripMenuItem.Text = "Mantenimiento Compra"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionPorCliToolStripMenuItem})
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'FacturacionPorCliToolStripMenuItem
        '
        Me.FacturacionPorCliToolStripMenuItem.Name = "FacturacionPorCliToolStripMenuItem"
        Me.FacturacionPorCliToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FacturacionPorCliToolStripMenuItem.Text = "Facturacion por cliente"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosMasVendidosToolStripMenuItem, Me.TiposDeArticulosMasVendidosToolStripMenuItem})
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'ProductosMasVendidosToolStripMenuItem
        '
        Me.ProductosMasVendidosToolStripMenuItem.Name = "ProductosMasVendidosToolStripMenuItem"
        Me.ProductosMasVendidosToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ProductosMasVendidosToolStripMenuItem.Text = "Marcas mas vendidos"
        '
        'TiposDeArticulosMasVendidosToolStripMenuItem
        '
        Me.TiposDeArticulosMasVendidosToolStripMenuItem.Name = "TiposDeArticulosMasVendidosToolStripMenuItem"
        Me.TiposDeArticulosMasVendidosToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.TiposDeArticulosMasVendidosToolStripMenuItem.Text = "Tipos de articulos mas vendidos"
        '
        'LibroIvaToolStripMenuItem
        '
        Me.LibroIvaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibroIVAToolStripMenuItem1})
        Me.LibroIvaToolStripMenuItem.Name = "LibroIvaToolStripMenuItem"
        Me.LibroIvaToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.LibroIvaToolStripMenuItem.Text = "IVA"
        '
        'LibroIVAToolStripMenuItem1
        '
        Me.LibroIVAToolStripMenuItem1.Name = "LibroIVAToolStripMenuItem1"
        Me.LibroIVAToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.LibroIVAToolStripMenuItem1.Text = "Libro IVA"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordToolStripMenuItem, Me.CalculadoraToolStripMenuItem, Me.CopiaDToolStripMenuItem, Me.EnviarCorreoToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(71, 20)
        Me.ToolStripMenuItem1.Text = "Utilidades"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.WordToolStripMenuItem.Text = "Word"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'CopiaDToolStripMenuItem
        '
        Me.CopiaDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem1, Me.RestoreToolStripMenuItem})
        Me.CopiaDToolStripMenuItem.Name = "CopiaDToolStripMenuItem"
        Me.CopiaDToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CopiaDToolStripMenuItem.Text = "Copia de Seguridad"
        '
        'BackupToolStripMenuItem1
        '
        Me.BackupToolStripMenuItem1.Name = "BackupToolStripMenuItem1"
        Me.BackupToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.BackupToolStripMenuItem1.Text = "Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'EnviarCorreoToolStripMenuItem
        '
        Me.EnviarCorreoToolStripMenuItem.Name = "EnviarCorreoToolStripMenuItem"
        Me.EnviarCorreoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EnviarCorreoToolStripMenuItem.Text = "Enviar correo"
        '
        'AcToolStripMenuItem
        '
        Me.AcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.InformacionToolStripMenuItem})
        Me.AcToolStripMenuItem.Name = "AcToolStripMenuItem"
        Me.AcToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AcToolStripMenuItem.Text = "Empresa"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton4, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(738, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(10, 1, 5, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Nueva Venta"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "Nuevo Cliente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.ToolTipText = "Nueva compra"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Datos Empresa"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 413)
        Me.Panel1.TabIndex = 2
        '
        'panel2
        '
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(736, 413)
        Me.panel2.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListadoFacturasToolStripMenuItem
        '
        Me.ListadoFacturasToolStripMenuItem.Name = "ListadoFacturasToolStripMenuItem"
        Me.ListadoFacturasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ListadoFacturasToolStripMenuItem.Text = "Listado Facturas"
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(738, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Menu
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaPrincipal"
        Me.Text = "CanoMatic S.A"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ProceedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel2 As Panel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LibroIvaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibroIVAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MantenimientoCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosMasVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeArticulosMasVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiaDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnviarCorreoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionPorCliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoFacturasToolStripMenuItem As ToolStripMenuItem
End Class
