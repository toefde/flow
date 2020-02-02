<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbNeuStatus = New System.Windows.Forms.ComboBox()
        Me.cbNeuPrio = New System.Windows.Forms.ComboBox()
        Me.cbPrio = New System.Windows.Forms.ComboBox()
        Me.btnBearbeitetUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AnmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslInfo = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpUebersicht = New System.Windows.Forms.TabPage()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnAktualisieren = New System.Windows.Forms.Button()
        Me.dgvUebersicht = New System.Windows.Forms.DataGridView()
        Me.tpBearbeiten = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbLetzterStand = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cbBearbeiter = New System.Windows.Forms.ComboBox()
        Me.cbKategorie = New System.Windows.Forms.ComboBox()
        Me.btnAbbrechenBearbeiten = New System.Windows.Forms.Button()
        Me.btnStaende = New System.Windows.Forms.Button()
        Me.tbBeschreibung = New System.Windows.Forms.TextBox()
        Me.tbTitel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbStand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTicketNr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tpAufgabeErstellen = New System.Windows.Forms.TabPage()
        Me.cbNeuBearbeiter = New System.Windows.Forms.ComboBox()
        Me.cbNeuKategorie = New System.Windows.Forms.ComboBox()
        Me.btnNeuInsert = New System.Windows.Forms.Button()
        Me.tbNeuBeschreibung = New System.Windows.Forms.TextBox()
        Me.tbNeuTitel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbNeuTicketNr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpUebersicht.SuspendLayout()
        CType(Me.dgvUebersicht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBearbeiten.SuspendLayout()
        Me.tpAufgabeErstellen.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbStatus.Location = New System.Drawing.Point(691, 30)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(189, 28)
        Me.cbStatus.TabIndex = 21
        '
        'cbNeuStatus
        '
        Me.cbNeuStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbNeuStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuStatus.Location = New System.Drawing.Point(816, 30)
        Me.cbNeuStatus.Name = "cbNeuStatus"
        Me.cbNeuStatus.Size = New System.Drawing.Size(189, 28)
        Me.cbNeuStatus.TabIndex = 33
        '
        'cbNeuPrio
        '
        Me.cbNeuPrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuPrio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbNeuPrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuPrio.Location = New System.Drawing.Point(1020, 30)
        Me.cbNeuPrio.Name = "cbNeuPrio"
        Me.cbNeuPrio.Size = New System.Drawing.Size(288, 28)
        Me.cbNeuPrio.TabIndex = 37
        '
        'cbPrio
        '
        Me.cbPrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbPrio.Location = New System.Drawing.Point(895, 30)
        Me.cbPrio.Name = "cbPrio"
        Me.cbPrio.Size = New System.Drawing.Size(288, 28)
        Me.cbPrio.TabIndex = 38
        '
        'btnBearbeitetUpdate
        '
        Me.btnBearbeitetUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBearbeitetUpdate.Location = New System.Drawing.Point(1343, 768)
        Me.btnBearbeitetUpdate.Name = "btnBearbeitetUpdate"
        Me.btnBearbeitetUpdate.Size = New System.Drawing.Size(130, 50)
        Me.btnBearbeitetUpdate.TabIndex = 1
        Me.btnBearbeitetUpdate.Text = "Speichern Update"
        Me.btnBearbeitetUpdate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnmeldenToolStripMenuItem, Me.AbmeldenToolStripMenuItem, Me.BeendenToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1484, 29)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AnmeldenToolStripMenuItem
        '
        Me.AnmeldenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AnmeldenToolStripMenuItem.Name = "AnmeldenToolStripMenuItem"
        Me.AnmeldenToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.AnmeldenToolStripMenuItem.Text = "Anmelden"
        '
        'AbmeldenToolStripMenuItem
        '
        Me.AbmeldenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AbmeldenToolStripMenuItem.Name = "AbmeldenToolStripMenuItem"
        Me.AbmeldenToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.AbmeldenToolStripMenuItem.Text = "Abmelden"
        Me.AbmeldenToolStripMenuItem.Visible = False
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(82, 25)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(196, 25)
        Me.InfoToolStripMenuItem.Text = "Programminformationen"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslInfo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 886)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1484, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tslInfo
        '
        Me.tslInfo.Name = "tslInfo"
        Me.tslInfo.Size = New System.Drawing.Size(102, 22)
        Me.tslInfo.Text = "Nicht angemeldet"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpUebersicht)
        Me.TabControl1.Controls.Add(Me.tpBearbeiten)
        Me.TabControl1.Controls.Add(Me.tpAufgabeErstellen)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1484, 857)
        Me.TabControl1.TabIndex = 18
        '
        'tpUebersicht
        '
        Me.tpUebersicht.BackColor = System.Drawing.Color.DarkGray
        Me.tpUebersicht.Controls.Add(Me.btnFilter)
        Me.tpUebersicht.Controls.Add(Me.btnAktualisieren)
        Me.tpUebersicht.Controls.Add(Me.dgvUebersicht)
        Me.tpUebersicht.Location = New System.Drawing.Point(4, 29)
        Me.tpUebersicht.Name = "tpUebersicht"
        Me.tpUebersicht.Padding = New System.Windows.Forms.Padding(3)
        Me.tpUebersicht.Size = New System.Drawing.Size(1476, 824)
        Me.tpUebersicht.TabIndex = 0
        Me.tpUebersicht.Text = "Übersicht"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(142, 6)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(130, 50)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnAktualisieren
        '
        Me.btnAktualisieren.Location = New System.Drawing.Point(6, 6)
        Me.btnAktualisieren.Name = "btnAktualisieren"
        Me.btnAktualisieren.Size = New System.Drawing.Size(130, 50)
        Me.btnAktualisieren.TabIndex = 1
        Me.btnAktualisieren.Text = "Aktualisieren"
        Me.btnAktualisieren.UseVisualStyleBackColor = True
        '
        'dgvUebersicht
        '
        Me.dgvUebersicht.AllowUserToAddRows = False
        Me.dgvUebersicht.AllowUserToDeleteRows = False
        Me.dgvUebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUebersicht.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUebersicht.Location = New System.Drawing.Point(6, 62)
        Me.dgvUebersicht.MultiSelect = False
        Me.dgvUebersicht.Name = "dgvUebersicht"
        Me.dgvUebersicht.ReadOnly = True
        Me.dgvUebersicht.Size = New System.Drawing.Size(1462, 712)
        Me.dgvUebersicht.TabIndex = 0
        '
        'tpBearbeiten
        '
        Me.tpBearbeiten.BackColor = System.Drawing.Color.DarkGray
        Me.tpBearbeiten.Controls.Add(Me.Label9)
        Me.tpBearbeiten.Controls.Add(Me.tbLetzterStand)
        Me.tpBearbeiten.Controls.Add(Me.lblID)
        Me.tpBearbeiten.Controls.Add(Me.cbBearbeiter)
        Me.tpBearbeiten.Controls.Add(Me.cbKategorie)
        Me.tpBearbeiten.Controls.Add(Me.cbPrio)
        Me.tpBearbeiten.Controls.Add(Me.btnAbbrechenBearbeiten)
        Me.tpBearbeiten.Controls.Add(Me.btnStaende)
        Me.tpBearbeiten.Controls.Add(Me.tbBeschreibung)
        Me.tpBearbeiten.Controls.Add(Me.btnBearbeitetUpdate)
        Me.tpBearbeiten.Controls.Add(Me.tbTitel)
        Me.tpBearbeiten.Controls.Add(Me.Label4)
        Me.tpBearbeiten.Controls.Add(Me.Label1)
        Me.tpBearbeiten.Controls.Add(Me.tbStand)
        Me.tpBearbeiten.Controls.Add(Me.Label2)
        Me.tpBearbeiten.Controls.Add(Me.cbStatus)
        Me.tpBearbeiten.Controls.Add(Me.tbTicketNr)
        Me.tpBearbeiten.Controls.Add(Me.Label3)
        Me.tpBearbeiten.Location = New System.Drawing.Point(4, 29)
        Me.tpBearbeiten.Name = "tpBearbeiten"
        Me.tpBearbeiten.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBearbeiten.Size = New System.Drawing.Size(1476, 824)
        Me.tpBearbeiten.TabIndex = 1
        Me.tpBearbeiten.Text = "Bearbeiten"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(692, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Letzter Stand"
        '
        'tbLetzterStand
        '
        Me.tbLetzterStand.Enabled = False
        Me.tbLetzterStand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbLetzterStand.Location = New System.Drawing.Point(692, 150)
        Me.tbLetzterStand.Multiline = True
        Me.tbLetzterStand.Name = "tbLetzterStand"
        Me.tbLetzterStand.Size = New System.Drawing.Size(650, 250)
        Me.tbLetzterStand.TabIndex = 42
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(8, 798)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 20)
        Me.lblID.TabIndex = 41
        Me.lblID.Text = "ID"
        '
        'cbBearbeiter
        '
        Me.cbBearbeiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBearbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBearbeiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbBearbeiter.Location = New System.Drawing.Point(691, 88)
        Me.cbBearbeiter.Name = "cbBearbeiter"
        Me.cbBearbeiter.Size = New System.Drawing.Size(189, 28)
        Me.cbBearbeiter.TabIndex = 40
        '
        'cbKategorie
        '
        Me.cbKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbKategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbKategorie.Location = New System.Drawing.Point(895, 88)
        Me.cbKategorie.Name = "cbKategorie"
        Me.cbKategorie.Size = New System.Drawing.Size(288, 28)
        Me.cbKategorie.TabIndex = 39
        '
        'btnAbbrechenBearbeiten
        '
        Me.btnAbbrechenBearbeiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechenBearbeiten.Location = New System.Drawing.Point(1207, 768)
        Me.btnAbbrechenBearbeiten.Name = "btnAbbrechenBearbeiten"
        Me.btnAbbrechenBearbeiten.Size = New System.Drawing.Size(130, 50)
        Me.btnAbbrechenBearbeiten.TabIndex = 2
        Me.btnAbbrechenBearbeiten.Text = "Abbrechen"
        Me.btnAbbrechenBearbeiten.UseVisualStyleBackColor = True
        '
        'btnStaende
        '
        Me.btnStaende.Location = New System.Drawing.Point(8, 689)
        Me.btnStaende.Name = "btnStaende"
        Me.btnStaende.Size = New System.Drawing.Size(130, 50)
        Me.btnStaende.TabIndex = 24
        Me.btnStaende.Text = "Alle Stände anzeigen"
        Me.btnStaende.UseVisualStyleBackColor = True
        '
        'tbBeschreibung
        '
        Me.tbBeschreibung.Enabled = False
        Me.tbBeschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBeschreibung.Location = New System.Drawing.Point(8, 150)
        Me.tbBeschreibung.Multiline = True
        Me.tbBeschreibung.Name = "tbBeschreibung"
        Me.tbBeschreibung.Size = New System.Drawing.Size(650, 250)
        Me.tbBeschreibung.TabIndex = 16
        '
        'tbTitel
        '
        Me.tbTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbTitel.Location = New System.Drawing.Point(6, 30)
        Me.tbTitel.Name = "tbTitel"
        Me.tbTitel.Size = New System.Drawing.Size(652, 26)
        Me.tbTitel.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(8, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Aktueller Stand"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Titel"
        '
        'tbStand
        '
        Me.tbStand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbStand.Location = New System.Drawing.Point(8, 433)
        Me.tbStand.Multiline = True
        Me.tbStand.Name = "tbStand"
        Me.tbStand.Size = New System.Drawing.Size(650, 250)
        Me.tbStand.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Beschreibung"
        '
        'tbTicketNr
        '
        Me.tbTicketNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbTicketNr.Location = New System.Drawing.Point(8, 94)
        Me.tbTicketNr.Name = "tbTicketNr"
        Me.tbTicketNr.Size = New System.Drawing.Size(263, 26)
        Me.tbTicketNr.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Ticket#"
        '
        'tpAufgabeErstellen
        '
        Me.tpAufgabeErstellen.BackColor = System.Drawing.Color.DarkGray
        Me.tpAufgabeErstellen.Controls.Add(Me.cbNeuBearbeiter)
        Me.tpAufgabeErstellen.Controls.Add(Me.cbNeuKategorie)
        Me.tpAufgabeErstellen.Controls.Add(Me.cbNeuPrio)
        Me.tpAufgabeErstellen.Controls.Add(Me.btnNeuInsert)
        Me.tpAufgabeErstellen.Controls.Add(Me.tbNeuBeschreibung)
        Me.tpAufgabeErstellen.Controls.Add(Me.tbNeuTitel)
        Me.tpAufgabeErstellen.Controls.Add(Me.Label6)
        Me.tpAufgabeErstellen.Controls.Add(Me.Label7)
        Me.tpAufgabeErstellen.Controls.Add(Me.cbNeuStatus)
        Me.tpAufgabeErstellen.Controls.Add(Me.tbNeuTicketNr)
        Me.tpAufgabeErstellen.Controls.Add(Me.Label8)
        Me.tpAufgabeErstellen.Location = New System.Drawing.Point(4, 29)
        Me.tpAufgabeErstellen.Name = "tpAufgabeErstellen"
        Me.tpAufgabeErstellen.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAufgabeErstellen.Size = New System.Drawing.Size(1476, 824)
        Me.tpAufgabeErstellen.TabIndex = 2
        Me.tpAufgabeErstellen.Text = "Aufgabe erstellen"
        '
        'cbNeuBearbeiter
        '
        Me.cbNeuBearbeiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuBearbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbNeuBearbeiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuBearbeiter.Location = New System.Drawing.Point(816, 88)
        Me.cbNeuBearbeiter.Name = "cbNeuBearbeiter"
        Me.cbNeuBearbeiter.Size = New System.Drawing.Size(189, 28)
        Me.cbNeuBearbeiter.TabIndex = 41
        '
        'cbNeuKategorie
        '
        Me.cbNeuKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbNeuKategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuKategorie.Location = New System.Drawing.Point(1020, 88)
        Me.cbNeuKategorie.Name = "cbNeuKategorie"
        Me.cbNeuKategorie.Size = New System.Drawing.Size(288, 28)
        Me.cbNeuKategorie.TabIndex = 40
        '
        'btnNeuInsert
        '
        Me.btnNeuInsert.Location = New System.Drawing.Point(1088, 625)
        Me.btnNeuInsert.Name = "btnNeuInsert"
        Me.btnNeuInsert.Size = New System.Drawing.Size(130, 50)
        Me.btnNeuInsert.TabIndex = 36
        Me.btnNeuInsert.Text = "Speichern Insert"
        Me.btnNeuInsert.UseVisualStyleBackColor = True
        '
        'tbNeuBeschreibung
        '
        Me.tbNeuBeschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuBeschreibung.Location = New System.Drawing.Point(6, 88)
        Me.tbNeuBeschreibung.Multiline = True
        Me.tbNeuBeschreibung.Name = "tbNeuBeschreibung"
        Me.tbNeuBeschreibung.Size = New System.Drawing.Size(515, 232)
        Me.tbNeuBeschreibung.TabIndex = 28
        '
        'tbNeuTitel
        '
        Me.tbNeuTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuTitel.Location = New System.Drawing.Point(6, 30)
        Me.tbNeuTitel.Name = "tbNeuTitel"
        Me.tbNeuTitel.Size = New System.Drawing.Size(515, 26)
        Me.tbNeuTitel.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Titel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Beschreibung"
        '
        'tbNeuTicketNr
        '
        Me.tbNeuTicketNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuTicketNr.Location = New System.Drawing.Point(536, 30)
        Me.tbNeuTicketNr.Name = "tbNeuTicketNr"
        Me.tbNeuTicketNr.Size = New System.Drawing.Size(263, 26)
        Me.tbNeuTicketNr.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(532, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Ticket#"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 911)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpUebersicht.ResumeLayout(False)
        CType(Me.dgvUebersicht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBearbeiten.ResumeLayout(False)
        Me.tpBearbeiten.PerformLayout()
        Me.tpAufgabeErstellen.ResumeLayout(False)
        Me.tpAufgabeErstellen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBearbeitetUpdate As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AnmeldenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbmeldenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tslInfo As ToolStripLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpUebersicht As TabPage
    Friend WithEvents dgvUebersicht As DataGridView
    Friend WithEvents tpBearbeiten As TabPage
    Friend WithEvents tbBeschreibung As TextBox
    Friend WithEvents tbTitel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbStand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTicketNr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStaende As Button
    Friend WithEvents tpAufgabeErstellen As TabPage
    Friend WithEvents btnNeuInsert As Button
    Friend WithEvents tbNeuBeschreibung As TextBox
    Friend WithEvents tbNeuTitel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbNeuTicketNr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAbbrechenBearbeiten As Button
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbPrio As ComboBox
    Friend WithEvents cbNeuStatus As ComboBox
    Friend WithEvents cbNeuPrio As ComboBox
    Friend WithEvents cbKategorie As ComboBox
    Friend WithEvents cbNeuKategorie As ComboBox
    Friend WithEvents cbBearbeiter As ComboBox
    Friend WithEvents cbNeuBearbeiter As ComboBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnAktualisieren As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbLetzterStand As TextBox
End Class
