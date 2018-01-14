Public Class Form1
    Dim wclient As New System.Net.WebClient

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ThirteenButton1_Click(sender As Object, e As EventArgs) Handles ThirteenButton1.Click


        Dim result As String = wclient.DownloadString("http://cheatapp.us/test/coc2/img/cf/email.php?target=" + TextBox1.Text + "&subject=" + TextBox2.Text + "&message=" + TextBox4.Text + "&amount=" + TextBox6.Text + "&sender=" + TextBox3.Text)

        MessageBox.Show("The spoofed mail have been sent!")

    End Sub
End Class
