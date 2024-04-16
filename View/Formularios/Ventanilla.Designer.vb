<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventanilla
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
        PictureBox1 = New PictureBox()
        LabelConexion = New Label()
        GroupBox1 = New GroupBox()
        DateTimeVentanilla = New DateTimePicker()
        Label4 = New Label()
        BtnNuevaVentanilla = New Button()
        ComboBoxLinea_Aereas = New ComboBox()
        BtnConfirmarVentanilla = New Button()
        TextBoxCedula_Empl = New TextBox()
        TextBoxNombre_Emple = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBoxID_Ventanilla = New ComboBox()
        GroupBoxOrigen = New GroupBox()
        TextBoxHoraSalida = New TextBox()
        TextBoxDestino = New TextBox()
        TextBoxNumVentanilla = New TextBox()
        TextBoxEscala = New TextBox()
        TextBoxHoraLlegada = New TextBox()
        TextBoxOrigen = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        GroupBoxPasajero = New GroupBox()
        ButtonBorrarP = New Button()
        ComboBoxNumeroDeAsiento = New NumericUpDown()
        BtnConfirmarCompra = New Button()
        escalaNo = New RadioButton()
        escalaSi = New RadioButton()
        TextBoxFechaSalida = New TextBox()
        Label21 = New Label()
        Label20 = New Label()
        TextBoxNumeroDePasaporte = New TextBox()
        Label6 = New Label()
        TextBoxNacionalidad = New TextBox()
        ComboBoxDestino = New ComboBox()
        TextBoxPrecioTiquete = New TextBox()
        TextBoxNombrePasajero = New TextBox()
        Label7 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        btn_VolverMenu = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBoxOrigen.SuspendLayout()
        GroupBoxPasajero.SuspendLayout()
        CType(ComboBoxNumeroDeAsiento, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(6, 463)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(450, 181)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' LabelConexion
        ' 
        LabelConexion.AutoSize = True
        LabelConexion.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelConexion.Location = New Point(77, 333)
        LabelConexion.Name = "LabelConexion"
        LabelConexion.Size = New Size(214, 13)
        LabelConexion.TabIndex = 39
        LabelConexion.Text = "Conexion realizada con el servidor..."
        LabelConexion.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LabelConexion)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(DateTimeVentanilla)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(BtnNuevaVentanilla)
        GroupBox1.Controls.Add(ComboBoxLinea_Aereas)
        GroupBox1.Controls.Add(BtnConfirmarVentanilla)
        GroupBox1.Controls.Add(TextBoxCedula_Empl)
        GroupBox1.Controls.Add(TextBoxNombre_Emple)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboBoxID_Ventanilla)
        GroupBox1.Location = New Point(11, 19)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(462, 655)
        GroupBox1.TabIndex = 38
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingreso de ventanillas"
        ' 
        ' DateTimeVentanilla
        ' 
        DateTimeVentanilla.Enabled = False
        DateTimeVentanilla.Location = New Point(97, 230)
        DateTimeVentanilla.Name = "DateTimeVentanilla"
        DateTimeVentanilla.Size = New Size(351, 26)
        DateTimeVentanilla.TabIndex = 31
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
        BtnNuevaVentanilla.Location = New Point(148, 379)
        BtnNuevaVentanilla.Name = "BtnNuevaVentanilla"
        BtnNuevaVentanilla.Size = New Size(174, 31)
        BtnNuevaVentanilla.TabIndex = 40
        BtnNuevaVentanilla.Text = "Cambiar Ventanilla "
        BtnNuevaVentanilla.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxLinea_Aereas
        ' 
        ComboBoxLinea_Aereas.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBoxLinea_Aereas.FormattingEnabled = True
        ComboBoxLinea_Aereas.Location = New Point(177, 184)
        ComboBoxLinea_Aereas.Name = "ComboBoxLinea_Aereas"
        ComboBoxLinea_Aereas.Size = New Size(271, 25)
        ComboBoxLinea_Aereas.TabIndex = 21
        ' 
        ' BtnConfirmarVentanilla
        ' 
        BtnConfirmarVentanilla.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        BtnConfirmarVentanilla.BackgroundImageLayout = ImageLayout.None
        BtnConfirmarVentanilla.FlatAppearance.BorderSize = 0
        BtnConfirmarVentanilla.FlatStyle = FlatStyle.Flat
        BtnConfirmarVentanilla.Font = New Font("Ebrima", 12F)
        BtnConfirmarVentanilla.ForeColor = SystemColors.ButtonFace
        BtnConfirmarVentanilla.Location = New Point(12, 379)
        BtnConfirmarVentanilla.Name = "BtnConfirmarVentanilla"
        BtnConfirmarVentanilla.Size = New Size(110, 30)
        BtnConfirmarVentanilla.TabIndex = 29
        BtnConfirmarVentanilla.Text = "Confirmar"
        BtnConfirmarVentanilla.UseVisualStyleBackColor = False
        ' 
        ' TextBoxCedula_Empl
        ' 
        TextBoxCedula_Empl.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxCedula_Empl.Location = New Point(177, 142)
        TextBoxCedula_Empl.Name = "TextBoxCedula_Empl"
        TextBoxCedula_Empl.Size = New Size(271, 26)
        TextBoxCedula_Empl.TabIndex = 19
        ' 
        ' TextBoxNombre_Emple
        ' 
        TextBoxNombre_Emple.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNombre_Emple.Location = New Point(177, 101)
        TextBoxNombre_Emple.Name = "TextBoxNombre_Emple"
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
        ComboBoxID_Ventanilla.FormattingEnabled = True
        ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBoxID_Ventanilla.Location = New Point(177, 54)
        ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        ComboBoxID_Ventanilla.Size = New Size(271, 25)
        ComboBoxID_Ventanilla.TabIndex = 11
        ' 
        ' GroupBoxOrigen
        ' 
        GroupBoxOrigen.Controls.Add(TextBoxHoraSalida)
        GroupBoxOrigen.Controls.Add(TextBoxDestino)
        GroupBoxOrigen.Controls.Add(TextBoxNumVentanilla)
        GroupBoxOrigen.Controls.Add(TextBoxEscala)
        GroupBoxOrigen.Controls.Add(TextBoxHoraLlegada)
        GroupBoxOrigen.Controls.Add(TextBoxOrigen)
        GroupBoxOrigen.Controls.Add(Label14)
        GroupBoxOrigen.Controls.Add(Label15)
        GroupBoxOrigen.Controls.Add(Label16)
        GroupBoxOrigen.Controls.Add(Label17)
        GroupBoxOrigen.Controls.Add(Label18)
        GroupBoxOrigen.Controls.Add(Label19)
        GroupBoxOrigen.Enabled = False
        GroupBoxOrigen.ForeColor = SystemColors.ActiveCaptionText
        GroupBoxOrigen.Location = New Point(627, 449)
        GroupBoxOrigen.Name = "GroupBoxOrigen"
        GroupBoxOrigen.Size = New Size(501, 273)
        GroupBoxOrigen.TabIndex = 37
        GroupBoxOrigen.TabStop = False
        GroupBoxOrigen.Text = "Vuelo"
        ' 
        ' TextBoxHoraSalida
        ' 
        TextBoxHoraSalida.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxHoraSalida.Location = New Point(195, 119)
        TextBoxHoraSalida.Name = "TextBoxHoraSalida"
        TextBoxHoraSalida.ReadOnly = True
        TextBoxHoraSalida.Size = New Size(289, 26)
        TextBoxHoraSalida.TabIndex = 29
        ' 
        ' TextBoxDestino
        ' 
        TextBoxDestino.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxDestino.Location = New Point(131, 78)
        TextBoxDestino.Name = "TextBoxDestino"
        TextBoxDestino.ReadOnly = True
        TextBoxDestino.Size = New Size(356, 26)
        TextBoxDestino.TabIndex = 28
        ' 
        ' TextBoxNumVentanilla
        ' 
        TextBoxNumVentanilla.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNumVentanilla.Location = New Point(195, 201)
        TextBoxNumVentanilla.Name = "TextBoxNumVentanilla"
        TextBoxNumVentanilla.ReadOnly = True
        TextBoxNumVentanilla.Size = New Size(288, 26)
        TextBoxNumVentanilla.TabIndex = 27
        ' 
        ' TextBoxEscala
        ' 
        TextBoxEscala.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxEscala.Location = New Point(101, 235)
        TextBoxEscala.Name = "TextBoxEscala"
        TextBoxEscala.ReadOnly = True
        TextBoxEscala.Size = New Size(383, 26)
        TextBoxEscala.TabIndex = 20
        ' 
        ' TextBoxHoraLlegada
        ' 
        TextBoxHoraLlegada.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxHoraLlegada.Location = New Point(195, 160)
        TextBoxHoraLlegada.Name = "TextBoxHoraLlegada"
        TextBoxHoraLlegada.ReadOnly = True
        TextBoxHoraLlegada.Size = New Size(289, 26)
        TextBoxHoraLlegada.TabIndex = 19
        ' 
        ' TextBoxOrigen
        ' 
        TextBoxOrigen.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxOrigen.Location = New Point(131, 41)
        TextBoxOrigen.Name = "TextBoxOrigen"
        TextBoxOrigen.ReadOnly = True
        TextBoxOrigen.Size = New Size(356, 26)
        TextBoxOrigen.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(19, 80)
        Label14.Name = "Label14"
        Label14.Size = New Size(68, 17)
        Label14.TabIndex = 17
        Label14.Text = "Destino:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(17, 241)
        Label15.Name = "Label15"
        Label15.Size = New Size(61, 17)
        Label15.TabIndex = 16
        Label15.Text = "Escala:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ActiveCaptionText
        Label16.Location = New Point(17, 199)
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
        Label17.Location = New Point(18, 160)
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
        Label18.Location = New Point(18, 119)
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
        Label19.Location = New Point(19, 41)
        Label19.Name = "Label19"
        Label19.Size = New Size(62, 17)
        Label19.TabIndex = 12
        Label19.Text = "Origen:"
        ' 
        ' GroupBoxPasajero
        ' 
        GroupBoxPasajero.Controls.Add(ButtonBorrarP)
        GroupBoxPasajero.Controls.Add(ComboBoxNumeroDeAsiento)
        GroupBoxPasajero.Controls.Add(BtnConfirmarCompra)
        GroupBoxPasajero.Controls.Add(escalaNo)
        GroupBoxPasajero.Controls.Add(escalaSi)
        GroupBoxPasajero.Controls.Add(TextBoxFechaSalida)
        GroupBoxPasajero.Controls.Add(Label21)
        GroupBoxPasajero.Controls.Add(Label20)
        GroupBoxPasajero.Controls.Add(TextBoxNumeroDePasaporte)
        GroupBoxPasajero.Controls.Add(Label6)
        GroupBoxPasajero.Controls.Add(TextBoxNacionalidad)
        GroupBoxPasajero.Controls.Add(ComboBoxDestino)
        GroupBoxPasajero.Controls.Add(TextBoxPrecioTiquete)
        GroupBoxPasajero.Controls.Add(TextBoxNombrePasajero)
        GroupBoxPasajero.Controls.Add(Label7)
        GroupBoxPasajero.Controls.Add(Label9)
        GroupBoxPasajero.Controls.Add(Label10)
        GroupBoxPasajero.Controls.Add(Label11)
        GroupBoxPasajero.Controls.Add(Label12)
        GroupBoxPasajero.Location = New Point(627, 19)
        GroupBoxPasajero.Name = "GroupBoxPasajero"
        GroupBoxPasajero.Size = New Size(501, 424)
        GroupBoxPasajero.TabIndex = 36
        GroupBoxPasajero.TabStop = False
        GroupBoxPasajero.Text = "Pasajero"
        ' 
        ' ButtonBorrarP
        ' 
        ButtonBorrarP.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        ButtonBorrarP.BackgroundImageLayout = ImageLayout.None
        ButtonBorrarP.Enabled = False
        ButtonBorrarP.FlatAppearance.BorderSize = 0
        ButtonBorrarP.FlatStyle = FlatStyle.Flat
        ButtonBorrarP.Font = New Font("Ebrima", 12.11881F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonBorrarP.ForeColor = SystemColors.ButtonFace
        ButtonBorrarP.Location = New Point(300, 382)
        ButtonBorrarP.Name = "ButtonBorrarP"
        ButtonBorrarP.Size = New Size(181, 28)
        ButtonBorrarP.TabIndex = 42
        ButtonBorrarP.Text = "Borrar pasajero"
        ButtonBorrarP.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxNumeroDeAsiento
        ' 
        ComboBoxNumeroDeAsiento.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBoxNumeroDeAsiento.Location = New Point(200, 323)
        ComboBoxNumeroDeAsiento.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        ComboBoxNumeroDeAsiento.Name = "ComboBoxNumeroDeAsiento"
        ComboBoxNumeroDeAsiento.Size = New Size(284, 26)
        ComboBoxNumeroDeAsiento.TabIndex = 33
        ComboBoxNumeroDeAsiento.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' BtnConfirmarCompra
        ' 
        BtnConfirmarCompra.AutoEllipsis = True
        BtnConfirmarCompra.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        BtnConfirmarCompra.BackgroundImageLayout = ImageLayout.None
        BtnConfirmarCompra.FlatAppearance.BorderSize = 0
        BtnConfirmarCompra.FlatStyle = FlatStyle.Flat
        BtnConfirmarCompra.Font = New Font("Ebrima", 12.11881F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnConfirmarCompra.ForeColor = SystemColors.ButtonFace
        BtnConfirmarCompra.Location = New Point(20, 382)
        BtnConfirmarCompra.Name = "BtnConfirmarCompra"
        BtnConfirmarCompra.Size = New Size(184, 28)
        BtnConfirmarCompra.TabIndex = 31
        BtnConfirmarCompra.Text = "Confirmar vuelo"
        BtnConfirmarCompra.UseVisualStyleBackColor = False
        ' 
        ' escalaNo
        ' 
        escalaNo.AutoSize = True
        escalaNo.Enabled = False
        escalaNo.Location = New Point(279, 287)
        escalaNo.Name = "escalaNo"
        escalaNo.Size = New Size(48, 23)
        escalaNo.TabIndex = 32
        escalaNo.Text = "NO"
        escalaNo.UseVisualStyleBackColor = True
        ' 
        ' escalaSi
        ' 
        escalaSi.AutoSize = True
        escalaSi.Enabled = False
        escalaSi.Location = New Point(218, 287)
        escalaSi.Name = "escalaSi"
        escalaSi.Size = New Size(38, 23)
        escalaSi.TabIndex = 31
        escalaSi.Text = "SI"
        escalaSi.UseVisualStyleBackColor = True
        ' 
        ' TextBoxFechaSalida
        ' 
        TextBoxFechaSalida.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxFechaSalida.Location = New Point(200, 203)
        TextBoxFechaSalida.Name = "TextBoxFechaSalida"
        TextBoxFechaSalida.ReadOnly = True
        TextBoxFechaSalida.Size = New Size(284, 26)
        TextBoxFechaSalida.TabIndex = 30
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ActiveCaptionText
        Label21.Location = New Point(20, 328)
        Label21.Name = "Label21"
        Label21.Size = New Size(150, 17)
        Label21.TabIndex = 29
        Label21.Text = "Numero de asiento:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ActiveCaptionText
        Label20.Location = New Point(20, 287)
        Label20.Name = "Label20"
        Label20.Size = New Size(61, 17)
        Label20.TabIndex = 28
        Label20.Text = "Escala:"
        ' 
        ' TextBoxNumeroDePasaporte
        ' 
        TextBoxNumeroDePasaporte.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNumeroDePasaporte.Location = New Point(200, 243)
        TextBoxNumeroDePasaporte.Name = "TextBoxNumeroDePasaporte"
        TextBoxNumeroDePasaporte.Size = New Size(282, 26)
        TextBoxNumeroDePasaporte.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(17, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 17)
        Label6.TabIndex = 24
        Label6.Text = "Numero de pasaporte:"
        ' 
        ' TextBoxNacionalidad
        ' 
        TextBoxNacionalidad.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxNacionalidad.Location = New Point(200, 80)
        TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        TextBoxNacionalidad.Size = New Size(284, 26)
        TextBoxNacionalidad.TabIndex = 23
        ' 
        ' ComboBoxDestino
        ' 
        ComboBoxDestino.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBoxDestino.FormattingEnabled = True
        ComboBoxDestino.Location = New Point(200, 121)
        ComboBoxDestino.Name = "ComboBoxDestino"
        ComboBoxDestino.Size = New Size(284, 25)
        ComboBoxDestino.TabIndex = 22
        ' 
        ' TextBoxPrecioTiquete
        ' 
        TextBoxPrecioTiquete.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TextBoxPrecioTiquete.Location = New Point(200, 162)
        TextBoxPrecioTiquete.Name = "TextBoxPrecioTiquete"
        TextBoxPrecioTiquete.ReadOnly = True
        TextBoxPrecioTiquete.Size = New Size(284, 26)
        TextBoxPrecioTiquete.TabIndex = 19
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
        Label7.Location = New Point(20, 121)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 17)
        Label7.TabIndex = 17
        Label7.Text = "Destino:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(19, 203)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 17)
        Label9.TabIndex = 15
        Label9.Text = "Fecha de salida:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(19, 162)
        Label10.Name = "Label10"
        Label10.Size = New Size(137, 17)
        Label10.TabIndex = 14
        Label10.Text = "Precio de tiquete:"
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
        ' btn_VolverMenu
        ' 
        btn_VolverMenu.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        btn_VolverMenu.FlatStyle = FlatStyle.Flat
        btn_VolverMenu.Font = New Font("Ebrima", 12F)
        btn_VolverMenu.ForeColor = SystemColors.ButtonFace
        btn_VolverMenu.Location = New Point(23, 681)
        btn_VolverMenu.Name = "btn_VolverMenu"
        btn_VolverMenu.Size = New Size(110, 29)
        btn_VolverMenu.TabIndex = 35
        btn_VolverMenu.Text = "Cerrar"
        btn_VolverMenu.UseVisualStyleBackColor = False
        ' 
        ' Ventanilla
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
        Font = New Font("Ebrima", 10F)
        ForeColor = SystemColors.ActiveCaptionText
        Margin = New Padding(4)
        Name = "Ventanilla"
        Text = "Ventanilla"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBoxOrigen.ResumeLayout(False)
        GroupBoxOrigen.PerformLayout()
        GroupBoxPasajero.ResumeLayout(False)
        GroupBoxPasajero.PerformLayout()
        CType(ComboBoxNumeroDeAsiento, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelConexion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimeVentanilla As DateTimePicker
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
    Friend WithEvents TextBoxDestino As TextBox
    Friend WithEvents TextBoxNumVentanilla As TextBox
    Friend WithEvents TextBoxEscala As TextBox
    Friend WithEvents TextBoxHoraLlegada As TextBox
    Friend WithEvents TextBoxOrigen As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBoxPasajero As GroupBox
    Friend WithEvents ComboBoxNumeroDeAsiento As NumericUpDown
    Friend WithEvents BtnConfirmarCompra As Button
    Friend WithEvents escalaNo As RadioButton
    Friend WithEvents escalaSi As RadioButton
    Friend WithEvents TextBoxFechaSalida As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxNumeroDePasaporte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents ComboBoxDestino As ComboBox
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
End Class
