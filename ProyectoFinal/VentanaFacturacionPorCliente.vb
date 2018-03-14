Public Class VentanaFacturacionPorCliente
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim idclientes As List(Of String)
    Dim listaNalbaranes As List(Of String)


    Dim miclase As New ClaseDecimal
    Dim fechas As New List(Of Date)

    Dim lineaAlbaran As New List(Of String)
    Dim direccionentrega As New List(Of String)
    Dim codcliente As New List(Of String)
    Dim nombres As New List(Of String)
    Dim direccion As New List(Of String)
    Dim formadepago As New List(Of String)
    Dim observaciones As New List(Of String)
    Dim sumaimporte As New List(Of Single)
    Dim porcentajedescuento As New List(Of Single)
    Dim importedescuento As New List(Of Single)
    Dim portes As New List(Of Single)
    Dim baseimponible As New List(Of Single)
    Dim porcentajeiva As New List(Of Single)
    Dim importeiva As New List(Of Single)
    Dim totalalbaran As New List(Of Single)

    Dim nalbaran As New List(Of String)
    Dim nlinea As New List(Of String)
    Dim codprod As New List(Of Integer)
    Dim descripcion As New List(Of String)
    Dim pvp As New List(Of Single)
    Dim unidad As New List(Of Single)
    Dim porcentajedescuentolinea As New List(Of Single)
    Dim importelinea As New List(Of Single)

    Dim listatipoiva As New List(Of Single)
    Dim listaformasdepago As New List(Of String)
    Dim descuento As Single
    Dim clase As New ClaseDecimal
    Dim criterio As String
    Dim descuentoClient, a As Single
    Dim nombrecliente, codcliente2, direccioncliente As String

    Private Sub VentanaFacturacionPorCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clase.establecer()

        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
        Miconexion = New SqlClient.SqlConnection(conexion)
        Miconexion.Open()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        textobuscar.Enabled = False
        textodatobuscar.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim z As Integer = 0
        Dim a As Integer = 0
        idclientes = New List(Of String)
        listaNalbaranes = New List(Of String)
        Dim imprimir As Boolean = True
        Dim fecha As Date = CDate(Now.ToShortDateString)

        orden_sql = "Select porcentaje  from tipodeiva"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            listatipoiva.Add(Midatareader(0).ToString)
        End While
        Midatareader.Close()

        orden_sql = "Select tipo  from formasdepago"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            listaformasdepago.Add(Midatareader(0).ToString)
        End While
        Midatareader.Close()

        If (RadioButton2.Enabled) Then
            orden_sql = "Select distinct id,facturado  from Clientes,Ventas where ventas.codcliente=clientes.id    and id ='" & codcliente2 & "' and facturado= '" & 0 & "'"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While (Midatareader.Read())
                idclientes.Add(Midatareader(0).ToString)
            End While
            Midatareader.Close()
        Else
            orden_sql = "Select distinct id,facturado  from Clientes,Ventas where ventas.codcliente=clientes.id and facturado= '" & 0 & "'"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While (Midatareader.Read())
                idclientes.Add(Midatareader(0).ToString)
            End While
            Midatareader.Close()
        End If

        While (x < idclientes.Count)
            orden_sql = "Select NVenta from Ventas where CodCliente ='" & idclientes.ElementAt(x) & "' and Facturado = '" & 0 & "'"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While (Midatareader.Read())
                listaNalbaranes.Add(Midatareader(0).ToString)
            End While
            Midatareader.Close()
            x = x + 1
        End While
        If (listaNalbaranes.Count = 0) Then
            ToolStripStatusLabel1.Text = "No hay ningun albaran sin facturar"
        Else
            x = 0

            While (x < listaNalbaranes.Count)
                Dim t As Integer = 0
                orden_sql = "Select * from Ventas where NVenta ='" & listaNalbaranes.ElementAt(x) & "'"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                Midatareader = comando.ExecuteReader()
                While (Midatareader.Read)
                    fechas.Add(CDate(Midatareader("Fecha").ToString))
                    lineaAlbaran.Add(a)
                    direccionentrega.Add(Midatareader("DireccionDeEntrega").ToString)
                    codcliente.Add(Midatareader("CodCliente").ToString)
                    nombres.Add(Midatareader("Nombre").ToString)
                    direccion.Add(Midatareader("Direccion").ToString)
                    formadepago.Add(Midatareader("FormaDePago").ToString)
                    observaciones.Add(Midatareader("DireccionDeEntrega").ToString)
                    sumaimporte.Add(CSng(Midatareader("sumaimporte").ToString))
                    porcentajedescuento.Add(CSng(Midatareader("Porcentajedescuento").ToString))
                    importedescuento.Add(CSng(Midatareader("ImporteDescuento").ToString))
                    portes.Add(CSng(Midatareader("portes").ToString))
                    baseimponible.Add(CSng(Midatareader("baseimponible").ToString))
                    porcentajeiva.Add(CSng(Midatareader("porcentajeiva").ToString))
                    importeiva.Add(CSng(Midatareader("importeiva").ToString))
                    totalalbaran.Add(CSng(Midatareader("totalalbaran").ToString))
                End While
                Midatareader.Close()
                x = x + 1
            End While

            Dim nuevaFactura As Boolean = True
            Dim sumabaseimponible = 0.00, sumaimporteiva = 0.00, sumatotalalbaran As Single = 0.00
            x = 0
            Dim h As Integer = 0
            While (h < idclientes.Count)
                y = 0
                z = 0
                x = 0
                imprimir = True
                While (y < listaformasdepago.Count)
                    x = 0
                    z = 0
                    While (z < listatipoiva.Count)
                        x = 0
                        nuevaFactura = True
                        Dim linea As Integer = 0

                        While (x < listaNalbaranes.Count)
                            If (listaformasdepago.ElementAt(y).Equals(formadepago.ElementAt(x)) And
                        listatipoiva.ElementAt(z).Equals(porcentajeiva.ElementAt(x)) And idclientes.ElementAt(h).Equals(codcliente.ElementAt(x))) Then

                                linea = linea + 1
                                If (nuevaFactura = True) Then
                                    sumabaseimponible = 0
                                    sumaimporteiva = 0
                                    sumatotalalbaran = 0
                                    orden_sql = "insert into Facturas(Nfactura,Fecha,DireccionDeEntrega,CodCliente,Nombre,Direccion,FormaDePago,Observaciones) " &
                                                            "VALUES('" & Format(contadorFacturas + 1, "0000") &
                                                            "','" & Format(fecha, "MM/dd/yyyy") &
                                                            "','" & direccionentrega.ElementAt(x) &
                                                            "','" & codcliente.ElementAt(x) &
                                                            "','" & nombres.ElementAt(x) &
                                                            "','" & direccion.ElementAt(x) &
                                                            "','" & formadepago.ElementAt(x) &
                                                            "','" & observaciones.ElementAt(x) & "');"
                                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                    comando.ExecuteNonQuery()
                                    nuevaFactura = False

                                    Dim cif, nombre As String

                                    orden_sql = "Select NIF_CIF,nombre  from Clientes where id ='" & codcliente.ElementAt(x) & "'"
                                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                    Midatareader = comando.ExecuteReader
                                    Midatareader.Read()
                                    cif = Midatareader(0).ToString
                                    nombre = Midatareader(1).ToString
                                    Midatareader.Close()
                                    orden_sql = "insert into LibroIva(Id,Nfactura,FechaFactura,Nombre,NIF_CIF,PorIVA,Tipo) " &
                                                   "VALUES('" & Format(contadorFacturas + 1, "0000") &
                                                    "','" & Format(contadorFacturas + 1, "0000") &
                                                   "','" & Format(fecha, "MM/dd/yyyy") &
                                                   "','" & nombre &
                                                   "','" & cif &
                                                   "','" & listatipoiva.ElementAt(z) &
                                                   "','" & "Repercutido" & "');"
                                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                    comando.ExecuteNonQuery()

                                    ModuloEmpresa.contadorFacturas = ModuloEmpresa.contadorFacturas + 1
                                    orden_sql = "update Empresa set ContadorFacturas= '" & ModuloEmpresa.contadorFacturas &
                            "' where Nombre =  '" & "CanoMatic" & "';"
                                    comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                    comando.ExecuteNonQuery()

                                End If

                                orden_sql = "insert into LineasFactura(NFactura,Nlinea,Descripcion,PVP,PorcentajeDescuento,ImporteLinea) " &
                                    "VALUES('" & Format(contadorFacturas, "0000") &
                                        "','" & Format(linea, "0000") &
                                        "','" & "Albaran n " & Format(CInt(listaNalbaranes.ElementAt(x)), "0000") & " con fecha " & Format(fechas.ElementAt(x), "dd/MM/yyyy") & "" &
                                        "','" & baseimponible.ElementAt(x) &
                                        "','" & importeiva.ElementAt(x) &
                                        "','" & totalalbaran.ElementAt(x) & "');"
                                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                comando.ExecuteNonQuery()
                                sumabaseimponible = sumabaseimponible + baseimponible.ElementAt(x)
                                sumaimporteiva = sumaimporteiva + importeiva.ElementAt(x)
                                sumatotalalbaran = sumatotalalbaran + totalalbaran.ElementAt(x)


                                orden_sql = "update Facturas set BaseImponible = '" & miclase.RemplazarComa(sumabaseimponible) &
                           "', PorcentajeIVA = '" & listatipoiva.ElementAt(z) &
                           "', ImporteIVA= '" & miclase.RemplazarComa(sumaimporteiva) &
                           "', TotalAlbaran= '" & miclase.RemplazarComa(sumatotalalbaran) &
                           "' where Nfactura = '" & Format(contadorFacturas, "0000") & "';"
                                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                comando.ExecuteNonQuery()
                                ''

                                orden_sql = "update LibroIva set BaseImponible = '" & miclase.RemplazarComa(sumabaseimponible) &
                           "', PorIVA = '" & listatipoiva.ElementAt(z) &
                           "', ImporteIVA= '" & miclase.RemplazarComa(sumaimporteiva) &
                           "', TotalFactura= '" & miclase.RemplazarComa(sumatotalalbaran) &
                           "' where id = '" & Format(contadorFacturas, "0000") & "';"
                                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                comando.ExecuteNonQuery()

                                orden_sql = "update Ventas set Facturado= '" & 1 &
                                "' where NVenta =  '" & listaNalbaranes.ElementAt(x) & "';"
                                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                                comando.ExecuteNonQuery()

                            End If

                            x = x + 1

                        End While
                        If (imprimir = True) Then
                            Dim ds As New DataSetFacturaC
                            Dim informe As New ListadoFacturaVentaAgrupada
                            Dim vs As New Visor
                            ds.EnforceConstraints = False



                            Dim adaptador1 As New SqlClient.SqlDataAdapter("select *  from Clientes where id= '" & idclientes.ElementAt(h) & "';", Miconexion)
                            ds.EnforceConstraints = False
                            adaptador1.Fill(ds, "Clientes")
                            informe.SetDataSource(ds)

                            Dim adaptador3 As New SqlClient.SqlDataAdapter("select *  from Empresa", Miconexion)
                            adaptador3.Fill(ds, "Empresa")
                            informe.SetDataSource(ds)

                            Dim adaptador4 As New SqlClient.SqlDataAdapter("select  *  from LineasFactura where NFactura = '" & Format(contadorFacturas, "0000") & "';", Miconexion)
                            adaptador4.Fill(ds, "LineasFactura")
                            informe.SetDataSource(ds)

                            Dim adaptador5 As New SqlClient.SqlDataAdapter("select  *  from Facturas where NFactura='" & Format(contadorFacturas, "0000") & "';", Miconexion)
                            adaptador5.Fill(ds, "Facturas")
                            informe.SetDataSource(ds)

                            vs.CrystalReportViewer1.ReportSource = informe
                            vs.ShowDialog()
                            imprimir = False
                        End If

                        z = z + 1
                    End While
                    y = y + 1

                End While

                h = h + 1
            End While

            ToolStripStatusLabel1.Text = "Facturacion realizada"

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        textobuscar.Enabled = True
        textodatobuscar.Enabled = True
    End Sub

    Private Sub textodatobuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textodatobuscar.SelectedIndexChanged
        Dim busqueda = textodatobuscar.SelectedItem
        If (criterio.Equals("Nombre")) Then
            orden_sql = "Select nombre, nif_cif,direccion,localidad,telefono, Email,Descuento,id from clientes where nombre='" + busqueda + "'"
        Else
            orden_sql = "Select nombre, nif_cif,direccion,localidad,telefono, Email,Descuento,id from clientes where nif_cif='" + busqueda + "'"
        End If

        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        Midatareader.Read()
        nombrecliente = Midatareader(0).ToString
        direccioncliente = Midatareader(2).ToString
        Dim datosCliente As String = "" + nombrecliente + vbLf + Midatareader(1).ToString + vbLf + direccioncliente + " " + Midatareader(3).ToString + vbLf + Midatareader(4).ToString + vbLf + Midatareader(5).ToString
        descuento = CSng(Midatareader(6).ToString)
        codcliente2 = Midatareader(7).ToString
        Midatareader.Close()


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
    Private Sub textodatobuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles textodatobuscar.KeyUp
        actualizarCombobox("Clientes", textodatobuscar.Text, criterio, textodatobuscar)
    End Sub
    Private Sub textobuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textobuscar.SelectedIndexChanged
        criterio = textobuscar.Text
    End Sub
End Class