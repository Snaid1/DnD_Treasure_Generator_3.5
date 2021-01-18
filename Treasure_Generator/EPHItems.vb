Module EPHItems

    Public Function GetItemsEPH(ByVal lvl As Integer) As Collection
        Return GetItemsEPH(lvl, 1.0)
    End Function
    Public Function GetItemsEPH(ByVal lvl As Integer, ByVal intItems As Integer) As Collection
        Dim stuff As New Collection
        If intItems = NONE Then
            stuff.Add("No Items")
        ElseIf intItems = HALF Then
            stuff = GetItemsEPH(lvl, 0.5)
        Else
            stuff = GetItemsEPH(lvl)
        End If
        Return stuff
    End Function
    Public Function GetItemsEPH(ByVal lvl As Integer, ByVal Percentage As Double) As Collection
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
                            addC(items, GetMinorMagicEPH())
                    End Select
                Case 2
                    Select Case rolls
                        Case 50 To 85
                            addC(items, GetMundaneDMG())
                        Case 86 To 100
                            addC(items, GetMinorMagicEPH())
                    End Select
                Case 3
                    Select Case rolls
                        Case 50 To 79
                            For x = 1 To d3()
                                addC(items, GetMundaneDMG())
                            Next
                        Case 80 To 100
                            addC(items, GetMinorMagicEPH())
                    End Select
                Case 4
                    Select Case rolls
                        Case 43 To 62
                            For x = 1 To d4()
                                addC(items, GetMundaneDMG())
                            Next
                        Case 63 To 100
                            addC(items, GetMinorMagicEPH())
                    End Select
                Case 5
                    Select Case rolls
                        Case 58 To 67
                            For x = 1 To d4()
                                addC(items, GetMundaneDMG())
                            Next
                        Case 68 To 100
                            For x = 1 To d3()
                                addC(items, GetMinorMagicEPH())
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
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 100
                            addC(items, GetMediumMagicEPH())
                    End Select
                Case 7
                    Select Case rolls
                        Case 52 To 97
                            For x = 1 To d3()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 98 To 100
                            addC(items, GetMediumMagicEPH())
                    End Select
                Case 8
                    Select Case rolls
                        Case 49 To 96
                            For x = 1 To d4()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 97 To 100
                            addC(items, GetMediumMagicEPH())
                    End Select
                Case 9
                    Select Case rolls
                        Case 44 To 91
                            For x = 1 To d4()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 92 To 100
                            addC(items, GetMediumMagicEPH())
                    End Select
                Case 10
                    Select Case rolls
                        Case 41 To 88
                            For x = 1 To d4()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 89 To 99
                            addC(items, GetMediumMagicEPH())
                        Case 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 11
                    Select Case rolls
                        Case 32 To 84
                            For x = 1 To d4()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 85 To 98
                            addC(items, GetMediumMagicEPH())
                        Case 99 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 12
                    Select Case rolls
                        Case 28 To 82
                            For x = 1 To d6()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 83 To 97
                            addC(items, GetMediumMagicEPH())
                        Case 98 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 13
                    Select Case rolls
                        Case 20 To 73
                            For x = 1 To d6()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 74 To 95
                            addC(items, GetMediumMagicEPH())
                        Case 96 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 14
                    Select Case rolls
                        Case 20 To 58
                            For x = 1 To d6()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 59 To 92
                            addC(items, GetMediumMagicEPH())
                        Case 93 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 15
                    Select Case rolls
                        Case 12 To 46
                            For x = 1 To d10()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 47 To 90
                            addC(items, GetMediumMagicEPH())
                        Case 91 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 16
                    Select Case rolls
                        Case 41 To 46
                            For x = 1 To d10()
                                addC(items, GetMinorMagicEPH())
                            Next
                        Case 47 To 90
                            For x = 1 To d3()
                                addC(items, GetMediumMagicEPH())
                            Next
                        Case 91 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 17
                    Select Case rolls
                        Case 34 To 83
                            For x = 1 To d3()
                                addC(items, GetMediumMagicEPH())
                            Next
                        Case 84 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 18
                    Select Case rolls
                        Case 25 To 80
                            For x = 1 To d4()
                                addC(items, GetMediumMagicEPH())
                            Next
                        Case 81 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 19
                    Select Case rolls
                        Case 5 To 70
                            For x = 1 To d4()
                                addC(items, GetMediumMagicEPH())
                            Next
                        Case 71 To 100
                            addC(items, GetMajorMagicEPH())
                    End Select
                Case 20
                    Select Case rolls
                        Case 26 To 65
                            For x = 1 To d4()
                                addC(items, GetMediumMagicEPH())
                            Next
                        Case 66 To 100
                            For x = 1 To d3()
                                addC(items, GetMajorMagicEPH())
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

    '''''''''''''''''''''''''''''''
    '        Psionic Items        '
    '''''''''''''''''''''''''''''''

    Public Function GetMinorMagicEPH() As Object
        Dim roll As Integer = d100()
        Dim magItem As New Object

        Select Case roll
            Case 1 To 2
                magItem = GetMinorMagicArmorEPH()
            Case 3 To 4
                magItem = GetMinorMagicShieldEPH()
            Case 5 To 6
                magItem = GetMinorMagicMeleeWeaponEPH()
            Case 7 To 8
                magItem = GetMinorMagicRangedWeaponEPH()
            Case 9 To 40
                magItem = GetMinorCognizanceCrystalEPH()
            Case 41 To 46
                magItem = GetMinorDorjeEPH()
            Case 47 To 83
                magItem = GetMinorPowerStoneEPH()
            Case 84 To 89
                magItem = GetMinorPsionicTattooEPH()
            Case 90 To 100
                magItem = GetMinorUniversalEPH()
        End Select

        Return magItem
    End Function
    Public Function GetMediumMagicEPH() As Object
        Dim roll As Integer = d100()
        Dim magItem As New Object

        Select Case roll
            Case 1 To 5
                magItem = GetMediumMagicArmorEPH()
            Case 6 To 10
                magItem = GetMediumMagicShieldEPH()
            Case 11 To 15
                magItem = GetMediumMagicMeleeWeaponEPH()
            Case 16 To 20
                magItem = GetMediumMagicRangedWeaponEPH()
            Case 21 To 40
                magItem = GetMediumCognizanceCrystalEPH()
            Case 41 To 50
                magItem = GetMediumDorjeEPH()
            Case 51 To 68
                magItem = GetMediumPowerStoneEPH()
            Case 69 To 82
                magItem = GetMediumPsicrownEPH()
            Case 83 To 89
                magItem = GetMediumPsionicTattooEPH()
            Case 90 To 100
                magItem = GetMediumUniversalEPH()
        End Select

        Return magItem
    End Function
    Public Function GetMajorMagicEPH() As Object
        Dim roll As Integer = d100()
        Dim magItem As New Object

        Select Case roll
            Case 1 To 5
                magItem = GetMajorMagicArmorEPH()
            Case 6 To 10
                magItem = GetMajorMagicShieldEPH()
            Case 11 To 15
                magItem = GetMajorMagicMeleeWeaponEPH()
            Case 16 To 20
                magItem = GetMajorMagicRangedWeaponEPH()
            Case 21 To 35
                magItem = GetMajorCognizanceCrystalEPH()
            Case 36 To 45
                magItem = GetMajorDorjeEPH()
            Case 46 To 67
                magItem = GetMajorPowerStoneEPH()
            Case 68 To 75
                magItem = GetMajorPsicrownEPH()
            Case 76 To 87
                magItem = GetMajorPsionicTattooEPH()
            Case 88 To 100
                magItem = GetMajorUniversalEPH()
        End Select

        Return magItem
    End Function
    'Minor Magic Items Functions
    'Psionic Armors'
    Public Function GetMinorMagicArmorEPH() As NewItem
        Dim armour As New PsiArmor
        Dim num As Integer
        armour.setItem(GetArmorDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 65
                    armour.plusses = 1
                Case 66 To 80
                    armour.plusses = 2
                Case 81 To 100
                    If armour.Value() < 81000 Then
                        GetMinorArmorPsionicAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    Public Function GetMediumMagicArmorEPH() As NewItem
        Dim armour As New PsiArmor
        Dim num As Integer
        armour.setItem(GetArmorDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 10
                    armour.plusses = 1
                Case 11 To 30
                    armour.plusses = 2
                Case 31 To 50
                    armour.plusses = 3
                Case 51 To 60
                    armour.plusses = 4
                Case 61 To 100
                    If armour.Value() < 81000 Then
                        GetMediumArmorPsionicAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    Public Function GetMajorMagicArmorEPH() As NewItem
        Dim armour As New PsiArmor
        Dim num As Integer
        armour.setItem(GetArmorDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 16
                    armour.plusses = 3
                Case 17 To 38
                    armour.plusses = 4
                Case 39 To 57
                    armour.plusses = 5
                Case 58 To 100
                    If armour.Value() < 81000 Then
                        GetMajorArmorPsionicAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    'Psionic Shields'
    Public Function GetMinorMagicShieldEPH() As NewItem
        Dim armour As New PsiShield
        Dim num As Integer
        armour.setItem(GetShieldDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 65
                    armour.plusses = 1
                Case 66 To 80
                    armour.plusses = 2
                Case 81 To 100
                    If armour.Value() < 81000 Then
                        GetMinorShieldPsionicAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    Public Function GetMediumMagicShieldEPH() As NewItem
        Dim armour As New PsiShield
        Dim num As Integer
        armour.setItem(GetShieldDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 10
                    armour.plusses = 1
                Case 11 To 30
                    armour.plusses = 2
                Case 31 To 50
                    armour.plusses = 3
                Case 51 To 60
                    armour.plusses = 4
                Case 61 To 100
                    If armour.Value() < 81000 Then
                        GetMediumShieldPsionicAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    Public Function GetMajorMagicShieldEPH() As NewItem
        Dim armour As New PsiShield
        Dim num As Integer
        armour.setItem(GetShieldDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 16
                    armour.plusses = 3
                Case 17 To 38
                    armour.plusses = 4
                Case 39 To 57
                    armour.plusses = 5
                Case 58 To 100
                    If armour.Value() < 81000 Then
                        GetMajorShieldPsionicAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    'Psionic Melee Weapons'
    Public Function GetMinorMagicMeleeWeaponEPH() As NewItem
        Dim weapon As New PsiMeleeWeapon
        Dim num As Integer
        weapon.setItem(GetMeleeWeaponDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                Case 1 To 70
                    weapon.plusses = 1
                Case 71 To 85
                    weapon.plusses = 2
                Case 86 To 100
                    If weapon.Value() < MAXWEAPONVALUE Then
                        GetMinorMeleePsionicAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMediumMagicMeleeWeaponEPH() As NewItem
        Dim weapon As New PsiMeleeWeapon
        Dim num As Integer
        weapon.setItem(GetMeleeWeaponDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                Case 1 To 10
                    weapon.plusses = 1
                Case 11 To 29
                    weapon.plusses = 2
                Case 30 To 58
                    weapon.plusses = 3
                Case 59 To 62
                    weapon.plusses = 4
                Case 63 To 100
                    If weapon.Value() < MAXWEAPONVALUE Then
                        GetMediumMeleePsionicAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMajorMagicMeleeWeaponEPH() As NewItem
        Dim weapon As New PsiMeleeWeapon
        Dim num As Integer
        weapon.setItem(GetMeleeWeaponDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                Case 1 To 20
                    weapon.plusses = 3
                Case 21 To 38
                    weapon.plusses = 4
                Case 39 To 49
                    weapon.plusses = 5
                Case 50 To 100
                    If weapon.Value() < MAXWEAPONVALUE Then
                        GetMajorMeleePsionicAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    'Psionic Ranged Weapons'
    Public Function GetMinorMagicRangedWeaponEPH() As NewItem
        Dim weapon As New PsiRangedWeapon
        Dim num As Integer
        weapon.setItem(GetRangedWeaponDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                Case 1 To 70
                    weapon.plusses = 1
                Case 71 To 85
                    weapon.plusses = 2
                Case 86 To 100
                    If weapon.Value() < MAXWEAPONVALUE Then
                        GetMinorRangedPsionicAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMediumMagicRangedWeaponEPH() As NewItem
        Dim weapon As New PsiRangedWeapon
        Dim num As Integer
        weapon.setItem(GetRangedWeaponDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                Case 1 To 10
                    weapon.plusses = 1
                Case 11 To 29
                    weapon.plusses = 2
                Case 30 To 58
                    weapon.plusses = 3
                Case 59 To 62
                    weapon.plusses = 4
                Case 63 To 100
                    If weapon.Value() < MAXWEAPONVALUE Then
                        GetMediumRangedPsionicAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMajorMagicRangedWeaponEPH() As NewItem
        Dim weapon As New PsiRangedWeapon
        Dim num As Integer
        weapon.setItem(GetRangedWeaponDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                Case 1 To 20
                    weapon.plusses = 3
                Case 21 To 38
                    weapon.plusses = 4
                Case 39 To 49
                    weapon.plusses = 5
                Case 50 To 100
                    If weapon.Value() < MAXWEAPONVALUE Then
                        GetMajorRangedPsionicAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    'Cognizance Crystals'
    Public Function GetMinorCognizanceCrystalEPH() As NewItem
        Return GetChart("XPHCogCrysMin.txt")
    End Function
    Public Function GetMediumCognizanceCrystalEPH() As NewItem
        Return GetChart("XPHCogCrysMed.txt")
    End Function
    Public Function GetMajorCognizanceCrystalEPH() As NewItem
        Return GetChart("XPHCogCrysMaj.txt")
    End Function
    'Dorjes'
    Public Function GetMinorDorjeEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Djore of "
        Select Case num
            Case 1 To 50
                item.name &= GetPower(1)
                item.value = 750
            Case 51 To 95
                item.name &= GetPower(2)
                item.value = 4500
            Case 96 To 100
                item.name &= GetPower(3)
                item.value = 4500
            Case Else
                item.name &= "Make Pink"
        End Select
        Return item
    End Function
    Public Function GetMediumDorjeEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Djore of "
        Select Case num
            Case 1 To 5
                item.name &= GetPower(2)
                item.value = 4500
            Case 6 To 65
                item.name &= GetPower(3)
                item.value = 11250
            Case 66 To 95
                item.name &= GetPower(4)
                item.value = 21000
            Case 96 To 100
                item.name &= GetPower(5)
                item.value = 33750
            Case Else
                item.name &= "Make Pokedots"
        End Select
        Return item
    End Function
    Public Function GetMajorDorjeEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Djore of "
        Select Case num
            Case 1 To 5
                item.name &= GetPower(4)
                item.value = 21000
            Case 6 To 50
                item.name &= GetPower(5)
                item.value = 33750
            Case 51 To 70
                item.name &= GetPower(6)
                item.value = 49500
            Case 71 To 85
                item.name &= GetPower(7)
                item.value = 68250
            Case 86 To 95
                item.name &= GetPower(8)
                item.value = 90000
            Case 96 To 100
                item.name &= GetPower(9)
                item.value = 114750
            Case Else
                item.name &= "Make Funky"
        End Select
        Return item
    End Function
    'Power Stones
    Public Function GetMinorPowerStoneEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Power Stone of "
        Select Case num
            Case 1 To 50
                item.name &= GetPower(1)
                item.value = 25
            Case 51 To 95
                item.name &= GetPower(2)
                item.value = 150
            Case 96 To 100
                item.name &= GetPower(3)
                item.value = 375
            Case Else
                item.name &= "Make Pink"
        End Select
        Return item
    End Function
    Public Function GetMediumPowerStoneEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Power Stone of "
        Select Case num
            Case 1 To 5
                item.name &= GetPower(2)
                item.value = 150
            Case 6 To 65
                item.name &= GetPower(3)
                item.value = 375
            Case 66 To 95
                item.name &= GetPower(4)
                item.value = 700
            Case 96 To 100
                item.name &= GetPower(5)
                item.value = 1125
            Case Else
                item.name &= "Make Pokedots"
        End Select
        Return item
    End Function
    Public Function GetMajorPowerStoneEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Power Stone of "
        Select Case num
            Case 1 To 5
                item.name &= GetPower(4)
                item.value = 700
            Case 6 To 50
                item.name &= GetPower(5)
                item.value = 1125
            Case 51 To 70
                item.name &= GetPower(6)
                item.value = 1650
            Case 71 To 85
                item.name &= GetPower(7)
                item.value = 2275
            Case 86 To 95
                item.name &= GetPower(8)
                item.value = 3000
            Case 96 To 100
                item.name &= GetPower(9)
                item.value = 3825
            Case Else
                item.name &= "Make Funky"
        End Select
        Return item
    End Function
    'Psicrowns'
    Public Function GetMediumPsicrownEPH() As NewItem
        Dim item As NewItem = GetChart("XPHPsicrownMed.txt")
        item.name = "Psicrown of the " & item.name
        Return item
    End Function
    Public Function GetMajorPsicrownEPH() As NewItem
        Dim item As NewItem = GetChart("XPHPsicrownMaj.txt")
        item.name = "Psicrown of the " & item.name
        Return item
    End Function
    'Psionic Tattoos'
    Public Function GetMinorPsionicTattooEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Psionic Tattoo of "
        Select Case num
            Case 1 To 47
                item.name &= GetPower(1)
                item.value = 50
            Case 48 To 100
                item.name &= GetPower(2)
                item.value = 300
            Case Else
                item.name &= "Make Pink"
        End Select
        Return item
    End Function
    Public Function GetMediumPsionicTattooEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Psionic Tattoo of "
        Select Case num
            Case 1 To 8
                item.name &= GetPower(1)
                item.value = 50
            Case 9 To 75
                item.name &= GetPower(2)
                item.value = 300
            Case 76 To 100
                item.name &= GetPower(3)
                item.value = 750
            Case Else
                item.name &= "Make Pink"
        End Select
        Return item
    End Function
    Public Function GetMajorPsionicTattooEPH() As NewItem
        Dim num As Integer = d100()
        Dim item As New NewItem
        item.name = "Psionic Tattoo of "
        Select Case num
            Case 1 To 50
                item.name &= GetPower(2)
                item.value = 300
            Case 51 To 100
                item.name &= GetPower(3)
                item.value = 750
            Case Else
                item.name &= "Make Pink"
        End Select
        Return item
    End Function
    'Universal Items'
    Public Function GetMinorUniversalEPH() As NewItem
        Return GetChart("XPHUniversalMin.txt")
    End Function
    Public Function GetMediumUniversalEPH() As NewItem
        Return GetChart("XPHUniversalMed.txt")
    End Function
    Public Function GetMajorUniversalEPH() As NewItem
        Return GetChart("XPHUniversalMaj.txt")
    End Function


    'Psionic Special Abilities
    Public Sub GetMinorMeleePsionicAbilities(ByRef weapon As PsiMeleeWeapon)
        SetAbility(weapon, "XPHMeleeWepMin.txt")
    End Sub
    Public Sub GetMediumMeleePsionicAbilities(ByRef weapon As PsiMeleeWeapon)
        SetAbility(weapon, "XPHMeleeWepMed.txt")
    End Sub
    Public Sub GetMajorMeleePsionicAbilities(ByRef weapon As PsiMeleeWeapon)
        SetAbility(weapon, "XPHMeleeWepMaj.txt")
    End Sub
    Public Sub GetMinorRangedPsionicAbilities(ByRef weapon As PsiRangedWeapon)
        SetAbility(weapon, "XPHRangedWepMin.txt")
    End Sub
    Public Sub GetMediumRangedPsionicAbilities(ByRef weapon As PsiRangedWeapon)
        SetAbility(weapon, "XPHRangedWepMed.txt")
    End Sub
    Public Sub GetMajorRangedPsionicAbilities(ByRef weapon As PsiRangedWeapon)
        SetAbility(weapon, "XPHRangedWepMaj.txt")
    End Sub
    Public Sub GetMinorArmorPsionicAbilities(ByRef armour As PsiArmor)
        SetAbility(armour, "XPHArmorMin.txt")
    End Sub
    Public Sub GetMediumArmorPsionicAbilities(ByRef armour As PsiArmor)
        SetAbility(armour, "XPHArmorMed.txt")
    End Sub
    Public Sub GetMajorArmorPsionicAbilities(ByRef armour As PsiArmor)
        SetAbility(armour, "XPHArmorMaj.txt")
    End Sub
    Public Sub GetMinorShieldPsionicAbilities(ByRef shield As PsiShield)
        SetAbility(shield, "XPHShieldMin.txt")
    End Sub
    Public Sub GetMediumShieldPsionicAbilities(ByRef shield As PsiShield)
        SetAbility(shield, "XPHShieldMed.txt")
    End Sub
    Public Sub GetMajorShieldPsionicAbilities(ByRef shield As PsiShield)
        SetAbility(shield, "XPHShieldMaj.txt")
    End Sub

    Public Sub SetAbility(ByRef specialItem As Object, ByVal filename As String)
        Dim i As Integer = 1
        Dim ability As String
        While (i > 0)
            ability = GetChart(filename).name
            If ability = "ROLLTWICE" Then
                i += 2
            Else
                CallByName(specialItem, "set" & ability, CallType.Method)
            End If
            i -= 1
        End While
    End Sub
End Module
