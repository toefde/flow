<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class schnelleNotizen
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
        Me.rtpNotizen = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtpNotizen
        '
        Me.rtpNotizen.AutoWordSelection = True
        Me.rtpNotizen.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.rtpNotizen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtpNotizen.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtpNotizen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtpNotizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtpNotizen.ForeColor = System.Drawing.Color.White
        Me.rtpNotizen.Location = New System.Drawing.Point(0, 0)
        Me.rtpNotizen.MaxLength = 9500
        Me.rtpNotizen.Name = "rtpNotizen"
        Me.rtpNotizen.Size = New System.Drawing.Size(650, 450)
        Me.rtpNotizen.TabIndex = 0
        Me.rtpNotizen.Text = ""
        '
        'schnelleNotizen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.rtpNotizen)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "schnelleNotizen"
        Me.Text = "schnelleNotizen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtpNotizen As RichTextBox
End Class
