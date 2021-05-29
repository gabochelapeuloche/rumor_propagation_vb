Module functions
'codé par Gaboche de WTO

    Sub loi(ByRef h1 As Humain, ByVal h2 As Humain, ByVal impactBaisse As Double, ByVal impactHausse As Double)
        'La loi qui régit la transmission positive ou négative de l’information
        'ici on déclare la variable p pour aléger le code par la suite
        Dim p As Double = h1.NiveauDeCroyanceT * h2.niveauDePersuasion * h1.niveauDeCredulite / 1000
        'les variables impacts permettent de jouer sur la grandeur p  selon si le niveau de croyance augmente ou baisse
        If p >= 0 Then
            h1.niveauDeCroyance = Math.Min((h1.NiveauDeCroyanceT + (p * impactHausse)), 10)
        ElseIf p < 0 Then
            h1.niveauDeCroyance = Math.Max((h1.NiveauDeCroyanceT + (p * impactBaisse)), -10)
        End If
    End Sub

    Public Sub transmission(ByVal nombre_humains As Integer, ByVal tailleHumain As Integer, ByVal impactBaisse As Integer, ByVal impactHausse As Integer)
        'On régit les interactions entre humains
        For i = 0 To nombre_humains - 1
            For j = 0 To nombre_humains - 1
                If i <> j Then
                    For n = -tailleHumain To tailleHumain
                        For p = -tailleHumain To tailleHumain
                            If humains(i).coordonnees.x = humains(j).coordonnees.x + n And humains(i).coordonnees.y = humains(j).coordonnees.y + p Then
                                loi(humains(i), humains(j), impactBaisse, impactHausse)
                            End If
                        Next
                    Next
                End If
            Next
        Next
        'le niveau de croyance passé prend la valeur du niveau de croyance actuel
        For i = 0 To nombre_humains - 1
            humains(i).NiveauDeCroyanceT = humains(i).niveauDeCroyance
        Next
    End Sub

    Public Sub deplacerHumain(ByRef h1 As Humain)
        'Déplacement sur la picture box des humains dans la simulation
        'méthode pour génrer des nombres aléatoires
        Dim rand As New Random
        'pour que les humains tende plus à se déplacer qu'à s'arreter
        Dim probabilitéDeDéplacement(10) As Integer
        '40% de -1
        For i = 0 To 3
            probabilitéDeDéplacement(i) = -1
        Next
        '20% de 0
        For i = 4 To 5
            probabilitéDeDéplacement(i) = 0
        Next
        '40% de 1
        For i = 6 To 9
            probabilitéDeDéplacement(i) = 1
        Next
        'changelent de coordonnées
        Dim randNb1, randNb2 As Integer
        randNb1 = rand.Next(10)
        randNb2 = rand.Next(10)
        h1.coordonnees.x += probabilitéDeDéplacement(randNb1) * tailleHumain
        h1.coordonnees.y += probabilitéDeDéplacement(randNb2) * tailleHumain
        'Toricité
        If h1.coordonnees.x > taillePb And h1.coordonnees.y > taillePb Then
            h1.coordonnees.x -= taillePb
            h1.coordonnees.y -= taillePb
        ElseIf h1.coordonnees.x < 0 And h1.coordonnees.y < 0 Then
            h1.coordonnees.x += taillePb
            h1.coordonnees.y += taillePb
        ElseIf h1.coordonnees.x > taillePb And h1.coordonnees.y < 0 Then
            h1.coordonnees.x -= taillePb
            h1.coordonnees.y += taillePb
        ElseIf h1.coordonnees.x < 0 And h1.coordonnees.y > taillePb Then
            h1.coordonnees.x += taillePb
            h1.coordonnees.y -= taillePb
        ElseIf h1.coordonnees.x > taillePb And taillePb > h1.coordonnees.y > 0 Then
            h1.coordonnees.x -= taillePb
        ElseIf h1.coordonnees.x < 0 And taillePb > h1.coordonnees.y > 0 Then
            h1.coordonnees.x += taillePb
        ElseIf 0 < h1.coordonnees.x < taillePb And h1.coordonnees.y < 0 Then
            h1.coordonnees.y += taillePb
        ElseIf 0 < h1.coordonnees.x < taillePb And h1.coordonnees.y > taillePb Then
            h1.coordonnees.y -= taillePb
        End If
    End Sub

    Public Sub initHumain(ByRef h1 As Humain, ByVal type As TypeDePersonne)
        'Initialise un humain en fonction de ses caractéristiques
        'on commence par initialiser les variables ne dépendant pas du typeHumain et donc aléatoires
        Dim rand As New Random
        h1.niveauDePersuasion = rand.Next(-10, 10)
        h1.niveauDeCroyance = rand.Next(-10, 10)
        h1.NiveauDeCroyanceT = h1.niveauDeCroyance
        'on initialise les variables dépendant du typeHumain
        Select Case type.ToString()
            Case "Credule"
                h1.niveauDeCredulite = rand.Next(4, 10)
            Case "Moyen"
                h1.niveauDeCredulite = rand.Next(-4, 4)
            Case "Sceptique"
                h1.niveauDeCredulite = rand.Next(-10, -4)
        End Select
    End Sub

    Public Sub boucleInitialisation(ByVal nbHumainTypeC As Integer, ByVal nbHumainTypeM As Integer, ByVal nbHumainTypeS As Integer, ByRef aleaIsTrue As Boolean, ByVal nbCroyant As Integer)
        ' on commence par placer les credules
        For i = nbCroyant To nbHumainTypeC - 1
            'pour le nombre demandé par l'utilisateur on initialise un humain
            initHumain(h1:=humains(i), type:=TypeDePersonne.Credule)
            If i <> 0 Then
                For j = 0 To i - 1 ' on observe que la partie gauche pa rrapport à i (à droite le tableau est pour l'instant vide
                    Dim rand As New Random
                    Dim place_occupee As Boolean = True
                    While place_occupee ' tant qu'un humain est déjà placé à ce coordonnées
                        place_occupee = False
                        'Si la place est occupée
                        If humains(j).coordonnees.x = humains(i).coordonnees.x And humains(j).coordonnees.y = humains(i).coordonnees.y Then
                            ' on attribue des coordonnées aléatoire
                            humains(i).coordonnees.x = rand.Next(0, taillePb)
                            humains(i).coordonnees.y = rand.Next(0, taillePb)
                            place_occupee = True 'et la place devient occupée
                        End If
                    End While
                Next
            End If
        Next
        'on place ensuite les moyen :
        For i = nbHumainTypeC To nbHumainTypeM + nbHumainTypeC - 1
            initHumain(h1:=humains(i), type:=TypeDePersonne.Moyen)
            If i <> 0 Then
                For j = 0 To i - 1
                    Dim rand As New Random
                    Dim place_occupee As Boolean = True
                    While place_occupee
                        place_occupee = False
                        If humains(j).coordonnees.x = humains(i).coordonnees.x And humains(j).coordonnees.y = humains(i).coordonnees.y Then
                            humains(i).coordonnees.x = rand.Next(0, taillePb)
                            humains(i).coordonnees.y = rand.Next(0, taillePb)
                            place_occupee = True
                        End If
                    End While
                Next
            End If
        Next
        'on place enfin les sceptique :
        For i = nbHumainTypeC + nbHumainTypeM To nbHumainTypeC + nbHumainTypeM + nbHumainTypeS - 1
            initHumain(h1:=humains(i), type:=TypeDePersonne.Sceptique)
            If i <> 0 Then
                For j = 0 To i - 1
                    Dim rand As New Random
                    Dim place_occupee As Boolean = True
                    While place_occupee
                        place_occupee = False
                        If humains(j).coordonnees.x = humains(i).coordonnees.x And humains(j).coordonnees.y = humains(i).coordonnees.y Then
                            humains(i).coordonnees.x = rand.Next(0, taillePb)
                            humains(i).coordonnees.y = rand.Next(0, taillePb)
                            place_occupee = True
                        End If
                    End While
                Next
            End If
        Next
        ' Si l'utuilisateur à choisit la génération non naléatoire (choix du nombre de croyant de départ)
        If aleaIsTrue = False Then
            ' on attribue le niveau de croyance maximal pour le nombre d'humain choisit par l'user
            For i = 0 To nbCroyant - 1
                humains(i).niveauDeCroyance = 10
            Next
            ' aux autres on attribue un niveau de croyance moyen
            For i = nbCroyant To nbHumainTypeC + nbHumainTypeM + nbHumainTypeS - 1
                Dim rand As New Random
                humains(i).niveauDeCroyance = rand.Next(-2, 2)
                humains(i).NiveauDeCroyanceT = humains(i).niveauDeCroyance
            Next
        End If
    End Sub

    Public Sub dessinerHumain(ByVal h1 As Humain, g As Graphics)
        'si niveau de croyance < -6 alors on dessine un carré de couleur tomate pour représenter l'umain, etc
        If h1.niveauDeCroyance < -6 Then
            g.FillRectangle(Brushes.Green, h1.coordonnees.x, h1.coordonnees.y, tailleHumain, tailleHumain)
        ElseIf h1.niveauDeCroyance < -2 And h1.niveauDeCroyance >= -6 Then
            g.FillRectangle(Brushes.PaleGreen, h1.coordonnees.x, h1.coordonnees.y, tailleHumain, tailleHumain)
        ElseIf h1.niveauDeCroyance < 2 And h1.niveauDeCroyance >= -2 Then
            g.FillRectangle(Brushes.Wheat, h1.coordonnees.x, h1.coordonnees.y, tailleHumain, tailleHumain)
        ElseIf h1.niveauDeCroyance < 6 And h1.niveauDeCroyance >= 2 Then
            g.FillRectangle(Brushes.DarkSalmon, h1.coordonnees.x, h1.coordonnees.y, tailleHumain, tailleHumain)
        ElseIf h1.niveauDeCroyance <= 10 And h1.niveauDeCroyance >= 6 Then
            g.FillRectangle(Brushes.Tomato, h1.coordonnees.x, h1.coordonnees.y, tailleHumain, tailleHumain)
        End If
    End Sub

End Module