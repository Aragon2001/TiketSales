Imports DataAccess

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoAvion
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label6 = New Label()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
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
        Label6.Location = New Point(15, 39)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(258, 23)
        Label6.TabIndex = 18
        Label6.Text = "Registro para un nuevo avion"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1202, 28)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 39)
        Button2.TabIndex = 17
        Button2.Text = "Regresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
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
        GroupBox1.Location = New Point(20, 98)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(1298, 350)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
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
        Label1.Location = New Point(694, 189)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 16)
        Label1.TabIndex = 12
        Label1.Text = "Ingrese la ciudad de origen :"
        ' 
        ' TextBoxlinea
        ' 
        TextBoxlinea.FormattingEnabled = True
        TextBoxlinea.Items.AddRange(New Object() {"American Airlines", "British Airways", "Emirates", "Delta Air Lines", "American Airlines", "British Airways", "Emirates", "Delta Air Lines"})
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
        Label2.Location = New Point(24, 45)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 16)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese la linea Aera:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 110)
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
        Label4.Location = New Point(694, 110)
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
        Label5.Location = New Point(694, 45)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 16)
        Label5.TabIndex = 4
        Label5.Text = "Ingrese la marca del avion:"
        ' 
        ' NuevoAvion
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1401, 657)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(GroupBox1)
        Margin = New Padding(5, 3, 5, 3)
        Name = "NuevoAvion"
        Text = "NuevoAvion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxlinea As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxmarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxcapacidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxnombre_piloto As TextBox
    Friend WithEvents Label5 As Label

    Friend WithEvents TextBoxCiudadOrigen As TextBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nuevoAvionDataAccess As New NuevoAvionDataAccess()
        nuevoAvionDataAccess.InsertarNuevoAvion(TextBoxmarca.Text, TextBoxlinea.SelectedIndex + 1, Convert.ToInt32(TextBoxcapacidad.Text), TextBoxnombre_piloto.Text, TextBoxCiudadOrigen.Text)
    End Sub
End Class
