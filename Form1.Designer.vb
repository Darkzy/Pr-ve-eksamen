<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolstripOppsett = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndrePassordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrerBrukerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripHjelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripOm = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdAvslutt = New System.Windows.Forms.Button()
        Me.lblNavn = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripOppsett, Me.toolstripHjelp, Me.toolstripOm})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(340, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolstripOppsett
        '
        Me.toolstripOppsett.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndrePassordToolStripMenuItem, Me.RegistrerBrukerToolStripMenuItem})
        Me.toolstripOppsett.Name = "toolstripOppsett"
        Me.toolstripOppsett.Size = New System.Drawing.Size(61, 20)
        Me.toolstripOppsett.Text = "Oppsett"
        '
        'EndrePassordToolStripMenuItem
        '
        Me.EndrePassordToolStripMenuItem.Name = "EndrePassordToolStripMenuItem"
        Me.EndrePassordToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EndrePassordToolStripMenuItem.Text = "Endre passord"
        '
        'RegistrerBrukerToolStripMenuItem
        '
        Me.RegistrerBrukerToolStripMenuItem.Name = "RegistrerBrukerToolStripMenuItem"
        Me.RegistrerBrukerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RegistrerBrukerToolStripMenuItem.Text = "Registrer bruker"
        '
        'toolstripHjelp
        '
        Me.toolstripHjelp.Name = "toolstripHjelp"
        Me.toolstripHjelp.Size = New System.Drawing.Size(47, 20)
        Me.toolstripHjelp.Text = "Hjelp"
        '
        'toolstripOm
        '
        Me.toolstripOm.ForeColor = System.Drawing.Color.Transparent
        Me.toolstripOm.Name = "toolstripOm"
        Me.toolstripOm.Size = New System.Drawing.Size(39, 20)
        Me.toolstripOm.Text = "Om"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(233, 46)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAvslutt
        '
        Me.cmdAvslutt.Location = New System.Drawing.Point(233, 84)
        Me.cmdAvslutt.Name = "cmdAvslutt"
        Me.cmdAvslutt.Size = New System.Drawing.Size(75, 23)
        Me.cmdAvslutt.TabIndex = 2
        Me.cmdAvslutt.Text = "Avslutt"
        Me.cmdAvslutt.UseVisualStyleBackColor = True
        '
        'lblNavn
        '
        Me.lblNavn.AutoSize = True
        Me.lblNavn.Location = New System.Drawing.Point(19, 55)
        Me.lblNavn.Name = "lblNavn"
        Me.lblNavn.Size = New System.Drawing.Size(62, 13)
        Me.lblNavn.TabIndex = 3
        Me.lblNavn.Text = "Brukernavn"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(19, 93)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 4
        Me.lblPassord.Text = "Passord"
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(97, 86)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBox2.Size = New System.Drawing.Size(100, 20)
        Me.txtBox2.TabIndex = 5
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(97, 48)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(100, 20)
        Me.txtBox1.TabIndex = 6
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 137)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.lblNavn)
        Me.Controls.Add(Me.cmdAvslutt)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents toolstripOppsett As ToolStripMenuItem
    Friend WithEvents EndrePassordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolstripHjelp As ToolStripMenuItem
    Friend WithEvents toolstripOm As ToolStripMenuItem
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdAvslutt As Button
    Friend WithEvents lblNavn As Label
    Friend WithEvents lblPassord As Label
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents RegistrerBrukerToolStripMenuItem As ToolStripMenuItem
End Class
