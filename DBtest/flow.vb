﻿Imports MySql.Data.MySqlClient
Imports System.Security
Public Class flow
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Public benutzer
    Public passwort
    Public myVorname
    Public myNachname
    Public myFullname
    Public rechte As String
    Dim neueAufgabe = False
    Dim prios()
    Dim status()
    Dim benutzerArray(,)
    Dim VorNachNamen() As String
    Dim kategorien()
    Public data As New List(Of String())
    Public filteredData As New List(Of String())
    Dim lastSelected As New Point
    Public angemeldet As Boolean = False
    Public db
    Dim ausgefahren = False
    Dim WithEvents ti As New Timer
    Dim failure = False
    Public aktKategorien(), aktStatus(), aktPrios()

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anmeldung.ShowDialog()
        setSettings()

        If angemeldet Then
            AnmeldenToolStripMenuItem.Visible = False
            AbmeldenToolStripMenuItem.Visible = True
            If rechte.Contains("ADMIN") Then
                VerwaltungToolStripMenuItem.Visible = True
            Else
                VerwaltungToolStripMenuItem.Visible = False
            End If
            db = New dbAccess(benutzer, passwort)
        Else
            AnmeldenToolStripMenuItem.Visible = True
            AbmeldenToolStripMenuItem.Visible = False
            VerwaltungToolStripMenuItem.Visible = False
            db = Nothing
        End If
        tslInfo.Text = "Angemeldet als " & benutzer

        prios = getPrios()
        status = getStatus()
        kategorien = getKategorien()
        VorNachNamen = getBenutzer()

        aktKategorien = My.Settings.startKategorien.Split(Einstellungen.splitter)
        aktStatus = My.Settings.startStatus.Split(Einstellungen.splitter)
        aktPrios = My.Settings.startPrios.Split(Einstellungen.splitter)

        Try
            cbStatus.Items.AddRange(status)
            cbNeuStatus.Items.AddRange(status)
            cbNeuStatus.SelectedIndex = 0

            cbPrio.Items.AddRange(prios)
            cbNeuPrio.Items.AddRange(prios)
            cbNeuPrio.SelectedIndex = 0

            If angemeldet Then
                cbKategorie.Items.AddRange(kategorien)
                cbNeuKategorie.Items.AddRange(kategorien)
                cbNeuKategorie.SelectedIndex = 0

                cbBearbeiter.Items.AddRange(getBenutzer)
                cbNeuBearbeiter.Items.AddRange(getBenutzer)
                cbNeuBearbeiter.SelectedItem = myFullname

                Filter.sFilter.Clear()
                Filter.pFilter.Clear()
                Filter.bFilter.Clear()
                Filter.kFilter.Clear()
                For Each item In status
                    Filter.sFilter.Add(item, aktStatus.Contains(item))
                Next
                For Each item In prios
                    Filter.pFilter.Add(item, aktPrios.Contains(item))
                Next

                Filter.bFilter.Item(myFullname) = True
                For Each item In VorNachNamen
                    If item <> myFullname Then
                        Filter.bFilter.Add(item, False)
                    End If
                Next

                For Each item In kategorien
                    Filter.kFilter.Add(item, aktKategorien.Contains(item))
                Next

                For Each tabp As TabPage In TabControl1.Controls.OfType(Of TabPage)
                    For Each item As Button In tabp.Controls.OfType(Of Button)
                        item.Enabled = True
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tpUebersicht_Enter(New Object, New EventArgs)

    End Sub

    Sub getAllAufgaben()
        If rechte = "ADMIN" Then
            cmd.CommandText = "SELECT aid, titel, beschreibung, status, prio, kategorie, bearbeiter, ticketnr, erstellt, bearbeitet, nachname, vorname FROM aufgaben INNER JOIN benutzer ON bearbeiter = bid;"
        ElseIf rechte = "USER" Then
            cmd.CommandText = "SELECT aid, titel, beschreibung, status, prio, kategorie, bearbeiter, ticketnr, erstellt, bearbeitet, nachname, vorname FROM aufgaben INNER JOIN benutzer ON aufgaben.bearbeiter = benutzer.bid WHERE benutzer.benutzername = '" & benutzer & "';"
        End If
        Try
            Dim arr(10) As String
            con.Open()
            reader = cmd.ExecuteReader
            Dim z = 0
            Do While reader.Read
                data.Add(New String(10) {})
                z = data.Count - 1
                data.Item(z)(0) = reader("aid")
                data.Item(z)(1) = reader("titel")
                data.Item(z)(2) = reader("beschreibung")
                data.Item(z)(3) = db.getStatusValue(reader("status"))
                data.Item(z)(4) = db.getPrioValue(reader("prio"))
                data.Item(z)(5) = db.getKategorieValue(reader("kategorie"))
                data.Item(z)(6) = db.getNeusterStandValue(data.Item(z)(0))
                data.Item(z)(7) = reader("vorname") & " " & reader("nachname")
                data.Item(z)(8) = reader("ticketnr")
                data.Item(z)(9) = reader("erstellt")
                data.Item(z)(10) = reader("bearbeitet")
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
            con.Close()
        End Try
    End Sub

    Sub proceedFilter(s() As KeyValuePair(Of String, Boolean), p() As KeyValuePair(Of String, Boolean), b() As KeyValuePair(Of String, Boolean), k() As KeyValuePair(Of String, Boolean))
        filteredData = data
        Dim toRemoveRows As New List(Of String())
        For Each row In data
            For Each item In s
                If Not item.Value Then
                    If item.Key = row(3) Then ' benutzer = aufgabenbearbeiter ?
                        toRemoveRows.Add(row)

                    End If
                End If
            Next
            For Each item In p
                If Not item.Value Then
                    If item.Key = row(4) Then
                        toRemoveRows.Add(row)

                    End If
                End If
            Next
            For Each item In b
                If Not item.Value Then
                    If item.Key = row(7) Then
                        toRemoveRows.Add(row)
                    End If
                End If
            Next
            For Each item In k
                If Not item.Value Then
                    If item.Key = row(5) Then
                        toRemoveRows.Add(row)

                    End If
                End If
            Next
        Next
        For Each item In toRemoveRows
            filteredData.Remove(item)
        Next
    End Sub
    Sub proceedFilter(bearbeiter() As KeyValuePair(Of String, Boolean))
        filteredData = data
        Dim toRemoveRows As New List(Of String())
        For Each row In data
            For Each item In bearbeiter
                If Not item.Value Then
                    If item.Key = row(7) Then ' benutzer = aufgabenbearbeiter ?
                        toRemoveRows.Add(row)
                    End If
                End If
            Next
        Next
        For Each item In toRemoveRows
            MsgBox(item)
            filteredData.Remove(item)
        Next
    End Sub

    Sub fillDGV()
        dgvUebersicht.Rows.Clear()
        dgvUebersicht.Columns.Clear()
        filteredData.Clear()

        If angemeldet Then
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

            Filter.spalten.Clear()
            Filter.clbSpalten.Items.Clear()
            For Each item In dgvUebersicht.Columns
                Filter.clbSpalten.Items.Add(item.headertext)
                Filter.spalten.Add(item.headertext, True)
            Next


            getAllAufgaben()
            proceedFilter(Filter.sFilter.ToArray, Filter.pFilter.ToArray, Filter.bFilter.ToArray, Filter.kFilter.ToArray)
            'proceedFilter(Filter.bFilter.ToArray)

            If filteredData.Count = 0 Then
                dgvUebersicht.Rows.Add(1)
            Else
                For z = 0 To filteredData.Count - 1
                    dgvUebersicht.Rows.Add(1)

                    dgvUebersicht.Rows(z).Cells(0).Value = filteredData.Item(z)(0)
                    dgvUebersicht.Rows(z).Cells(1).Value = filteredData.Item(z)(1)
                    dgvUebersicht.Rows(z).Cells(2).Value = filteredData.Item(z)(2)
                    dgvUebersicht.Rows(z).Cells(3).Value = filteredData.Item(z)(3)
                    dgvUebersicht.Rows(z).Cells(4).Value = filteredData.Item(z)(4)
                    dgvUebersicht.Rows(z).Cells(5).Value = filteredData.Item(z)(5)
                    dgvUebersicht.Rows(z).Cells(6).Value = filteredData.Item(z)(6)
                    dgvUebersicht.Rows(z).Cells(7).Value = filteredData.Item(z)(7)
                    dgvUebersicht.Rows(z).Cells(8).Value = filteredData.Item(z)(8)
                    dgvUebersicht.Rows(z).Cells(9).Value = filteredData.Item(z)(9)
                    dgvUebersicht.Rows(z).Cells(10).Value = filteredData.Item(z)(10)
                Next
            End If

        End If

        dgvUebersicht_SelectionChanged(New Object, New EventArgs)
    End Sub
    Function getBenutzer() As String()
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
        Dim bnutzer(arrayLaenge - 1) As String

        cmd.CommandText = "SELECT benutzername, vorname, nachname FROM benutzer ORDER BY benutzername ASC;"
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
        Dim result As New List(Of String)
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM kategorien;"
        cmd.CommandType = CommandType.Text
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read
                result.Add(reader("kategorie"))
            Loop
            Dim res() = result.ToArray
            Array.Sort(res)
            reader.Close()
            con.Close()
            Return res
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Function

    Function getPrios()
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM prio order by pid;"
        cmd.CommandType = CommandType.Text
        Dim result As New List(Of String)
        Try
            con.Open()
            reader = cmd.ExecuteReader
            While reader.Read
                result.Add(reader("prioritaet"))
            End While
            reader.Close()
            con.Close()
            Return result.ToArray
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Function getStatus()
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM status order by sid;"
        cmd.CommandType = CommandType.Text
        Dim result As New List(Of String)
        Try
            con.Open()
            reader = cmd.ExecuteReader
            While reader.Read
                result.Add(reader("status"))
            End While
            reader.Close()
            con.Close()
            Return result.ToArray
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function




    Public Function getAllStaendeFrom(aufgabenID As String) As String(,)
        Dim arrayLaenge = 0
        cmd.CommandText = "SELECT COUNT(*) AS Anzahl FROM staende WHERE aufgabe = '" & aufgabenID & "';"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            arrayLaenge = reader("Anzahl") - 1
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        cmd.CommandText = "SELECT stand, erstellt, bearbeiter FROM staende WHERE aufgabe = '" & aufgabenID & "';"
        Dim result(arrayLaenge, 2) As String
        Try
            con.Open()
            reader = cmd.ExecuteReader

            For z = 0 To arrayLaenge
                reader.Read()
                result(z, 0) = reader("stand").ToString
                result(z, 1) = reader("erstellt").ToString
                result(z, 2) = db.getBenutzerValue(reader("bearbeiter"))
            Next
            reader.Close()
            con.Close()
            Return result
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        benutzer = Nothing
        passwort = Nothing
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        '-- etc
    End Sub


    Private Sub AnmeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnmeldenToolStripMenuItem.Click
        Form1_Load(New Object, New EventArgs)
    End Sub

    Private Sub AbmeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbmeldenToolStripMenuItem.Click
        angemeldet = False
        rechte = Nothing
        AnmeldenToolStripMenuItem.Visible = True
        AbmeldenToolStripMenuItem.Visible = False
        VerwaltungToolStripMenuItem.Visible = False
        benutzer = Nothing
        passwort = Nothing
        fillDGV()
        tslInfo.Text = "Nicht angemeldet"
        For Each tabp As TabPage In TabControl1.Controls.OfType(Of TabPage)
            For Each item As TextBox In tabp.Controls.OfType(Of TextBox)
                item.Clear()
            Next
            For Each item As ComboBox In tabp.Controls.OfType(Of ComboBox)
                item.Items.Clear()
            Next
            For Each item As Button In tabp.Controls.OfType(Of Button)
                item.Enabled = False
            Next
        Next
    End Sub

    Friend Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tpUebersicht_Enter(sender As Object, e As EventArgs) Handles tpUebersicht.Enter
        'AcceptButton = Nothing
        'CancelButton = Nothing
        fillDGV()
        If angemeldet Then
            Try
                dgvUebersicht.CurrentCell = dgvUebersicht.Rows(lastSelected.Y).Cells(lastSelected.X)
            Catch ex As Exception
                dgvUebersicht.Rows.Add(1)
            End Try
        End If
        dgvUebersicht_SelectionChanged(sender, e)
        'lastSelected.X = 0
        'lastSelected.Y = 0
    End Sub

    Private Sub btnNeuInsert_Click(sender As Object, e As EventArgs) Handles btnNeuErstellen.Click
        If tbNeuTitel.Text = "" Or tbNeuBeschreibung.Text = "" Then
            MsgBox("Bitte Felder ausfüllen")
        Else
            Try
                Dim temp() = cbNeuBearbeiter.SelectedItem.ToString.Split(" ")
                Dim bname = ""
                'b 0, v 1, n 2
                For i = 0 To benutzerArray.Length / 3 - 1
                    If temp(0) = benutzerArray(i, 1) And temp(1) = benutzerArray(i, 2) Then
                        bname = benutzerArray(i, 0)
                    End If
                Next


                cmd.CommandText = "INSERT INTO aufgaben (titel, beschreibung, bearbeiter, ticketnr, status, prio, kategorie, bearbeitet) VALUES ('" & tbNeuTitel.Text & "', '" & tbNeuBeschreibung.Text &
                    "', (SELECT bid FROM benutzer WHERE benutzername = '" & bname & "'), '" & tbNeuTicketNr.Text & "', '" & db.getStatusID(cbNeuStatus.SelectedItem.ToString) & "', '" & db.getPrioID(cbNeuPrio.SelectedItem.ToString) &
                    "', '" & db.getKategorieID(cbNeuKategorie.SelectedItem.ToString) & "', NOW());"
                query()
                'con.Open()
                'cmd.ExecuteNonQuery()
                cmd.CommandText = "INSERT INTO staende (stand, aufgabe, bearbeiter) VALUES ('" & tbNeuBeschreibung.Text & "', '" & db.getAufgabeID(tbNeuTitel.Text) & "', '" & db.getBenutzerID(benutzer) & "');"
                query()
                'cmd.ExecuteNonQuery()
            Catch ex As Exception
                If angemeldet Then
                    MsgBox(ex.ToString)
                Else
                    MsgBox("Kein Benutzer angemeldet")
                End If
            Finally
                'con.Close()
            End Try
            TabControl1.SelectedTab = tpUebersicht
        End If
    End Sub

    Private Sub btnBearbeitetUpdate_Click(sender As Object, e As EventArgs) Handles btnBearbeitet.Click
        Try
            Dim temp() = cbBearbeiter.SelectedItem.ToString.Split(" ")
            Dim bname = ""
            'b 0, v 1, n 2
            For i = 0 To benutzerArray.Length / 3 - 1 'get in combobox ausgewählter Benutzer
                If temp(0) = benutzerArray(i, 1) And temp(1) = benutzerArray(i, 2) Then
                    bname = benutzerArray(i, 0)
                End If
            Next

            'con.Open()
            If tbStand.Text <> "" Then
                cmd.CommandText = "INSERT INTO staende (stand, aufgabe, bearbeiter) VALUES ('" & tbStand.Text & "', '" & lblID.Text & "', '" & db.getBenutzerID(benutzer) & "');"
                'cmd.ExecuteNonQuery()
                query()
            End If
            cmd.CommandText = "UPDATE aufgaben SET titel = '" & tbTitel.Text & "', beschreibung = '" & tbBeschreibung.Text &
                "', bearbeiter = '" & db.getBenutzerID(bname) & "', ticketnr = '" & tbTicketNr.Text & "', status = '" & db.getStatusID(cbStatus.SelectedItem) &
                "', prio = '" & db.getPrioID(cbPrio.SelectedItem) & "', kategorie = '" & db.getKategorieID(cbKategorie.SelectedItem) & "' WHERE aid = " & lblID.Text & ";"
            'cmd.ExecuteNonQuery()
            query()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            'con.Close()
        End Try
        If tbStand.Text <> "" Then
            tbLetzterStand.Text = tbStand.Text
            tbStand.Clear()
        End If
        btnAbbrechenBearbeiten_Click(New Object, New EventArgs)
    End Sub
    Private Sub tpBearbeiten_Enter(sender As Object, e As EventArgs) Handles tpBearbeiten.Enter
        If dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(0).Value <> Nothing Then
            'AcceptButton = btnAbbrechenBearbeiten
            'CancelButton = btnBearbeitet
            clearAllFieldsBearbeiten()

            If angemeldet Then
                lastSelected.X = dgvUebersicht.CurrentCellAddress.X
                lastSelected.Y = dgvUebersicht.CurrentCellAddress.Y
                Dim selectedID = dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(0).Value

                cmd.CommandText = "SELECT * FROM aufgaben INNER JOIN staende ON aufgaben.aid = staende.aufgabe INNER JOIN benutzer ON aufgaben.bearbeiter = benutzer.bid WHERE aufgaben.aid = " & selectedID & " ORDER BY staende.erstellt DESC LIMIT 1;"
                Try
                    con.Open()
                    reader = cmd.ExecuteReader()
                    reader.Read()
                    lblID.Text = reader("aid").ToString
                    tbTitel.Text = reader("titel")
                    tbBeschreibung.Text = reader("beschreibung")
                    tbTicketNr.Text = reader("ticketnr")
                    tbLetzterStand.Text = db.getNeusterStandValue(reader("aufgabe"))
                    cbStatus.SelectedItem() = db.getStatusValue(reader("status"))
                    cbPrio.SelectedItem() = db.getPrioValue(reader("prio"))

                    cbBearbeiter.SelectedItem() = reader("vorname") & " " & reader("nachname")

                    cbKategorie.SelectedItem() = db.getKategorieValue(reader("kategorie"))
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    reader.Close()
                    con.Close()
                End Try
            End If
        Else

        End If
    End Sub

    Private Sub tpAufgabeErstellen_Enter(sender As Object, e As EventArgs) Handles tpAufgabeErstellen.Enter
        'AcceptButton = btnBearbeitet
        'CancelButton = btnAbbrechenBearbeiten
        clearAllFieldsErstellen()
        lastSelected.X = dgvUebersicht.CurrentCellAddress.X
        lastSelected.Y = dgvUebersicht.CurrentCellAddress.Y
    End Sub




    Private Sub btnAbbrechenBearbeiten_Click(sender As Object, e As EventArgs) Handles btnAbbrechenBearbeiten.Click, btnAbbrechenErstellen.Click
        clearAllFields()
        TabControl1.SelectedIndex = 0
    End Sub

    Sub clearAllFields()
        For Each tabp As TabPage In TabControl1.Controls.OfType(Of TabPage)
            For Each item As TextBox In tabp.Controls.OfType(Of TextBox)
                item.Clear()
            Next
        Next
    End Sub

    Sub clearAllFieldsBearbeiten()
        For Each item As TextBox In tpBearbeiten.Controls.OfType(Of TextBox)
            item.Clear()
        Next

    End Sub

    Sub clearAllFieldsErstellen()
        For Each item As TextBox In tpAufgabeErstellen.Controls.OfType(Of TextBox)
            item.Clear()
        Next

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Angemeldet: " & benutzer & vbCrLf & "Server: " & My.Settings.server & vbCrLf & "Datenbank: " & My.Settings.datenbank & vbCrLf & "Rechte: " & rechte)
    End Sub

    Private Sub btnAktualisieren_Click(sender As Object, e As EventArgs) Handles btnAktualisieren.Click
        fillDGV()
        dgvUebersicht_SelectionChanged(sender, e)
    End Sub

    Private Sub dgvUebersicht_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUebersicht.CellDoubleClick
        tpBearbeiten_Enter(New Object, New EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub BenutzerverwaltungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwaltungToolStripMenuItem.Click
        Verwaltung.ShowDialog()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Filter.ShowDialog()
    End Sub

    Private Sub dgvUebersicht_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUebersicht.SelectionChanged
        Dim columnCount = dgvUebersicht.Columns.GetColumnCount(DataGridViewElementStates.None)
        For r = 0 To dgvUebersicht.Rows.Count - 1
            For i = 0 To columnCount - 1
                If CBool(r Mod 2) Then
                    dgvUebersicht.Rows(r).Cells(i).Style.BackColor = My.Settings.evenRowBackColor
                Else
                    dgvUebersicht.Rows(r).Cells(i).Style.BackColor = My.Settings.oddRowBackColor
                End If
                dgvUebersicht.Rows(r).Cells(i).Style.ForeColor = My.Settings.evenRowForeColor
            Next
        Next
        Try
            For i = 0 To columnCount - 1
                dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(i).Style.BackColor = My.Settings.selectedRowBackColor
                dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(i).Style.ForeColor = My.Settings.selectetRowForeColor
            Next
        Catch ex As Exception
        End Try

        staendeAnzeigen.rtpStaende.Clear()

        If angemeldet Then
            If dgvUebersicht.Columns("stand").Width > 250 Then
                dgvUebersicht.Columns("stand").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                dgvUebersicht.Columns("stand").Width = 250
            End If
            Try
                Dim staende = getAllStaendeFrom(dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells("aid").Value)
                For i = 0 To staende.Length / 3 - 1
                    staendeAnzeigen.rtpStaende.Text &= staende(i, 0) & vbCrLf & vbCrLf
                    staendeAnzeigen.rtpStaende.Text &= staende(i, 1) & vbTab & staende(i, 2) & vbCrLf & "_________________________________________" & vbCrLf & vbCrLf
                Next

            Catch ex As Exception
            End Try
        End If


    End Sub


    Sub setSettings()
        With My.Settings
            .oddRowBackColor = Color.FromArgb(90, 90, 90)
            .evenRowBackColor = Color.FromArgb(111, 111, 111)
            .oddRowForeColor = Color.White
            .evenRowForeColor = Color.White
            .selectedRowBackColor = Color.FromArgb(26, 145, 26)
            .selectetRowForeColor = Color.Black
        End With
        If My.Settings.startFullscreen Then
            Me.WindowState = FormWindowState.Maximized
        End If
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Einstellungen.ShowDialog()
    End Sub



    Private Sub sidePanelButton_Click(sender As Object, e As EventArgs) Handles btnSchnelleNotizen.Click, btnStaende.Click
        formPanel.Controls.Clear()
        formPanel.Size = New Size(506, sidePanel.Size.Height - 10)

        Select Case sender.name
            Case "btnSchnelleNotizen"
                schnelleNotizen.TopLevel = False
                formPanel.Controls.Add(schnelleNotizen)
                schnelleNotizen.rtpNotizen.Text = db.getNotiz()
                schnelleNotizen.Size = formPanel.Size
                schnelleNotizen.Show()
            Case "btnStaende"
                If dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells("aid").Value = "" Then Exit Sub

                staendeAnzeigen.TopLevel = False
                formPanel.Controls.Add(staendeAnzeigen)
                staendeAnzeigen.Size = formPanel.Size
                staendeAnzeigen.Show()
        End Select

        If Not ausgefahren Or sender.tag Then
            sidePanelTimer.Start()
        End If

        For Each btn In sidePanel.Controls.OfType(Of Button)
            btn.Tag = False
            btn.BackColor = Color.Gainsboro
            btn.FlatAppearance.BorderSize = 1
            btn.ForeColor = Color.Black
        Next
        sender.BackColor = Color.DimGray
        sender.FlatAppearance.BorderSize = 0
        sender.ForeColor = Color.White

        sender.tag = True
    End Sub

    Private Sub sidePanelTimer_Tick(sender As Object, e As EventArgs) Handles sidePanelTimer.Tick
        If ausgefahren Then
            'einfahren
            sidePanel.Size = New Size(sidePanel.Size.Width - 40, sidePanel.Size.Height)
            If sidePanel.Size.Width <= 140 Then
                sidePanelTimer.Stop()
                ausgefahren = False
                For Each btn In sidePanel.Controls.OfType(Of Button)
                    btn.Tag = False
                    btn.BackColor = Color.Gainsboro
                    btn.FlatAppearance.BorderSize = 1
                    btn.ForeColor = Color.Black
                Next
            End If
        Else
            'ausfahren
            sidePanel.Size = New Size(sidePanel.Size.Width + 40, sidePanel.Size.Height)
            If sidePanel.Size.Width >= 640 Then
                sidePanelTimer.Stop()
                ausgefahren = True
            End If
        End If
    End Sub

    Private Sub query()
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ti.Interval = 100
            PictureBox1.Image = My.Resources.greenCheck
            ti.Tag = 0
            ti.Start()
        Catch ex As Exception
            ti.Interval = 100
            PictureBox1.Image = My.Resources.redX
            ti.Tag = 0
            ti.Start()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ti_Tick() Handles ti.Tick
        ti.Tag += 1
        If ti.Tag > 20 Then
            ti.Tag = 0
            PictureBox1.Image = Nothing
            ti.Stop()
        End If
    End Sub

    Sub printArray(a As String())
        Dim s = ""
        For Each item In a
            s &= item
        Next
        MsgBox(s)
    End Sub

End Class
