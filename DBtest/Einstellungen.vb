Imports MySql.Data.MySqlClient

Public Class Einstellungen
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Public splitter = "~"

    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cbFullscreen.Checked = My.Settings.startFullscreen


        For Each item In gbFilter.Controls.OfType(Of CheckedListBox)
            item.Items.Clear()
        Next
        clbStatus.Items.AddRange(flow.getStatus)
        clbPrio.Items.AddRange(flow.getPrios)
        clbKategorie.Items.AddRange(flow.getKategorien)

        Dim lKategorien(), lStatus(), lPrios()

        lKategorien = My.Settings.startKategorien.Split(splitter)
        lStatus = My.Settings.startStatus.Split(splitter)
        lPrios = My.Settings.startPrios.Split(splitter)

        For i = 0 To clbKategorie.Items.Count - 1
            clbKategorie.SetItemChecked(i, lKategorien.Contains(clbKategorie.Items.Item(i)))
        Next
        For i = 0 To clbPrio.Items.Count - 1
            clbPrio.SetItemChecked(i, lPrios.Contains(clbPrio.Items.Item(i)))
        Next
        For i = 0 To clbStatus.Items.Count - 1
            clbStatus.SetItemChecked(i, lStatus.Contains(clbStatus.Items.Item(i)))
        Next

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

    Private Sub cbFullscreen_CheckedChanged(sender As Object, e As EventArgs) Handles cbFullscreen.CheckedChanged
        My.Settings.startFullscreen = cbFullscreen.CheckState
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSchließen.Click
        My.Settings.Save()
        Close()
    End Sub

    Private Sub btnStartFilter_Click(sender As Object, e As EventArgs) Handles btnStartFilter.Click
        Dim lKategorien As New List(Of String)
        Dim lStatus As New List(Of String)
        Dim lPrios As New List(Of String)
        For i = 0 To clbKategorie.Items.Count - 1
            If clbKategorie.GetItemChecked(i) Then
                lKategorien.Add(clbKategorie.Items.Item(i))
            End If
        Next
        For i = 0 To clbStatus.Items.Count - 1
            If clbStatus.GetItemChecked(i) Then
                lStatus.Add(clbStatus.Items.Item(i))
            End If
        Next
        For i = 0 To clbPrio.Items.Count - 1
            If clbPrio.GetItemChecked(i) Then
                lPrios.Add(clbPrio.Items.Item(i))
            End If
        Next

        My.Settings.startKategorien = ""
        For Each item In lKategorien
            My.Settings.startKategorien &= item
            If item <> lKategorien.Last Then
                My.Settings.startKategorien &= splitter
            End If
        Next
        My.Settings.startPrios = ""
        For Each item In lPrios
            My.Settings.startPrios &= item
            If item <> lPrios.Last Then
                My.Settings.startPrios &= splitter
            End If
        Next
        My.Settings.startStatus = ""
        For Each item In lStatus
            My.Settings.startStatus &= item
            If item <> lStatus.Last Then
                My.Settings.startStatus &= splitter
            End If
        Next

        MsgBox(My.Settings.startKategorien)
        MsgBox(My.Settings.startStatus)
        MsgBox(My.Settings.startPrios)
    End Sub
End Class