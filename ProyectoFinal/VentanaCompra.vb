Public Class VentanaCompra

    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim numlinea As Integer = 0
    Dim nalbaran As Integer
    Dim codprod2(10) As Integer
    Dim productodesuento(10), pvp2(10), unidad2(10), importelinea2(10) As Single
    Dim fila As String()
    Dim descrip(10) As String
    Dim p As Integer = 0
    Dim portes As Single
    Dim base As Single
    Dim poriva As Single
    Dim importelineas, descuento As Single
    Dim fpago As String
    Dim clase As New ClaseDecimal
    Dim fila2 As String()
    Dim criterio As String
    Dim descuentoCliente, b As Single

    Dim nombreproveedor, direccionproveedor
    Dim idProveedor As String
    Private Sub botonbuscar_Click(sender As Object, e As EventArgs) Handles botonbuscar.Click
        deshabilitar(Me)
        verbotones()
        textobuscar.Enabled = True
        textodatobuscar.Enabled = True
    End Sub

    Private Sub VentanaAlbaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            orden_sql = "Select porcentaje from TipodeIVA"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While (Midatareader.Read())
                textoporcentajeiva.Items.Add(Midatareader(0).ToString)
            End While
            Midatareader.Close()

        Catch ex As Exception
            MsgBox("Fallo en la conexion, intentelo de nuevo")
            Me.Close()
        End Try
        rellenar()
        clase.establecer()

    End Sub

    Private Sub botoninsertarfila_Click(sender As Object, e As EventArgs) Handles botoninsertarfila.Click
        If (textodescripcion.Text = "" Or textopvp.Text = "" Or textounidad.Text = "" Or textoproductodescuento.Text = "" Or
            textoimportelinea.Text = "") Then
            ToolStripStatusLabel1.Text = "Faltan introducir datos del producto"
        Else
            numlinea = numlinea + 1

            orden_sql = "Select idArticulos from Articulos where descripcion='" & textodescripcion.Text & "'"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Dim a As Integer = 0
            While (Midatareader.Read())
                codprod2(a) = Midatareader(0).ToString
                a = a + 1
            End While
            Midatareader.Close()


            descrip(p) = textodescripcion.Text
            nalbaran = CInt(textonumeroalbaran.Text)

            If (textopvp.Text = "") Then
                pvp2(p) = 0
            Else
                pvp2(p) = CSng(clase.RemplazarComa(textopvp.Text))
            End If

            If (textounidad.Text = "") Then
                unidad2(p) = 0
            Else
                unidad2(p) = CSng(clase.RemplazarComa(textounidad.Text))
                b = CSng(clase.RemplazarComa(textounidad.Text))
            End If

            If (textoproductodescuento.Text = "") Then
                productodesuento(p) = 0
            Else
                productodesuento(p) = CSng(clase.RemplazarComa(textoproductodescuento.Text))
            End If
            If (textoimportelinea.Text = "") Then
                importelinea2(p) = 0
            Else
                importelinea2(p) = CSng(clase.RemplazarComa(textoimportelinea.Text))
            End If

            fila = {numlinea, textodescripcion.Text, Format(pvp2(p), "##,##0.00"), Format(unidad2(p), "##,##0.00"), Format(productodesuento(p), "##,##0.00"), Format(importelinea2(p), "##,##0.00")}
            tablalineaventa.Rows.Add(fila)

            p = p + 1

            textopvp.Text = ""
            textounidad.Text = ""
            textoproductodescuento.Text = ""
            textoimportelinea.Text = ""
            textodescripcion.Text = ""
            textodescripcion.BackColor = Color.White
        End If
    End Sub



    Private Sub rellenar()
        textonumeroalbaran.Text = Format(ModuloEmpresa.contadorCompras + 1, "0000")
        Dim fechas As Date
        fechas = CDate(Now.ToShortDateString)
        textofecha.Text = Format(fechas, "dd/MM/yyyy")
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

        If TypeOf textos Is TextBox Or TypeOf textos Is ComboBox Or TypeOf textos Is Button Then
            textos.Enabled = True
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                habilitar(contex)
            Next
        End If
        textoimportelinea.Enabled = False
        textosuma.Enabled = False
        textodescuento.Enabled = False
        textobaseimponible.Enabled = False
        textototalimpuestos.Enabled = False
    End Sub
    Private Sub verbotones()
        botonbuscar.Visible = False

    End Sub

    Private Sub textobuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textobuscar.SelectedIndexChanged
        criterio = textobuscar.Text
    End Sub

    Private Sub textodatobuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textodatobuscar.SelectedIndexChanged
        Dim busqueda = textodatobuscar.SelectedItem
        If (criterio.Equals("Razon_Social")) Then
            orden_sql = "Select Razon_social, nif_cif,direccion,localidad,telefono, Email,Descuento_habitual,CodProd from Proveedores where Razon_social='" + busqueda + "'"
        Else
            orden_sql = "Select Razon_social, nif_cif,direccion,localidad,telefono, Email,Descuento_habitual,CodProd from Proveedores where nif_cif='" + busqueda + "'"
        End If

        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        Midatareader.Read()
        nombreproveedor = Midatareader(0).ToString
        direccionproveedor = Midatareader(2).ToString
        Dim datosCliente As String = "" + nombreproveedor + vbLf + Midatareader(1).ToString + vbLf + direccionproveedor + " " + Midatareader(3).ToString + vbLf + Midatareader(4).ToString + vbLf + Midatareader(5).ToString
        descuento = CSng(Midatareader(6).ToString)
        idProveedor = Midatareader(7).ToString
        Midatareader.Close()
        textocliente.Text = datosCliente
        habilitar(Me)
        botonfacturadirecta.Enabled = False
        botonimprimir.Enabled = False
        botonaceptar.Enabled = True
        botoncancelar.Enabled = True

    End Sub

    Private Sub textodescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textodescripcion.SelectedIndexChanged
        orden_sql = "Select pvp ,stockActual from Articulos where descripcion = '" & textodescripcion.Text & "'"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        Midatareader.Read()
        textopvp.Text = Midatareader(0).ToString
        If (Midatareader(1).ToString.Equals("0")) Then
            textodescripcion.ForeColor = Color.Red
            deshabilitar(Me)
        Else
            textodescripcion.BackColor = Color.GreenYellow
        End If
        Midatareader.Close()
    End Sub

    Private Sub verbotones2()
        botonbuscar.Visible = True

    End Sub

    Private Sub textodescripcion_KeyUp(sender As Object, e As KeyEventArgs) Handles textodescripcion.KeyUp
        actualizarComboboxProductosProveedor("Articulos", textodescripcion.Text, "Descripcion", textodescripcion, idProveedor)
    End Sub

    Private Sub botonterminarlineas_Click(sender As Object, e As EventArgs) Handles botonterminarlineas.Click
        Dim x As Integer = 0
        While (x < tablalineaventa.RowCount)
            importelineas = CSng(tablalineaventa.Item(5, x).Value) + importelineas
            x = x + 1

        End While
        textosuma.Text = clase.RemplazarComa(importelineas)
        textoporcentajedescuento.Text = clase.RemplazarComa(descuento)
        descuento = Math.Round(importelineas - (100 - CSng(clase.RemplazarComa(descuento))) / 100 * importelineas, 2)
        textodescuento.Text = clase.RemplazarComa(descuento)
        textoformadepago.Enabled = True
    End Sub

    Private Sub botonaceptar_Click(sender As Object, e As EventArgs) Handles botonaceptar.Click
        Dim suma, porcentajedescuento, descuento, portes, baseimponible, porcentajeiva, iva, totalimpuesto, totalgastadoaño As Single
        suma = CSng(textosuma.Text)
        porcentajedescuento = CSng(clase.RemplazarComa(textoporcentajedescuento.Text))
        descuento = CSng(textodescuento.Text)
        portes = CSng(clase.RemplazarComa(textoportes.Text))
        baseimponible = CSng(textobaseimponible.Text)
        porcentajeiva = CSng(clase.RemplazarComa(textoporcentajeiva.SelectedItem))
        iva = CSng(textoiva.Text)
        totalimpuesto = CSng(textototalimpuestos.Text)
        Dim fecha As Date
        fecha = CDate(textofecha.Text)
        Dim x As Integer = 0

        Try
            orden_sql = "insert into Compras(NCompra,Fecha,DireccionDeEntrega,CodProveedor,Nombre,Direccion,FormaDePago,Observaciones,SumaImporte,PorcentajeDescuento,ImporteDescuento,Portes,BaseImponible,PorcentajeIVA,ImporteIVA,TotalAlbaran) " &
                            "VALUES('" & textonumeroalbaran.Text &
                            "','" & Format(fecha, "MM/dd/yyyy") &
                            "','" & textodireccionentrega.Text &
                            "','" & idProveedor &
                            "','" & nombreproveedor &
                            "','" & direccionproveedor &
                            "','" & fpago &
                            "','" & textoobservaciones.Text &
                            "','" & clase.RemplazarComa(suma) &
                            "','" & clase.RemplazarComa(porcentajedescuento) &
                            "','" & clase.RemplazarComa(descuento) &
                            "','" & clase.RemplazarComa(portes) &
                            "','" & clase.RemplazarComa(baseimponible) &
                            "','" & clase.RemplazarComa(porcentajeiva) &
                            "','" & clase.RemplazarComa(iva) &
                            "','" & clase.RemplazarComa(totalimpuesto) & "');"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            comando.ExecuteNonQuery()
            While (x < numlinea)
                orden_sql = "Select stockActual from Articulos where idArticulos  = '" & Format(codprod2(x), "0000") & "'; "
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                Midatareader = comando.ExecuteReader
                Midatareader.Read()
                Dim stock As Single = CSng((clase.RemplazarComa(Midatareader(0).ToString))) + b
                Midatareader.Close()

                orden_sql = "update Articulos set stockActual='" & stock &
                "' where idArticulos = '" & Format(codprod2(x), "0000") & "';"

                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()

                x = x + 1
            End While
            x = 0
            While (x < numlinea)

                orden_sql = "insert into LineasCompra(NCompra,Nlinea,Codprod,Descripcion,PVP,Unidad,PorcentajeDescuento,ImporteLinea) " &
                        "VALUES('" & textonumeroalbaran.Text &
                        "','" & Format(x + 1, "0000") &
                        "','" & codprod2(x) &
                        "','" & descrip(x) &
                        "','" & clase.RemplazarComa(pvp2(x)) &
                        "','" & clase.RemplazarComa(unidad2(x)) &
                        "','" & clase.RemplazarComa(productodesuento(x)) &
                        "','" & clase.RemplazarComa(importelinea2(x)) & "');"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()
                x = x + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            orden_sql = "update Empresa set ContadorCompras= '" & ModuloEmpresa.contadorCompras + 1 &
                "' where Nombre =  '" & "CanoMatic" & "';"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            comando.ExecuteNonQuery()

            orden_sql = "Select AcumuladoCompras from Proveedores where CodProd='" & idProveedor & "' "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            If (Midatareader(0).ToString.Equals("")) Then
                totalgastadoaño = 0
            Else
                totalgastadoaño = CSng(Midatareader(0).ToString)
            End If
            Midatareader.Close()
            totalgastadoaño = totalgastadoaño + totalimpuesto
            orden_sql = "update Proveedores set Fecha_ultima_compra= '" & Format(fecha, "MM/dd/yyyy") &
           "' ,AcumuladoCompras='" & clase.RemplazarComa(totalgastadoaño) &
                "' where CodProd = '" & idProveedor & "';"

            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            comando.ExecuteNonQuery()
            ToolStripStatusLabel1.Text = "Albaran Creado"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        botonimprimir.Enabled = True
        botonfacturadirecta.Enabled = True
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
        texto.Select(textodatobuscar.Text.Length, 0)
    End Sub
    Private Sub actualizarComboboxProductosProveedor(ByVal tabla As String, ByVal textointroducido As String, ByVal criterio As String,
               ByVal texto As ComboBox, ByVal CodProv As String)
        texto.Items.Clear()
        Dim array As List(Of String)
        array = New List(Of String)
        orden_sql = "Select distinct " & criterio & " from " & tabla & " where idProveedores ='" & CodProv & "'"
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
        texto.Select(textodatobuscar.Text.Length, 0)
    End Sub
    Private Sub botonnuevo_Click(sender As Object, e As EventArgs) Handles botonnuevo.Click
        limpiar(Me)
    End Sub

    Private Sub botonfacturadirecta_Click(sender As Object, e As EventArgs) Handles botonfacturadirecta.Click
        Dim facturado As Integer
        Dim x As Integer = 0
        Dim fecha As Date
        Dim suma, porcentajedescuento, descuento, portes, baseimponible, porcentajeiva, iva, totalimpuesto As Single
        Dim nif, tipo As String
        suma = CSng(clase.RemplazarComa(textosuma.Text))
        porcentajedescuento = CSng(clase.RemplazarComa(textoporcentajedescuento.Text))
        descuento = CSng(clase.RemplazarComa(textodescuento.Text))
        portes = CSng(clase.RemplazarComa(textoportes.Text))
        baseimponible = CSng(clase.RemplazarComa(textobaseimponible.Text))
        porcentajeiva = CSng(clase.RemplazarComa(textoporcentajeiva.Text))
        iva = CSng(clase.RemplazarComa(textoiva.Text))
        totalimpuesto = CSng(clase.RemplazarComa(textototalimpuestos.Text))
        fecha = CDate(textofecha.Text)
        nalbaran = CInt(textonumeroalbaran.Text)


        orden_sql = "Select Facturado from Ventas where NVenta='" & Format(nalbaran, "0000") & "' "
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        Midatareader.Read()
        facturado = CInt(Midatareader(0).ToString)
        Midatareader.Close()
        If (facturado = 0) Then

            orden_sql = "Select ContadorFacturas from Empresa "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            ModuloEmpresa.contadorFacturas = CInt(Midatareader(0).ToString)
            Midatareader.Close()
            tipo = "Compra"
            Try
                orden_sql = "insert into Facturas(Nfactura,Fecha,DireccionDeEntrega,CodCliente,Nombre,Direccion,FormaDePago,Observaciones,SumaImporte,PorcentajeDescuento,ImporteDescuento,Portes,BaseImponible,PorcentajeIVA,ImporteIVA,TotalAlbaran,Tipo) " &
                                "VALUES('" & ModuloEmpresa.contadorFacturas + 1 &
                                "','" & Format(fecha, "MM/dd/yyyy") &
                                "','" & textodireccionentrega.Text &
                                "','" & idProveedor &
                                "','" & nombreproveedor &
                                "','" & direccionproveedor &
                                "','" & fpago &
                                "','" & textoobservaciones.Text &
                                "','" & clase.RemplazarComa(suma) &
                                "','" & clase.RemplazarComa(porcentajedescuento) &
                                "','" & clase.RemplazarComa(descuento) &
                                "','" & clase.RemplazarComa(portes) &
                                "','" & clase.RemplazarComa(baseimponible) &
                                "','" & clase.RemplazarComa(porcentajeiva) &
                                "','" & clase.RemplazarComa(iva) &
                                "','" & clase.RemplazarComa(totalimpuesto) &
                                 "','" & tipo & "');"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()
                While (x < numlinea)

                    orden_sql = "insert into LineasFactura(NFactura,Nlinea,Codprod,Descripcion,PVP,Unidad,PorcentajeDescuento,ImporteLinea) " &
                            "VALUES('" & ModuloEmpresa.contadorFacturas + 1 &
                            "','" & (x + 1) &
                            "','" & codprod2(x) &
                            "','" & descrip(x) &
                            "','" & clase.RemplazarComa(pvp2(x)) &
                            "','" & clase.RemplazarComa(unidad2(x)) &
                            "','" & clase.RemplazarComa(productodesuento(x)) &
                            "','" & clase.RemplazarComa(importelinea2(x)) & "');"
                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                    comando.ExecuteNonQuery()
                    x = x + 1
                End While

                orden_sql = "Select NIF_CIF from Proveedores where CodProd='" & idProveedor & "' "
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                Midatareader = comando.ExecuteReader
                Midatareader.Read()
                nif = (Midatareader(0).ToString)
                Midatareader.Close()

                orden_sql = "insert into LibroIva(Id,Nfactura,FechaFactura,Nombre,NIF_CIF,BaseImponible,PorIVA,ImporteIVA,TotalFactura,Tipo) " &
                               "VALUES('" & ModuloEmpresa.contadorFacturas + 1 &
                                "','" & ModuloEmpresa.contadorFacturas + 1 &
                               "','" & Format(fecha, "MM/dd/yyyy") &
                               "','" & nombreproveedor &
                               "','" & nif &
                               "','" & clase.RemplazarComa(baseimponible) &
                               "','" & clase.RemplazarComa(porcentajeiva) &
                               "','" & clase.RemplazarComa(iva) &
                               "','" & clase.RemplazarComa(totalimpuesto) &
                               "','" & "Soportado" & "');"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()

                ModuloEmpresa.contadorFacturas = ModuloEmpresa.contadorFacturas + 1
                orden_sql = "update Empresa set ContadorFacturas= '" & ModuloEmpresa.contadorFacturas &
                "' where Nombre =  '" & "CanoMatic" & "';"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()
                'se actuliza el campo facturado a 1 para indicar que se ha facturado dicho albaran
                orden_sql = "update Compras set Facturado= '" & 1 & "' where NCompra =  '" & Format(nalbaran, "0000") & "';"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()
                ToolStripStatusLabel1.Text = "El albaran fue facturado correctamente"
                botonfacturadirecta.Enabled = True
                botonimprimir.Enabled = True
                botonaceptar.Enabled = False
                botoncancelar.Enabled = False
                botonfacturadirecta.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            imprimirFactura()
        Else
            '  MsgBox("El albaran ya esta facturado")
            ToolStripStatusLabel1.Text = "El albaran ya esta facturado"
        End If
    End Sub
    Private Sub imprimirFactura()

        Dim ds As New DataSetFacturaC
        Dim informe As New ListadoFacturaCompra
        Dim vs As New Visor
        ds.EnforceConstraints = False
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from Proveedores ", Miconexion)

        adaptador.Fill(ds, "Proveedores")
        informe.SetDataSource(ds)

        Dim adaptador2 As New SqlClient.SqlDataAdapter("select *  from Facturas where Nfactura='" & ModuloEmpresa.contadorFacturas & "' ", Miconexion)

        adaptador2.Fill(ds, "Facturas")
        informe.SetDataSource(ds)

        Dim adaptador4 As New SqlClient.SqlDataAdapter("select distinct *  from LineasFactura", Miconexion)

        adaptador4.Fill(ds, "LineasFactura")
        informe.SetDataSource(ds)

        Dim adaptador5 As New SqlClient.SqlDataAdapter("select *  from Empresa ", Miconexion)

        adaptador5.Fill(ds, "Empresa")
        informe.SetDataSource(ds)

        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
    End Sub
    Private Sub textoformadepago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textoformadepago.SelectedIndexChanged
        fpago = textoformadepago.Text
    End Sub

    Private Sub textototalimpuestos_TextChanged(sender As Object, e As EventArgs) Handles textototalimpuestos.TextChanged
        botonaceptar.Enabled = True
    End Sub

    Private Sub botonimprimir_Click(sender As Object, e As EventArgs) Handles botonimprimir.Click

        Dim ds As New DataSetAlbaranConpra
        Dim informe As New ListadoAlbaranCompra
        Dim vs As New Visor
        ds.EnforceConstraints = False
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from Proveedores ", Miconexion)

        adaptador.Fill(ds, "Proveedores")
        informe.SetDataSource(ds)

        Dim adaptador2 As New SqlClient.SqlDataAdapter("select *  from Compras where NCompra='0001' ", Miconexion)

        adaptador2.Fill(ds, "Compras")
        informe.SetDataSource(ds)

        Dim adaptador4 As New SqlClient.SqlDataAdapter("select distinct *  from LineasCompra", Miconexion)

        adaptador4.Fill(ds, "LineasCompra")
        informe.SetDataSource(ds)

        Dim adaptador5 As New SqlClient.SqlDataAdapter("select *  from Empresa ", Miconexion)

        adaptador5.Fill(ds, "Empresa")
        informe.SetDataSource(ds)

        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
    End Sub

    Private Sub textodatobuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles textodatobuscar.KeyUp
        actualizarCombobox("Proveedores", textodatobuscar.Text, criterio, textodatobuscar)
    End Sub

    Private Sub textounidad_KeyUp(sender As Object, e As KeyEventArgs) Handles textounidad.KeyUp
        Dim cantidad, descuento, pvp As Single
        If (textounidad.Text = "") Then
            cantidad = 0
        Else
            cantidad = CSng(clase.RemplazarComa(textounidad.Text))
        End If

        If (textoproductodescuento.Text = "") Then
            descuento = 0
        Else
            descuento = CSng(clase.RemplazarComa(textoproductodescuento.Text))
        End If
        If (textopvp.Text = "") Then
            pvp = 0
        Else
            pvp = CSng(clase.RemplazarComa(textopvp.Text))
        End If
        textoimportelinea.Text = clase.RemplazarComa(CSng(pvp * cantidad * ((100 - descuento) / 100)))
    End Sub

    Private Sub textoproductodescuento_KeyUp(sender As Object, e As KeyEventArgs) Handles textoproductodescuento.KeyUp
        Dim cantidad, descuento, pvp As Single
        If (textounidad.Text = "") Then
            cantidad = 0
        Else
            cantidad = CSng(clase.RemplazarComa(textounidad.Text))
        End If

        If (textoproductodescuento.Text = "") Then
            descuento = 0
        Else
            descuento = CSng(clase.RemplazarComa(textoproductodescuento.Text))
        End If
        If (textopvp.Text = "") Then
            pvp = 0
        Else
            pvp = CSng(clase.RemplazarComa(textopvp.Text))
        End If
        textoimportelinea.Text = clase.RemplazarComa(CSng(pvp * cantidad * ((100 - descuento) / 100)))
    End Sub
    Private Sub textoporcentajeiva_SelectedValueChanged(sender As Object, e As EventArgs) Handles textoporcentajeiva.SelectedValueChanged
        poriva = CSng(clase.RemplazarComa(textoporcentajeiva.SelectedItem))
        Dim a As Single
        a = Math.Round((base) * (poriva / 100), 2)
        textoiva.Text = CSng(a)
        textototalimpuestos.Text = CSng(Math.Round(base + a, 2))
    End Sub

    Private Sub textoportes_KeyUp(sender As Object, e As KeyEventArgs) Handles textoportes.KeyUp
        portes = CSng(clase.RemplazarComa(textoportes.Text))
        base = Math.Round(portes + importelineas - descuento, 2)
        textobaseimponible.Text = clase.RemplazarComa(base)
    End Sub
    Private Sub limpiar(ByVal textos As Control)

        If TypeOf textos Is TextBox Or TypeOf textos Is RichTextBox Then
            textos.Text = ""
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                limpiar(contex)
            Next

        End If

    End Sub
End Class