Imports MySql.Data.MySqlClient

Public Class dbAccess
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader


    Public Sub New(user As String, pw As String)
        con.ConnectionString = "server=" & My.Settings.server & ";uid=" & user & ";pwd=" & pw & ";database=" & My.Settings.datenbank
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

    End Sub

    Function customQuery(query As String)

    End Function

    Public Function getAufgabeID(aufgabe As String)
        cmd.CommandText = "SELECT aid FROM aufgaben WHERE titel = '" & aufgabe & "' ORDER BY aid DESC LIMIT 1;"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("aid")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            reader.Close()
            con.Close()
        End Try
        Return result
    End Function


    Public Function getStatusID(status As String)
        cmd.CommandText = "SELECT sid FROM status WHERE status = '" & status & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("sid")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getStandID(stand As String)
        cmd.CommandText = "SELECT sid FROM staende WHERE stand = '" & stand & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("sid")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getPrioID(prio As String)
        cmd.CommandText = "SELECT pid FROM prio WHERE prioritaet = '" & prio & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("pid")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getBenutzerID(benutzer As String)
        cmd.CommandText = "SELECT bid FROM benutzer WHERE benutzername = '" & benutzer & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("bid")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getKategorieID(kategorie As String)
        cmd.CommandText = "SELECT kid FROM kategorien WHERE kategorie = '" & kategorie & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("kid")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getRechteID(rechte As String)
        cmd.CommandText = "SELECT rid FROM rechte WHERE rechte = '" & rechte & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("rid")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getStatusValue(status As String)
        cmd.CommandText = "SELECT status FROM status WHERE sid = '" & status & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("status")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function
    Public Function getPrioValue(prio As String)
        cmd.CommandText = "SELECT prioritaet FROM prio WHERE pid = '" & prio & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("prioritaet")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getNeusterStandValue(standID As String)
        'MsgBox(stand)
        cmd.CommandText = "SELECT stand FROM staende INNER JOIN aufgaben ON staende.aufgabe = aufgaben.aid WHERE aid = '" & standID & "' ORDER BY staende.erstellt DESC LIMIT 1;"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("stand")
        Catch ex As Exception
            'MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
        Return result
    End Function
    Public Function getNeusterStandID(stand As String)
        cmd.CommandText = "SELECT sid FROM staende INNER JOIN aufgaben ON staende.aufgabe = aufgaben.aid WHERE stand = '" & stand & "' ORDER BY staende.erstellt DESC LIMIT 1;"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("stand")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function
    Public Function getBenutzerValue(benutzer As String)
        cmd.CommandText = "SELECT benutzername FROM benutzer WHERE bid = '" & benutzer & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("benutzername")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
        Return result
    End Function

    Public Function getKategorieValue(kategorie As String)
        cmd.CommandText = "SELECT kategorie FROM kategorien WHERE kid = '" & kategorie & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("kategorie")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Function getRechteValue(rechte As String)
        cmd.CommandText = "SELECT rechte.rechte FROM rechte INNER JOIN benutzer ON rechte.rid = benutzer.rechte WHERE rid = '" & rechte & "';"
        Dim result = ""
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            result = reader("rechte")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function


End Class
