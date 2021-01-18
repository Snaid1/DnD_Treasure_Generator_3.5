Module EPHPowerStruct
    Public Function GetPower(ByVal lvl As Integer) As String
        Dim num As Integer = d100()
        If num >= 71 And num <= 100 And lvl <= 6 Then
            Return GetPsychicWarriorPower(lvl)
        Else
            Return GetPsionPower(lvl)
        End If
    End Function
    Public Function GetPsionPower(ByVal lvl As Integer) As String
        Return GetNameChart("XPHPsion" & CStr(lvl) & ".txt")
    End Function
    Public Function GetPsychicWarriorPower(ByVal lvl As Integer) As String
        Return GetNameChart("XPHPsychicWarrior" & CStr(lvl) & ".txt")
    End Function
    'Weapon Class for psionic items"
    MustInherit Class PsiWeapon
        Inherits GeneralWeapon

        Public Overrides Function BaseAttribs(Optional ByVal first As String = " ") As String
            Dim tempstr As String = ""
            If Psychokinetic = 1 Then
                tempstr &= first & "Psychokinetic"
                first = ", "
            ElseIf Psychokinetic = 2 Then
                tempstr &= first & "Psychokinetic Burst"
                first = ", "
            End If
            If CoupDeGrace Then
                tempstr &= first & "Coup De Grace"
                first = ", "
            End If
            If Psibane Then
                tempstr &= first & "Psibane"
                first = ", "
            End If
            If Collision Then
                tempstr &= first & "Collision"
                first = ", "
            End If
            If Suppression Then
                tempstr &= first & "Suppression"
                first = ", "
            End If
            If Manifester Then
                tempstr &= first & "Manifester"
                first = ", "
            End If

            Return tempstr
        End Function
        Public Overrides Function Attribs() As String
            Return BaseAttribs()
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
        'Functions for defining special abilities'
        Private Psychokinetic As Integer
        Private CoupDeGrace As Boolean
        Private Psibane As Boolean
        Private Collision As Boolean
        Private Suppression As Boolean
        Private Manifester As Boolean

        Public Sub setPsychokinetic()
            If Psychokinetic < 1 Then
                Psychokinetic = 1
                pluscost += 1
            End If
        End Sub
        Public Sub setPsychokineticBurst()
            If Psychokinetic < 2 Then
                If Psychokinetic = 1 Then
                    pluscost += 1
                Else
                    pluscost += 2
                End If
                Psychokinetic = 2
            End If
        End Sub
        Public Sub setCoupDeGrace()
            If CoupDeGrace = False Then
                CoupDeGrace = True
                pluscost += 5
            End If
        End Sub
        Public Sub setPsibane()
            If Psibane = False Then
                Psibane = True
                pluscost += 2
            End If
        End Sub
        Public Sub setCollision()
            If Collision = False Then
                Collision = True
                pluscost += 2
            End If
        End Sub
        Public Sub setSuppression()
            If Suppression = False Then
                Suppression = True
                pluscost += 2
            End If
        End Sub
        Public Sub setManifester()
            If Manifester = False Then
                Manifester = True
                cost += 16000
            End If
        End Sub
    End Class
    Class PsiMeleeWeapon
        Inherits PsiWeapon

        Private Dissipater As Boolean
        Private Lucky As Boolean
        Private Sundering As Boolean
        Private PowerStoring As Boolean
        Private Mindcrusher As Boolean
        Private Parrying As Boolean
        Private Bodyfeeder As Boolean
        Private Mindfeeder As Boolean
        Private Soulbreaker As Boolean
        Private Psychic As Boolean

        Public Sub setDissipater()
            If Dissipater = False Then
                Dissipater = True
                pluscost += 1
            End If
        End Sub
        Public Sub setLucky()
            If Lucky = False Then
                Lucky = True
                pluscost += 1
            End If
        End Sub
        Public Sub setSundering()
            If Sundering = False Then
                Sundering = True
                pluscost += 1
            End If
        End Sub
        Public Sub setPowerStoring()
            If PowerStoring = False Then
                PowerStoring = True
                pluscost += 1
            End If
        End Sub
        Public Sub setMindcrusher()
            If Mindcrusher = False Then
                Mindcrusher = True
                pluscost += 2
            End If
        End Sub
        Public Sub setParrying()
            If Parrying = False Then
                Parrying = True
                cost += 8000
            End If
        End Sub
        Public Sub setBodyfeeder()
            If Bodyfeeder = False Then
                Bodyfeeder = True
                pluscost += 3
            End If
        End Sub
        Public Sub setMindfeeder()
            If Mindfeeder = False Then
                Mindfeeder = True
                pluscost += 3
            End If
        End Sub
        Public Sub setSoulbreaker()
            If Soulbreaker = False Then
                Soulbreaker = True
                pluscost += 3
            End If
        End Sub
        Public Sub setPsychic()
            If Psychic = False Then
                Psychic = True
                cost += 35000
            End If
        End Sub

        Overloads Function Attribs() As String
            Dim first As String = " "
            Dim tempstr As String = ""
            If Dissipater Then
                tempstr &= first & "Dissipater"
                first = ", "
            End If
            If Lucky Then
                tempstr &= first & "Lucky"
                first = ", "
            End If
            If Sundering Then
                tempstr &= first & "Sundering"
                first = ", "
            End If
            If PowerStoring Then
                tempstr &= first & "Power Storing"
                first = ", "
            End If
            If Mindcrusher Then
                tempstr &= first & "Mindcrusher"
                first = ", "
            End If
            If Parrying Then
                tempstr &= first & "Parrying"
                first = ", "
            End If
            If Bodyfeeder Then
                tempstr &= first & "Bodyfeeder"
                first = ", "
            End If
            If Mindfeeder Then
                tempstr &= first & "Mindfeeder"
                first = ", "
            End If
            If Soulbreaker Then
                tempstr &= first & "Soulbreaker"
                first = ", "
            End If
            If Psychic Then
                tempstr &= first & "Psychic"
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
    Class PsiRangedWeapon
        Inherits PsiWeapon
        Private Teleporting As Boolean
        Private Dislocator As Integer

        Public Sub setTeleporting()
            If Teleporting = False Then
                Teleporting = True
                pluscost += 1
            End If
        End Sub
        Public Sub setDislocator()
            If Dislocator < 1 Then
                Dislocator = 1
                pluscost += 1
            End If
        End Sub
        Public Sub setGreatDislocator()
            If Dislocator < 2 Then
                If Dislocator = 1 Then
                    pluscost += 1
                Else
                    pluscost += 2
                End If
                Dislocator = 2
            End If
        End Sub

        Public Overrides Function Attribs() As String
            Dim first As String = " "
            Dim tempstr As String = ""
            If Dislocator = 1 Then
                tempstr &= first & "Dislocator"
                first = ", "
            ElseIf Dislocator = 2 Then
                tempstr &= first & "Great Dislocator"
                first = ", "
            End If
            If Teleporting Then
                tempstr &= first & "Teleporting"
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
    'Armor Class for Psionic Armor and Shields
    MustInherit Class PsiBaseArmor
        Inherits GeneralArmor
        Public Overrides Function BaseAttribs(Optional ByVal first As String = " ") As String
            Dim tempstr As String = ""
            If PowerResistance = 13 Then
                tempstr &= first & "Power Resistance(13)"
                first = ", "
            ElseIf PowerResistance = 15 Then
                tempstr &= first & "Power Resistance(15)"
                first = ", "
            ElseIf PowerResistance = 17 Then
                tempstr &= first & "Power Resistance(17)"
                first = ", "
            ElseIf PowerResistance = 19 Then
                tempstr &= first & "Power Resistance(19)"
                first = ", "
            End If
            If Linked Then
                tempstr &= first & "Linked"
                first = ", "
            End If
            If Vanishing Then
                tempstr &= first & "Vanishing"
                first = ", "
            End If
            If Mindarmor Then
                tempstr &= first & "Mindarmor"
                first = ", "
            End If
            If Aporter Then
                tempstr &= first & "Aporter"
                first = ", "
            End If

            Return tempstr
        End Function
        Public Overrides Function Attribs() As String
            Return BaseAttribs()
        End Function

        Private PowerResistance As Integer
        Private Linked As Boolean
        Private Vanishing As Boolean
        Private Mindarmor As Boolean
        Private Aporter As Boolean

        Public Sub setPowerResistance13()
            If PowerResistance < 13 Then
                PowerResistance = 13
                pluscost += 2
            End If
        End Sub
        Public Sub setPowerResistance15()
            If PowerResistance < 13 Then
                PowerResistance = 15
                pluscost += 3
            ElseIf PowerResistance < 15 Then
                PowerResistance = 15
                pluscost += 1
            End If
        End Sub
        Public Sub setPowerResistance17()
            If PowerResistance < 13 Then
                PowerResistance = 17
                pluscost += 4
            ElseIf PowerResistance < 15 Then
                PowerResistance = 17
                pluscost += 2
            ElseIf PowerResistance < 17 Then
                PowerResistance = 17
                pluscost += 1
            End If
        End Sub
        Public Sub setPowerResistance19()
            If PowerResistance < 13 Then
                pluscost += 5
            ElseIf PowerResistance < 15 Then
                pluscost += 3
            ElseIf PowerResistance < 17 Then
                pluscost += 2
            ElseIf PowerResistance < 19 Then
                pluscost += 1
            End If
                PowerResistance = 19
        End Sub
        Public Sub setLinked()
            If Linked = False Then
                Linked = True
                cost += 6000
            End If
        End Sub
        Public Sub setVanishing()
            If Vanishing = False Then
                Vanishing = True
                pluscost += 3
            End If
        End Sub
        Public Sub setMindarmor()
            If Mindarmor = False Then
                Mindarmor = True
                cost += 24000
            End If
        End Sub
        Public Sub setAporter()
            If Aporter = False Then
                Aporter = True
                cost += 40320
            End If
        End Sub

    End Class
    Public Class PsiArmor
        Inherits PsiBaseArmor

        Private Quickness As Boolean
        Private Landing As Boolean
        Private Floating As Boolean
        Private Seeing As Boolean
        Private Ectoplasmic As Boolean
        Private Gleaming As Boolean
        Private Radiant As Boolean
        Private Phasing As Boolean

        Public Sub setQuickness()
            If Quickness = False Then
                Quickness = True
                pluscost += 1
            End If
        End Sub
        Public Sub setLanding()
            If Landing = False Then
                Landing = True
                cost += 4000
            End If
        End Sub
        Public Sub setFloating()
            If Floating = False Then
                Floating = True
                cost += 4000
            End If
        End Sub
        Public Sub setSeeing()
            If Seeing = False Then
                Seeing = True
                cost += 6000
            End If
        End Sub
        Public Sub setEctoplasmic()
            If Ectoplasmic = False Then
                Ectoplasmic = True
                cost += 10800
            End If
        End Sub
        Public Sub setGleaming()
            If Gleaming = False Then
                Gleaming = True
                pluscost += 3
            End If
        End Sub
        Public Sub setRadiant()
            If Radiant = False Then
                Radiant = True
                pluscost += 4
            End If
        End Sub
        Public Sub setPhasing()
            If Phasing = False Then
                Phasing = True
                cost += 65520
            End If
        End Sub

        Overloads Function Attribs() As String
            Dim first As String = " "
            Dim tempstr As String = ""
            If Quickness Then
                tempstr &= first & "Quickness"
                first = ", "
            End If
            If Landing Then
                tempstr &= first & "Landing"
                first = ", "
            End If
            If Floating Then
                tempstr &= first & "Floating"
                first = ", "
            End If
            If Seeing Then
                tempstr &= first & "Seeing"
                first = ", "
            End If
            If Ectoplasmic Then
                tempstr &= first & "Ectoplasmic"
                first = ", "
            End If
            If Gleaming Then
                tempstr &= first & "Gleaming"
                first = ", "
            End If
            If Radiant Then
                tempstr &= first & "Radiant"
                first = ", "
            End If
            If Quickness Then
                tempstr &= first & "Phasing"
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
    Public Class PsiShield
        Inherits PsiBaseArmor

        Private Heartening As Boolean
        Private Ranged As Boolean
        Private Manifester As Boolean
        Private Averter As Boolean
        Private Wall As Boolean
        Private TimeButtress As Boolean

        Public Sub setHeartening()
            If Heartening = False Then
                Heartening = True
                cost += 720
            End If
        End Sub
        Public Sub setRanged()
            If Ranged = False Then
                Ranged = True
                pluscost += 1
            End If
        End Sub
        Public Sub setManifester()
            If Manifester = False Then
                Manifester = True
                cost += 10800
            End If
        End Sub
        Public Sub setAverter()
            If Averter = False Then
                Averter = True
                cost += 12960
            End If
        End Sub
        Public Sub setWall()
            If Wall = False Then
                Wall = True
                cost += 20160
            End If
        End Sub
        Public Sub setTimeButtress()
            If TimeButtress = False Then
                TimeButtress = True
                cost += 720
            End If
        End Sub

        Overloads Function Attribs() As String
            Dim first As String = " "
            Dim tempstr As String = ""
            If Heartening Then
                tempstr &= first & "Heartening"
                first = ", "
            End If
            If Ranged Then
                tempstr &= first & "Ranged"
                first = ", "
            End If
            If Manifester Then
                tempstr &= first & "Manifester"
                first = ", "
            End If
            If Averter Then
                tempstr &= first & "Averter"
                first = ", "
            End If
            If Wall Then
                tempstr &= first & "Wall"
                first = ", "
            End If
            If TimeButtress Then
                tempstr &= first & "TimeButtress"
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
End Module
