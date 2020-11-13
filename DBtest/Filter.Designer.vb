<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Filter
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
        Me.clbBenutzer = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.filterPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbKategorie = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clbPrio = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbStatus = New System.Windows.Forms.CheckedListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clbSpalten = New System.Windows.Forms.CheckedListBox()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.filterPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'clbBenutzer
        '
        Me.clbBenutzer.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbBenutzer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbBenutzer.CheckOnClick = True
        Me.clbBenutzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbBenutzer.ForeColor = System.Drawing.Color.White
        Me.clbBenutzer.Location = New System.Drawing.Point(12, 177)
        Me.clbBenutzer.Name = "clbBenutzer"
        Me.clbBenutzer.Size = New System.Drawing.Size(300, 105)
        Me.clbBenutzer.TabIndex = 2
        Me.clbBenutzer.ThreeDCheckBoxes = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(8, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Benutzer"
        '
        'filterPanel
        '
        Me.filterPanel.Controls.Add(Me.Label3)
        Me.filterPanel.Controls.Add(Me.clbKategorie)
        Me.filterPanel.Controls.Add(Me.Label2)
        Me.filterPanel.Controls.Add(Me.clbPrio)
        Me.filterPanel.Controls.Add(Me.Label1)
        Me.filterPanel.Controls.Add(Me.clbStatus)
        Me.filterPanel.Controls.Add(Me.Label6)
        Me.filterPanel.Controls.Add(Me.clbBenutzer)
        Me.filterPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.filterPanel.Location = New System.Drawing.Point(0, 0)
        Me.filterPanel.Name = "filterPanel"
        Me.filterPanel.Size = New System.Drawing.Size(984, 333)
        Me.filterPanel.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Kategorie"
        '
        'clbKategorie
        '
        Me.clbKategorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbKategorie.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbKategorie.CheckOnClick = True
        Me.clbKategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbKategorie.ForeColor = System.Drawing.Color.White
        Me.clbKategorie.Location = New System.Drawing.Point(8, 27)
        Me.clbKategorie.Name = "clbKategorie"
        Me.clbKategorie.Size = New System.Drawing.Size(300, 105)
        Me.clbKategorie.TabIndex = 35
        Me.clbKategorie.ThreeDCheckBoxes = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(668, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Priorität"
        '
        'clbPrio
        '
        Me.clbPrio.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbPrio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbPrio.CheckOnClick = True
        Me.clbPrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbPrio.ForeColor = System.Drawing.Color.White
        Me.clbPrio.Location = New System.Drawing.Point(672, 27)
        Me.clbPrio.Name = "clbPrio"
        Me.clbPrio.Size = New System.Drawing.Size(300, 105)
        Me.clbPrio.TabIndex = 33
        Me.clbPrio.ThreeDCheckBoxes = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(336, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Status"
        '
        'clbStatus
        '
        Me.clbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbStatus.CheckOnClick = True
        Me.clbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbStatus.ForeColor = System.Drawing.Color.White
        Me.clbStatus.Location = New System.Drawing.Point(340, 27)
        Me.clbStatus.Name = "clbStatus"
        Me.clbStatus.Size = New System.Drawing.Size(300, 105)
        Me.clbStatus.TabIndex = 31
        Me.clbStatus.ThreeDCheckBoxes = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.clbSpalten)
        Me.Panel2.Location = New System.Drawing.Point(12, 339)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(543, 259)
        Me.Panel2.TabIndex = 45
        '
        'clbSpalten
        '
        Me.clbSpalten.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.clbSpalten.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbSpalten.CheckOnClick = True
        Me.clbSpalten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clbSpalten.ForeColor = System.Drawing.Color.White
        Me.clbSpalten.Location = New System.Drawing.Point(3, 3)
        Me.clbSpalten.Name = "clbSpalten"
        Me.clbSpalten.Size = New System.Drawing.Size(300, 105)
        Me.clbSpalten.TabIndex = 31
        Me.clbSpalten.ThreeDCheckBoxes = True
        Me.clbSpalten.Visible = False
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpeichern.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSpeichern.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSpeichern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSpeichern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSpeichern.ForeColor = System.Drawing.Color.Black
        Me.btnSpeichern.Location = New System.Drawing.Point(842, 599)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(130, 50)
        Me.btnSpeichern.TabIndex = 46
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'Filter
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.filterPanel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Filter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter"
        Me.filterPanel.ResumeLayout(False)
        Me.filterPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clbBenutzer As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents filterPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents clbSpalten As CheckedListBox
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents clbKategorie As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents clbPrio As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clbStatus As CheckedListBox
End Class
