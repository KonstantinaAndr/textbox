Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Asc(e.KeyChar) > 97 Or Asc(e.KeyChar) < 122 Then
            e.Handled = True
        End If
        If Not Asc(e.KeyChar) > 65 Or Asc(e.KeyChar) < 90 Then
            e.Handled = True
        End If
        If Not Asc(e.KeyChar) > 48 Or Asc(e.KeyChar) < 57 Then
            e.Handled = True
        End If
        If Not Asc(e.KeyChar) > 0 Or Asc(e.KeyChar) < 31 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub
End Class
