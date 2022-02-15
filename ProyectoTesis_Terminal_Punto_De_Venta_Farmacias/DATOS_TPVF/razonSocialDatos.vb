Imports System.Data.SqlClient
Public Class razonSocialDatos
    Public Shared Function RazonesSociales_Select() As DataTable
        Dim oconex As New SqlConnection(My.Settings.cadena)
        oconex.Open()

        Dim ocomand As New SqlCommand
        ocomand.Connection = oconex
        ocomand.CommandType = CommandType.StoredProcedure
        ocomand.CommandText = "SP_SELECT_RAZONSOCIAL_DOS"

        Dim oidr As IDataReader
        oidr = ocomand.ExecuteReader

        Dim odt As New DataTable
        odt.Load(oidr)

        Return odt

        oconex.Close()
    End Function

    Public Shared Function RazonesSociales_Select2(ByVal nombre_razon_social As String) As DataTable
        Dim oconex As New SqlConnection(My.Settings.cadena)
        oconex.Open()

        Dim ocomand As New SqlCommand
        ocomand.Connection = oconex
        ocomand.CommandType = CommandType.StoredProcedure
        ocomand.CommandText = "SP_SELECT_RAZONSOCIAL"

        ocomand.Parameters.AddWithValue("@NOMBRE", nombre_razon_social)

        Dim oidr As IDataReader
        oidr = ocomand.ExecuteReader

        Dim odt As New DataTable
        odt.Load(oidr)

        Return odt

        oconex.Close()
    End Function

    Public Shared Function RazonesSociales_Select3() As DataTable
        Dim oconex As New SqlConnection(My.Settings.cadena)
        oconex.Open()

        Dim ocomand As New SqlCommand
        ocomand.Connection = oconex
        ocomand.CommandType = CommandType.StoredProcedure
        ocomand.CommandText = "SP_SELECT_RAZONSOCIAL_TRES"

        Dim oidr As IDataReader
        oidr = ocomand.ExecuteReader

        Dim odt As New DataTable
        odt.Load(oidr)

        Return odt

        oconex.Close()
    End Function

    Public Shared Function RazonesSociales_Insert(ByVal nombre_razon_social As String, ByVal calle_razon_social As String, ByVal numext_razon_social As Integer, ByVal numint_razon_social As Integer, ByVal referencia_razon_social As String, ByVal colonia_razon_social As String, ByVal cp_razon_social As Integer, ByVal rfc_razon_social As String, ByVal estado_razon_social As String, ByVal municipio_razon_social As String, ByVal regimenfiscal_razon_social As String, ByVal teluno_razon_social As Integer, ByVal teldos_razon_social As Integer, ByVal redsocialuno_razon_social As String, ByVal redsocialdos_razon_social As String) As DataTable
        Dim oconex As New SqlConnection(My.Settings.cadena)
        oconex.Open()

        Dim ocomand As New SqlCommand
        ocomand.Connection = oconex
        ocomand.CommandType = CommandType.StoredProcedure
        ocomand.CommandText = "SP_INSERT_RAZONSOCIAL"

        ocomand.Parameters.AddWithValue("@NOMBRE", nombre_razon_social)
        ocomand.Parameters.AddWithValue("@CALLE", calle_razon_social)
        ocomand.Parameters.AddWithValue("@NUMEXT", numext_razon_social)
        ocomand.Parameters.AddWithValue("@NUMINT", numint_razon_social)
        ocomand.Parameters.AddWithValue("@REFERENCIA", referencia_razon_social)
        ocomand.Parameters.AddWithValue("@COLONIA", colonia_razon_social)
        ocomand.Parameters.AddWithValue("@CP", cp_razon_social)
        ocomand.Parameters.AddWithValue("@RFC", rfc_razon_social)
        ocomand.Parameters.AddWithValue("@ESTADO", estado_razon_social)
        ocomand.Parameters.AddWithValue("@MUNICIPIO", municipio_razon_social)
        ocomand.Parameters.AddWithValue("@REGIMENFISCAL", regimenfiscal_razon_social)
        ocomand.Parameters.AddWithValue("@TELEFONOUNO", teluno_razon_social)
        ocomand.Parameters.AddWithValue("@TELEFONODOS", teldos_razon_social)
        ocomand.Parameters.AddWithValue("@REDSOCIALUNO", redsocialuno_razon_social)
        ocomand.Parameters.AddWithValue("@REDSOCIALDOS", redsocialdos_razon_social)

        Dim oidr As IDataReader
        oidr = ocomand.ExecuteReader

        Dim odt As New DataTable
        odt.Load(oidr)

        Return odt

        oconex.Close()
    End Function

End Class
