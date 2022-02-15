Public Class inicioSesion

    Public Shared Function InicioSesion_Select(ByVal usuario_empleado As String, ByVal Contrasenia_Empleado As String) As DataTable

        Return DATOS_TPVF.inicioSesion.InicioSesion_Select(usuario_empleado, Contrasenia_Empleado)

    End Function

End Class
