Module ItemStructs
    MustInherit Class GeneralWeapon
        Public Name As String
        Public plusses As Integer
        Public pluscost As Integer
        Public cost As Integer
        Public damageType As WeaponDamage

        Public Function isSlashing() As Boolean
            If damageType = WeaponDamage.Slashing Or damageType = WeaponDamage.SlashingAndBludgeoning Or damageType = WeaponDamage.SlashingAndPiercing Or damageType = WeaponDamage.SlashingAndBludgeoningAndPiercing Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function isBludgeoning() As Boolean
            If damageType = WeaponDamage.Bludgeoning Or damageType = WeaponDamage.SlashingAndBludgeoning Or damageType = WeaponDamage.BludgeoningAndPiercing Or damageType = WeaponDamage.SlashingAndBludgeoningAndPiercing Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function isPiercing() As Boolean
            If damageType = WeaponDamage.Piercing Or damageType = WeaponDamage.SlashingAndPiercing Or damageType = WeaponDamage.BludgeoningAndPiercing Or damageType = WeaponDamage.SlashingAndBludgeoningAndPiercing Then
                Return True
            Else
                Return False
            End If
        End Function
        Private Function plusValue() As Integer
            Return plusses + pluscost
        End Function
        Public Function Value() As Integer
            Return ((plusValue() * plusValue()) * 2000) + cost
        End Function
        Public MustOverride Function BaseAttribs(Optional ByVal first As String = " ") As String
        Public MustOverride Function Attribs() As String
        Public Overridable Function FullName() As String
            Dim tempname As String = ""
            If plusses > 0 Then
                tempname &= "+" & plusses
            End If
            tempname &= Attribs()
            tempname &= " " & Name
            Return tempname
        End Function
        Public Function asItem() As NewItem
            Dim tempitem As New NewItem
            tempitem.name = FullName()
            tempitem.value = Value()
            Return tempitem
        End Function
        Public Function Display() As String
            Return asItem().Display
        End Function
        Public Sub setItem(ByVal item As NewItem)
            Name = item.name
            cost = item.value
            damageType = item.flag
        End Sub
    End Class
    MustInherit Class DMGWeapon
        Inherits GeneralWeapon

        Public Overrides Function Attribs() As String
            Return BaseAttribs()
        End Function

        Public Overrides Function BaseAttribs(Optional first As String = " ") As String
            Dim tempstr As String = ""
            If Anarchic Then
                tempstr &= first & "Anarchic"
                first = ", "
            End If
            If Axiomatic Then
                tempstr &= first & "Axiomatic"
                first = ", "
            End If
            If Bane Then
                tempstr &= first & BaneType & " Bane"
                first = ", "
            End If
            If BrilliantEnergy Then
                tempstr &= first & "Brilliant Energy"
                first = ", "
            End If
            If Flaming = 1 Then
                tempstr &= first & "Flaming"
                first = ", "
            ElseIf Flaming = 2 Then
                tempstr &= first & "Flaming Burst"
                first = ", "
            End If
            If Frost = 1 Then
                tempstr &= first & "Frost"
                first = ", "
            ElseIf Frost = 2 Then
                tempstr &= first & "Icy Burst"
                first = ", "
            End If
            If Holy Then
                tempstr &= first & "Holy"
                first = ", "
            End If
            If Merciful Then
                tempstr &= first & "Merciful"
                first = ", "
            End If
            If Shock = 1 Then
                tempstr &= first & "Shock"
                first = ", "
            ElseIf Shock = 2 Then
                tempstr &= first & "Shocking Burst"
                first = ", "
            End If
            If Speed Then
                tempstr &= first & "Speed"
                first = ", "
            End If
            If Thundering Then
                tempstr &= first & "Thundering"
                first = ", "
            End If
            If Unholy Then
                tempstr &= first & "Unholy"
                first = ", "
            End If
            Return tempstr
        End Function
        'set attriute values and functions
        Private Anarchic As Boolean
        Private Axiomatic As Boolean
        Private Bane As Boolean
        Private BaneType As String = ""
        Private BrilliantEnergy As Boolean
        Private Flaming As Integer
        Private Frost As Integer
        Private Holy As Boolean
        Private Merciful As Boolean
        Private Shock As Integer
        Private Speed As Boolean
        Private Thundering As Boolean
        Private Unholy As Boolean

        Public Sub setAnarchic()
            If Anarchic = False And Axiomatic = False Then
                Anarchic = True
                pluscost += 2
            End If
        End Sub
        Public Sub setAxiomatic()
            If Axiomatic = False And Anarchic = False Then
                Axiomatic = True
                pluscost += 2
            End If
        End Sub
        Public Sub setBane()
            If Bane = False Then
                Bane = True
                BaneType = GetBaneCreatureType()
                pluscost += 1
            End If
        End Sub
        Public Sub setBrilliantEnergy()
            If BrilliantEnergy = False Then
                BrilliantEnergy = True
                pluscost += 4
            End If
        End Sub
        Public Sub setFlaming()
            If Flaming < 1 Then
                Flaming = 1
                pluscost += 1
            End If
        End Sub
        Public Sub setFlamingBurst()
            If Flaming < 2 Then
                If Flaming = 1 Then
                    pluscost += 1
                Else
                    pluscost += 2
                End If
                Flaming = 2
            End If
        End Sub
        Public Sub setFrost()
            If Frost < 1 Then
                Frost = 1
                pluscost += 1
            End If
        End Sub
        Public Sub setIcyBurst()
            If Frost < 2 Then
                If Frost = 1 Then
                    pluscost += 1
                Else
                    pluscost += 2
                End If
                Frost = 2
            End If
        End Sub
        Public Sub setHoly()
            If Holy = False And Unholy = False Then
                Holy = True
                pluscost += 2
            End If
        End Sub
        Public Sub setMerciful()
            If Merciful = False Then
                Merciful = True
                pluscost += 1
            End If
        End Sub
        Public Sub setShock()
            If Shock < 1 Then
                Shock = 1
                pluscost += 1
            End If
        End Sub
        Public Sub setShockingBurst()
            If Shock < 2 Then
                If Shock = 1 Then
                    pluscost += 1
                Else
                    pluscost += 2
                End If
                Shock = 2
            End If
        End Sub
        Public Sub setSpeed()
            If Speed = False Then
                Speed = True
                pluscost += 3
            End If
        End Sub
        Public Sub setThundering()
            If Thundering = False Then
                Thundering = True
                pluscost += 1
            End If
        End Sub
        Public Sub setUnholy()
            If Unholy = False And Holy = False Then
                Unholy = True
                pluscost += 2
            End If
        End Sub
        Public Overrides Function FullName() As String
            Dim tempname As String = ""
            If plusses > 0 Then
                tempname &= "+" & plusses
            End If
            tempname &= Attribs()
            tempname &= " " & Name
            Return tempname
        End Function
    End Class
    Public Class DMGMeleeWeapon
        Inherits DMGWeapon

        Private Dancing As Boolean
        Private Defending As Boolean
        Private Disruption As Boolean
        Private GhostTouch As Boolean
        Private Keen As Boolean
        Private KiFocus As Boolean
        Private MightyCleaving As Boolean
        Private SpellStoring As Boolean
        Private Throwing As Boolean
        Private Vicious As Boolean
        Private Vorpal As Boolean
        Private Wounding As Boolean

        Public Sub setDancing()
            If Dancing = False Then
                Dancing = True
                pluscost += 4
            End If
        End Sub
        Public Sub setDefending()
            If Defending = False Then
                Defending = True
                pluscost += 1
            End If
        End Sub
        Public Sub setDisruption()
            If Disruption = False And isBludgeoning() Then
                Disruption = True
                pluscost += 2
            End If
        End Sub
        Public Sub setGhostTouch()
            If GhostTouch = False Then
                GhostTouch = True
                pluscost += 1
            End If
        End Sub
        Public Sub setKeen()
            If Keen = False And (isSlashing() Or isPiercing()) Then
                Keen = True
                pluscost += 1
            End If
        End Sub
        Public Sub setKiFocus()
            If KiFocus = False Then
                KiFocus = True
                pluscost += 1
            End If
        End Sub
        Public Sub setMightyCleaving()
            If MightyCleaving = False Then
                MightyCleaving = True
                pluscost += 1
            End If
        End Sub
        Public Sub setSpellStoring()
            If SpellStoring = False Then
                SpellStoring = True
                pluscost += 1
            End If
        End Sub
        Public Sub setThrowing()
            If Throwing = False Then
                Throwing = True
                pluscost += 1
            End If
        End Sub
        Public Sub setVicious()
            If Vicious = False Then
                Vicious = True
                pluscost += 1
            End If
        End Sub
        Public Sub setVorpal()
            If Vorpal = False And (isSlashing() Or isPiercing()) Then
                Vorpal = True
                pluscost += 5
            End If
        End Sub
        Public Sub setWounding()
            If Wounding = False Then
                Wounding = True
                pluscost += 2
            End If
        End Sub

        Public Overrides Function Attribs() As String
            Dim first As String = " "
            Dim tempstr As String = ""

            If Dancing Then
                tempstr &= first & "Dancing"
                first = ", "
            End If
            If Defending Then
                tempstr &= first & "Defending"
                first = ", "
            End If
            If Disruption Then
                tempstr &= first & "Disruption"
                first = ", "
            End If
            If GhostTouch Then
                tempstr &= first & "Ghost Touch"
                first = ", "
            End If
            If Keen Then
                tempstr &= first & "Keen"
                first = ", "
            End If
            If KiFocus Then
                tempstr &= first & "Ki Focus"
                first = ", "
            End If
            If MightyCleaving Then
                tempstr &= first & "Mighty Cleaving"
                first = ", "
            End If
            If SpellStoring Then
                tempstr &= first & "Spell Storing"
                first = ", "
            End If
            If Throwing Then
                tempstr &= first & "Throwing"
                first = ", "
            End If
            If Vicious Then
                tempstr &= first & "Vicious"
                first = ", "
            End If
            If Vorpal Then
                tempstr &= first & "Vorpal"
                first = ", "
            End If
            If Wounding Then
                tempstr &= first & "Wounding"
                first = ", "
            End If

            tempstr &= BaseAttribs(first)
            Return tempstr
        End Function
        Public Overrides Function FullName() As String
            Dim tempname As String = ""
            If plusses > 0 Then
                tempname &= "+" & plusses
            End If
            tempname &= Attribs()
            tempname &= " " & Name
            Return tempname
        End Function
    End Class
    Public Class DMGRangedWeapon
        Inherits DMGWeapon

        Private Distance As Boolean
        Private Returning As Boolean
        Private Seeking As Boolean

        Public Sub setDistance()
            If Distance = False Then
                Distance = True
                pluscost += 4
            End If
        End Sub
        Public Sub setReturning()
            If Returning = False Then
                Returning = True
                pluscost += 4
            End If
        End Sub
        Public Sub setSeeking()
            If Seeking = False Then
                Seeking = True
                pluscost += 4
            End If
        End Sub


        Public Overrides Function Attribs() As String
            Dim first As String = " "
            Dim tempstr As String = ""

            If Distance Then
                tempstr &= first & "Distance"
                first = ", "
            End If
            If Returning Then
                tempstr &= first & "Returning"
                first = ", "
            End If
            If Seeking Then
                tempstr &= first & "Seeking"
                first = ", "
            End If

            tempstr &= BaseAttribs(first)
            Return tempstr
        End Function
        Public Overrides Function FullName() As String
            Dim tempname As String = ""
            If plusses > 0 Then
                tempname &= "+" & plusses
            End If
            tempname &= Attribs()
            tempname &= " " & Name
            Return tempname
        End Function
    End Class

    ''''''''''''''''''''''
    ''     Armors       ''
    ''''''''''''''''''''''
    MustInherit Class GeneralArmor
        Public Name As String
        Public plusses As Integer
        Public pluscost As Integer
        Public cost As Integer

        Private Function plusValue() As Integer
            Return plusses + pluscost
        End Function
        Public Function Value() As Integer
            Return ((plusValue() * plusValue()) * 1000) + cost
        End Function
        Public MustOverride Function BaseAttribs(Optional ByVal first As String = " ") As String
        Public MustOverride Function Attribs() As String
        Public Overridable Function FullName() As String
            Dim tempname As String = ""
            If plusses > 0 Then
                tempname &= "+" & plusses
            End If
            tempname &= Attribs()
            tempname &= " " & Name
            Return tempname
        End Function
        Public Function asItem() As NewItem
            Dim tempitem As New NewItem
            tempitem.name = FullName()
            tempitem.value = Value()
            Return tempitem
        End Function
        Public Function Display() As String
            Return asItem().Display
        End Function
        Public Sub setItem(ByVal item As NewItem)
            Name = item.name
            cost = item.value
        End Sub

        Public Function checkBlank(ByVal list, ByRef first) As String
            If list <> "" Then
                list = first & list
                first = ", "
            End If
            Return list
        End Function
    End Class
    MustInherit Class DMGBaseArmor
        Inherits GeneralArmor

        Private AcidResistance As Integer
        Private ColdResistance As Integer
        Private ElectricityResistance As Integer
        Private FireResistance As Integer
        Private Fortification As Integer
        Private GhostTouch As Boolean
        Private SonicResistance As Integer
        Private SpellResistance As Integer
        Private UndeadControlling As Boolean
        Private Wild As Boolean

        Public Sub setAcidResistance()
            If AcidResistance < 1 Then
                AcidResistance = 1
                cost += 18000
            End If
        End Sub
        Public Sub setImprovedAcidResistance()
            If AcidResistance < 2 Then
                If AcidResistance = 1 Then
                    cost += 24000
                Else
                    cost += 42000
                End If
                AcidResistance = 2
            End If
        End Sub
        Public Sub setGreaterAcidResistance()
            If AcidResistance < 3 Then
                Select Case AcidResistance
                    Case 2
                        cost += 24000
                    Case 1
                        cost += 48000
                    Case Else
                        cost += 66000
                End Select
                AcidResistance = 3
            End If
        End Sub
        Public Sub setColdResistance()
            If ColdResistance < 1 Then
                ColdResistance = 1
                cost += 18000
            End If
        End Sub
        Public Sub setImprovedColdResistance()
            If ColdResistance < 2 Then
                If ColdResistance = 1 Then
                    cost += 24000
                Else
                    cost += 42000
                End If
                ColdResistance = 2
            End If
        End Sub
        Public Sub setGreaterColdResistance()
            If ColdResistance < 3 Then
                Select Case ColdResistance
                    Case 2
                        cost += 24000
                    Case 1
                        cost += 48000
                    Case Else
                        cost += 66000
                End Select
                ColdResistance = 3
            End If
        End Sub
        Public Sub setElectricityResistance()
            If ElectricityResistance < 1 Then
                ElectricityResistance = 1
                cost += 18000
            End If
        End Sub
        Public Sub setImprovedElectricityResistance()
            If ElectricityResistance < 2 Then
                If ElectricityResistance = 1 Then
                    cost += 24000
                Else
                    cost += 42000
                End If
                ElectricityResistance = 2
            End If
        End Sub
        Public Sub setGreaterElectricityResistance()
            If ElectricityResistance < 3 Then
                Select Case ElectricityResistance
                    Case 2
                        cost += 24000
                    Case 1
                        cost += 48000
                    Case Else
                        cost += 66000
                End Select
                ElectricityResistance = 3
            End If
        End Sub
        Public Sub setFireResistance()
            If FireResistance < 1 Then
                FireResistance = 1
                cost += 18000
            End If
        End Sub
        Public Sub setImprovedFireResistance()
            If FireResistance < 2 Then
                If FireResistance = 1 Then
                    cost += 24000
                Else
                    cost += 42000
                End If
                FireResistance = 2
            End If
        End Sub
        Public Sub setGreaterFireResistance()
            If FireResistance < 3 Then
                Select Case FireResistance
                    Case 2
                        cost += 24000
                    Case 1
                        cost += 48000
                    Case Else
                        cost += 66000
                End Select
                FireResistance = 3
            End If
        End Sub
        Public Sub setFortificationLight()
            If Fortification < 1 Then
                Fortification = 1
                pluscost += 1
            End If
        End Sub
        Public Sub setFortificationModerate()
            If Fortification < 2 Then
                If Fortification = 1 Then
                    pluscost += 2
                Else
                    pluscost += 3
                End If
                Fortification = 2
            End If
        End Sub
        Public Sub setFortificationHeavy()
            If Fortification < 3 Then
                Select Case Fortification
                    Case 2
                        pluscost += 2
                    Case 1
                        pluscost += 4
                    Case Else
                        pluscost += 5
                End Select
                Fortification = 3
            End If
        End Sub
        Public Sub setGhostTouch()
            If GhostTouch = False Then
                GhostTouch = True
                pluscost += 3
            End If
        End Sub
        Public Sub setSonicResistance()
            If SonicResistance < 1 Then
                SonicResistance = 1
                cost += 18000
            End If
        End Sub
        Public Sub setImprovedSonicResistance()
            If SonicResistance < 2 Then
                If SonicResistance = 1 Then
                    cost += 24000
                Else
                    cost += 42000
                End If
                SonicResistance = 2
            End If
        End Sub
        Public Sub setGreaterSonicResistance()
            If SonicResistance < 3 Then
                Select Case SonicResistance
                    Case 2
                        cost += 24000
                    Case 1
                        cost += 48000
                    Case Else
                        cost += 66000
                End Select
                SonicResistance = 3
            End If
        End Sub
        Public Sub setSpellResistance13()
            If SpellResistance < 13 Then
                SpellResistance = 13
                pluscost += 2
            End If
        End Sub
        Public Sub setSpellResistance15()
            If SpellResistance < 13 Then
                SpellResistance = 15
                pluscost += 3
            ElseIf SpellResistance < 15 Then
                SpellResistance = 15
                pluscost += 1
            End If
        End Sub
        Public Sub setSpellResistance17()
            If SpellResistance < 13 Then
                SpellResistance = 17
                pluscost += 4
            ElseIf SpellResistance < 15 Then
                SpellResistance = 17
                pluscost += 2
            ElseIf SpellResistance < 17 Then
                SpellResistance = 17
                pluscost += 1
            End If
        End Sub
        Public Sub setSpellResistance19()
            If SpellResistance < 13 Then
                pluscost += 5
            ElseIf SpellResistance < 15 Then
                pluscost += 3
            ElseIf SpellResistance < 17 Then
                pluscost += 2
            ElseIf SpellResistance < 19 Then
                pluscost += 1
            End If
            SpellResistance = 19
        End Sub
        Public Sub setUndeadControlling()
            If UndeadControlling = False Then
                UndeadControlling = True
                cost += 49000
            End If
        End Sub
        Public Sub setWild()
            If Wild = False Then
                Wild = True
                pluscost += 3
            End If
        End Sub

        Private Function getAcidResistance() As String
            Dim tempstr As String
            Select Case AcidResistance
                Case 1
                    tempstr = "Acid Resistance"
                Case 2
                    tempstr = "Improved Acid Resistance"
                Case 3
                    tempstr = "Greater Acid Resistance"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getColdResistance() As String
            Dim tempstr As String
            Select Case ColdResistance
                Case 1
                    tempstr = "Cold Resistance"
                Case 2
                    tempstr = "Improved Cold Resistance"
                Case 3
                    tempstr = "Greater Cold Resistance"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getElectricityResistance() As String
            Dim tempstr As String
            Select Case ElectricityResistance
                Case 1
                    tempstr = "Electrisity Resistance"
                Case 2
                    tempstr = "Improved Electrisity Resistance"
                Case 3
                    tempstr = "Greater Electrisity Resistance"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getFireResistance() As String
            Dim tempstr As String
            Select Case FireResistance
                Case 1
                    tempstr = "Fire Resistance"
                Case 2
                    tempstr = "Improved Fire Resistance"
                Case 3
                    tempstr = "Greater Fire Resistance"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getFortification() As String
            Dim tempstr As String
            Select Case Fortification
                Case 1
                    tempstr = "Light Fortification"
                Case 2
                    tempstr = "Moderate Fortification"
                Case 3
                    tempstr = "Heavy Fortification"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getGhostTouch() As String
            Dim tempstr As String
            If GhostTouch Then
                tempstr = "Ghost Touch"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getSonicResistance() As String
            Dim tempstr As String
            Select Case SonicResistance
                Case 1
                    tempstr = "Sonic Resistance"
                Case 2
                    tempstr = "Improved Sonic Resistance"
                Case 3
                    tempstr = "Greater Sonic Resistance"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getSpellResistance() As String
            Dim tempstr As String
            Select Case SpellResistance
                Case 13
                    tempstr = "Spell Resistance(13)"
                Case 15
                    tempstr = "Spell Resistance(15)"
                Case 17
                    tempstr = "Spell Resistance(17)"
                Case 19
                    tempstr = "Spell Resistance(19)"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getUndeadControlling() As String
            Dim tempstr As String
            If UndeadControlling Then
                tempstr = "Undead Controlling"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getWild() As String
            Dim tempstr As String
            If Wild Then
                tempstr = "Wild"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function

        Public Overrides Function Attribs() As String
            Return BaseAttribs()
        End Function
        Public Overrides Function BaseAttribs(Optional first As String = " ") As String
            Dim tempstr As String = ""
            tempstr &= checkBlank(getAcidResistance(), first)
            tempstr &= checkBlank(getColdResistance(), first)
            tempstr &= checkBlank(getElectricityResistance(), first)
            tempstr &= checkBlank(getFireResistance(), first)
            tempstr &= checkBlank(getFortification(), first)
            tempstr &= checkBlank(getGhostTouch(), first)
            tempstr &= checkBlank(getSonicResistance(), first)
            tempstr &= checkBlank(getSpellResistance(), first)
            tempstr &= checkBlank(getUndeadControlling(), first)
            tempstr &= checkBlank(getWild(), first)
            Return tempstr
        End Function
    End Class
    Public Class DMGArmor
        Inherits DMGBaseArmor

        Private Etherialness As Boolean
        Private Glamered As Boolean
        Private Invulnerability As Boolean
        Private Shadow As Integer
        Private SilentMoves As Integer
        Private Slick As Integer

        Public Sub setEtherialness()
            If Etherialness = False Then
                Etherialness = True
                cost += 49000
            End If
        End Sub
        Public Sub setGlamered()
            If Glamered = False Then
                Glamered = True
                cost += 2700
            End If
        End Sub
        Public Sub setInvulnerability()
            If Invulnerability = False Then
                Invulnerability = True
                pluscost += 3
            End If
        End Sub
        Public Sub setShadow()
            If Shadow < 1 Then
                Shadow = 1
                cost += 3750
            End If
        End Sub
        Public Sub setImprovedShadow()
            If Shadow < 2 Then
                If Shadow = 1 Then
                    cost += 11250
                Else
                    cost += 15000
                End If
                Shadow = 2
            End If
        End Sub
        Public Sub setGreaterShadow()
            If Shadow < 3 Then
                Select Case Shadow
                    Case 2
                        cost += 18750
                    Case 1
                        cost += 30000
                    Case Else
                        cost += 33750
                End Select
                Shadow = 3
            End If
        End Sub
        Public Sub setSilentMoves()
            If SilentMoves < 1 Then
                SilentMoves = 1
                cost += 3750
            End If
        End Sub
        Public Sub setImprovedSilentMoves()
            If SilentMoves < 2 Then
                If SilentMoves = 1 Then
                    cost += 11250
                Else
                    cost += 15000
                End If
                SilentMoves = 2
            End If
        End Sub
        Public Sub setGreaterSilentMoves()
            If SilentMoves < 3 Then
                Select Case SilentMoves
                    Case 2
                        cost += 18750
                    Case 1
                        cost += 30000
                    Case Else
                        cost += 33750
                End Select
                SilentMoves = 3
            End If
        End Sub
        Public Sub setSlick()
            If Slick < 1 Then
                Slick = 1
                cost += 3750
            End If
        End Sub
        Public Sub setImprovedSlick()
            If Slick < 2 Then
                If Slick = 1 Then
                    cost += 11250
                Else
                    cost += 15000
                End If
                Slick = 2
            End If
        End Sub
        Public Sub setGreaterSlick()
            If Slick < 3 Then
                Select Case Slick
                    Case 2
                        cost += 18750
                    Case 1
                        cost += 30000
                    Case Else
                        cost += 33750
                End Select
                Slick = 3
            End If
        End Sub

        Private Function getEtherialness() As String
            Dim tempstr As String
            If Etherialness Then
                tempstr = "Etherialness"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getGlamered() As String
            Dim tempstr As String
            If Glamered Then
                tempstr = "Glamered"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getInvulnerability() As String
            Dim tempstr As String
            If Invulnerability Then
                tempstr = "Invulnerability"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getShadow() As String
            Dim tempstr As String
            Select Case Shadow
                Case 1
                    tempstr = "Shadow"
                Case 2
                    tempstr = "Improved Shadow"
                Case 3
                    tempstr = "Greater Shadow"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getSilentMoves() As String
            Dim tempstr As String
            Select Case SilentMoves
                Case 1
                    tempstr = "Silent Moves"
                Case 2
                    tempstr = "Improved Silent Moves"
                Case 3
                    tempstr = "Greater Silent Moves"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function
        Private Function getSlick() As String
            Dim tempstr As String
            Select Case Slick
                Case 1
                    tempstr = "Slick"
                Case 2
                    tempstr = "Improved Slick"
                Case 3
                    tempstr = "Greater Slick"
                Case Else
                    tempstr = ""
            End Select
            Return tempstr
        End Function

        Public Overrides Function Attribs() As String
            Dim tempstr As String = ""
            Dim first As String = " "

            tempstr &= checkBlank(getEtherialness(), first)
            tempstr &= checkBlank(getGlamered(), first)
            tempstr &= checkBlank(getInvulnerability(), first)
            tempstr &= checkBlank(getShadow(), first)
            tempstr &= checkBlank(getSilentMoves(), first)
            tempstr &= checkBlank(getSlick(), first)

            tempstr &= BaseAttribs(first)
            Return tempstr
        End Function
        Public Overrides Function FullName() As String
            Dim tempname As String = ""
            If plusses > 0 Then
                tempname &= "+" & plusses
            End If
            tempname &= Attribs()
            tempname &= " " & Name
            Return tempname
        End Function
    End Class
    Public Class DMGShield
        Inherits DMGBaseArmor

        Private Animated As Boolean
        Private ArrowCatching As Boolean
        Private ArrowDeflection As Boolean
        Private Bashing As Boolean
        Private Blinding As Boolean
        Private Reflecting As Boolean

        Public Sub setAnimated()
            If Animated = False Then
                Animated = True
                pluscost += 2
            End If
        End Sub
        Public Sub setArrowCatching()
            If ArrowCatching = False Then
                ArrowCatching = True
                pluscost += 1
            End If
        End Sub
        Public Sub setArrowDeflection()
            If ArrowDeflection = False Then
                ArrowDeflection = True
                pluscost += 2
            End If
        End Sub
        Public Sub setBashing()
            If Bashing = False Then
                Bashing = True
                pluscost += 1
            End If
        End Sub
        Public Sub setBlinding()
            If Blinding = False Then
                Blinding = True
                pluscost += 1
            End If
        End Sub
        Public Sub setReflecting()
            If Reflecting = False Then
                Reflecting = True
                pluscost += 5
            End If
        End Sub

        Private Function getAnimated() As String
            Dim tempstr As String
            If Animated Then
                tempstr = "Animated"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getArrowCatching() As String
            Dim tempstr As String
            If ArrowCatching Then
                tempstr = "Arrow Catching"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getArrowDeflection() As String
            Dim tempstr As String
            If ArrowDeflection Then
                tempstr = "Arrow Deflection"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getBashing() As String
            Dim tempstr As String
            If Bashing Then
                tempstr = "Bashing"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getBlinding() As String
            Dim tempstr As String
            If Blinding Then
                tempstr = "Blinding"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function
        Private Function getReflecting() As String
            Dim tempstr As String
            If Reflecting Then
                tempstr = "Reflecting"
            Else
                tempstr = ""
            End If
            Return tempstr
        End Function

        Public Overrides Function Attribs() As String
            Dim tempstr As String = ""
            Dim first As String = " "

            tempstr &= checkBlank(getAnimated(), first)
            tempstr &= checkBlank(getArrowCatching(), first)
            tempstr &= checkBlank(getArrowDeflection(), first)
            tempstr &= checkBlank(getBashing(), first)
            tempstr &= checkBlank(getBlinding(), first)
            tempstr &= checkBlank(getReflecting(), first)

            tempstr &= BaseAttribs(first)
            Return tempstr
        End Function
        Public Overrides Function FullName() As String
            Dim tempname As String = ""
            If plusses > 0 Then
                tempname &= "+" & plusses
            End If
            tempname &= Attribs()
            tempname &= " " & Name
            Return tempname
        End Function
    End Class

    ''''''''''''''''''''''
    ''     Scrolls      ''
    ''''''''''''''''''''''
    Enum MagicType
        Arcane = 1
        Divine = 2
    End Enum
    Public Class DMGScroll
        Inherits NewItem
        Public silverValue As Integer
        Public scrollType As MagicType
        Public Overrides Function Display() As String
            Dim tempstr As String
            If scrollType = MagicType.Arcane Then
                tempstr = "Arcane "
            ElseIf scrollType = MagicType.Divine Then
                tempstr = "Divine "
            Else
                tempstr = "Unknown "
            End If
            tempstr &= "Scroll of " & name & " (" & CStr(value) & " gp"
            If silverValue > 0 Then
                tempstr &= " " & CStr(silverValue) & " sp"
            End If
            tempstr &= ")"
            Return tempstr
        End Function
        Public Overrides Sub Copy(item As NewItem)
            name = item.name
            value = item.value
            silverValue = item.flag
        End Sub
        Public Overloads Sub Copy(item As DMGScroll)
            name = item.name
            value = item.value
            silverValue = item.silverValue
            scrollType = item.scrollType
            flag = item.flag
        End Sub
    End Class
    Public Class ChargedItem
        Inherits NewItem
        Public charges As Integer
        Public Overrides Function Display() As String
            Return name & " [" & CStr(charges) & " charges]" & " (" & CStr(ReducePriceByCharge50(value, charges)) & " gp)"
        End Function
        Public Function ReducePriceByCharge50(ByVal price As Integer, ByVal charges As Integer) As Integer
            price = (charges / 50) * price
            Return price
        End Function
    End Class

End Module
