Imports DataAccess

Public Class NuevaAerolinea
    Private Sub ButtonAgregarAerolinea_Click(sender As Object, e As EventArgs) Handles ButtonAgregarAerolinea.Click
        Try
            Dim nombreAerolinea = TextBoxNombreAerolinea.Text
            Dim paisOrigen = TextBoxPaisOrigenAerolinea.Text

            Dim AerolineaDataAccess As New AerolineaDataAccess
            AerolineaDataAccess.InsertarNuevaAerolinea(nombreAerolinea, paisOrigen)

            ' Limpiar los campos después de guardar la información
            TextBoxNombreAerolinea.Text = ""
            TextBoxPaisOrigenAerolinea.Text = ""

            ' Mostrar un mensaje de éxito
            MessageBox.Show("La aerolínea se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Mostrar un mensaje de error
            MessageBox.Show("Error al agregar la aerolínea : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Close()
    End Sub
End Class