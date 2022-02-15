<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuEmpleadoUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuEmpleadoUI))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoDeRazonesSocialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoDeSucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatáloDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoDeLíneasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoDeMarcasYLaboratoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.horaActual = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(12, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 757)
        Me.Panel3.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(0, 599)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 144)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Cerrar Sesión"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 144)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Realizar Venta"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(0, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 144)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(0, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 144)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Corte de Caja"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(0, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 144)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Vtas. Realizadas"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.ArtículosToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1527, 25)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogoDeRazonesSocialesToolStripMenuItem, Me.CatálogoDeSucursalesToolStripMenuItem, Me.CatálogoDeEmpleadosToolStripMenuItem, Me.CatáloDeProveedoresToolStripMenuItem, Me.CatálogoDeLíneasToolStripMenuItem, Me.CatálogoDeMarcasYLaboratoriosToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(79, 21)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'CatálogoDeRazonesSocialesToolStripMenuItem
        '
        Me.CatálogoDeRazonesSocialesToolStripMenuItem.Name = "CatálogoDeRazonesSocialesToolStripMenuItem"
        Me.CatálogoDeRazonesSocialesToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.CatálogoDeRazonesSocialesToolStripMenuItem.Text = "Catálogo de Razones Sociales"
        '
        'CatálogoDeSucursalesToolStripMenuItem
        '
        Me.CatálogoDeSucursalesToolStripMenuItem.Name = "CatálogoDeSucursalesToolStripMenuItem"
        Me.CatálogoDeSucursalesToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.CatálogoDeSucursalesToolStripMenuItem.Text = "Catálogo de Sucursales"
        '
        'CatálogoDeEmpleadosToolStripMenuItem
        '
        Me.CatálogoDeEmpleadosToolStripMenuItem.Name = "CatálogoDeEmpleadosToolStripMenuItem"
        Me.CatálogoDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.CatálogoDeEmpleadosToolStripMenuItem.Text = "Catálogo de Empleados"
        '
        'CatáloDeProveedoresToolStripMenuItem
        '
        Me.CatáloDeProveedoresToolStripMenuItem.Name = "CatáloDeProveedoresToolStripMenuItem"
        Me.CatáloDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.CatáloDeProveedoresToolStripMenuItem.Text = "Catálogo de Proveedores"
        '
        'CatálogoDeLíneasToolStripMenuItem
        '
        Me.CatálogoDeLíneasToolStripMenuItem.Name = "CatálogoDeLíneasToolStripMenuItem"
        Me.CatálogoDeLíneasToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.CatálogoDeLíneasToolStripMenuItem.Text = "Catálogo de Líneas"
        '
        'CatálogoDeMarcasYLaboratoriosToolStripMenuItem
        '
        Me.CatálogoDeMarcasYLaboratoriosToolStripMenuItem.Name = "CatálogoDeMarcasYLaboratoriosToolStripMenuItem"
        Me.CatálogoDeMarcasYLaboratoriosToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.CatálogoDeMarcasYLaboratoriosToolStripMenuItem.Text = "Catálogo de Marcas y Laboratorios"
        '
        'ArtículosToolStripMenuItem
        '
        Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
        Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.ArtículosToolStripMenuItem.Text = "Artículos"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(114, 21)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(56, 21)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(581, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 359)
        Me.Panel1.TabIndex = 13
        '
        'Timer1
        '
        '
        'horaActual
        '
        Me.horaActual.AutoSize = True
        Me.horaActual.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaActual.Location = New System.Drawing.Point(1397, 745)
        Me.horaActual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.horaActual.Name = "horaActual"
        Me.horaActual.Size = New System.Drawing.Size(75, 39)
        Me.horaActual.TabIndex = 14
        Me.horaActual.Text = "Label1"
        '
        'menuEmpleadoUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1527, 791)
        Me.Controls.Add(Me.horaActual)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1543, 830)
        Me.MinimumSize = New System.Drawing.Size(1534, 822)
        Me.Name = "menuEmpleadoUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TPVF - Empleado"
        Me.Panel3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoDeRazonesSocialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoDeSucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatáloDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoDeLíneasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoDeMarcasYLaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents horaActual As Label
End Class
