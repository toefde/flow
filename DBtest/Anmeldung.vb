Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class Anmeldung
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim d

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
                d = New dbAccess(flow.benutzer, flow.passwort)
                con.Open()
                reader = cmd.ExecuteReader

                Dim datenArr(6) As String
                Do While reader.Read

                    datenArr(0) = reader("bid").ToString
                    datenArr(1) = reader("benutzername").ToString
                    datenArr(2) = reader("vorname").ToString
                    datenArr(3) = reader("nachname").ToString
                    datenArr(4) = reader("passwort").ToString
                    datenArr(5) = d.getRechteValue(reader("rechte"))

                    If datenArr(1) = flow.benutzer And datenArr(4) = flow.passwort Then
                        flow.rechte = datenArr(5)
                        flow.angemeldet = True
                        flow.myVorname = datenArr(2)
                        flow.myNachname = datenArr(3)
                        flow.myFullname = flow.myVorname & " " & flow.myNachname
                        For Each tabp As TabPage In flow.TabControl1.Controls.OfType(Of TabPage)
                            For Each item As Button In tabp.Controls.OfType(Of Button)
                                item.Enabled = True
                            Next
                        Next
                    End If

                Loop

            Catch ex As Exception
                MsgBox("Benutzer falsch angelegt!" & vbCrLf & ex.ToString)
                con.Close()
            End Try
            If Not flow.angemeldet Then
                MsgBox("Benutzer falsch angelegt!")
                Exit Sub
            End If

            Timer1.Stop()
            Me.Close()
        Catch ex As Exception
            tbbenutzer.BackColor = Color.Red
            tbpasswort.BackColor = Color.Red
            'MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbbenutzer.Text = "admin"
        tbpasswort.Text = "toefde"
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

    Private Sub btnSchliessenButton2_Click(sender As Object, e As EventArgs) Handles btnSchliessen.Click
        Application.Exit()
        flow.BeendenToolStripMenuItem_Click(sender, e)
        Close()
    End Sub





    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    Private Sub tbpasswort_KeyDown(sender As Object, e As KeyEventArgs) Handles tbpasswort.KeyDown
        tbbenutzer.BackColor = Color.FromArgb(111, 111, 111)
        tbpasswort.BackColor = Color.FromArgb(111, 111, 111)
        If e.KeyData = Keys.Enter Then
            login_Click(sender, New EventArgs)
        End If
        e.Handled = True
    End Sub
End Class