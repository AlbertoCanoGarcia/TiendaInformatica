Public Class LibroIva
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim contador As Integer
    Dim ultimo As Integer
    Dim opc As Integer
    Dim nfactura As Integer
    Dim fecha As Date
    Dim nombr, nif As String
    Dim fila As String()
    Dim base, por, ImpIva, totalfact As Single

    Private Sub tablarepercutido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablarepercutido.CellContentClick

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub LibroIva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clase As New ClaseDecimal
        clase.establecer()
        Dim x As Integer = 0
        Dim a = 0.00, b = 0.00, c = 0.00, d As Decimal = 0.00
        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
        Miconexion = New SqlClient.SqlConnection(conexion)
        Miconexion.Open()
        orden_sql = "Select * from LibroIva where Tipo='Repercutido'"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            fila = {Midatareader("NFactura").ToString, Midatareader("FechaFactura").ToString.Substring(0, 10), Midatareader("Nombre").ToString, Midatareader("NIF_CIF").ToString,
                Format(CDec(Midatareader("BaseImponible").ToString), "#,##0.00"), Format(CDec(Midatareader("porIVA").ToString), "0.00"), Format(CDec(Midatareader("ImporteIVA").ToString), "#,##0.00"), Format(CDec(Midatareader("TotalFactura").ToString), "#,##0.00")}
            tablarepercutido.Rows.Add(fila)
            a = CDec(Midatareader("BaseImponible").ToString) + a
            b = CDec(Midatareader("ImporteIVA").ToString) + b
        End While
        Midatareader.Close()

        totalbase.Text = Format(a, "#,##0.00")
        totaliva.Text = Format(b, "#,##0.00")
        totalrepercutido.Text = Format(a + b, "#,##0.00")

        orden_sql = "Select * from LibroIva where Tipo='Soportado'"
        comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
        Midatareader = comando.ExecuteReader
        While (Midatareader.Read())
            fila = {Midatareader("NFactura").ToString, Midatareader("FechaFactura").ToString.Substring(0, 10), Midatareader("Nombre").ToString, Midatareader("NIF_CIF").ToString,
               Format(CDec(Midatareader("BaseImponible").ToString), "#,##0.00"), Format(CDec(Midatareader("porIVA").ToString), "0.00"), Format(CDec(Midatareader("ImporteIVA").ToString), "#,##0.00"), Format(CDec(Midatareader("TotalFactura").ToString), "#,##0.00")}
            tablasoportado.Rows.Add(fila)
            c = CDec(Midatareader("BaseImponible").ToString) + c
            d = CDec(Midatareader("ImporteIVA").ToString) + d
        End While
        Midatareader.Close()
        x = 0

        totalbase2.Text = Format(c, "#,##0.00")
        totaliva2.Text = Format(d, "#,##0.00")
        totalsoportado.Text = Format(c + d, "#,##0.00")

        total.Text = Format((a + b) - (c + d), "#,##0.00")
    End Sub
End Class