<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAvion
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
        Label6 = New Label()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        Label11 = New Label()
        TextBoxCiudadesEscala = New TextBox()
        RadioButtonNoEscala = New RadioButton()
        RadioButtonSiEscala = New RadioButton()
        Label10 = New Label()
        DateTimePickerHoraLlegada = New DateTimePicker()
        DateTimePickerHoraSalida = New DateTimePicker()
        Label9 = New Label()
        Label8 = New Label()
        TextBoxCiudadDestino = New TextBox()
        Label7 = New Label()
        TextBoxCiudadOrigen = New TextBox()
        Label1 = New Label()
        TextBoxlinea = New ComboBox()
        Button1 = New Button()
        TextBoxmarca = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxcapacidad = New TextBox()
        Label4 = New Label()
        TextBoxnombre_piloto = New TextBox()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 48)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(258, 23)
        Label6.TabIndex = 21
        Label6.Text = "Registro para un nuevo avion"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1201, 22)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 54)
        Button2.TabIndex = 20
        Button2.Text = "Regresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(TextBoxCiudadesEscala)
        GroupBox1.Controls.Add(RadioButtonNoEscala)
        GroupBox1.Controls.Add(RadioButtonSiEscala)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(DateTimePickerHoraLlegada)
        GroupBox1.Controls.Add(DateTimePickerHoraSalida)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBoxCiudadDestino)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBoxCiudadOrigen)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBoxlinea)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBoxmarca)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBoxcapacidad)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBoxnombre_piloto)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(19, 92)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(1298, 365)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(551, 269)
        Label11.Margin = New Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(136, 16)
        Label11.TabIndex = 24
        Label11.Text = "Ciudades de la escala"
        ' 
        ' TextBoxCiudadesEscala
        ' 
        TextBoxCiudadesEscala.Location = New Point(459, 297)
        TextBoxCiudadesEscala.Margin = New Padding(5)
        TextBoxCiudadesEscala.Name = "TextBoxCiudadesEscala"
        TextBoxCiudadesEscala.Size = New Size(322, 23)
        TextBoxCiudadesEscala.TabIndex = 23
        ' 
        ' RadioButtonNoEscala
        ' 
        RadioButtonNoEscala.AutoSize = True
        RadioButtonNoEscala.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButtonNoEscala.Location = New Point(381, 301)
        RadioButtonNoEscala.Name = "RadioButtonNoEscala"
        RadioButtonNoEscala.Size = New Size(41, 19)
        RadioButtonNoEscala.TabIndex = 22
        RadioButtonNoEscala.TabStop = True
        RadioButtonNoEscala.Text = "No"
        RadioButtonNoEscala.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonSiEscala
        ' 
        RadioButtonSiEscala.AutoSize = True
        RadioButtonSiEscala.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButtonSiEscala.Location = New Point(339, 301)
        RadioButtonSiEscala.Name = "RadioButtonSiEscala"
        RadioButtonSiEscala.Size = New Size(36, 19)
        RadioButtonSiEscala.TabIndex = 21
        RadioButtonSiEscala.TabStop = True
        RadioButtonSiEscala.Text = "Si"
        RadioButtonSiEscala.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(285, 301)
        Label10.Margin = New Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 16)
        Label10.TabIndex = 20
        Label10.Text = "Escala"
        ' 
        ' DateTimePickerHoraLlegada
        ' 
        DateTimePickerHoraLlegada.Format = DateTimePickerFormat.Time
        DateTimePickerHoraLlegada.Location = New Point(298, 203)
        DateTimePickerHoraLlegada.Name = "DateTimePickerHoraLlegada"
        DateTimePickerHoraLlegada.ShowUpDown = True
        DateTimePickerHoraLlegada.Size = New Size(235, 23)
        DateTimePickerHoraLlegada.TabIndex = 19
        ' 
        ' DateTimePickerHoraSalida
        ' 
        DateTimePickerHoraSalida.Format = DateTimePickerFormat.Time
        DateTimePickerHoraSalida.Location = New Point(298, 165)
        DateTimePickerHoraSalida.Name = "DateTimePickerHoraSalida"
        DateTimePickerHoraSalida.ShowUpDown = True
        DateTimePickerHoraSalida.Size = New Size(235, 23)
        DateTimePickerHoraSalida.TabIndex = 18
        DateTimePickerHoraSalida.Value = New Date(2024, 4, 20, 16, 42, 0, 0)
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(26, 205)
        Label9.Margin = New Padding(6, 0, 6, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(172, 16)
        Label9.TabIndex = 17
        Label9.Text = "Ingrese la hora de llegada :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(26, 172)
        Label8.Margin = New Padding(6, 0, 6, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(164, 16)
        Label8.TabIndex = 16
        Label8.Text = "Ingrese la hora de salida :"
        ' 
        ' TextBoxCiudadDestino
        ' 
        TextBoxCiudadDestino.Location = New Point(955, 236)
        TextBoxCiudadDestino.Margin = New Padding(4, 3, 4, 3)
        TextBoxCiudadDestino.Name = "TextBoxCiudadDestino"
        TextBoxCiudadDestino.Size = New Size(319, 23)
        TextBoxCiudadDestino.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(696, 240)
        Label7.Margin = New Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(187, 16)
        Label7.TabIndex = 14
        Label7.Text = "Ingrese la ciudad de destino :"
        ' 
        ' TextBoxCiudadOrigen
        ' 
        TextBoxCiudadOrigen.Location = New Point(955, 182)
        TextBoxCiudadOrigen.Margin = New Padding(4, 3, 4, 3)
        TextBoxCiudadOrigen.Name = "TextBoxCiudadOrigen"
        TextBoxCiudadOrigen.Size = New Size(319, 23)
        TextBoxCiudadOrigen.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(696, 191)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 16)
        Label1.TabIndex = 12
        Label1.Text = "Ingrese la ciudad de origen :"
        ' 
        ' TextBoxlinea
        ' 
        TextBoxlinea.FormattingEnabled = True
        TextBoxlinea.Items.AddRange(New Object() {"American Airlines", "British Airways", "Emirates", "Delta Air Lines"})
        TextBoxlinea.Location = New Point(298, 40)
        TextBoxlinea.Margin = New Padding(5, 3, 5, 3)
        TextBoxlinea.Name = "TextBoxlinea"
        TextBoxlinea.Size = New Size(290, 23)
        TextBoxlinea.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(24, 288)
        Button1.Margin = New Padding(5)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 39)
        Button1.TabIndex = 10
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBoxmarca
        ' 
        TextBoxmarca.Location = New Point(955, 45)
        TextBoxmarca.Margin = New Padding(5)
        TextBoxmarca.Name = "TextBoxmarca"
        TextBoxmarca.Size = New Size(319, 23)
        TextBoxmarca.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 47)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 16)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese la linea Aerea:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 112)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(186, 16)
        Label3.TabIndex = 2
        Label3.Text = "Ingrese el nombre del piloto:"
        ' 
        ' TextBoxcapacidad
        ' 
        TextBoxcapacidad.Location = New Point(955, 105)
        TextBoxcapacidad.Margin = New Padding(5)
        TextBoxcapacidad.Name = "TextBoxcapacidad"
        TextBoxcapacidad.ReadOnly = True
        TextBoxcapacidad.Size = New Size(319, 23)
        TextBoxcapacidad.TabIndex = 7
        TextBoxcapacidad.Text = "200"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(696, 112)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 16)
        Label4.TabIndex = 3
        Label4.Text = "Ingrese la capacidad del avion:"
        ' 
        ' TextBoxnombre_piloto
        ' 
        TextBoxnombre_piloto.Location = New Point(298, 105)
        TextBoxnombre_piloto.Margin = New Padding(5)
        TextBoxnombre_piloto.Name = "TextBoxnombre_piloto"
        TextBoxnombre_piloto.Size = New Size(290, 23)
        TextBoxnombre_piloto.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(696, 47)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 16)
        Label5.TabIndex = 4
        Label5.Text = "Ingrese la marca del avion:"
        ' 
        ' AgregarAvion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1345, 468)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(GroupBox1)
        Name = "AgregarAvion"
        Text = "AgregarAvion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxCiudadesEscala As TextBox
    Friend WithEvents RadioButtonNoEscala As RadioButton
    Friend WithEvents RadioButtonSiEscala As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePickerHoraLlegada As DateTimePicker
    Friend WithEvents DateTimePickerHoraSalida As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCiudadDestino As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCiudadOrigen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxlinea As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxmarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxcapacidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxnombre_piloto As TextBox
    Friend WithEvents Label5 As Label
End Class
