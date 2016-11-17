Public Class frmEndrePassord

#Region "Ok Knapp"
    Private Sub cmdOK2_Click(sender As Object, e As EventArgs) Handles cmdOk2.Click
        If txtBox4.Text = Passord1 Then
            Passord1 = txtBox3.Text
            If txtBox3.Text = "" Then
                If MessageBox.Show("Skriv inn et nytt passord", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error) _
                = DialogResult.Yes Then
                    Hide()
                End If
            Else
                Hide()
            End If
        Else
            If MessageBox.Show("Nåværende passord feil", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error) _
            = DialogResult.OK Then
            End If
        End If
        txtBox3.Text = ""
        txtBox4.Text = ""
    End Sub

#End Region

#Region "Angre Knapp"
    Private Sub cmdAngre_Click(sender As Object, e As EventArgs) Handles cmdAngre.Click
        If MessageBox.Show("Ønsker du å angre?", "Forespørsel",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then
            Hide()
        End If
    End Sub
#End Region

    Private Sub frmEndrePassord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
