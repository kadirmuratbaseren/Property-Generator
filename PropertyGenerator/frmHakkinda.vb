Public Class frmHakkinda

    Private Sub frmHakkinda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub frmHakkinda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = "FreewareSoft by K.Murat BA�EREN" & vbCrLf & vbCrLf & "Property Generator v1.0.0" & vbCrLf & "T�m haklar� sakl�d�r.."
    End Sub
End Class