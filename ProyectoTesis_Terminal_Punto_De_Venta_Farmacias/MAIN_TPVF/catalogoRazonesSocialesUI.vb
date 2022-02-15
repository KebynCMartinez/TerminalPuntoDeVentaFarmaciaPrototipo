Public Class catalogoRazonesSocialesUI
    Private odt, odt2 As New DataTable
    Private Sub catalogoRazonesSocialesUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        odt = LOGICA_TPVF.razonSocialLogica.RazonesSociales_Select()
        dgv_RazonesSociales.DataSource = odt
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        registrarRazonSocialUI.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            eventoEnter()

        End If
    End Sub

    Private Sub eventoEnter()
        If TextBox1.Text.Length = 0 Then
            odt = LOGICA_TPVF.razonSocialLogica.RazonesSociales_Select()
            dgv_RazonesSociales.DataSource = odt
        End If
        If TextBox1.Text.Length > 0 Then
            odt2 = LOGICA_TPVF.razonSocialLogica.RazonesSociales_Select2(TextBox1.Text)
            dgv_RazonesSociales.DataSource = odt2
        End If
    End Sub
End Class