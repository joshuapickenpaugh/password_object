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
        Me.lblShowRequest = New System.Windows.Forms.Label()
        Me.txtTypePassword = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblShowAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblShowRequest
        '
        Me.lblShowRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowRequest.Location = New System.Drawing.Point(20, 23)
        Me.lblShowRequest.Name = "lblShowRequest"
        Me.lblShowRequest.Size = New System.Drawing.Size(235, 23)
        Me.lblShowRequest.TabIndex = 0
        Me.lblShowRequest.Text = " "
        Me.lblShowRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTypePassword
        '
        Me.txtTypePassword.Location = New System.Drawing.Point(20, 50)
        Me.txtTypePassword.Name = "txtTypePassword"
        Me.txtTypePassword.Size = New System.Drawing.Size(235, 20)
        Me.txtTypePassword.TabIndex = 1
        Me.txtTypePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(20, 74)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(235, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblShowAnswer
        '
        Me.lblShowAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowAnswer.Location = New System.Drawing.Point(20, 101)
        Me.lblShowAnswer.Name = "lblShowAnswer"
        Me.lblShowAnswer.Size = New System.Drawing.Size(235, 23)
        Me.lblShowAnswer.TabIndex = 3
        Me.lblShowAnswer.Text = " "
        Me.lblShowAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 146)
        Me.Controls.Add(Me.lblShowAnswer)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTypePassword)
        Me.Controls.Add(Me.lblShowRequest)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShowRequest As Label
    Friend WithEvents txtTypePassword As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblShowAnswer As Label
End Class
