Imports DataAccess

Public Class AgregarAvion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tieneEscala As Boolean

        ' Determinar si el RadioButtonSiEscala está seleccionado
        If RadioButtonSiEscala.Checked Then
            tieneEscala = True
        ElseIf RadioButtonNoEscala.Checked Then
            tieneEscala = False
        End If

        Dim ciudadesEscala As String = ""

        ' Si tiene escala, obtener las ciudades de escala
        If tieneEscala Then
            ' Suponiendo que tienes una forma de obtener las ciudades de escala, puedes asignarlas a ciudadesEscala
            ' Por ejemplo, si las ciudades de escala están en un TextBox separadas por coma:
            ciudadesEscala = TextBoxCiudadesEscala.Text
        End If

        Dim nuevoAvionDataAccess As New NuevoAvionDataAccess()
        nuevoAvionDataAccess.InsertarNuevoAvion(TextBoxmarca.Text, TextBoxlinea.SelectedIndex + 1, Convert.ToInt32(TextBoxcapacidad.Text), TextBoxnombre_piloto.Text, TextBoxCiudadOrigen.Text, TextBoxCiudadDestino.Text, DateTimePickerHoraSalida.Value, DateTimePickerHoraLlegada.Value, tieneEscala, ciudadesEscala)

        ' Limpiar los TextBox después de guardar la información
        TextBoxmarca.Text = ""
        TextBoxlinea.SelectedIndex = -1 ' Reiniciar el ComboBox a su estado inicial
        TextBoxcapacidad.Text = ""
        TextBoxnombre_piloto.Text = ""
        TextBoxCiudadOrigen.Text = ""
        TextBoxCiudadDestino.Text = ""
        TextBoxCiudadesEscala.Text = "" ' Limpiar el TextBox de ciudades de escala si lo hubiera

        ' Reiniciar los RadioButton
        RadioButtonSiEscala.Checked = False
        RadioButtonNoEscala.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class