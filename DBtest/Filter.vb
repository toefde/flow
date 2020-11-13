Public Class Filter
    Public Shared bFilter As New Dictionary(Of String, Boolean)
    Public Shared sFilter As New Dictionary(Of String, Boolean)
    Public Shared pFilter As New Dictionary(Of String, Boolean)
    Public Shared kFilter As New Dictionary(Of String, Boolean)
    Public Shared spalten As New Dictionary(Of String, Boolean)


    Private Sub Filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If flow.rechte = "USER" Then
            Label6.Visible = False
            clbBenutzer.Visible = False
        ElseIf flow.rechte = "ADMIN" Then
            Label6.Visible = True
            clbBenutzer.Visible = True
        End If
        For Each item In filterPanel.Controls.OfType(Of CheckedListBox)
            item.Items.Clear()
        Next
        clbBenutzer.Items.AddRange(flow.getBenutzer)
        clbStatus.Items.AddRange(flow.getStatus)
        clbPrio.Items.AddRange(flow.getPrios)
        clbKategorie.Items.AddRange(flow.getKategorien)

        clbSpalten.Items.Add(spalten)

        For Each kvi In bFilter
            For i = 0 To clbBenutzer.Items.Count - 1
                If kvi.Key = clbBenutzer.Items.Item(i) Then
                    clbBenutzer.SetItemChecked(i, kvi.Value)
                End If
            Next
        Next
        For Each kvi In sFilter
            For i = 0 To clbStatus.Items.Count - 1
                If kvi.Key = clbStatus.Items.Item(i) Then
                    clbStatus.SetItemChecked(i, kvi.Value)
                End If
            Next
        Next
        For Each kvi In pFilter
            For i = 0 To clbPrio.Items.Count - 1
                If kvi.Key = clbPrio.Items.Item(i) Then
                    clbPrio.SetItemChecked(i, kvi.Value)
                End If
            Next
        Next
        For Each kvi In kFilter
            For i = 0 To clbKategorie.Items.Count - 1
                If kvi.Key = clbKategorie.Items.Item(i) Then
                    clbKategorie.SetItemChecked(i, kvi.Value)
                End If
            Next
        Next

        For Each kvi In spalten
            For i = 0 To clbSpalten.Items.Count - 1 - 1
                If kvi.Key = clbSpalten.Items.Item(i) Then
                    clbSpalten.SetItemChecked(i, kvi.Value)
                End If
            Next
        Next
    End Sub


    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        For kvi = 0 To bFilter.Count
            For i = 0 To clbBenutzer.Items.Count - 1
                If bFilter.Keys(kvi) = clbBenutzer.Items.Item(i) Then
                    bFilter.Item(bFilter.Keys(kvi)) = clbBenutzer.GetItemChecked(i)
                End If
            Next
        Next
        For kvi = 0 To sFilter.Count
            For i = 0 To clbStatus.Items.Count - 1
                If sFilter.Keys(kvi) = clbStatus.Items.Item(i) Then
                    sFilter.Item(sFilter.Keys(kvi)) = clbStatus.GetItemChecked(i)
                End If
            Next
        Next
        For kvi = 0 To pFilter.Count
            For i = 0 To clbBenutzer.Items.Count - 1
                If pFilter.Keys(kvi) = clbPrio.Items.Item(i) Then
                    pFilter.Item(pFilter.Keys(kvi)) = clbPrio.GetItemChecked(i)
                End If
            Next
        Next
        For kvi = 0 To kFilter.Count
            For i = 0 To clbKategorie.Items.Count - 1
                If kFilter.Keys(kvi) = clbKategorie.Items.Item(i) Then
                    kFilter.Item(kFilter.Keys(kvi)) = clbKategorie.GetItemChecked(i)
                End If
            Next
        Next

        ' flow.dgvUebersicht.Columns.Item(0).Visible = False

        flow.fillDGV()
        Me.Close()
    End Sub





End Class