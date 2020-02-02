<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staendeAnzeigen
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
        Me.dgvStaende = New System.Windows.Forms.DataGridView()
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
        Me.dgvStaende.Size = New System.Drawing.Size(921, 644)
        Me.dgvStaende.TabIndex = 0
        '
        'staendeAnzeigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 644)
        Me.Controls.Add(Me.dgvStaende)
        Me.Name = "staendeAnzeigen"
        Me.Text = "staendeAnzeigen"
        CType(Me.dgvStaende, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvStaende As DataGridView
End Class
