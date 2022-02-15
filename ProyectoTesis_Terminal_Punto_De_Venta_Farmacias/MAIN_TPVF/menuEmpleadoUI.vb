Public Class menuEmpleadoUI

    Dim resultado As MsgBoxResult
    Private Sub CatálogoDeRazonesSocialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoDeRazonesSocialesToolStripMenuItem.Click
        catalogoRazonesSocialesUI.Show()
    End Sub

    Private Sub CatálogoDeSucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoDeSucursalesToolStripMenuItem.Click
        catalogoSucursalesUI.Show()
    End Sub

    Private Sub CatálogoDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoDeEmpleadosToolStripMenuItem.Click
        catalogoEmpleadosUI.Show()
    End Sub

    Private Sub CatáloDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatáloDeProveedoresToolStripMenuItem.Click
        catalogoProveedoresUI.Show()
    End Sub

    Private Sub CatálogoDeLíneasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoDeLíneasToolStripMenuItem.Click
        catalogoLineasUI.Show()
    End Sub

    Private Sub CatálogoDeMarcasYLaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoDeMarcasYLaboratoriosToolStripMenuItem.Click
        catalogoLaboratoriosUI.Show()
    End Sub

    Private Sub inicioSesionUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        resultado = CType(MessageBox.Show("¿Desea salir del sistema?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Visible = False
        InicioSesionUI.Visible = True
    End Sub

    Private Sub menuEmpleadoUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.horaActual.Text = DateTime.Now.ToShortTimeString
    End Sub
End Class