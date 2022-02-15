<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesionUI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesionUI))
        Me.btn_iniciar_sesion = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Contrasenia = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dvg_Resultado = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dvg_Resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_iniciar_sesion
        '
        Me.btn_iniciar_sesion.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_iniciar_sesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciar_sesion.Location = New System.Drawing.Point(229, 440)
        Me.btn_iniciar_sesion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_iniciar_sesion.Name = "btn_iniciar_sesion"
        Me.btn_iniciar_sesion.Size = New System.Drawing.Size(141, 43)
        Me.btn_iniciar_sesion.TabIndex = 2
        Me.btn_iniciar_sesion.Text = "Iniciar sesión"
        Me.btn_iniciar_sesion.UseCompatibleTextRendering = True
        Me.btn_iniciar_sesion.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(7, 440)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(141, 43)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 195)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 319)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'Txt_Contrasenia
        '
        Me.Txt_Contrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contrasenia.Location = New System.Drawing.Point(2, 346)
        Me.Txt_Contrasenia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Contrasenia.MaxLength = 30
        Me.Txt_Contrasenia.Name = "Txt_Contrasenia"
        Me.Txt_Contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Contrasenia.Size = New System.Drawing.Size(375, 40)
        Me.Txt_Contrasenia.TabIndex = 1
        Me.Txt_Contrasenia.UseSystemPasswordChar = True
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Usuario.Location = New System.Drawing.Point(2, 222)
        Me.Txt_Usuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Usuario.MaxLength = 20
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(375, 40)
        Me.Txt_Usuario.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(2, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 157)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Txt_Usuario)
        Me.Panel2.Controls.Add(Me.btn_iniciar_sesion)
        Me.Panel2.Controls.Add(Me.btn_cancelar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Txt_Contrasenia)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dvg_Resultado)
        Me.Panel2.Location = New System.Drawing.Point(680, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 492)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 779)
        Me.Panel3.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(0, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 144)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Ingresar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(0, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 144)
        Me.Button2.TabIndex = 1
        Me.Button2.TabStop = False
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dvg_Resultado
        '
        Me.dvg_Resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dvg_Resultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dvg_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_Resultado.Location = New System.Drawing.Point(170, 346)
        Me.dvg_Resultado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dvg_Resultado.Name = "dvg_Resultado"
        Me.dvg_Resultado.RowHeadersWidth = 51
        Me.dvg_Resultado.RowTemplate.Height = 24
        Me.dvg_Resultado.Size = New System.Drawing.Size(102, 40)
        Me.dvg_Resultado.TabIndex = 4
        Me.dvg_Resultado.TabStop = False
        '
        'inicioSesionUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1527, 791)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1543, 830)
        Me.MinimumSize = New System.Drawing.Size(1534, 822)
        Me.Name = "inicioSesionUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TPVF - Ingresar al sistema"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dvg_Resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_iniciar_sesion As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Contrasenia As TextBox
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dvg_Resultado As DataGridView
End Class
