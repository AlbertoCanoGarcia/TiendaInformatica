Public Class MantenimientoCliente
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim fila As String()
    Dim nalbaran As Integer
    Dim validar As New ClaseDecimal
    Dim busqueda As String
    Dim criterio As String
    Private Sub botonborrar_Click(sender As Object, e As EventArgs) Handles botonborrar.Click
        Dim numid As String
        Dim indice As Integer
        indice = tablacliente.SelectedCells.Item(0).RowIndex
        numid = tablacliente.Item(0, indice).Value
        Try
        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            orden_sql = "Delete  from Clientes where id='" & numid & "'"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            comando.ExecuteNonQuery()
            ToolStripStatusLabel1.Text = "Cliente dado de baja corecctamente"
            tablacliente.Rows.Item(indice).Cells.Clear()

        Catch ex As Exception
            MsgBox("Fallo en la conexion, intentelo de nuevo")
            Me.Close()
        End Try
    End Sub
    Dim Form As VentanaNuevoCliente

    Private Sub botonanadircliente_Click(sender As Object, e As EventArgs) Handles botonanadircliente.Click
        Form = New VentanaNuevoCliente
        Form.Show()


    End Sub

    Private Sub tablacliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablacliente.CellContentClick
        Dim filaSeleccionado, i As Integer
        filaSeleccionado = CInt(tablacliente.SelectedCells.Item(0).RowIndex)
        i = 0
        While (i < tablacliente.Rows.Count)
            If (i = filaSeleccionado) Then
            Else
                tablacliente.Rows(i).ReadOnly = True
            End If

            i = i + 1
        End While


    End Sub

    Private Sub MantenimientoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validar.establecer()
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            orden_sql = "Select * from Clientes"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While Midatareader.Read
                fila = {Midatareader("id").ToString, Midatareader("Nombre").ToString, Midatareader("nif_cif").ToString, Midatareader("telefono").ToString, Midatareader("email").ToString, Midatareader("direccion").ToString, Midatareader("localidad").ToString, Midatareader("provincia").ToString, Midatareader("cp").ToString, Midatareader("cuentabancaria").ToString, Midatareader("Fecha_ultima_venta").ToString.Split(" ").ElementAt(0), Midatareader("fecha_alta").ToString.Split(" ").ElementAt(0), Midatareader("Direccion_entrega").ToString}
                tablacliente.Rows.Add(fila)
            End While
            Midatareader.Close()
            Dim fila2 As String()
            fila2 = {"Id", "Nombre", "NIF_CIF", "Localidad ", "Direccion", "Provincia", "CP", "Direccion_entrega"}
            Dim a As Integer = 0
            While (a < fila2.Length)
                textobuscar.Items.Add(fila2(a))
                a = a + 1
            End While

        Catch ex As Exception
            MsgBox("Fallo en la conexion, intentelo de nuevo")
            Me.Close()
        End Try

    End Sub
    Private Sub verbotones()
        botonanadircliente.Visible = False
        botonborrar.Visible = False
        botonmodificar.Visible = False
        botonbuscar.Visible = False
        Baceptar.Visible = True
        Bcancelar.Visible = True
        BSalir.Visible = False
        Baceptar.Enabled = True
        Bcancelar.Enabled = True
    End Sub

    Private Sub verbotones2()
        botonanadircliente.Visible = True
        botonborrar.Visible = True
        botonmodificar.Visible = True
        botonbuscar.Visible = True
        Baceptar.Visible = False
        Bcancelar.Visible = False
        BSalir.Visible = True
        Baceptar.Enabled = False
        Bcancelar.Enabled = False
    End Sub

    Private Sub botonmodificar_Click(sender As Object, e As EventArgs) Handles botonmodificar.Click
        verbotones()
        opc = 2
        tablacliente.Enabled = True
    End Sub


    Private Sub Baceptar_Click(sender As Object, e As EventArgs) Handles Baceptar.Click
        Dim fechaAlta, fecha_ultima_venta As Date
        Dim filaSeleccionado As Integer
        filaSeleccionado = CInt(tablacliente.SelectedCells.Item(0).RowIndex)
        fechaAlta = CDate(tablacliente.Item(11, filaSeleccionado).Value)
        fecha_ultima_venta = CDate(tablacliente.Item(10, filaSeleccionado).Value)
        Select Case opc
            Case 2
                Try
                    orden_sql = "update Clientes set Id = '" & tablacliente.Item(0, filaSeleccionado).Value &
                        "', nombre = '" & tablacliente.Item(1, filaSeleccionado).Value &
                        "', nif_cif = '" & tablacliente.Item(2, filaSeleccionado).Value &
                        "', telefono = '" & tablacliente.Item(3, filaSeleccionado).Value &
                        "', email = '" & tablacliente.Item(4, filaSeleccionado).Value &
                        "', direccion = '" & tablacliente.Item(5, filaSeleccionado).Value &
                        "', localidad = '" & tablacliente.Item(6, filaSeleccionado).Value &
                        "', provincia = '" & tablacliente.Item(7, filaSeleccionado).Value &
                        "', cp = '" & tablacliente.Item(8, filaSeleccionado).Value &
                        "', cuentabancaria = '" & tablacliente.Item(9, filaSeleccionado).Value &
                        "', fecha_ultima_venta = '" & Format(fecha_ultima_venta, "MM/dd/yyyy") &
                        "', fecha_alta = '" & Format(fechaAlta, "MM/dd/yyyy") &
                        "', direccion_entrega = '" & tablacliente.Item(12, filaSeleccionado).Value & "' where Id = '" & tablacliente.Item(0, filaSeleccionado).Value & "';"
                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                    comando.ExecuteNonQuery()
                    ToolStripStatusLabel1.Text = "Cliente modificado"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 3
                tablacliente.Rows.Clear()
                criterio = textobuscar.SelectedItem
                busqueda = textodatobuscar.SelectedItem
                Try
                    orden_sql = "Select * from Clientes where " & criterio & "='" & busqueda & "'"
                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                    Midatareader = comando.ExecuteReader
                    While Midatareader.Read
                        fila = {Midatareader("id").ToString, Midatareader("Nombre").ToString, Midatareader("nif_cif").ToString, Midatareader("telefono").ToString, Midatareader("email").ToString, Midatareader("direccion").ToString, Midatareader("localidad").ToString, Midatareader("provincia").ToString, Midatareader("cp").ToString, Midatareader("cuentabancaria").ToString, Midatareader("Fecha_ultima_venta").ToString.Split(" ").ElementAt(0), Midatareader("fecha_alta").ToString.Split(" ").ElementAt(0), Midatareader("Direccion_entrega").ToString}
                        tablacliente.Rows.Add(fila)
                    End While
                    Midatareader.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End Select
        verbotones2()
        deshabilitar(Me)
        limpiar(Me)
    End Sub

    Private Sub Bcancelar_Click(sender As Object, e As EventArgs) Handles Bcancelar.Click
        verbotones2()
        deshabilitar(Me)
        Dim filaSeleccionado, i As Integer
        filaSeleccionado = CInt(tablacliente.SelectedCells.Item(0).RowIndex)
        i = 0
        While (i < tablacliente.Rows.Count)
            tablacliente.Rows(i).ReadOnly = False
            i = i + 1
        End While
    End Sub
    Private Sub deshabilitar(ByVal textos As Control)

        If TypeOf textos Is TextBox Or TypeOf textos Is ComboBox Then
            textos.Enabled = False
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                deshabilitar(contex)
            Next
        End If

    End Sub

    Private Sub botonbuscar_Click(sender As Object, e As EventArgs) Handles botonbuscar.Click
        deshabilitar(Me)
        verbotones()
        textobuscar.Enabled = True
        textodatobuscar.Enabled = True
        opc = 3
    End Sub


    Private Sub actualizarCombobox()
        textodatobuscar.Items.Clear()
        Dim array As List(Of String)
        array = New List(Of String)
        Dim textointroducido As String
        textointroducido = textodatobuscar.Text
        criterio = textobuscar.Text
        orden_sql = "Select distinct " & criterio & " from Clientes"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            array.Add(Midatareader(0).ToString)
        End While
        Dim i As Integer = 0
        While (i < array.Count)
            If (array.Item(i).ToUpper.Contains(textointroducido.ToUpper)) Then
                textodatobuscar.Items.Add(array.Item(i))
            End If

            i = i + 1
        End While
        Midatareader.Close()
        textodatobuscar.Select(textodatobuscar.Text.Length, 0)
    End Sub

    Private Sub textodatobuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles textodatobuscar.KeyUp
        actualizarCombobox()
    End Sub

    Private Sub limpiar(ByVal textos As Control)

        If TypeOf textos Is TextBox Or TypeOf textos Is ComboBox Then
            textos.Text = ""
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                limpiar(contex)
            Next

        End If

    End Sub


End Class