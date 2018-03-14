Public Class VentanaEmpresa
    Private Sub EmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpresaBindingSource.EndEdit()


    End Sub

    Private Sub VentanaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpresaTableAdapter.Fill(Me.EmpresaDataSet.Empresa)

    End Sub
End Class