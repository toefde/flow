<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Benutzerverwaltung
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnBLloeschen = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvBenutzerverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBenutzerverwaltung
        '
        Me.dgvBenutzerverwaltung.AllowUserToAddRows = False
        Me.dgvBenutzerverwaltung.AllowUserToDeleteRows = False
        Me.dgvBenutzerverwaltung.AllowUserToResizeRows = False
        Me.dgvBenutzerverwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBenutzerverwaltung.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBenutzerverwaltung.Location = New System.Drawing.Point(12, 12)
        Me.dgvBenutzerverwaltung.MultiSelect = False
        Me.dgvBenutzerverwaltung.Name = "dgvBenutzerverwaltung"
        Me.dgvBenutzerverwaltung.ReadOnly = True
        Me.dgvBenutzerverwaltung.Size = New System.Drawing.Size(960, 331)
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
        Me.GroupBox2.Location = New System.Drawing.Point(418, 349)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Benutzer ändern"
        '
        'cbBVrechte
        '
        Me.cbBVrechte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBVrechte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBVrechte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbBVrechte.Items.AddRange(New Object() {"DATENPFLEGER", "ADMIN"})
        Me.cbBVrechte.Location = New System.Drawing.Point(10, 244)
        Me.cbBVrechte.Name = "cbBVrechte"
        Me.cbBVrechte.Size = New System.Drawing.Size(248, 28)
        Me.cbBVrechte.TabIndex = 22
        '
        'tbBVbenutzer
        '
        Me.tbBVbenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.tbBVpasswort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.tbBVvorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.tbBVnachname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.btnBveraendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.btnBvSchliessen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBvSchliessen.Location = New System.Drawing.Point(842, 599)
        Me.btnBvSchliessen.Name = "btnBvSchliessen"
        Me.btnBvSchliessen.Size = New System.Drawing.Size(130, 50)
        Me.btnBvSchliessen.TabIndex = 7
        Me.btnBvSchliessen.Text = "Abbrechen"
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 300)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Benutzer anlegen"
        '
        'cbBArechte
        '
        Me.cbBArechte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBArechte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBArechte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbBArechte.Items.AddRange(New Object() {"DATENPFLEGER", "ADMIN"})
        Me.cbBArechte.Location = New System.Drawing.Point(10, 244)
        Me.cbBArechte.Name = "cbBArechte"
        Me.cbBArechte.Size = New System.Drawing.Size(248, 28)
        Me.cbBArechte.TabIndex = 22
        '
        'tbBAbenutzer
        '
        Me.tbBAbenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.tbBApasswort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.tbBAvorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.tbBAnachname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.btnBanlegen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBanlegen.Location = New System.Drawing.Point(264, 244)
        Me.btnBanlegen.Name = "btnBanlegen"
        Me.btnBanlegen.Size = New System.Drawing.Size(130, 50)
        Me.btnBanlegen.TabIndex = 3
        Me.btnBanlegen.Text = "Speichern"
        Me.btnBanlegen.UseVisualStyleBackColor = True
        '
        'btnBLloeschen
        '
        Me.btnBLloeschen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBLloeschen.BackColor = System.Drawing.Color.LightCoral
        Me.btnBLloeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBLloeschen.Location = New System.Drawing.Point(6, 25)
        Me.btnBLloeschen.Name = "btnBLloeschen"
        Me.btnBLloeschen.Size = New System.Drawing.Size(130, 74)
        Me.btnBLloeschen.TabIndex = 24
        Me.btnBLloeschen.Text = "Ausgewählten Benutzer löschen"
        Me.btnBLloeschen.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBLloeschen)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(824, 349)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 105)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Benutzer löschen"
        '
        'Benutzerverwaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBvSchliessen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvBenutzerverwaltung)
        Me.Name = "Benutzerverwaltung"
        Me.Text = "Benutzerverwaltung"
        CType(Me.dgvBenutzerverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
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
    Friend WithEvents btnBLloeschen As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
