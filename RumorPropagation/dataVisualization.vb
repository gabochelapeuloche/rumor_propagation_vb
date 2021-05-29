Module dataVisualization
'codé par Gaboche de WTO

    Sub setGraphicHisto(ByVal nbColonne As Integer, ByRef g As Graphics, ByRef b As Bitmap, ByRef pb As PictureBox, ByVal valeur As Array)
        'pour fluidifier l'écriture du code on déclare les variables hauteur et largeur
        Dim hauteur As Integer = pb.Size.Height
        Dim largeur As Integer = pb.Size.Width
        'place les axes
        For i = 0 To hauteur - 1
            b.SetPixel(1, i, Color.Black)
        Next
        For i = 0 To hauteur - 1 Step 5
            For j = 1 To 3
                b.SetPixel(j, i, Color.Black)
            Next
        Next
        For i = 0 To largeur - 1
            b.SetPixel(i, hauteur - 1, Color.Black)
        Next
        'dessine les rectangles
        g.FillRectangle(Brushes.Tomato,
                        40,
                        hauteur - CInt(Math.Round(valeur(0) * 2)) - 1,
                        40,
                        CInt(Math.Round(valeur(0) * 2)))
        g.FillRectangle(Brushes.DarkSalmon,
                        100,
                        hauteur - CInt(Math.Round(valeur(1) * 2)) - 1,
                        40,
                        CInt(Math.Round(valeur(1) * 2)))
        g.FillRectangle(Brushes.Wheat,
                        160,
                        hauteur - CInt(Math.Round(valeur(2) * 2)) - 1,
                        40,
                        CInt(Math.Round(valeur(2) * 2)))
        g.FillRectangle(Brushes.PaleGreen,
                        220,
                        hauteur - CInt(Math.Round(valeur(3) * 2)) - 1,
                        40,
                        CInt(Math.Round(valeur(3) * 2)))
        g.FillRectangle(Brushes.Green,
                        280,
                        hauteur - CInt(Math.Round(valeur(4) * 2)) - 1,
                        40,
                        CInt(Math.Round(valeur(4) * 2)))
        'l'image de la picture box prend la valeur b 
        pb.Image = b
    End Sub

    Public Sub setProgressBarAndLabel(p As ProgressBar, l As Label, n As Integer, m As Integer)
        'fixe min max, la valeur que doit prendre la progress bar et le label qui affiche le pourcentage
        p.Minimum = 0
        p.Maximum = 100
        p.Value = n
        l.Text = CStr(m) + "%"
    End Sub

End Module