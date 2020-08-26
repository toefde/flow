<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staendeAnzeigen
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
        Me.dgvStaende = New System.Windows.Forms.DataGridView()
        Me.rtpStaende = New System.Windows.Forms.RichTextBox()
        CType(Me.dgvStaende, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStaende
        '
        Me.dgvStaende.AllowUserToAddRows = False
        Me.dgvStaende.AllowUserToDeleteRows = False
        Me.dgvStaende.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaende.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStaende.Location = New System.Drawing.Point(0, 0)
        Me.dgvStaende.Name = "dgvStaende"
        Me.dgvStaende.ReadOnly = True
        Me.dgvStaende.Size = New System.Drawing.Size(984, 661)
        Me.dgvStaende.TabIndex = 0
        '
        'rtpStaende
        '
        Me.rtpStaende.AutoWordSelection = True
        Me.rtpStaende.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.rtpStaende.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtpStaende.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtpStaende.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtpStaende.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtpStaende.ForeColor = System.Drawing.Color.White
        Me.rtpStaende.Location = New System.Drawing.Point(0, 0)
        Me.rtpStaende.MaxLength = 9500
        Me.rtpStaende.Name = "rtpStaende"
        Me.rtpStaende.ReadOnly = True
        Me.rtpStaende.Size = New System.Drawing.Size(984, 661)
        Me.rtpStaende.TabIndex = 1
        Me.rtpStaende.Text = ""
        '
        'staendeAnzeigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.rtpStaende)
        Me.Controls.Add(Me.dgvStaende)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staendeAnzeigen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staendeAnzeigen"
        CType(Me.dgvStaende, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvStaende As DataGridView
    Friend WithEvents rtpStaende As RichTextBox
End Class
