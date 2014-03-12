<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnGuess = New System.Windows.Forms.Button
        Me.btnGiveUp = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblGuess = New System.Windows.Forms.Label
        Me.txtGuess = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(167, 12)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 2
        Me.btnGuess.Text = "&Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnGiveUp
        '
        Me.btnGiveUp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGiveUp.Location = New System.Drawing.Point(167, 41)
        Me.btnGiveUp.Name = "btnGiveUp"
        Me.btnGiveUp.Size = New System.Drawing.Size(75, 23)
        Me.btnGiveUp.TabIndex = 3
        Me.btnGiveUp.Text = "Give &up"
        Me.btnGiveUp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(167, 70)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Location = New System.Drawing.Point(22, 22)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(89, 13)
        Me.lblGuess.TabIndex = 0
        Me.lblGuess.Text = "&Enter your guess:"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(16, 61)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtGuess.TabIndex = 1
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnGuess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnGiveUp
        Me.ClientSize = New System.Drawing.Size(261, 103)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGiveUp)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents btnGiveUp As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblGuess As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox

End Class
