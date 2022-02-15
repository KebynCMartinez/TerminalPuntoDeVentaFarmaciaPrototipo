Imports System.Runtime.InteropServices
Public Class InicioSesionUI
    Private odt As New DataTable
    Dim resultado As MsgBoxResult
    Dim FilaActual As Integer
    Dim m_timer, m2 As System.Windows.Forms.Timer
    Private Sub iniciarSesionUI(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        m_timer = New System.Windows.Forms.Timer()
        m2 = New System.Windows.Forms.Timer()
        AddHandler m_timer.Tick, AddressOf TimerOnTick
        AddHandler m2.Tick, AddressOf TimerOnTick2
        m_timer.Interval = 600
        m2.Interval = 800
        menuEmpleadoUI.Show()
        menuEmpleadoUI.Visible = False
    End Sub

    Private Sub TimerOnTick(ByVal sender As Object, ByVal e As EventArgs)
        m_timer.Stop()
        If dvg_Resultado.Rows.Count > 0 Then
            Me.Text = "TPV - " + dvg_Resultado.Rows(0).Cells(0).Value
        End If

    End Sub

    Private Sub TimerOnTick2(ByVal sender As Object, ByVal e As EventArgs)
        m2.Stop()
        If Me.Text = "TPV - " Then
            resultado = CType(MessageBox.Show("No existe el registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation), MsgBoxResult)
        Else
            menuEmpleadoUI.Text = "TPV - " + dvg_Resultado.Rows(0).Cells(0).Value
            menuEmpleadoUI.Visible = True
            Me.Visible = False
            dvg_Resultado.Columns.Clear()
            Txt_Usuario.Clear()
            Txt_Contrasenia.Clear()
        End If

    End Sub
    Private Sub btn_iniciar_sesion_Click(sender As Object, e As EventArgs) Handles btn_iniciar_sesion.Click
        odt = LOGICA_TPVF.inicioSesion.InicioSesion_Select(Txt_Usuario.Text, Txt_Contrasenia.Text)
        dvg_Resultado.DataSource = odt

        If Txt_Usuario.Text = "" Or Txt_Contrasenia.Text = "" Then
            resultado = CType(MessageBox.Show("Datos incompletos, rellene los campos anteriores", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation), MsgBoxResult)
        Else
            m_timer.Start()
            m2.Start()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Txt_Usuario.Clear()
        Txt_Contrasenia.Clear()
        Panel2.Visible = False
        dvg_Resultado.Columns.Clear()
    End Sub

    Private Sub inicioSesionUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        resultado = CType(MessageBox.Show("¿Desea salir del sistema?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        menuEmpleadoUI.Close()
    End Sub

End Class