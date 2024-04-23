<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportesG
    Inherits System.Windows.Forms.Form

    'Descartar reemplazos de Dispose para limpiar la lista de componentes.
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

    ' NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    ' Se puede modificar usando el Diseñador de Windows Forms.  
    ' No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnVuelosDestinos = New Button()
        BtnRecolectadoVentanilla = New Button()
        BtnPasajerosPorVuelo = New Button()
        BtnPasajerosBajados = New Button()
        BtnPasajerosLlegaronDestino = New Button()
        DataGridView1 = New DataGridView()
        cbVuelo = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        cbVentanilla = New ComboBox()
        Label3 = New Label()
        cbEscala = New ComboBox()
        Label4 = New Label()
        cbDestino = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnVuelosDestinos
        ' 
        BtnVuelosDestinos.Location = New Point(2, 12)
        BtnVuelosDestinos.Margin = New Padding(4, 3, 4, 3)
        BtnVuelosDestinos.Name = "BtnVuelosDestinos"
        BtnVuelosDestinos.Size = New Size(163, 41)
        BtnVuelosDestinos.TabIndex = 0
        BtnVuelosDestinos.Text = "Vuelos y Destinos"
        BtnVuelosDestinos.UseVisualStyleBackColor = True
        ' 
        ' BtnRecolectadoVentanilla
        ' 
        BtnRecolectadoVentanilla.Location = New Point(247, 12)
        BtnRecolectadoVentanilla.Margin = New Padding(4, 3, 4, 3)
        BtnRecolectadoVentanilla.Name = "BtnRecolectadoVentanilla"
        BtnRecolectadoVentanilla.Size = New Size(163, 41)
        BtnRecolectadoVentanilla.TabIndex = 1
        BtnRecolectadoVentanilla.Text = "Recolectado por Ventanilla"
        BtnRecolectadoVentanilla.UseVisualStyleBackColor = True
        ' 
        ' BtnPasajerosPorVuelo
        ' 
        BtnPasajerosPorVuelo.Location = New Point(740, 12)
        BtnPasajerosPorVuelo.Margin = New Padding(4, 3, 4, 3)
        BtnPasajerosPorVuelo.Name = "BtnPasajerosPorVuelo"
        BtnPasajerosPorVuelo.Size = New Size(163, 41)
        BtnPasajerosPorVuelo.TabIndex = 2
        BtnPasajerosPorVuelo.Text = "Pasajeros por Vuelo"
        BtnPasajerosPorVuelo.UseVisualStyleBackColor = True
        ' 
        ' BtnPasajerosBajados
        ' 
        BtnPasajerosBajados.Location = New Point(487, 12)
        BtnPasajerosBajados.Margin = New Padding(4, 3, 4, 3)
        BtnPasajerosBajados.Name = "BtnPasajerosBajados"
        BtnPasajerosBajados.Size = New Size(163, 41)
        BtnPasajerosBajados.TabIndex = 3
        BtnPasajerosBajados.Text = "Pasajeros Bajados"
        BtnPasajerosBajados.UseVisualStyleBackColor = True
        ' 
        ' BtnPasajerosLlegaronDestino
        ' 
        BtnPasajerosLlegaronDestino.Location = New Point(972, 12)
        BtnPasajerosLlegaronDestino.Margin = New Padding(4, 3, 4, 3)
        BtnPasajerosLlegaronDestino.Name = "BtnPasajerosLlegaronDestino"
        BtnPasajerosLlegaronDestino.Size = New Size(163, 41)
        BtnPasajerosLlegaronDestino.TabIndex = 4
        BtnPasajerosLlegaronDestino.Text = "Pasajeros Llegaron Destino"
        BtnPasajerosLlegaronDestino.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 247)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(1114, 477)
        DataGridView1.TabIndex = 5
        ' 
        ' cbVuelo
        ' 
        cbVuelo.FormattingEnabled = True
        cbVuelo.Items.AddRange(New Object() {"1", "2"})
        cbVuelo.Location = New Point(161, 114)
        cbVuelo.Name = "cbVuelo"
        cbVuelo.Size = New Size(121, 23)
        cbVuelo.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 7
        Label1.Text = "Numero de Vuelo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 15)
        Label2.TabIndex = 8
        Label2.Text = "Numero de ventanilla"
        ' 
        ' cbVentanilla
        ' 
        cbVentanilla.FormattingEnabled = True
        cbVentanilla.Items.AddRange(New Object() {"1", "2"})
        cbVentanilla.Location = New Point(161, 165)
        cbVentanilla.Name = "cbVentanilla"
        cbVentanilla.Size = New Size(121, 23)
        cbVentanilla.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(369, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 11
        Label3.Text = "Escala en:"
        ' 
        ' cbEscala
        ' 
        cbEscala.FormattingEnabled = True
        cbEscala.Items.AddRange(New Object() {"1", "2"})
        cbEscala.Location = New Point(511, 117)
        cbEscala.Name = "cbEscala"
        cbEscala.Size = New Size(121, 23)
        cbEscala.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(369, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 13
        Label4.Text = "Destino:"
        ' 
        ' cbDestino
        ' 
        cbDestino.FormattingEnabled = True
        cbDestino.Items.AddRange(New Object() {"1", "2"})
        cbDestino.Location = New Point(511, 165)
        cbDestino.Name = "cbDestino"
        cbDestino.Size = New Size(121, 23)
        cbDestino.TabIndex = 12
        ' 
        ' ReportesG
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 736)
        Controls.Add(Label4)
        Controls.Add(cbDestino)
        Controls.Add(Label3)
        Controls.Add(cbEscala)
        Controls.Add(cbVentanilla)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbVuelo)
        Controls.Add(DataGridView1)
        Controls.Add(BtnPasajerosLlegaronDestino)
        Controls.Add(BtnPasajerosBajados)
        Controls.Add(BtnPasajerosPorVuelo)
        Controls.Add(BtnRecolectadoVentanilla)
        Controls.Add(BtnVuelosDestinos)
        Margin = New Padding(4, 3, 4, 3)
        Name = "ReportesG"
        Text = "Reportes Generales"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents BtnVuelosDestinos As Button
    Friend WithEvents BtnRecolectadoVentanilla As Button
    Friend WithEvents BtnPasajerosPorVuelo As Button
    Friend WithEvents BtnPasajerosBajados As Button
    Friend WithEvents BtnPasajerosLlegaronDestino As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbVuelo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbVentanilla As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEscala As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDestino As ComboBox
End Class
