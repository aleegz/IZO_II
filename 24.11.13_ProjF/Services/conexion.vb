Module conexion
    Public cmd As New SqlClient.SqlCommand

    Public dr As SqlClient.SqlDataReader

    Public conexion As New SqlClient.SqlConnection("Data Source=IZO_024\SQLEXPRESS;Initial Catalog=tienda_ropa;Integrated Security=false;user id=sa;password=izo9045")

    'Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-G7FKGJ6\SQLEXPRESS;Initial Catalog=tienda_ropa;Integrated Security=true")

    Public Sub conectar() 'FUNCION PARA ABRIR LA CONEXIONv

        Try

            conexion.Open()

            cmd.Connection = conexion

        Catch ex As Exception

            MsgBox("Error al conectar con el servidor.", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub
End Module
