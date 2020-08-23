Imports MySql.Data.MySqlClient

Public Class Verwaltung
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim dgvs As New List(Of DataGridView)
    Dim dvs As New List(Of DataTable)



    Private Sub Benutzerverwaltung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        For Each tp As TabPage In TabControl1.Controls.OfType(Of TabPage)
            For Each dgv As DataGridView In tp.Controls.OfType(Of DataGridView)
                dgvs.Add(dgv)
                dvs.Add(New DataTable)
            Next
        Next
    End Sub

    Private Sub btnSchliessen_Click(sender As Object, e As EventArgs) Handles btnBvSchliessen.Click, btnPvSchliessen.Click, btnKvSchliessen.Click, btnSvSchliessen.Click
        Me.Close()
    End Sub



    Private Sub tbBAvorname_TextChanged(sender As Object, e As EventArgs) Handles tbBAvorname.TextChanged
        tbBAbenutzer.Text = tbBAvorname.Text & "." & tbBAnachname.Text.ToLower
    End Sub
    Private Sub tbBAnachname_TextChanged(sender As Object, e As EventArgs) Handles tbBAnachname.TextChanged
        tbBAbenutzer.Text = tbBAvorname.Text & "." & tbBAnachname.Text.ToLower
    End Sub



    Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'Benutzerverwaltung
                dgvBenutzerverwaltung.Rows.Clear()
                dgvBenutzerverwaltung.Columns.Clear()

                cmd.CommandText = "SELECT bid, benutzername, vorname, nachname, rechte FROM benutzer;"

                dgvBenutzerverwaltung.Columns.Add("bid", "ID")
                dgvBenutzerverwaltung.Columns.Add("benutzername", "Benutzername")
                dgvBenutzerverwaltung.Columns.Add("vorname", "Vorname")
                dgvBenutzerverwaltung.Columns.Add("nachname", "Nachname")
                dgvBenutzerverwaltung.Columns.Add("rechte", "Rechte")
                dgvBenutzerverwaltung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                Try
                    con.Open()
                    reader = cmd.ExecuteReader
                    Dim z = 0
                    Do While reader.Read
                        dgvBenutzerverwaltung.Rows.Add(1)
                        z = dgvBenutzerverwaltung.Rows.Count - 1
                        dgvBenutzerverwaltung.Rows(z).Cells(0).Value = reader("bid")
                        dgvBenutzerverwaltung.Rows(z).Cells(1).Value = reader("benutzername")
                        dgvBenutzerverwaltung.Rows(z).Cells(2).Value = reader("vorname")
                        dgvBenutzerverwaltung.Rows(z).Cells(3).Value = reader("nachname")
                        dgvBenutzerverwaltung.Rows(z).Cells(4).Value = flow.db.getRechteValue(reader("rechte"))
                    Loop
                    reader.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                cbBArechte.SelectedItem = "USER"

            Case 1 'Statusverwaltung
                dgvStatusverwaltung.Rows.Clear()
                dgvStatusverwaltung.Columns.Clear()

                cmd.CommandText = "SELECT sid, status.status FROM status;"

                dgvStatusverwaltung.Columns.Add("sid", "ID")
                dgvStatusverwaltung.Columns.Add("status", "Status")
                dgvStatusverwaltung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                Try
                    con.Open()
                    reader = cmd.ExecuteReader
                    Dim z = 0
                    Do While reader.Read
                        dgvStatusverwaltung.Rows.Add(1)
                        z = dgvStatusverwaltung.Rows.Count - 1
                        dgvStatusverwaltung.Rows(z).Cells(0).Value = reader("sid")
                        dgvStatusverwaltung.Rows(z).Cells(1).Value = reader("status")
                    Loop
                    reader.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Case 2 'Kategorienverwaltung
                dgvKategorienverwaltung.Rows.Clear()
                dgvKategorienverwaltung.Columns.Clear()

                cmd.CommandText = "SELECT kid, kategorie FROM kategorien;"

                dgvKategorienverwaltung.Columns.Add("kid", "ID")
                dgvKategorienverwaltung.Columns.Add("kategorie", "Kategorie")
                dgvKategorienverwaltung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                Try
                    con.Open()
                    reader = cmd.ExecuteReader
                    Dim z = 0
                    Do While reader.Read
                        dgvKategorienverwaltung.Rows.Add(1)
                        z = dgvKategorienverwaltung.Rows.Count - 1
                        dgvKategorienverwaltung.Rows(z).Cells(0).Value = reader("kid")
                        dgvKategorienverwaltung.Rows(z).Cells(1).Value = reader("kategorie")
                    Loop
                    reader.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Case 3 'Prioritätenverwaltung
                dgvPrioritaetenverwaltung.Rows.Clear()
                dgvPrioritaetenverwaltung.Columns.Clear()

                cmd.CommandText = "SELECT pid, prioritaet FROM prio;"

                dgvPrioritaetenverwaltung.Columns.Add("pid", "ID")
                dgvPrioritaetenverwaltung.Columns.Add("prioritaet", "Priorität")
                dgvPrioritaetenverwaltung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                Try
                    con.Open()
                    reader = cmd.ExecuteReader
                    Dim z = 0
                    Do While reader.Read
                        dgvPrioritaetenverwaltung.Rows.Add(1)
                        z = dgvPrioritaetenverwaltung.Rows.Count - 1
                        dgvPrioritaetenverwaltung.Rows(z).Cells(0).Value = reader("pid")
                        dgvPrioritaetenverwaltung.Rows(z).Cells(1).Value = reader("prioritaet")
                    Loop
                    reader.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select
        dgvs(TabControl1.SelectedIndex).Focus()
    End Sub

    Private Sub btnAnlegen_Click(sender As Object, e As EventArgs) Handles btnBanlegen.Click, btnSanlegen.Click, btnKanlegen.Click, btnPanlegen.Click
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        Select Case TabControl1.SelectedIndex
            Case 0
                cmd.CommandText = "CREATE USER '" & tbBAbenutzer.Text & "'@'%' IDENTIFIED BY '" & tbBApasswort.Text & "';
            GRANT EXECUTE, SELECT, SHOW VIEW, EVENT, INDEX, INSERT, REFERENCES, TRIGGER, UPDATE ON *.* TO '" & tbBAbenutzer.Text & "'@'%';
            FLUSH PRIVILEGES;
            INSERT INTO benutzer (benutzername, vorname, nachname, passwort, rechte) VALUES ('" & tbBAbenutzer.Text & "', '" & tbBAvorname.Text & "', '" & tbBAnachname.Text & "', '" & tbBApasswort.Text &
            "', '" & flow.db.getRechteID(cbBArechte.SelectedItem.ToString) & "');"
                tbBAbenutzer.Clear()
                tbBApasswort.Clear()
                tbBAvorname.Clear()
                tbBAnachname.Clear()
                cbBArechte.SelectedItem = "USER"
            Case 1
                cmd.CommandText = "INSERT INTO status (status) VALUES ('" & tbSAstatus.Text & "');"
                tbSAstatus.Clear()
            Case 2
                cmd.CommandText = "INSERT INTO kategorien (kategorie) VALUES ('" & tbKAkategorie.Text & "');"
                tbKAkategorie.Clear()
            Case 3
                cmd.CommandText = "INSERT INTO prio (prioritaet) VALUES ('" & tbPAprioritaet.Text & "');"
                tbPAprioritaet.Clear()
        End Select
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TabControl1_SelectedIndexChanged(sender, e)
        SelectionChanged(sender, e)
        dgvs(TabControl1.SelectedIndex).Focus()
    End Sub

    Private Sub btnVeraendern_Click(sender As Object, e As EventArgs) Handles btnBveraendern.Click, btnSveraendern.Click, btnKveraendern.Click, btnPveraendern.Click
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        Select Case TabControl1.SelectedIndex
            Case 0
                If tbBVpasswort.Text = "" Then
                    tbBVpasswort.BackColor = Color.Red
                Else
                    cmd.CommandText = "UPDATE benutzer SET benutzername = '" & tbBVbenutzer.Text & "', passwort = '" & tbBVpasswort.Text & "', vorname= '" & tbBVvorname.Text & "', nachname = '" & tbBVnachname.Text &
                    "', rechte = '" & flow.db.getRechteID(cbBVrechte.SelectedItem) & "' WHERE bid = " & dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";"
                    If Not tbBVpasswort.Text = "" Then
                        cmd.CommandText &= "SET PASSWORD FOR '" & tbBVbenutzer.Text & "'@'%' = PASSWORD('" & tbBVpasswort.Text & "');"
                    End If
                    tbBVpasswort.Clear()
                End If
            Case 1
                If tbSVstatus.Text = "" Then
                    tbSVstatus.BackColor = Color.Red
                Else
                    cmd.CommandText = "UPDATE status SET status = '" & tbSVstatus.Text & "' WHERE sid = " & dgvStatusverwaltung.Rows(dgvStatusverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";"
                    tbSVstatus.Clear()
                End If
            Case 2
                If tbKVkategorie.Text = "" Then
                    tbKVkategorie.BackColor = Color.Red
                Else
                    cmd.CommandText = "UPDATE kategorien SET kategorie = '" & tbKVkategorie.Text & "' WHERE kid = " & dgvKategorienverwaltung.Rows(dgvKategorienverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";"
                    tbKVkategorie.Clear()
                End If
            Case 3
                If tbPVprioritaet.Text = "" Then
                    tbPVprioritaet.BackColor = Color.Red
                Else
                    cmd.CommandText = "UPDATE prio SET prioritaet = '" & tbPVprioritaet.Text & "' WHERE pid = " & dgvPrioritaetenverwaltung.Rows(dgvPrioritaetenverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";"
                    tbPVprioritaet.Clear()
                End If
        End Select
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TabControl1_SelectedIndexChanged(sender, e)
        SelectionChanged(sender, e)
        dgvs(TabControl1.SelectedIndex).Focus()
    End Sub

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnBloeschen.Click, btnSloeschen.Click, btnKloeschen.Click, btnPloeschen.Click
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        Select Case TabControl1.SelectedIndex
            Case 0
                cmd.CommandText = "DELETE FROM benutzer WHERE bid = " & dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";
            DROP USER '" & dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(1).Value & "';"
            Case 1
                cmd.CommandText = "DELETE FROM status WHERE sid = " & dgvStatusverwaltung.Rows(dgvStatusverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";"
            Case 2
                cmd.CommandText = "DELETE FROM kategorie WHERE kid = " & dgvKategorienverwaltung.Rows(dgvKategorienverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";"
            Case 3
                cmd.CommandText = "DELETE FROM prio WHERE pid = " & dgvPrioritaetenverwaltung.Rows(dgvPrioritaetenverwaltung.CurrentCellAddress.Y).Cells(0).Value & ";"
        End Select
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TabControl1_SelectedIndexChanged(sender, e)
        SelectionChanged(sender, e)

    End Sub

    Private Sub SelectionChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged, dgvBenutzerverwaltung.SelectionChanged, dgvKategorienverwaltung.SelectionChanged, dgvPrioritaetenverwaltung.SelectionChanged, dgvStatusverwaltung.SelectionChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                tbBVbenutzer.Text = dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(1).Value
                tbBVvorname.Text = dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(2).Value
                tbBVnachname.Text = dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(3).Value
                cbBVrechte.SelectedItem = dgvBenutzerverwaltung.Rows(dgvBenutzerverwaltung.CurrentCellAddress.Y).Cells(4).Value
                CancelButton = btnBvSchliessen
            Case 1
                tbSVstatus.Text = dgvStatusverwaltung.Rows(dgvStatusverwaltung.CurrentCellAddress.Y).Cells(1).Value
                CancelButton = btnSvSchliessen
            Case 2
                tbKVkategorie.Text = dgvKategorienverwaltung.Rows(dgvKategorienverwaltung.CurrentCellAddress.Y).Cells(1).Value
                CancelButton = btnKvSchliessen
            Case 3
                tbPVprioritaet.Text = dgvPrioritaetenverwaltung.Rows(dgvPrioritaetenverwaltung.CurrentCellAddress.Y).Cells(1).Value
                CancelButton = btnPvSchliessen
        End Select

        For Each tp As TabPage In TabControl1.Controls.OfType(Of TabPage)
            For Each dgv As DataGridView In tp.Controls.OfType(Of DataGridView)
                For r = 0 To dgv.Rows.Count - 1
                    For i = 0 To dgv.Columns.GetColumnCount(DataGridViewElementStates.None) - 1
                        If CBool(r Mod 2) Then
                            dgv.Rows(r).Cells(i).Style.BackColor = My.Settings.evenRowBackColor
                        Else
                            dgv.Rows(r).Cells(i).Style.BackColor = My.Settings.oddRowBackColor
                        End If
                        dgv.Rows(r).Cells(i).Style.ForeColor = My.Settings.evenRowForeColor
                    Next
                Next
                For i = 0 To dgv.Columns.GetColumnCount(DataGridViewElementStates.None) - 1
                    dgv.Rows(dgv.CurrentCellAddress.Y).Cells(i).Style.BackColor = My.Settings.selectedRowBackColor
                    dgv.Rows(dgv.CurrentCellAddress.Y).Cells(i).Style.ForeColor = My.Settings.selectetRowForeColor
                Next
            Next
        Next

    End Sub

    Private Sub tpBenutzerverwaltung_Enter(sender As Object, e As EventArgs) Handles tpBenutzerverwaltung.Enter
        TabControl1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub tbV_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBVpasswort.KeyDown, tbSVstatus.KeyDown, tbKVkategorie.KeyDown, tbPVprioritaet.KeyDown
        e.Handled = True
        sender.BackColor = Color.FromArgb(111, 111, 111)
        If e.KeyData = Keys.Enter Then
            btnVeraendern_Click(sender, New EventArgs)
        End If
    End Sub

    Private Sub tbA_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBApasswort.KeyDown, tbSAstatus.KeyDown, tbKAkategorie.KeyDown, tbPAprioritaet.KeyDown
        e.Handled = True
        If e.KeyData = Keys.Enter Then
            btnAnlegen_Click(sender, New EventArgs)
        End If
    End Sub
End Class