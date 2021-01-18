Module Goods
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '"'                                                           '"'
    '"'                 Start of Goods Functions                  '"'
    '"'                                                           '"'
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function GetGoodsDMG(ByVal lvl As Integer) As Collection
        Return GetGoodsDMG(lvl, 1.0)
    End Function
    Public Function GetGoodsDMG(ByVal lvl As Integer, ByVal intgoods As Integer) As Collection
        If intgoods = NONE Then
            Dim stuff As New Collection
            stuff.Add("No Goods")
            Return stuff
        ElseIf intgoods = HALF Then
            Return GetGoodsDMG(lvl, 0.5)
        Else
            Return GetGoodsDMG(lvl)
        End If
    End Function
    Public Function GetGoodsDMG(ByVal lvl As Integer, ByVal Percentage As Double) As Collection
        Dim chance As Double = CDbl(d100()) / 100
        Dim stuff As New Collection
        Dim x As Integer = 0
        If chance <= Percentage Then
            Dim roll As Integer = d100()
            Select Case lvl
                Case 1
                    Select Case roll
                        Case 91 To 95
                            stuff.Add(GenerateGemsDMG())
                        Case 96 To 100
                            stuff.Add(GenerateArtDMG())
                    End Select
                Case 2
                    Select Case roll
                        Case 82 To 95
                            For x = 1 To d3()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 96 To 100
                            For x = 1 To d3()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 3
                    Select Case roll
                        Case 78 To 95
                            For x = 1 To d3()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 96 To 100
                            For x = 1 To d3()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 4
                    Select Case roll
                        Case 71 To 95
                            For x = 1 To d4()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 96 To 100
                            For x = 1 To d3()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 5
                    Select Case roll
                        Case 61 To 95
                            For x = 1 To d4()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 96 To 100
                            For x = 1 To d4()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 6
                    Select Case roll
                        Case 57 To 92
                            For x = 1 To d4()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 93 To 100
                            For x = 1 To d4()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 7
                    Select Case roll
                        Case 49 To 88
                            For x = 1 To d4()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 89 To 100
                            For x = 1 To d4()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 8
                    Select Case roll
                        Case 46 To 85
                            For x = 1 To d6()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 86 To 100
                            For x = 1 To d4()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 9
                    Select Case roll
                        Case 41 To 80
                            For x = 1 To d8()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 81 To 100
                            For x = 1 To d4()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 10
                    Select Case roll
                        Case 36 To 79
                            For x = 1 To d8()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 80 To 100
                            For x = 1 To d6()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 11
                    Select Case roll
                        Case 25 To 74
                            For x = 1 To d10()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 75 To 100
                            For x = 1 To d6()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 12
                    Select Case roll
                        Case 18 To 70
                            For x = 1 To d10()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 71 To 100
                            For x = 1 To d8()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 13
                    Select Case roll
                        Case 12 To 66
                            For x = 1 To d12()
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 67 To 100
                            For x = 1 To d10()
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 14
                    Select Case roll
                        Case 12 To 66
                            For x = 1 To d8(2)
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 67 To 100
                            For x = 1 To d6(2)
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 15
                    Select Case roll
                        Case 10 To 65
                            For x = 1 To d10(2)
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 66 To 100
                            For x = 1 To d8(2)
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 16
                    Select Case roll
                        Case 8 To 64
                            For x = 1 To d6(4)
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 65 To 100
                            For x = 1 To d10(2)
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 17
                    Select Case roll
                        Case 5 To 63
                            For x = 1 To d8(4)
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 64 To 100
                            For x = 1 To d8(3)
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 18
                    Select Case roll
                        Case 5 To 54
                            For x = 1 To d12(3)
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 55 To 100
                            For x = 1 To d10(3)
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 19
                    Select Case roll
                        Case 4 To 50
                            For x = 1 To d6(6)
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 51 To 100
                            For x = 1 To d6(6)
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
                Case 20
                    Select Case roll
                        Case 3 To 38
                            For x = 1 To d10(4)
                                stuff.Add(GenerateGemsDMG())
                            Next
                        Case 39 To 100
                            For x = 1 To d6(7)
                                stuff.Add(GenerateArtDMG())
                            Next
                    End Select
            End Select
            If stuff.Count = 0 Then
                stuff.Add("No Goods")
            End If
        Else
            stuff.Add("No Goods")
        End If
        Return stuff
    End Function
    '''''''''''''''''''''''''
    '          Gems         '
    '''''''''''''''''''''''''

    Public Function GetGemsDMG(ByVal list As Integer) As String
        Dim rolls As Integer = d100()
        Dim gemName As String = "A Rock"
        Select Case list
            Case 1
                rolls = d12()
                Select Case rolls
                    Case 1
                        gemName = "Banded Agate"
                    Case 2
                        gemName = "Eye Agate"
                    Case 3
                        gemName = "Moss Agate"
                    Case 4
                        gemName = "Azurite"
                    Case 5
                        gemName = "Blue Quartz"
                    Case 6
                        gemName = "hematite"
                    Case 7
                        gemName = "Lapiz Lazuli"
                    Case 8
                        gemName = "Malachite"
                    Case 9
                        gemName = "Obsidian"
                    Case 10
                        gemName = "Rhodochrosite"
                    Case 11
                        gemName = "Tiger Eye Turquoise"
                    Case 12
                        gemName = "Freshwater (Irregular) Pearl"
                End Select
            Case 2
                rolls = Roll(16)
                Select Case rolls
                    Case 1
                        gemName = "Bloodstone"
                    Case 2
                        gemName = "Carnelian"
                    Case 3
                        gemName = "Chalcedony"
                    Case 4
                        gemName = "Chrysoprase"
                    Case 5
                        gemName = "Citrine"
                    Case 6
                        gemName = "Jasper Iolite"
                    Case 7
                        gemName = "Moonstone"
                    Case 8
                        gemName = "Onyx"
                    Case 9
                        gemName = "Peridot"
                    Case 10
                        gemName = "Rock Crystal(Clear Quartz)"
                    Case 11
                        gemName = "Sard"
                    Case 12
                        gemName = "Sardonyx"
                    Case 13
                        gemName = "Rose Quartz"
                    Case 14
                        gemName = "Smokey Quartz"
                    Case 15
                        gemName = "Star Rose Quartz"
                    Case 16
                        gemName = "Zircon"
                End Select
            Case 3
                rolls = Roll(16)
                Select Case rolls
                    Case 1
                        gemName = "Amber"
                    Case 2
                        gemName = "Amethyst"
                    Case 3
                        gemName = "Chrysoberyl"
                    Case 4
                        gemName = "Coral"
                    Case 5
                        gemName = "Red Garnet"
                    Case 6
                        gemName = "Brown-Green Garnet"
                    Case 7
                        gemName = "Jade"
                    Case 8
                        gemName = "Jet"
                    Case 9
                        gemName = "White Pearl"
                    Case 10
                        gemName = "Golden Pearl"
                    Case 11
                        gemName = "Pink Pearl"
                    Case 12
                        gemName = "Silver Pearl"
                    Case 13
                        gemName = "Red Spinel"
                    Case 14
                        gemName = "Red-Brown Spinel"
                    Case 15
                        gemName = "Deep Green Spinel"
                    Case 16
                        gemName = "Tourmaline"
                End Select
            Case 4
                rolls = d6()
                Select Case rolls
                    Case 1
                        gemName = "Alexandrite"
                    Case 2
                        gemName = "Aquamarine"
                    Case 3
                        gemName = "Violet Garnet"
                    Case 4
                        gemName = "Black Pearl"
                    Case 5
                        gemName = "Deep Blue Spinel"
                    Case 6
                        gemName = "Golden Yellow Topaz"
                End Select
            Case 5
                rolls = d10()
                Select Case rolls
                    Case 1
                        gemName = "Emerald"
                    Case 2
                        gemName = "White Opal"
                    Case 3
                        gemName = "Black Opal"
                    Case 4
                        gemName = "Fire Opal"
                    Case 5
                        gemName = "Blue Sapphire"
                    Case 6
                        gemName = "Fiery Yellow Corundum"
                    Case 7
                        gemName = "Rich Purple Corundum"
                    Case 8
                        gemName = "Blue Star Sapphire"
                    Case 9
                        gemName = "Black Star Sapphire"
                    Case 10
                        gemName = "Star Ruby"
                End Select
            Case 6
                rolls = Roll(7)
                Select Case rolls
                    Case 1
                        gemName = "Clearest Bright Green Emerald"
                    Case 2
                        gemName = "Blue-White Diamond"
                    Case 3
                        gemName = "Canary Diamond"
                    Case 4
                        gemName = "Pink Diamond"
                    Case 5
                        gemName = "Brown Diamond"
                    Case 6
                        gemName = "Blue Diamond"
                    Case 7
                        gemName = "Jacinth"
                End Select
            Case Else
                gemName = "A Rock"
        End Select
        gemName &= "<Gem> "
        Return gemName
    End Function
    Public Function GetGemValueDMG(ByVal list As Integer) As String
        Dim gemval As Integer
        Dim gemvalue As String = ""
        Select Case list
            Case 1
                gemval = GetCoins(4, 4, 1)
            Case 2
                gemval = GetCoins(2, 4, 10)
            Case 3
                gemval = GetCoins(4, 4, 10)
            Case 4
                gemval = GetCoins(2, 4, 100)
            Case 5
                gemval = GetCoins(4, 4, 100)
            Case 6
                gemval = GetCoins(2, 4, 1000)
            Case Else
                gemval = 0
        End Select
        gemvalue = " (" & CStr(gemval) & " gp)"
        Return gemvalue
    End Function
    Public Function GenerateGemsDMG() As String
        Dim gemName As String
        Dim rolls As Integer = d100()
        Dim value As Integer = 0
        Select Case rolls
            Case 1 To 25
                value = 1
            Case 26 To 50
                value = 2
            Case 51 To 70
                value = 3
            Case 71 To 90
                value = 4
            Case 91 To 99
                value = 5
            Case 100
                value = 6
        End Select
        gemName = GetGemsDMG(value)
        gemName &= GetGemValueDMG(value)
        Return gemName
    End Function
    ''''''''''''''''''''''''
    '          Art         '
    ''''''''''''''''''''''''
    Public Function GenerateArtDMG() As String
        Dim Artwork As String
        Dim roll As Integer = d100()
        Dim value As Integer = 0
        Select Case roll
            Case 1 To 10
                value = 1
            Case 11 To 25
                value = 2
            Case 26 To 40
                value = 3
            Case 41 To 50
                value = 4
            Case 51 To 60
                value = 5
            Case 61 To 70
                value = 6
            Case 71 To 80
                value = 7
            Case 81 To 85
                value = 8
            Case 86 To 90
                value = 9
            Case 91 To 95
                value = 10
            Case 96 To 99
                value = 11
            Case 100
                value = 12
            Case Else
                value = 0
        End Select

        Artwork = GetArtNameDMG(value)
        Artwork &= GetArtValueDMG(value)

        Return Artwork
    End Function
    Public Function GetArtNameDMG(ByVal value As Integer) As String
        Dim artName As String = ""
        Dim roll As Integer = d100()
        Select Case value
            Case 1
                roll = d4()
                Select Case roll
                    Case 1
                        artName = "Silver Ewer"
                    Case 2
                        artName = "Carved Bone Statuette"
                    Case 3
                        artName = "Ivory Statuette"
                    Case 4
                        artName = "Finely Wrought Small Gold Bracelet"
                End Select
            Case 2
                roll = d3()
                Select Case roll
                    Case 1
                        artName = "Cloth of Gold Vestments"
                    Case 2
                        artName = "Black Velvet Mask"
                    Case 3
                        artName = "Silver Chalice with Lapis Lazuli Gems"
                End Select
            Case 3
                roll = d2()
                Select Case roll
                    Case 1
                        artName = "Large Well-Done Wool Tapestry"
                    Case 2
                        artName = "Brass Mug With Jade Inlays"
                End Select
            Case 4
                roll = d2()
                Select Case roll
                    Case 1
                        artName = "Silver Comb with Moonstones"
                    Case 2
                        artName = "Silver-Plated Steel Longsword with Jet Jewel in Hilt"
                End Select
            Case 5
                roll = d2()
                Select Case roll
                    Case 1
                        artName = "Carved Harp with Ivory Inlay and Zircon Gems"
                    Case 2
                        artName = "Solid Gold Idol(10 lb.)"
                End Select
            Case 6
                roll = d3()
                Select Case roll
                    Case 1
                        artName = "Gold Dragon Comb with Red Garnet"
                    Case 2
                        artName = "Gold and Topaz Bottle Stopper Cork"
                    Case 3
                        artName = "Ceremonial Electrum Dagger with a Star Ruby Pommel"
                End Select
            Case 7
                roll = d3()
                Select Case roll
                    Case 1
                        artName = "Eyepatch with Mock Eye of Sapphire and Moonstone"
                    Case 2
                        artName = "Fire Opal Pendant on a Fine Gold Chain"
                    Case 3
                        artName = "Old Masterpiece Painting"
                End Select
            Case 8
                roll = d2()
                Select Case roll
                    Case 1
                        artName = "Embroidered Silk Mantle with Numerous Moonstones"
                    Case 2
                        artName = "Sapphire Pendant on Gold Chain"
                End Select
            Case 9
                roll = d3()
                Select Case roll
                    Case 1
                        artName = "Embroidered and Bejeweled Glove"
                    Case 2
                        artName = "Jeweled Anklet"
                    Case 3
                        artName = "Gold Music Box"
                End Select
            Case 10
                roll = d2()
                Select Case roll
                    Case 1
                        artName = "Golden Circlet with Four Aquamarines"
                    Case 2
                        artName = "A String of Small Pink Pearls"
                End Select
            Case 11
                roll = d2()
                Select Case roll
                    Case 1
                        artName = "Jeweled Gold Crown"
                    Case 2
                        artName = "Jeweled Electrum Ring"
                End Select
            Case 12
                roll = d2()
                Select Case roll
                    Case 1
                        artName = "Gold and Ruby Ring"
                    Case 2
                        artName = "Gold Cup set with Emeralds"
                End Select
            Case Else
                artName = "Barbie Doll missing her head"
        End Select
        artName &= "<Art> "
        Return artName
    End Function
    Public Function GetArtValueDMG(ByVal num As Integer) As String
        Dim total As String
        Dim value As Integer
        Select Case num
            Case 1
                value = GetCoins(1, 10, 10)
            Case 2
                value = GetCoins(3, 6, 10)
            Case 3
                value = GetCoins(1, 6, 100)
            Case 4
                value = GetCoins(1, 10, 100)
            Case 5
                value = GetCoins(2, 6, 100)
            Case 6
                value = GetCoins(3, 6, 100)
            Case 7
                value = GetCoins(4, 6, 100)
            Case 8
                value = GetCoins(5, 6, 100)
            Case 9
                value = GetCoins(1, 4, 1000)
            Case 10
                value = GetCoins(1, 6, 1000)
            Case 11
                value = GetCoins(2, 4, 1000)
            Case 12
                value = GetCoins(2, 6, 1000)
            Case Else
                value = 0
        End Select

        total = " (" & CStr(value) & " gp)"
        Return total
    End Function
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '"'                                                           '"'
    '"'                  End of Goods Functions                   '"'
    '"'                                                           '"'
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Module
