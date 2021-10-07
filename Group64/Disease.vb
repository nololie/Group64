Public MustInherit Class Disease
    Public _noWeeks As Integer ' This will help us resize all our arrays
    Public _Name As String ' Identity reasons
    Public _noPepleInfected() As Integer ' This will store the recorded infections each week
    Public _CanRecover As Boolean ' This lets us know if a one can recover from a desease or not
    Public _Treatment() As String ' This stores the names of treatment options available for the disease
    Public _noPeopleOnTreatment() As Integer ' This stores the number Of people who started treatment each week
    Public _PreventionMeasures() As String ' This stores all known preventive measures for the disease
    Public _DiagnosticMethods() As String ' This stores all known Diagnostic methods available for the disease
    Public _noPeopleDied() As Integer ' This stores the number of people who died from the disease


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
    Public Function DetermineTrend() As String

    End Function

End Class
