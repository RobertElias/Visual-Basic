Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim path = IO.Path.GetFileName(PictureBox1.ImageLocation)
        MessageBox.Show(path, "Picture", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
