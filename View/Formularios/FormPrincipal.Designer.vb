<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        PanelContenedor = New Panel()
        PanelFormularios = New Panel()
        LOGO = New PictureBox()
        PanelMenu = New Panel()
        btnReporte = New Button()
        btnAddAerolinea = New Button()
        Panel1 = New Panel()
        linkEditarPerfil = New LinkLabel()
        lblemail = New Label()
        lblIdentificacion = New Label()
        PictureBox1 = New PictureBox()
        lblUser = New Label()
        lblUsuarioActivo = New Label()
        btnLogout = New Button()
        btnAddVuelo = New Button()
        btnAddPlane = New Button()
        btnVentanilla = New Button()
        btnUsuarios = New Button()
        PanelBarraTitulo = New Panel()
        Label1 = New Label()
        btnRestaurar = New PictureBox()
        btnMinimizar = New PictureBox()
        btnMaximizar = New PictureBox()
        btnCerrar = New PictureBox()
        PanelContenedor.SuspendLayout()
        PanelFormularios.SuspendLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelBarraTitulo.SuspendLayout()
        CType(btnRestaurar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = SystemColors.ActiveCaption
        PanelContenedor.Controls.Add(PanelFormularios)
        PanelContenedor.Controls.Add(PanelMenu)
        PanelContenedor.Controls.Add(PanelBarraTitulo)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(0, 0)
        PanelContenedor.Margin = New Padding(2)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(1539, 778)
        PanelContenedor.TabIndex = 0
        ' 
        ' PanelFormularios
        ' 
        PanelFormularios.BackColor = SystemColors.Control
        PanelFormularios.Controls.Add(LOGO)
        PanelFormularios.Dock = DockStyle.Fill
        PanelFormularios.Location = New Point(227, 37)
        PanelFormularios.Margin = New Padding(2)
        PanelFormularios.Name = "PanelFormularios"
        PanelFormularios.Size = New Size(1312, 741)
        PanelFormularios.TabIndex = 2
        ' 
        ' LOGO
        ' 
        LOGO.Dock = DockStyle.Fill
        LOGO.Image = CType(resources.GetObject("LOGO.Image"), Image)
        LOGO.Location = New Point(0, 0)
        LOGO.Margin = New Padding(2)
        LOGO.Name = "LOGO"
        LOGO.Size = New Size(1312, 741)
        LOGO.SizeMode = PictureBoxSizeMode.StretchImage
        LOGO.TabIndex = 0
        LOGO.TabStop = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(4), CByte(41), CByte(68))
        PanelMenu.Controls.Add(btnReporte)
        PanelMenu.Controls.Add(btnAddAerolinea)
        PanelMenu.Controls.Add(Panel1)
        PanelMenu.Controls.Add(btnLogout)
        PanelMenu.Controls.Add(btnAddVuelo)
        PanelMenu.Controls.Add(btnAddPlane)
        PanelMenu.Controls.Add(btnVentanilla)
        PanelMenu.Controls.Add(btnUsuarios)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 37)
        PanelMenu.Margin = New Padding(2)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(227, 741)
        PanelMenu.TabIndex = 1
        ' 
        ' btnReporte
        ' 
        btnReporte.FlatAppearance.BorderSize = 0
        btnReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(33), CByte(50), CByte(70))
        btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(12), CByte(61), CByte(92))
        btnReporte.FlatStyle = FlatStyle.Flat
        btnReporte.Font = New Font("Ebrima", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReporte.ForeColor = Color.Gainsboro
        btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), Image)
        btnReporte.ImageAlign = ContentAlignment.MiddleLeft
        btnReporte.Location = New Point(3, 186)
        btnReporte.Margin = New Padding(2)
        btnReporte.Name = "btnReporte"
        btnReporte.Size = New Size(225, 51)
        btnReporte.TabIndex = 13
        btnReporte.Text = "Reportes"
        btnReporte.TextAlign = ContentAlignment.MiddleRight
        btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReporte.UseVisualStyleBackColor = True
        ' 
        ' btnAddAerolinea
        ' 
        btnAddAerolinea.FlatAppearance.BorderSize = 0
        btnAddAerolinea.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(33), CByte(50), CByte(70))
        btnAddAerolinea.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(12), CByte(61), CByte(92))
        btnAddAerolinea.FlatStyle = FlatStyle.Flat
        btnAddAerolinea.Font = New Font("Ebrima", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddAerolinea.ForeColor = Color.Gainsboro
        btnAddAerolinea.Image = CType(resources.GetObject("btnAddAerolinea.Image"), Image)
        btnAddAerolinea.ImageAlign = ContentAlignment.MiddleLeft
        btnAddAerolinea.Location = New Point(0, 410)
        btnAddAerolinea.Margin = New Padding(2)
        btnAddAerolinea.Name = "btnAddAerolinea"
        btnAddAerolinea.Size = New Size(225, 51)
        btnAddAerolinea.TabIndex = 12
        btnAddAerolinea.Text = " Agregar Aerolinea"
        btnAddAerolinea.TextAlign = ContentAlignment.MiddleRight
        btnAddAerolinea.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddAerolinea.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(linkEditarPerfil)
        Panel1.Controls.Add(lblemail)
        Panel1.Controls.Add(lblIdentificacion)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblUser)
        Panel1.Controls.Add(lblUsuarioActivo)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 122)
        Panel1.TabIndex = 11
        ' 
        ' linkEditarPerfil
        ' 
        linkEditarPerfil.AutoSize = True
        linkEditarPerfil.LinkColor = Color.Gainsboro
        linkEditarPerfil.Location = New Point(3, 107)
        linkEditarPerfil.Name = "linkEditarPerfil"
        linkEditarPerfil.Size = New Size(84, 15)
        linkEditarPerfil.TabIndex = 7
        linkEditarPerfil.TabStop = True
        linkEditarPerfil.Text = "Editar mi perfil"
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Font = New Font("Ebrima", 9.75F)
        lblemail.ForeColor = Color.Gainsboro
        lblemail.Location = New Point(82, 73)
        lblemail.Margin = New Padding(4, 0, 4, 0)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(46, 17)
        lblemail.TabIndex = 6
        lblemail.Text = "Label1"
        ' 
        ' lblIdentificacion
        ' 
        lblIdentificacion.AutoSize = True
        lblIdentificacion.Font = New Font("Ebrima", 9.75F)
        lblIdentificacion.ForeColor = Color.Gainsboro
        lblIdentificacion.Location = New Point(82, 50)
        lblIdentificacion.Margin = New Padding(4, 0, 4, 0)
        lblIdentificacion.Name = "lblIdentificacion"
        lblIdentificacion.Size = New Size(46, 17)
        lblIdentificacion.TabIndex = 5
        lblIdentificacion.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 85)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Ebrima", 9.75F)
        lblUser.ForeColor = Color.Gainsboro
        lblUser.Location = New Point(82, 5)
        lblUser.Margin = New Padding(4, 0, 4, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(56, 17)
        lblUser.TabIndex = 4
        lblUser.Text = "Usuario:"
        ' 
        ' lblUsuarioActivo
        ' 
        lblUsuarioActivo.AutoSize = True
        lblUsuarioActivo.Font = New Font("Ebrima", 9.75F)
        lblUsuarioActivo.ForeColor = Color.Gainsboro
        lblUsuarioActivo.Location = New Point(82, 28)
        lblUsuarioActivo.Margin = New Padding(4, 0, 4, 0)
        lblUsuarioActivo.Name = "lblUsuarioActivo"
        lblUsuarioActivo.Size = New Size(46, 17)
        lblUsuarioActivo.TabIndex = 3
        lblUsuarioActivo.Text = "Label1"
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(33), CByte(50), CByte(70))
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(12), CByte(61), CByte(92))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Ebrima", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Gainsboro
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(2, 669)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(219, 51)
        btnLogout.TabIndex = 10
        btnLogout.Text = "        Cerrar Sesión "
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnAddVuelo
        ' 
        btnAddVuelo.FlatAppearance.BorderSize = 0
        btnAddVuelo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(33), CByte(50), CByte(70))
        btnAddVuelo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(12), CByte(61), CByte(92))
        btnAddVuelo.FlatStyle = FlatStyle.Flat
        btnAddVuelo.Font = New Font("Ebrima", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddVuelo.ForeColor = Color.Gainsboro
        btnAddVuelo.Image = CType(resources.GetObject("btnAddVuelo.Image"), Image)
        btnAddVuelo.ImageAlign = ContentAlignment.MiddleLeft
        btnAddVuelo.Location = New Point(2, 355)
        btnAddVuelo.Margin = New Padding(2)
        btnAddVuelo.Name = "btnAddVuelo"
        btnAddVuelo.Size = New Size(225, 51)
        btnAddVuelo.TabIndex = 9
        btnAddVuelo.Text = " Agregar Vuelo"
        btnAddVuelo.TextAlign = ContentAlignment.MiddleRight
        btnAddVuelo.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddVuelo.UseVisualStyleBackColor = True
        ' 
        ' btnAddPlane
        ' 
        btnAddPlane.FlatAppearance.BorderSize = 0
        btnAddPlane.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(33), CByte(50), CByte(70))
        btnAddPlane.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(12), CByte(61), CByte(92))
        btnAddPlane.FlatStyle = FlatStyle.Flat
        btnAddPlane.Font = New Font("Ebrima", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddPlane.ForeColor = Color.Gainsboro
        btnAddPlane.Image = CType(resources.GetObject("btnAddPlane.Image"), Image)
        btnAddPlane.ImageAlign = ContentAlignment.MiddleLeft
        btnAddPlane.Location = New Point(2, 300)
        btnAddPlane.Margin = New Padding(2)
        btnAddPlane.Name = "btnAddPlane"
        btnAddPlane.Size = New Size(225, 51)
        btnAddPlane.TabIndex = 8
        btnAddPlane.Text = "    Agregar Avión"
        btnAddPlane.TextAlign = ContentAlignment.MiddleRight
        btnAddPlane.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddPlane.UseVisualStyleBackColor = True
        ' 
        ' btnVentanilla
        ' 
        btnVentanilla.FlatAppearance.BorderSize = 0
        btnVentanilla.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(33), CByte(50), CByte(70))
        btnVentanilla.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(12), CByte(61), CByte(92))
        btnVentanilla.FlatStyle = FlatStyle.Flat
        btnVentanilla.Font = New Font("Ebrima", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVentanilla.ForeColor = Color.Gainsboro
        btnVentanilla.Image = CType(resources.GetObject("btnVentanilla.Image"), Image)
        btnVentanilla.ImageAlign = ContentAlignment.MiddleLeft
        btnVentanilla.Location = New Point(2, 127)
        btnVentanilla.Margin = New Padding(2)
        btnVentanilla.Name = "btnVentanilla"
        btnVentanilla.Size = New Size(225, 55)
        btnVentanilla.TabIndex = 1
        btnVentanilla.Text = "    Ventanilla"
        btnVentanilla.TextAlign = ContentAlignment.MiddleRight
        btnVentanilla.TextImageRelation = TextImageRelation.ImageBeforeText
        btnVentanilla.UseVisualStyleBackColor = True
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.FlatAppearance.BorderSize = 0
        btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(33), CByte(50), CByte(70))
        btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(12), CByte(61), CByte(92))
        btnUsuarios.FlatStyle = FlatStyle.Flat
        btnUsuarios.Font = New Font("Ebrima", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsuarios.ForeColor = Color.Gainsboro
        btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), Image)
        btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft
        btnUsuarios.Location = New Point(2, 244)
        btnUsuarios.Margin = New Padding(2)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(225, 51)
        btnUsuarios.TabIndex = 0
        btnUsuarios.Text = "    Usuarios"
        btnUsuarios.TextAlign = ContentAlignment.MiddleRight
        btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUsuarios.UseVisualStyleBackColor = True
        ' 
        ' PanelBarraTitulo
        ' 
        PanelBarraTitulo.BackColor = Color.FromArgb(CByte(13), CByte(93), CByte(142))
        PanelBarraTitulo.Controls.Add(Label1)
        PanelBarraTitulo.Controls.Add(btnRestaurar)
        PanelBarraTitulo.Controls.Add(btnMinimizar)
        PanelBarraTitulo.Controls.Add(btnMaximizar)
        PanelBarraTitulo.Controls.Add(btnCerrar)
        PanelBarraTitulo.Dock = DockStyle.Top
        PanelBarraTitulo.Location = New Point(0, 0)
        PanelBarraTitulo.Margin = New Padding(2)
        PanelBarraTitulo.Name = "PanelBarraTitulo"
        PanelBarraTitulo.Size = New Size(1539, 37)
        PanelBarraTitulo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(18, 12)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 15)
        Label1.TabIndex = 4
        Label1.Text = "Aeropuerto Juan Santa Maria"
        ' 
        ' btnRestaurar
        ' 
        btnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), Image)
        btnRestaurar.Location = New Point(1484, 12)
        btnRestaurar.Margin = New Padding(2)
        btnRestaurar.Name = "btnRestaurar"
        btnRestaurar.Size = New Size(16, 16)
        btnRestaurar.SizeMode = PictureBoxSizeMode.AutoSize
        btnRestaurar.TabIndex = 3
        btnRestaurar.TabStop = False
        btnRestaurar.Visible = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), Image)
        btnMinimizar.Location = New Point(1451, 12)
        btnMinimizar.Margin = New Padding(2)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(16, 16)
        btnMinimizar.SizeMode = PictureBoxSizeMode.AutoSize
        btnMinimizar.TabIndex = 2
        btnMinimizar.TabStop = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), Image)
        btnMaximizar.Location = New Point(1484, 12)
        btnMaximizar.Margin = New Padding(2)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(16, 16)
        btnMaximizar.SizeMode = PictureBoxSizeMode.AutoSize
        btnMaximizar.TabIndex = 1
        btnMaximizar.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(1514, 12)
        btnCerrar.Margin = New Padding(2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(16, 16)
        btnCerrar.SizeMode = PictureBoxSizeMode.AutoSize
        btnCerrar.TabIndex = 0
        btnCerrar.TabStop = False
        ' 
        ' FormPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1539, 778)
        Controls.Add(PanelContenedor)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        MinimumSize = New Size(481, 375)
        Name = "FormPrincipal"
        Text = "Form1"
        PanelContenedor.ResumeLayout(False)
        PanelFormularios.ResumeLayout(False)
        CType(LOGO, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelBarraTitulo.ResumeLayout(False)
        PanelBarraTitulo.PerformLayout()
        CType(btnRestaurar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnVentanilla As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents lblUsuarioActivo As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents btnAddVuelo As Button
    Friend WithEvents btnAddPlane As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblemail As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents linkEditarPerfil As LinkLabel
    Friend WithEvents btnAddAerolinea As Button
    Friend WithEvents btnReporte As Button
End Class
