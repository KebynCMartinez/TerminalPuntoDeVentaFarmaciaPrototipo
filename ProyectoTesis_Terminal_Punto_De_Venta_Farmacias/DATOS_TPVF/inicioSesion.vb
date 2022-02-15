Imports System.Data.SqlClient
Public Class inicioSesion
    Public Shared Function InicioSesion_Select(ByVal usuario_empleado As String, ByVal Contrasenia_Empleado As String) As DataTable
        Dim oconex As New SqlConnection(My.Settings.cadena)
        oconex.Open()

        Dim ocomand As New SqlCommand
        ocomand.Connection = oconex
        ocomand.CommandType = CommandType.StoredProcedure
        ocomand.CommandText = "SP_SELECT_INICIO_SESION"

        ocomand.Parameters.AddWithValue("@USUARIO", usuario_empleado)
        ocomand.Parameters.AddWithValue("@CONTRASENIA", Contrasenia_Empleado)

        Dim oidr As IDataReader
        oidr = ocomand.ExecuteReader

        Dim odt As New DataTable
        odt.Load(oidr)

        Return odt

        oconex.Close()
    End Function

End Class
