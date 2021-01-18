Module ChartKeywords
    Public Function GetAlignmentDMG() As String
        Return GetChart("DMGAlignments.txt", False).name
    End Function
    Public Function GetEnergyType() As String
        Return GetChart("DMGEnergy.txt", False).name
    End Function
    Public Function GetOilPotion() As String
        Dim myroll As Integer = d2()
        If myroll = 1 Then
            Return "Potion"
        Else
            Return "Oil"
        End If
    End Function
    Public Function GetBaneCreatureType() As String
        Return GetChart("DMGBaneCreatureType.txt").name
    End Function
End Module
