<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarVuelo
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
        ComboBoxIDAvion = New ComboBox()
        Label3 = New Label()
        TextBoxDestinoVuelo = New TextBox()
        ComboBoxBoxlinea = New ComboBox()
        Label1 = New Label()
        DateTimePickerHoraLlegada = New DateTimePicker()
        DateTimePickerHoraSalida = New DateTimePicker()
        Label9 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        TextBoxPrecio = New TextBox()
        Label2 = New Label()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 40)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(256, 23)
        Label6.TabIndex = 24
        Label6.Text = "Registro para un nuevo vuelo"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1201, 14)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 54)
        Button2.TabIndex = 23
        Button2.Text = "Regresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBoxIDAvion)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBoxDestinoVuelo)
        GroupBox1.Controls.Add(ComboBoxBoxlinea)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DateTimePickerHoraLlegada)
        GroupBox1.Controls.Add(DateTimePickerHoraSalida)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBoxPrecio)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(19, 84)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(1298, 365)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        ' 
        ' ComboBoxIDAvion
        ' 
        ComboBoxIDAvion.FormattingEnabled = True
        ComboBoxIDAvion.Items.AddRange(New Object() {1, 2})
        ComboBoxIDAvion.Location = New Point(886, 100)
        ComboBoxIDAvion.Margin = New Padding(5, 3, 5, 3)
        ComboBoxIDAvion.Name = "ComboBoxIDAvion"
        ComboBoxIDAvion.Size = New Size(319, 23)
        ComboBoxIDAvion.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(698, 105)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 16)
        Label3.TabIndex = 23
        Label3.Text = "Ingrese el ID del avion :"
        ' 
        ' TextBoxDestinoVuelo
        ' 
        TextBoxDestinoVuelo.Location = New Point(286, 40)
        TextBoxDestinoVuelo.Margin = New Padding(5)
        TextBoxDestinoVuelo.Name = "TextBoxDestinoVuelo"
        TextBoxDestinoVuelo.Size = New Size(319, 23)
        TextBoxDestinoVuelo.TabIndex = 22
        ' 
        ' ComboBoxBoxlinea
        ' 
        ComboBoxBoxlinea.FormattingEnabled = True
        ComboBoxBoxlinea.Items.AddRange(New Object() {"American Airlines", "British Airways", "Emirates", "Delta Air Lines"})
        ComboBoxBoxlinea.Location = New Point(286, 98)
        ComboBoxBoxlinea.Margin = New Padding(5, 3, 5, 3)
        ComboBoxBoxlinea.Name = "ComboBoxBoxlinea"
        ComboBoxBoxlinea.Size = New Size(319, 23)
        ComboBoxBoxlinea.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 100)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 16)
        Label1.TabIndex = 20
        Label1.Text = "Ingrese la linea aerea "
        ' 
        ' DateTimePickerHoraLlegada
        ' 
        DateTimePickerHoraLlegada.Format = DateTimePickerFormat.Time
        DateTimePickerHoraLlegada.Location = New Point(286, 197)
        DateTimePickerHoraLlegada.Name = "DateTimePickerHoraLlegada"
        DateTimePickerHoraLlegada.ShowUpDown = True
        DateTimePickerHoraLlegada.Size = New Size(235, 23)
        DateTimePickerHoraLlegada.TabIndex = 19
        ' 
        ' DateTimePickerHoraSalida
        ' 
        DateTimePickerHoraSalida.Format = DateTimePickerFormat.Time
        DateTimePickerHoraSalida.Location = New Point(286, 155)
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
        Label9.Location = New Point(28, 202)
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
        Label8.Location = New Point(36, 160)
        Label8.Margin = New Padding(6, 0, 6, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(164, 16)
        Label8.TabIndex = 16
        Label8.Text = "Ingrese la hora de salida :"
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
        ' TextBoxPrecio
        ' 
        TextBoxPrecio.Location = New Point(886, 47)
        TextBoxPrecio.Margin = New Padding(5)
        TextBoxPrecio.Name = "TextBoxPrecio"
        TextBoxPrecio.Size = New Size(319, 23)
        TextBoxPrecio.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(28, 42)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 16)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese el destino del vuelo "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(698, 49)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(178, 16)
        Label5.TabIndex = 4
        Label5.Text = "Ingrese el precio del vuelo :"
        ' 
        ' AgregarVuelo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1332, 471)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(GroupBox1)
        Name = "AgregarVuelo"
        Text = "AgregarVuelo"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxcapacidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxBoxlinea As ComboBox
    Friend WithEvents TextBoxDestinoVuelo As TextBox
    Friend WithEvents ComboBoxIDAvion As ComboBox
    Friend WithEvents Label3 As Label
End Class
