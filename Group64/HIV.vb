Public Class HIV : Inherits Disease

    Private _noPeopleBornPositive() As Integer
    Private _noPeopleOnPrep() As Integer
    Private _noPeopleUndetectable() As Integer


    Public Overrides Function Alarm() As String
        Throw New NotImplementedException()
    End Function
End Class
