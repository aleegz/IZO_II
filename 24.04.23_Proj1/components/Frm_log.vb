Public Class Frm_log
    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        If psw.Text <> "123" Or username.Text.Trim.Length = 0 Then
            MsgBox("usuario o contraseña incorrecto.")
            username.Text = ""
            psw.Text = ""
            username.Focus()
        Else
            Vars.SavedUsername = username.Text
            Frm_main.Show()
        End If

        Me.Close()
    End Sub
End Class