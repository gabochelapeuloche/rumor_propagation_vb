Module data
'codé par Gaboche de WTO

    'le tableau contenenat les humains
    Public humains(5000) As Humain
    'taille de la picture box
    Public Const taillePb As Integer = 501
    'coté du carré représentant un humain
    Public Const tailleHumain As Integer = 10

    Public Structure Humain
        'variables caractérisant un humain
        Dim niveauDeCroyance As Double 't + 1
        Dim NiveauDeCroyanceT As Double 't
        Dim niveauDePersuasion As Double
        Dim niveauDeCredulite As Double
        Dim typeDePersonne As TypeDePersonne
        Dim coordonnees As Point
    End Structure

    Public Structure Point
        Dim x As Integer
        Dim y As Integer
    End Structure

    Public Enum TypeDePersonne
        Credule
        Moyen
        Sceptique
    End Enum

End Module
