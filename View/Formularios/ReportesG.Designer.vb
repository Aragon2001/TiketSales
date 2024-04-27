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
        Label4 = New Label()
        cbDestino = New ComboBox()
        btnTiketes = New Button()
        Label5 = New Label()
        cbTiketsN = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnVuelosDestinos
        ' 
        BtnVuelosDestinos.Location = New Point(24, 12)
        BtnVuelosDestinos.Margin = New Padding(4, 3, 4, 3)
        BtnVuelosDestinos.Name = "BtnVuelosDestinos"
        BtnVuelosDestinos.Size = New Size(215, 41)
        BtnVuelosDestinos.TabIndex = 0
        BtnVuelosDestinos.Text = "Vuelos y Destinos"
        BtnVuelosDestinos.UseVisualStyleBackColor = True
        ' 
        ' BtnRecolectadoVentanilla
        ' 
        BtnRecolectadoVentanilla.Location = New Point(349, 12)
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
        BtnPasajerosBajados.Location = New Point(551, 12)
        BtnPasajerosBajados.Margin = New Padding(4, 3, 4, 3)
        BtnPasajerosBajados.Name = "BtnPasajerosBajados"
        BtnPasajerosBajados.Size = New Size(163, 41)
        BtnPasajerosBajados.TabIndex = 3
        BtnPasajerosBajados.Text = "Pasajeros Bajados"
        BtnPasajerosBajados.UseVisualStyleBackColor = True
        ' 
        ' BtnPasajerosLlegaronDestino
        ' 
        BtnPasajerosLlegaronDestino.Location = New Point(349, 117)
        BtnPasajerosLlegaronDestino.Margin = New Padding(4, 3, 4, 3)
        BtnPasajerosLlegaronDestino.Name = "BtnPasajerosLlegaronDestino"
        BtnPasajerosLlegaronDestino.Size = New Size(192, 41)
        BtnPasajerosLlegaronDestino.TabIndex = 4
        BtnPasajerosLlegaronDestino.Text = "Pasajeros Llegaron Destino"
        BtnPasajerosLlegaronDestino.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 247)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(1114, 477)
        DataGridView1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(352, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 13
        Label4.Text = "Destino:"
        ' 
        ' cbDestino
        ' 
        cbDestino.FormattingEnabled = True
        cbDestino.Items.AddRange(New Object() {"1", "2"})
        cbDestino.Location = New Point(420, 182)
        cbDestino.Name = "cbDestino"
        cbDestino.Size = New Size(121, 23)
        cbDestino.TabIndex = 12
        ' 
        ' btnTiketes
        ' 
        btnTiketes.Location = New Point(22, 117)
        btnTiketes.Margin = New Padding(4, 3, 4, 3)
        btnTiketes.Name = "btnTiketes"
        btnTiketes.Size = New Size(214, 41)
        btnTiketes.TabIndex = 14
        btnTiketes.Text = "Tiquetes"
        btnTiketes.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 16
        Label5.Text = "# Tikets:"
        ' 
        ' cbTiketsN
        ' 
        cbTiketsN.FormattingEnabled = True
        cbTiketsN.Items.AddRange(New Object() {"1", "2"})
        cbTiketsN.Location = New Point(115, 182)
        cbTiketsN.Name = "cbTiketsN"
        cbTiketsN.Size = New Size(121, 23)
        cbTiketsN.TabIndex = 15
        ' 
        ' ReportesG
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 736)
        Controls.Add(Label5)
        Controls.Add(cbTiketsN)
        Controls.Add(btnTiketes)
        Controls.Add(Label4)
        Controls.Add(cbDestino)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDestino As ComboBox
    Friend WithEvents btnTiketes As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTiketsN As ComboBox
End Class
