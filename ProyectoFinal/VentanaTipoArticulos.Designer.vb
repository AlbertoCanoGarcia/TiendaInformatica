<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaTipoArticulos
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
        Dim IdTipoArticuloLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaTipoArticulos))
        Me.TiposArticuloDataSet = New ProyectoFinal.TiposArticuloDataSet()
        Me.TiposArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposArticuloTableAdapter = New ProyectoFinal.TiposArticuloDataSetTableAdapters.TiposArticuloTableAdapter()
        Me.TableAdapterManager = New ProyectoFinal.TiposArticuloDataSetTableAdapters.TableAdapterManager()
        Me.TiposArticuloBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TiposArticuloBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTipoArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IdTipoArticuloLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.TiposArticuloDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposArticuloBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TiposArticuloBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdTipoArticuloLabel
        '
        IdTipoArticuloLabel.AutoSize = True
        IdTipoArticuloLabel.Location = New System.Drawing.Point(48, 82)
        IdTipoArticuloLabel.Name = "IdTipoArticuloLabel"
        IdTipoArticuloLabel.Size = New System.Drawing.Size(81, 13)
        IdTipoArticuloLabel.TabIndex = 1
        IdTipoArticuloLabel.Text = "Id Tipo Articulo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(48, 108)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "nombre:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(48, 134)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "descripcion:"
        '
        'TiposArticuloDataSet
        '
        Me.TiposArticuloDataSet.DataSetName = "TiposArticuloDataSet"
        Me.TiposArticuloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposArticuloBindingSource
        '
        Me.TiposArticuloBindingSource.DataMember = "TiposArticulo"
        Me.TiposArticuloBindingSource.DataSource = Me.TiposArticuloDataSet
        '
        'TiposArticuloTableAdapter
        '
        Me.TiposArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TiposArticuloTableAdapter = Me.TiposArticuloTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoFinal.TiposArticuloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TiposArticuloBindingNavigator
        '
        Me.TiposArticuloBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TiposArticuloBindingNavigator.BindingSource = Me.TiposArticuloBindingSource
        Me.TiposArticuloBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TiposArticuloBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TiposArticuloBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TiposArticuloBindingNavigatorSaveItem})
        Me.TiposArticuloBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TiposArticuloBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TiposArticuloBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TiposArticuloBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TiposArticuloBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TiposArticuloBindingNavigator.Name = "TiposArticuloBindingNavigator"
        Me.TiposArticuloBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TiposArticuloBindingNavigator.Size = New System.Drawing.Size(296, 25)
        Me.TiposArticuloBindingNavigator.TabIndex = 0
        Me.TiposArticuloBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TiposArticuloBindingNavigatorSaveItem
        '
        Me.TiposArticuloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TiposArticuloBindingNavigatorSaveItem.Image = CType(resources.GetObject("TiposArticuloBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TiposArticuloBindingNavigatorSaveItem.Name = "TiposArticuloBindingNavigatorSaveItem"
        Me.TiposArticuloBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TiposArticuloBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTipoArticuloTextBox
        '
        Me.IdTipoArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposArticuloBindingSource, "IdTipoArticulo", True))
        Me.IdTipoArticuloTextBox.Location = New System.Drawing.Point(135, 79)
        Me.IdTipoArticuloTextBox.Name = "IdTipoArticuloTextBox"
        Me.IdTipoArticuloTextBox.Size = New System.Drawing.Size(108, 20)
        Me.IdTipoArticuloTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposArticuloBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(135, 105)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(108, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposArticuloBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(51, 163)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(192, 20)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(78, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tipos de Articulos"
        '
        'VentanaTipoArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(296, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdTipoArticuloLabel)
        Me.Controls.Add(Me.IdTipoArticuloTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.TiposArticuloBindingNavigator)
        Me.Name = "VentanaTipoArticulos"
        Me.Text = "VentanaTipoArticulos"
        CType(Me.TiposArticuloDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposArticuloBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TiposArticuloBindingNavigator.ResumeLayout(False)
        Me.TiposArticuloBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TiposArticuloDataSet As TiposArticuloDataSet
    Friend WithEvents TiposArticuloBindingSource As BindingSource
    Friend WithEvents TiposArticuloTableAdapter As TiposArticuloDataSetTableAdapters.TiposArticuloTableAdapter
    Friend WithEvents TableAdapterManager As TiposArticuloDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TiposArticuloBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TiposArticuloBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTipoArticuloTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
