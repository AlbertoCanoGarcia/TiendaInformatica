Public Class VentanaAcercaDe
    Dim i As Integer = 0
    Private Sub VentanaAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animacion.BackgroundImage = Image.FromFile("C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\Iconos\anim.png")
        animacion.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub
    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    If (i Mod 2.0! = 0) Then
    '        animacion.BackgroundImage = Image.FromFile("C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\Iconos\anim.png")
    '        animacion.SizeMode = PictureBoxSizeMode.AutoSize
    '        animacion.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone / 2)
    '    End If
    '    i = i + 1
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (i Mod 2 = 0) Then

            animacion.BackgroundImage = Image.FromFile("C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\Iconos\anim.png")
            animacion.SizeMode = PictureBoxSizeMode.AutoSize
            animacion.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX)

        Else
            animacion.BackgroundImage = Image.FromFile("C:\Dam2_1718Proy\Alberto\ProyectoFinal\ProyectoFinal\Iconos\anim.png")
            animacion.SizeMode = PictureBoxSizeMode.AutoSize

        End If
        i = i + 1
    End Sub
End Class