Public Class Form1
'codé par Gaboche de WTO

    Public Feuille As Bitmap = New Bitmap(taillePb + 1, taillePb + 1)
    Public Dessin As Graphics = Graphics.FromImage(Feuille)
    Public Histogramme As Bitmap = New Bitmap(501, 201)
    Public Coloriage As Graphics = Graphics.FromImage(Histogramme)
    Public isRunning As Boolean = False
    Public aleaIsTrue As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'atribue à toutes les classes leur valeur initiale
        'Labels
        lblPeriod.Text = 0
        lblConvaincu.Text = 0
        lblHermetique.Text = 0
        lblImpactBaisse.Text = 1
        lblImpactHausse.Text = 1
        lblMoyenneCroyance.Text = 0
        lblPeriod.Text = 0
        lblSpringGreen.Text = 0
        lblPaleGreen.Text = 0
        lblWheat.Text = 0
        lblCoral.Text = 0
        lblTomato.Text = 0
        lblTotalCount.Text = 0
        lblCoral2.Text = 0
        lblTomato2.Text = 0
        lblPaleGreen2.Text = 0
        lblSpringGreen2.Text = 0
        lblWheat2.Text = 0
        ' TrackBars
        tbCredulite.Value = 1
        tbSceptisisme.Value = 1
        'TextBox
        txtNbCroyants.Text = 1
        txtNbIndivCredule.Text = 0
        txtNbIndivMoyen.Text = 0
        txtNbIndivSceptique.Text = 0
        'RadioBoutons
        rbAlea.Checked = True
        'ProgressBar
        pbarNbConvaincu.Value = 0
        pbarNbCoral.Value = 0
        pbarNbHermetique.Value = 0
        pbarNbPaleGreen.Value = 0
        pbarNbSpringGreen.Value = 0
        pbarNbTomato.Value = 0
        pbarNbWheat.Value = 0
        pbarProgress.Value = 0
        'PictureBox
        Dessin.Clear(Color.White)
        pbWorld.Image = Feuille
    End Sub

    Private Sub btnGenerer_Click(sender As Object, e As EventArgs) Handles btnGenerer.Click
        'atribue à toutes les classes leur valeur initiale
        'Labels
        lblPeriod.Text = 0
        lblConvaincu.Text = 0
        lblHermetique.Text = 0
        lblMoyenneCroyance.Text = 0
        lblPeriod.Text = 0
        lblSpringGreen.Text = 0
        lblPaleGreen.Text = 0
        lblWheat.Text = 0
        lblCoral.Text = 0
        lblTomato.Text = 0
        lblTotalCount.Text = 0
        'ProgressBar
        pbarNbConvaincu.Value = 0
        pbarNbCoral.Value = 0
        pbarNbHermetique.Value = 0
        pbarNbPaleGreen.Value = 0
        pbarNbSpringGreen.Value = 0
        pbarNbTomato.Value = 0
        pbarNbWheat.Value = 0
        pbarProgress.Value = 0
        lblCoral2.Text = 0
        lblTomato2.Text = 0
        lblPaleGreen2.Text = 0
        lblSpringGreen2.Text = 0
        lblWheat2.Text = 0
        'PictureBox
        Dessin.Clear(Color.White)
        pbWorld.Image = Feuille
        'radioBoutons et variable gérant la génération aléatoire
        If rbAlea.Checked = True Then
            aleaIsTrue = True
        Else
            aleaIsTrue = False
        End If
        'on récupère les données dans les pictures box remplies par l'utilisateur
        Dim nombre_individus_credules As Integer = CInt(txtNbIndivCredule.Text)
        Dim nombre_individus_moyens As Integer = CInt(txtNbIndivMoyen.Text)
        Dim nombre_individus_sceptiques As Integer = CInt(txtNbIndivSceptique.Text)
        'appel de la fonction initialisant les humains
        boucleInitialisation(nombre_individus_credules, nombre_individus_moyens, nombre_individus_sceptiques, aleaIsTrue, txtNbCroyants.Text)
        'dessin des humains sur la picture box
        For i = 0 To nombre_individus_credules + nombre_individus_moyens + nombre_individus_sceptiques - 1
            dessinerHumain(humains(i), Dessin)
        Next
        'l'image de la picture box prend la valeur Feuille
        pbWorld.Image = Feuille
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'gère la couleur et le texte sur le bouton strat/stop et la valeur de isRunnig
        If btnStart.Text = "START" Then
            btnStart.Text = "STOP"
            btnStart.BackColor = Color.Tomato
            Timer1.Interval = CInt(cbFrequency.Text)
            isRunning = True
            Timer1.Start()
        Else
            btnStart.Text = "START"
            btnStart.BackColor = Color.PaleGreen
            isRunning = False
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Efface l'image des pictures box
        Dessin.Clear(Color.White)
        Coloriage.Clear(Color.White)
        'La fréquence prend la valeur attribuée par l'utilisateur
        Timer1.Interval = CInt(cbFrequency.Text)
        'déclare les variables utiles pour l'analyse des données
        Dim nombre_individus_credules As Integer = CInt(txtNbIndivCredule.Text)
        Dim nombre_individus_moyens As Integer = CInt(txtNbIndivMoyen.Text)
        Dim nombre_individus_sceptiques As Integer = CInt(txtNbIndivSceptique.Text)
        Dim totalHumains As Integer = nombre_individus_credules + nombre_individus_moyens + nombre_individus_sceptiques
        Dim totalConvaincu As Integer = 0
        Dim totalHermetique As Integer = 0
        Dim totalTomato As Integer = 0
        Dim totalCoral As Integer = 0
        Dim totalWheat As Integer = 0
        Dim totalPaleGreen As Integer = 0
        Dim totalSpringGreen As Integer = 0
        Dim niveauDeCroyanceTotal As Integer = 0
        Dim niveauDeCroyanceMoyen As Integer = 0
        Dim progressionRumeur As Integer = 0
        ' Incremente les variables pour donner le nombre d'individu correspondant
        For i = 0 To totalHumains - 1
            If humains(i).niveauDeCroyance <= 10 And humains(i).niveauDeCroyance >= 6 Then
                totalTomato += 1
            ElseIf humains(i).niveauDeCroyance < 6 And humains(i).niveauDeCroyance >= 2 Then
                totalCoral += 1
            ElseIf humains(i).niveauDeCroyance < 2 And humains(i).niveauDeCroyance >= -2 Then
                totalWheat += 1
            ElseIf humains(i).niveauDeCroyance < -2 And humains(i).niveauDeCroyance >= -6 Then
                totalPaleGreen += 1
            ElseIf humains(i).niveauDeCroyance < -6 Then
                totalSpringGreen += 1
            End If

            If humains(i).niveauDeCroyance = 10 Then
                totalConvaincu += 1
            ElseIf humains(i).niveauDeCroyance = -10 Then
                totalHermetique += 1
            End If
            niveauDeCroyanceTotal += humains(i).niveauDeCroyance
        Next
        ' condition pour la robustesse
        If totalHumains <> 0 Then
            'calcul du niveau de croyance moyen
            niveauDeCroyanceMoyen = niveauDeCroyanceTotal / totalHumains * 10
        Else
            niveauDeCroyanceMoyen = 0
        End If
        'déclare et initialise le tableau servant de parametre au graphique
        Dim tableauValueHumains = {totalTomato * 100 / totalHumains,
            totalCoral * 100 / totalHumains,
            totalWheat * 100 / totalHumains,
            totalPaleGreen * 100 / totalHumains,
            totalSpringGreen * 100 / totalHumains}
        'les labels prennent la valeur de leur jumeaux
        lblCoral2.Text = lblCoral.Text
        lblTomato2.Text = lblTomato.Text
        lblWheat2.Text = lblWheat.Text
        lblSpringGreen2.Text = lblSpringGreen.Text
        lblPaleGreen2.Text = lblPaleGreen.Text
        'les labels prennent la valeur associée
        lblTotalCount.Text = totalHumains
        lblImpactBaisse.Text = tbSceptisisme.Value
        lblImpactHausse.Text = tbCredulite.Value
        lblPeriod.Text += 1
        'déplacement des humains dans la picture box
        For i = 0 To totalHumains - 1
            deplacerHumain(humains(i))
        Next
        'interaction entre humain
        transmission(totalHumains, tailleHumain, CInt(lblImpactBaisse.Text), CInt(lblImpactBaisse.Text))
        'dessin des humains
        For i = 0 To totalHumains - 1
            dessinerHumain(humains(i), Dessin)
        Next
        'condition pour la robustesse
        If totalHumains <> 0 Then
            'appel des fonction affichant les données
            setProgressBarAndLabel(pbarNbTomato, lblTomato, totalTomato * 100 / totalHumains, totalTomato * 100 / totalHumains)
            setProgressBarAndLabel(pbarNbCoral, lblCoral, totalCoral * 100 / totalHumains, totalCoral * 100 / totalHumains)
            setProgressBarAndLabel(pbarNbWheat, lblWheat, totalWheat * 100 / totalHumains, totalWheat * 100 / totalHumains)
            setProgressBarAndLabel(pbarNbPaleGreen, lblPaleGreen, totalPaleGreen * 100 / totalHumains, totalPaleGreen * 100 / totalHumains)
            setProgressBarAndLabel(pbarNbSpringGreen, lblSpringGreen, totalSpringGreen * 100 / totalHumains, totalSpringGreen * 100 / totalHumains)
            setProgressBarAndLabel(pbarNbConvaincu, lblConvaincu, totalConvaincu * 100 / totalHumains, totalConvaincu * 100 / totalHumains)
            setProgressBarAndLabel(pbarNbHermetique, lblHermetique, totalHermetique * 100 / totalHumains, totalHermetique * 100 / totalHumains)
            setProgressBarAndLabel(pbarProgress, lblMoyenneCroyance, niveauDeCroyanceMoyen + 50, niveauDeCroyanceMoyen + 50)
            setGraphicHisto(5, Coloriage, Histogramme, pbHistogramme, tableauValueHumains)
        Else
        End If
        'l'image de la picture box prend la valeur Feuille
        pbWorld.Image = Feuille
    End Sub

End Class