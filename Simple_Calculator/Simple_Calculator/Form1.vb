Public Class Form1
    Private Sub btnSummarize_Click(sender As Object, e As EventArgs) Handles btnSummarize.Click
        Dim leftValue = Double.Parse(txtLeftValue.Text)
        Dim RightValue = Double.Parse(txtRightValue.Text)
        Dim sum = leftValue + RightValue
        lblSummary.Text = $"Sum: {sum}" + vbCr + $"Average: {sum / 2}"
        'Avarage = sum / 2
    End Sub
End Class
