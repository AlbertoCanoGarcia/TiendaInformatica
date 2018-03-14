Public Class ClaseDecimal
    Public Sub establecer()
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."

        r.NumberFormat.NumberDecimalSeparator = "."

        System.Threading.Thread.CurrentThread.CurrentCulture = r
    End Sub

    Public Function RemplazarComa(ByVal numero As String) As String
        Dim resultado As String
        numero = numero.Replace(",", ".")
        resultado = Format(CSng(numero), "#,##0.00")
        Return resultado

    End Function
End Class
