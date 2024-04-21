Imports DataAccess

Public Class AgregarVuelo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim idAvion As Integer = ComboBoxIDAvion.Text
            Dim idAerolinea As Integer = ComboBoxBoxlinea.SelectedIndex + 1
            Dim destino As String = TextBoxDestinoVuelo.Text
            Dim horaSalida As DateTime = DateTimePickerHoraSalida.Value
            Dim horaLlegada As DateTime = DateTimePickerHoraLlegada.Value
            Dim precio As Decimal

            If Not Decimal.TryParse(TextBoxPrecio.Text, precio) Then
                MessageBox.Show("Ingrese un valor numerico valido para el precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim nuevoVueloDataAccess As New NuevoVueloDataAccess()
            nuevoVueloDataAccess.InsertarNuevoVuelo(idAvion, idAerolinea, destino, horaSalida, horaLlegada, precio)

            ' Limpiar los campos despues de guardar la informacion
            TextBoxDestinoVuelo.Text = ""
            DateTimePickerHoraSalida.Value = DateTime.Now
            DateTimePickerHoraLlegada.Value = DateTime.Now
            TextBoxPrecio.Text = ""

            ' Mostrar un mensaje de exito
            MessageBox.Show("El vuelo se ha agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Mostrar un mensaje de error
            MessageBox.Show("Error al agregar el vuelo : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class