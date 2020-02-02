<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anmeldung
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbbenutzer
        '
        Me.tbbenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbbenutzer.Location = New System.Drawing.Point(117, 52)
        Me.tbbenutzer.Name = "tbbenutzer"
        Me.tbbenutzer.Size = New System.Drawing.Size(360, 26)
        Me.tbbenutzer.TabIndex = 0
        '
        'tbpasswort
        '
        Me.tbpasswort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbpasswort.Location = New System.Drawing.Point(117, 118)
        Me.tbpasswort.Name = "tbpasswort"
        Me.tbpasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.tbpasswort.Size = New System.Drawing.Size(360, 26)
        Me.tbpasswort.TabIndex = 1
        '
        'tbserver
        '
        Me.tbserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbserver.Location = New System.Drawing.Point(117, 190)
        Me.tbserver.Name = "tbserver"
        Me.tbserver.Size = New System.Drawing.Size(360, 26)
        Me.tbserver.TabIndex = 2
        '
        'tbdatenbank
        '
        Me.tbdatenbank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.login.Location = New System.Drawing.Point(347, 307)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(130, 50)
        Me.login.TabIndex = 2
        Me.login.Text = "Anmelden"
        Me.login.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ADMIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(489, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(109, 17)
        Me.ToolStripStatusLabel1.Text = "Keine Verbindung..."
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(350, 16)
        Me.ToolStripProgressBar1.Step = 100
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(33, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 50)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "DATENPFLEGER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Anmeldung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 392)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StatusStrip1)
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
        Me.Name = "Anmeldung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Anmeldung"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
End Class
