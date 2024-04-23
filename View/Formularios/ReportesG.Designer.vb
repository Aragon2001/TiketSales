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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
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
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2"})
        ComboBox1.Location = New Point(82, 114)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 7
        Label1.Text = "Label1"
        ' 
        ' ReportesG
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1138, 736)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
