<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndrePassord
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
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.cmdAngre = New System.Windows.Forms.Button()
        Me.cmdOk2 = New System.Windows.Forms.Button()
        Me.lblReset2 = New System.Windows.Forms.Label()
        Me.txtBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtBox3
        '
        Me.txtBox3.Location = New System.Drawing.Point(193, 71)
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBox3.Size = New System.Drawing.Size(100, 20)
        Me.txtBox3.TabIndex = 0
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Location = New System.Drawing.Point(12, 74)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(108, 13)
        Me.lblReset.TabIndex = 1
        Me.lblReset.Text = "Skriv inn nytt passord"
        '
        'cmdAngre
        '
        Me.cmdAngre.Location = New System.Drawing.Point(137, 111)
        Me.cmdAngre.Name = "cmdAngre"
        Me.cmdAngre.Size = New System.Drawing.Size(75, 23)
        Me.cmdAngre.TabIndex = 2
        Me.cmdAngre.Text = "Angre"
        Me.cmdAngre.UseVisualStyleBackColor = True
        '
        'cmdOk2
        '
        Me.cmdOk2.Location = New System.Drawing.Point(218, 111)
        Me.cmdOk2.Name = "cmdOk2"
        Me.cmdOk2.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk2.TabIndex = 3
        Me.cmdOk2.Text = "Ok"
        Me.cmdOk2.UseVisualStyleBackColor = True
        '
        'lblReset2
        '
        Me.lblReset2.AutoSize = True
        Me.lblReset2.Location = New System.Drawing.Point(12, 36)
        Me.lblReset2.Name = "lblReset2"
        Me.lblReset2.Size = New System.Drawing.Size(130, 13)
        Me.lblReset2.TabIndex = 4
        Me.lblReset2.Text = "Skriv inn gammelt passord"
        '
        'txtBox4
        '
        Me.txtBox4.Location = New System.Drawing.Point(193, 33)
        Me.txtBox4.Name = "txtBox4"
        Me.txtBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBox4.Size = New System.Drawing.Size(100, 20)
        Me.txtBox4.TabIndex = 5
        '
        'frmEndrePassord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 146)
        Me.Controls.Add(Me.txtBox4)
        Me.Controls.Add(Me.lblReset2)
        Me.Controls.Add(Me.cmdOk2)
        Me.Controls.Add(Me.cmdAngre)
        Me.Controls.Add(Me.lblReset)
        Me.Controls.Add(Me.txtBox3)
        Me.Name = "frmEndrePassord"
        Me.Text = "Endre Passord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox3 As TextBox
    Friend WithEvents lblReset As Label
    Friend WithEvents cmdAngre As Button
    Friend WithEvents cmdOk2 As Button
    Friend WithEvents lblReset2 As Label
    Friend WithEvents txtBox4 As TextBox
End Class
