Public Class Form1
    Private Sub chkCalendar_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalendar.CheckedChanged
        If chkCalendar.Checked Then
            MonthCalendar1.Visible = True
        Else
            MonthCalendar1.Visible = False
        End If
    End Sub
End Class
