﻿Imports MySql.Data.MySqlClient

Public Class Benutzerverwaltung
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub Benutzerverwaltung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBenutzerverwaltung.Rows.Clear()
        dgvBenutzerverwaltung.Columns.Clear()
        con.Close()
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT COUNT(*) AS Anzahl FROM benutzer;"
        con.Open()
        reader = cmd.ExecuteReader
        reader.Read()
        Dim anzahl As Integer = reader("Anzahl")
        con.Close()
        cmd.CommandText = "SELECT bid, benutzername, vorname, nachname, rechte FROM benutzer;"

        dgvBenutzerverwaltung.Columns.Add("bid", "ID")
        dgvBenutzerverwaltung.Columns.Add("benutzername", "Benutzername")
        dgvBenutzerverwaltung.Columns.Add("vorname", "Vorname")
        dgvBenutzerverwaltung.Columns.Add("nachname", "Nachname")
        dgvBenutzerverwaltung.Columns.Add("rechte", "Rechte")
        dgvBenutzerverwaltung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvBenutzerverwaltung.Rows.Add(anzahl)

        Try
            con.Open()
            reader = cmd.ExecuteReader
            Dim z = 0
            Do While reader.Read
                dgvBenutzerverwaltung.Rows(z).Cells(0).Value = reader("bid")
                dgvBenutzerverwaltung.Rows(z).Cells(1).Value = reader("benutzername")
                dgvBenutzerverwaltung.Rows(z).Cells(2).Value = reader("vorname")
                dgvBenutzerverwaltung.Rows(z).Cells(3).Value = reader("nachname")
                dgvBenutzerverwaltung.Rows(z).Cells(4).Value = reader("rechte")

                z += 1
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cbBArechte.SelectedItem = "DATENPFLEGER"
    End Sub

    Private Sub btnBvAbrechen_Click(sender As Object, e As EventArgs) Handles btnBvAbrechen.Click
        Me.Close()
    End Sub

    Private Sub btnBanlegen_Click(sender As Object, e As EventArgs) Handles btnBanlegen.Click
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        If cbBArechte.SelectedItem = "DATENPFLEGER" Then
            cmd.CommandText = "CREATE USER '" & tbBAbenutzer.Text & "'@'%' IDENTIFIED BY '" & tbBApasswort.Text & "';
            GRANT UPDATE, SELECT, INSERT  ON " & My.Settings.datenbank & ".* TO '" & tbBAbenutzer.Text & "'@'%';
            FLUSH PRIVILEGES;"
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        ElseIf cbBArechte.SelectedItem = "ADMIN" Then
            Try
                cmd.CommandText = "CREATE USER '" & tbBAbenutzer.Text & "'@'%' IDENTIFIED BY '" & tbBApasswort.Text & "';
            GRANT EXECUTE, SELECT, SHOW VIEW, CREATE, DELETE, INSERT, CREATE USER, UPDATE, TRIGGER, RELOAD, SUPER ON *.* TO '" & tbBAbenutzer.Text & "'@'%' WITH GRANT OPTION;
            GRANT EXECUTE, SELECT, SHOW VIEW, ALTER, ALTER ROUTINE, CREATE, CREATE ROUTINE, CREATE TEMPORARY TABLES, CREATE VIEW, DELETE, DROP, EVENT, INDEX, INSERT, REFERENCES, TRIGGER, UPDATE, LOCK TABLES ON '" & My.Settings.datenbank & "'.* TO '" & tbBAbenutzer.Text & "'@'%' WITH GRANT OPTION;
            FLUSH PRIVILEGES;
            INSERT INTO benutzer (benutzername, vorname, nachname, passwort, rechte) VALUES ('" & tbBAbenutzer.Text & "', '" & tbBAvorname.Text & "', '" & tbBAnachname.Text & "', '" & tbBApasswort.Text &
            "', '" & cbBArechte.SelectedItem.ToString & "');"
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
        Benutzerverwaltung_Load(New Object, New EventArgs)
    End Sub

    Private Sub tbBAvorname_TextChanged(sender As Object, e As EventArgs) Handles tbBAvorname.TextChanged
        tbBAbenutzer.Text = tbBAvorname.Text & "." & tbBAnachname.Text.ToLower
    End Sub
    Private Sub tbBAnachname_TextChanged(sender As Object, e As EventArgs) Handles tbBAnachname.TextChanged
        tbBAbenutzer.Text = tbBAvorname.Text & "." & tbBAnachname.Text.ToLower
    End Sub

    Private Sub btnBLloeschen_Click(sender As Object, e As EventArgs) Handles btnBLloeschen.Click 'lösche ausgewählten Benutzer
        'MsgBox(dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(0).Value & dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(1).Value)
        cmd.CommandText = "DELETE From benutzer Where Bid = " & dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";
            DROP USER '" & dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(1).Value & "';"
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Benutzerverwaltung_Load(New Object, New EventArgs)
    End Sub
End Class