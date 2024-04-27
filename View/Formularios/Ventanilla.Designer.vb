<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cbAsiento
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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        lblFechaHora = New Label()
        txtLA = New TextBox()
        Label4 = New Label()
        BtnNuevaVentanilla = New Button()
        TextBoxCedula_Empl = New TextBox()
        BtnConfirmarVentanilla = New Button()
        TextBoxNombre_Emple = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBoxID_Ventanilla = New ComboBox()
        GroupBoxOrigen = New GroupBox()
        DTFechaSalida = New DateTimePicker()
        cbAsientos = New ComboBox()
        escalaNo = New RadioButton()
        TextBoxHoraSalida = New TextBox()
        escalaSi = New RadioButton()
        TextBoxNumVentanilla = New TextBox()
        TextBoxEscala = New TextBox()
        TextBoxHoraLlegada = New TextBox()
        TextBoxOrigen = New TextBox()
        Label21 = New Label()
        Label15 = New Label()
        Label20 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        TextBoxPrecioTiquete = New TextBox()
        GroupBoxPasajero = New GroupBox()
        txtApellido2 = New TextBox()
        Label13 = New Label()
        txtapellido1 = New TextBox()
        Label8 = New Label()
        ButtonBorrarP = New Button()
        TextBoxNacionalidad = New TextBox()
        cbDestinos = New ComboBox()
        TextBoxNombrePasajero = New TextBox()
        Label7 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBoxNumeroDePasaporte = New TextBox()
        Label6 = New Label()
        BtnConfirmarCompra = New Button()
        btn_VolverMenu = New Button()
        TimerActualizarHora = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBoxOrigen.SuspendLayout()
        GroupBoxPasajero.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(232, 272)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 146)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblFechaHora)
        GroupBox1.Controls.Add(txtLA)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(BtnNuevaVentanilla)
        GroupBox1.Controls.Add(TextBoxCedula_Empl)
        GroupBox1.Controls.Add(BtnConfirmarVentanilla)
        GroupBox1.Controls.Add(TextBoxNombre_Emple)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboBoxID_Ventanilla)
        GroupBox1.Location = New Point(11, 19)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(502, 424)
        GroupBox1.TabIndex = 38
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingreso de ventanillas"
        ' 
        ' lblFechaHora
        ' 
        lblFechaHora.AutoSize = True
        lblFechaHora.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFechaHora.Location = New Point(177, 235)
        lblFechaHora.Name = "lblFechaHora"
        lblFechaHora.Size = New Size(0, 17)
        lblFechaHora.TabIndex = 43
        ' 
        ' txtLA
        ' 
        txtLA.BackColor = Color.Silver
        txtLA.Enabled = False
        txtLA.ForeColor = Color.Gainsboro
        txtLA.Location = New Point(177, 188)
        txtLA.Name = "txtLA"
        txtLA.ReadOnly = True
        txtLA.Size = New Size(271, 26)
        txtLA.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(19, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 17)
        Label4.TabIndex = 30
        Label4.Text = "Fecha:"
        ' 
        ' BtnNuevaVentanilla
        ' 
        BtnNuevaVentanilla.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        BtnNuevaVentanilla.BackgroundImageLayout = ImageLayout.None
        BtnNuevaVentanilla.FlatStyle = FlatStyle.Flat
        BtnNuevaVentanilla.Font = New Font("Ebrima", 12.11881F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNuevaVentanilla.ForeColor = SystemColors.ButtonFace
        BtnNuevaVentanilla.Location = New Point(21, 350)
        BtnNuevaVentanilla.Name = "BtnNuevaVentanilla"
        BtnNuevaVentanilla.Size = New Size(174, 35)
        BtnNuevaVentanilla.TabIndex = 40
        BtnNuevaVentanilla.Text = "Cambiar Ventanilla "
        BtnNuevaVentanilla.UseVisualStyleBackColor = False
        ' 
        ' TextBoxCedula_Empl
        ' 
        TextBoxCedula_Empl.BackColor = Color.Silver
        TextBoxCedula_Empl.Enabled = False
        TextBoxCedula_Empl.ForeColor = Color.Gainsboro
        TextBoxCedula_Empl.Location = New Point(177, 142)
        TextBoxCedula_Empl.Name = "TextBoxCedula_Empl"
        TextBoxCedula_Empl.ReadOnly = True
        TextBoxCedula_Empl.Size = New Size(271, 26)
        TextBoxCedula_Empl.TabIndex = 19
        ' 
        ' BtnConfirmarVentanilla
        ' 
        BtnConfirmarVentanilla.BackColor = Color.Green
        BtnConfirmarVentanilla.BackgroundImageLayout = ImageLayout.None
        BtnConfirmarVentanilla.FlatAppearance.BorderSize = 0
        BtnConfirmarVentanilla.FlatStyle = FlatStyle.Flat
        BtnConfirmarVentanilla.Font = New Font("Ebrima", 12F)
        BtnConfirmarVentanilla.ForeColor = SystemColors.ButtonFace
        BtnConfirmarVentanilla.Location = New Point(21, 291)
        BtnConfirmarVentanilla.Name = "BtnConfirmarVentanilla"
        BtnConfirmarVentanilla.Size = New Size(174, 35)
        BtnConfirmarVentanilla.TabIndex = 29
        BtnConfirmarVentanilla.Text = "Confirmar"
        BtnConfirmarVentanilla.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNombre_Emple
        ' 
        TextBoxNombre_Emple.BackColor = Color.Silver
        TextBoxNombre_Emple.Enabled = False
        TextBoxNombre_Emple.ForeColor = Color.Gainsboro
        TextBoxNombre_Emple.Location = New Point(177, 101)
        TextBoxNombre_Emple.Name = "TextBoxNombre_Emple"
        TextBoxNombre_Emple.ReadOnly = True
        TextBoxNombre_Emple.Size = New Size(271, 26)
        TextBoxNombre_Emple.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(19, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 17)
        Label5.TabIndex = 16
        Label5.Text = "Linea Aérea:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(19, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 17)
        Label3.TabIndex = 14
        Label3.Text = "Cédula Empleado:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(19, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 17)
        Label2.TabIndex = 13
        Label2.Text = "Nombre Empleado:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(19, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 17)
        Label1.TabIndex = 12
        Label1.Text = "Ingrese la ventanilla:"
        ' 
        ' ComboBoxID_Ventanilla
        ' 
        ComboBoxID_Ventanilla.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBoxID_Ventanilla.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxID_Ventanilla.Font = New Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxID_Ventanilla.ForeColor = Color.Gainsboro
        ComboBoxID_Ventanilla.FormattingEnabled = True
        ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2"})
        ComboBoxID_Ventanilla.Location = New Point(177, 54)
        ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        ComboBoxID_Ventanilla.Size = New Size(271, 25)
        ComboBoxID_Ventanilla.TabIndex = 11
        ' 
        ' GroupBoxOrigen
        ' 
        GroupBoxOrigen.Controls.Add(DTFechaSalida)
        GroupBoxOrigen.Controls.Add(cbAsientos)
        GroupBoxOrigen.Controls.Add(escalaNo)
        GroupBoxOrigen.Controls.Add(TextBoxHoraSalida)
        GroupBoxOrigen.Controls.Add(escalaSi)
        GroupBoxOrigen.Controls.Add(TextBoxNumVentanilla)
        GroupBoxOrigen.Controls.Add(TextBoxEscala)
        GroupBoxOrigen.Controls.Add(TextBoxHoraLlegada)
        GroupBoxOrigen.Controls.Add(TextBoxOrigen)
        GroupBoxOrigen.Controls.Add(Label21)
        GroupBoxOrigen.Controls.Add(Label15)
        GroupBoxOrigen.Controls.Add(Label20)
        GroupBoxOrigen.Controls.Add(Label16)
        GroupBoxOrigen.Controls.Add(Label17)
        GroupBoxOrigen.Controls.Add(Label18)
        GroupBoxOrigen.Controls.Add(Label19)
        GroupBoxOrigen.Controls.Add(Label10)
        GroupBoxOrigen.Controls.Add(Label9)
        GroupBoxOrigen.Controls.Add(TextBoxPrecioTiquete)
        GroupBoxOrigen.Enabled = False
        GroupBoxOrigen.ForeColor = SystemColors.ActiveCaptionText
        GroupBoxOrigen.Location = New Point(627, 19)
        GroupBoxOrigen.Name = "GroupBoxOrigen"
        GroupBoxOrigen.Size = New Size(501, 402)
        GroupBoxOrigen.TabIndex = 37
        GroupBoxOrigen.TabStop = False
        GroupBoxOrigen.Text = "Vuelo"
        ' 
        ' DTFechaSalida
        ' 
        DTFechaSalida.Location = New Point(192, 269)
        DTFechaSalida.Name = "DTFechaSalida"
        DTFechaSalida.Size = New Size(289, 26)
        DTFechaSalida.TabIndex = 43
        ' 
        ' cbAsientos
        ' 
        cbAsientos.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        cbAsientos.DropDownStyle = ComboBoxStyle.DropDownList
        cbAsientos.FormattingEnabled = True
        cbAsientos.Location = New Point(193, 353)
        cbAsientos.Name = "cbAsientos"
        cbAsientos.Size = New Size(288, 25)
        cbAsientos.TabIndex = 42
        ' 
        ' escalaNo
        ' 
        escalaNo.AutoSize = True
        escalaNo.Enabled = False
        escalaNo.Location = New Point(280, 320)
        escalaNo.Name = "escalaNo"
        escalaNo.Size = New Size(48, 23)
        escalaNo.TabIndex = 32
        escalaNo.Text = "NO"
        escalaNo.UseVisualStyleBackColor = True
        ' 
        ' TextBoxHoraSalida
        ' 
        TextBoxHoraSalida.AutoCompleteMode = AutoCompleteMode.Append
        TextBoxHoraSalida.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxHoraSalida.Location = New Point(192, 68)
        TextBoxHoraSalida.Name = "TextBoxHoraSalida"
        TextBoxHoraSalida.ReadOnly = True
        TextBoxHoraSalida.Size = New Size(289, 26)
        TextBoxHoraSalida.TabIndex = 29
        ' 
        ' escalaSi
        ' 
        escalaSi.AutoSize = True
        escalaSi.Enabled = False
        escalaSi.Location = New Point(219, 320)
        escalaSi.Name = "escalaSi"
        escalaSi.Size = New Size(38, 23)
        escalaSi.TabIndex = 31
        escalaSi.Text = "SI"
        escalaSi.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNumVentanilla
        ' 
        TextBoxNumVentanilla.AutoCompleteMode = AutoCompleteMode.Append
        TextBoxNumVentanilla.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNumVentanilla.Location = New Point(193, 148)
        TextBoxNumVentanilla.Name = "TextBoxNumVentanilla"
        TextBoxNumVentanilla.ReadOnly = True
        TextBoxNumVentanilla.Size = New Size(288, 26)
        TextBoxNumVentanilla.TabIndex = 27
        ' 
        ' TextBoxEscala
        ' 
        TextBoxEscala.AutoCompleteMode = AutoCompleteMode.Append
        TextBoxEscala.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxEscala.Location = New Point(192, 194)
        TextBoxEscala.Name = "TextBoxEscala"
        TextBoxEscala.ReadOnly = True
        TextBoxEscala.Size = New Size(289, 26)
        TextBoxEscala.TabIndex = 20
        ' 
        ' TextBoxHoraLlegada
        ' 
        TextBoxHoraLlegada.AutoCompleteMode = AutoCompleteMode.Append
        TextBoxHoraLlegada.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxHoraLlegada.Location = New Point(192, 109)
        TextBoxHoraLlegada.Name = "TextBoxHoraLlegada"
        TextBoxHoraLlegada.ReadOnly = True
        TextBoxHoraLlegada.Size = New Size(289, 26)
        TextBoxHoraLlegada.TabIndex = 19
        ' 
        ' TextBoxOrigen
        ' 
        TextBoxOrigen.AutoCompleteMode = AutoCompleteMode.Append
        TextBoxOrigen.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxOrigen.Location = New Point(126, 26)
        TextBoxOrigen.Name = "TextBoxOrigen"
        TextBoxOrigen.ReadOnly = True
        TextBoxOrigen.Size = New Size(356, 26)
        TextBoxOrigen.TabIndex = 18
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ActiveCaptionText
        Label21.Location = New Point(21, 361)
        Label21.Name = "Label21"
        Label21.Size = New Size(150, 17)
        Label21.TabIndex = 29
        Label21.Text = "Numero de asiento:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(15, 203)
        Label15.Name = "Label15"
        Label15.Size = New Size(61, 17)
        Label15.TabIndex = 16
        Label15.Text = "Escala:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ActiveCaptionText
        Label20.Location = New Point(21, 320)
        Label20.Name = "Label20"
        Label20.Size = New Size(61, 17)
        Label20.TabIndex = 28
        Label20.Text = "Escala:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ActiveCaptionText
        Label16.Location = New Point(15, 157)
        Label16.Name = "Label16"
        Label16.Size = New Size(167, 17)
        Label16.TabIndex = 15
        Label16.Text = "Numero de ventanilla:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ActiveCaptionText
        Label17.Location = New Point(16, 118)
        Label17.Name = "Label17"
        Label17.Size = New Size(129, 17)
        Label17.TabIndex = 14
        Label17.Text = "Hora de llegada:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = SystemColors.ActiveCaptionText
        Label18.Location = New Point(16, 77)
        Label18.Name = "Label18"
        Label18.Size = New Size(119, 17)
        Label18.TabIndex = 13
        Label18.Text = "Hora de salida:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ActiveCaptionText
        Label19.Location = New Point(17, 35)
        Label19.Name = "Label19"
        Label19.Size = New Size(62, 17)
        Label19.TabIndex = 12
        Label19.Text = "Origen:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(20, 235)
        Label10.Name = "Label10"
        Label10.Size = New Size(137, 17)
        Label10.TabIndex = 14
        Label10.Text = "Precio de tiquete:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(20, 276)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 17)
        Label9.TabIndex = 15
        Label9.Text = "Fecha de salida:"
        ' 
        ' TextBoxPrecioTiquete
        ' 
        TextBoxPrecioTiquete.AutoCompleteMode = AutoCompleteMode.Append
        TextBoxPrecioTiquete.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxPrecioTiquete.Location = New Point(192, 226)
        TextBoxPrecioTiquete.Name = "TextBoxPrecioTiquete"
        TextBoxPrecioTiquete.ReadOnly = True
        TextBoxPrecioTiquete.Size = New Size(290, 26)
        TextBoxPrecioTiquete.TabIndex = 19
        ' 
        ' GroupBoxPasajero
        ' 
        GroupBoxPasajero.Controls.Add(txtApellido2)
        GroupBoxPasajero.Controls.Add(Label13)
        GroupBoxPasajero.Controls.Add(txtapellido1)
        GroupBoxPasajero.Controls.Add(Label8)
        GroupBoxPasajero.Controls.Add(ButtonBorrarP)
        GroupBoxPasajero.Controls.Add(TextBoxNacionalidad)
        GroupBoxPasajero.Controls.Add(cbDestinos)
        GroupBoxPasajero.Controls.Add(TextBoxNombrePasajero)
        GroupBoxPasajero.Controls.Add(Label7)
        GroupBoxPasajero.Controls.Add(Label11)
        GroupBoxPasajero.Controls.Add(Label12)
        GroupBoxPasajero.Controls.Add(TextBoxNumeroDePasaporte)
        GroupBoxPasajero.Controls.Add(Label6)
        GroupBoxPasajero.Location = New Point(12, 471)
        GroupBoxPasajero.Name = "GroupBoxPasajero"
        GroupBoxPasajero.Size = New Size(957, 253)
        GroupBoxPasajero.TabIndex = 36
        GroupBoxPasajero.TabStop = False
        GroupBoxPasajero.Text = "Pasajero"
        ' 
        ' txtApellido2
        ' 
        txtApellido2.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        txtApellido2.Location = New Point(659, 80)
        txtApellido2.Name = "txtApellido2"
        txtApellido2.Size = New Size(284, 26)
        txtApellido2.TabIndex = 46
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(518, 85)
        Label13.Name = "Label13"
        Label13.Size = New Size(140, 17)
        Label13.TabIndex = 45
        Label13.Text = "Segundo Apellido:"
        ' 
        ' txtapellido1
        ' 
        txtapellido1.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        txtapellido1.Location = New Point(659, 43)
        txtapellido1.Name = "txtapellido1"
        txtapellido1.Size = New Size(284, 26)
        txtapellido1.TabIndex = 44
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(518, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 17)
        Label8.TabIndex = 43
        Label8.Text = "Primer Apellido"
        ' 
        ' ButtonBorrarP
        ' 
        ButtonBorrarP.BackColor = Color.IndianRed
        ButtonBorrarP.BackgroundImageLayout = ImageLayout.None
        ButtonBorrarP.Enabled = False
        ButtonBorrarP.FlatAppearance.BorderSize = 0
        ButtonBorrarP.FlatStyle = FlatStyle.Flat
        ButtonBorrarP.Font = New Font("Ebrima", 12.11881F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonBorrarP.ForeColor = SystemColors.ButtonFace
        ButtonBorrarP.Location = New Point(20, 212)
        ButtonBorrarP.Name = "ButtonBorrarP"
        ButtonBorrarP.Size = New Size(181, 35)
        ButtonBorrarP.TabIndex = 42
        ButtonBorrarP.Text = "Borrar pasajero"
        ButtonBorrarP.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNacionalidad
        ' 
        TextBoxNacionalidad.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNacionalidad.Location = New Point(200, 80)
        TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        TextBoxNacionalidad.Size = New Size(284, 26)
        TextBoxNacionalidad.TabIndex = 23
        ' 
        ' cbDestinos
        ' 
        cbDestinos.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        cbDestinos.DropDownStyle = ComboBoxStyle.DropDownList
        cbDestinos.FormattingEnabled = True
        cbDestinos.Location = New Point(202, 157)
        cbDestinos.Name = "cbDestinos"
        cbDestinos.Size = New Size(284, 25)
        cbDestinos.TabIndex = 22
        ' 
        ' TextBoxNombrePasajero
        ' 
        TextBoxNombrePasajero.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNombrePasajero.Location = New Point(200, 41)
        TextBoxNombrePasajero.Name = "TextBoxNombrePasajero"
        TextBoxNombrePasajero.Size = New Size(284, 26)
        TextBoxNombrePasajero.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(22, 157)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 17)
        Label7.TabIndex = 17
        Label7.Text = "Destino:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(19, 80)
        Label11.Name = "Label11"
        Label11.Size = New Size(107, 17)
        Label11.TabIndex = 13
        Label11.Text = "Nacionalidad:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(19, 43)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 17)
        Label12.TabIndex = 12
        Label12.Text = "Nombre:"
        ' 
        ' TextBoxNumeroDePasaporte
        ' 
        TextBoxNumeroDePasaporte.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNumeroDePasaporte.Location = New Point(202, 115)
        TextBoxNumeroDePasaporte.Name = "TextBoxNumeroDePasaporte"
        TextBoxNumeroDePasaporte.Size = New Size(282, 26)
        TextBoxNumeroDePasaporte.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(19, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 17)
        Label6.TabIndex = 24
        Label6.Text = "Numero de pasaporte:"
        ' 
        ' BtnConfirmarCompra
        ' 
        BtnConfirmarCompra.AutoEllipsis = True
        BtnConfirmarCompra.BackColor = Color.Green
        BtnConfirmarCompra.BackgroundImageLayout = ImageLayout.None
        BtnConfirmarCompra.FlatAppearance.BorderSize = 0
        BtnConfirmarCompra.FlatStyle = FlatStyle.Flat
        BtnConfirmarCompra.Font = New Font("Ebrima", 12.11881F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnConfirmarCompra.ForeColor = SystemColors.ButtonFace
        BtnConfirmarCompra.Location = New Point(989, 516)
        BtnConfirmarCompra.Name = "BtnConfirmarCompra"
        BtnConfirmarCompra.Size = New Size(137, 64)
        BtnConfirmarCompra.TabIndex = 31
        BtnConfirmarCompra.Text = "Confirmar vuelo"
        BtnConfirmarCompra.UseVisualStyleBackColor = False
        ' 
        ' btn_VolverMenu
        ' 
        btn_VolverMenu.BackColor = Color.IndianRed
        btn_VolverMenu.FlatStyle = FlatStyle.Flat
        btn_VolverMenu.Font = New Font("Ebrima", 12F)
        btn_VolverMenu.ForeColor = SystemColors.ButtonFace
        btn_VolverMenu.Location = New Point(989, 610)
        btn_VolverMenu.Name = "btn_VolverMenu"
        btn_VolverMenu.Size = New Size(139, 35)
        btn_VolverMenu.TabIndex = 35
        btn_VolverMenu.Text = "Cerrar"
        btn_VolverMenu.UseVisualStyleBackColor = False
        ' 
        ' cbAsiento
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Lavender
        ClientSize = New Size(1138, 736)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBoxOrigen)
        Controls.Add(GroupBoxPasajero)
        Controls.Add(btn_VolverMenu)
        Controls.Add(BtnConfirmarCompra)
        Font = New Font("Ebrima", 10F)
        ForeColor = SystemColors.ActiveCaptionText
        Margin = New Padding(4)
        Name = "cbAsiento"
        Text = "Ventanilla"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBoxOrigen.ResumeLayout(False)
        GroupBoxOrigen.PerformLayout()
        GroupBoxPasajero.ResumeLayout(False)
        GroupBoxPasajero.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxLinea_Aereas As ComboBox
    Friend WithEvents BtnConfirmarVentanilla As Button
    Friend WithEvents TextBoxCedula_Empl As TextBox
    Friend WithEvents TextBoxNombre_Emple As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxID_Ventanilla As ComboBox
    Friend WithEvents GroupBoxOrigen As GroupBox
    Friend WithEvents TextBoxHoraSalida As TextBox
    Friend WithEvents TextBoxNumVentanilla As TextBox
    Friend WithEvents TextBoxEscala As TextBox
    Friend WithEvents TextBoxHoraLlegada As TextBox
    Friend WithEvents TextBoxOrigen As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBoxPasajero As GroupBox
    Friend WithEvents BtnConfirmarCompra As Button
    Friend WithEvents escalaNo As RadioButton
    Friend WithEvents escalaSi As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxNumeroDePasaporte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents cbDestinos As ComboBox
    Friend WithEvents TextBoxPrecioTiquete As TextBox
    Friend WithEvents TextBoxNombrePasajero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_VolverMenu As Button
    Friend WithEvents BtnNuevaVentanilla As Button
    Friend WithEvents ButtonBorrarP As Button
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtapellido1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbAsientos As ComboBox
    Friend WithEvents txtLA As TextBox
    Friend WithEvents DTFechaSalida As DateTimePicker
    Friend WithEvents lblFechaHora As Label
    Friend WithEvents TimerActualizarHora As Timer
End Class
