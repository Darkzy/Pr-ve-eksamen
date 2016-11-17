<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyBruker
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
        Me.lblNyBruker1 = New System.Windows.Forms.Label()
        Me.lblNyBruker2 = New System.Windows.Forms.Label()
        Me.lblNyBruker3 = New System.Windows.Forms.Label()
        Me.txtBoxNy1 = New System.Windows.Forms.TextBox()
        Me.txtBoxNy2 = New System.Windows.Forms.TextBox()
        Me.txtBoxNy3 = New System.Windows.Forms.TextBox()
        Me.cmdnyAvbryt = New System.Windows.Forms.Button()
        Me.cmdNyRegistrer = New System.Windows.Forms.Button()
        Me.cmdNyClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNyBruker1
        '
        Me.lblNyBruker1.AutoSize = True
        Me.lblNyBruker1.Location = New System.Drawing.Point(36, 42)
        Me.lblNyBruker1.Name = "lblNyBruker1"
        Me.lblNyBruker1.Size = New System.Drawing.Size(62, 13)
        Me.lblNyBruker1.TabIndex = 0
        Me.lblNyBruker1.Text = "Brukernavn"
        '
        'lblNyBruker2
        '
        Me.lblNyBruker2.AutoSize = True
        Me.lblNyBruker2.Location = New System.Drawing.Point(36, 79)
        Me.lblNyBruker2.Name = "lblNyBruker2"
        Me.lblNyBruker2.Size = New System.Drawing.Size(45, 13)
        Me.lblNyBruker2.TabIndex = 1
        Me.lblNyBruker2.Text = "Passord"
        '
        'lblNyBruker3
        '
        Me.lblNyBruker3.AutoSize = True
        Me.lblNyBruker3.Location = New System.Drawing.Point(36, 114)
        Me.lblNyBruker3.Name = "lblNyBruker3"
        Me.lblNyBruker3.Size = New System.Drawing.Size(79, 13)
        Me.lblNyBruker3.TabIndex = 2
        Me.lblNyBruker3.Text = "Gjenta Passord"
        '
        'txtBoxNy1
        '
        Me.txtBoxNy1.Location = New System.Drawing.Point(124, 39)
        Me.txtBoxNy1.Name = "txtBoxNy1"
        Me.txtBoxNy1.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNy1.TabIndex = 4
        '
        'txtBoxNy2
        '
        Me.txtBoxNy2.Location = New System.Drawing.Point(124, 79)
        Me.txtBoxNy2.Name = "txtBoxNy2"
        Me.txtBoxNy2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxNy2.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNy2.TabIndex = 5
        '
        'txtBoxNy3
        '
        Me.txtBoxNy3.Location = New System.Drawing.Point(124, 114)
        Me.txtBoxNy3.Name = "txtBoxNy3"
        Me.txtBoxNy3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxNy3.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNy3.TabIndex = 6
        '
        'cmdnyAvbryt
        '
        Me.cmdnyAvbryt.Location = New System.Drawing.Point(12, 156)
        Me.cmdnyAvbryt.Name = "cmdnyAvbryt"
        Me.cmdnyAvbryt.Size = New System.Drawing.Size(75, 23)
        Me.cmdnyAvbryt.TabIndex = 8
        Me.cmdnyAvbryt.Text = "Avbryt"
        Me.cmdnyAvbryt.UseVisualStyleBackColor = True
        '
        'cmdNyRegistrer
        '
        Me.cmdNyRegistrer.Location = New System.Drawing.Point(175, 156)
        Me.cmdNyRegistrer.Name = "cmdNyRegistrer"
        Me.cmdNyRegistrer.Size = New System.Drawing.Size(75, 23)
        Me.cmdNyRegistrer.TabIndex = 9
        Me.cmdNyRegistrer.Text = "Registrer"
        Me.cmdNyRegistrer.UseVisualStyleBackColor = True
        '
        'cmdNyClear
        '
        Me.cmdNyClear.Location = New System.Drawing.Point(94, 156)
        Me.cmdNyClear.Name = "cmdNyClear"
        Me.cmdNyClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdNyClear.TabIndex = 10
        Me.cmdNyClear.Text = "Visk"
        Me.cmdNyClear.UseVisualStyleBackColor = True
        '
        'frmNyBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 193)
        Me.Controls.Add(Me.cmdNyClear)
        Me.Controls.Add(Me.cmdNyRegistrer)
        Me.Controls.Add(Me.cmdnyAvbryt)
        Me.Controls.Add(Me.txtBoxNy3)
        Me.Controls.Add(Me.txtBoxNy2)
        Me.Controls.Add(Me.txtBoxNy1)
        Me.Controls.Add(Me.lblNyBruker3)
        Me.Controls.Add(Me.lblNyBruker2)
        Me.Controls.Add(Me.lblNyBruker1)
        Me.Name = "frmNyBruker"
        Me.Text = "NyBruker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNyBruker1 As Label
    Friend WithEvents lblNyBruker2 As Label
    Friend WithEvents lblNyBruker3 As Label
    Friend WithEvents txtBoxNy1 As TextBox
    Friend WithEvents txtBoxNy2 As TextBox
    Friend WithEvents txtBoxNy3 As TextBox
    Friend WithEvents cmdnyAvbryt As Button
    Friend WithEvents cmdNyRegistrer As Button
    Friend WithEvents cmdNyClear As Button
End Class
