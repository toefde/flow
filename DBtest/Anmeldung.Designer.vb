<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Anmeldung
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
        Me.tbbenutzer = New System.Windows.Forms.TextBox()
        Me.tbpasswort = New System.Windows.Forms.TextBox()
        Me.tbserver = New System.Windows.Forms.TextBox()
        Me.tbdatenbank = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSchliessen = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbbenutzer
        '
        Me.tbbenutzer.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbbenutzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbbenutzer.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbbenutzer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbbenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbbenutzer.ForeColor = System.Drawing.Color.White
        Me.tbbenutzer.Location = New System.Drawing.Point(117, 52)
        Me.tbbenutzer.Name = "tbbenutzer"
        Me.tbbenutzer.Size = New System.Drawing.Size(360, 26)
        Me.tbbenutzer.TabIndex = 0
        '
        'tbpasswort
        '
        Me.tbpasswort.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbpasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpasswort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbpasswort.ForeColor = System.Drawing.Color.White
        Me.tbpasswort.Location = New System.Drawing.Point(117, 118)
        Me.tbpasswort.Name = "tbpasswort"
        Me.tbpasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.tbpasswort.Size = New System.Drawing.Size(360, 26)
        Me.tbpasswort.TabIndex = 1
        '
        'tbserver
        '
        Me.tbserver.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbserver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbserver.ForeColor = System.Drawing.Color.White
        Me.tbserver.Location = New System.Drawing.Point(117, 190)
        Me.tbserver.Name = "tbserver"
        Me.tbserver.Size = New System.Drawing.Size(360, 26)
        Me.tbserver.TabIndex = 2
        '
        'tbdatenbank
        '
        Me.tbdatenbank.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.tbdatenbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbdatenbank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbdatenbank.ForeColor = System.Drawing.Color.White
        Me.tbdatenbank.Location = New System.Drawing.Point(117, 263)
        Me.tbdatenbank.Name = "tbdatenbank"
        Me.tbdatenbank.Size = New System.Drawing.Size(360, 26)
        Me.tbdatenbank.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Benutzer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Passwort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Server"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(13, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Datenbank"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Gainsboro
        Me.login.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.login.ForeColor = System.Drawing.Color.Black
        Me.login.Location = New System.Drawing.Point(347, 307)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(130, 50)
        Me.login.TabIndex = 2
        Me.login.Text = "Anmelden"
        Me.login.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(211, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ADMIN"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Timer1
        '
        '
        'btnSchliessen
        '
        Me.btnSchliessen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSchliessen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSchliessen.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSchliessen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSchliessen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSchliessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchliessen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchliessen.ForeColor = System.Drawing.Color.Black
        Me.btnSchliessen.Location = New System.Drawing.Point(17, 307)
        Me.btnSchliessen.Name = "btnSchliessen"
        Me.btnSchliessen.Size = New System.Drawing.Size(130, 50)
        Me.btnSchliessen.TabIndex = 12
        Me.btnSchliessen.Text = "Abbrechen"
        Me.btnSchliessen.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 367)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(489, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(109, 20)
        Me.ToolStripStatusLabel1.Text = "Keine Verbindung..."
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(350, 22)
        Me.ToolStripProgressBar1.Step = 100
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'Anmeldung
        '
        Me.AcceptButton = Me.login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.CancelButton = Me.btnSchliessen
        Me.ClientSize = New System.Drawing.Size(489, 392)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnSchliessen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbdatenbank)
        Me.Controls.Add(Me.tbserver)
        Me.Controls.Add(Me.tbpasswort)
        Me.Controls.Add(Me.tbbenutzer)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Anmeldung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anmeldung"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbbenutzer As TextBox
    Friend WithEvents tbpasswort As TextBox
    Friend WithEvents tbserver As TextBox
    Friend WithEvents tbdatenbank As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents login As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSchliessen As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
End Class
