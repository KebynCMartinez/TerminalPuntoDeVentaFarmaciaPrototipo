Public Class registrarRazonSocialUI
    Private odt, odt2 As New DataTable
    Dim resultado As MsgBoxResult

    Private Sub registrarRazonSocialUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        catalogoRazonesSocialesUI.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numInt, numExt, cp, telUno, telDos As Integer
        Integer.TryParse(txt_NumInt.Text, numInt)
        Integer.TryParse(txt_NumExt.Text, numExt)
        Integer.TryParse(txt_CP.Text, cp)
        Integer.TryParse(txt_TelUno.Text, telUno)
        Integer.TryParse(txt_TelDos.Text, telDos)



        resultado = CType(MessageBox.Show("¿Está seguro de registrar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            odt = LOGICA_TPVF.razonSocialLogica.RazonesSociales_Insert(txt_Nombre.Text, txt_Calle.Text, numInt, numExt, txt_Refencia.Text, txt_Colonia.Text, cp, txt_RFC.Text, txt_Estado.Text, txt_Municipio.Text, txt_RegFisc.Text, telUno, telDos, txt_RedUno.Text, txt_RedDos.Text)
            Me.Close()
            catalogoRazonesSocialesUI.Close()
            catalogoRazonesSocialesUI.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub registrarRazonSocialUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        odt = LOGICA_TPVF.razonSocialLogica.RazonesSociales_Select3()
        DataGridView1.DataSource = odt

        Dim numbasedata As Integer
        Dim letra As String = DataGridView1.Rows(0).Cells(0).Value.ToString()
        Integer.TryParse(letra, numbasedata)
        Dim numotro As Integer = 1
        Dim result As Integer
        result = (numbasedata + numotro)
        Label2.Text = result.ToString
    End Sub
End Class