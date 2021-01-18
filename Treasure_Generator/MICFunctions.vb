Module MICFunctions
    Public Structure MICcoins
        Public value As Integer
        Public valuetype As Integer
        Public Function Display() As String
            Dim tempstr As String
            If value > 0 Then
                tempstr = CStr(value) & " "
                Select Case valuetype
                    Case CP
                        tempstr &= "cp"
                    Case SP
                        tempstr &= "sp"
                    Case GP
                        tempstr &= "gp"
                    Case PP
                        tempstr &= "pp"
                End Select
            Else
                tempstr = "No Coins"
            End If
            Return tempstr
        End Function
    End Structure
    Public Function CMICcoins(ByVal value As Integer, ByVal valuetype As Integer) As MICcoins
        Dim tempcoins As MICcoins
        tempcoins.value = value
        tempcoins.valuetype = valuetype
        Return tempcoins
    End Function
    Public Sub GetMICTreasure()

    End Sub
    Public Function GetCoinsMIC(ByVal numdice As Integer, ByVal numsides As Integer, ByVal multiple As Integer, ByVal cointype As Integer, ByVal coinlevel As Decimal) As MICcoins
        Dim tempcoins As New MICcoins
        Dim tempint As Integer = coinlevel
        If tempint < 1 Then
            tempint = 1
        End If
        If coinlevel = NONE Then

        End If
        If coinlevel >= 1 Then
            For x = 1 To tempint
                If djCoinTweak Then
                    For y = 1 To multiple
                        tempcoins.value += Roll(numdice, numsides)
                    Next
                Else
                    tempcoins.value += Roll(numdice, numsides) * multiple
                End If
            Next
        End If
        If coinlevel < 1 Then
            tempcoins.value = tempcoins.value * coinlevel
        End If
        tempcoins.valuetype = cointype
        Return tempcoins
    End Function
    Public Function GetGoodsValue(ByVal numdice As Integer, ByVal numsides As Integer, ByVal multiple As Integer) As Integer
        Return GetCoinsMIC(numdice, numsides, multiple, GP, 1).value
    End Function
    Public Function getGoodsMICa() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsA.txt", False)
        tempitem.value = d4(4)
        Return tempitem
    End Function
    Public Function getGoodsMICb() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsB.txt", False)
        tempitem.value = GetGoodsValue(2, 4, 10)
        Return tempitem
    End Function
    Public Function getGoodsMICc() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsC.txt", False)
        tempitem.value = GetGoodsValue(4, 4, 10)
        Return tempitem
    End Function
    Public Function getGoodsMICd() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsD.txt", False)
        tempitem.value = GetGoodsValue(1, 4, 100)
        Return tempitem
    End Function
    Public Function getGoodsMICe() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsE.txt", False)
        tempitem.value = GetGoodsValue(2, 4, 100)
        Return tempitem
    End Function
    Public Function getGoodsMICf() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsF.txt", False)
        tempitem.value = GetGoodsValue(4, 4, 100)
        Return tempitem
    End Function
    Public Function getGoodsMICg() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsG.txt", False)
        tempitem.value = GetGoodsValue(1, 4, 1000)
        Return tempitem
    End Function
    Public Function getGoodsMICh() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsH.txt", False)
        tempitem.value = GetGoodsValue(2, 4, 1000)
        Return tempitem
    End Function
    Public Function getGoodsMICi() As NewItem
        Dim tempitem As NewItem
        tempitem = GetChart("MICGoodsI.txt", False)
        tempitem.value = GetGoodsValue(4, 4, 1000)
        Return tempitem
    End Function
End Module
