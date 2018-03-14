
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class VentanaPrincipal
    Dim Conexion As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"

    Dim MiConexion As New SqlConnection(Conexion)
    Dim adapter As SqlDataAdapter
    Dim dataset As New DataSet
    Dim builder As SqlCommandBuilder
    Dim gestorEnlace As BindingManagerBase
    Dim consulta As String
    Dim accion As String
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Private Sub ReparacionesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProceedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProceedoresToolStripMenuItem.Click

    End Sub

    Private Sub VentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MiConexion = New SqlClient.SqlConnection(Conexion)
            MiConexion.Open()
            orden_sql = "Select * from Empresa"
            comando = New SqlClient.SqlCommand(orden_sql, MiConexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            ModuloEmpresa.nombre = Midatareader("Nombre").ToString
            ModuloEmpresa.razonsocial = Midatareader("Razonsocial").ToString
            ModuloEmpresa.direccion = Midatareader("Direccion").ToString
            ModuloEmpresa.poblacion = Midatareader("Poblacion").ToString
            ModuloEmpresa.provincia = Midatareader("Provincia").ToString
            ModuloEmpresa.codigopostal = Midatareader("CodigoPostal").ToString
            ModuloEmpresa.fax = Midatareader("Fax").ToString
            ModuloEmpresa.telefono = Midatareader("Telefono").ToString
            ModuloEmpresa.cif = Midatareader("CIF").ToString
            ModuloEmpresa.email = Midatareader("Email").ToString
            ModuloEmpresa.direccionentrega = Midatareader("DireccionEntrega").ToString
            ModuloEmpresa.web = Midatareader("Web").ToString
            ModuloEmpresa.representante = Midatareader("Representante").ToString
            ModuloEmpresa.contadorAlbaran = Midatareader("ContadorAlbaran").ToString
            ModuloEmpresa.contadorCompras = Midatareader("ContadorCompras").ToString
            ModuloEmpresa.contadorFacturas = Midatareader("ContadorFacturas").ToString
            Midatareader.Close()
        Catch ex As Exception
            MsgBox("Fallo en la conexion, intentelo de nuevo")
            Me.Close()
        End Try

        MiConexion.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim form As New VentanaNuevoCliente
        'form.TopLevel = False
        'form.FormBorderStyle = FormBorderStyle.None
        'panel.Controls.Add(form)
        'panel.Tag = form
        form.Show()

    End Sub

    Private Sub MaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaToolStripMenuItem.Click
        Dim form As New VentanaProductos
        form.Show()

    End Sub

    Private Sub MantenimientoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoClienteToolStripMenuItem.Click
        Dim form As New MantenimientoCliente
        form.Show()

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim form As New VentanaAlbaran
        form.Show()

    End Sub

    Private Sub MantenimientoVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoVentaToolStripMenuItem.Click
        Dim form As New MantenimientoVentas
        form.Show()

    End Sub



    Private Sub MantenimientoProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoProveedoresToolStripMenuItem.Click
        Dim form As New VentanarProveedores
        form.Show()

    End Sub

    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordToolStripMenuItem.Click
        Dim objProcess As New Process
        objProcess.Start("WINWORD.EXE", AppWinStyle.MaximizedFocus)
    End Sub
    Dim i As Integer = 0


    Private Sub RealizarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarCompraToolStripMenuItem.Click
        Dim form As New VentanaCompra
        form.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        MiConexion.Open()
        Dim ds As New ListadoClientesDataSet
        Dim informe As New ListadoClientes
        Dim vs As New Visor
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from Clientes order by Nombre", MiConexion)
        ds.EnforceConstraints = False
        adaptador.Fill(ds, "Clientes")
        informe.SetDataSource(ds)

        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
        MiConexion.Close()


    End Sub

    Private Sub ListadoProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoProductosToolStripMenuItem.Click
        MiConexion.Open()
        Dim ds As New ArtListDS
        Dim informe As New ListadoArticulos
        Dim vs As New Visor
        ds.EnforceConstraints = False
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from Articulos where stockminimo>=stockactual ", MiConexion)

        adaptador.Fill(ds, "Articulos")
        informe.SetDataSource(ds)

        Dim adaptador2 As New SqlClient.SqlDataAdapter("select *  from Marca ", MiConexion)

        adaptador2.Fill(ds, "Marca")
        informe.SetDataSource(ds)
        Dim adaptador3 As New SqlClient.SqlDataAdapter("select *  from Proveedores ", MiConexion)

        adaptador3.Fill(ds, "Proveedores")
        informe.SetDataSource(ds)
        Dim adaptador4 As New SqlClient.SqlDataAdapter("select *  from TiposArticulo ", MiConexion)

        adaptador4.Fill(ds, "TiposArticulo")
        informe.SetDataSource(ds)
        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
        MiConexion.Close()
    End Sub

    Private Sub ListadoProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListadoProductosToolStripMenuItem1.Click
        MiConexion.Open()
        Dim ds As New ArtListDS
        Dim informe As New ListadoArticulos
        Dim vs As New Visor
        ds.EnforceConstraints = False
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from Articulos where stockminimo<stockactual ", MiConexion)

        adaptador.Fill(ds, "Articulos")
        informe.SetDataSource(ds)

        Dim adaptador2 As New SqlClient.SqlDataAdapter("select *  from Marca ", MiConexion)

        adaptador2.Fill(ds, "Marca")
        informe.SetDataSource(ds)
        Dim adaptador3 As New SqlClient.SqlDataAdapter("select *  from Proveedores ", MiConexion)

        adaptador3.Fill(ds, "Proveedores")
        informe.SetDataSource(ds)
        Dim adaptador4 As New SqlClient.SqlDataAdapter("select *  from TiposArticulo ", MiConexion)

        adaptador4.Fill(ds, "TiposArticulo")
        informe.SetDataSource(ds)
        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
        MiConexion.Close()
    End Sub

    Private Sub LibroIVAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LibroIVAToolStripMenuItem1.Click
        Dim form As New LibroIva
        form.Show()

    End Sub

    Private Sub MantenimientoCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoCompraToolStripMenuItem.Click
        Dim form As New MantenimientoCompra
        form.Show()

    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim objProcess As New Process
        objProcess.Start("calc.exe", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductosMasVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosMasVendidosToolStripMenuItem.Click
        MiConexion.Open()
        Dim ds As New ProductosEstadisticasDataSet
        Dim informe As New ListadoArticulosEstadisticas
        Dim vs As New Visor
        ds.EnforceConstraints = False
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from Articulos ", MiConexion)

        adaptador.Fill(ds, "Articulos")
        informe.SetDataSource(ds)

        Dim adaptador2 As New SqlClient.SqlDataAdapter("select *  from Marca ", MiConexion)

        adaptador2.Fill(ds, "Marca")
        informe.SetDataSource(ds)
        Dim adaptador3 As New SqlClient.SqlDataAdapter("select *  from LineasVenta ", MiConexion)

        adaptador3.Fill(ds, "LineasVenta")
        informe.SetDataSource(ds)
        Dim adaptador4 As New SqlClient.SqlDataAdapter("select *  from TiposArticulo ", MiConexion)

        adaptador4.Fill(ds, "TiposArticulo")
        informe.SetDataSource(ds)
        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
        MiConexion.Close()
    End Sub

    Private Sub TiposDeArticulosMasVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeArticulosMasVendidosToolStripMenuItem.Click
        MiConexion.Open()
        Dim ds As New ProductosEstadisticasDataSet
        Dim informe As New ListadoEstadisticaTipoProductos
        Dim vs As New Visor
        ds.EnforceConstraints = False
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from Articulos ", MiConexion)

        adaptador.Fill(ds, "Articulos")
        informe.SetDataSource(ds)

        Dim adaptador2 As New SqlClient.SqlDataAdapter("select *  from Marca ", MiConexion)

        adaptador2.Fill(ds, "Marca")
        informe.SetDataSource(ds)
        Dim adaptador3 As New SqlClient.SqlDataAdapter("select *  from LineasVenta ", MiConexion)

        adaptador3.Fill(ds, "LineasVenta")
        informe.SetDataSource(ds)
        Dim adaptador4 As New SqlClient.SqlDataAdapter("select *  from TiposArticulo ", MiConexion)

        adaptador4.Fill(ds, "TiposArticulo")
        informe.SetDataSource(ds)
        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
        MiConexion.Close()
    End Sub

    Private Sub CopiaDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaDToolStripMenuItem.Click

    End Sub

    Private Sub BackupToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem1.Click
        Dim orden, sql As String
        Dim fecha As String = Date.Today
        Dim directorio As String = "|DataDirectory|\TiendaInformatica.mdf"
        fecha = fecha.Replace(" / ", " -")
        SaveFileDialog1.InitialDirectory = "C:\"
        SaveFileDialog1.FileName = "BD_BACKUP_" & fecha & ".bak"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If SaveFileDialog1.CreatePrompt = False Then
                Dim ruta As String = SaveFileDialog1.FileName.ToString
                Try

                    Conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" & directorio & "';Integrated Security=True;Connect Timeout=30"
                    MiConexion = New SqlClient.SqlConnection(Conexion)
                    MiConexion.Open()
                    orden = "BACKUP DATABASE [Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" & directorio & "';Integrated Security=True;Connect Timeout=30] TO DISK = '" & ruta & "'"

                    comando = New SqlClient.SqlCommand(orden, MiConexion)
                    comando.ExecuteNonQuery()

                Catch ex As Exception

                End Try
            Else
                Try
                    Dim ruta As String = SaveFileDialog1.FileName.ToString
                    My.Computer.FileSystem.DeleteFile(ruta)
                    'My.Computer.FileSystem.DeleteFile(ruta, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)-->Preguntar y enviar a papelera de reciclaje
                    Conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" & directorio & "';Integrated Security=True;"
                    MiConexion = New SqlClient.SqlConnection(Conexion)
                    MiConexion.Open()
                    orden = "BACKUP DATABASE [Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" & directorio & "';Integrated Security=True;Connect Timeout=30] TO DISK = '" & ruta & "'"

                    comando = New SqlClient.SqlCommand(orden, MiConexion)
                    comando.ExecuteNonQuery()

                Catch ex As Exception

                End Try
            End If

        End If
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        Dim form As New VentanaEmail
        form.Show()

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim form As New VentanaAcercaDe
        form.Show()

    End Sub

    Private Sub FacturacionPorCliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionPorCliToolStripMenuItem.Click
        Dim form As New VentanaFacturacionPorCliente
        form.Show()

    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        Dim form As New VentanaNuevoCliente
        form.Show()

    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        Dim form As New VentanaAlbaran
        form.Show()

    End Sub

    Private Sub TiposDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeArticulosToolStripMenuItem.Click
        Dim form As New VentanaTipoArticulos
        form.Show()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim form As New VentanaCompra
        form.Show()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        Dim form As New VentanaEmpresa
        form.Show()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim form As New VentanaEmpresa
        form.Show()
    End Sub

    Private Sub ListadoFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoFacturasToolStripMenuItem.Click

        Dim ds As New DataSetFacturaV
        Dim informe As New ListadoTodasFacturasVenta
        Dim vs As New Visor
        ds.EnforceConstraints = False
        Dim adaptador As New SqlClient.SqlDataAdapter("select *  from clientes ", MiConexion)

        adaptador.Fill(ds, "Clientes")
        informe.SetDataSource(ds)

        Dim adaptador2 As New SqlClient.SqlDataAdapter("select *  from Facturas where Tipo='Venta' order by Fecha ", MiConexion)

        adaptador2.Fill(ds, "Facturas")
        informe.SetDataSource(ds)

        Dim adaptador5 As New SqlClient.SqlDataAdapter("select *  from Empresa ", MiConexion)

        adaptador5.Fill(ds, "Empresa")
        informe.SetDataSource(ds)

        vs.CrystalReportViewer1.ReportSource = informe
        vs.ShowDialog()
    End Sub
End Class
