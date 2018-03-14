Public Class VentanaTipoArticulos
    Private Sub TiposArticuloBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TiposArticuloBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TiposArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TiposArticuloDataSet)

    End Sub

    Private Sub VentanaTipoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiposArticuloDataSet.TiposArticulo' Puede moverla o quitarla según sea necesario.
        Me.TiposArticuloTableAdapter.Fill(Me.TiposArticuloDataSet.TiposArticulo)

    End Sub
End Class