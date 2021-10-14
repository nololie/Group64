<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeseaseManagementTracker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInitialize = New System.Windows.Forms.Button()
        Me.btnAddDisease = New System.Windows.Forms.Button()
        Me.btnUpdateDisease = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInitialize
        '
        Me.btnInitialize.Location = New System.Drawing.Point(12, 12)
        Me.btnInitialize.Name = "btnInitialize"
        Me.btnInitialize.Size = New System.Drawing.Size(120, 34)
        Me.btnInitialize.TabIndex = 0
        Me.btnInitialize.Text = "Initialize program"
        Me.btnInitialize.UseVisualStyleBackColor = True
        '
        'btnAddDisease
        '
        Me.btnAddDisease.Location = New System.Drawing.Point(138, 12)
        Me.btnAddDisease.Name = "btnAddDisease"
        Me.btnAddDisease.Size = New System.Drawing.Size(120, 34)
        Me.btnAddDisease.TabIndex = 1
        Me.btnAddDisease.Text = "Add Disease"
        Me.btnAddDisease.UseVisualStyleBackColor = True
        '
        'btnUpdateDisease
        '
        Me.btnUpdateDisease.Location = New System.Drawing.Point(264, 12)
        Me.btnUpdateDisease.Name = "btnUpdateDisease"
        Me.btnUpdateDisease.Size = New System.Drawing.Size(120, 34)
        Me.btnUpdateDisease.TabIndex = 2
        Me.btnUpdateDisease.Text = "Update Disease"
        Me.btnUpdateDisease.UseVisualStyleBackColor = True
        '
        'frmDeseaseManagementTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 161)
        Me.Controls.Add(Me.btnUpdateDisease)
        Me.Controls.Add(Me.btnAddDisease)
        Me.Controls.Add(Me.btnInitialize)
        Me.Name = "frmDeseaseManagementTracker"
        Me.Text = "Disease Management Tracker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInitialize As Button
    Friend WithEvents btnAddDisease As Button
    Friend WithEvents btnUpdateDisease As Button
End Class
