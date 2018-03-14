<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaEmpresa
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
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim PoblacionLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DireccionEntregaLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim RepresentanteLabel As System.Windows.Forms.Label
        Me.EmpresaDataSet = New ProyectoFinal.EmpresaDataSet()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New ProyectoFinal.EmpresaDataSetTableAdapters.EmpresaTableAdapter()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.PoblacionTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CIFTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionEntregaTextBox = New System.Windows.Forms.TextBox()
        Me.WebTextBox = New System.Windows.Forms.TextBox()
        Me.RepresentanteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        PoblacionLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CIFLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DireccionEntregaLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        RepresentanteLabel = New System.Windows.Forms.Label()
        CType(Me.EmpresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(24, 52)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(24, 78)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 3
        RazonSocialLabel.Text = "Razon Social:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(24, 104)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Direccion:"
        '
        'PoblacionLabel
        '
        PoblacionLabel.AutoSize = True
        PoblacionLabel.Location = New System.Drawing.Point(24, 130)
        PoblacionLabel.Name = "PoblacionLabel"
        PoblacionLabel.Size = New System.Drawing.Size(57, 13)
        PoblacionLabel.TabIndex = 7
        PoblacionLabel.Text = "Poblacion:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(24, 156)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 9
        ProvinciaLabel.Text = "Provincia:"
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.Location = New System.Drawing.Point(24, 182)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(75, 13)
        CodigoPostalLabel.TabIndex = 11
        CodigoPostalLabel.Text = "Codigo Postal:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(24, 208)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 13
        FaxLabel.Text = "Fax:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(287, 52)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 15
        TelefonoLabel.Text = "Telefono:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(287, 81)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(26, 13)
        CIFLabel.TabIndex = 17
        CIFLabel.Text = "CIF:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(287, 107)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'DireccionEntregaLabel
        '
        DireccionEntregaLabel.AutoSize = True
        DireccionEntregaLabel.Location = New System.Drawing.Point(287, 133)
        DireccionEntregaLabel.Name = "DireccionEntregaLabel"
        DireccionEntregaLabel.Size = New System.Drawing.Size(95, 13)
        DireccionEntregaLabel.TabIndex = 21
        DireccionEntregaLabel.Text = "Direccion Entrega:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Location = New System.Drawing.Point(287, 159)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(33, 13)
        WebLabel.TabIndex = 23
        WebLabel.Text = "Web:"
        '
        'RepresentanteLabel
        '
        RepresentanteLabel.AutoSize = True
        RepresentanteLabel.Location = New System.Drawing.Point(287, 185)
        RepresentanteLabel.Name = "RepresentanteLabel"
        RepresentanteLabel.Size = New System.Drawing.Size(80, 13)
        RepresentanteLabel.TabIndex = 25
        RepresentanteLabel.Text = "Representante:"
        '
        'EmpresaDataSet
        '
        Me.EmpresaDataSet.DataSetName = "EmpresaDataSet"
        Me.EmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "Empresa"
        Me.EmpresaBindingSource.DataSource = Me.EmpresaDataSet
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(141, 49)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "RazonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(141, 75)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(112, 20)
        Me.RazonSocialTextBox.TabIndex = 4
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(141, 101)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(112, 20)
        Me.DireccionTextBox.TabIndex = 6
        '
        'PoblacionTextBox
        '
        Me.PoblacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Poblacion", True))
        Me.PoblacionTextBox.Location = New System.Drawing.Point(141, 127)
        Me.PoblacionTextBox.Name = "PoblacionTextBox"
        Me.PoblacionTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PoblacionTextBox.TabIndex = 8
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(141, 153)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(68, 20)
        Me.ProvinciaTextBox.TabIndex = 10
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "CodigoPostal", True))
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(141, 179)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(42, 20)
        Me.CodigoPostalTextBox.TabIndex = 12
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(141, 205)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(68, 20)
        Me.FaxTextBox.TabIndex = 14
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(404, 49)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(91, 20)
        Me.TelefonoTextBox.TabIndex = 16
        '
        'CIFTextBox
        '
        Me.CIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "CIF", True))
        Me.CIFTextBox.Location = New System.Drawing.Point(404, 78)
        Me.CIFTextBox.Name = "CIFTextBox"
        Me.CIFTextBox.Size = New System.Drawing.Size(91, 20)
        Me.CIFTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(404, 104)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(148, 20)
        Me.EmailTextBox.TabIndex = 20
        '
        'DireccionEntregaTextBox
        '
        Me.DireccionEntregaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "DireccionEntrega", True))
        Me.DireccionEntregaTextBox.Location = New System.Drawing.Point(404, 130)
        Me.DireccionEntregaTextBox.Name = "DireccionEntregaTextBox"
        Me.DireccionEntregaTextBox.Size = New System.Drawing.Size(91, 20)
        Me.DireccionEntregaTextBox.TabIndex = 22
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(404, 156)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(148, 20)
        Me.WebTextBox.TabIndex = 24
        '
        'RepresentanteTextBox
        '
        Me.RepresentanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Representante", True))
        Me.RepresentanteTextBox.Location = New System.Drawing.Point(404, 182)
        Me.RepresentanteTextBox.Name = "RepresentanteTextBox"
        Me.RepresentanteTextBox.Size = New System.Drawing.Size(91, 20)
        Me.RepresentanteTextBox.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(228, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Datos empresa"
        '
        'VentanaEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(601, 288)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(RazonSocialLabel)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(PoblacionLabel)
        Me.Controls.Add(Me.PoblacionTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(CodigoPostalLabel)
        Me.Controls.Add(Me.CodigoPostalTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CIFLabel)
        Me.Controls.Add(Me.CIFTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(DireccionEntregaLabel)
        Me.Controls.Add(Me.DireccionEntregaTextBox)
        Me.Controls.Add(WebLabel)
        Me.Controls.Add(Me.WebTextBox)
        Me.Controls.Add(RepresentanteLabel)
        Me.Controls.Add(Me.RepresentanteTextBox)
        Me.Name = "VentanaEmpresa"
        Me.Text = "VentanaEmpresa"
        CType(Me.EmpresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmpresaDataSet As EmpresaDataSet
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As EmpresaDataSetTableAdapters.EmpresaTableAdapter
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents PoblacionTextBox As TextBox
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents CodigoPostalTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CIFTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DireccionEntregaTextBox As TextBox
    Friend WithEvents WebTextBox As TextBox
    Friend WithEvents RepresentanteTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
