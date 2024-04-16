<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Panel1 = New Panel()
        btnEditarUsuario = New Button()
        btnCerrar = New Button()
        btnAgregarUsuario = New Button()
        btnEditarMiPerfil = New Button()
        lblrol = New Label()
        Label23 = New Label()
        Label21 = New Label()
        lblemail = New Label()
        lblnombre = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        lblapellido2 = New Label()
        lblApellido1 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        lblidentificacion = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        cbLineaAerea = New ComboBox()
        Label3 = New Label()
        PanelTipo = New Panel()
        rbNO = New RadioButton()
        Label10 = New Label()
        rbSI = New RadioButton()
        Button2 = New Button()
        LinkEditar = New LinkLabel()
        btnguardar = New Button()
        btnCancelar = New Button()
        btnBuscar = New Button()
        Label11 = New Label()
        txtPass_Actual = New TextBox()
        TxtConf_Pass = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label8 = New Label()
        txtPass = New TextBox()
        txtap1 = New TextBox()
        txtap2 = New TextBox()
        txtemail = New TextBox()
        txtnombre = New TextBox()
        txtIdentificacion = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        PanelTipo.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(btnEditarUsuario)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Controls.Add(btnAgregarUsuario)
        Panel1.Controls.Add(btnEditarMiPerfil)
        Panel1.Controls.Add(lblrol)
        Panel1.Controls.Add(Label23)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(lblemail)
        Panel1.Controls.Add(lblnombre)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblapellido2)
        Panel1.Controls.Add(lblApellido1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblidentificacion)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(640, 736)
        Panel1.TabIndex = 0
        ' 
        ' btnEditarUsuario
        ' 
        btnEditarUsuario.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        btnEditarUsuario.FlatAppearance.BorderSize = 0
        btnEditarUsuario.FlatStyle = FlatStyle.Flat
        btnEditarUsuario.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        btnEditarUsuario.ForeColor = Color.White
        btnEditarUsuario.Location = New Point(404, 671)
        btnEditarUsuario.Margin = New Padding(4, 3, 4, 3)
        btnEditarUsuario.Name = "btnEditarUsuario"
        btnEditarUsuario.Size = New Size(155, 37)
        btnEditarUsuario.TabIndex = 33
        btnEditarUsuario.Text = "Editar Usuario"
        btnEditarUsuario.UseVisualStyleBackColor = False
        btnEditarUsuario.Visible = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.IndianRed
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        btnCerrar.ForeColor = Color.White
        btnCerrar.Location = New Point(540, 12)
        btnCerrar.Margin = New Padding(4, 3, 4, 3)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(84, 37)
        btnCerrar.TabIndex = 29
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnAgregarUsuario
        ' 
        btnAgregarUsuario.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        btnAgregarUsuario.FlatAppearance.BorderSize = 0
        btnAgregarUsuario.FlatStyle = FlatStyle.Flat
        btnAgregarUsuario.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        btnAgregarUsuario.ForeColor = Color.White
        btnAgregarUsuario.Location = New Point(213, 671)
        btnAgregarUsuario.Margin = New Padding(4, 3, 4, 3)
        btnAgregarUsuario.Name = "btnAgregarUsuario"
        btnAgregarUsuario.Size = New Size(155, 37)
        btnAgregarUsuario.TabIndex = 32
        btnAgregarUsuario.Text = "Agregar Usuario"
        btnAgregarUsuario.UseVisualStyleBackColor = False
        btnAgregarUsuario.Visible = False
        ' 
        ' btnEditarMiPerfil
        ' 
        btnEditarMiPerfil.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        btnEditarMiPerfil.FlatAppearance.BorderSize = 0
        btnEditarMiPerfil.FlatStyle = FlatStyle.Flat
        btnEditarMiPerfil.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        btnEditarMiPerfil.ForeColor = Color.White
        btnEditarMiPerfil.Location = New Point(42, 671)
        btnEditarMiPerfil.Margin = New Padding(4, 3, 4, 3)
        btnEditarMiPerfil.Name = "btnEditarMiPerfil"
        btnEditarMiPerfil.Size = New Size(139, 37)
        btnEditarMiPerfil.TabIndex = 27
        btnEditarMiPerfil.Text = "Editar mi perfil"
        btnEditarMiPerfil.UseVisualStyleBackColor = False
        ' 
        ' lblrol
        ' 
        lblrol.AutoSize = True
        lblrol.Location = New Point(302, 376)
        lblrol.Name = "lblrol"
        lblrol.Size = New Size(28, 19)
        lblrol.TabIndex = 31
        lblrol.Text = "Rol"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label23.Location = New Point(302, 351)
        Label23.Name = "Label23"
        Label23.Size = New Size(39, 21)
        Label23.TabIndex = 30
        Label23.Text = "Rol:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label21.Location = New Point(302, 300)
        Label21.Name = "Label21"
        Label21.Size = New Size(57, 21)
        Label21.TabIndex = 28
        Label21.Text = "Email:"
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Location = New Point(302, 325)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(41, 19)
        lblemail.TabIndex = 27
        lblemail.Text = "Email"
        ' 
        ' lblnombre
        ' 
        lblnombre.AutoSize = True
        lblnombre.Location = New Point(302, 271)
        lblnombre.Name = "lblnombre"
        lblnombre.Size = New Size(59, 19)
        lblnombre.TabIndex = 26
        lblnombre.Text = "Nombre"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label9.Location = New Point(302, 245)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 21)
        Label9.TabIndex = 8
        Label9.Text = "Nombre"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(28, 95)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 262)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' lblapellido2
        ' 
        lblapellido2.AutoSize = True
        lblapellido2.Location = New Point(302, 221)
        lblapellido2.Name = "lblapellido2"
        lblapellido2.Size = New Size(66, 19)
        lblapellido2.TabIndex = 6
        lblapellido2.Text = "Apellido2"
        ' 
        ' lblApellido1
        ' 
        lblApellido1.AutoSize = True
        lblApellido1.Location = New Point(302, 170)
        lblApellido1.Name = "lblApellido1"
        lblApellido1.Size = New Size(66, 19)
        lblApellido1.TabIndex = 5
        lblApellido1.Text = "Apellido1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label5.Location = New Point(302, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 21)
        Label5.TabIndex = 4
        Label5.Text = "Segundo Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label4.Location = New Point(302, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 21)
        Label4.TabIndex = 3
        Label4.Text = "Primer Apellido"
        ' 
        ' lblidentificacion
        ' 
        lblidentificacion.AutoSize = True
        lblidentificacion.Location = New Point(302, 119)
        lblidentificacion.Name = "lblidentificacion"
        lblidentificacion.Size = New Size(89, 19)
        lblidentificacion.TabIndex = 2
        lblidentificacion.Text = "Identificacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label2.Location = New Point(302, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 1
        Label2.Text = "Usuario:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        Label1.Location = New Point(105, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 25)
        Label1.TabIndex = 0
        Label1.Text = "Mi Perfil"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        Panel2.Controls.Add(cbLineaAerea)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PanelTipo)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(LinkEditar)
        Panel2.Controls.Add(btnguardar)
        Panel2.Controls.Add(btnCancelar)
        Panel2.Controls.Add(btnBuscar)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(txtPass_Actual)
        Panel2.Controls.Add(TxtConf_Pass)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txtPass)
        Panel2.Controls.Add(txtap1)
        Panel2.Controls.Add(txtap2)
        Panel2.Controls.Add(txtemail)
        Panel2.Controls.Add(txtnombre)
        Panel2.Controls.Add(txtIdentificacion)
        Panel2.Dock = DockStyle.Right
        Panel2.Enabled = False
        Panel2.Location = New Point(640, 0)
        Panel2.Name = "Panel2"
        Panel2.RightToLeft = RightToLeft.Yes
        Panel2.Size = New Size(498, 736)
        Panel2.TabIndex = 1
        ' 
        ' cbLineaAerea
        ' 
        cbLineaAerea.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbLineaAerea.FormattingEnabled = True
        cbLineaAerea.Location = New Point(47, 351)
        cbLineaAerea.Name = "cbLineaAerea"
        cbLineaAerea.Size = New Size(419, 29)
        cbLineaAerea.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.Gainsboro
        Label3.Location = New Point(46, 327)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 21)
        Label3.TabIndex = 30
        Label3.Text = "Linea Aerea"
        ' 
        ' PanelTipo
        ' 
        PanelTipo.Controls.Add(rbNO)
        PanelTipo.Controls.Add(Label10)
        PanelTipo.Controls.Add(rbSI)
        PanelTipo.Location = New Point(47, 545)
        PanelTipo.Name = "PanelTipo"
        PanelTipo.Size = New Size(204, 97)
        PanelTipo.TabIndex = 28
        ' 
        ' rbNO
        ' 
        rbNO.AutoSize = True
        rbNO.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        rbNO.ForeColor = Color.Gainsboro
        rbNO.Location = New Point(78, 53)
        rbNO.Name = "rbNO"
        rbNO.Size = New Size(53, 25)
        rbNO.TabIndex = 22
        rbNO.TabStop = True
        rbNO.Text = "NO"
        rbNO.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label10.ForeColor = Color.Gainsboro
        Label10.Location = New Point(4, 14)
        Label10.Name = "Label10"
        Label10.Size = New Size(183, 21)
        Label10.TabIndex = 9
        Label10.Text = "Usuario Administrador"
        ' 
        ' rbSI
        ' 
        rbSI.AutoSize = True
        rbSI.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        rbSI.ForeColor = Color.Gainsboro
        rbSI.Location = New Point(12, 53)
        rbSI.Name = "rbSI"
        rbSI.Size = New Size(42, 25)
        rbSI.TabIndex = 21
        rbSI.TabStop = True
        rbSI.Text = "SI"
        rbSI.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(382, 671)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(84, 37)
        Button2.TabIndex = 27
        Button2.Text = "Eliminar"
        Button2.UseVisualStyleBackColor = False
        Button2.Visible = False
        ' 
        ' LinkEditar
        ' 
        LinkEditar.AutoSize = True
        LinkEditar.LinkColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        LinkEditar.Location = New Point(155, 389)
        LinkEditar.Name = "LinkEditar"
        LinkEditar.Size = New Size(44, 19)
        LinkEditar.TabIndex = 26
        LinkEditar.TabStop = True
        LinkEditar.Text = "Editar"
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        btnguardar.FlatAppearance.BorderSize = 0
        btnguardar.FlatStyle = FlatStyle.Flat
        btnguardar.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        btnguardar.ForeColor = Color.White
        btnguardar.Location = New Point(222, 671)
        btnguardar.Margin = New Padding(4, 3, 4, 3)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(139, 37)
        btnguardar.TabIndex = 24
        btnguardar.Text = "Guardar"
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.IndianRed
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(51, 671)
        btnCancelar.Margin = New Padding(4, 3, 4, 3)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(139, 37)
        btnCancelar.TabIndex = 23
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(420, 30)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(46, 47)
        btnBuscar.TabIndex = 25
        btnBuscar.UseVisualStyleBackColor = False
        btnBuscar.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label11.ForeColor = Color.Gainsboro
        Label11.Location = New Point(48, 489)
        Label11.Name = "Label11"
        Label11.Size = New Size(149, 21)
        Label11.TabIndex = 10
        Label11.Text = "Contraseña Actual"
        ' 
        ' txtPass_Actual
        ' 
        txtPass_Actual.Font = New Font("Ebrima", 12F)
        txtPass_Actual.Location = New Point(46, 510)
        txtPass_Actual.Name = "txtPass_Actual"
        txtPass_Actual.RightToLeft = RightToLeft.Yes
        txtPass_Actual.Size = New Size(417, 29)
        txtPass_Actual.TabIndex = 19
        ' 
        ' TxtConf_Pass
        ' 
        TxtConf_Pass.Enabled = False
        TxtConf_Pass.Font = New Font("Ebrima", 12F)
        TxtConf_Pass.Location = New Point(46, 459)
        TxtConf_Pass.Name = "TxtConf_Pass"
        TxtConf_Pass.RightToLeft = RightToLeft.Yes
        TxtConf_Pass.Size = New Size(417, 29)
        TxtConf_Pass.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label12.ForeColor = Color.Gainsboro
        Label12.Location = New Point(46, 438)
        Label12.Name = "Label12"
        Label12.Size = New Size(177, 21)
        Label12.TabIndex = 11
        Label12.Text = "Confirmar Contraseña"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label13.ForeColor = Color.Gainsboro
        Label13.Location = New Point(48, 387)
        Label13.Name = "Label13"
        Label13.Size = New Size(96, 21)
        Label13.TabIndex = 12
        Label13.Text = "Contraseña"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label14.ForeColor = Color.Gainsboro
        Label14.Location = New Point(47, 274)
        Label14.Name = "Label14"
        Label14.Size = New Size(151, 21)
        Label14.TabIndex = 13
        Label14.Text = "Correo Electronico"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label15.ForeColor = Color.Gainsboro
        Label15.Location = New Point(47, 221)
        Label15.Name = "Label15"
        Label15.Size = New Size(147, 21)
        Label15.TabIndex = 14
        Label15.Text = "Segundo Apellido"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label16.ForeColor = Color.Gainsboro
        Label16.Location = New Point(47, 170)
        Label16.Name = "Label16"
        Label16.Size = New Size(130, 21)
        Label16.TabIndex = 15
        Label16.Text = "Primer Apellido"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label17.ForeColor = Color.Gainsboro
        Label17.Location = New Point(47, 119)
        Label17.Name = "Label17"
        Label17.Size = New Size(73, 21)
        Label17.TabIndex = 16
        Label17.Text = "Nombre"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label18.ForeColor = Color.Gainsboro
        Label18.Location = New Point(47, 68)
        Label18.Name = "Label18"
        Label18.Size = New Size(116, 21)
        Label18.TabIndex = 17
        Label18.Text = "Identificación"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Gainsboro
        Label8.Location = New Point(189, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(120, 25)
        Label8.TabIndex = 8
        Label8.Text = "Editar Datos"
        ' 
        ' txtPass
        ' 
        txtPass.Enabled = False
        txtPass.Font = New Font("Ebrima", 12F)
        txtPass.Location = New Point(46, 408)
        txtPass.Name = "txtPass"
        txtPass.RightToLeft = RightToLeft.Yes
        txtPass.Size = New Size(417, 29)
        txtPass.TabIndex = 6
        ' 
        ' txtap1
        ' 
        txtap1.Font = New Font("Ebrima", 12F)
        txtap1.Location = New Point(47, 191)
        txtap1.Name = "txtap1"
        txtap1.RightToLeft = RightToLeft.Yes
        txtap1.Size = New Size(419, 29)
        txtap1.TabIndex = 5
        ' 
        ' txtap2
        ' 
        txtap2.Font = New Font("Ebrima", 12F)
        txtap2.Location = New Point(47, 242)
        txtap2.Name = "txtap2"
        txtap2.RightToLeft = RightToLeft.Yes
        txtap2.Size = New Size(419, 29)
        txtap2.TabIndex = 4
        ' 
        ' txtemail
        ' 
        txtemail.Font = New Font("Ebrima", 12F)
        txtemail.Location = New Point(47, 295)
        txtemail.Name = "txtemail"
        txtemail.RightToLeft = RightToLeft.Yes
        txtemail.Size = New Size(419, 29)
        txtemail.TabIndex = 3
        ' 
        ' txtnombre
        ' 
        txtnombre.Font = New Font("Ebrima", 12F)
        txtnombre.Location = New Point(47, 140)
        txtnombre.Name = "txtnombre"
        txtnombre.RightToLeft = RightToLeft.Yes
        txtnombre.Size = New Size(419, 29)
        txtnombre.TabIndex = 2
        ' 
        ' txtIdentificacion
        ' 
        txtIdentificacion.Font = New Font("Ebrima", 12F)
        txtIdentificacion.Location = New Point(47, 89)
        txtIdentificacion.Name = "txtIdentificacion"
        txtIdentificacion.RightToLeft = RightToLeft.Yes
        txtIdentificacion.Size = New Size(419, 29)
        txtIdentificacion.TabIndex = 1
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 736)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Ebrima", 9.980198F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Usuarios"
        Text = "Usuarios"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        PanelTipo.ResumeLayout(False)
        PanelTipo.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblapellido2 As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblidentificacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtap1 As TextBox
    Friend WithEvents txtap2 As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents txtPass_Actual As TextBox
    Friend WithEvents TxtConf_Pass As TextBox
    Friend WithEvents rbNO As RadioButton
    Friend WithEvents rbSI As RadioButton
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblemail As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblrol As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LinkEditar As LinkLabel
    Friend WithEvents btnEditarMiPerfil As Button
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelTipo As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEditarUsuario As Button
    Friend WithEvents cbLineaAerea As ComboBox
    Friend WithEvents Label3 As Label
End Class
