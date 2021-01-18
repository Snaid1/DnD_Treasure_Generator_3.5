Module DMGItems
    '''''''''''''''''''''
    ''   Magic Armor   ''
    '''''''''''''''''''''

    'Get Armors'
    Public Function GetMinorMagicArmorDMG() As NewItem
        Dim armour As New DMGArmor
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
                        GetMinorArmorSpecialAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    Public Function GetMediumMagicArmorDMG() As NewItem
        Dim armour As New DMGArmor
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
                        GetMediumArmorSpecialAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    Public Function GetMajorMagicArmorDMG() As NewItem
        Dim armour As New DMGArmor
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
                        GetMajorArmorSpecialAbilities(armour)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return armour.asItem()
    End Function
    'Get Armor Special Abilities (DMG)'
    Public Sub GetMinorArmorSpecialAbilities(ByRef item As DMGArmor)
        SetAbility(item, "DMGArmorMin.txt")
    End Sub
    Public Sub GetMediumArmorSpecialAbilities(ByRef item As DMGArmor)
        SetAbility(item, "DMGArmorMed.txt")
    End Sub
    Public Sub GetMajorArmorSpecialAbilities(ByRef item As DMGArmor)
        SetAbility(item, "DMGArmorMed.txt")
    End Sub
    'Get Specific Magic Armor (DMG)'
    Public Function GetMinorSpecificArmorDMG() As NewItem
        Return GetChart("DMGArmorSpecificMin.txt")
    End Function
    Public Function GetMediumSpecificArmorDMG() As NewItem
        Return GetChart("DMGArmorSpecificMed.txt")
    End Function
    Public Function GetMajorSpecificArmorDMG() As NewItem
        Return GetChart("DMGArmorSpecificMaj.txt")
    End Function

    '''''''''''''''''''''''
    ''   Magic Shields   ''
    '''''''''''''''''''''''

    'Get Shields'
    Public Function GetMinorMagicShieldDMG() As NewItem
        Dim myshield As New DMGShield
        Dim num As Integer
        myshield.setItem(GetShieldDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 65
                    myshield.plusses = 1
                Case 66 To 80
                    myshield.plusses = 2
                Case 81 To 100
                    If myshield.Value() < 81000 Then
                        GetMinorShieldSpecialAbilities(myshield)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return myshield.asItem()
    End Function
    Public Function GetMediumMagicShieldDMG() As NewItem
        Dim myshield As New DMGShield
        Dim num As Integer
        myshield.setItem(GetShieldDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and armor in chart
                Case 1 To 10
                    myshield.plusses = 1
                Case 11 To 30
                    myshield.plusses = 2
                Case 31 To 50
                    myshield.plusses = 3
                Case 51 To 60
                    myshield.plusses = 4
                Case 61 To 100
                    If myshield.Value() < 81000 Then
                        GetMediumShieldSpecialAbilities(myshield)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return myshield.asItem()
    End Function
    Public Function GetMajorMagicShieldDMG() As NewItem
        Dim myshield As New DMGShield
        Dim num As Integer
        myshield.setItem(GetShieldDMG())
        Dim i As Integer = 1
        While i > 0
            num = Roll(100)
            Select Case num
                ''Percentages were taken from DMG 3.5 and adjusted based 
                ''on apparent devision between shields and Armor in chart
                Case 1 To 16
                    myshield.plusses = 3
                Case 17 To 38
                    myshield.plusses = 4
                Case 39 To 57
                    myshield.plusses = 5
                Case 58 To 100
                    If myshield.Value() < 81000 Then
                        GetMajorShieldSpecialAbilities(myshield)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return myshield.asItem()
    End Function
    'Get Shield Special Ailitys(DMG)'
    Public Sub GetMinorShieldSpecialAbilities(ByRef item As DMGShield)
        SetAbility(item, "DMGShieldMin.txt")
    End Sub
    Public Sub GetMediumShieldSpecialAbilities(ByRef item As DMGShield)
        SetAbility(item, "DMGShieldMed.txt")
    End Sub
    Public Sub GetMajorShieldSpecialAbilities(ByRef item As DMGShield)
        SetAbility(item, "DMGShieldMaj.txt")
    End Sub
    'Get Specific Shields(DMG)'
    Public Function GetMinorSpecificShieldDMG() As NewItem
        Return GetChart("DMGShieldSpecificMin.txt")
    End Function
    Public Function GetMediumSpecificShieldDMG() As NewItem
        Return GetChart("DMGShieldSpecificMed.txt")
    End Function
    Public Function GetMajorSpecificShieldDMG() As NewItem
        Return GetChart("DMGShieldSpecificMaj.txt")
    End Function

    '''''''''''''''''''''''
    ''   Magic Weapons   ''
    '''''''''''''''''''''''
    Public Enum WeaponDamage
        Slashing = 1
        Bludgeoning = 2
        SlashingAndBludgeoning = 3
        Piercing = 4
        SlashingAndPiercing = 5
        BludgeoningAndPiercing = 6
        SlashingAndBludgeoningAndPiercing = 7
        Other = 8
    End Enum
    'Generate Weapons
    Public Function GetMinorMagicWeaponDMG() As NewItem
        Dim num As Integer = Roll(100)
        If num > 80 Then
            Return GetMinorMagicRangedWeaponDMG()
        Else
            Return GetMinorMagicMeleeWeaponDMG()
        End If
    End Function
    Public Function GetMediumMagicWeaponDMG() As NewItem
        Dim num As Integer = Roll(100)
        If num > 80 Then
            Return GetMediumMagicRangedWeaponDMG()
        Else
            Return GetMediumMagicMeleeWeaponDMG()
        End If
    End Function
    Public Function GetMajorMagicWeaponDMG() As NewItem
        Dim num As Integer = Roll(100)
        If num > 80 Then
            Return GetMajorMagicRangedWeaponDMG()
        Else
            Return GetMajorMagicMeleeWeaponDMG()
        End If
    End Function
    'Get Melee Weapons
    Public Function GetMinorMagicMeleeWeaponDMG() As NewItem
        Dim weapon As New DMGMeleeWeapon
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
                        GetMinorMeleeSpecialAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMediumMagicMeleeWeaponDMG() As NewItem
        Dim weapon As New DMGMeleeWeapon
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
                        GetMediumMeleeSpecialAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMajorMagicMeleeWeaponDMG() As NewItem
        Dim weapon As New DMGMeleeWeapon
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
                        GetMajorMeleeSpecialAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    'Get Ranged Weapons
    Public Function GetMinorMagicRangedWeaponDMG() As NewItem
        Dim weapon As New DMGRangedWeapon
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
                        GetMinorRangedSpecialAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMediumMagicRangedWeaponDMG() As NewItem
        Dim weapon As New DMGRangedWeapon
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
                        GetMediumRangedSpecialAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    Public Function GetMajorMagicRangedWeaponDMG() As NewItem
        Dim weapon As New DMGRangedWeapon
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
                        GetMajorRangedSpecialAbilities(weapon)
                    End If
                    i += 1
            End Select
            i -= 1
        End While

        Return weapon.asItem()
    End Function
    'Get Melee Special Abilities
    Public Sub GetMinorMeleeSpecialAbilities(ByRef item As DMGMeleeWeapon)
        SetAbility(item, "DMGMeleeWepMin.txt")
    End Sub
    Public Sub GetMediumMeleeSpecialAbilities(ByRef item As DMGMeleeWeapon)
        SetAbility(item, "DMGMeleeWepMed.txt")
    End Sub
    Public Sub GetMajorMeleeSpecialAbilities(ByRef item As DMGMeleeWeapon)
        SetAbility(item, "DMGMeleeWepMed.txt")
    End Sub
    'Get Ranged Special Abilities
    Public Sub GetMinorRangedSpecialAbilities(ByRef item As DMGRangedWeapon)
        SetAbility(item, "DMGRangedWepMin.txt")
    End Sub
    Public Sub GetMediumRangedSpecialAbilities(ByRef item As DMGRangedWeapon)
        SetAbility(item, "DMGRangedWepMed.txt")
    End Sub
    Public Sub GetMajorRangedSpecialAbilities(ByRef item As DMGRangedWeapon)
        SetAbility(item, "DMGRangedWepMaj.txt")
    End Sub
    'Get Specific Weapons
    Public Function GetMinorSpecificWeaponDMG() As NewItem
        Return GetChart("DMGWepSpecificMin.txt")
    End Function
    Public Function GetMediumSpecificWeaponDMG() As NewItem
        Return GetChart("DMGWepSpecificMed.txt")
    End Function
    Public Function GetMajorSpecificWeaponDMG() As NewItem
        Return GetChart("DMGWepSpecificMaj.txt")
    End Function

    '''''''''''''''''''''''
    ''   Magic Potions   ''
    '''''''''''''''''''''''
    Public Function GetMinorMagicPotionDMG() As NewItem
        Return GetChart("DMGPotionsMin.txt")
    End Function
    Public Function GetMediumMagicPotionDMG() As NewItem
        Return GetChart("DMGPotionsMed.txt")
    End Function
    Public Function GetMajorMagicPotionDMG() As NewItem
        Return GetChart("DMGPotionsMaj.txt")
    End Function

    '''''''''''''''''''''
    ''   Magic Rings   ''
    '''''''''''''''''''''
    Public Function GetMinorMagicRingDMG() As NewItem
        Return GetChart("DMGRingsMin.txt")
    End Function
    Public Function GetMediumMagicRingDMG() As NewItem
        Return GetChart("DMGRingsMed.txt")
    End Function
    Public Function GetMajorMagicRingDMG() As NewItem
        Return GetChart("DMGRingsMaj.txt")
    End Function

    ''''''''''''''''''''
    ''   Magic Rods   ''
    ''''''''''''''''''''
    Public Function GetMediumMagicRodDMG() As NewItem
        Dim myitem As New NewItem
        myitem = GetChart("DMGRodsMed.txt")
        If myitem.name.Contains("Rod") = False Then
            myitem.name = "Rod of " & myitem.name
        End If
        Return myitem
    End Function
    Public Function GetMajorMagicRodDMG() As NewItem
        Dim myitem As New NewItem
        myitem = GetChart("DMGRodsMaj.txt")
        If myitem.name.Contains("Rod") = False Then
            myitem.name = "Rod of " & myitem.name
        End If
        Return myitem
    End Function

    '''''''''''''''''''''''
    ''   Magic Scrolls   ''
    '''''''''''''''''''''''

    'Get Scrolls
    Public Function GetMinorMagicScrollDMG() As Collection
        Dim scroll As New Collection
        Dim rolls As Integer
        Dim numscrolls As Integer = Roll(3)
        For x = 1 To numscrolls
            rolls = d100()
            Select Case rolls
                Case 1 To 70
                    addC(scroll, GetMinorArcaneScrollDMG())
                Case 71 To 100
                    addC(scroll, GetMinorDivineScrollDMG())
            End Select
        Next
        Return scroll
    End Function
    Public Function GetMediumMagicScrollDMG() As Collection
        Dim scroll As New Collection
        Dim rolls As Integer
        Dim numscrolls As Integer = Roll(4)
        For x = 1 To numscrolls
            rolls = d100()
            Select Case rolls
                Case 1 To 70
                    addC(scroll, GetMediumArcaneScrollDMG())
                Case 71 To 100
                    addC(scroll, GetMediumDivineScrollDMG())
            End Select
        Next
        Return scroll
    End Function
    Public Function GetMajorMagicScrollDMG() As Collection
        Dim scroll As New Collection
        Dim rolls As Integer
        Dim numscrolls As Integer = Roll(6)
        For x = 1 To numscrolls
            rolls = d100()
            Select Case rolls
                Case 1 To 70
                    addC(scroll, GetMajorArcaneScrollDMG())
                Case 71 To 100
                    addC(scroll, GetMajorDivineScrollDMG())
            End Select
        Next
        Return scroll
    End Function
    Public Function GetMinorArcaneScrollDMG() As DMGScroll
        Dim roll As Integer = d100()
        Dim myscroll As New DMGScroll
        Dim tempitem As New NewItem
        Select Case roll
            Case 1 To 5
                tempitem = GetArcaneScroll0DMG()
            Case 6 To 50
                tempitem = GetArcaneScroll1DMG()
            Case 51 To 95
                tempitem = GetArcaneScroll2DMG()
            Case 96 To 100
                tempitem = GetArcaneScroll3DMG()
            Case Else
                tempitem.name = "Blank Scroll"
        End Select
        myscroll.Copy(tempitem)
        myscroll.scrollType = MagicType.Arcane
        Return myscroll
    End Function
    Public Function GetMinorDivineScrollDMG() As DMGScroll
        Dim roll As Integer = d100()
        Dim myscroll As New DMGScroll
        Dim tempitem As New NewItem
        Select Case roll
            Case 1 To 5
                tempitem = GetDivineScroll0DMG()
            Case 6 To 50
                tempitem = GetDivineScroll1DMG()
            Case 51 To 95
                tempitem = GetDivineScroll2DMG()
            Case 96 To 100
                tempitem = GetDivineScroll3DMG()
            Case Else
                tempitem.name = "Blank Scroll"
        End Select
        myscroll.Copy(tempitem)
        myscroll.scrollType = MagicType.Arcane
        Return myscroll
    End Function
    Public Function GetMediumArcaneScrollDMG() As DMGScroll
        Dim roll As Integer = d100()
        Dim myscroll As New DMGScroll
        Dim tempitem As New NewItem
        Select Case roll
            Case 1 To 5
                tempitem = GetArcaneScroll2DMG()
            Case 6 To 65
                tempitem = GetArcaneScroll3DMG()
            Case 66 To 95
                tempitem = GetArcaneScroll4DMG()
            Case 96 To 100
                tempitem = GetArcaneScroll5DMG()
            Case Else
                tempitem.name = "Blank Scroll"
        End Select
        myscroll.Copy(tempitem)
        myscroll.scrollType = MagicType.Arcane
        Return myscroll
    End Function
    Public Function GetMediumDivineScrollDMG() As DMGScroll
        Dim roll As Integer = d100()
        Dim myscroll As New DMGScroll
        Dim tempitem As New NewItem
        Select Case roll
            Case 1 To 5
                tempitem = GetDivineScroll2DMG()
            Case 6 To 65
                tempitem = GetDivineScroll3DMG()
            Case 66 To 95
                tempitem = GetDivineScroll4DMG()
            Case 96 To 100
                tempitem = GetDivineScroll5DMG()
            Case Else
                tempitem.name = "Blank Scroll"
        End Select
        myscroll.Copy(tempitem)
        myscroll.scrollType = MagicType.Arcane
        Return myscroll
    End Function
    Public Function GetMajorArcaneScrollDMG() As DMGScroll
        Dim roll As Integer = d100()
        Dim myscroll As New DMGScroll
        Dim tempitem As New NewItem
        Select Case roll
            Case 1 To 5
                tempitem = GetArcaneScroll4DMG()
            Case 6 To 50
                tempitem = GetArcaneScroll5DMG()
            Case 51 To 70
                tempitem = GetArcaneScroll6DMG()
            Case 71 To 85
                tempitem = GetArcaneScroll7DMG()
            Case 86 To 95
                tempitem = GetArcaneScroll8DMG()
            Case 96 To 100
                tempitem = GetArcaneScroll9DMG()
            Case Else
                tempitem.name = "Blank Scroll"
        End Select
        myscroll.Copy(tempitem)
        myscroll.scrollType = MagicType.Arcane
        Return myscroll
    End Function
    Public Function GetMajorDivineScrollDMG() As DMGScroll
        Dim roll As Integer = d100()
        Dim myscroll As New DMGScroll
        Dim tempitem As New NewItem
        Select Case roll
            Case 1 To 5
                tempitem = GetDivineScroll4DMG()
            Case 6 To 50
                tempitem = GetDivineScroll5DMG()
            Case 51 To 70
                tempitem = GetDivineScroll6DMG()
            Case 71 To 85
                tempitem = GetDivineScroll7DMG()
            Case 86 To 95
                tempitem = GetDivineScroll8DMG()
            Case 96 To 100
                tempitem = GetDivineScroll9DMG()
            Case Else
                tempitem.name = "Blank Scroll"
        End Select
        myscroll.Copy(tempitem)
        myscroll.scrollType = MagicType.Divine
        Return myscroll
    End Function
    'Arcane Scrolls
    Public Function GetArcaneScroll0DMG() As NewItem
        Return GetChart("DMGArcaneScroll0.txt")
    End Function
    Public Function GetArcaneScroll1DMG() As NewItem
        Return GetChart("DMGArcaneScroll1.txt")
    End Function
    Public Function GetArcaneScroll2DMG() As NewItem
        Return GetChart("DMGArcaneScroll2.txt")
    End Function
    Public Function GetArcaneScroll3DMG() As NewItem
        Return GetChart("DMGArcaneScroll3.txt")
    End Function
    Public Function GetArcaneScroll4DMG() As NewItem
        Return GetChart("DMGArcaneScroll4.txt")
    End Function
    Public Function GetArcaneScroll5DMG() As NewItem
        Return GetChart("DMGArcaneScroll5.txt")
    End Function
    Public Function GetArcaneScroll6DMG() As NewItem
        Return GetChart("DMGArcaneScroll6.txt")
    End Function
    Public Function GetArcaneScroll7DMG() As NewItem
        Return GetChart("DMGArcaneScroll7.txt")
    End Function
    Public Function GetArcaneScroll8DMG() As NewItem
        Return GetChart("DMGArcaneScroll8.txt")
    End Function
    Public Function GetArcaneScroll9DMG() As NewItem
        Return GetChart("DMGArcaneScroll9.txt")
    End Function
    'Divine Scrolls
    Public Function GetDivineScroll0DMG() As NewItem
        Return GetChart("DMGDivineScroll0.txt")
    End Function
    Public Function GetDivineScroll1DMG() As NewItem
        Return GetChart("DMGDivineScroll1.txt")
    End Function
    Public Function GetDivineScroll2DMG() As NewItem
        Return GetChart("DMGDivineScroll2.txt")
    End Function
    Public Function GetDivineScroll3DMG() As NewItem
        Return GetChart("DMGDivineScroll3.txt")
    End Function
    Public Function GetDivineScroll4DMG() As NewItem
        Return GetChart("DMGDivineScroll4.txt")
    End Function
    Public Function GetDivineScroll5DMG() As NewItem
        Return GetChart("DMGDivineScroll5.txt")
    End Function
    Public Function GetDivineScroll6DMG() As NewItem
        Return GetChart("DMGDivineScroll6.txt")
    End Function
    Public Function GetDivineScroll7DMG() As NewItem
        Return GetChart("DMGDivineScroll7.txt")
    End Function
    Public Function GetDivineScroll8DMG() As NewItem
        Return GetChart("DMGDivineScroll8.txt")
    End Function
    Public Function GetDivineScroll9DMG() As NewItem
        Return GetChart("DMGDivineScroll9.txt")
    End Function

    ''''''''''''''''''''''
    ''   Magic Staffs   ''
    ''''''''''''''''''''''
    Public Function GetMediumMagicStaffDMG() As ChargedItem
        Dim mystaff As New ChargedItem
        mystaff.Copy(GetChart("DMGStaffsMed.txt"))
        mystaff.name = "Staff of " & mystaff.name
        mystaff.charges = Roll(50)

        Return mystaff
    End Function
    Public Function GetMajorMagicStaffDMG() As ChargedItem
        Dim mystaff As New ChargedItem
        mystaff.Copy(GetChart("DMGStaffsMaj.txt"))
        mystaff.name = "Staff of " & mystaff.name
        mystaff.charges = Roll(50)

        Return mystaff
    End Function

    '''''''''''''''''''''
    ''   Magic Wands   ''
    '''''''''''''''''''''
    Public Function GetMinorMagicWandDMG() As ChargedItem
        Dim mywand As New ChargedItem
        mywand.Copy(GetChart("DMGWandsMin.txt"))
        mywand.name = "Wand of " & mywand.name
        mywand.charges = Roll(50)

        Return mywand
    End Function
    Public Function GetMediumMagicWandDMG() As ChargedItem
        Dim mywand As New ChargedItem
        mywand.Copy(GetChart("DMGWandsMed.txt"))
        mywand.name = "Wand of " & mywand.name
        mywand.charges = Roll(50)

        Return mywand
    End Function
    Public Function GetMajorMagicWandDMG() As ChargedItem
        Dim mywand As New ChargedItem
        mywand.Copy(GetChart("DMGWandsMaj.txt"))
        mywand.name = "Wand of " & mywand.name
        mywand.charges = Roll(50)

        Return mywand
    End Function

    '''''''''''''''''''''''''
    ''   Wonderous Items   ''
    '''''''''''''''''''''''''
    Public Function GetMinorMagicWonderDMG() As NewItem
        Return GetChart("DMGWonderousMin.txt")
    End Function
    Public Function GetMediumMagicWonderDMG() As NewItem
        Return GetChart("DMGWonderousMed.txt")
    End Function
    Public Function GetMajorMagicWonderDMG() As NewItem
        Return GetChart("DMGWonderousMaj.txt")
    End Function
End Module
