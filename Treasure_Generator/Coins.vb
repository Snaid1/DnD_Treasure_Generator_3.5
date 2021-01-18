Module Coins
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '"'                                                           '"'
    '"'                  Start of Coin Functions                  '"'
    '"'                                                           '"'
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function getcoinsDMG(ByVal level As Integer) As String
        Return getcoinsDMG(level, 1.0)
    End Function
    Public Function getcoinsDMG(ByVal level As Integer, ByVal intcoin As Integer) As String
        If intcoin = NONE Then
            Return "None"
        ElseIf intcoin = HALF Then
            Return getcoinsDMG(level, 0.5)
        ElseIf intcoin = TEN Then
            Return getcoinsDMG(level, 0.1)
        Else
            Return getcoinsDMG(level)
        End If
    End Function
    Public Function getcoinsDMG(ByVal level As Integer, ByVal percentage As Double) As String
        Dim total As String 'returned value
        Dim value As Integer = 0 'number of pieces
        Dim pieces As Integer = 0 'type of pieces 1=cp 2=sp 3=gp 4=pp
        Dim roll As Integer = d100()
        Select Case level
            Case 1
                Select Case roll
                    Case 1 To 14
                        value = 0
                        pieces = 0
                    Case 15 To 29
                        value = Getcoins(6, 1000)
                        pieces = CP
                    Case 30 To 52
                        value = Getcoins(8, 100)
                        pieces = SP
                    Case 53 To 95
                        value = Getcoins(2, 8, 10)
                        pieces = GP
                    Case 96 To 100
                        value = Getcoins(4, 10)
                        pieces = PP
                End Select
            Case 2
                Select Case roll
                    Case 1 To 13
                        value = 0
                        pieces = 0
                    Case 14 To 23
                        value = Getcoins(10, 1000)
                        pieces = CP
                    Case 24 To 43
                        value = Getcoins(2, 10, 100)
                        pieces = SP
                    Case 44 To 95
                        value = Getcoins(4, 10, 10)
                        pieces = GP
                    Case 96 To 100
                        value = Getcoins(2, 8, 10)
                        pieces = PP
                End Select
            Case 3
                Select Case roll
                    Case 1 To 11
                        value = 0
                        pieces = 0
                    Case 12 To 21
                        value = Getcoins(2, 10, 1000)
                        pieces = CP
                    Case 22 To 41
                        value = Getcoins(4, 8, 100)
                        pieces = SP
                    Case 42 To 95
                        value = Getcoins(4, 100)
                        pieces = GP
                    Case 96 To 100
                        value = Getcoins(10, 10)
                        pieces = PP
                End Select
            Case 4
                Select Case roll
                    Case 1 To 11
                        value = 0
                        pieces = 0
                    Case 12 To 21
                        value = Getcoins(3, 10, 1000)
                        pieces = CP
                    Case 22 To 41
                        value = Getcoins(4, 12, 1000)
                        pieces = SP
                    Case 42 To 95
                        value = Getcoins(6, 100)
                        pieces = GP
                    Case 96 To 100
                        value = Getcoins(8, 10)
                        pieces = PP
                End Select
            Case 5
                Select Case roll
                    Case 1 To 10
                        value = 0
                        pieces = 0
                    Case 11 To 19
                        value = Getcoins(4, 10000)
                        pieces = CP
                    Case 20 To 38
                        value = Getcoins(6, 1000)
                        pieces = SP
                    Case 39 To 95
                        value = Getcoins(8, 100)
                        pieces = GP
                    Case 96 To 100
                        value = Getcoins(10, 10)
                        pieces = PP
                End Select
            Case 6
                Select Case roll
                    Case 1 To 10
                        value = 0
                        pieces = 0
                    Case 11 To 18
                        value = Getcoins(6, 10000)
                        pieces = CP
                    Case 19 To 37
                        value = Getcoins(8, 1000)
                        pieces = SP
                    Case 38 To 95
                        value = Getcoins(10, 100)
                        pieces = GP
                    Case 96 To 100
                        value = Getcoins(12, 10)
                        pieces = PP
                End Select
            Case 7
                Select Case roll
                    Case 1 To 11
                        value = 0
                        pieces = 0
                    Case 12 To 18
                        value = Getcoins(10, 10000)
                        pieces = CP
                    Case 19 To 35
                        value = Getcoins(12, 1000)
                        pieces = SP
                    Case 36 To 93
                        value = Getcoins(2, 6, 100)
                        pieces = GP
                    Case 94 To 100
                        value = Getcoins(3, 4, 10)
                        pieces = PP
                End Select
            Case 8
                Select Case roll
                    Case 1 To 10
                        value = 0
                        pieces = 0
                    Case 11 To 15
                        value = Getcoins(12, 10000)
                        pieces = CP
                    Case 16 To 29
                        value = Getcoins(2, 6, 1000)
                        pieces = SP
                    Case 30 To 87
                        value = Getcoins(2, 8, 100)
                        pieces = GP
                    Case 88 To 100
                        value = Getcoins(3, 6, 10)
                        pieces = PP
                End Select
            Case 9
                Select Case roll
                    Case 1 To 10
                        value = 0
                        pieces = 0
                    Case 11 To 15
                        value = Getcoins(2, 6, 10000)
                        pieces = CP
                    Case 16 To 29
                        value = Getcoins(2, 8, 1000)
                        pieces = SP
                    Case 30 To 85
                        value = Getcoins(5, 4, 100)
                        pieces = GP
                    Case 86 To 100
                        value = Getcoins(2, 12, 10)
                        pieces = PP
                End Select
            Case 10
                Select Case roll
                    Case 1 To 10
                        value = 0
                        pieces = 0
                    Case 11 To 24
                        value = Getcoins(2, 10, 1000)
                        pieces = SP
                    Case 25 To 79
                        value = Getcoins(6, 4, 100)
                        pieces = GP
                    Case 80 To 100
                        value = Getcoins(5, 6, 10)
                        pieces = PP
                End Select
            Case 11
                Select Case roll
                    Case 1 To 8
                        value = 0
                        pieces = 0
                    Case 9 To 14
                        value = Getcoins(3, 10, 1000)
                        pieces = SP
                    Case 15 To 75
                        value = Getcoins(4, 8, 1000)
                        pieces = GP
                    Case 76 To 100
                        value = Getcoins(4, 10, 10)
                        pieces = PP
                End Select
            Case 12
                Select Case roll
                    Case 1 To 8
                        value = 0
                        pieces = 0
                    Case 9 To 14
                        value = Getcoins(3, 12, 1000)
                        pieces = SP
                    Case 15 To 75
                        value = Getcoins(4, 1000)
                        pieces = GP
                    Case 76 To 100
                        value = Getcoins(4, 100)
                        pieces = PP
                End Select
            Case 13
                Select Case roll
                    Case 1 To 8
                        value = 0
                        pieces = 0
                    Case 9 To 75
                        value = Getcoins(4, 1000)
                        pieces = GP
                    Case 76 To 100
                        value = Getcoins(10, 100)
                        pieces = PP
                End Select
            Case 14
                Select Case roll
                    Case 1 To 8
                        value = 0
                        pieces = 0
                    Case 9 To 75
                        value = Getcoins(6, 1000)
                        pieces = GP
                    Case 76 To 100
                        value = Getcoins(12, 100)
                        pieces = PP
                End Select
            Case 15
                Select Case roll
                    Case 1 To 3
                        value = 0
                        pieces = 0
                    Case 4 To 74
                        value = Getcoins(8, 1000)
                        pieces = GP
                    Case 75 To 100
                        value = Getcoins(3, 4, 100)
                        pieces = PP
                End Select
            Case 16
                Select Case roll
                    Case 1 To 3
                        value = 0
                        pieces = 0
                    Case 4 To 74
                        value = Getcoins(12, 1000)
                        pieces = GP
                    Case 75 To 100
                        value = Getcoins(3, 4, 100)
                        pieces = PP
                End Select
            Case 17
                Select Case roll
                    Case 1 To 3
                        value = 0
                        pieces = 0
                    Case 4 To 68
                        value = Getcoins(3, 4, 1000)
                        pieces = GP
                    Case 69 To 100
                        value = Getcoins(2, 10, 100)
                        pieces = PP
                End Select
            Case 18
                Select Case roll
                    Case 1 To 2
                        value = 0
                        pieces = 0
                    Case 3 To 65
                        value = Getcoins(3, 6, 1000)
                        pieces = GP
                    Case 66 To 100
                        value = Getcoins(5, 4, 100)
                        pieces = PP
                End Select
            Case 19
                Select Case roll
                    Case 1 To 2
                        value = 0
                        pieces = 0
                    Case 3 To 65
                        value = Getcoins(3, 8, 1000)
                        pieces = GP
                    Case 66 To 199
                        value = Getcoins(3, 10, 100)
                        pieces = PP
                End Select
            Case 20
                Select Case roll
                    Case 1 To 2
                        value = 0
                        pieces = 0
                    Case 3 To 65
                        value = Getcoins(4, 8, 1000)
                        pieces = GP
                    Case 66 To 100
                        value = Getcoins(4, 10, 100)
                        pieces = PP
                End Select
            Case Else
                value = 0
        End Select

        If value > 0 Then
            value = CInt(value * percentage)
            total = CStr(value) & " "
            Select Case pieces
                Case CP
                    total &= "cp"
                Case SP
                    total &= "sp"
                Case GP
                    total &= "gp"
                Case PP
                    total &= "pp"
                Case Else
                    total &= "bones"
            End Select
            Return total
        End If
        Return "No Coins"
    End Function
    Public Function GetCoins(ByVal dicesides As Integer, ByVal nummult As Integer) As Integer
        Return GetCoins(1, dicesides, nummult)
    End Function
    Public Function GetCoins(ByVal dicenum As Integer, ByVal dicesides As Integer, ByVal nummult As Integer) As Integer
        If djCoinTweak = True Then
            Return Roll(dicenum * nummult, dicesides)
        Else
            Return (Roll(dicenum, dicesides) * nummult)
        End If
    End Function
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '"'                                                           '"'
    '"'                   End of Coin Functions                   '"'
    '"'                                                           '"'
    '"'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"'
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Module
