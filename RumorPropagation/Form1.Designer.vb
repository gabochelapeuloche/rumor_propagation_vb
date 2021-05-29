<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _'codé par Gaboche de WTO
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbWorld = New System.Windows.Forms.PictureBox()
        Me.btnGenerer = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblImpactBaisse = New System.Windows.Forms.Label()
        Me.txtNbIndivCredule = New System.Windows.Forms.TextBox()
        Me.txtNbIndivMoyen = New System.Windows.Forms.TextBox()
        Me.txtNbIndivSceptique = New System.Windows.Forms.TextBox()
        Me.cbFrequency = New System.Windows.Forms.ComboBox()
        Me.lblImpactHausse = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pbarNbHermetique = New System.Windows.Forms.ProgressBar()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.pbarNbConvaincu = New System.Windows.Forms.ProgressBar()
        Me.lblCoral = New System.Windows.Forms.Label()
        Me.lblHermetique = New System.Windows.Forms.Label()
        Me.lblWheat = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblConvaincu = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblPaleGreen = New System.Windows.Forms.Label()
        Me.lblMoyenneCroyance = New System.Windows.Forms.Label()
        Me.lblSpringGreen = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTomato = New System.Windows.Forms.Label()
        Me.pbarProgress = New System.Windows.Forms.ProgressBar()
        Me.pbarNbCoral = New System.Windows.Forms.ProgressBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pbarNbWheat = New System.Windows.Forms.ProgressBar()
        Me.pbarNbPaleGreen = New System.Windows.Forms.ProgressBar()
        Me.pbarNbSpringGreen = New System.Windows.Forms.ProgressBar()
        Me.pbarNbTomato = New System.Windows.Forms.ProgressBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbNonAlea = New System.Windows.Forms.RadioButton()
        Me.txtNbCroyants = New System.Windows.Forms.TextBox()
        Me.rbAlea = New System.Windows.Forms.RadioButton()
        Me.tbCredulite = New System.Windows.Forms.TrackBar()
        Me.tbSceptisisme = New System.Windows.Forms.TrackBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.pbHistogramme = New System.Windows.Forms.PictureBox()
        Me.lblCoral2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblWheat2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblPaleGreen2 = New System.Windows.Forms.Label()
        Me.lblSpringGreen2 = New System.Windows.Forms.Label()
        Me.lblTomato2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.pbWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.tbCredulite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSceptisisme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.pbHistogramme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbWorld
        '
        Me.pbWorld.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pbWorld.Location = New System.Drawing.Point(12, 12)
        Me.pbWorld.Name = "pbWorld"
        Me.pbWorld.Size = New System.Drawing.Size(500, 500)
        Me.pbWorld.TabIndex = 0
        Me.pbWorld.TabStop = False
        '
        'btnGenerer
        '
        Me.btnGenerer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGenerer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerer.Location = New System.Drawing.Point(4, 18)
        Me.btnGenerer.Name = "btnGenerer"
        Me.btnGenerer.Size = New System.Drawing.Size(167, 39)
        Me.btnGenerer.TabIndex = 1
        Me.btnGenerer.Text = "GENERER"
        Me.btnGenerer.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(4, 63)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(167, 40)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre d'humains crédules"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Crédulité Globale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sceptiscisme Global"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Moyen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sceptique"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(28, 84)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(13, 15)
        Me.lblPeriod.TabIndex = 8
        Me.lblPeriod.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Vitesse de déroulement de la simulation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nombre d'itérations"
        '
        'lblImpactBaisse
        '
        Me.lblImpactBaisse.AutoSize = True
        Me.lblImpactBaisse.Location = New System.Drawing.Point(141, 96)
        Me.lblImpactBaisse.Name = "lblImpactBaisse"
        Me.lblImpactBaisse.Size = New System.Drawing.Size(13, 15)
        Me.lblImpactBaisse.TabIndex = 11
        Me.lblImpactBaisse.Text = "1"
        '
        'txtNbIndivCredule
        '
        Me.txtNbIndivCredule.Location = New System.Drawing.Point(14, 42)
        Me.txtNbIndivCredule.Name = "txtNbIndivCredule"
        Me.txtNbIndivCredule.Size = New System.Drawing.Size(100, 23)
        Me.txtNbIndivCredule.TabIndex = 12
        Me.txtNbIndivCredule.Text = "0"
        '
        'txtNbIndivMoyen
        '
        Me.txtNbIndivMoyen.Location = New System.Drawing.Point(14, 86)
        Me.txtNbIndivMoyen.Name = "txtNbIndivMoyen"
        Me.txtNbIndivMoyen.Size = New System.Drawing.Size(100, 23)
        Me.txtNbIndivMoyen.TabIndex = 13
        Me.txtNbIndivMoyen.Text = "0"
        '
        'txtNbIndivSceptique
        '
        Me.txtNbIndivSceptique.Location = New System.Drawing.Point(14, 130)
        Me.txtNbIndivSceptique.Name = "txtNbIndivSceptique"
        Me.txtNbIndivSceptique.Size = New System.Drawing.Size(100, 23)
        Me.txtNbIndivSceptique.TabIndex = 14
        Me.txtNbIndivSceptique.Text = "0"
        '
        'cbFrequency
        '
        Me.cbFrequency.FormattingEnabled = True
        Me.cbFrequency.Items.AddRange(New Object() {"10", "25", "50", "75", "100", "250", "500"})
        Me.cbFrequency.Location = New System.Drawing.Point(14, 48)
        Me.cbFrequency.Name = "cbFrequency"
        Me.cbFrequency.Size = New System.Drawing.Size(121, 23)
        Me.cbFrequency.TabIndex = 15
        Me.cbFrequency.Text = "10"
        '
        'lblImpactHausse
        '
        Me.lblImpactHausse.AutoSize = True
        Me.lblImpactHausse.Location = New System.Drawing.Point(417, 96)
        Me.lblImpactHausse.Name = "lblImpactHausse"
        Me.lblImpactHausse.Size = New System.Drawing.Size(13, 15)
        Me.lblImpactHausse.TabIndex = 16
        Me.lblImpactHausse.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nombre total d'humain"
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Location = New System.Drawing.Point(28, 54)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(13, 15)
        Me.lblTotalCount.TabIndex = 18
        Me.lblTotalCount.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnGenerer)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Location = New System.Drawing.Point(518, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 108)
        Me.Panel1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Boutons"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtNbIndivCredule)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNbIndivMoyen)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtNbIndivSceptique)
        Me.Panel2.Location = New System.Drawing.Point(518, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(187, 191)
        Me.Panel2.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Informations à Saisir"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.pbarNbHermetique)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.pbarNbConvaincu)
        Me.Panel3.Controls.Add(Me.lblCoral)
        Me.Panel3.Controls.Add(Me.lblHermetique)
        Me.Panel3.Controls.Add(Me.lblWheat)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.lblConvaincu)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.lblPaleGreen)
        Me.Panel3.Controls.Add(Me.lblMoyenneCroyance)
        Me.Panel3.Controls.Add(Me.lblSpringGreen)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.lblTomato)
        Me.Panel3.Controls.Add(Me.pbarProgress)
        Me.Panel3.Controls.Add(Me.pbarNbCoral)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.pbarNbWheat)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.pbarNbPaleGreen)
        Me.Panel3.Controls.Add(Me.lblPeriod)
        Me.Panel3.Controls.Add(Me.pbarNbSpringGreen)
        Me.Panel3.Controls.Add(Me.lblTotalCount)
        Me.Panel3.Controls.Add(Me.pbarNbTomato)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(711, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(395, 305)
        Me.Panel3.TabIndex = 21
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(188, 54)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(203, 15)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "(rouge très croyant, vert peu croyant)"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(99, -110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(202, 15)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Répartition du plus au moins croyant"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(188, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(202, 15)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Répartition du plus au moins croyant"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Green
        Me.Label23.Location = New System.Drawing.Point(223, 148)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 15)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "."
        '
        'pbarNbHermetique
        '
        Me.pbarNbHermetique.Location = New System.Drawing.Point(30, 179)
        Me.pbarNbHermetique.Name = "pbarNbHermetique"
        Me.pbarNbHermetique.Size = New System.Drawing.Size(100, 11)
        Me.pbarNbHermetique.TabIndex = 34
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.PaleGreen
        Me.Label24.Location = New System.Drawing.Point(223, 131)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 15)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "."
        '
        'pbarNbConvaincu
        '
        Me.pbarNbConvaincu.Location = New System.Drawing.Point(30, 149)
        Me.pbarNbConvaincu.Name = "pbarNbConvaincu"
        Me.pbarNbConvaincu.Size = New System.Drawing.Size(100, 11)
        Me.pbarNbConvaincu.TabIndex = 8
        '
        'lblCoral
        '
        Me.lblCoral.AutoSize = True
        Me.lblCoral.Location = New System.Drawing.Point(346, 97)
        Me.lblCoral.Name = "lblCoral"
        Me.lblCoral.Size = New System.Drawing.Size(13, 15)
        Me.lblCoral.TabIndex = 12
        Me.lblCoral.Text = "0"
        '
        'lblHermetique
        '
        Me.lblHermetique.AutoSize = True
        Me.lblHermetique.Location = New System.Drawing.Point(134, 175)
        Me.lblHermetique.Name = "lblHermetique"
        Me.lblHermetique.Size = New System.Drawing.Size(13, 15)
        Me.lblHermetique.TabIndex = 32
        Me.lblHermetique.Text = "0"
        '
        'lblWheat
        '
        Me.lblWheat.AutoSize = True
        Me.lblWheat.Location = New System.Drawing.Point(346, 114)
        Me.lblWheat.Name = "lblWheat"
        Me.lblWheat.Size = New System.Drawing.Size(13, 15)
        Me.lblWheat.TabIndex = 11
        Me.lblWheat.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 161)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 15)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Nombre d'hermétiques"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label22.Location = New System.Drawing.Point(223, 97)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 15)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "."
        '
        'lblConvaincu
        '
        Me.lblConvaincu.AutoSize = True
        Me.lblConvaincu.Location = New System.Drawing.Point(134, 145)
        Me.lblConvaincu.Name = "lblConvaincu"
        Me.lblConvaincu.Size = New System.Drawing.Size(13, 15)
        Me.lblConvaincu.TabIndex = 30
        Me.lblConvaincu.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Wheat
        Me.Label14.Location = New System.Drawing.Point(223, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 15)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "NombreDeConvaincu"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Tomato
        Me.Label21.Location = New System.Drawing.Point(223, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(10, 15)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(41, 235)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(240, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Progression de la rumeur dans la population"
        '
        'lblPaleGreen
        '
        Me.lblPaleGreen.AutoSize = True
        Me.lblPaleGreen.Location = New System.Drawing.Point(346, 131)
        Me.lblPaleGreen.Name = "lblPaleGreen"
        Me.lblPaleGreen.Size = New System.Drawing.Size(13, 15)
        Me.lblPaleGreen.TabIndex = 10
        Me.lblPaleGreen.Text = "0"
        '
        'lblMoyenneCroyance
        '
        Me.lblMoyenneCroyance.AutoSize = True
        Me.lblMoyenneCroyance.Location = New System.Drawing.Point(298, 242)
        Me.lblMoyenneCroyance.Name = "lblMoyenneCroyance"
        Me.lblMoyenneCroyance.Size = New System.Drawing.Size(13, 15)
        Me.lblMoyenneCroyance.TabIndex = 25
        Me.lblMoyenneCroyance.Text = "0"
        '
        'lblSpringGreen
        '
        Me.lblSpringGreen.AutoSize = True
        Me.lblSpringGreen.Location = New System.Drawing.Point(346, 148)
        Me.lblSpringGreen.Name = "lblSpringGreen"
        Me.lblSpringGreen.Size = New System.Drawing.Size(13, 15)
        Me.lblSpringGreen.TabIndex = 9
        Me.lblSpringGreen.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(41, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 15)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Niveau de croyance moyen"
        '
        'lblTomato
        '
        Me.lblTomato.AutoSize = True
        Me.lblTomato.Location = New System.Drawing.Point(346, 79)
        Me.lblTomato.Name = "lblTomato"
        Me.lblTomato.Size = New System.Drawing.Size(13, 15)
        Me.lblTomato.TabIndex = 8
        Me.lblTomato.Text = "0"
        '
        'pbarProgress
        '
        Me.pbarProgress.Location = New System.Drawing.Point(10, 273)
        Me.pbarProgress.Name = "pbarProgress"
        Me.pbarProgress.Size = New System.Drawing.Size(374, 23)
        Me.pbarProgress.TabIndex = 23
        '
        'pbarNbCoral
        '
        Me.pbarNbCoral.Location = New System.Drawing.Point(239, 101)
        Me.pbarNbCoral.Name = "pbarNbCoral"
        Me.pbarNbCoral.Size = New System.Drawing.Size(100, 11)
        Me.pbarNbCoral.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Informations Sur la Simulation"
        '
        'pbarNbWheat
        '
        Me.pbarNbWheat.Location = New System.Drawing.Point(239, 118)
        Me.pbarNbWheat.Name = "pbarNbWheat"
        Me.pbarNbWheat.Size = New System.Drawing.Size(100, 11)
        Me.pbarNbWheat.TabIndex = 6
        '
        'pbarNbPaleGreen
        '
        Me.pbarNbPaleGreen.Location = New System.Drawing.Point(239, 135)
        Me.pbarNbPaleGreen.Name = "pbarNbPaleGreen"
        Me.pbarNbPaleGreen.Size = New System.Drawing.Size(100, 11)
        Me.pbarNbPaleGreen.TabIndex = 5
        '
        'pbarNbSpringGreen
        '
        Me.pbarNbSpringGreen.Location = New System.Drawing.Point(239, 152)
        Me.pbarNbSpringGreen.Name = "pbarNbSpringGreen"
        Me.pbarNbSpringGreen.Size = New System.Drawing.Size(100, 11)
        Me.pbarNbSpringGreen.TabIndex = 4
        '
        'pbarNbTomato
        '
        Me.pbarNbTomato.ForeColor = System.Drawing.Color.Tomato
        Me.pbarNbTomato.Location = New System.Drawing.Point(239, 84)
        Me.pbarNbTomato.Name = "pbarNbTomato"
        Me.pbarNbTomato.Size = New System.Drawing.Size(100, 11)
        Me.pbarNbTomato.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Controls.Add(Me.rbNonAlea)
        Me.Panel4.Controls.Add(Me.txtNbCroyants)
        Me.Panel4.Controls.Add(Me.rbAlea)
        Me.Panel4.Controls.Add(Me.tbCredulite)
        Me.Panel4.Controls.Add(Me.tbSceptisisme)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.cbFrequency)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.lblImpactHausse)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lblImpactBaisse)
        Me.Panel4.Location = New System.Drawing.Point(518, 323)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(588, 189)
        Me.Panel4.TabIndex = 22
        '
        'rbNonAlea
        '
        Me.rbNonAlea.AutoSize = True
        Me.rbNonAlea.Location = New System.Drawing.Point(277, 52)
        Me.rbNonAlea.Name = "rbNonAlea"
        Me.rbNonAlea.Size = New System.Drawing.Size(197, 19)
        Me.rbNonAlea.TabIndex = 25
        Me.rbNonAlea.TabStop = True
        Me.rbNonAlea.Text = "Selection Du nombre de Croyant"
        Me.rbNonAlea.UseVisualStyleBackColor = True
        '
        'txtNbCroyants
        '
        Me.txtNbCroyants.Location = New System.Drawing.Point(479, 48)
        Me.txtNbCroyants.Name = "txtNbCroyants"
        Me.txtNbCroyants.Size = New System.Drawing.Size(100, 23)
        Me.txtNbCroyants.TabIndex = 24
        Me.txtNbCroyants.Text = "1"
        '
        'rbAlea
        '
        Me.rbAlea.AutoSize = True
        Me.rbAlea.Location = New System.Drawing.Point(277, 26)
        Me.rbAlea.Name = "rbAlea"
        Me.rbAlea.Size = New System.Drawing.Size(179, 19)
        Me.rbAlea.TabIndex = 24
        Me.rbAlea.TabStop = True
        Me.rbAlea.Text = "Niveau de croyance Aleatoire"
        Me.rbAlea.UseVisualStyleBackColor = True
        '
        'tbCredulite
        '
        Me.tbCredulite.Location = New System.Drawing.Point(307, 114)
        Me.tbCredulite.Name = "tbCredulite"
        Me.tbCredulite.Size = New System.Drawing.Size(104, 45)
        Me.tbCredulite.TabIndex = 18
        '
        'tbSceptisisme
        '
        Me.tbSceptisisme.Location = New System.Drawing.Point(23, 114)
        Me.tbSceptisisme.Name = "tbSceptisisme"
        Me.tbSceptisisme.Size = New System.Drawing.Size(104, 45)
        Me.tbSceptisisme.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Informations à Sélectionner"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.Controls.Add(Me.Label37)
        Me.Panel5.Controls.Add(Me.Label36)
        Me.Panel5.Controls.Add(Me.Label35)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label30)
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.pbHistogramme)
        Me.Panel5.Controls.Add(Me.lblCoral2)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.lblWheat2)
        Me.Panel5.Controls.Add(Me.Label31)
        Me.Panel5.Controls.Add(Me.Label32)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.lblPaleGreen2)
        Me.Panel5.Controls.Add(Me.lblSpringGreen2)
        Me.Panel5.Controls.Add(Me.lblTomato2)
        Me.Panel5.Location = New System.Drawing.Point(12, 518)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1094, 277)
        Me.Panel5.TabIndex = 23
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(760, 179)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(165, 15)
        Me.Label37.TabIndex = 57
        Me.Label37.Text = "Niveau de croyance très faible"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(760, 162)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(143, 15)
        Me.Label36.TabIndex = 56
        Me.Label36.Text = "Niveau de croyance faible"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(760, 145)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(151, 15)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "Niveau de croyance moyen"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(760, 127)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(141, 15)
        Me.Label34.TabIndex = 54
        Me.Label34.Text = "Niveau de croyance élevé"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(760, 110)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(163, 15)
        Me.Label30.TabIndex = 53
        Me.Label30.Text = "Niveau de croyance très élevé"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(202, 28)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(188, 15)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = "% de couleur parmis la population"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Green
        Me.Label27.Location = New System.Drawing.Point(712, 178)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(10, 15)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.PaleGreen
        Me.Label28.Location = New System.Drawing.Point(712, 161)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(10, 15)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "."
        '
        'pbHistogramme
        '
        Me.pbHistogramme.BackColor = System.Drawing.Color.White
        Me.pbHistogramme.Location = New System.Drawing.Point(192, 51)
        Me.pbHistogramme.Name = "pbHistogramme"
        Me.pbHistogramme.Size = New System.Drawing.Size(501, 201)
        Me.pbHistogramme.TabIndex = 1
        Me.pbHistogramme.TabStop = False
        '
        'lblCoral2
        '
        Me.lblCoral2.AutoSize = True
        Me.lblCoral2.Location = New System.Drawing.Point(728, 128)
        Me.lblCoral2.Name = "lblCoral2"
        Me.lblCoral2.Size = New System.Drawing.Size(13, 15)
        Me.lblCoral2.TabIndex = 46
        Me.lblCoral2.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Graphiques"
        '
        'lblWheat2
        '
        Me.lblWheat2.AutoSize = True
        Me.lblWheat2.Location = New System.Drawing.Point(728, 145)
        Me.lblWheat2.Name = "lblWheat2"
        Me.lblWheat2.Size = New System.Drawing.Size(13, 15)
        Me.lblWheat2.TabIndex = 45
        Me.lblWheat2.Text = "0"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label31.Location = New System.Drawing.Point(712, 127)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(10, 15)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Wheat
        Me.Label32.Location = New System.Drawing.Point(712, 144)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(10, 15)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Tomato
        Me.Label33.Location = New System.Drawing.Point(712, 110)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(10, 15)
        Me.Label33.TabIndex = 48
        Me.Label33.Text = "."
        '
        'lblPaleGreen2
        '
        Me.lblPaleGreen2.AutoSize = True
        Me.lblPaleGreen2.Location = New System.Drawing.Point(728, 162)
        Me.lblPaleGreen2.Name = "lblPaleGreen2"
        Me.lblPaleGreen2.Size = New System.Drawing.Size(13, 15)
        Me.lblPaleGreen2.TabIndex = 44
        Me.lblPaleGreen2.Text = "0"
        '
        'lblSpringGreen2
        '
        Me.lblSpringGreen2.AutoSize = True
        Me.lblSpringGreen2.Location = New System.Drawing.Point(728, 179)
        Me.lblSpringGreen2.Name = "lblSpringGreen2"
        Me.lblSpringGreen2.Size = New System.Drawing.Size(13, 15)
        Me.lblSpringGreen2.TabIndex = 43
        Me.lblSpringGreen2.Text = "0"
        '
        'lblTomato2
        '
        Me.lblTomato2.AutoSize = True
        Me.lblTomato2.Location = New System.Drawing.Point(728, 110)
        Me.lblTomato2.Name = "lblTomato2"
        Me.lblTomato2.Size = New System.Drawing.Size(13, 15)
        Me.lblTomato2.TabIndex = 42
        Me.lblTomato2.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Tomato
        Me.Label17.Location = New System.Drawing.Point(831, 532)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 15)
        Me.Label17.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 807)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbWorld)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbWorld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.tbCredulite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSceptisisme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pbHistogramme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbWorld As PictureBox
    Friend WithEvents btnGenerer As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblImpactBaisse As Label
    Friend WithEvents txtNbIndivCredule As TextBox
    Friend WithEvents txtNbIndivMoyen As TextBox
    Friend WithEvents txtNbIndivSceptique As TextBox
    Friend WithEvents cbFrequency As ComboBox
    Friend WithEvents lblImpactHausse As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbarProgress As ProgressBar
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblMoyenneCroyance As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents pbarNbHermetique As ProgressBar
    Friend WithEvents pbarNbConvaincu As ProgressBar
    Friend WithEvents lblHermetique As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblConvaincu As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents pbarNbCoral As ProgressBar
    Friend WithEvents pbarNbWheat As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents pbarNbSpringGreen As ProgressBar
    Friend WithEvents pbarNbTomato As ProgressBar
    Friend WithEvents pbarNbTomat As ProgressBar
    Friend WithEvents pbarNbPaleGreen As ProgressBar
    Friend WithEvents lblCoral As Label
    Friend WithEvents lblWheat As Label
    Friend WithEvents lblPaleGreen As Label
    Friend WithEvents lblSpringGreen As Label
    Friend WithEvents lblTomato As Label
    Friend WithEvents tbCredulite As TrackBar
    Friend WithEvents tbSceptisisme As TrackBar
    Friend WithEvents txtbNbCroyants As TextBox
    Friend WithEvents rbNonAlea As RadioButton
    Friend WithEvents rbAlea As RadioButton
    Friend WithEvents txtNbCroyants As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents pbHistogramme As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblCoral2 As Label
    Friend WithEvents lblWheat2 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblPaleGreen2 As Label
    Friend WithEvents lblSpringGreen2 As Label
    Friend WithEvents lblTomato2 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
End Class
