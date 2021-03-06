Option Strict On
Option Explicit On
Option Infer Off
' *****************************************************************
' Team Number: 64
' Team Member 1 Details: Lefatle, LL (217007690)
' Team Member 2 Details: Komane, KM (219018736)
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
        MsgBox("Successfully Initialised application")
    End Sub

    Private Sub btnAddDisease_Click(sender As Object, e As EventArgs) Handles btnAddDisease.Click
        Dim newDiseaseSize As Integer = Diseases.Length + 1
        ReDim Preserve Diseases(newDiseaseSize)

        Dim DiseaseType As String = InputBox("H = HIV,     O = Other")

        If DiseaseType = "O" Or DiseaseType = "o" Then
            Dim Name As String = InputBox("Please enter Desease Name")
            For i As Integer = 0 To Diseases.Length - 1
                If Diseases(i)._Name = Name Then
                    i = Diseases.Length
                    MsgBox("Disease already exists")
                ElseIf i = Diseases.Length - 1 And Diseases(i)._Name <> Name Then
                    Diseases(Diseases.Length - 1) = New Disease(PeriodLength, Name)
                    MsgBox("Disease successfully added")
                End If
            Next
        ElseIf DiseaseType = "H" Or DiseaseType = "h" Then
            For i As Integer = 0 To Diseases.Length - 1
                If Diseases(i)._Name = "HIV" Then
                    i = Diseases.Length
                    MsgBox("Disease already exists")
                ElseIf i = Diseases.Length - 1 And Diseases(i)._Name <> "HIV" Then
                    Diseases(Diseases.Length - 1) = HIV.SingleNew(PeriodLength)
                    MsgBox("Disease successfully added")
                End If
            Next
        End If

    End Sub

    Private Sub btnUpdateDisease_Click(sender As Object, e As EventArgs) Handles btnUpdateDisease.Click
        Dim Name As String = InputBox("Enter the name of the desease to update.")

        For i As Integer = 0 To Diseases.Length - 1
            If Diseases(i)._Name = Name Then
                For j As Integer = 0 To Diseases(i)._noNewInfections.Length - 1
                    If Diseases(i)._noNewInfections(j) = Nothing Then
                        Diseases(i)._noNewInfections(j) = CInt(InputBox("Enter the number of new infections recorded on this period"))
                        Diseases(i)._noPeopleDied(j) = CInt(InputBox("Enter the number of new deaths recorded on this period"))
                        Diseases(i)._noPeopleOnTreatment(j) = CInt(InputBox("Enter the number of people on medication recorded on this period"))

                        If Diseases(i).GetType() Is "HIV" Then
                            'Diseases(i)._noPeopleBornPositive() = CInt(InputBox("Enter the number of new infections recorded on this period"))
                        End If
                    End If
                Next
            End If
        Next
    End Sub
End Class
