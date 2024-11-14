Imports System.Data.SqlClient

Module Funciones
    Public Function ObtenerUltimoID(columna As String, tabla As String) As Integer
        Dim ultimoID As Integer = 0

        Using cmd As New SqlCommand()
            cmd.Connection = conexion.conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = $"SELECT MAX({columna}) AS ultimo_id FROM {tabla}"

            Try
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        If Not IsDBNull(reader("ultimo_id")) Then
                            ultimoID = Convert.ToInt32(reader("ultimo_id"))
                        End If
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End Using

        Return ultimoID + 1
    End Function

    Public Function desplegar(form As Form) As FrameStyle
        form.Size = New Size(970, 650)
    End Function
End Module
