Public Class razonSocialLogica
    Public Shared Function RazonesSociales_Select() As DataTable

        Return DATOS_TPVF.razonSocialDatos.RazonesSociales_Select()

    End Function

    Public Shared Function RazonesSociales_Select2(ByVal nombre_razon_social As String) As DataTable

        Return DATOS_TPVF.razonSocialDatos.RazonesSociales_Select2(nombre_razon_social)

    End Function

    Public Shared Function RazonesSociales_Select3() As DataTable

        Return DATOS_TPVF.razonSocialDatos.RazonesSociales_Select3()

    End Function

    Public Shared Function RazonesSociales_Insert(ByVal nombre_razon_social As String, ByVal calle_razon_social As String, ByVal numext_razon_social As Integer, ByVal numint_razon_social As Integer, ByVal referencia_razon_social As String, ByVal colonia_razon_social As String, ByVal cp_razon_social As Integer, ByVal rfc_razon_social As String, ByVal estado_razon_social As String, ByVal municipio_razon_social As String, ByVal regimenfiscal_razon_social As String, ByVal teluno_razon_social As Integer, ByVal teldos_razon_social As Integer, ByVal redsocialuno_razon_social As String, ByVal redsocialdos_razon_social As String) As DataTable

        Return DATOS_TPVF.razonSocialDatos.RazonesSociales_Insert(nombre_razon_social, calle_razon_social, numext_razon_social, numint_razon_social, referencia_razon_social, colonia_razon_social, cp_razon_social, rfc_razon_social, estado_razon_social, municipio_razon_social, regimenfiscal_razon_social, teluno_razon_social, teldos_razon_social, redsocialuno_razon_social, redsocialdos_razon_social)

    End Function

End Class
