Public Class schnelleNotizen
    Private Sub RichTextBox1_Leave(sender As Object, e As EventArgs) Handles rtpNotizen.MouseLeave
        flow.db.setNotiz(rtpNotizen.Text)
    End Sub
End Class