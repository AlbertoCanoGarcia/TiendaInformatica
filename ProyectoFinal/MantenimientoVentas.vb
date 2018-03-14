Public Class MantenimientoVentas
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim validar As New ClaseDecimal
    Dim arrayidcliente As New List(Of String)
    Dim arrayNIFcliente As New List(Of String)
    Dim sentenciaFactura As String
    Dim factura As String = "no"
    Private Sub MantenimientoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fila As String()
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()

            orden_sql = "Select id, nif_cif from Clientes "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While Midatareader.Read
                arrayidcliente.Add(Midatareader(0).ToString)
                arrayNIFcliente.Add(Midatareader(1).ToString)
            End While
            Midatareader.Close()

            Dim a As Integer = 0
            While (a < arrayidcliente.Count)
                orden_sql = "Select NVenta,nombre,direccion, fecha, TotalAlbaran from Ventas where Codcliente='" & arrayidcliente.ElementAt(a) & "'order by fecha asc"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While Midatareader.Read
                    fila = {Midatareader(0).ToString, arrayNIFcliente.ElementAt(a), Midatareader(1).ToString, Midatareader(2).ToString, Midatareader(3).ToString.Substring(0, 10), Format(CSng(Midatareader(4).ToString), "0.00")}
                    tablaventas.Rows.Add(fila)
            End While
                Midatareader.Close()
                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex)
            Me.Close()
        End Try
    End Sub



    Private Sub tablaventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaventas.CellContentClick
        Dim nalbaran As String
        nalbaran = tablaventas.Rows.Item(e.RowIndex).Cells.Item(0).Value
        Dim form As New VentanaMantenimientoVenta
        form.idAlbaran = nalbaran
        form.factura = factura
        form.Show()
    End Sub
    Dim criterios As String = ""
    Private Sub textobuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textobuscar.SelectedIndexChanged
        criterios = textobuscar.Text
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
        actualizarCombobox("Clientes", textodatobuscar.Text, criterios, textodatobuscar)
        botonbuscar.Enabled = True
    End Sub

    Private Sub botonbuscar_Click(sender As Object, e As EventArgs) Handles botonbuscar.Click
        factura = ""
        Dim fila As String()
        tablaventas.Rows.Clear()
        arrayidcliente.Clear()
        arrayNIFcliente.Clear()
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()

            orden_sql = "Select id, nif_cif from Clientes where " & criterios & "='" & textodatobuscar.Text & "' "
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            While Midatareader.Read
                arrayidcliente.Add(Midatareader(0).ToString)
                arrayNIFcliente.Add(Midatareader(1).ToString)
            End While
            Midatareader.Close()
            If (opcionFacturado.Checked And Not opcionNoFacturado.Checked) Then
                sentenciaFactura = "and facturado ='" & 1 & "'"
            ElseIf (opcionNoFacturado.Checked And Not opcionFacturado.Checked) Then
                sentenciaFactura = "and facturado ='" & 0 & "'"
            Else
                sentenciaFactura = ""
            End If

            Dim a As Integer = 0
            While (a < arrayidcliente.Count)
                orden_sql = "Select NVenta,nombre,direccion, fecha, TotalAlbaran from Ventas where Codcliente=" & arrayidcliente.ElementAt(a) & " " & sentenciaFactura & " order by fecha asc"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                Midatareader = comando.ExecuteReader
                While Midatareader.Read
                    fila = {Midatareader(0).ToString, arrayNIFcliente.ElementAt(a), Midatareader(1).ToString, Midatareader(2).ToString, Midatareader(3).ToString.Substring(0, 10), Midatareader(4).ToString}
                    tablaventas.Rows.Add(fila)
                End While
                Midatareader.Close()
                a = a + 1

            End While
            factura = "no"
        Catch ex As Exception
            MsgBox(ex)
            Me.Close()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fila As String()
        tablaventas.Rows.Clear()
        arrayidcliente.Clear()
        arrayNIFcliente.Clear()
        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            Dim idfactura As String = txtfact.Text
            Dim a As Integer = 0


            orden_sql = "Select Nfactura,nombre,direccion, fecha, TotalAlbaran from Facturas where Nfactura=" & idfactura & ""
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            fila = {Midatareader(0).ToString, "", Midatareader(1).ToString, Midatareader(2).ToString, Midatareader(3).ToString.Substring(0, 10), Midatareader(4).ToString, "Si"}
            tablaventas.Rows.Add(fila)

            Midatareader.Close()
            factura = "si"
        Catch ex As Exception
            MsgBox(ex)
            Me.Close()
        End Try
    End Sub
End Class