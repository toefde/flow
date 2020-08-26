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
        Me.tpFarbverwaltung = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tpAllgemein.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpAllgemein)
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
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Einstellungen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.TabControl1.ResumeLayout(False)
        Me.tpAllgemein.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
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
End Class
