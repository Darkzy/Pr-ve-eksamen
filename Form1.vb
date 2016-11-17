Public Class frmLogin
    Public EndrePassord As New frmEndrePassord()
#Region "Avslutt og Ok kanpp"
    Private Sub cmdAvslutt_Click(sender As Object, e As EventArgs) Handles cmdAvslutt.Click
        If MessageBox.Show("Ønsker du å avslutte?", "Forespørsel",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click

        If txtBox1.Text = Brukernavn1 And txtBox2.Text = Passord1 Then
            MsgBox("Du er nå logget på", MsgBoxStyle.OkOnly +
            MsgBoxStyle.Information, "Login")
            txtBox1.Text = ""
            txtBox2.Text = ""
        Else
            MsgBox("Feil brukernavn eller passord, prøv igjen", MsgBoxStyle.OkOnly +
            MsgBoxStyle.Critical, "Login")
            txtBox1.Text = ""
            txtBox2.Text = ""
            txtBox1.Focus()
        End If
    End Sub

#End Region

#Region "Tool strip"
    Private Sub EndrePassordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndrePassordToolStripMenuItem.Click
        If EndrePassord.ShowDialog() Then
        End If
    End Sub

    Private Sub toolstripHjelp_Click(sender As Object, e As EventArgs) Handles toolstripHjelp.Click
        If MessageBox.Show("Skriv inn Brukernavn og passord i tekst feltene") _
           = DialogResult.OK Then
        End If
    End Sub

    Private Sub toolstripOm_Click(sender As Object, e As EventArgs) Handles toolstripOm.Click
        If MessageBox.Show("You found the hidden easter egg :^)") _
            = DialogResult.OK Then
        End If
    End Sub

    Private Sub RegistrerBrukerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrerBrukerToolStripMenuItem.Click
        frmNyBruker.ShowDialog()
    End Sub

#End Region

#Region "Users"
    Private Sub frmpassord_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Brukernavn1 = "Haugaland"
        Passord1 = "Test"

    End Sub


#End Region
End Class