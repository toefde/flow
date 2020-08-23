Public Class Taskliste
    Dim s = "






Filter einrichten




Passwörter verschlüsseln



wer hat aufgabe erstellt feld in db















"
    'Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
    '    Dim AES As New System.Security.Cryptography.RijndaelManaged
    '    Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
    '    Dim decrypted As String = ""
    '    Try
    '        Dim hash(31) As Byte
    '        Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
    '        Array.Copy(temp, 0, hash, 0, 16)
    '        Array.Copy(temp, 0, hash, 15, 16)
    '        AES.Key = hash
    '        AES.Mode = Security.Cryptography.CipherMode.ECB
    '        Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
    '        Dim Buffer As Byte() = Convert.FromBase64String(input)
    '        decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
    '        Return decrypted
    '    Catch ex As Exception
    '    End Try
    'End Function

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    '    con.ConnectionString = "server=fe80::a4ac:77b5:3d1:c4b0;uid=timmy.test;pwd=jo;database=flow"
    '    cmd.Connection = con
    '    cmd.CommandText = "SELECT AES_ENCRYPT('wort', '2') AS wort FROM benutzer WHERE bid = 1;"
    '    cmd.CommandType = CommandType.Text

    '    Try
    '        con.Open()
    '        reader = cmd.ExecuteReader

    '        Do While reader.Read
    '            MsgBox(System.Text.Encoding.Unicode.GetString(reader("wort")))
    '            'MsgBox(AES_Decrypt(reader("vorname").ToString, "2"))


    '        Loop
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    con.Close()
    'End Sub
    'Private Function UnicodeBytesToString(ByVal bytes() As Byte) As String

    '    Return System.Text.Encoding.Unicode.GetString(bytes)
    'End Function
End Class
