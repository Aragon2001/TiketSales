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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelConexion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimeVentanilla = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxLinea_Aereas = New System.Windows.Forms.ComboBox()
        Me.BtnConfirmarVentanilla = New System.Windows.Forms.Button()
        Me.TextBoxCedula_Empl = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre_Emple = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxID_Ventanilla = New System.Windows.Forms.ComboBox()
        Me.GroupBoxOrigen = New System.Windows.Forms.GroupBox()
        Me.TextBoxHoraSalida = New System.Windows.Forms.TextBox()
        Me.TextBoxDestino = New System.Windows.Forms.TextBox()
        Me.TextBoxNumVentanilla = New System.Windows.Forms.TextBox()
        Me.TextBoxEscala = New System.Windows.Forms.TextBox()
        Me.TextBoxHoraLlegada = New System.Windows.Forms.TextBox()
        Me.TextBoxOrigen = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBoxPasajero = New System.Windows.Forms.GroupBox()
        Me.ComboBoxNumeroDeAsiento = New System.Windows.Forms.NumericUpDown()
        Me.BtnConfirmarCompra = New System.Windows.Forms.Button()
        Me.escalaNo = New System.Windows.Forms.RadioButton()
        Me.escalaSi = New System.Windows.Forms.RadioButton()
        Me.TextBoxFechaSalida = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxNumeroDePasaporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNacionalidad = New System.Windows.Forms.TextBox()
        Me.ComboBoxDestino = New System.Windows.Forms.ComboBox()
        Me.TextBoxPrecioTiquete = New System.Windows.Forms.TextBox()
        Me.TextBoxNombrePasajero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_VolverMenu = New System.Windows.Forms.Button()
        Me.BtnNuevaVentanilla = New System.Windows.Forms.Button()
        Me.ButtonBorrarP = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxOrigen.SuspendLayout()
        Me.GroupBoxPasajero.SuspendLayout()
        CType(Me.ComboBoxNumeroDeAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 463)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(462, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'LabelConexion
        '
        Me.LabelConexion.AutoSize = True
        Me.LabelConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConexion.Location = New System.Drawing.Point(77, 333)
        Me.LabelConexion.Name = "LabelConexion"
        Me.LabelConexion.Size = New System.Drawing.Size(214, 13)
        Me.LabelConexion.TabIndex = 39
        Me.LabelConexion.Text = "Conexion realizada con el servidor..."
        Me.LabelConexion.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelConexion)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimeVentanilla)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnNuevaVentanilla)
        Me.GroupBox1.Controls.Add(Me.ComboBoxLinea_Aereas)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmarVentanilla)
        Me.GroupBox1.Controls.Add(Me.TextBoxCedula_Empl)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre_Emple)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxID_Ventanilla)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 655)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de ventanillas"
        '
        'DateTimeVentanilla
        '
        Me.DateTimeVentanilla.Enabled = False
        Me.DateTimeVentanilla.Location = New System.Drawing.Point(97, 230)
        Me.DateTimeVentanilla.Name = "DateTimeVentanilla"
        Me.DateTimeVentanilla.Size = New System.Drawing.Size(351, 27)
        Me.DateTimeVentanilla.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Fecha:"
        '
        'ComboBoxLinea_Aereas
        '
        Me.ComboBoxLinea_Aereas.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ComboBoxLinea_Aereas.FormattingEnabled = True
        Me.ComboBoxLinea_Aereas.Location = New System.Drawing.Point(177, 184)
        Me.ComboBoxLinea_Aereas.Name = "ComboBoxLinea_Aereas"
        Me.ComboBoxLinea_Aereas.Size = New System.Drawing.Size(271, 27)
        Me.ComboBoxLinea_Aereas.TabIndex = 21
        '
        'BtnConfirmarVentanilla
        '
        Me.BtnConfirmarVentanilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnConfirmarVentanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConfirmarVentanilla.FlatAppearance.BorderSize = 0
        Me.BtnConfirmarVentanilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfirmarVentanilla.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.BtnConfirmarVentanilla.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnConfirmarVentanilla.Location = New System.Drawing.Point(12, 379)
        Me.BtnConfirmarVentanilla.Name = "BtnConfirmarVentanilla"
        Me.BtnConfirmarVentanilla.Size = New System.Drawing.Size(110, 30)
        Me.BtnConfirmarVentanilla.TabIndex = 29
        Me.BtnConfirmarVentanilla.Text = "Confirmar"
        Me.BtnConfirmarVentanilla.UseVisualStyleBackColor = False
        '
        'TextBoxCedula_Empl
        '
        Me.TextBoxCedula_Empl.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxCedula_Empl.Location = New System.Drawing.Point(177, 142)
        Me.TextBoxCedula_Empl.Name = "TextBoxCedula_Empl"
        Me.TextBoxCedula_Empl.Size = New System.Drawing.Size(271, 27)
        Me.TextBoxCedula_Empl.TabIndex = 19
        '
        'TextBoxNombre_Emple
        '
        Me.TextBoxNombre_Emple.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxNombre_Emple.Location = New System.Drawing.Point(177, 101)
        Me.TextBoxNombre_Emple.Name = "TextBoxNombre_Emple"
        Me.TextBoxNombre_Emple.Size = New System.Drawing.Size(271, 27)
        Me.TextBoxNombre_Emple.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Linea Aérea:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cédula Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese la ventanilla:"
        '
        'ComboBoxID_Ventanilla
        '
        Me.ComboBoxID_Ventanilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ComboBoxID_Ventanilla.FormattingEnabled = True
        Me.ComboBoxID_Ventanilla.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBoxID_Ventanilla.Location = New System.Drawing.Point(177, 54)
        Me.ComboBoxID_Ventanilla.Name = "ComboBoxID_Ventanilla"
        Me.ComboBoxID_Ventanilla.Size = New System.Drawing.Size(271, 27)
        Me.ComboBoxID_Ventanilla.TabIndex = 11
        '
        'GroupBoxOrigen
        '
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraSalida)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxDestino)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxNumVentanilla)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxEscala)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxHoraLlegada)
        Me.GroupBoxOrigen.Controls.Add(Me.TextBoxOrigen)
        Me.GroupBoxOrigen.Controls.Add(Me.Label14)
        Me.GroupBoxOrigen.Controls.Add(Me.Label15)
        Me.GroupBoxOrigen.Controls.Add(Me.Label16)
        Me.GroupBoxOrigen.Controls.Add(Me.Label17)
        Me.GroupBoxOrigen.Controls.Add(Me.Label18)
        Me.GroupBoxOrigen.Controls.Add(Me.Label19)
        Me.GroupBoxOrigen.Enabled = False
        Me.GroupBoxOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBoxOrigen.Location = New System.Drawing.Point(627, 454)
        Me.GroupBoxOrigen.Name = "GroupBoxOrigen"
        Me.GroupBoxOrigen.Size = New System.Drawing.Size(501, 273)
        Me.GroupBoxOrigen.TabIndex = 37
        Me.GroupBoxOrigen.TabStop = False
        Me.GroupBoxOrigen.Text = "Vuelo"
        '
        'TextBoxHoraSalida
        '
        Me.TextBoxHoraSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxHoraSalida.Location = New System.Drawing.Point(195, 119)
        Me.TextBoxHoraSalida.Name = "TextBoxHoraSalida"
        Me.TextBoxHoraSalida.ReadOnly = True
        Me.TextBoxHoraSalida.Size = New System.Drawing.Size(289, 27)
        Me.TextBoxHoraSalida.TabIndex = 29
        '
        'TextBoxDestino
        '
        Me.TextBoxDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxDestino.Location = New System.Drawing.Point(131, 78)
        Me.TextBoxDestino.Name = "TextBoxDestino"
        Me.TextBoxDestino.ReadOnly = True
        Me.TextBoxDestino.Size = New System.Drawing.Size(356, 27)
        Me.TextBoxDestino.TabIndex = 28
        '
        'TextBoxNumVentanilla
        '
        Me.TextBoxNumVentanilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxNumVentanilla.Location = New System.Drawing.Point(195, 201)
        Me.TextBoxNumVentanilla.Name = "TextBoxNumVentanilla"
        Me.TextBoxNumVentanilla.ReadOnly = True
        Me.TextBoxNumVentanilla.Size = New System.Drawing.Size(288, 27)
        Me.TextBoxNumVentanilla.TabIndex = 27
        '
        'TextBoxEscala
        '
        Me.TextBoxEscala.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxEscala.Location = New System.Drawing.Point(101, 235)
        Me.TextBoxEscala.Name = "TextBoxEscala"
        Me.TextBoxEscala.ReadOnly = True
        Me.TextBoxEscala.Size = New System.Drawing.Size(383, 27)
        Me.TextBoxEscala.TabIndex = 20
        '
        'TextBoxHoraLlegada
        '
        Me.TextBoxHoraLlegada.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxHoraLlegada.Location = New System.Drawing.Point(195, 160)
        Me.TextBoxHoraLlegada.Name = "TextBoxHoraLlegada"
        Me.TextBoxHoraLlegada.ReadOnly = True
        Me.TextBoxHoraLlegada.Size = New System.Drawing.Size(289, 27)
        Me.TextBoxHoraLlegada.TabIndex = 19
        '
        'TextBoxOrigen
        '
        Me.TextBoxOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxOrigen.Location = New System.Drawing.Point(131, 41)
        Me.TextBoxOrigen.Name = "TextBoxOrigen"
        Me.TextBoxOrigen.ReadOnly = True
        Me.TextBoxOrigen.Size = New System.Drawing.Size(356, 27)
        Me.TextBoxOrigen.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(19, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 18)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Destino:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(17, 241)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 18)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Escala:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(17, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(171, 18)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Numero de ventanilla:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(18, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(131, 18)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Hora de llegada:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(18, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 18)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Hora de salida:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(19, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 18)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Origen:"
        '
        'GroupBoxPasajero
        '
        Me.GroupBoxPasajero.Controls.Add(Me.ButtonBorrarP)
        Me.GroupBoxPasajero.Controls.Add(Me.ComboBoxNumeroDeAsiento)
        Me.GroupBoxPasajero.Controls.Add(Me.BtnConfirmarCompra)
        Me.GroupBoxPasajero.Controls.Add(Me.escalaNo)
        Me.GroupBoxPasajero.Controls.Add(Me.escalaSi)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxFechaSalida)
        Me.GroupBoxPasajero.Controls.Add(Me.Label21)
        Me.GroupBoxPasajero.Controls.Add(Me.Label20)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxNumeroDePasaporte)
        Me.GroupBoxPasajero.Controls.Add(Me.Label6)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxNacionalidad)
        Me.GroupBoxPasajero.Controls.Add(Me.ComboBoxDestino)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxPrecioTiquete)
        Me.GroupBoxPasajero.Controls.Add(Me.TextBoxNombrePasajero)
        Me.GroupBoxPasajero.Controls.Add(Me.Label7)
        Me.GroupBoxPasajero.Controls.Add(Me.Label9)
        Me.GroupBoxPasajero.Controls.Add(Me.Label10)
        Me.GroupBoxPasajero.Controls.Add(Me.Label11)
        Me.GroupBoxPasajero.Controls.Add(Me.Label12)
        Me.GroupBoxPasajero.Location = New System.Drawing.Point(627, 27)
        Me.GroupBoxPasajero.Name = "GroupBoxPasajero"
        Me.GroupBoxPasajero.Size = New System.Drawing.Size(501, 424)
        Me.GroupBoxPasajero.TabIndex = 36
        Me.GroupBoxPasajero.TabStop = False
        Me.GroupBoxPasajero.Text = "Pasajero"
        '
        'ComboBoxNumeroDeAsiento
        '
        Me.ComboBoxNumeroDeAsiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ComboBoxNumeroDeAsiento.Location = New System.Drawing.Point(200, 323)
        Me.ComboBoxNumeroDeAsiento.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.ComboBoxNumeroDeAsiento.Name = "ComboBoxNumeroDeAsiento"
        Me.ComboBoxNumeroDeAsiento.Size = New System.Drawing.Size(284, 27)
        Me.ComboBoxNumeroDeAsiento.TabIndex = 33
        Me.ComboBoxNumeroDeAsiento.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnConfirmarCompra
        '
        Me.BtnConfirmarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnConfirmarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConfirmarCompra.FlatAppearance.BorderSize = 0
        Me.BtnConfirmarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfirmarCompra.Font = New System.Drawing.Font("Ebrima", 12.11881!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnConfirmarCompra.Location = New System.Drawing.Point(20, 382)
        Me.BtnConfirmarCompra.Name = "BtnConfirmarCompra"
        Me.BtnConfirmarCompra.Size = New System.Drawing.Size(184, 28)
        Me.BtnConfirmarCompra.TabIndex = 31
        Me.BtnConfirmarCompra.Text = "Confirmar vuelo"
        Me.BtnConfirmarCompra.UseVisualStyleBackColor = False
        '
        'escalaNo
        '
        Me.escalaNo.AutoSize = True
        Me.escalaNo.Enabled = False
        Me.escalaNo.Location = New System.Drawing.Point(279, 287)
        Me.escalaNo.Name = "escalaNo"
        Me.escalaNo.Size = New System.Drawing.Size(49, 24)
        Me.escalaNo.TabIndex = 32
        Me.escalaNo.Text = "NO"
        Me.escalaNo.UseVisualStyleBackColor = True
        '
        'escalaSi
        '
        Me.escalaSi.AutoSize = True
        Me.escalaSi.Enabled = False
        Me.escalaSi.Location = New System.Drawing.Point(218, 287)
        Me.escalaSi.Name = "escalaSi"
        Me.escalaSi.Size = New System.Drawing.Size(39, 24)
        Me.escalaSi.TabIndex = 31
        Me.escalaSi.Text = "SI"
        Me.escalaSi.UseVisualStyleBackColor = True
        '
        'TextBoxFechaSalida
        '
        Me.TextBoxFechaSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxFechaSalida.Location = New System.Drawing.Point(200, 203)
        Me.TextBoxFechaSalida.Name = "TextBoxFechaSalida"
        Me.TextBoxFechaSalida.ReadOnly = True
        Me.TextBoxFechaSalida.Size = New System.Drawing.Size(284, 27)
        Me.TextBoxFechaSalida.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(20, 328)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(156, 18)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Numero de asiento:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(20, 287)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 18)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Escala:"
        '
        'TextBoxNumeroDePasaporte
        '
        Me.TextBoxNumeroDePasaporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxNumeroDePasaporte.Location = New System.Drawing.Point(200, 243)
        Me.TextBoxNumeroDePasaporte.Name = "TextBoxNumeroDePasaporte"
        Me.TextBoxNumeroDePasaporte.Size = New System.Drawing.Size(282, 27)
        Me.TextBoxNumeroDePasaporte.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(17, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Numero de pasaporte:"
        '
        'TextBoxNacionalidad
        '
        Me.TextBoxNacionalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxNacionalidad.Location = New System.Drawing.Point(200, 80)
        Me.TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        Me.TextBoxNacionalidad.Size = New System.Drawing.Size(284, 27)
        Me.TextBoxNacionalidad.TabIndex = 23
        '
        'ComboBoxDestino
        '
        Me.ComboBoxDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ComboBoxDestino.FormattingEnabled = True
        Me.ComboBoxDestino.Location = New System.Drawing.Point(200, 121)
        Me.ComboBoxDestino.Name = "ComboBoxDestino"
        Me.ComboBoxDestino.Size = New System.Drawing.Size(284, 27)
        Me.ComboBoxDestino.TabIndex = 22
        '
        'TextBoxPrecioTiquete
        '
        Me.TextBoxPrecioTiquete.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxPrecioTiquete.Location = New System.Drawing.Point(200, 162)
        Me.TextBoxPrecioTiquete.Name = "TextBoxPrecioTiquete"
        Me.TextBoxPrecioTiquete.ReadOnly = True
        Me.TextBoxPrecioTiquete.Size = New System.Drawing.Size(284, 27)
        Me.TextBoxPrecioTiquete.TabIndex = 19
        '
        'TextBoxNombrePasajero
        '
        Me.TextBoxNombrePasajero.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TextBoxNombrePasajero.Location = New System.Drawing.Point(200, 41)
        Me.TextBoxNombrePasajero.Name = "TextBoxNombrePasajero"
        Me.TextBoxNombrePasajero.Size = New System.Drawing.Size(284, 27)
        Me.TextBoxNombrePasajero.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(20, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Destino:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(19, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Fecha de salida:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(19, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Precio de tiquete:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(19, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 18)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Nacionalidad:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(19, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Nombre:"
        '
        'btn_VolverMenu
        '
        Me.btn_VolverMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_VolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_VolverMenu.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btn_VolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_VolverMenu.Location = New System.Drawing.Point(12, 679)
        Me.btn_VolverMenu.Name = "btn_VolverMenu"
        Me.btn_VolverMenu.Size = New System.Drawing.Size(110, 26)
        Me.btn_VolverMenu.TabIndex = 35
        Me.btn_VolverMenu.Text = "Cerrar"
        Me.btn_VolverMenu.UseVisualStyleBackColor = False
        '
        'BtnNuevaVentanilla
        '
        Me.BtnNuevaVentanilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnNuevaVentanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNuevaVentanilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevaVentanilla.Font = New System.Drawing.Font("Ebrima", 12.11881!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevaVentanilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNuevaVentanilla.Location = New System.Drawing.Point(148, 379)
        Me.BtnNuevaVentanilla.Name = "BtnNuevaVentanilla"
        Me.BtnNuevaVentanilla.Size = New System.Drawing.Size(174, 31)
        Me.BtnNuevaVentanilla.TabIndex = 40
        Me.BtnNuevaVentanilla.Text = "Cambiar Ventanilla "
        Me.BtnNuevaVentanilla.UseVisualStyleBackColor = False
        '
        'ButtonBorrarP
        '
        Me.ButtonBorrarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ButtonBorrarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonBorrarP.Enabled = False
        Me.ButtonBorrarP.FlatAppearance.BorderSize = 0
        Me.ButtonBorrarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBorrarP.Font = New System.Drawing.Font("Ebrima", 12.11881!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBorrarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBorrarP.Location = New System.Drawing.Point(300, 382)
        Me.ButtonBorrarP.Name = "ButtonBorrarP"
        Me.ButtonBorrarP.Size = New System.Drawing.Size(181, 28)
        Me.ButtonBorrarP.TabIndex = 42
        Me.ButtonBorrarP.Text = "Borrar pasajero"
        Me.ButtonBorrarP.UseVisualStyleBackColor = False
        '
        'Ventanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1178, 876)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxOrigen)
        Me.Controls.Add(Me.GroupBoxPasajero)
        Me.Controls.Add(Me.btn_VolverMenu)
        Me.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Ventanilla"
        Me.Text = "Ventanilla"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxOrigen.ResumeLayout(False)
        Me.GroupBoxOrigen.PerformLayout()
        Me.GroupBoxPasajero.ResumeLayout(False)
        Me.GroupBoxPasajero.PerformLayout()
        CType(Me.ComboBoxNumeroDeAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
