Public Class VentanaProductos
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim validar As New ClaseDecimal
    Dim proveedor1, marca1, tipoarticulo1 As List(Of String)
    Dim indiceProveedore, indiceMarca, indiceTipoArticulo As Integer

    Private Sub ArticulosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VentanaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validar.establecer()
        marca1 = New List(Of String)
        proveedor1 = New List(Of String)
        tipoarticulo1 = New List(Of String)
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            orden_sql = "Select * from Articulos"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While Midatareader.Read
                ultimo = ultimo + 1
            End While
            Midatareader.Close()
            ultimo = ultimo - 1
            contador = 0

            orden_sql = "Select  codprod , Razon_social from Proveedores "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While (Midatareader.Read())
                proveedor1.Add(Midatareader(0).ToString)
                textoproveedor.Items.Add(Midatareader(1).ToString)
            End While

            Midatareader.Close()

            orden_sql = "Select idMarca, Nombre from Marca "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While (Midatareader.Read())
                marca1.Add(Midatareader(0).ToString)
                textomarca.Items.Add(Midatareader(1).ToString)
            End While
            Midatareader.Close()

            orden_sql = "Select  idTipoArticulo, nombre from tiposArticulo "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While (Midatareader.Read())
                tipoarticulo1.Add(Midatareader(0).ToString)
                textotipoarticulo.Items.Add(Midatareader(1).ToString)
            End While
            Midatareader.Close()


        Catch ex As Exception
            MsgBox("Fallo en la conexion, intentelo de nuevo")
            Me.Close()
        End Try
        deshabilitar(Me)
        verbotones2()
        posicion(contador)

    End Sub

    Public Sub posicion(ByVal cont As Integer)

        orden_sql = "Select * from Articulos "
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader


        If cont = 0 Then
            Bprimero.Enabled = False
            BAnterior.Enabled = False
        End If
        If cont = ultimo Then
            BSiguiente.Enabled = False
            Bultimo.Enabled = False
        End If
        If cont > 0 Then
            Bprimero.Enabled = True
            BAnterior.Enabled = True
        End If
        If cont < ultimo Then
            BSiguiente.Enabled = True
            Bultimo.Enabled = True
        End If


        Dim x As Integer
        For x = 0 To cont
            Midatareader.Read()
        Next
        rellenar()

    End Sub

    Private Sub rellenar()
        Dim idproveedor = "", idmarca = "", idtipo As String = ""
        Try
            textoIdArticulos.Text = Midatareader("IdArticulos").ToString
            idproveedor = Midatareader("idProveedores").ToString
            idmarca = Midatareader("idMarca").ToString
            textoDescripcion.Text = Midatareader("Descripcion").ToString
            idtipo = Midatareader("idTipoArticulo").ToString
            textoDescripcion.Text = Midatareader("descripcion").ToString
            textoPrecioCompra.Text = Midatareader("precioCompra").ToString
            textoPvp.Text = Midatareader("pvp").ToString
            textoStockActual.Text = Midatareader("StockActual").ToString
            textoStockMinimo.Text = Midatareader("StockMinimo").ToString
            textoPvp1.Text = Midatareader("PVP1").ToString
            textoPvp2.Text = Midatareader("PVP2").ToString
            textoPvp3.Text = Midatareader("PVP3").ToString
            textoGarantia.Text = Midatareader("garantia").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Midatareader.Close()


        orden_sql = "Select Razon_social from Proveedores where CodProd='" & idproveedor & "';"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            textoproveedor.Text = Midatareader(0).ToString
        End While

        Midatareader.Close()

        orden_sql = "Select Nombre from Marca where IdMarca='" & idmarca & "'"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            textomarca.Text = Midatareader(0).ToString
        End While
        Midatareader.Close()

        orden_sql = "Select  nombre from tiposArticulo where idtipoArticulo='" & idtipo & "'"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            textotipoarticulo.Text = Midatareader(0).ToString
        End While

        Midatareader.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bprimero.Click
        contador = 0
        posicion(contador)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bultimo.Click
        contador = ultimo
        posicion(contador)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAnterior.Click
        contador = contador - 1
        If contador < 0 Then
            contador = 0
        End If
        posicion(contador)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        contador = contador + 1
        If contador > ultimo Then
            contador = ultimo
        End If
        posicion(contador)
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

    Private Sub habilitar(ByVal textos As Control)

        If TypeOf textos Is TextBox Or TypeOf textos Is ComboBox Then
            textos.Enabled = True
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                habilitar(contex)
            Next
        End If


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

    Private Sub verbotones()
        Bprimero.Visible = False
        BAnterior.Visible = False
        BSiguiente.Visible = False
        Bultimo.Visible = False
        BAlta.Visible = False
        Bbaja.Visible = False
        Bmodifi.Visible = False
        Bconsulta.Visible = False
        Baceptar.Visible = True
        BCancelar.Visible = True
        Bsalir.Visible = False

    End Sub

    Private Sub verbotones2()
        Bprimero.Visible = True
        BAnterior.Visible = True
        BSiguiente.Visible = True
        Bultimo.Visible = True
        BAlta.Visible = True
        Bbaja.Visible = True
        Bmodifi.Visible = True
        Bconsulta.Visible = True
        Baceptar.Visible = False
        BCancelar.Visible = False
        Bsalir.Visible = True

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        Midatareader.Close()
        verbotones2()
        deshabilitar(Me)
        posicion(contador)
    End Sub

    Private Sub BAlta_Click(sender As Object, e As EventArgs) Handles BAlta.Click
        verbotones()
        limpiar(Me)
        habilitar(Me)
        textobuscar.Enabled = False
        orden_sql = "Select * from Articulos"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        Dim x As Integer
        While Midatareader.Read
            x = CInt(Midatareader("IdArticulos").ToString)
        End While
        x = x + 1
        Midatareader.Close()
        textoIdArticulos.Text = Format(x, "0000")
        opc = 1
        Baceptar.Enabled = True
        Bcancelar.Enabled = True
    End Sub

    Private Sub textomarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textomarca.SelectedIndexChanged
        indiceMarca = textomarca.SelectedIndex
    End Sub

    Private Sub textotipoarticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textotipoarticulo.SelectedIndexChanged
        indiceTipoArticulo = textotipoarticulo.SelectedIndex
    End Sub

    Private Sub botonok_Click(sender As Object, e As EventArgs) Handles botonok.Click
        Dim id As String
        Try
            orden_sql = "select idArticulos from articulos where descripcion  ='" & textobuscar.Text & "';"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            id = Midatareader(0).ToString
            Midatareader.Close()

            orden_sql = "select * from articulos where idArticulos ='" & id & "';"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rellenar()
        botonok.Visible = False
        textobuscar.Enabled = False
        contador = CInt(textoIdArticulos.Text) - 1
    End Sub


    Private Sub Bconsulta_Click(sender As Object, e As EventArgs) Handles Bconsulta.Click
        textobuscar.Enabled = True
        botonok.Visible = True


    End Sub

    Private Sub Bbaja_Click(sender As Object, e As EventArgs) Handles Bbaja.Click
        Dim res As DialogResult = MessageBox.Show("¿Desea borrar el producto?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If res = DialogResult.Yes Then
            Try
                orden_sql = "delete from Articulos where idArticulos = '" & textoIdArticulos.Text & "';"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()
                ultimo = ultimo - 1
                contador = 0
                ToolStripStatusLabel1.Text = "articulo eliminado correctamente"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            posicion(contador)
        End If
    End Sub

    Private Sub Bmodifi_Click(sender As Object, e As EventArgs) Handles Bmodifi.Click
        verbotones()
        habilitar(Me)
        textobuscar.Enabled = False
        opc = 2
        Baceptar.Enabled = True
        Bcancelar.Enabled = True
    End Sub

    Private Sub Bcancelar_Click(sender As Object, e As EventArgs) Handles Bcancelar.Click
        verbotones2()
    End Sub



    Private Sub textoproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textoproveedor.SelectedIndexChanged
        indiceProveedore = textoproveedor.SelectedIndex

    End Sub

    Private Sub Baceptar_Click(sender As Object, e As EventArgs) Handles Baceptar.Click
        Dim pvp1, pvp2, pvp3, precioCompra, pvp, stockActual, stockMinimo As Single
        precioCompra = CSng(validar.RemplazarComa(textoPrecioCompra.Text))
        stockActual = CSng(validar.RemplazarComa(textoStockActual.Text))
        stockMinimo = CSng(validar.RemplazarComa(textoStockMinimo.Text))
        pvp = CSng(validar.RemplazarComa(textoPvp.Text))
        pvp1 = CSng(validar.RemplazarComa(textoPvp1.Text))
        pvp2 = CSng(validar.RemplazarComa(textoPvp2.Text))
        pvp3 = CSng(validar.RemplazarComa(textoPvp3.Text))
        Select Case opc
            Case 1
                Try
                    orden_sql = "insert into Articulos(IdArticulos, idProveedores,idMarca, idTipoArticulo, descripcion, precioCompra, pvp,stockActual,StockMinimo,PVP1, PVP2,PVP3,garantia) " &
                                "VALUES('" & textoIdArticulos.Text &
                                "','" & proveedor1.Item(indiceProveedore) &
                                "','" & marca1.Item(indiceMarca) &
                                "','" & tipoarticulo1.Item(indiceTipoArticulo) &
                                "','" & textoDescripcion.Text &
                                "','" & precioCompra &
                                "','" & pvp &
                                "','" & stockActual &
                                "','" & stockMinimo &
                                "','" & pvp1 &
                                "','" & pvp2 &
                                "','" & pvp3 &
                                "','" & textoGarantia.Text & "');"

                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                    comando.ExecuteNonQuery()
                    ultimo = ultimo + 1
                    contador = ultimo
                    ToolStripStatusLabel1.Text = "El articulo fue dado de alta correctomente"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                verbotones2()
                deshabilitar(Me)
                posicion(contador)
            Case 2
                Try
                    orden_sql = "update Articulos set IdArticulos = '" & textoIdArticulos.Text &
                        "', idProveedores = '" & proveedor1.Item(indiceProveedore) &
                        "', idMarca = '" & marca1.Item(indiceMarca) &
                        "', idtipoArticulo = '" & tipoarticulo1.Item(indiceTipoArticulo) &
                        "', descripcion = '" & textoDescripcion.Text &
                        "', precioCompra = '" & precioCompra &
                        "', pvp = '" & pvp &
                        "', stockActual = '" & stockActual &
                        "', stockMinimo = '" & stockMinimo &
                        "', PVP1 = '" & pvp1 &
                        "', PVP2 = '" & pvp2 &
                        "', PVP3 = '" & pvp3 &
                        "', garantia = '" & textoGarantia.Text & "' where IdArticulos = '" & textoIdArticulos.Text & "';"
                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                    comando.ExecuteNonQuery()
                    ToolStripStatusLabel1.Text = "articulo modificado"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                verbotones2()
                deshabilitar(Me)
                posicion(contador)
        End Select
    End Sub

    Private Sub textobuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles textobuscar.KeyUp
        actualizarCombobox("Articulos", textobuscar.Text, "Descripcion", textobuscar)
    End Sub

    Private Sub actualizarCombobox(ByVal tabla As String, ByVal textointroducido As String, ByVal criterio As String,
               ByVal texto As ComboBox)
        texto.Items.Clear()
        Dim array As List(Of String)
        array = New List(Of String)
        orden_sql = "Select distinct " & criterio & " from " & tabla & ""
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            array.Add(Midatareader(0).ToString)
        End While
        Dim i As Integer = 0
        While (i < array.Count)
            If (array.Item(i).ToUpper.Contains(textointroducido.ToUpper)) Then
                texto.Items.Add(array.Item(i))
            End If

            i = i + 1
        End While
        Midatareader.Close()
        texto.Select(texto.Text.Length, 0)
    End Sub

    Private Sub textoproveedor_KeyUp(sender As Object, e As KeyEventArgs) Handles textoproveedor.KeyUp
        actualizarCombobox("Proveedores", textoproveedor.Text, "Razon_social", textoproveedor)
    End Sub

    Private Sub textomarca_KeyUp(sender As Object, e As KeyEventArgs) Handles textomarca.KeyUp
        actualizarCombobox("Marca", textomarca.Text, "nombre", textomarca)
    End Sub

    Private Sub textotipoarticulo_KeyUp(sender As Object, e As KeyEventArgs) Handles textotipoarticulo.KeyUp
        actualizarCombobox("TiposArticulo", textotipoarticulo.Text, "nombre", textotipoarticulo)
    End Sub
End Class