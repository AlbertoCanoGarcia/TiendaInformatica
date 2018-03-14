<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaNuevoCliente
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NIF_CIFLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim Direccion_entregaLabel As System.Windows.Forms.Label
        Dim CuentaBancariaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaNuevoCliente))
        Me.botonAceptar = New System.Windows.Forms.Button()
        Me.botonCancelar = New System.Windows.Forms.Button()
        Me.textoid = New System.Windows.Forms.TextBox()
        Me.textonombre = New System.Windows.Forms.TextBox()
        Me.textonif = New System.Windows.Forms.MaskedTextBox()
        Me.textotelefono = New System.Windows.Forms.MaskedTextBox()
        Me.textoemail = New System.Windows.Forms.MaskedTextBox()
        Me.textodireccion = New System.Windows.Forms.TextBox()
        Me.textolocalidad = New System.Windows.Forms.TextBox()
        Me.textoprovincia = New System.Windows.Forms.TextBox()
        Me.textocp = New System.Windows.Forms.MaskedTextBox()
        Me.textocuentabancaria = New System.Windows.Forms.TextBox()
        Me.textodireccionentrega = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        NIF_CIFLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        Direccion_entregaLabel = New System.Windows.Forms.Label()
        CuentaBancariaLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(97, 76)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 16)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        IdLabel.UseWaitCursor = True
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(63, 104)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(60, 16)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        NombreLabel.UseWaitCursor = True
        AddHandler NombreLabel.Click, AddressOf Me.NombreLabel_Click
        '
        'NIF_CIFLabel
        '
        NIF_CIFLabel.AutoSize = True
        NIF_CIFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIF_CIFLabel.Location = New System.Drawing.Point(68, 130)
        NIF_CIFLabel.Name = "NIF_CIFLabel"
        NIF_CIFLabel.Size = New System.Drawing.Size(55, 16)
        NIF_CIFLabel.TabIndex = 5
        NIF_CIFLabel.Text = "NIF CIF:"
        NIF_CIFLabel.UseWaitCursor = True
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(57, 153)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(65, 16)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "Telefono:"
        TelefonoLabel.UseWaitCursor = True
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(74, 179)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 16)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        EmailLabel.UseWaitCursor = True
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(54, 205)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(68, 16)
        DireccionLabel.TabIndex = 11
        DireccionLabel.Text = "Direccion:"
        DireccionLabel.UseWaitCursor = True
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalidadLabel.Location = New System.Drawing.Point(51, 233)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(71, 16)
        LocalidadLabel.TabIndex = 13
        LocalidadLabel.Text = "Localidad:"
        LocalidadLabel.UseWaitCursor = True
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvinciaLabel.Location = New System.Drawing.Point(53, 259)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(67, 16)
        ProvinciaLabel.TabIndex = 15
        ProvinciaLabel.Text = "Provincia:"
        ProvinciaLabel.UseWaitCursor = True
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPLabel.Location = New System.Drawing.Point(83, 286)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(29, 16)
        CPLabel.TabIndex = 17
        CPLabel.Text = "CP:"
        CPLabel.UseWaitCursor = True
        '
        'Direccion_entregaLabel
        '
        Direccion_entregaLabel.AutoSize = True
        Direccion_entregaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Direccion_entregaLabel.Location = New System.Drawing.Point(6, 334)
        Direccion_entregaLabel.Name = "Direccion_entregaLabel"
        Direccion_entregaLabel.Size = New System.Drawing.Size(117, 16)
        Direccion_entregaLabel.TabIndex = 29
        Direccion_entregaLabel.Text = "Direccion entrega:"
        Direccion_entregaLabel.UseWaitCursor = True
        '
        'CuentaBancariaLabel
        '
        CuentaBancariaLabel.AutoSize = True
        CuentaBancariaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuentaBancariaLabel.Location = New System.Drawing.Point(13, 309)
        CuentaBancariaLabel.Name = "CuentaBancariaLabel"
        CuentaBancariaLabel.Size = New System.Drawing.Size(110, 16)
        CuentaBancariaLabel.TabIndex = 19
        CuentaBancariaLabel.Text = "Cuenta Bancaria:"
        CuentaBancariaLabel.UseWaitCursor = True
        '
        'botonAceptar
        '
        Me.botonAceptar.Image = CType(resources.GetObject("botonAceptar.Image"), System.Drawing.Image)
        Me.botonAceptar.Location = New System.Drawing.Point(48, 371)
        Me.botonAceptar.Name = "botonAceptar"
        Me.botonAceptar.Size = New System.Drawing.Size(64, 64)
        Me.botonAceptar.TabIndex = 31
        Me.botonAceptar.UseVisualStyleBackColor = True
        '
        'botonCancelar
        '
        Me.botonCancelar.Image = CType(resources.GetObject("botonCancelar.Image"), System.Drawing.Image)
        Me.botonCancelar.Location = New System.Drawing.Point(217, 371)
        Me.botonCancelar.Name = "botonCancelar"
        Me.botonCancelar.Size = New System.Drawing.Size(64, 64)
        Me.botonCancelar.TabIndex = 32
        Me.botonCancelar.UseVisualStyleBackColor = True
        '
        'textoid
        '
        Me.textoid.Location = New System.Drawing.Point(129, 75)
        Me.textoid.Name = "textoid"
        Me.textoid.Size = New System.Drawing.Size(49, 20)
        Me.textoid.TabIndex = 33
        '
        'textonombre
        '
        Me.textonombre.Location = New System.Drawing.Point(129, 100)
        Me.textonombre.Name = "textonombre"
        Me.textonombre.Size = New System.Drawing.Size(134, 20)
        Me.textonombre.TabIndex = 34
        '
        'textonif
        '
        Me.textonif.Location = New System.Drawing.Point(129, 126)
        Me.textonif.Mask = "00000000L"
        Me.textonif.Name = "textonif"
        Me.textonif.Size = New System.Drawing.Size(64, 20)
        Me.textonif.TabIndex = 35
        '
        'textotelefono
        '
        Me.textotelefono.Location = New System.Drawing.Point(129, 153)
        Me.textotelefono.Mask = "000000000"
        Me.textotelefono.Name = "textotelefono"
        Me.textotelefono.Size = New System.Drawing.Size(64, 20)
        Me.textotelefono.TabIndex = 36
        '
        'textoemail
        '
        Me.textoemail.Location = New System.Drawing.Point(129, 179)
        Me.textoemail.Name = "textoemail"
        Me.textoemail.Size = New System.Drawing.Size(152, 20)
        Me.textoemail.TabIndex = 37
        '
        'textodireccion
        '
        Me.textodireccion.Location = New System.Drawing.Point(129, 205)
        Me.textodireccion.Name = "textodireccion"
        Me.textodireccion.Size = New System.Drawing.Size(152, 20)
        Me.textodireccion.TabIndex = 38
        '
        'textolocalidad
        '
        Me.textolocalidad.Location = New System.Drawing.Point(129, 231)
        Me.textolocalidad.Name = "textolocalidad"
        Me.textolocalidad.Size = New System.Drawing.Size(100, 20)
        Me.textolocalidad.TabIndex = 39
        '
        'textoprovincia
        '
        Me.textoprovincia.Location = New System.Drawing.Point(129, 255)
        Me.textoprovincia.Name = "textoprovincia"
        Me.textoprovincia.Size = New System.Drawing.Size(87, 20)
        Me.textoprovincia.TabIndex = 40
        '
        'textocp
        '
        Me.textocp.Location = New System.Drawing.Point(129, 282)
        Me.textocp.Name = "textocp"
        Me.textocp.Size = New System.Drawing.Size(55, 20)
        Me.textocp.TabIndex = 41
        '
        'textocuentabancaria
        '
        Me.textocuentabancaria.Location = New System.Drawing.Point(129, 308)
        Me.textocuentabancaria.Name = "textocuentabancaria"
        Me.textocuentabancaria.Size = New System.Drawing.Size(121, 20)
        Me.textocuentabancaria.TabIndex = 42
        '
        'textodireccionentrega
        '
        Me.textodireccionentrega.Location = New System.Drawing.Point(129, 334)
        Me.textodireccionentrega.Name = "textodireccionentrega"
        Me.textodireccionentrega.Size = New System.Drawing.Size(134, 20)
        Me.textodireccionentrega.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(81, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Nuevo Cliente"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 457)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(328, 22)
        Me.StatusStrip1.TabIndex = 45
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'VentanaNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(328, 479)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textodireccionentrega)
        Me.Controls.Add(Me.textocuentabancaria)
        Me.Controls.Add(Me.textocp)
        Me.Controls.Add(Me.textoprovincia)
        Me.Controls.Add(Me.textolocalidad)
        Me.Controls.Add(Me.textodireccion)
        Me.Controls.Add(Me.textoemail)
        Me.Controls.Add(Me.textotelefono)
        Me.Controls.Add(Me.textonif)
        Me.Controls.Add(Me.textonombre)
        Me.Controls.Add(Me.textoid)
        Me.Controls.Add(Me.botonCancelar)
        Me.Controls.Add(Me.botonAceptar)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(NIF_CIFLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(CuentaBancariaLabel)
        Me.Controls.Add(Direccion_entregaLabel)
        Me.Name = "VentanaNuevoCliente"
        Me.Text = "VentanaNuevoCliente"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents botonAceptar As Button
    Friend WithEvents botonCancelar As Button
    Friend WithEvents textoid As TextBox
    Friend WithEvents textonombre As TextBox
    Friend WithEvents textonif As MaskedTextBox
    Friend WithEvents textotelefono As MaskedTextBox
    Friend WithEvents textoemail As MaskedTextBox
    Friend WithEvents textodireccion As TextBox
    Friend WithEvents textolocalidad As TextBox
    Friend WithEvents textoprovincia As TextBox
    Friend WithEvents textocp As MaskedTextBox
    Friend WithEvents textocuentabancaria As TextBox
    Friend WithEvents textodireccionentrega As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
