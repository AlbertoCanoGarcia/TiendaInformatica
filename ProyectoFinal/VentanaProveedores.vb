Public Class VentanarProveedores
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim validar As New ClaseDecimal

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VentanarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validar.establecer()
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            orden_sql = "Select * from Proveedores"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While Midatareader.Read
                ultimo = ultimo + 1
            End While
            Midatareader.Close()
            ultimo = ultimo - 1
            contador = 0
        Catch ex As Exception
            MsgBox("Fallo en la conexion, intentelo de nuevo")
            Me.Close()
        End Try
        deshabilitar(Me)
        verbotones2()
        posicion(contador)
    End Sub

    Public Sub posicion(ByVal cont As Integer)

        orden_sql = "Select * from Proveedores "
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
            CodProdTextBox.Text = Midatareader("CodProd").ToString
            Razon_socialTextBox.Text = Midatareader("Razon_social").ToString
            DescripcionTextBox.Text = Midatareader("Descripcion").ToString
            NIF_CIFTextBox.Text = Midatareader("NIF_CIF").ToString
            DireccionTextBox.Text = Midatareader("Direccion").ToString
            TelefonoTextBox.Text = Midatareader("Telefono").ToString
            LocalidadTextBox.Text = Midatareader("Localidad").ToString
            ProvinciaTextBox.Text = Midatareader("Provincia").ToString
            CPTextBox.Text = Midatareader("CP").ToString
            PersonaContactoTextBox.Text = Midatareader("PersonaContacto").ToString
            textoFechaAlta.Text = Midatareader("FechaAlta").ToString
            textoFechaBaja.Text = Midatareader("FechaBaja").ToString
            textoFechaUltimaCompra.Text = Midatareader("Fecha_Ultima_Compra").ToString
            Descuento_habitualTextBox.Text = Midatareader("Descuento_habitual").ToString
            AcumuladoComprasTextBox.Text = Midatareader("AcumuladoCompras").ToString
            FormaPagoTextBox.Text = Midatareader("FormaPago").ToString
            textoobservaciones.Text = Midatareader("Observaciones").ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

        If TypeOf textos Is TextBox Or TypeOf textos Is ComboBox Or TypeOf textos Is MaskedTextBox Then
            textos.Enabled = False
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                deshabilitar(contex)
            Next
        End If

    End Sub

    Private Sub habilitar(ByVal textos As Control)

        If TypeOf textos Is TextBox Or TypeOf textos Is ComboBox Or TypeOf textos Is MaskedTextBox Or TypeOf textos Is RichTextBox Then
            textos.Enabled = True
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                habilitar(contex)
            Next
        End If
        textoFechaAlta.Enabled = False
        textoFechaBaja.Enabled = False
        textoFechaUltimaCompra.Enabled = False
        AcumuladoComprasTextBox.Enabled = False
    End Sub

    Private Sub limpiar(ByVal textos As Control)

        If TypeOf textos Is TextBox Or TypeOf textos Is ComboBox Or TypeOf textos Is MaskedTextBox Or TypeOf textos Is RichTextBox Then
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
        Bcancelar.Visible = True
        BSalir.Visible = False

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
        Bcancelar.Visible = False
        BSalir.Visible = True

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancelar.Click
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
        orden_sql = "Select * from Proveedores"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        Dim x As Integer
        While Midatareader.Read
            x = CInt(Midatareader("CodProd").ToString)
        End While
        x = x + 1
        Midatareader.Close()
        CodProdTextBox.Text = Format(x, "0000")
        textoFechaAlta.Text = Format(CDate(Now.ToShortDateString), "dd/MM/yyyy")
        textoFechaBaja.Text = "01/01/0001"
        opc = 1
        Baceptar.Enabled = True
        Bcancelar.Enabled = True
    End Sub

    Private Sub botonok_Click(sender As Object, e As EventArgs) Handles botonok.Click
        Dim id As String
        Try
            orden_sql = "select CodProd from Proveedores where Razon_social  ='" & textobuscar.Text & "';"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            id = Midatareader(0).ToString
            Midatareader.Close()

            orden_sql = "select * from Proveedores where CodProd ='" & id & "';"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()

            botonok.Enabled = False
            textobuscar.Enabled = False
            textobuscar.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rellenar()
    End Sub


    Private Sub Bconsulta_Click(sender As Object, e As EventArgs) Handles Bconsulta.Click
        textobuscar.Enabled = True
        botonok.Visible = True
        botonok.Enabled = True
        deshabilitar(Me)
        textobuscar.Enabled = True

    End Sub

    Private Sub Bbaja_Click(sender As Object, e As EventArgs) Handles Bbaja.Click
        '    Dim res As DialogResult = MessageBox.Show("¿Desea borrar el producto?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        '    If res = DialogResult.Yes Then
        '        Try
        '            orden_sql = "delete from Articulos where idArticulos = '" & textoIdArticulos.Text & "';"
        '            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        '            comando.ExecuteNonQuery()
        '            ultimo = ultimo - 1
        '            contador = 0
        '            MsgBox("articulo eliminado correctamente")
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '        End Try
        '        posicion(contador)
        '    End If
        textoFechaBaja.Text = Format(CDate(Now.ToShortDateString), "dd/MM/yyyy")
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



    Private Sub Baceptar_Click(sender As Object, e As EventArgs) Handles Baceptar.Click
        Dim descuento_habitual, tarifa, acumuladoCompras As Single
        Dim fechaAlta, fechaBaja, fechaUltimaCompra As Date
        descuento_habitual = CSng(validar.RemplazarComa(Descuento_habitualTextBox.Text))

        fechaAlta = CDate(textoFechaAlta.Text)
        fechaBaja = CDate(textoFechaBaja.Text)
        If (textoFechaUltimaCompra.Text.Equals("  /  /")) Then
            fechaUltimaCompra = CDate("01/01/0001")

        Else
            fechaUltimaCompra = CDate(textoFechaUltimaCompra.Text)
        End If

        Select Case opc
            Case 1
                Try
                    orden_sql = "insert into Proveedores(Codprod, Razon_social, Descripcion, NIF_CIF, Direccion, Telefono, Localidad, Provincia, CP, PersonaContacto, FechaAlta, FechaBaja , Fecha_ultima_compra, Descuento_habitual, 
                        Formapago,Tarifa, Observaciones) " &
                                "VALUES('" & CodProdTextBox.Text &
                                "','" & Razon_socialTextBox.Text &
                                "','" & DescripcionTextBox.Text &
                                "','" & NIF_CIFTextBox.Text &
                                "','" & DireccionTextBox.Text &
                                "','" & TelefonoTextBox.Text &
                                "','" & LocalidadTextBox.Text &
                                "','" & ProvinciaTextBox.Text &
                                "','" & CPTextBox.Text &
                                "','" & PersonaContactoTextBox.Text &
                                "','" & Format(fechaAlta, "MM/dd/yyyy") &
                                "','" & Format(fechaBaja, "MM/dd/yyyy") &
                                "','" & Format(fechaUltimaCompra, "MM/dd/yyyy") &
                                "','" & descuento_habitual &
                                "','" & FormaPagoTextBox.Text &
                                "','" & TarifaTextBox.Text &
                                "','" & textoobservaciones.Text & "');"

                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                    comando.ExecuteNonQuery()
                    ultimo = ultimo + 1
                    contador = ultimo
                    ToolStripStatusLabel1.Text = "El proveedor fue dado de alta correctomente"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                verbotones2()
                deshabilitar(Me)
                posicion(contador)
            Case 2
                Try
                    orden_sql = "update Proveedores set CodProd = '" & CodProdTextBox.Text &
                        "', Razon_social = '" & Razon_socialTextBox.Text &
                        "', Descripcion = '" & DescripcionTextBox.Text &
                        "', NIF_CIF = '" & NIF_CIFTextBox.Text &
                        "', Direccion = '" & DireccionTextBox.Text &
                        "', Telefono = '" & TelefonoTextBox.Text &
                        "', Localidad = '" & LocalidadTextBox.Text &
                        "', Provincia = '" & ProvinciaTextBox.Text &
                        "', CP = '" & CPTextBox.Text &
                        "', PersonaContacto = '" & PersonaContactoTextBox.Text &
                        "', FechaAlta = '" & Format(fechaAlta, "MM/dd/yyyy") &
                        "', FechaBaja = '" & Format(fechaBaja, "MM/dd/yyyy") &
                        "', Fecha_ultima_compra = '" & Format(fechaUltimaCompra, "MM/dd/yyyy") &
                        "', Descuento_habitual = '" & descuento_habitual &
                        "', AcumuladoCompras = '" & acumuladoCompras &
                        "', FormaPago = '" & FormaPagoTextBox.Text &
                        "', Tarifa = '" & TarifaTextBox.Text &
                        "', Observaciones = '" & textoobservaciones.Text & "' where CodProd = '" & CodProdTextBox.Text & "';"
                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                    comando.ExecuteNonQuery()
                    ToolStripStatusLabel1.Text = "Proveedor modificado"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                verbotones2()
                deshabilitar(Me)
                posicion(contador)
        End Select

    End Sub

    Private Sub textobuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles textobuscar.KeyUp
        actualizarCombobox("Proveedores", textobuscar.Text, "Razon_social", textobuscar)
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
End Class