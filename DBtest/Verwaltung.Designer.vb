<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verwaltung
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBenutzerverwaltung = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbBVrechte = New System.Windows.Forms.ComboBox()
        Me.tbBVbenutzer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbBVpasswort = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbBVvorname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbBVnachname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBveraendern = New System.Windows.Forms.Button()
        Me.btnBvSchliessen = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBArechte = New System.Windows.Forms.ComboBox()
        Me.tbBAbenutzer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBApasswort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBAvorname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbBAnachname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBanlegen = New System.Windows.Forms.Button()
        Me.btnBloeschen = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpBenutzerverwaltung = New System.Windows.Forms.TabPage()
        Me.tpStatusverwaltung = New System.Windows.Forms.TabPage()
        Me.btnSvSchliessen = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSloeschen = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbSVstatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSveraendern = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbSAstatus = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSanlegen = New System.Windows.Forms.Button()
        Me.dgvStatusverwaltung = New System.Windows.Forms.DataGridView()
        Me.tpKategorienverwaltung = New System.Windows.Forms.TabPage()
        Me.btnKvSchliessen = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnKloeschen = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbKVkategorie = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnKveraendern = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.tbKAkategorie = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnKanlegen = New System.Windows.Forms.Button()
        Me.dgvKategorienverwaltung = New System.Windows.Forms.DataGridView()
        Me.tpPrioritätenverwaltung = New System.Windows.Forms.TabPage()
        Me.btnPvSchliessen = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnPloeschen = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.tbPVprioritaet = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnPveraendern = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.tbPAprioritaet = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnPanlegen = New System.Windows.Forms.Button()
        Me.dgvPrioritaetenverwaltung = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBenutzerverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpBenutzerverwaltung.SuspendLayout()
        Me.tpStatusverwaltung.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvStatusverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpKategorienverwaltung.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvKategorienverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPrioritätenverwaltung.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.dgvPrioritaetenverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBenutzerverwaltung
        '
        Me.dgvBenutzerverwaltung.AllowUserToAddRows = False
        Me.dgvBenutzerverwaltung.AllowUserToDeleteRows = False
        Me.dgvBenutzerverwaltung.AllowUserToResizeRows = False
        Me.dgvBenutzerverwaltung.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvBenutzerverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBenutzerverwaltung.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvBenutzerverwaltung.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvBenutzerverwaltung.Location = New System.Drawing.Point(6, 6)
        Me.dgvBenutzerverwaltung.MultiSelect = False
        Me.dgvBenutzerverwaltung.Name = "dgvBenutzerverwaltung"
        Me.dgvBenutzerverwaltung.ReadOnly = True
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBenutzerverwaltung.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvBenutzerverwaltung.RowTemplate.Height = 30
        Me.dgvBenutzerverwaltung.Size = New System.Drawing.Size(962, 309)
        Me.dgvBenutzerverwaltung.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbBVrechte)
        Me.GroupBox2.Controls.Add(Me.tbBVbenutzer)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbBVpasswort)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbBVvorname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbBVnachname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnBveraendern)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(412, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Benutzer ändern"
        '
        'cbBVrechte
        '
        Me.cbBVrechte.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbBVrechte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBVrechte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBVrechte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbBVrechte.ForeColor = System.Drawing.Color.White
        Me.cbBVrechte.Items.AddRange(New Object() {"USER", "ADMIN"})
        Me.cbBVrechte.Location = New System.Drawing.Point(10, 244)
        Me.cbBVrechte.Name = "cbBVrechte"
        Me.cbBVrechte.Size = New System.Drawing.Size(248, 28)
        Me.cbBVrechte.TabIndex = 22
        '
        'tbBVbenutzer
        '
        Me.tbBVbenutzer.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBVbenutzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBVbenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBVbenutzer.ForeColor = System.Drawing.Color.White
        Me.tbBVbenutzer.Location = New System.Drawing.Point(10, 45)
        Me.tbBVbenutzer.Name = "tbBVbenutzer"
        Me.tbBVbenutzer.Size = New System.Drawing.Size(384, 26)
        Me.tbBVbenutzer.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Passwort"
        '
        'tbBVpasswort
        '
        Me.tbBVpasswort.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBVpasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBVpasswort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBVpasswort.ForeColor = System.Drawing.Color.White
        Me.tbBVpasswort.Location = New System.Drawing.Point(10, 97)
        Me.tbBVpasswort.Name = "tbBVpasswort"
        Me.tbBVpasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.tbBVpasswort.Size = New System.Drawing.Size(384, 26)
        Me.tbBVpasswort.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Benutzername"
        '
        'tbBVvorname
        '
        Me.tbBVvorname.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBVvorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBVvorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBVvorname.ForeColor = System.Drawing.Color.White
        Me.tbBVvorname.Location = New System.Drawing.Point(10, 149)
        Me.tbBVvorname.Name = "tbBVvorname"
        Me.tbBVvorname.Size = New System.Drawing.Size(384, 26)
        Me.tbBVvorname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nachname"
        '
        'tbBVnachname
        '
        Me.tbBVnachname.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBVnachname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBVnachname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBVnachname.ForeColor = System.Drawing.Color.White
        Me.tbBVnachname.Location = New System.Drawing.Point(10, 201)
        Me.tbBVnachname.Name = "tbBVnachname"
        Me.tbBVnachname.Size = New System.Drawing.Size(384, 26)
        Me.tbBVnachname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Vorname"
        '
        'btnBveraendern
        '
        Me.btnBveraendern.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBveraendern.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBveraendern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnBveraendern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBveraendern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBveraendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBveraendern.ForeColor = System.Drawing.Color.Black
        Me.btnBveraendern.Location = New System.Drawing.Point(264, 244)
        Me.btnBveraendern.Name = "btnBveraendern"
        Me.btnBveraendern.Size = New System.Drawing.Size(130, 50)
        Me.btnBveraendern.TabIndex = 3
        Me.btnBveraendern.Text = "Speichern"
        Me.btnBveraendern.UseVisualStyleBackColor = True
        '
        'btnBvSchliessen
        '
        Me.btnBvSchliessen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBvSchliessen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBvSchliessen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBvSchliessen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnBvSchliessen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBvSchliessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBvSchliessen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBvSchliessen.ForeColor = System.Drawing.Color.Black
        Me.btnBvSchliessen.Location = New System.Drawing.Point(824, 565)
        Me.btnBvSchliessen.Name = "btnBvSchliessen"
        Me.btnBvSchliessen.Size = New System.Drawing.Size(130, 50)
        Me.btnBvSchliessen.TabIndex = 7
        Me.btnBvSchliessen.Text = "Schließen"
        Me.btnBvSchliessen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbBArechte)
        Me.GroupBox1.Controls.Add(Me.tbBAbenutzer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbBApasswort)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbBAvorname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbBAnachname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnBanlegen)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Neuen Benutzer anlegen"
        '
        'cbBArechte
        '
        Me.cbBArechte.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.cbBArechte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBArechte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBArechte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbBArechte.ForeColor = System.Drawing.Color.White
        Me.cbBArechte.Items.AddRange(New Object() {"USER", "ADMIN"})
        Me.cbBArechte.Location = New System.Drawing.Point(10, 244)
        Me.cbBArechte.Name = "cbBArechte"
        Me.cbBArechte.Size = New System.Drawing.Size(248, 28)
        Me.cbBArechte.TabIndex = 22
        '
        'tbBAbenutzer
        '
        Me.tbBAbenutzer.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBAbenutzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBAbenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBAbenutzer.ForeColor = System.Drawing.Color.White
        Me.tbBAbenutzer.Location = New System.Drawing.Point(10, 45)
        Me.tbBAbenutzer.Name = "tbBAbenutzer"
        Me.tbBAbenutzer.Size = New System.Drawing.Size(384, 26)
        Me.tbBAbenutzer.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Passwort"
        '
        'tbBApasswort
        '
        Me.tbBApasswort.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBApasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBApasswort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBApasswort.ForeColor = System.Drawing.Color.White
        Me.tbBApasswort.Location = New System.Drawing.Point(10, 97)
        Me.tbBApasswort.Name = "tbBApasswort"
        Me.tbBApasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.tbBApasswort.Size = New System.Drawing.Size(384, 26)
        Me.tbBApasswort.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Benutzername"
        '
        'tbBAvorname
        '
        Me.tbBAvorname.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBAvorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBAvorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBAvorname.ForeColor = System.Drawing.Color.White
        Me.tbBAvorname.Location = New System.Drawing.Point(10, 149)
        Me.tbBAvorname.Name = "tbBAvorname"
        Me.tbBAvorname.Size = New System.Drawing.Size(384, 26)
        Me.tbBAvorname.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nachname"
        '
        'tbBAnachname
        '
        Me.tbBAnachname.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbBAnachname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBAnachname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbBAnachname.ForeColor = System.Drawing.Color.White
        Me.tbBAnachname.Location = New System.Drawing.Point(10, 201)
        Me.tbBAnachname.Name = "tbBAnachname"
        Me.tbBAnachname.Size = New System.Drawing.Size(384, 26)
        Me.tbBAnachname.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Vorname"
        '
        'btnBanlegen
        '
        Me.btnBanlegen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBanlegen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBanlegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnBanlegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBanlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanlegen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBanlegen.ForeColor = System.Drawing.Color.Black
        Me.btnBanlegen.Location = New System.Drawing.Point(264, 244)
        Me.btnBanlegen.Name = "btnBanlegen"
        Me.btnBanlegen.Size = New System.Drawing.Size(130, 50)
        Me.btnBanlegen.TabIndex = 3
        Me.btnBanlegen.Text = "Speichern"
        Me.btnBanlegen.UseVisualStyleBackColor = True
        '
        'btnBloeschen
        '
        Me.btnBloeschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBloeschen.BackColor = System.Drawing.Color.IndianRed
        Me.btnBloeschen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBloeschen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnBloeschen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBloeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBloeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBloeschen.ForeColor = System.Drawing.Color.Black
        Me.btnBloeschen.Location = New System.Drawing.Point(6, 25)
        Me.btnBloeschen.Name = "btnBloeschen"
        Me.btnBloeschen.Size = New System.Drawing.Size(130, 74)
        Me.btnBloeschen.TabIndex = 24
        Me.btnBloeschen.Text = "Ausgewählten Benutzer löschen"
        Me.btnBloeschen.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBloeschen)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(818, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 105)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Benutzer löschen"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpBenutzerverwaltung)
        Me.TabControl1.Controls.Add(Me.tpStatusverwaltung)
        Me.TabControl1.Controls.Add(Me.tpKategorienverwaltung)
        Me.TabControl1.Controls.Add(Me.tpPrioritätenverwaltung)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 661)
        Me.TabControl1.TabIndex = 26
        '
        'tpBenutzerverwaltung
        '
        Me.tpBenutzerverwaltung.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpBenutzerverwaltung.Controls.Add(Me.btnBvSchliessen)
        Me.tpBenutzerverwaltung.Controls.Add(Me.dgvBenutzerverwaltung)
        Me.tpBenutzerverwaltung.Controls.Add(Me.GroupBox3)
        Me.tpBenutzerverwaltung.Controls.Add(Me.GroupBox2)
        Me.tpBenutzerverwaltung.Controls.Add(Me.GroupBox1)
        Me.tpBenutzerverwaltung.ForeColor = System.Drawing.Color.White
        Me.tpBenutzerverwaltung.Location = New System.Drawing.Point(4, 29)
        Me.tpBenutzerverwaltung.Name = "tpBenutzerverwaltung"
        Me.tpBenutzerverwaltung.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBenutzerverwaltung.Size = New System.Drawing.Size(976, 628)
        Me.tpBenutzerverwaltung.TabIndex = 0
        Me.tpBenutzerverwaltung.Text = "Benutzerverwaltung"
        '
        'tpStatusverwaltung
        '
        Me.tpStatusverwaltung.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpStatusverwaltung.Controls.Add(Me.btnSvSchliessen)
        Me.tpStatusverwaltung.Controls.Add(Me.GroupBox4)
        Me.tpStatusverwaltung.Controls.Add(Me.GroupBox5)
        Me.tpStatusverwaltung.Controls.Add(Me.GroupBox6)
        Me.tpStatusverwaltung.Controls.Add(Me.dgvStatusverwaltung)
        Me.tpStatusverwaltung.Location = New System.Drawing.Point(4, 29)
        Me.tpStatusverwaltung.Name = "tpStatusverwaltung"
        Me.tpStatusverwaltung.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStatusverwaltung.Size = New System.Drawing.Size(976, 628)
        Me.tpStatusverwaltung.TabIndex = 1
        Me.tpStatusverwaltung.Text = "Statusverwaltung"
        '
        'btnSvSchliessen
        '
        Me.btnSvSchliessen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSvSchliessen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSvSchliessen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSvSchliessen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSvSchliessen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSvSchliessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSvSchliessen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSvSchliessen.ForeColor = System.Drawing.Color.Black
        Me.btnSvSchliessen.Location = New System.Drawing.Point(824, 565)
        Me.btnSvSchliessen.Name = "btnSvSchliessen"
        Me.btnSvSchliessen.Size = New System.Drawing.Size(130, 50)
        Me.btnSvSchliessen.TabIndex = 26
        Me.btnSvSchliessen.Text = "Schließen"
        Me.btnSvSchliessen.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSloeschen)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(818, 321)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(148, 105)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status löschen"
        '
        'btnSloeschen
        '
        Me.btnSloeschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSloeschen.BackColor = System.Drawing.Color.IndianRed
        Me.btnSloeschen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSloeschen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSloeschen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSloeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSloeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSloeschen.ForeColor = System.Drawing.Color.Black
        Me.btnSloeschen.Location = New System.Drawing.Point(6, 25)
        Me.btnSloeschen.Name = "btnSloeschen"
        Me.btnSloeschen.Size = New System.Drawing.Size(130, 74)
        Me.btnSloeschen.TabIndex = 24
        Me.btnSloeschen.Text = "Ausgewählten Status löschen"
        Me.btnSloeschen.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbSVstatus)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.btnSveraendern)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(412, 321)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Status ändern"
        '
        'tbSVstatus
        '
        Me.tbSVstatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbSVstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSVstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbSVstatus.ForeColor = System.Drawing.Color.White
        Me.tbSVstatus.Location = New System.Drawing.Point(10, 45)
        Me.tbSVstatus.Name = "tbSVstatus"
        Me.tbSVstatus.Size = New System.Drawing.Size(384, 26)
        Me.tbSVstatus.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(6, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Statusname"
        '
        'btnSveraendern
        '
        Me.btnSveraendern.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSveraendern.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSveraendern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSveraendern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSveraendern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSveraendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSveraendern.ForeColor = System.Drawing.Color.Black
        Me.btnSveraendern.Location = New System.Drawing.Point(264, 244)
        Me.btnSveraendern.Name = "btnSveraendern"
        Me.btnSveraendern.Size = New System.Drawing.Size(130, 50)
        Me.btnSveraendern.TabIndex = 3
        Me.btnSveraendern.Text = "Speichern"
        Me.btnSveraendern.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tbSAstatus)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.btnSanlegen)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(6, 321)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox6.TabIndex = 28
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Neuen Status anlegen"
        '
        'tbSAstatus
        '
        Me.tbSAstatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbSAstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSAstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbSAstatus.ForeColor = System.Drawing.Color.White
        Me.tbSAstatus.Location = New System.Drawing.Point(10, 45)
        Me.tbSAstatus.Name = "tbSAstatus"
        Me.tbSAstatus.Size = New System.Drawing.Size(384, 26)
        Me.tbSAstatus.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 20)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Statusname"
        '
        'btnSanlegen
        '
        Me.btnSanlegen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSanlegen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSanlegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSanlegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSanlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSanlegen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSanlegen.ForeColor = System.Drawing.Color.Black
        Me.btnSanlegen.Location = New System.Drawing.Point(264, 244)
        Me.btnSanlegen.Name = "btnSanlegen"
        Me.btnSanlegen.Size = New System.Drawing.Size(130, 50)
        Me.btnSanlegen.TabIndex = 3
        Me.btnSanlegen.Text = "Speichern"
        Me.btnSanlegen.UseVisualStyleBackColor = True
        '
        'dgvStatusverwaltung
        '
        Me.dgvStatusverwaltung.AllowUserToAddRows = False
        Me.dgvStatusverwaltung.AllowUserToDeleteRows = False
        Me.dgvStatusverwaltung.AllowUserToResizeRows = False
        Me.dgvStatusverwaltung.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvStatusverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStatusverwaltung.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvStatusverwaltung.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvStatusverwaltung.Location = New System.Drawing.Point(6, 6)
        Me.dgvStatusverwaltung.MultiSelect = False
        Me.dgvStatusverwaltung.Name = "dgvStatusverwaltung"
        Me.dgvStatusverwaltung.ReadOnly = True
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvStatusverwaltung.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvStatusverwaltung.RowTemplate.Height = 30
        Me.dgvStatusverwaltung.Size = New System.Drawing.Size(962, 309)
        Me.dgvStatusverwaltung.TabIndex = 1
        '
        'tpKategorienverwaltung
        '
        Me.tpKategorienverwaltung.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpKategorienverwaltung.Controls.Add(Me.btnKvSchliessen)
        Me.tpKategorienverwaltung.Controls.Add(Me.GroupBox7)
        Me.tpKategorienverwaltung.Controls.Add(Me.GroupBox8)
        Me.tpKategorienverwaltung.Controls.Add(Me.GroupBox9)
        Me.tpKategorienverwaltung.Controls.Add(Me.dgvKategorienverwaltung)
        Me.tpKategorienverwaltung.Location = New System.Drawing.Point(4, 29)
        Me.tpKategorienverwaltung.Name = "tpKategorienverwaltung"
        Me.tpKategorienverwaltung.Padding = New System.Windows.Forms.Padding(3)
        Me.tpKategorienverwaltung.Size = New System.Drawing.Size(976, 628)
        Me.tpKategorienverwaltung.TabIndex = 2
        Me.tpKategorienverwaltung.Text = "Kategorienverwaltung"
        '
        'btnKvSchliessen
        '
        Me.btnKvSchliessen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKvSchliessen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKvSchliessen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnKvSchliessen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnKvSchliessen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnKvSchliessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKvSchliessen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnKvSchliessen.ForeColor = System.Drawing.Color.Black
        Me.btnKvSchliessen.Location = New System.Drawing.Point(824, 565)
        Me.btnKvSchliessen.Name = "btnKvSchliessen"
        Me.btnKvSchliessen.Size = New System.Drawing.Size(130, 50)
        Me.btnKvSchliessen.TabIndex = 26
        Me.btnKvSchliessen.Text = "Schließen"
        Me.btnKvSchliessen.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnKloeschen)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(818, 321)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(148, 105)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Kategorie löschen"
        '
        'btnKloeschen
        '
        Me.btnKloeschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKloeschen.BackColor = System.Drawing.Color.IndianRed
        Me.btnKloeschen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnKloeschen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnKloeschen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnKloeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKloeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnKloeschen.ForeColor = System.Drawing.Color.Black
        Me.btnKloeschen.Location = New System.Drawing.Point(6, 25)
        Me.btnKloeschen.Name = "btnKloeschen"
        Me.btnKloeschen.Size = New System.Drawing.Size(130, 74)
        Me.btnKloeschen.TabIndex = 24
        Me.btnKloeschen.Text = "Ausgewählte Kategorie löschen"
        Me.btnKloeschen.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbKVkategorie)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.btnKveraendern)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(412, 321)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox8.TabIndex = 27
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Kategorie ändern"
        '
        'tbKVkategorie
        '
        Me.tbKVkategorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbKVkategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKVkategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbKVkategorie.ForeColor = System.Drawing.Color.White
        Me.tbKVkategorie.Location = New System.Drawing.Point(10, 45)
        Me.tbKVkategorie.Name = "tbKVkategorie"
        Me.tbKVkategorie.Size = New System.Drawing.Size(384, 26)
        Me.tbKVkategorie.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(6, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 20)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Kategoriename"
        '
        'btnKveraendern
        '
        Me.btnKveraendern.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKveraendern.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnKveraendern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnKveraendern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnKveraendern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKveraendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnKveraendern.ForeColor = System.Drawing.Color.Black
        Me.btnKveraendern.Location = New System.Drawing.Point(264, 244)
        Me.btnKveraendern.Name = "btnKveraendern"
        Me.btnKveraendern.Size = New System.Drawing.Size(130, 50)
        Me.btnKveraendern.TabIndex = 3
        Me.btnKveraendern.Text = "Speichern"
        Me.btnKveraendern.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.tbKAkategorie)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Controls.Add(Me.btnKanlegen)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(6, 321)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox9.TabIndex = 28
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Neue Kategorie anlegen"
        '
        'tbKAkategorie
        '
        Me.tbKAkategorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbKAkategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKAkategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbKAkategorie.ForeColor = System.Drawing.Color.White
        Me.tbKAkategorie.Location = New System.Drawing.Point(10, 45)
        Me.tbKAkategorie.Name = "tbKAkategorie"
        Me.tbKAkategorie.Size = New System.Drawing.Size(384, 26)
        Me.tbKAkategorie.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label22.Location = New System.Drawing.Point(6, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 20)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Kategoriename"
        '
        'btnKanlegen
        '
        Me.btnKanlegen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKanlegen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnKanlegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnKanlegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnKanlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKanlegen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnKanlegen.ForeColor = System.Drawing.Color.Black
        Me.btnKanlegen.Location = New System.Drawing.Point(264, 244)
        Me.btnKanlegen.Name = "btnKanlegen"
        Me.btnKanlegen.Size = New System.Drawing.Size(130, 50)
        Me.btnKanlegen.TabIndex = 3
        Me.btnKanlegen.Text = "Speichern"
        Me.btnKanlegen.UseVisualStyleBackColor = True
        '
        'dgvKategorienverwaltung
        '
        Me.dgvKategorienverwaltung.AllowUserToAddRows = False
        Me.dgvKategorienverwaltung.AllowUserToDeleteRows = False
        Me.dgvKategorienverwaltung.AllowUserToResizeRows = False
        Me.dgvKategorienverwaltung.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvKategorienverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKategorienverwaltung.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvKategorienverwaltung.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvKategorienverwaltung.Location = New System.Drawing.Point(6, 6)
        Me.dgvKategorienverwaltung.MultiSelect = False
        Me.dgvKategorienverwaltung.Name = "dgvKategorienverwaltung"
        Me.dgvKategorienverwaltung.ReadOnly = True
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvKategorienverwaltung.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvKategorienverwaltung.RowTemplate.Height = 30
        Me.dgvKategorienverwaltung.Size = New System.Drawing.Size(962, 309)
        Me.dgvKategorienverwaltung.TabIndex = 2
        '
        'tpPrioritätenverwaltung
        '
        Me.tpPrioritätenverwaltung.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpPrioritätenverwaltung.Controls.Add(Me.btnPvSchliessen)
        Me.tpPrioritätenverwaltung.Controls.Add(Me.GroupBox10)
        Me.tpPrioritätenverwaltung.Controls.Add(Me.GroupBox11)
        Me.tpPrioritätenverwaltung.Controls.Add(Me.GroupBox12)
        Me.tpPrioritätenverwaltung.Controls.Add(Me.dgvPrioritaetenverwaltung)
        Me.tpPrioritätenverwaltung.Location = New System.Drawing.Point(4, 29)
        Me.tpPrioritätenverwaltung.Name = "tpPrioritätenverwaltung"
        Me.tpPrioritätenverwaltung.Size = New System.Drawing.Size(976, 628)
        Me.tpPrioritätenverwaltung.TabIndex = 3
        Me.tpPrioritätenverwaltung.Text = "Prioritätenverwaltung"
        '
        'btnPvSchliessen
        '
        Me.btnPvSchliessen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPvSchliessen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPvSchliessen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPvSchliessen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnPvSchliessen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPvSchliessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPvSchliessen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPvSchliessen.ForeColor = System.Drawing.Color.Black
        Me.btnPvSchliessen.Location = New System.Drawing.Point(824, 565)
        Me.btnPvSchliessen.Name = "btnPvSchliessen"
        Me.btnPvSchliessen.Size = New System.Drawing.Size(130, 50)
        Me.btnPvSchliessen.TabIndex = 26
        Me.btnPvSchliessen.Text = "Schließen"
        Me.btnPvSchliessen.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btnPloeschen)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox10.ForeColor = System.Drawing.Color.White
        Me.GroupBox10.Location = New System.Drawing.Point(818, 321)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(148, 105)
        Me.GroupBox10.TabIndex = 29
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Priorität löschen"
        '
        'btnPloeschen
        '
        Me.btnPloeschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPloeschen.BackColor = System.Drawing.Color.IndianRed
        Me.btnPloeschen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPloeschen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnPloeschen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPloeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPloeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPloeschen.ForeColor = System.Drawing.Color.Black
        Me.btnPloeschen.Location = New System.Drawing.Point(6, 25)
        Me.btnPloeschen.Name = "btnPloeschen"
        Me.btnPloeschen.Size = New System.Drawing.Size(130, 74)
        Me.btnPloeschen.TabIndex = 24
        Me.btnPloeschen.Text = "Ausgewählte Priorität löschen"
        Me.btnPloeschen.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.tbPVprioritaet)
        Me.GroupBox11.Controls.Add(Me.Label26)
        Me.GroupBox11.Controls.Add(Me.btnPveraendern)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox11.ForeColor = System.Drawing.Color.White
        Me.GroupBox11.Location = New System.Drawing.Point(412, 321)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox11.TabIndex = 27
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Priorität ändern"
        '
        'tbPVprioritaet
        '
        Me.tbPVprioritaet.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbPVprioritaet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPVprioritaet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbPVprioritaet.ForeColor = System.Drawing.Color.White
        Me.tbPVprioritaet.Location = New System.Drawing.Point(10, 45)
        Me.tbPVprioritaet.Name = "tbPVprioritaet"
        Me.tbPVprioritaet.Size = New System.Drawing.Size(384, 26)
        Me.tbPVprioritaet.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label26.Location = New System.Drawing.Point(6, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 20)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Prioritätname"
        '
        'btnPveraendern
        '
        Me.btnPveraendern.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPveraendern.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPveraendern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnPveraendern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPveraendern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPveraendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPveraendern.ForeColor = System.Drawing.Color.Black
        Me.btnPveraendern.Location = New System.Drawing.Point(264, 244)
        Me.btnPveraendern.Name = "btnPveraendern"
        Me.btnPveraendern.Size = New System.Drawing.Size(130, 50)
        Me.btnPveraendern.TabIndex = 3
        Me.btnPveraendern.Text = "Speichern"
        Me.btnPveraendern.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.tbPAprioritaet)
        Me.GroupBox12.Controls.Add(Me.Label30)
        Me.GroupBox12.Controls.Add(Me.btnPanlegen)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox12.ForeColor = System.Drawing.Color.White
        Me.GroupBox12.Location = New System.Drawing.Point(6, 321)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox12.TabIndex = 28
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Neue Priorität anlegen"
        '
        'tbPAprioritaet
        '
        Me.tbPAprioritaet.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbPAprioritaet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPAprioritaet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbPAprioritaet.ForeColor = System.Drawing.Color.White
        Me.tbPAprioritaet.Location = New System.Drawing.Point(10, 45)
        Me.tbPAprioritaet.Name = "tbPAprioritaet"
        Me.tbPAprioritaet.Size = New System.Drawing.Size(384, 26)
        Me.tbPAprioritaet.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label30.Location = New System.Drawing.Point(6, 22)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(103, 20)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Prioritätname"
        '
        'btnPanlegen
        '
        Me.btnPanlegen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPanlegen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPanlegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnPanlegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPanlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPanlegen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPanlegen.ForeColor = System.Drawing.Color.Black
        Me.btnPanlegen.Location = New System.Drawing.Point(264, 244)
        Me.btnPanlegen.Name = "btnPanlegen"
        Me.btnPanlegen.Size = New System.Drawing.Size(130, 50)
        Me.btnPanlegen.TabIndex = 3
        Me.btnPanlegen.Text = "Speichern"
        Me.btnPanlegen.UseVisualStyleBackColor = True
        '
        'dgvPrioritaetenverwaltung
        '
        Me.dgvPrioritaetenverwaltung.AllowUserToAddRows = False
        Me.dgvPrioritaetenverwaltung.AllowUserToDeleteRows = False
        Me.dgvPrioritaetenverwaltung.AllowUserToResizeRows = False
        Me.dgvPrioritaetenverwaltung.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvPrioritaetenverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrioritaetenverwaltung.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvPrioritaetenverwaltung.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvPrioritaetenverwaltung.Location = New System.Drawing.Point(6, 6)
        Me.dgvPrioritaetenverwaltung.MultiSelect = False
        Me.dgvPrioritaetenverwaltung.Name = "dgvPrioritaetenverwaltung"
        Me.dgvPrioritaetenverwaltung.ReadOnly = True
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPrioritaetenverwaltung.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvPrioritaetenverwaltung.RowTemplate.Height = 30
        Me.dgvPrioritaetenverwaltung.Size = New System.Drawing.Size(962, 309)
        Me.dgvPrioritaetenverwaltung.TabIndex = 3
        '
        'Verwaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Verwaltung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stammdatenverwaltung"
        CType(Me.dgvBenutzerverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpBenutzerverwaltung.ResumeLayout(False)
        Me.tpStatusverwaltung.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvStatusverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpKategorienverwaltung.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.dgvKategorienverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPrioritätenverwaltung.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.dgvPrioritaetenverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBenutzerverwaltung As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbBVvorname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbBVnachname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBveraendern As Button
    Friend WithEvents btnBvSchliessen As Button
    Friend WithEvents tbBVbenutzer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbBVpasswort As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbBVrechte As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbBArechte As ComboBox
    Friend WithEvents tbBAbenutzer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbBApasswort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBAvorname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbBAnachname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBanlegen As Button
    Friend WithEvents btnBloeschen As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpBenutzerverwaltung As TabPage
    Friend WithEvents tpStatusverwaltung As TabPage
    Friend WithEvents tpKategorienverwaltung As TabPage
    Friend WithEvents tpPrioritätenverwaltung As TabPage
    Friend WithEvents dgvStatusverwaltung As DataGridView
    Friend WithEvents dgvKategorienverwaltung As DataGridView
    Friend WithEvents dgvPrioritaetenverwaltung As DataGridView
    Friend WithEvents btnSvSchliessen As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSloeschen As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tbSVstatus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSveraendern As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents tbSAstatus As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSanlegen As Button
    Friend WithEvents btnKvSchliessen As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnKloeschen As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents tbKVkategorie As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnKveraendern As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents tbKAkategorie As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents btnKanlegen As Button
    Friend WithEvents btnPvSchliessen As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents btnPloeschen As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents tbPVprioritaet As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnPveraendern As Button
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents tbPAprioritaet As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents btnPanlegen As Button
End Class
