<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpAllgemein = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbNeuesPasswortW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNeuesPasswort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPasswortAendern = New System.Windows.Forms.Button()
        Me.tpStartOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbFullscreen = New System.Windows.Forms.CheckBox()
        Me.gbFilter = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbKategorie = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clbPrio = New System.Windows.Forms.CheckedListBox()
        Me.clbStatus = New System.Windows.Forms.CheckedListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpFarbverwaltung = New System.Windows.Forms.TabPage()
        Me.btnSchließen = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStartFilter = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpAllgemein.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tpStartOptions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbFilter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpAllgemein)
        Me.TabControl1.Controls.Add(Me.tpStartOptions)
        Me.TabControl1.Controls.Add(Me.tpFarbverwaltung)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 661)
        Me.TabControl1.TabIndex = 27
        '
        'tpAllgemein
        '
        Me.tpAllgemein.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpAllgemein.Controls.Add(Me.GroupBox6)
        Me.tpAllgemein.ForeColor = System.Drawing.Color.White
        Me.tpAllgemein.Location = New System.Drawing.Point(4, 29)
        Me.tpAllgemein.Name = "tpAllgemein"
        Me.tpAllgemein.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAllgemein.Size = New System.Drawing.Size(976, 628)
        Me.tpAllgemein.TabIndex = 0
        Me.tpAllgemein.Text = "Allgemein"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tbNeuesPasswortW)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.tbNeuesPasswort)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.btnPasswortAendern)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(400, 219)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Eigenes Passwort ändern"
        '
        'tbNeuesPasswortW
        '
        Me.tbNeuesPasswortW.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbNeuesPasswortW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNeuesPasswortW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuesPasswortW.ForeColor = System.Drawing.Color.White
        Me.tbNeuesPasswortW.Location = New System.Drawing.Point(10, 113)
        Me.tbNeuesPasswortW.Name = "tbNeuesPasswortW"
        Me.tbNeuesPasswortW.Size = New System.Drawing.Size(384, 26)
        Me.tbNeuesPasswortW.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Neues Passwort wiederholen"
        '
        'tbNeuesPasswort
        '
        Me.tbNeuesPasswort.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbNeuesPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNeuesPasswort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbNeuesPasswort.ForeColor = System.Drawing.Color.White
        Me.tbNeuesPasswort.Location = New System.Drawing.Point(10, 48)
        Me.tbNeuesPasswort.Name = "tbNeuesPasswort"
        Me.tbNeuesPasswort.Size = New System.Drawing.Size(384, 26)
        Me.tbNeuesPasswort.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Neues Passwort"
        '
        'btnPasswortAendern
        '
        Me.btnPasswortAendern.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPasswortAendern.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPasswortAendern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnPasswortAendern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnPasswortAendern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasswortAendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPasswortAendern.ForeColor = System.Drawing.Color.Black
        Me.btnPasswortAendern.Location = New System.Drawing.Point(264, 160)
        Me.btnPasswortAendern.Name = "btnPasswortAendern"
        Me.btnPasswortAendern.Size = New System.Drawing.Size(130, 50)
        Me.btnPasswortAendern.TabIndex = 3
        Me.btnPasswortAendern.Text = "Speichern"
        Me.btnPasswortAendern.UseVisualStyleBackColor = True
        '
        'tpStartOptions
        '
        Me.tpStartOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpStartOptions.Controls.Add(Me.GroupBox2)
        Me.tpStartOptions.Controls.Add(Me.gbFilter)
        Me.tpStartOptions.Location = New System.Drawing.Point(4, 29)
        Me.tpStartOptions.Name = "tpStartOptions"
        Me.tpStartOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStartOptions.Size = New System.Drawing.Size(976, 628)
        Me.tpStartOptions.TabIndex = 2
        Me.tpStartOptions.Text = "Startoptionen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbFullscreen)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(6, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 68)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fullscreen"
        '
        'cbFullscreen
        '
        Me.cbFullscreen.AutoSize = True
        Me.cbFullscreen.Location = New System.Drawing.Point(11, 25)
        Me.cbFullscreen.Name = "cbFullscreen"
        Me.cbFullscreen.Size = New System.Drawing.Size(202, 24)
        Me.cbFullscreen.TabIndex = 0
        Me.cbFullscreen.Text = "Im Vollbildmodus starten"
        Me.cbFullscreen.UseVisualStyleBackColor = True
        '
        'gbFilter
        '
        Me.gbFilter.Controls.Add(Me.btnStartFilter)
        Me.gbFilter.Controls.Add(Me.Label5)
        Me.gbFilter.Controls.Add(Me.clbKategorie)
        Me.gbFilter.Controls.Add(Me.Label6)
        Me.gbFilter.Controls.Add(Me.clbPrio)
        Me.gbFilter.Controls.Add(Me.clbStatus)
        Me.gbFilter.Controls.Add(Me.Label7)
        Me.gbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.gbFilter.ForeColor = System.Drawing.Color.White
        Me.gbFilter.Location = New System.Drawing.Point(6, 3)
        Me.gbFilter.Name = "gbFilter"
        Me.gbFilter.Size = New System.Drawing.Size(962, 251)
        Me.gbFilter.TabIndex = 30
        Me.gbFilter.TabStop = False
        Me.gbFilter.Text = "Daten die bei Start angezeigt werden sollen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Kategorie"
        '
        'clbKategorie
        '
        Me.clbKategorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbKategorie.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbKategorie.CheckOnClick = True
        Me.clbKategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbKategorie.ForeColor = System.Drawing.Color.White
        Me.clbKategorie.Location = New System.Drawing.Point(9, 45)
        Me.clbKategorie.Name = "clbKategorie"
        Me.clbKategorie.Size = New System.Drawing.Size(300, 105)
        Me.clbKategorie.TabIndex = 43
        Me.clbKategorie.ThreeDCheckBoxes = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(649, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Priorität"
        '
        'clbPrio
        '
        Me.clbPrio.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbPrio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbPrio.CheckOnClick = True
        Me.clbPrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbPrio.ForeColor = System.Drawing.Color.White
        Me.clbPrio.Location = New System.Drawing.Point(653, 45)
        Me.clbPrio.Name = "clbPrio"
        Me.clbPrio.Size = New System.Drawing.Size(300, 105)
        Me.clbPrio.TabIndex = 41
        Me.clbPrio.ThreeDCheckBoxes = True
        '
        'clbStatus
        '
        Me.clbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbStatus.CheckOnClick = True
        Me.clbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbStatus.ForeColor = System.Drawing.Color.White
        Me.clbStatus.Location = New System.Drawing.Point(331, 45)
        Me.clbStatus.Name = "clbStatus"
        Me.clbStatus.Size = New System.Drawing.Size(300, 105)
        Me.clbStatus.TabIndex = 39
        Me.clbStatus.ThreeDCheckBoxes = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(327, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Status"
        '
        'tpFarbverwaltung
        '
        Me.tpFarbverwaltung.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tpFarbverwaltung.Location = New System.Drawing.Point(4, 29)
        Me.tpFarbverwaltung.Name = "tpFarbverwaltung"
        Me.tpFarbverwaltung.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFarbverwaltung.Size = New System.Drawing.Size(976, 628)
        Me.tpFarbverwaltung.TabIndex = 1
        Me.tpFarbverwaltung.Text = "Farbverwaltung"
        '
        'btnSchließen
        '
        Me.btnSchließen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSchließen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSchließen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSchließen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSchließen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchließen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSchließen.ForeColor = System.Drawing.Color.Black
        Me.btnSchließen.Location = New System.Drawing.Point(843, 12)
        Me.btnSchließen.Name = "btnSchließen"
        Me.btnSchließen.Size = New System.Drawing.Size(130, 50)
        Me.btnSchließen.TabIndex = 48
        Me.btnSchließen.Text = "Schließen"
        Me.btnSchließen.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSchließen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 587)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 74)
        Me.Panel1.TabIndex = 28
        '
        'btnStartFilter
        '
        Me.btnStartFilter.BackColor = System.Drawing.Color.Gainsboro
        Me.btnStartFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnStartFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnStartFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnStartFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnStartFilter.ForeColor = System.Drawing.Color.Black
        Me.btnStartFilter.Location = New System.Drawing.Point(826, 194)
        Me.btnStartFilter.Name = "btnStartFilter"
        Me.btnStartFilter.Size = New System.Drawing.Size(130, 50)
        Me.btnStartFilter.TabIndex = 45
        Me.btnStartFilter.Text = "Speichern"
        Me.btnStartFilter.UseVisualStyleBackColor = True
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Einstellungen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.TabControl1.ResumeLayout(False)
        Me.tpAllgemein.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tpStartOptions.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbFilter.ResumeLayout(False)
        Me.gbFilter.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpAllgemein As TabPage
    Friend WithEvents tpFarbverwaltung As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents tbNeuesPasswortW As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNeuesPasswort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPasswortAendern As Button
    Friend WithEvents tpStartOptions As TabPage
    Friend WithEvents gbFilter As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbFullscreen As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents clbKategorie As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents clbPrio As CheckedListBox
    Friend WithEvents clbStatus As CheckedListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSchließen As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStartFilter As Button
End Class
