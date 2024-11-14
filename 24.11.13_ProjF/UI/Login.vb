Imports System.Data.SqlClient
Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub

    Private Function ValidarLogin(nombreUsuario As String, contrasena As String) As Boolean

        ' Definir la consulta SQL para verificar el usuario y la contraseña
        Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE usuario = @NombreUsuario AND psw = @Contrasena"

        ' Configurar el comando SQL
        cmd.CommandText = query
        cmd.Parameters.Clear()  ' Limpiar parámetros previos
        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
        cmd.Parameters.AddWithValue("@Contrasena", contrasena)

        Try
            ' Ejecutar la consulta y obtener el resultado
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Si el resultado es mayor que 0, significa que el usuario existe y la contraseña es correcta
            If result > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al validar el inicio de sesión: " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim frm As New Home
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Obtener los datos del formulario
        Dim nombreUsuario As String = txtUser.Text
        Dim contrasena As String = txtPsw.Text

        ' Validar los datos de entrada
        If String.IsNullOrWhiteSpace(nombreUsuario) OrElse String.IsNullOrWhiteSpace(contrasena) Then
            MessageBox.Show("Por favor ingrese un nombre de usuario y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Llamar a la función que valida el login
        If ValidarLogin(nombreUsuario, contrasena) Then
            MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm As New Home
            frm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
