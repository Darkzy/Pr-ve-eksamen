Public Class frmNyBruker
#Region "Avbryt og Visk knapp"
    Private Sub cmdnyAvbryt_Click(sender As Object, e As EventArgs) Handles cmdnyAvbryt.Click
        If MessageBox.Show("Avbryte bruker registrering?", "Forespørsel",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then
            Hide()
        End If
    End Sub

    Private Sub cmdNyClear_Click(sender As Object, e As EventArgs) Handles cmdNyClear.Click
        txtBoxNy1.Text = ""
        txtBoxNy2.Text = ""
        txtBoxNy3.Text = ""
    End Sub

#End Region

#Region "Registrer knapp"
    Private Sub cmdNyRegistrer_Click(sender As Object, e As EventArgs) Handles cmdNyRegistrer.Click

    End Sub
#End Region
End Class