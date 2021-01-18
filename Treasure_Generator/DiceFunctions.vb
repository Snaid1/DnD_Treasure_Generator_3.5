Module DiceFunctions
    Private Rand As New Random()
    Public Function Roll(ByVal num As Integer) As Integer
        Randomize()
        Return Rand.Next(1, num + 1)
    End Function

    Public Function Roll(ByVal numdice As Integer, ByVal numsides As Integer) As Integer
        Dim total As Integer
        Dim x As Integer
        total = 0
        For x = 1 To numdice
            total += Roll(numsides)
        Next
        Return total
    End Function

    Public Function d100() As Integer
        Return Roll(100)
    End Function
    Public Function d20() As Integer
        Return Roll(20)
    End Function
    Public Function d12() As Integer
        Return Roll(12)
    End Function
    Public Function d10() As Integer
        Return Roll(10)
    End Function
    Public Function d8() As Integer
        Return Roll(8)
    End Function
    Public Function d6() As Integer
        Return Roll(6)
    End Function
    Public Function d4() As Integer
        Return Roll(4)
    End Function
    Public Function d3() As Integer
        Return Roll(3)
    End Function
    Public Function d2() As Integer
        Return Roll(2)
    End Function
    Public Function d100(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 100)
    End Function
    Public Function d20(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 20)
    End Function
    Public Function d12(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 12)
    End Function
    Public Function d10(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 10)
    End Function
    Public Function d8(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 8)
    End Function
    Public Function d6(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 6)
    End Function
    Public Function d4(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 4)
    End Function
    Public Function d3(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 3)
    End Function
    Public Function d2(ByVal numdice As Integer) As Integer
        Return Roll(numdice, 2)
    End Function

End Module
