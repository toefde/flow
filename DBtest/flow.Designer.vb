<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class flow
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbNeuStatus = New System.Windows.Forms.ComboBox()
        Me.cbNeuPrio = New System.Windows.Forms.ComboBox()
        Me.cbPrio = New System.Windows.Forms.ComboBox()
        Me.btnBearbeitetUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerwaltungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslInfo = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpUebersicht = New System.Windows.Forms.TabPage()
        Me.dataPanel = New System.Windows.Forms.Panel()
        Me.dgvUebersicht = New System.Windows.Forms.DataGridView()
        Me.filterPanel = New System.Windows.Forms.Panel()
        Me.btnAktualisieren = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.tpBearbeiten = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAbbrechenErstellen = New System.Windows.Forms.Button()
        Me.cbNeuBearbeiter = New System.Windows.Forms.ComboBox()
        Me.cbNeuKategorie = New System.Windows.Forms.ComboBox()
        Me.btnNeuInsert = New System.Windows.Forms.Button()
        Me.tbNeuBeschreibung = New System.Windows.Forms.TextBox()
        Me.tbNeuTitel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbNeuTicketNr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpUebersicht.SuspendLayout()
        Me.dataPanel.SuspendLayout()
        CType(Me.dgvUebersicht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filterPanel.SuspendLayout()
        Me.tpBearbeiten.SuspendLayout()
        Me.tpAufgabeErstellen.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbStatus.ForeColor = System.Drawing.Color.White
        Me.cbStatus.Location = New System.Drawing.Point(691, 30)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(189, 28)
        Me.cbStatus.TabIndex = 21
        '
        'cbNeuStatus
        '
        Me.cbNeuStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbNeuStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNeuStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuStatus.ForeColor = System.Drawing.Color.White
        Me.cbNeuStatus.Location = New System.Drawing.Point(691, 30)
        Me.cbNeuStatus.Name = "cbNeuStatus"
        Me.cbNeuStatus.Size = New System.Drawing.Size(189, 28)
        Me.cbNeuStatus.TabIndex = 33
        '
        'cbNeuPrio
        '
        Me.cbNeuPrio.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbNeuPrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuPrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNeuPrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuPrio.ForeColor = System.Drawing.Color.White
        Me.cbNeuPrio.Location = New System.Drawing.Point(895, 30)
        Me.cbNeuPrio.Name = "cbNeuPrio"
        Me.cbNeuPrio.Size = New System.Drawing.Size(288, 28)
        Me.cbNeuPrio.TabIndex = 37
        '
        'cbPrio
        '
        Me.cbPrio.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbPrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbPrio.ForeColor = System.Drawing.Color.White
        Me.cbPrio.Location = New System.Drawing.Point(895, 30)
        Me.cbPrio.Name = "cbPrio"
        Me.cbPrio.Size = New System.Drawing.Size(288, 28)
        Me.cbPrio.TabIndex = 38
        '
        'btnBearbeitetUpdate
        '
        Me.btnBearbeitetUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBearbeitetUpdate.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBearbeitetUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBearbeitetUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnBearbeitetUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBearbeitetUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBearbeitetUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnBearbeitetUpdate.Location = New System.Drawing.Point(1340, 768)
        Me.btnBearbeitetUpdate.Name = "btnBearbeitetUpdate"
        Me.btnBearbeitetUpdate.Size = New System.Drawing.Size(130, 50)
        Me.btnBearbeitetUpdate.TabIndex = 1
        Me.btnBearbeitetUpdate.Text = "Speichern"
        Me.btnBearbeitetUpdate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbmeldenToolStripMenuItem, Me.AnmeldenToolStripMenuItem, Me.VerwaltungToolStripMenuItem, Me.BeendenToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1484, 29)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbmeldenToolStripMenuItem
        '
        Me.AbmeldenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AbmeldenToolStripMenuItem.Name = "AbmeldenToolStripMenuItem"
        Me.AbmeldenToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.AbmeldenToolStripMenuItem.Text = "Abmelden"
        Me.AbmeldenToolStripMenuItem.Visible = False
        '
        'AnmeldenToolStripMenuItem
        '
        Me.AnmeldenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AnmeldenToolStripMenuItem.Name = "AnmeldenToolStripMenuItem"
        Me.AnmeldenToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.AnmeldenToolStripMenuItem.Text = "Anmelden"
        '
        'VerwaltungToolStripMenuItem
        '
        Me.VerwaltungToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.VerwaltungToolStripMenuItem.Name = "VerwaltungToolStripMenuItem"
        Me.VerwaltungToolStripMenuItem.Size = New System.Drawing.Size(188, 25)
        Me.VerwaltungToolStripMenuItem.Text = "Stammdatenverwaltung"
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
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
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
        Me.tpUebersicht.Controls.Add(Me.dataPanel)
        Me.tpUebersicht.Controls.Add(Me.filterPanel)
        Me.tpUebersicht.Location = New System.Drawing.Point(4, 29)
        Me.tpUebersicht.Name = "tpUebersicht"
        Me.tpUebersicht.Padding = New System.Windows.Forms.Padding(3)
        Me.tpUebersicht.Size = New System.Drawing.Size(1476, 824)
        Me.tpUebersicht.TabIndex = 0
        Me.tpUebersicht.Text = "Übersicht"
        '
        'dataPanel
        '
        Me.dataPanel.Controls.Add(Me.dgvUebersicht)
        Me.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataPanel.Location = New System.Drawing.Point(3, 63)
        Me.dataPanel.Name = "dataPanel"
        Me.dataPanel.Size = New System.Drawing.Size(1470, 758)
        Me.dataPanel.TabIndex = 4
        '
        'dgvUebersicht
        '
        Me.dgvUebersicht.AllowUserToAddRows = False
        Me.dgvUebersicht.AllowUserToDeleteRows = False
        Me.dgvUebersicht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUebersicht.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvUebersicht.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUebersicht.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUebersicht.ColumnHeadersHeight = 30
        Me.dgvUebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUebersicht.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUebersicht.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUebersicht.EnableHeadersVisualStyles = False
        Me.dgvUebersicht.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvUebersicht.Location = New System.Drawing.Point(0, 0)
        Me.dgvUebersicht.MultiSelect = False
        Me.dgvUebersicht.Name = "dgvUebersicht"
        Me.dgvUebersicht.ReadOnly = True
        Me.dgvUebersicht.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUebersicht.RowHeadersWidth = 30
        Me.dgvUebersicht.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUebersicht.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUebersicht.RowTemplate.Height = 30
        Me.dgvUebersicht.Size = New System.Drawing.Size(1470, 758)
        Me.dgvUebersicht.TabIndex = 0
        '
        'filterPanel
        '
        Me.filterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.filterPanel.Controls.Add(Me.btnAktualisieren)
        Me.filterPanel.Controls.Add(Me.btnFilter)
        Me.filterPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.filterPanel.Location = New System.Drawing.Point(3, 3)
        Me.filterPanel.Name = "filterPanel"
        Me.filterPanel.Size = New System.Drawing.Size(1470, 60)
        Me.filterPanel.TabIndex = 3
        '
        'btnAktualisieren
        '
        Me.btnAktualisieren.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAktualisieren.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAktualisieren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAktualisieren.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAktualisieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAktualisieren.ForeColor = System.Drawing.Color.Black
        Me.btnAktualisieren.Location = New System.Drawing.Point(3, 3)
        Me.btnAktualisieren.Name = "btnAktualisieren"
        Me.btnAktualisieren.Size = New System.Drawing.Size(130, 50)
        Me.btnAktualisieren.TabIndex = 1
        Me.btnAktualisieren.Text = "Aktualisieren"
        Me.btnAktualisieren.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.ForeColor = System.Drawing.Color.Black
        Me.btnFilter.Location = New System.Drawing.Point(139, 3)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(130, 50)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'tpBearbeiten
        '
        Me.tpBearbeiten.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpBearbeiten.Controls.Add(Me.Label12)
        Me.tpBearbeiten.Controls.Add(Me.Label11)
        Me.tpBearbeiten.Controls.Add(Me.Label10)
        Me.tpBearbeiten.Controls.Add(Me.Label5)
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(900, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 20)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Kategorie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(900, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Priorität"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(692, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Bearbeiter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(692, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Status"
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
        Me.tbLetzterStand.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbLetzterStand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbLetzterStand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbLetzterStand.ForeColor = System.Drawing.Color.White
        Me.tbLetzterStand.Location = New System.Drawing.Point(692, 150)
        Me.tbLetzterStand.Multiline = True
        Me.tbLetzterStand.Name = "tbLetzterStand"
        Me.tbLetzterStand.ReadOnly = True
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
        Me.cbBearbeiter.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbBearbeiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBearbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBearbeiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbBearbeiter.ForeColor = System.Drawing.Color.White
        Me.cbBearbeiter.Location = New System.Drawing.Point(691, 88)
        Me.cbBearbeiter.Name = "cbBearbeiter"
        Me.cbBearbeiter.Size = New System.Drawing.Size(189, 28)
        Me.cbBearbeiter.TabIndex = 40
        '
        'cbKategorie
        '
        Me.cbKategorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbKategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbKategorie.ForeColor = System.Drawing.Color.White
        Me.cbKategorie.Location = New System.Drawing.Point(895, 88)
        Me.cbKategorie.Name = "cbKategorie"
        Me.cbKategorie.Size = New System.Drawing.Size(288, 28)
        Me.cbKategorie.TabIndex = 39
        '
        'btnAbbrechenBearbeiten
        '
        Me.btnAbbrechenBearbeiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechenBearbeiten.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAbbrechenBearbeiten.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAbbrechenBearbeiten.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAbbrechenBearbeiten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAbbrechenBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbbrechenBearbeiten.ForeColor = System.Drawing.Color.Black
        Me.btnAbbrechenBearbeiten.Location = New System.Drawing.Point(1204, 768)
        Me.btnAbbrechenBearbeiten.Name = "btnAbbrechenBearbeiten"
        Me.btnAbbrechenBearbeiten.Size = New System.Drawing.Size(130, 50)
        Me.btnAbbrechenBearbeiten.TabIndex = 2
        Me.btnAbbrechenBearbeiten.Text = "Abbrechen"
        Me.btnAbbrechenBearbeiten.UseVisualStyleBackColor = True
        '
        'btnStaende
        '
        Me.btnStaende.BackColor = System.Drawing.Color.Gainsboro
        Me.btnStaende.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnStaende.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnStaende.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnStaende.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaende.ForeColor = System.Drawing.Color.Black
        Me.btnStaende.Location = New System.Drawing.Point(8, 689)
        Me.btnStaende.Name = "btnStaende"
        Me.btnStaende.Size = New System.Drawing.Size(130, 50)
        Me.btnStaende.TabIndex = 24
        Me.btnStaende.Text = "Alle Stände anzeigen"
        Me.btnStaende.UseVisualStyleBackColor = True
        '
        'tbBeschreibung
        '
        Me.tbBeschreibung.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBeschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBeschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBeschreibung.ForeColor = System.Drawing.Color.White
        Me.tbBeschreibung.Location = New System.Drawing.Point(7, 150)
        Me.tbBeschreibung.Multiline = True
        Me.tbBeschreibung.Name = "tbBeschreibung"
        Me.tbBeschreibung.Size = New System.Drawing.Size(650, 250)
        Me.tbBeschreibung.TabIndex = 16
        '
        'tbTitel
        '
        Me.tbTitel.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbTitel.ForeColor = System.Drawing.Color.White
        Me.tbTitel.Location = New System.Drawing.Point(7, 30)
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
        Me.Label4.Size = New System.Drawing.Size(205, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Aktuellen Stand hinzufügen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Titel"
        '
        'tbStand
        '
        Me.tbStand.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbStand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbStand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbStand.ForeColor = System.Drawing.Color.White
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
        Me.Label2.Location = New System.Drawing.Point(7, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Beschreibung"
        '
        'tbTicketNr
        '
        Me.tbTicketNr.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbTicketNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTicketNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbTicketNr.ForeColor = System.Drawing.Color.White
        Me.tbTicketNr.Location = New System.Drawing.Point(7, 94)
        Me.tbTicketNr.Name = "tbTicketNr"
        Me.tbTicketNr.Size = New System.Drawing.Size(263, 26)
        Me.tbTicketNr.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Ticket#"
        '
        'tpAufgabeErstellen
        '
        Me.tpAufgabeErstellen.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpAufgabeErstellen.Controls.Add(Me.Label13)
        Me.tpAufgabeErstellen.Controls.Add(Me.Label14)
        Me.tpAufgabeErstellen.Controls.Add(Me.Label15)
        Me.tpAufgabeErstellen.Controls.Add(Me.Label16)
        Me.tpAufgabeErstellen.Controls.Add(Me.btnAbbrechenErstellen)
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(900, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Kategorie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(900, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 20)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Priorität"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(692, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 20)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Bearbeiter"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(692, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Status"
        '
        'btnAbbrechenErstellen
        '
        Me.btnAbbrechenErstellen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechenErstellen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAbbrechenErstellen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAbbrechenErstellen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAbbrechenErstellen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAbbrechenErstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbbrechenErstellen.ForeColor = System.Drawing.Color.Black
        Me.btnAbbrechenErstellen.Location = New System.Drawing.Point(1204, 768)
        Me.btnAbbrechenErstellen.Name = "btnAbbrechenErstellen"
        Me.btnAbbrechenErstellen.Size = New System.Drawing.Size(130, 50)
        Me.btnAbbrechenErstellen.TabIndex = 42
        Me.btnAbbrechenErstellen.Text = "Abbrechen"
        Me.btnAbbrechenErstellen.UseVisualStyleBackColor = True
        '
        'cbNeuBearbeiter
        '
        Me.cbNeuBearbeiter.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbNeuBearbeiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuBearbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNeuBearbeiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuBearbeiter.ForeColor = System.Drawing.Color.White
        Me.cbNeuBearbeiter.Location = New System.Drawing.Point(691, 88)
        Me.cbNeuBearbeiter.Name = "cbNeuBearbeiter"
        Me.cbNeuBearbeiter.Size = New System.Drawing.Size(189, 28)
        Me.cbNeuBearbeiter.TabIndex = 41
        '
        'cbNeuKategorie
        '
        Me.cbNeuKategorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbNeuKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNeuKategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbNeuKategorie.ForeColor = System.Drawing.Color.White
        Me.cbNeuKategorie.Location = New System.Drawing.Point(895, 88)
        Me.cbNeuKategorie.Name = "cbNeuKategorie"
        Me.cbNeuKategorie.Size = New System.Drawing.Size(288, 28)
        Me.cbNeuKategorie.TabIndex = 40
        '
        'btnNeuInsert
        '
        Me.btnNeuInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNeuInsert.BackColor = System.Drawing.Color.Gainsboro
        Me.btnNeuInsert.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNeuInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnNeuInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnNeuInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNeuInsert.ForeColor = System.Drawing.Color.Black
        Me.btnNeuInsert.Location = New System.Drawing.Point(1340, 768)
        Me.btnNeuInsert.Name = "btnNeuInsert"
        Me.btnNeuInsert.Size = New System.Drawing.Size(130, 50)
        Me.btnNeuInsert.TabIndex = 36
        Me.btnNeuInsert.Text = "Erstellen"
        Me.btnNeuInsert.UseVisualStyleBackColor = True
        '
        'tbNeuBeschreibung
        '
        Me.tbNeuBeschreibung.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbNeuBeschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNeuBeschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuBeschreibung.ForeColor = System.Drawing.Color.White
        Me.tbNeuBeschreibung.Location = New System.Drawing.Point(7, 150)
        Me.tbNeuBeschreibung.Multiline = True
        Me.tbNeuBeschreibung.Name = "tbNeuBeschreibung"
        Me.tbNeuBeschreibung.Size = New System.Drawing.Size(650, 250)
        Me.tbNeuBeschreibung.TabIndex = 28
        '
        'tbNeuTitel
        '
        Me.tbNeuTitel.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbNeuTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNeuTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuTitel.ForeColor = System.Drawing.Color.White
        Me.tbNeuTitel.Location = New System.Drawing.Point(7, 30)
        Me.tbNeuTitel.Name = "tbNeuTitel"
        Me.tbNeuTitel.Size = New System.Drawing.Size(652, 26)
        Me.tbNeuTitel.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(7, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Titel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(7, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Beschreibung"
        '
        'tbNeuTicketNr
        '
        Me.tbNeuTicketNr.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbNeuTicketNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNeuTicketNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuTicketNr.ForeColor = System.Drawing.Color.White
        Me.tbNeuTicketNr.Location = New System.Drawing.Point(7, 94)
        Me.tbNeuTicketNr.Name = "tbNeuTicketNr"
        Me.tbNeuTicketNr.Size = New System.Drawing.Size(263, 26)
        Me.tbNeuTicketNr.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(7, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Ticket#"
        '
        'flow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1484, 911)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "flow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpUebersicht.ResumeLayout(False)
        Me.dataPanel.ResumeLayout(False)
        CType(Me.dgvUebersicht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filterPanel.ResumeLayout(False)
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
    Friend WithEvents btnAktualisieren As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbLetzterStand As TextBox
    Friend WithEvents VerwaltungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAbbrechenErstellen As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dataPanel As Panel
    Friend WithEvents filterPanel As Panel
    Friend WithEvents lblID As Label
End Class
