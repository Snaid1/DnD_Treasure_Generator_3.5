Module Generic
    'Decliaring Constants
    'constants for Coins, Goods, Items
    Public Const NONE As Integer = 0
    Public Const STANDARD As Integer = 1
    Public Const DBL As Integer = 2
    Public Const TRPL As Integer = 3
    Public Const HALF As Decimal = 0.5
    Public Const TEN As Decimal = 0.1
    'Constants for Coin Types
    Public Const CP As Integer = 1
    Public Const SP As Integer = 10
    Public Const GP As Integer = 100
    Public Const PP As Integer = 1000
    ' Magic Item Constants
    Public Const MINOR As Integer = 1
    Public Const MEDIUM As Integer = 2
    Public Const MAJOR As Integer = 3
    ' Weapon Type Constants
    Public Const SLASHING As Integer = 1
    Public Const PIERCING As Integer = 2
    Public Const BLUDGEONING As Integer = 3
    Public Const SLASHANDPIERCE As Integer = 4
    Public Const SLASHANDBLUDGE As Integer = 5
    Public Const PIERCEANDBLUDGE As Integer = 6
    Public Const SLASHPIERCEBLUDGE As Integer = 7
    ' Book definition Constants
    Public Const DMG As Integer = 1
    Public Const EPH As Integer = 2
    Public Const MIC As Integer = 3
    Public Const MULTI As Integer = 5
    'Maximum value of weapons and armor before denying additional abilities
    Public Const MAXWEAPONVALUE As Integer = (9 * 9) * 2000
    Public Const MAXARMORVALUE As Integer = (9 * 9) * 1000

    Public Source As Integer = 1
    Public djCoinTweak As Boolean = False

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '"'                                                           '"'
    '"'                Initial Generate Functions                 '"'
    '"'                                                           '"'
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function GenerateCoins(ByVal intCoins As Integer, ByVal lvl As Integer) As Collection
        Dim coins As New Collection

        If intCoins = NONE Then
            coins.Add("No Coins")
            Return coins
        End If
        Dim tempsrc As Integer = setMultiSource()
        If Source = DMG Or Source = EPH Or (Source = MULTI And (tempsrc = DMG Or tempsrc = EPH)) Then
            Dim tempcoins As String
            tempcoins = getcoinsDMG(lvl, intCoins)
            If tempcoins <> "No Coins" Then
                coins.Add(tempcoins)
            End If
            If intCoins = DBL Then
                tempcoins = getcoinsDMG(lvl)
                If tempcoins <> "No Coins" Then
                    coins.Add(tempcoins)
                End If
            ElseIf intCoins = TRPL Then
                For x = 1 To 2
                    tempcoins = getcoinsDMG(lvl)
                    If tempcoins <> "No Coins" Then
                        coins.Add(tempcoins)
                    End If
                Next
            End If
            If coins.Count = 0 Then
                coins.Add("No Coins")
            End If
        End If

        Return coins
    End Function
    Public Function GenerateGoods(ByVal intGoods As Integer, ByVal lvl As Integer) As Collection
        Dim goods As New Collection
        If intGoods = NONE Then
            goods.Add("No Goods")
            Return goods
        End If
        Dim tempsrc As Integer = setMultiSource()
        If Source = DMG Or Source = EPH Or (Source = MULTI And (tempsrc = DMG Or tempsrc = EPH)) Then
            goods = GetGoodsDMG(lvl, intGoods)
            Dim moregoods As New Collection
            If intGoods = DBL Then
                If goods.Item(1) = "No Goods" Then
                    goods.Clear()
                End If
                moregoods = GetGoodsDMG(lvl, intGoods)
                If (goods.Count() > 0 And moregoods.Item(1) <> "No Goods") Or (goods.Count() = 0) Then
                    addC(goods, moregoods)
                End If
            ElseIf intGoods = TRPL Then
                For x = 1 To 2
                    If goods.Item(1) = "No Goods" Then
                        goods.Clear()
                    End If
                    moregoods = GetGoodsDMG(lvl, intGoods)
                    If (goods.Count() > 0 And moregoods.Item(1) <> "No Goods") Or (goods.Count() = 0) Then
                        addC(goods, moregoods)
                    End If
                Next
            End If
        End If
        Return goods
    End Function
    Public Function GenerateItems(ByVal intItems As Integer, ByVal lvl As Integer) As Collection
        Dim items As New Collection
        If intItems = NONE Then
            items.Add("No Items")
            Return items
        End If
        If Source = EPH Or (Source = MULTI And setMultiSource() = EPH) Then
            items = GetItemsEPH(lvl, intItems)
        Else
            items = GetItemsDMG(lvl, intItems)
        End If
        Dim moreItems As New Collection
        If intItems = DBL Then
            If items.Item(1) = "No Items" Then
                items.Clear()
            End If
            If Source = EPH Or (Source = MULTI And setMultiSource() = EPH) Then
                moreItems = GetItemsEPH(lvl)
            Else
                moreItems = GetItemsDMG(lvl)
            End If
            If (items.Count() > 0 And moreItems.Item(1) <> "No Items") Or (items.Count() = 0) Then
                addC(items, moreItems)
            End If
        ElseIf intItems = TRPL Then
            For x = 1 To 2
                If items.Item(1) = "No Items" Then
                    items.Clear()
                End If
                If Source = EPH Or (Source = MULTI And setMultiSource() = EPH) Then
                    moreItems = GetItemsEPH(lvl)
                Else
                    moreItems = GetItemsDMG(lvl)
                End If
                If (items.Count() > 0 And moreItems.Item(1) <> "No Items") Or (items.Count() = 0) Then
                    addC(items, moreItems)
                End If
            Next
        End If
        'End If
        Return items
    End Function

    '''''''''''''''''''''''''''''''
    '         Magic Items         '
    '''''''''''''''''''''''''''''''

    Public Function GetMinorMagicDMG() As Object
        Dim roll As Integer = d100()
        Dim magItem As New Object

        Select Case roll
            Case 1 To 4
                magItem = GetMinorMagicArmorDMG()
                Return magItem
            Case 5 To 9
                magItem = GetMinorMagicWeaponDMG()
                Return magItem
            Case 10 To 44
                magItem = GetMinorMagicPotionDMG()
            Case 45 To 46
                magItem = GetMinorMagicRingDMG()
            Case 47 To 81
                magItem = GetMinorMagicScrollDMG()
                Return magItem
            Case 82 To 91
                magItem = GetMinorMagicWandDMG()
            Case 92 To 100
                magItem = GetMinorMagicWonderDMG()
        End Select
        Return magItem
    End Function
    Public Function GetMediumMagicDMG() As Object
        Dim roll As Integer = d100()
        Dim magItem As New Object

        Select Case roll
            Case 1 To 10
                magItem = GetMediumMagicArmorDMG()
                Return magItem
            Case 11 To 20
                magItem = GetMediumMagicWeaponDMG()
                Return magItem
            Case 21 To 30
                magItem = GetMediumMagicPotionDMG()
            Case 31 To 40
                magItem = GetMediumMagicRingDMG()
            Case 41 To 50
                magItem = GetMediumMagicRodDMG()
            Case 51 To 65
                magItem = GetMediumMagicScrollDMG()
                Return magItem
            Case 66 To 68
                magItem = GetMediumMagicStaffDMG()
            Case 69 To 83
                magItem = GetMediumMagicWandDMG()
            Case 84 To 100
                magItem = GetMediumMagicWonderDMG()
                Return magItem
        End Select
        Return magItem
    End Function
    Public Function GetMajorMagicDMG() As Object
        Dim roll As Integer = d100()
        Dim magItem As New Object

        Select Case roll
            Case 1 To 10
                magItem = GetMajorMagicArmorDMG()
                Return magItem
            Case 11 To 20
                magItem = GetMajorMagicWeaponDMG()
                Return magItem
            Case 21 To 25
                magItem = GetMajorMagicPotionDMG()
            Case 26 To 35
                magItem = GetMajorMagicRingDMG()
            Case 36 To 45
                magItem = GetMajorMagicRodDMG()
            Case 46 To 55
                magItem = GetMajorMagicScrollDMG()
                Return magItem
            Case 56 To 75
                magItem = GetMajorMagicStaffDMG()
            Case 76 To 80
                magItem = GetMajorMagicWandDMG()
            Case 81 To 100
                magItem = GetMajorMagicWonderDMG()
                Return magItem
        End Select
        Return magItem
    End Function
    'Function to select & set source
    Public Function setSource() As Integer
        Dim tempsource As Integer
        If frmTreasure.btnEPH.Checked Then
            tempsource = EPH
        ElseIf frmTreasure.btnMIC.Checked Then
            tempsource = MIC
        ElseIf frmTreasure.btnMultiSource.Checked Then
            tempsource = MULTI
        Else
            tempsource = DMG
        End If
        Return tempsource
    End Function
    Public Function setMultiSource() As Integer
        Dim num As Integer = d100()
        Dim src As Integer = 1
        Dim DMGP As Integer = frmTreasure.spnPercentDMG.Value 'Set upper bound DMG percentage
        Dim XPHP As Integer = DMGP + frmTreasure.spnPercentXPH.Value 'Sets upper bound XPH percent above DMG percentage
        Select Case num
            Case 1 To DMGP
                src = DMG
            Case DMGP + 1 To XPHP
                src = EPH
            Case Else
                src = DMG
        End Select
        Return src
    End Function

    Public Sub addC(ByRef c1 As Collection, ByRef c2 As Object)
        If TypeOf c2 Is Collection Then
            Dim ob As Object
            For Each ob In c2
                addC(c1, ob)
            Next
            c2.Clear()
        ElseIf TypeOf c2 Is String Then
            c1.Add(c2)
        Else
            c1.Add(c2.display())
        End If
    End Sub
End Module