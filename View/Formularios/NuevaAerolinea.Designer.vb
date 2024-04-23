<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaAerolinea
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
        ButtonCerrar = New Button()
        GroupBox1 = New GroupBox()
        TextBoxPaisOrigenAerolinea = New TextBox()
        TextBoxNombreAerolinea = New TextBox()
        Label1 = New Label()
        ButtonAgregarAerolinea = New Button()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 29)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(300, 23)
        Label6.TabIndex = 30
        Label6.Text = "Registro para una nueva aerolinea"
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Location = New Point(582, 16)
        ButtonCerrar.Margin = New Padding(5)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(117, 54)
        ButtonCerrar.TabIndex = 29
        ButtonCerrar.Text = "Regresar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBoxPaisOrigenAerolinea)
        GroupBox1.Controls.Add(TextBoxNombreAerolinea)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ButtonAgregarAerolinea)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(19, 73)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(680, 365)
        GroupBox1.TabIndex = 28
        GroupBox1.TabStop = False
        ' 
        ' TextBoxPaisOrigenAerolinea
        ' 
        TextBoxPaisOrigenAerolinea.Location = New Point(304, 102)
        TextBoxPaisOrigenAerolinea.Margin = New Padding(5)
        TextBoxPaisOrigenAerolinea.Name = "TextBoxPaisOrigenAerolinea"
        TextBoxPaisOrigenAerolinea.Size = New Size(319, 23)
        TextBoxPaisOrigenAerolinea.TabIndex = 23
        ' 
        ' TextBoxNombreAerolinea
        ' 
        TextBoxNombreAerolinea.Location = New Point(304, 42)
        TextBoxNombreAerolinea.Margin = New Padding(5)
        TextBoxNombreAerolinea.Name = "TextBoxNombreAerolinea"
        TextBoxNombreAerolinea.Size = New Size(319, 23)
        TextBoxNombreAerolinea.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 104)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(238, 16)
        Label1.TabIndex = 20
        Label1.Text = "Ingrese el nombre del pais de origen :"
        ' 
        ' ButtonAgregarAerolinea
        ' 
        ButtonAgregarAerolinea.Location = New Point(24, 288)
        ButtonAgregarAerolinea.Margin = New Padding(5)
        ButtonAgregarAerolinea.Name = "ButtonAgregarAerolinea"
        ButtonAgregarAerolinea.Size = New Size(167, 39)
        ButtonAgregarAerolinea.TabIndex = 10
        ButtonAgregarAerolinea.Text = "Guardar"
        ButtonAgregarAerolinea.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 46)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 16)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese el nombre de la nueva aerolinea : "
        ' 
        ' NuevaAerolinea
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 736)
        Controls.Add(Label6)
        Controls.Add(ButtonCerrar)
        Controls.Add(GroupBox1)
        Name = "NuevaAerolinea"
        Text = "NuevaAerolinea"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxPaisOrigenAerolinea As TextBox
    Friend WithEvents TextBoxNombreAerolinea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAgregarAerolinea As Button
    Friend WithEvents Label2 As Label
End Class
