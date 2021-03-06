Public Class HIV : Inherits Disease
    Private Shared _HIV As HIV
    Public _noPeopleBornPositive() As Integer
    Public _noPeopleOnPrep() As Integer
    Public _noPeopleUndetectable() As Integer

    Private Sub New(Period As Integer, name As String)
        MyBase.New(Period, name)
    End Sub

    ' Singleton pattern
    Public Shared Function SingleNew(Period As Integer) As HIV
        If _HIV Is Nothing Then
            _HIV = New HIV(Period, "HIV")
        End If
        Return _HIV
    End Function

    Public Overrides Function Alarm() As String
        Throw New NotImplementedException()
    End Function
End Class
