Module Clases
    Class usuarios
        Public id_usuario As Integer
        Public usuario As String
        Public psw As Integer
    End Class

    Class marcas
        Public id_marca As Integer
        Public descrip_marca As String
    End Class

    Class prendas
        Public codigo As Integer
        Public talle As String
        Public color As String
        Public descrip_prenda As String
        Public stock As Integer
        Public precio As Decimal
        Public id_marca As Integer
    End Class

    Class clientes
        Public id_cliente As Integer
        Public razon_social As String
        Public telefono As String
    End Class

    Class formas_pago
        Public id_forma_pago As Integer
        Public descrip_forma_pago As String
    End Class

    Class ventas
        Public id_venta As Integer
        Public fecha As DateTime
        Public id_cliente As Integer
        Public id_forma_pago As Integer
        Public importe As Decimal
    End Class

    Class detalle_ventas
        Public id_venta As Integer
        Public codigo As Integer
        Public talle As String
        Public color As String
        Public precio As Decimal
        Public cantidad As Integer
        Public precio_r As Decimal
    End Class
End Module
