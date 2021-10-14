Option Strict On
Option Explicit On
Option Infer Off
' *****************************************************************
' Team Number: 64
' Team Member 1 Details: Lefatle, LL (217007690)
' Team Member 2 Details: Surname, Initials (Student #)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: (frmDeseaseManagementTracker)
' *****************************************************************
Public Class frmDeseaseManagementTracker
    Dim PeriodLength As Integer
    Dim Diseases(0) As Disease

    Private Sub btnInitialize_Click(sender As Object, e As EventArgs) Handles btnInitialize.Click
        'Input(Action)
        PeriodLength = CInt(InputBox("Enter the period length of tracking"))
        'Reaction
    End Sub

    Private Sub btnAddDisease_Click(sender As Object, e As EventArgs) Handles btnAddDisease.Click
        Dim newDiseaseSize As Integer = Diseases.Length + 1
        ReDim Preserve Diseases(newDiseaseSize)

        Dim DiseaseType As String = InputBox("H = HIV,     O = Other")

        If DiseaseType = "O" Or DiseaseType = "o" Then
            For i As Integer = 0 To Diseases.Length - 1

            Next
            Diseases(Diseases.Length - 1) = New Disease(PeriodLength, "Malaria")
        ElseIf DiseaseType = "H" Or DiseaseType = "h" Then
            Diseases(Diseases.Length - 1) = HIV.SingleNew(PeriodLength, "HIV")
        End If

    End Sub
End Class
