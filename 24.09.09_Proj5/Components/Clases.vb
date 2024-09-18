Module Clases
    Class sucursales
        Public id_sucursal As Integer
        Public descripcion As String
        Public localidad As String
    End Class

    Class vendedores
        Public id_vendedor As Integer
        Public nombre As String
        Public contraseña As String
        Public id_sucursal As Integer
    End Class

    Class ventas
        Public id_venta As Integer
        Public fecha As Date
        Public importe As Decimal
        Public id_vendedor As Integer
    End Class
End Module
