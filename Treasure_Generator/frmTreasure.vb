Public Class frmTreasure
    Public TotalCoins As Integer
    Public TotalGoods As Integer
    Public TotalItems As Integer
    Public Path As String

    Private Sub btnStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStandard.CheckedChanged
        btncoinstd.Checked = True
        btngoodstd.Checked = True
        btnitemstd.Checked = True
    End Sub

    Private Sub btnDblStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDblStandard.CheckedChanged
        btncoindbl.Checked = True
        btngooddbl.Checked = True
        btnitemdbl.Checked = True
    End Sub
    Private Sub btnTplStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTplStandard.CheckedChanged
        btncointpl.Checked = True
        btngoodtpl.Checked = True
        btnitemtpl.Checked = True
    End Sub

    Private Sub btnNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNone.CheckedChanged
        btncoinno.Checked = True
        btngoodno.Checked = True
        btnitemno.Checked = True
    End Sub


    Private Sub grpCoins_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCoins.Enter
        btnNonstandard.Checked = True
    End Sub

    Private Sub grpGoods_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpGoods.Enter
        btnNonstandard.Checked = True
    End Sub

    Private Sub grpItems_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpItems.Enter
        btnNonstandard.Checked = True
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If FreezeCoinsToolStripMenuItem.Checked = False Then
            If KeepCoinsToolStripMenuItem.Checked = False Or lstCoins.Items(0) = "No Coins" Then
                lstCoins.Items.Clear()
            End If
        End If
        If FreezeGoodsToolStripMenuItem.Checked = False Then
            If KeepGoodsToolStripMenuItem.Checked = False Or lstGoods.Items(0) = "No Goods" Then
                lstGoods.Items.Clear()
            End If
        End If
        If FreezeItemsToolStripMenuItem.Checked = False Then
            If KeepItemsToolStripMenuItem.Checked = False Or lstItems.Items(0) = "No Items" Then
                lstItems.Items.Clear()
            End If
        End If

        Dim intCoins As Decimal = NONE
        Dim intGoods As Integer = NONE
        Dim intItems As Integer = NONE
        Dim intLevel As Integer = 1
        djCoinTweak = chkCoinTweak.Checked  'real numbers instead of multiples since computers work faster than people

        If btncoinstd.Checked Then
            intCoins = STANDARD
        ElseIf btncoindbl.Checked Then
            intCoins = DBL
        ElseIf btncointpl.Checked Then
            intCoins = TRPL
        ElseIf btncoin50.Checked Then
            intCoins = HALF
        ElseIf btncoin10.Checked Then
            intCoins = TEN
        Else
            intCoins = NONE
        End If

        If btngoodstd.Checked Then
            intGoods = STANDARD
        ElseIf btngooddbl.Checked Then
            intGoods = DBL
        ElseIf btngoodtpl.Checked Then
            intGoods = TRPL
        ElseIf btngood50.Checked Then
            intGoods = HALF
        Else
            intGoods = NONE
        End If

        If btnitemstd.Checked Then
            intItems = STANDARD
        ElseIf btnitemdbl.Checked Then
            intItems = DBL
        ElseIf btnitemtpl.Checked Then
            intItems = TRPL
        ElseIf btnitem50.Checked Then
            intItems = HALF
        Else
            intItems = NONE
        End If

        intLevel = spnLevel.Value
        Source = setSource() 'found in Generic.vb

        Dim stuff As Collection
        Dim thing As Object
        If FreezeCoinsToolStripMenuItem.Checked = False Then
            stuff = GenerateCoins(intCoins, intLevel)
            For Each thing In stuff
                If lstCoins.Items.Count = 0 Or (lstCoins.Items.Count > 0 And thing <> "No Coins") Then
                    lstCoins.Items.Add(thing)
                End If
            Next
        End If
        If FreezeGoodsToolStripMenuItem.Checked = False Then
            stuff = GenerateGoods(intGoods, intLevel)
            For Each thing In stuff
                If lstGoods.Items.Count = 0 Or (lstGoods.Items.Count > 0 And thing <> "No Goods") Then
                    lstGoods.Items.Add(thing)
                End If
            Next
        End If
        If FreezeItemsToolStripMenuItem.Checked = False Then
            stuff = GenerateItems(intItems, intLevel)
            For Each thing In stuff
                If lstItems.Items.Count = 0 Or (lstItems.Items.Count > 0 And thing <> "No Items") Then
                    lstItems.Items.Add(thing)
                End If
            Next
        End If
    End Sub

    Private Sub lstItems_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstItems.MouseDoubleClick
        If lstItems.SelectedIndex < 0 Then
            lstItems.SelectedIndex = 0
        End If
        MsgBox(lstItems.Items(lstItems.SelectedIndex), MsgBoxStyle.OkOnly, "Item Details")
    End Sub

    Private Sub lstGoods_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstGoods.MouseDoubleClick
        If lstGoods.SelectedIndex < 0 Then
            lstGoods.SelectedIndex = 0
        End If
        MsgBox(lstGoods.Items(lstGoods.SelectedIndex), MsgBoxStyle.OkOnly, "Goods Details")
    End Sub

    Private Sub lstCoins_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCoins.MouseDoubleClick
        If lstCoins.SelectedIndex < 0 Then
            lstCoins.SelectedIndex = 0
        End If
        MsgBox(lstCoins.Items(lstCoins.SelectedIndex), MsgBoxStyle.OkOnly, "Coins Details")
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim saveplace As New SaveFileDialog
        saveplace.Filter = "Exported Treasure Hoard|*.txt"
        saveplace.Title = "Export Treaseure"
        saveplace.ShowDialog()

        If saveplace.FileName <> "" Then
            Dim objReader As New System.IO.StreamWriter(saveplace.FileName, True)
            Dim thing As Object
            For Each thing In lstCoins.Items
                objReader.WriteLine(thing)
            Next
            For Each thing In lstGoods.Items
                objReader.WriteLine(thing)
            Next
            For Each thing In lstItems.Items
                objReader.WriteLine(thing)
            Next
            objReader.Close()
            MsgBox("Treasure Hoard Exported")
        Else
            MsgBox("Error: Treasure Hoard Not Exported")
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        btnExport_Click(sender, e)
        System.IO.Directory.SetCurrentDirectory(Path)
    End Sub

    Private Sub KeepCoinsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeepCoinsToolStripMenuItem.Click
        If KeepCoinsToolStripMenuItem.Checked Then
            KeepCoinsToolStripMenuItem.Checked = False
        Else
            KeepCoinsToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub KeepGoodsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeepGoodsToolStripMenuItem.Click
        If KeepGoodsToolStripMenuItem.Checked Then
            KeepGoodsToolStripMenuItem.Checked = False
        Else
            KeepGoodsToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub KeepItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeepItemsToolStripMenuItem.Click
        If KeepItemsToolStripMenuItem.Checked Then
            KeepItemsToolStripMenuItem.Checked = False
        Else
            KeepItemsToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub FreezeCoinsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreezeCoinsToolStripMenuItem.Click
        If FreezeCoinsToolStripMenuItem.Checked Then
            FreezeCoinsToolStripMenuItem.Checked = False
            KeepCoinsToolStripMenuItem.Enabled = True
        Else
            FreezeCoinsToolStripMenuItem.Checked = True
            KeepCoinsToolStripMenuItem.Enabled = False
            KeepCoinsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub FreezeGoodsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreezeGoodsToolStripMenuItem.Click
        If FreezeGoodsToolStripMenuItem.Checked Then
            FreezeGoodsToolStripMenuItem.Checked = False
            KeepGoodsToolStripMenuItem.Enabled = True
        Else
            FreezeGoodsToolStripMenuItem.Checked = True
            KeepGoodsToolStripMenuItem.Enabled = False
            KeepGoodsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub FreezeItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreezeItemsToolStripMenuItem.Click
        If FreezeItemsToolStripMenuItem.Checked Then
            FreezeItemsToolStripMenuItem.Checked = False
            KeepItemsToolStripMenuItem.Enabled = True
        Else
            FreezeItemsToolStripMenuItem.Checked = True
            KeepItemsToolStripMenuItem.Enabled = False
            KeepItemsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        lstCoins.Items.Clear()
        lstGoods.Items.Clear()
        lstItems.Items.Clear()
        lstCoins.Items.Add("No Coins")
        lstGoods.Items.Add("No Goods")
        lstItems.Items.Add("No Items")
    End Sub

    Private Sub frmTreasure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Path = System.IO.Directory.GetCurrentDirectory()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnMultiSource_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiSource.CheckedChanged
        If btnMultiSource.Checked = True Then
            grpPercent.Visible = True
        Else
            grpPercent.Visible = False
        End If
    End Sub

    Private Sub spnPercentDMG_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spnPercentDMG.ValueChanged
        spnPercentXPH.Value = 100 - spnPercentDMG.Value
    End Sub

    Private Sub spnPercentXPH_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spnPercentXPH.ValueChanged
        spnPercentDMG.Value = 100 - spnPercentXPH.Value
    End Sub
End Class

