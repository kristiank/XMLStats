Imports System.Windows.Forms

Public Class frmDlgFindText

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If (tbFind.Text.Length = 0) Then
            Exit Sub
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmDlgFindText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbFind.SelectAll()
    End Sub
End Class
