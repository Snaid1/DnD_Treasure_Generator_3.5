Module Items
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '"'                                                           '"'
    '"'                 Start of Items Functions                  '"'
    '"'                                                           '"'
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function GetItemsDMG(ByVal lvl As Integer) As Collection
        Return GetItemsDMG(lvl, 1.0)
    End Function
    Public Function GetItemsDMG(ByVal lvl As Integer, ByVal intItems As Integer) As Collection
        Dim stuff As New Collection
        If intItems = NONE Then
            stuff.Add("No Items")
        ElseIf intItems = HALF Then
            stuff = GetItemsDMG(lvl, 0.5)
        Else
            stuff = GetItemsDMG(lvl)
        End If

        Return stuff
    End Function
    Public Function GetItemsDMG(ByVal lvl As Integer, ByVal Percentage As Double) As Collection
        Dim items As New Collection
        Dim tempitems As New Collection
        Dim chance As Double = d100() / 100
        If chance <= Percentage Then
            Dim rolls As Integer = d100()
            Dim x As Integer
            Select Case lvl
                Case 1
                    Select Case rolls
                        Case 72 To 95
                            addC(items, GetMundaneDMG())
                        Case 96 To 100
                            addC(items, GetMinorMagicDMG())
                    End Select
                Case 2
                    Select Case rolls
                        Case 50 To 85
                            addC(items, GetMundaneDMG())
                        Case 86 To 100
                            addC(items, GetMinorMagicDMG())
                    End Select
                Case 3
                    Select Case rolls
                        Case 50 To 79
                            For x = 1 To d3()
                                addC(items, GetMundaneDMG())
                            Next
                        Case 80 To 100
                            addC(items, GetMinorMagicDMG())
                    End Select
                Case 4
                    Select Case rolls
                        Case 43 To 62
                            For x = 1 To d4()
                                addC(items, GetMundaneDMG())
                            Next
                        Case 63 To 100
                            addC(items, GetMinorMagicDMG())
                    End Select
                Case 5
                    Select Case rolls
                        Case 58 To 67
                            For x = 1 To d4()
                                addC(items, GetMundaneDMG())
                            Next
                        Case 68 To 100
                            For x = 1 To d3()
                                addC(items, GetMinorMagicDMG())
                            Next
                    End Select
                Case 6
                    Select Case rolls
                        Case 55 To 59
                            For x = 1 To d4()
                                addC(items, GetMundaneDMG())
                            Next
                        Case 60 To 99
                            For x = 1 To d3()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 100
                            addC(items, GetMediumMagicDMG())
                    End Select
                Case 7
                    Select Case rolls
                        Case 52 To 97
                            For x = 1 To d3()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 98 To 100
                            addC(items, GetMediumMagicDMG())
                    End Select
                Case 8
                    Select Case rolls
                        Case 49 To 96
                            For x = 1 To d4()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 97 To 100
                            addC(items, GetMediumMagicDMG())
                    End Select
                Case 9
                    Select Case rolls
                        Case 44 To 91
                            For x = 1 To d4()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 92 To 100
                            addC(items, GetMediumMagicDMG())
                    End Select
                Case 10
                    Select Case rolls
                        Case 41 To 88
                            For x = 1 To d4()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 89 To 99
                            addC(items, GetMediumMagicDMG())
                        Case 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 11
                    Select Case rolls
                        Case 32 To 84
                            For x = 1 To d4()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 85 To 98
                            addC(items, GetMediumMagicDMG())
                        Case 99 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 12
                    Select Case rolls
                        Case 28 To 82
                            For x = 1 To d6()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 83 To 97
                            addC(items, GetMediumMagicDMG())
                        Case 98 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 13
                    Select Case rolls
                        Case 20 To 73
                            For x = 1 To d6()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 74 To 95
                            addC(items, GetMediumMagicDMG())
                        Case 96 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 14
                    Select Case rolls
                        Case 20 To 58
                            For x = 1 To d6()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 59 To 92
                            addC(items, GetMediumMagicDMG())
                        Case 93 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 15
                    Select Case rolls
                        Case 12 To 46
                            For x = 1 To d10()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 47 To 90
                            addC(items, GetMediumMagicDMG())
                        Case 91 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 16
                    Select Case rolls
                        Case 41 To 46
                            For x = 1 To d10()
                                addC(items, GetMinorMagicDMG())
                            Next
                        Case 47 To 90
                            For x = 1 To d3()
                                addC(items, GetMediumMagicDMG())
                            Next
                        Case 91 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 17
                    Select Case rolls
                        Case 34 To 83
                            For x = 1 To d3()
                                addC(items, GetMediumMagicDMG())
                            Next
                        Case 84 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 18
                    Select Case rolls
                        Case 25 To 80
                            For x = 1 To d4()
                                addC(items, GetMediumMagicDMG())
                            Next
                        Case 81 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 19
                    Select Case rolls
                        Case 5 To 70
                            For x = 1 To d4()
                                addC(items, GetMediumMagicDMG())
                            Next
                        Case 71 To 100
                            addC(items, GetMajorMagicDMG())
                    End Select
                Case 20
                    Select Case rolls
                        Case 26 To 65
                            For x = 1 To d4()
                                addC(items, GetMediumMagicDMG())
                            Next
                        Case 66 To 100
                            For x = 1 To d3()
                                addC(items, GetMajorMagicDMG())
                            Next
                    End Select
                Case Else
                    addC(items, "Pile O' Junk")
            End Select

        End If
        If items.Count = 0 Then
            addC(items, "No Items")
        End If
        Return items
    End Function
    Public Function GetMundaneDMG() As Object
        Dim roll As Integer = d100()
        Dim item As String
        Select Case roll
            Case 1 To 5
                item = "Alchemist's Fire (" & CStr(d4()) & "flasks, 20 gp each)"
            Case 6 To 10
                item = "Acid (" & CStr(d4(2)) & " flasks, 10 gp each)"
            Case 11 To 12
                item = "Smokesticks (" & CStr(d4()) & " sticks, 20 gp each)"
            Case 13 To 18
                item = "Holy Water (" & CStr(d4()) & " flasks, 25 gp each)"
            Case 19 To 20
                item = "Thunderstones (" & CStr(d4()) & " stones, 30 gp each)"
            Case 21 To 22
                Dim r As Integer = d100()
                If r <= 10 Then
                    item = "Small Chain Shirt (75 gp)"
                Else
                    item = "Medium Chain Shirt (100 gp)"
                End If
            Case 23 To 27
                item = "Antitoxin (" & CStr(d4()) & " doses, 50 gp each)"
            Case 28 To 29
                item = "Tanglefoot Bag (" & CStr(d4()) & " bags, 50 gp each)"
            Case 30 To 34
                Dim r As Integer = d100()
                If r <= 50 Then
                    item = "Small Masterwork Studded Leather (132 gp)"
                Else
                    item = "Medium Masterwork Studded Leather (175 gp)"
                End If
            Case 35 To 39
                Dim r As Integer = d100()
                If r <= 60 Then
                    item = "Mighty Composite Shortbow(+1 Str Bonus) (150 gp)"
                Else
                    item = "Mighty Composite Shortbow(+2 Str Bonus) (225 gp)"
                End If
            Case 40 To 43
                Dim r As Integer = d100()
                If r <= 10 Then
                    item = "Small Breastplate (150 gp)"
                Else
                    item = "Medium Breastplate (200 gp)"
                End If
            Case 44 To 48
                Dim r As Integer = d100()
                If r <= 10 Then
                    item = "Small Banded Mail (187 gp)"
                Else
                    item = "Medium Banded Mail (250 gp)"
                End If
            Case 49 To 66
                item = "Masterwork "
                item &= GetComMeleeWeaponDMG().Display
            Case 67 To 68
                item = "Masterwork "
                item &= GetUncMeleeWeaponDMG().Display
            Case 69 To 73
                item = "Masterwork "
                item &= GetRangedWeaponDMG().Display
            Case 74 To 83
                Dim r As Integer = d100()
                Dim randomint As Integer
                Select Case r
                    Case 1 To 45
                        randomint = 1
                    Case 46 To 75
                        randomint = 2
                    Case 76 To 90
                        randomint = 3
                    Case 91 To 100
                        randomint = 4
                End Select
                item = "Mighty Composite Longbow(+" & CStr(randomint) & " Str Bonus) (" & CInt(1 + randomint) & "00 gp)"
            Case 84 To 93
                Dim r As Integer = d100()
                If r <= 10 Then
                    item = "Small Half-Plate (450 gp)"
                Else
                    item = "Medium Half-Plate (600 gp)"
                End If
            Case 94 To 100
                Dim r As Integer = d100()
                If r <= 10 Then
                    item = "Small Full Plate (1125 gp)"
                Else
                    item = "Medium Full Plate (1500 gp)"
                End If
            Case Else
                item = "Mundane Junk (0 gp)"
        End Select
        Return item
    End Function

    'Normal Items & functions'
    Public Function GetMeleeWeaponDMG() As NewItem
        Dim num As Integer = Roll(80)
        Select Case num
            Case 1 To 70
                Return GetComMeleeWeaponDMG()
            Case 71 To 80
                Return GetUncMeleeWeaponDMG()
            Case Else
                Return CNewItem("Junk", 0)
        End Select
    End Function
    Public Function GetComMeleeWeaponDMG() As NewItem
        Return GetChart("DMGComMeleeWeapons.txt")
    End Function
    Public Function GetUncMeleeWeaponDMG() As NewItem
        Return GetChart("DMGUncMeleeWeapons.txt")
    End Function
    Public Function GetRangedWeaponDMG() As NewItem
        Return GetChart("DMGRangedWeapons.txt")
    End Function
    Public Function GetArmorDMG() As NewItem
        Return GetChart("DMGArmor.txt")
    End Function
    Public Function GetShieldDMG() As NewItem
        Return GetChart("DMGShields.txt")
    End Function



End Module
