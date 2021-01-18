Module ChartReader
    Public Structure Chartline
        Dim minnum As Integer
        Dim maxnum As Integer
        Dim name As String
        Dim value As Integer
        Dim flag As Integer
    End Structure
    Public Class NewItem
        Public name As String
        Public value As Integer
        Public flag As Integer
        Public Overridable Function Display() As String
            Return name & " (" & CStr(value) & " gp)"
        End Function
        Public Overridable Sub Copy(ByVal item As NewItem)
            name = item.name
            value = item.value
            flag = item.flag
        End Sub
    End Class

    'Convert to NewItem Functions
    Public Function CNewItem(ByVal name As String, ByVal value As Integer, Optional ByVal flag As Integer = 0) As NewItem
        Dim item As New NewItem
        item.name = name
        item.value = value
        item.flag = flag
        Return item
    End Function
    Public Function CNewItem(ByVal line As Chartline) As NewItem
        Return CNewItem(line.name, line.value, line.flag)
    End Function
    Public Function CChartline(ByVal item As NewItem) As Chartline
        Dim templine As New Chartline
        templine.name = item.name
        templine.value = item.value
        Return templine
    End Function

    Public Function ReadChartLine(ByRef streamread As System.IO.StreamReader) As Chartline
        Dim entry As Chartline
        Dim line As String() = Split(streamread.ReadLine(), "|")
        entry.minnum = Int(line(0))
        entry.maxnum = Int(line(1))
        entry.name = KeywordReplace(line(2))
        entry.value = line(3)
        If line.Length = 5 Then
            entry.flag = line(4)
        Else
            entry.flag = 0
        End If
        Return entry
    End Function

    Public Function ReadChart(ByVal filename As String) As Chartline()
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("Charts\" & filename)
        Dim numlines As Integer = Int(fileReader.ReadLine())
        Dim chart(numlines) As Chartline
        For x = 1 To numlines
            chart(x) = ReadChartLine(fileReader)
        Next
        fileReader.Close()
        Return chart
    End Function

    Public Function GetChart(ByVal file As String, Optional ByVal cien As Boolean = True) As NewItem
        Dim chart() As Chartline = ReadChart(file)
        Dim templine As Chartline
        Dim item As New NewItem
        Dim score As Integer
        item.name = "Nada Nada(you got an error!)"
        If cien = True Then
            score = d100()
        Else
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("Charts\" & file)
            score = Roll(Int(fileReader.ReadLine()))
            fileReader.Close()
        End If

        For Each templine In chart
            If score <= templine.maxnum And score >= templine.minnum Then
                item = CNewItem(templine)
            End If
        Next

        If item.name = "Nada Nada(you got an error!)" Then
            MessageBox.Show("Break the code! something didn't read right!")
        End If

        Return item
    End Function

    Public Function GetNameChart(ByVal file As String) As String
        Return GetChart(file, False).name
    End Function

    Public Function KeywordReplace(ByVal tempstr As String)
        If tempstr.Contains("<Alignment>") Then
            tempstr = Replace(tempstr, "<Alignment>", GetAlignmentDMG())
        End If
        If tempstr.Contains("<Energy>") Then
            tempstr = Replace(tempstr, "<Energy>", GetEnergyType())
        End If
        If tempstr.Contains("<Creature>") Then
            tempstr = Replace(tempstr, "<Creature>", GetBaneCreatureType())
        End If
        If tempstr.Contains("<OilPotion>") Then
            tempstr = Replace(tempstr, "<OilPotion>", GetOilPotion())
        End If
        Return tempstr
    End Function

End Module
