Imports MySql.Data.MySqlClient
Imports System.Security
Public Class flow
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Public benutzer
    Public passwort
    Public rechte As String
    Dim neueAufgabe = False
    Dim prios() = {"PRIORITÄT AUSWÄHLEN", "1 - Dringend | Wichtig", "2 - Dringend | Weniger Wichtig", "3 - Nicht Dringend | Wichtig", "4 - Nicht Dringend | Weniger Wichtig"}
    Dim status() = {"STATUS AUSWÄHLEN", "Offen", "In Bearbeitung", "Geschlossen"}
    Dim benutzerArray(,)
    Dim lastSelected As New Point
    Public angemeldet As Boolean = False

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anmeldung.ShowDialog()

        If angemeldet Then
            AnmeldenToolStripMenuItem.Visible = False
            AbmeldenToolStripMenuItem.Visible = True
            If rechte.Contains("ADMIN") Then
                BenutzerverwaltungToolStripMenuItem.Visible = True
            Else
                BenutzerverwaltungToolStripMenuItem.Visible = False
            End If
        Else
            AnmeldenToolStripMenuItem.Visible = True
            AbmeldenToolStripMenuItem.Visible = False
            BenutzerverwaltungToolStripMenuItem.Visible = False
        End If
        tslInfo.Text = "Angemeldet als " & benutzer

        cbStatus.Items.AddRange(status)
        cbNeuStatus.Items.AddRange(status)
        cbNeuStatus.SelectedIndex = 0

        cbPrio.Items.AddRange(prios)
        cbNeuPrio.Items.AddRange(prios)
        cbNeuPrio.SelectedIndex = 0

        If angemeldet Then
            cbKategorie.Items.AddRange(getKategorien)
            cbNeuKategorie.Items.Add("KATEGORIE AUSWÄHLEN")
            cbNeuKategorie.Items.AddRange(getKategorien)
            cbNeuKategorie.SelectedIndex = 0

            cbBearbeiter.Items.AddRange(getBenutzer)
            cbNeuBearbeiter.Items.Add("BEARBEITER AUSWÄHLEN")
            cbNeuBearbeiter.Items.AddRange(getBenutzer)
            cbNeuBearbeiter.SelectedIndex = 0

            If rechte.Contains("ADMIN") Then
                cbStatus.Items.Add("ABGESCHLOSSEN")
                cbNeuStatus.Items.Add("ABGESCHLOSSEN")
            End If
        End If
        fillDGV()

    End Sub
    Sub fillDGV()
        dgvUebersicht.Rows.Clear()
        dgvUebersicht.Columns.Clear()

        If Not angemeldet Then
            Exit Sub
        End If
        If rechte.Contains("ADMIN") Then
            con.Close()
            con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT COUNT(*) AS Anzahl FROM aufgaben;"
            con.Open()
            reader = cmd.ExecuteReader
            reader.Read()
            Dim anzahl As Integer = reader("Anzahl")
            con.Close()
            cmd.CommandText = "SELECT * FROM aufgaben INNER JOIN benutzer ON bearbeiter = bid;"

            dgvUebersicht.Columns.Add("aid", "ID")
            dgvUebersicht.Columns.Add("titel", "Titel")
            dgvUebersicht.Columns.Add("beschreibung", "Beschreibung")
            dgvUebersicht.Columns.Add("status", "Status")
            dgvUebersicht.Columns.Add("prio", "Priorität")
            dgvUebersicht.Columns.Add("kategorie", "Kategorie")
            dgvUebersicht.Columns.Add("stand", "Aktueller Stand")
            dgvUebersicht.Columns.Add("bearbeiter", "Bearbeiter")
            dgvUebersicht.Columns.Add("ticketnr", "Ticket#")
            dgvUebersicht.Columns.Add("erstellt", "Erstelldatum")
            dgvUebersicht.Columns.Add("bearbeitet", "Änderungsdatum")
            dgvUebersicht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells


            dgvUebersicht.Rows.Add(anzahl)

            Try
                con.Open()
                reader = cmd.ExecuteReader
                Dim z = 0
                Do While reader.Read
                    dgvUebersicht.Rows(z).Cells(0).Value = reader("aid")
                    dgvUebersicht.Rows(z).Cells(1).Value = reader("titel")
                    dgvUebersicht.Rows(z).Cells(2).Value = reader("beschreibung")
                    dgvUebersicht.Rows(z).Cells(3).Value = reader("status")
                    dgvUebersicht.Rows(z).Cells(4).Value = reader("prio")
                    dgvUebersicht.Rows(z).Cells(5).Value = reader("kategorie")
                    dgvUebersicht.Rows(z).Cells(6).Value = reader("staende")
                    dgvUebersicht.Rows(z).Cells(7).Value = reader("vorname") & " " & reader("nachname")
                    dgvUebersicht.Rows(z).Cells(8).Value = reader("ticketnr")
                    dgvUebersicht.Rows(z).Cells(9).Value = reader("erstellt")
                    dgvUebersicht.Rows(z).Cells(10).Value = reader("bearbeitet")

                    z += 1
                Loop
                reader.Close()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf rechte.Contains("DATENPFLEGER") Then
            con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT COUNT(*) AS Anzahl FROM aufgaben WHERE bearbeiter = (SELECT bid FROM benutzer WHERE benutzername = '" & benutzer & "');"
            con.Open()
            reader = cmd.ExecuteReader
            reader.Read()
            Dim anzahl As Integer = 0
            anzahl += reader("Anzahl")
            con.Close()
            cmd.CommandText = "SELECT * FROM aufgaben INNER JOIN benutzer ON bearbeiter = bid WHERE bearbeiter = (SELECT bid FROM benutzer WHERE benutzername = '" & benutzer & "');"
            dgvUebersicht.Columns.Add("aid", "ID")
            dgvUebersicht.Columns.Add("titel", "Titel")
            dgvUebersicht.Columns.Add("beschreibung", "Beschreibung")
            dgvUebersicht.Columns.Add("status", "Status")
            dgvUebersicht.Columns.Add("prio", "Priorität")
            dgvUebersicht.Columns.Add("kategorie", "Kategorie")
            dgvUebersicht.Columns.Add("stand", "Aktueller Stand")
            dgvUebersicht.Columns.Add("bearbeiter", "Bearbeiter")
            dgvUebersicht.Columns.Add("ticketnr", "Ticket#")
            dgvUebersicht.Columns.Add("erstellt", "Erstelldatum")
            dgvUebersicht.Columns.Add("bearbeitet", "Änderungsdatum")
            dgvUebersicht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

            If anzahl = 0 Then
                anzahl = 1
            End If
            dgvUebersicht.Rows.Add(anzahl)

            Try
                con.Open()
                reader = cmd.ExecuteReader
                Dim z = 0
                Do While reader.Read
                    dgvUebersicht.Rows(z).Cells(0).Value = reader("aid")
                    dgvUebersicht.Rows(z).Cells(1).Value = reader("titel")
                    dgvUebersicht.Rows(z).Cells(2).Value = reader("beschreibung")
                    dgvUebersicht.Rows(z).Cells(3).Value = reader("status")
                    dgvUebersicht.Rows(z).Cells(4).Value = reader("prio")
                    dgvUebersicht.Rows(z).Cells(5).Value = reader("kategorie")
                    dgvUebersicht.Rows(z).Cells(6).Value = reader("staende")
                    dgvUebersicht.Rows(z).Cells(7).Value = reader("vorname") & " " & reader("nachname")
                    dgvUebersicht.Rows(z).Cells(8).Value = reader("ticketnr")
                    dgvUebersicht.Rows(z).Cells(9).Value = reader("erstellt")
                    dgvUebersicht.Rows(z).Cells(10).Value = reader("bearbeitet")

                    z += 1
                Loop
                reader.Close()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Function getBenutzer()
        Dim arrayLaenge As Integer
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank

        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) AS Anzahl FROM benutzer;"
        cmd.CommandType = CommandType.Text
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read
                arrayLaenge = reader("Anzahl").ToString
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'benutzername 0, vorname 1, nachname 2
        Dim nutzer(arrayLaenge - 1, 2)
        Dim bnutzer(arrayLaenge - 1)

        cmd.CommandText = "SELECT * FROM benutzer ORDER BY benutzername ASC;"
        cmd.CommandType = CommandType.Text

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Dim z = 0
            Do While reader.Read
                nutzer(z, 0) = reader("benutzername")
                nutzer(z, 1) = reader("vorname")
                nutzer(z, 2) = reader("nachname")
                bnutzer(z) = nutzer(z, 1) & " " & nutzer(z, 2)
                z += 1
            Loop
            'Array.Sort(nutzer)
            'MsgBox(kategorien(0) & vbCrLf & kategorien(1))
            reader.Close()
            con.Close()
            benutzerArray = nutzer
            Return bnutzer
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function
    Function getKategorien()
        Dim arrayLaenge As Integer
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank

        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) AS Anzahl FROM kategorien;"
        cmd.CommandType = CommandType.Text
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read
                arrayLaenge = reader("Anzahl").ToString
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim kategorien(arrayLaenge - 1)


        cmd.CommandText = "SELECT * FROM kategorien;"
        cmd.CommandType = CommandType.Text

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Dim z = 0
            Do While reader.Read
                kategorien(z) = reader("kategorie")
                z += 1
            Loop
            Array.Sort(kategorien)
            'MsgBox(kategorien(0) & vbCrLf & kategorien(1))
            reader.Close()
            con.Close()
            Return kategorien
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        benutzer = Nothing
        passwort = Nothing
    End Sub

    Private Sub btnBearbeitetUpdate_Click(sender As Object, e As EventArgs) Handles btnBearbeitetUpdate.Click
        Try
            con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank
            Dim temp() = cbBearbeiter.SelectedItem.ToString.Split(" ")
            MsgBox(temp(0) & temp(1))
            Dim bname
            'b 0, v 1, n 2
            For i = 0 To benutzerArray.Length / 3 - 1
                If temp(0) = benutzerArray(i, 1) And temp(1) = benutzerArray(i, 2) Then
                    bname = benutzerArray(i, 0)
                End If
            Next
            MsgBox(bname)
            cmd.Connection = con
            cmd.CommandText = "UPDATE aufgaben SET titel = '" & tbTitel.Text & "', beschreibung = '" & tbBeschreibung.Text &
                "', bearbeiter = (SELECT bid FROM benutzer WHERE benutzername = '" & bname & "'), ticketnr = '" & tbTicketNr.Text & "', status = '" & cbStatus.SelectedItem &
                "', prio = '" & cbPrio.SelectedIndex & "', kategorie = '" & cbKategorie.SelectedIndex & "' WHERE aid = " & lblID.Text & ";"
            cmd.CommandType = CommandType.Text
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub


    'Private Sub dgv1_RightClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgv1.CellMouseUp
    '    If e.Button <> Windows.Forms.MouseButtons.Right Then Return
    '    Dim cms = New ContextMenuStrip
    '    Dim item1 = cms.Items.Add("foo")
    '    item1.Tag = 1
    '    AddHandler item1.Click, AddressOf menuChoice
    '    Dim item2 = cms.Items.Add("bar")
    '    item2.Tag = 2
    '    AddHandler item2.Click, AddressOf menuChoice
    '    '-- etc
    '    '..
    '    'cms.Show(dgv1, e.Location)

    'End Sub
    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        '-- etc
    End Sub
    Private Sub dgv1_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Dim p As New Point(0, 0)
        'p = dgv1.CurrentCellAddress
        'Dim temp = dgv1.Item(p.X, p.Y).Value
        'updateDB(p.Y, dgv1.Columns(p.X).HeaderText, temp)
        ' MsgBox(p.X)

    End Sub


    Private Sub AnmeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnmeldenToolStripMenuItem.Click
        'Anmeldung.ShowDialog()
        'If angemeldet Then
        '    AnmeldenToolStripMenuItem.Visible = False
        '    AbmeldenToolStripMenuItem.Visible = True
        'Else
        '    AnmeldenToolStripMenuItem.Visible = True
        '    AbmeldenToolStripMenuItem.Visible = False
        'End If
        'fillDGV()
        'tslInfo.Text = "Angemeldet als " & benutzer
        Form1_Load(New Object, New EventArgs)
    End Sub

    Private Sub AbmeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbmeldenToolStripMenuItem.Click
        angemeldet = False
        rechte = Nothing
        AnmeldenToolStripMenuItem.Visible = True
        AbmeldenToolStripMenuItem.Visible = False
        BenutzerverwaltungToolStripMenuItem.Visible = False
        benutzer = Nothing
        passwort = Nothing
        fillDGV()
        tslInfo.Text = "Nicht angemeldet"
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tpUebersicht_Enter(sender As Object, e As EventArgs) Handles tpUebersicht.Enter
        fillDGV()
        If angemeldet Then
            dgvUebersicht.CurrentCell = dgvUebersicht.Rows(lastSelected.Y).Cells(lastSelected.X)
        End If
        'lastSelected.X = 0
        'lastSelected.Y = 0
    End Sub

    Private Sub tpBearbeiten_Enter(sender As Object, e As EventArgs) Handles tpBearbeiten.Enter
        If angemeldet Then
            lastSelected.X = dgvUebersicht.CurrentCellAddress.X
            lastSelected.Y = dgvUebersicht.CurrentCellAddress.Y
            Dim selectedID = dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(0).Value
            con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM aufgaben INNER JOIN staende ON aufgaben.staende = staende.sid INNER JOIN benutzer ON aufgaben.bearbeiter = benutzer.bid WHERE aufgaben.aid = " & selectedID & ";"
            cmd.CommandType = CommandType.Text
            Try
                con.Open()
                reader = cmd.ExecuteReader()
                Do While reader.Read
                    lblID.Text = reader("aid").ToString
                    tbTitel.Text = reader("titel")
                    tbBeschreibung.Text = reader("beschreibung")
                    tbTicketNr.Text = reader("ticketnr")
                    tbLetzterStand.Text = reader("stand")
                    cbStatus.SelectedItem() = reader("status")
                    cbPrio.SelectedItem() = reader("prio")

                    cbBearbeiter.SelectedItem() = reader("vorname") & " " & reader("nachname")

                    cbKategorie.SelectedItem() = reader("kategorie")

                Loop
                reader.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub tpAufgabeErstellen_Enter(sender As Object, e As EventArgs) Handles tpAufgabeErstellen.Enter
        lastSelected.X = dgvUebersicht.CurrentCellAddress.X
        lastSelected.Y = dgvUebersicht.CurrentCellAddress.Y
        'MsgBox("Aufgabe erstellen")
    End Sub

    Private Sub btnNeuInsert_Click(sender As Object, e As EventArgs) Handles btnNeuInsert.Click

        Try
            con.Close()
            con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank
            If cbNeuBearbeiter.SelectedItem.ToString.Contains("AUSWÄHLEN") Or cbNeuStatus.SelectedItem.ToString.Contains("AUSWÄHLEN") Or cbNeuPrio.SelectedItem.ToString.Contains("AUSWÄHLEN") Or cbNeuKategorie.SelectedItem.ToString.Contains("AUSWÄHLEN") Then
                MsgBox("Bearbeiter, Status, Priorität und Kategorie müssen ausgewählt werden!")
                Exit Sub
            End If
            Dim temp() = cbNeuBearbeiter.SelectedItem.ToString.Split(" ")
            Dim bname
            'b 0, v 1, n 2
            For i = 0 To benutzerArray.Length / 3 - 1
                If temp(0) = benutzerArray(i, 1) And temp(1) = benutzerArray(i, 2) Then
                    bname = benutzerArray(i, 0)
                End If
            Next
            cmd.Connection = con '" & cbBearbeiter.SelectedItem.ToString & "
            cmd.CommandText = "INSERT INTO aufgaben (titel, beschreibung, bearbeiter, ticketnr, status, prio, kategorie, bearbeitet) VALUES ('" & tbNeuTitel.Text & "', '" & tbNeuBeschreibung.Text &
                "', (SELECT bid FROM benutzer WHERE benutzername = '" & bname & "'), '" & tbNeuTicketNr.Text & "', '" & cbNeuStatus.SelectedItem.ToString & "', '" & cbNeuPrio.SelectedItem.ToString &
                "', '" & cbNeuKategorie.SelectedItem.ToString & "', NOW());"
            cmd.CommandType = CommandType.Text
            MsgBox(cmd.CommandText)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            If angemeldet Then
                MsgBox(ex.ToString)
            Else
                MsgBox("Kein Benutzer angemeldet")
            End If

        End Try


    End Sub


    Private Sub btnAbbrechenBearbeiten_Click(sender As Object, e As EventArgs) Handles btnAbbrechenBearbeiten.Click
        tbBeschreibung.Clear()
        tbStand.Clear()
        tbTitel.Clear()
        tbTicketNr.Clear()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Angemeldet: " & benutzer & vbCrLf & "Server: " & My.Settings.server & vbCrLf & "Datenbank: " & My.Settings.datenbank & vbCrLf & "Rechte: " & rechte)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAktualisieren.Click
        fillDGV()
    End Sub

    Private Sub dgvUebersicht_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUebersicht.CellDoubleClick
        tpBearbeiten_Enter(New Object, New EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub BenutzerverwaltungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BenutzerverwaltungToolStripMenuItem.Click
        Benutzerverwaltung.Show()
    End Sub
End Class
