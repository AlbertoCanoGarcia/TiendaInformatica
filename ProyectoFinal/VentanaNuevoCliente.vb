Public Class VentanaNuevoCliente
    Dim Miconexion As SqlClient.SqlConnection
    Dim comando As New SqlClient.SqlCommand
    Dim Midatareader As SqlClient.SqlDataReader
    Dim orden_sql As String
    Dim conexion As String
    Dim control As Boolean = True
    Dim fila As String()
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub VentanaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\TiendaInformatica.mdf;Integrated Security=True;Connect Timeout=30"
            Miconexion = New SqlClient.SqlConnection(conexion)
            Miconexion.Open()
            orden_sql = "Select MAX(Id) from Clientes"
            comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
            Midatareader = comando.ExecuteReader
            Midatareader.Read()
            textoid.Text = Format(CInt(Midatareader(0).ToString) + 1, "0000")
            Midatareader.Close()

        Catch ex As Exception
            MsgBox("Fallo en la conexion, intentelo de nuevo")
            Me.Close()
        End Try

    End Sub

    Private Sub botonAceptar_Click(sender As Object, e As EventArgs) Handles botonAceptar.Click


        If (comprobartextos(Me)) Then
            Dim fechaAlta As Date
            fechaAlta = Now.ToShortDateString
            fila = {textoid.Text, textonombre.Text, textotelefono.Text, textoemail.Text, textodireccion.Text, textolocalidad.Text, textoprovincia.Text, textocp.Text, textocuentabancaria.Text, fechaAlta, textodireccionentrega.Text}
            Try
                orden_sql = "insert into Clientes(Id, Nombre, NIF_CIF, Telefono, Email, Direccion, Localidad, Provincia, 
CP, CuentaBancaria,Fecha_alta , Direccion_entrega,fecha_ultima_venta,descuento,Total_gastado_ano ) " &
                            "VALUES('" & textoid.Text &
                            "','" & textonombre.Text &
                            "','" & textonif.Text &
                            "','" & textotelefono.Text &
                            "','" & textoemail.Text &
                            "','" & textodireccion.Text &
                            "','" & textolocalidad.Text &
                            "','" & textoprovincia.Text &
                            "','" & textocp.Text &
                            "','" & textocuentabancaria.Text &
                             "','" & Format(fechaAlta, "MM/dd/yyyy") &
                            "','" & textodireccionentrega.Text &
                            "','" & "01/01/1901" &
                             "','" & 0 &
                            "','" & 0 & "');"
                comando = New SqlClient.SqlCommand(orden_sql, Miconexion)
                comando.ExecuteNonQuery()
                ToolStripStatusLabel1.Text = "El cliente fue dado de alta correctomente"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            limpiar(Me)
        End If
    End Sub

    Private Sub botonCancelar_Click(sender As Object, e As EventArgs) Handles botonCancelar.Click
        Dispose()

    End Sub
    Private Sub limpiar(ByVal textos As Control)
        If TypeOf textos Is TextBox Then
            textos.Text = ""

        End If
        If (TypeOf textos Is MaskedTextBox) Then
            textos.Text = ""

        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                limpiar(contex)
            Next

        End If

    End Sub

    Private Function comprobartextos(ByVal textos As Control) As Boolean
        control = True
        If TypeOf textos Is TextBox And textos.Equals("") Then
            MsgBox("Falta algun campo por introducir")
            control = False
        End If
        If (TypeOf textos Is MaskedTextBox) And textos.Equals("") Then
            MsgBox("Falta algun campo por introducir")
            control = False
        End If

        If textos.Controls.Count > 0 Then
            For Each contex As Control In textos.Controls
                comprobartextos(contex)
            Next

        End If
        Return control
    End Function

    Public Property getfila As String()
        Get
            Return fila
        End Get
        Set(ByVal fila As String())
            Me.fila = fila
        End Set
    End Property

    Private Sub NombreLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class