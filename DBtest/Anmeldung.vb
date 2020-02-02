Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class Anmeldung

    Private Sub Anmeldung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbserver.Text = My.Settings.server
        tbdatenbank.Text = My.Settings.datenbank
        'tbserver.Text = "fe80::a4ac:77b5:3d1:c4b0"
        'MsgBox(My.Computer.Network.Ping(tbserver.Text, 100))

        Timer1.Start()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If ToolStripProgressBar1.Visible Then 'Checken ob Verbindung besteht
            tbserver.BackColor = Color.Red
            Return
        End If
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader


        flow.benutzer = tbbenutzer.Text.ToString.ToLower
        flow.passwort = tbpasswort.Text.ToString.ToLower
        My.Settings.server = tbserver.Text
        My.Settings.datenbank = tbdatenbank.Text

        con.ConnectionString = "server=" & tbserver.Text & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=mysql"



        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM mysql.user;"
        cmd.CommandType = CommandType.Text
        Try
            con.Open()
            cmd.ExecuteReader()
            con.Close()

            con.ConnectionString = "server=" & tbserver.Text & ";uid=" & flow.benutzer & ";pwd=" & flow.passwort & ";database=" & tbdatenbank.Text
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM flow.benutzer;"
            cmd.CommandType = CommandType.Text

            Try 'Wenn Benutzer in mysql.user angelegt ist, prüfe welche Recht über interne flow.benutzer Tabelle
                con.Open()
                reader = cmd.ExecuteReader

                Dim datenArr(6) As String
                Do While reader.Read

                    datenArr(0) = reader("bid").ToString
                    datenArr(1) = reader("benutzername").ToString
                    datenArr(2) = reader("vorname").ToString
                    datenArr(3) = reader("nachname").ToString
                    datenArr(4) = reader("passwort").ToString
                    datenArr(5) = reader("rechte").ToString

                    If datenArr(1) = flow.benutzer And datenArr(4) = flow.passwort Then
                        flow.rechte = datenArr(5)
                        'MsgBox(Form1.rechte)
                        flow.angemeldet = True
                    End If
                Loop

            Catch ex As Exception
                MsgBox("Benutzer falsch angelegt!" & vbCrLf & ex.ToString)
            End Try
            If Not flow.angemeldet Then
                MsgBox("Benutzer falsch angelegt!")
                Exit Sub
            End If
            con.Close()
            Timer1.Stop()
            Me.Close()
        Catch ex As Exception
            tbbenutzer.BackColor = Color.Red
            tbpasswort.BackColor = Color.Red
            'MsgBox(ex.ToString)

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbbenutzer.Text = "testuser"
        tbpasswort.Text = "jo"
        login_Click(New Object, New EventArgs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 3000
        Try
            If My.Computer.Network.Ping(tbserver.Text, 100) Then
                ToolStripProgressBar1.Visible = False
                ToolStripStatusLabel1.Text = "Verbunden"
            Else
                ToolStripProgressBar1.Visible = True
                ToolStripStatusLabel1.Text = "Keine Verbindung..."
            End If
        Catch ex As Exception
            ToolStripProgressBar1.Visible = True
            ToolStripStatusLabel1.Text = "Keine Verbindung..."
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbbenutzer.Text = "timmy.test"
        tbpasswort.Text = "jo"
        login_Click(New Object, New EventArgs)
    End Sub
End Class