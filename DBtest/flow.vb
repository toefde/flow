Imports MySql.Data.MySqlClient
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
    Dim lastSelected As New Point
    Public angemeldet As Boolean = False
    Public db

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
        Try
            cbStatus.Items.AddRange(status)
            cbNeuStatus.Items.AddRange(status)
            cbNeuStatus.SelectedIndex = 0

            cbPrio.Items.AddRange(prios)
            cbNeuPrio.Items.AddRange(prios)
            cbNeuPrio.SelectedIndex = 0

            If angemeldet Then
                cbKategorie.Items.AddRange(getKategorien)
                cbNeuKategorie.Items.AddRange(getKategorien)
                cbNeuKategorie.SelectedIndex = 0

                cbBearbeiter.Items.AddRange(getBenutzer)
                cbNeuBearbeiter.Items.AddRange(getBenutzer)
                cbNeuBearbeiter.SelectedItem = myFullname

                For Each tabp As TabPage In TabControl1.Controls.OfType(Of TabPage)
                    For Each item As Button In tabp.Controls.OfType(Of Button)
                        item.Enabled = True
                    Next
                Next
            End If
            ' fillDGV()
        Catch ex As Exception
        End Try
    End Sub
    Sub fillDGV()
        dgvUebersicht.Rows.Clear()
        dgvUebersicht.Columns.Clear()

        If Not angemeldet Then
            Exit Sub
        End If
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank
        If rechte = "ADMIN" Then
            cmd.CommandText = "SELECT * FROM aufgaben INNER JOIN benutzer ON bearbeiter = bid;"
        ElseIf rechte = "USER" Then
            cmd.CommandText = "SELECT * FROM aufgaben INNER JOIN benutzer ON aufgaben.bearbeiter = benutzer.bid WHERE benutzer.benutzername = '" & benutzer & "';"
        End If
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

        Try
            con.Open()
            reader = cmd.ExecuteReader
            Dim z = 0
            Do While reader.Read
                dgvUebersicht.Rows.Add(1)
                z = dgvUebersicht.Rows.Count - 1
                dgvUebersicht.Rows(z).Cells(0).Value = reader("aid")
                dgvUebersicht.Rows(z).Cells(1).Value = reader("titel")
                dgvUebersicht.Rows(z).Cells(2).Value = reader("beschreibung")
                dgvUebersicht.Rows(z).Cells(3).Value = db.getStatusValue(reader("status"))
                dgvUebersicht.Rows(z).Cells(4).Value = db.getPrioValue(reader("prio"))
                dgvUebersicht.Rows(z).Cells(5).Value = db.getKategorieValue(reader("kategorie"))
                Try
                    dgvUebersicht.Rows(z).Cells(6).Value = db.getNeusterStandValue(dgvUebersicht.Rows(z).Cells(0).Value)
                Catch ex As Exception
                End Try
                dgvUebersicht.Rows(z).Cells(7).Value = reader("vorname") & " " & reader("nachname")
                dgvUebersicht.Rows(z).Cells(8).Value = reader("ticketnr")
                dgvUebersicht.Rows(z).Cells(9).Value = reader("erstellt")
                dgvUebersicht.Rows(z).Cells(10).Value = reader("bearbeitet")
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
            con.Close()
        End Try

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

    Private Sub btnNeuInsert_Click(sender As Object, e As EventArgs) Handles btnNeuInsert.Click
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
                con.Open()
                cmd.ExecuteNonQuery()
                cmd.CommandText = "INSERT INTO staende (stand, aufgabe, bearbeiter) VALUES ('Aufgabe erstellt', '" & db.getAufgabeID(tbNeuTitel.Text) & "', '" & db.getBenutzerID(benutzer) & "');"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                If angemeldet Then
                    MsgBox(ex.ToString)
                Else
                    MsgBox("Kein Benutzer angemeldet")
                End If
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btnBearbeitetUpdate_Click(sender As Object, e As EventArgs) Handles btnBearbeitetUpdate.Click
        Try
            Dim temp() = cbBearbeiter.SelectedItem.ToString.Split(" ")
            Dim bname = ""
            'b 0, v 1, n 2
            For i = 0 To benutzerArray.Length / 3 - 1 'get in combobox ausgewählter Benutzer
                If temp(0) = benutzerArray(i, 1) And temp(1) = benutzerArray(i, 2) Then
                    bname = benutzerArray(i, 0)
                End If
            Next

            con.Open()
            If tbStand.Text <> "" Then
                cmd.CommandText = "INSERT INTO staende (stand, aufgabe, bearbeiter) VALUES ('" & tbStand.Text & "', '" & lblID.Text & "', '" & benutzer & "');"
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = "UPDATE aufgaben SET titel = '" & tbTitel.Text & "', beschreibung = '" & tbBeschreibung.Text &
                "', bearbeiter = '" & db.getBenutzerID(bname) & "', ticketnr = '" & tbTicketNr.Text & "', status = '" & db.getStatusID(cbStatus.SelectedItem) &
                "', prio = '" & db.getPrioID(cbPrio.SelectedItem) & "', kategorie = '" & db.getKategorieID(cbKategorie.SelectedItem) & "' WHERE aid = " & lblID.Text & ";"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
        If tbStand.Text <> "" Then
            tbLetzterStand.Text = tbStand.Text
            tbStand.Clear()
        End If
    End Sub
    Private Sub tpBearbeiten_Enter(sender As Object, e As EventArgs) Handles tpBearbeiten.Enter
        clearAllFieldsBearbeiten()

        If angemeldet Then
            lastSelected.X = dgvUebersicht.CurrentCellAddress.X
            lastSelected.Y = dgvUebersicht.CurrentCellAddress.Y
            Dim selectedID = dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(0).Value
            con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM aufgaben INNER JOIN staende ON aufgaben.aid = staende.aufgabe INNER JOIN benutzer ON aufgaben.bearbeiter = benutzer.bid WHERE aufgaben.aid = " & selectedID & " ORDER BY staende.erstellt DESC LIMIT 1;"
            cmd.CommandType = CommandType.Text
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
    End Sub

    Private Sub tpAufgabeErstellen_Enter(sender As Object, e As EventArgs) Handles tpAufgabeErstellen.Enter
        clearAllFieldsErstellen()
        lastSelected.X = dgvUebersicht.CurrentCellAddress.X
        lastSelected.Y = dgvUebersicht.CurrentCellAddress.Y
        'MsgBox("Aufgabe erstellen")
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
            For Each item As ComboBox In tabp.Controls.OfType(Of ComboBox)
                item.Items.Clear()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAktualisieren.Click
        fillDGV()
        dgvUebersicht_SelectionChanged(sender, e)
    End Sub

    Private Sub dgvUebersicht_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUebersicht.CellDoubleClick
        tpBearbeiten_Enter(New Object, New EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub BenutzerverwaltungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwaltungToolStripMenuItem.Click
        Verwaltung.Show()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        MsgBox(db.getBenutzerID(benutzer))
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
        For i = 0 To columnCount - 1
            dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(i).Style.BackColor = My.Settings.selectedRowBackColor
            dgvUebersicht.Rows(dgvUebersicht.CurrentCellAddress.Y).Cells(i).Style.ForeColor = My.Settings.selectetRowForeColor
        Next

    End Sub

    Private Sub btnStaende_Click(sender As Object, e As EventArgs) Handles btnStaende.Click
        staendeAnzeigen.Show()
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
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & benutzer & ";pwd=" & passwort & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text



    End Sub
End Class
