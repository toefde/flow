Public Class staendeAnzeigen
    Private Sub staendeAnzeigen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim staende = flow.getAllStaendeFrom(flow.lblID.Text)
        Text = "Notizen von " & flow.tbTitel.Text

        For i = 0 To staende.Length / 3 - 1
            TextBox1.Text &= staende(i, 0) & vbCrLf & vbCrLf
            TextBox1.Text &= staende(i, 1) & vbTab & staende(i, 2) & vbCrLf & "_________________________________________" & vbCrLf & vbCrLf
        Next

    End Sub
End Class