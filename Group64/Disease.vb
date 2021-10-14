Public Class Disease
    Public _Name As String ' Identity reasons
    Public _noNewInfections() As Integer ' This will store the recorded infections each week
    Public _noPeopleOnTreatment() As Integer ' This stores the number Of people who started treatment each week
    Public _noPeopleDied() As Integer ' This stores the number of people who died from the disease

    Public Sub New(Period As Integer, name As String)
        _Name = name

        ReDim _noNewInfections(Period)
        ReDim _noPeopleOnTreatment(Period)
        ReDim _noPeopleDied(Period)
    End Sub

    Public Overridable Function Alarm() As String
    End Function
    Public Function DetermineTrend(array() As Integer) As String

    End Function


    Public Function CalPeepNotTreated() As Integer

    End Function
    Public Function CalcIndex() As Integer

    End Function
    Public Function CalcPerformance() As String

    End Function
    Public Function Display() As String

    End Function
    Public Sub CompileReport()

    End Sub

End Class
