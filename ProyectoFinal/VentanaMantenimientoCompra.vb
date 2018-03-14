Public Class VentanaMantenimientoCompra
    Public idAlbaran As String
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim numlinea As Integer = 0
    Dim fila As String()
    Dim nalbaran As Integer
    Dim codprod2(10) As String
    Dim productodesuento(10), pvp2(10), unidad2(10), importelinea2(10) As Single
    Dim clase As New ClaseDecimal
    Dim descrip(10) As String
    Dim p As Integer = 0
    Dim portes As Single
    Dim base As Single
    Dim poriva As Single
    Dim importelineas, descuento As Single
    Dim fpago As String
    Dim fila2 As String()
    Dim criterio As String
    Dim descuentoCliente As Single
    Dim nombrecliente, codcliente, direccioncliente
    Dim codigocliente As String
    Private Sub botonimprimir_Click(sender As Object, e As EventArgs) Handles botonimprimir.Click

    End Sub
    Private Sub botonaceptar_Click(sender As Object, e As EventArgs) Handles botonaceptar.Click
        Dim suma, porcentajedescuento, descuento, portes, baseimponible, porcentajeiva, iva, totalimpuesto As Single
        nalbaran = CInt(textonumeroalbaran.Text)
        suma = CSng(clase.RemplazarComa(textosuma.Text))
        porcentajedescuento = CSng(clase.RemplazarComa(textoporcentajedescuento.Text))
        descuento = CSng(clase.RemplazarComa(textodescuento.Text))
        portes = CSng(clase.RemplazarComa(textoportes.Text))
        baseimponible = CSng(clase.RemplazarComa(textobaseimponible.Text))
        porcentajeiva = CSng(clase.RemplazarComa(textoporcentajeiva.Text))
        iva = CSng(clase.RemplazarComa(textoiva.Text))
        totalimpuesto = CSng(clase.RemplazarComa(textototalimpuestos.Text))
        Dim fecha As Date
        fecha = CDate(textofecha.Text)
        Dim x As Integer = 0
        Try
            orden_sql = "update Compras set Fecha= '" & Format(fecha, "MM/dd/yyyy") &
                "', DireccionEntrega = '" & textodireccionentrega.Text &
                "', Observaciones= '" & textoobservaciones.Text &
                "', SumaImporte = '" & clase.RemplazarComa(suma) &
                "', PorcentajeDescuento = '" & clase.RemplazarComa(porcentajedescuento) &
                "', ImporteDescuento = '" & clase.RemplazarComa(descuento) &
                "', Portes = '" & clase.RemplazarComa(portes) &
                "', BaseImponible = '" & clase.RemplazarComa(baseimponible) &
                "', PorcentajeIVA = '" & clase.RemplazarComa(porcentajeiva) &
                "', ImporteIVA= '" & clase.RemplazarComa(iva) &
                "', TotalAlbaran= '" & clase.RemplazarComa(totalimpuesto) &
                "' where Ncompra = '" & Format(nalbaran, "0000") & "';"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            comando.ExecuteNonQuery()

            'MsgBox("Albaran modificado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub botonFacturadir_Click(sender As Object, e As EventArgs) Handles botonFacturadir.Click
        Dim facturado As Integer
        nalbaran = CInt(textonumeroalbaran.Text)
        Dim x As Integer = 0
        Dim fecha As Date
        Dim suma, porcentajedescuento, descuento, portes, baseimponible, porcentajeiva, iva, totalimpuesto As Single
        Dim nif As String
        suma = CSng(clase.RemplazarComa(textosuma.Text))
        porcentajedescuento = CSng(clase.RemplazarComa(textoporcentajedescuento.Text))
        descuento = CSng(clase.RemplazarComa(textodescuento.Text))
        portes = CSng(clase.RemplazarComa(textoportes.Text))
        baseimponible = CSng(clase.RemplazarComa(textobaseimponible.Text))
        porcentajeiva = CSng(clase.RemplazarComa(textoporcentajeiva.Text))
        iva = CSng(clase.RemplazarComa(textoiva.Text))
        totalimpuesto = CSng(clase.RemplazarComa(textototalimpuestos.Text))
        fecha = CDate(Now.ToShortDateString)



        orden_sql = "Select Facturado from Compras where NCompra='" & Format(nalbaran, "0000") & "' "
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        Midatareader.Read()
        facturado = CInt(Midatareader(0).ToString)
        Midatareader.Close()
        If (facturado = 0) Then

            orden_sql = "Select NLinea from LineasCompra "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            numlinea = CInt(Midatareader(0).ToString)
            Midatareader.Close()

            Dim con As Integer = 0
            While (con < numlinea)
                codprod2(x) = tablalineaventa.Item(1, con).Value.ToString
                descrip(x) = tablalineaventa.Item(2, con).Value.ToString
                pvp2(x) = CSng(clase.RemplazarComa(tablalineaventa.Item(3, con).Value.ToString))
                unidad2(x) = CSng(clase.RemplazarComa(tablalineaventa.Item(4, con).Value.ToString))
                productodesuento(x) = CSng(clase.RemplazarComa(tablalineaventa.Item(5, con).Value.ToString))
                importelinea2(x) = CSng(clase.RemplazarComa(tablalineaventa.Item(6, con).Value.ToString))
                con = con + 1

            End While

            orden_sql = "Select ContadorFacturas from Empresa "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            ModuloEmpresa.contadorFacturas = CInt(Midatareader(0).ToString)
            Midatareader.Close()

            Try
                orden_sql = "insert into Facturas(Nfactura,Fecha,DireccionDeEntrega,CodCliente,Nombre,Direccion,FormaDePago,Observaciones,SumaImporte,PorcentajeDescuento,ImporteDescuento,Portes,BaseImponible,PorcentajeIVA,ImporteIVA,TotalAlbaran,Tipo) " &
                                "VALUES('" & ModuloEmpresa.contadorFacturas + 1 &
                                "','" & Format(fecha, "MM/dd/yyyy") &
                                "','" & textodireccionentrega.Text &
                                "','" & codcliente &
                                "','" & nombrecliente &
                                "','" & direccioncliente &
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
                                 "','" & "Compra" & "');"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()
                x = 0
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

                orden_sql = "Select NIF_CIF from Clientes where Id='" & codcliente & "' "
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                Midatareader = comando.ExecuteReader
                Midatareader.Read()
                nif = (Midatareader(0).ToString)
                Midatareader.Close()

                orden_sql = "insert into LibroIva(Id,Nfactura,FechaFactura,Nombre,NIF_CIF,BaseImponible,PorIVA,ImporteIVA,TotalFactura,Tipo) " &
                               "VALUES('" & ModuloEmpresa.contadorFacturas + 1 &
                                "','" & ModuloEmpresa.contadorFacturas + 1 &
                               "','" & Format(fecha, "MM/dd/yyyy") &
                               "','" & nombrecliente &
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

                botonimprimir.Enabled = True
                botonaceptar.Enabled = False
                botoncancelar.Enabled = False
                botonFacturadir.Enabled = False
                imprimirFacturaC()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            '  MsgBox("El albaran ya esta facturado")
            ToolStripStatusLabel1.Text = "El albaran ya esta facturado"
        End If
    End Sub

    Private Sub VentanaMantenimientoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase.establecer()
        Dim nlineas As Integer = 0
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            orden_sql = "Select * from Compras where NCompra='" & idAlbaran & "'"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While Midatareader.Read
                textonumeroalbaran.Text = Midatareader("NCompra").ToString
                textofecha.Text = Midatareader("Fecha").ToString
                textodireccionentrega.Text = Midatareader("DireccionDeEntrega").ToString
                codigocliente = Midatareader("CodProveedor").ToString
                textoobservaciones.Text = Midatareader("Observaciones").ToString
                textosuma.Text = Format(CSng(Midatareader("SumaImporte").ToString), "0.00")
                textoporcentajedescuento.Text = Format(CSng(Midatareader("PorcentajeDescuento").ToString), "0.00")
                textodescuento.Text = Format(CSng(Midatareader("ImporteDescuento").ToString), "0.00")
                textoportes.Text = Format(CSng(Midatareader("Portes").ToString), "0.00")
                textobaseimponible.Text = Format(CSng(Midatareader("BaseImponible").ToString), "0.00")
                textoporcentajeiva.Text = Format(CSng(Midatareader("PorcentajeIVA").ToString), "0.00")
                textoiva.Text = Format(CSng(Midatareader("ImporteIVA").ToString), "0.00")
                textototalimpuestos.Text = Format(CSng(Midatareader("TotalAlbaran").ToString), "0.00")
                codcliente = Midatareader("CodProveedor").ToString
            End While
            Midatareader.Close()

            orden_sql = "Select razon_social, nif_cif,direccion,localidad,telefono, Email from proveedores where CodProd='" & codigocliente & "' "

            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            nombrecliente = Midatareader(0).ToString
            direccioncliente = Midatareader(2).ToString
            Dim datosCliente As String = "" + nombrecliente + vbLf + Midatareader(1).ToString + vbLf + direccioncliente + " " + Midatareader(3).ToString + vbLf + Midatareader(4).ToString + vbLf + Midatareader(5).ToString
            Midatareader.Close()
            textocliente.Text = datosCliente


            orden_sql = "Select COUNT(NCompra) as lineastotales from LineasCompra where NCompra ='" & textonumeroalbaran.Text & "'group by NCompra "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            nlineas = Midatareader("lineastotales").ToString
            Midatareader.Close()


            Dim i As Integer = 0
            While (i < nlineas)
                orden_sql = "Select * from LineasCompra where NCompra ='" & textonumeroalbaran.Text & "'and NLinea='" & Format(i + 1, "0000") & "' "
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                Midatareader = comando.ExecuteReader
                Midatareader.Read()
                fila = {Midatareader("NLinea").ToString, Midatareader("CodProd").ToString, Midatareader("Descripcion").ToString,
                Format(CSng(Midatareader("PVP").ToString), "0.00"), Format(CSng(Midatareader("Unidad").ToString), "0.00"), Format(CSng(Midatareader("PorcentajeDescuento").ToString), "0.00"), Format(CSng(Midatareader("ImporteLinea").ToString), "0.00")}
                tablalineaventa.Rows.Add(fila)

                Midatareader.Close()
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox(ex)
            Me.Close()
        End Try
    End Sub
    Private Sub habilitar(ByVal textos As Control)
        textos.Enabled = True
        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                habilitar(contex)
            Next
        End If

    End Sub

    Private Sub imprimirFacturaC()

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
    Private Sub botonmodificar_Click(sender As Object, e As EventArgs) Handles botonmodificar.Click
        habilitar(Me)
    End Sub
End Class