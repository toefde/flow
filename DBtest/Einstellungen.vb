Imports MySql.Data.MySqlClient

Public Class Einstellungen
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
    End Sub

    Private Sub btnPasswortAendern_Click(sender As Object, e As EventArgs) Handles btnPasswortAendern.Click
        MsgBox("fes")

        If tbNeuesPasswort.Text <> tbNeuesPasswortW.Text Then
            tbNeuesPasswort.BackColor = Color.FromArgb(111, 111, 111)
            tbNeuesPasswortW.BackColor = Color.FromArgb(111, 111, 111)
            MsgBox(False)
        Else
            cmd.CommandText = "UPDATE benutzer SET passwort = '" & tbNeuesPasswort.Text & "' WHERE bid = " & flow.db.getBenutzerID(flow.benutzer) & ";"
            If Not tbNeuesPasswort.Text = "" Then
                cmd.CommandText &= "SET PASSWORD FOR '" & flow.benutzer.Text & "'@'%' = PASSWORD('" & tbNeuesPasswort.Text & "');"
            End If
            Try
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub neuesPasswort_TextChanged(sender As Object, e As EventArgs) Handles tbNeuesPasswort.TextChanged, tbNeuesPasswort.TextChanged
        tbNeuesPasswort.BackColor = Color.FromArgb(111, 111, 111)
        tbNeuesPasswortW.BackColor = Color.FromArgb(111, 111, 111)
    End Sub


End Class