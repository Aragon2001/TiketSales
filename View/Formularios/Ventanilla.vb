
Imports data
Imports System.Data.SqlClient
Imports Common
Imports DataAccess
Imports Domain
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class cbAsiento
    Dim VM As New VentanillaModel()
#Region "Diseño de botones"
    Private Sub BtnConfirmarCompra_Paint(sender As Object, e As PaintEventArgs) Handles BtnConfirmarCompra.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = BtnConfirmarCompra.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        BtnConfirmarCompra.Region = New Region(buttonPath)
    End Sub
    Private Sub btn_VolverMenu_Paint(sender As Object, e As PaintEventArgs) Handles btn_VolverMenu.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btn_VolverMenu.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        btn_VolverMenu.Region = New Region(buttonPath)
    End Sub
    Private Sub BtnConfirmarVentanilla_Paint(sender As Object, e As PaintEventArgs) Handles BtnConfirmarVentanilla.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = BtnConfirmarVentanilla.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        BtnConfirmarVentanilla.Region = New Region(buttonPath)
    End Sub
    Private Sub BtnNuevaVentanilla_Paint(sender As Object, e As PaintEventArgs) Handles BtnNuevaVentanilla.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = BtnNuevaVentanilla.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        BtnNuevaVentanilla.Region = New Region(buttonPath)
    End Sub
    Private Sub ButtonBorrarP_Paint(sender As Object, e As PaintEventArgs) Handles ButtonBorrarP.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = ButtonBorrarP.ClientRectangle
        myRectangle.Inflate(0, 15)
        buttonPath.AddEllipse(myRectangle)
        ButtonBorrarP.Region = New Region(buttonPath)
    End Sub

#End Region

    Private Sub Ventanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxNombre_Emple.Text = ActiveUser.nombre
        TextBoxCedula_Empl.Text = ActiveUser.identificacion
        txtLA.Text = ActiveUser.lineaaerea
        TextBoxNombre_Emple.Enabled = False
        TextBoxCedula_Empl.Enabled = False
        txtLA.Enabled = False
        BtnNuevaVentanilla.Enabled = False
        GroupBoxPasajero.Enabled = False
        BtnConfirmarCompra.Enabled = False
        ButtonBorrarP.Enabled = False

        logo()
        CargarDestinos()


    End Sub

    Private Sub btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles btn_VolverMenu.Click
        Me.Close()
    End Sub
    Private Sub TimerActualizarHora_Tick(sender As Object, e As EventArgs) Handles TimerActualizarHora.Tick
        ' Actualizar el contenido del Label con la fecha y hora actual
        lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub ComboBoxNumeroDeAsiento_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnConfirmarVentanilla_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        If ComboBoxID_Ventanilla.SelectedItem Is Nothing Then
            MessageBox.Show("Debe seleccionar la ventanilla para poder iniciar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            confirmarVentanilla()
        End If

    End Sub

    Private Sub BtnNuevaVentanilla_Click(sender As Object, e As EventArgs) Handles BtnNuevaVentanilla.Click
        cambiarVentanilla()
        borrarPasajero()
        limpiarVuelo()
        GroupBoxOrigen.Enabled = False

    End Sub


    Private Sub confirmarVentanilla()
        VentanillaAbierta.Cedula_Empleado = TextBoxCedula_Empl.Text
        VentanillaAbierta.Nombre_empleado = TextBoxNombre_Emple.Text
        VentanillaAbierta.NumeroVentanilla = ComboBoxID_Ventanilla.SelectedItem
        VentanillaAbierta.apellido1 = txtapellido1.Text
        VentanillaAbierta.apellido2 = txtApellido2.Text
        VentanillaAbierta.Linea_aerea = txtLA.Text
        VentanillaAbierta.fecha = lblFechaHora.Text
        ComboBoxID_Ventanilla.Enabled = False
        BtnConfirmarVentanilla.Enabled = False
        BtnNuevaVentanilla.Enabled = True
        BtnConfirmarCompra.Enabled = True
        ButtonBorrarP.Enabled = True
        GroupBoxPasajero.Enabled = True


    End Sub

    Public Sub DatosPasajeros()
        VentanillaAbierta.nombrePasajero = TextBoxNombrePasajero.Text
        VentanillaAbierta.passport = TextBoxNumeroDePasaporte.Text
        VentanillaAbierta.destino = cbDestinos.SelectedItem.ToString
        VentanillaAbierta.nacionalidadPasajero = TextBoxNacionalidad.Text
        VentanillaAbierta.apellido1 = txtapellido1.Text
        VentanillaAbierta.apellido2 = txtApellido2.Text
        VentanillaAbierta.fecha = lblFechaHora.Text
        VentanillaAbierta.FechaSalida = DTFechaSalida.Value

    End Sub

    Public Sub DatosTiquetes()

    End Sub
    Public Sub cambiarVentanilla()
        ComboBoxID_Ventanilla.Enabled = True
        VentanillaAbierta.Cedula_Empleado = ""
        VentanillaAbierta.Nombre_empleado = ""
        VentanillaAbierta.NumeroVentanilla = ""
        VentanillaAbierta.Linea_aerea = ""
        VentanillaAbierta.fecha = ""
        BtnConfirmarVentanilla.Enabled = True
        BtnNuevaVentanilla.Enabled = False
        BtnConfirmarCompra.Enabled = False
        ButtonBorrarP.Enabled = False
        GroupBoxPasajero.Enabled = False
    End Sub
    Public Sub limpiarVuelo()
        TextBoxOrigen.Clear()
        DTFechaSalida.ResetText()
        TextBoxHoraLlegada.Clear()
        TextBoxNumVentanilla.Clear()
        TextBoxEscala.Clear()
        TextBoxPrecioTiquete.Clear()
        cbAsientos.SelectedItem = Nothing
        escalaNo.Checked = False
        escalaSi.Checked = False
        TextBoxHoraSalida.Clear()



    End Sub

    Public Sub borrarPasajero()
        TextBoxNacionalidad.Clear()
        TextBoxNombrePasajero.Clear()
        TextBoxNumeroDePasaporte.Clear()
        txtapellido1.Clear()
        txtApellido2.Clear()
        cbDestinos.SelectedItem = Nothing

    End Sub

    Private Sub ButtonBorrarP_Click(sender As Object, e As EventArgs) Handles ButtonBorrarP.Click
        borrarPasajero()
        limpiarVuelo()
        GroupBoxOrigen.Enabled = False

    End Sub


    Private Sub logo()

        If ActiveUser.lineaaerea.ToString IsNot Nothing Then
            Dim selectedAerolinea As String = ActiveUser.lineaaerea.ToString

            Select Case selectedAerolinea
                Case "British Airways"
                    Dim imagePath As String = "C:\Users\emanu\OneDrive - UACA Cipreses S.A\Cursos Ingenieria en Sistemas\Programacion 3 VB.net\VentaTiketes\View\Logo Aerolineas\British-Airways-Logo.png"
                    Dim image As Image = Image.FromFile(imagePath)
                    PictureBox1.Image = image

                    ' Agrega más casos para otras aerolíneas si es necesario
                    ' Case "Otra aerolínea"
                    '     Dim otraImagePath As String = "Ruta a la imagen de la otra aerolínea"
                    '     Dim otraImage As Image = Image.FromFile(otraImagePath)
                    '     PictureBox1.Image = otraImage

                Case Else
                    ' Acción por defecto si no se encuentra una coincidencia
                    ' Puede ser dejar la imagen en blanco o mostrar un mensaje de error
                    PictureBox1.Image = Nothing
                    MessageBox.Show("Aerolínea no reconocida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
    End Sub

    Private Sub BtnConfirmarCompra_Click(sender As Object, e As EventArgs) Handles BtnConfirmarCompra.Click
        Try
            ' Verificar si algún campo está vacío
            If String.IsNullOrEmpty(TextBoxNombrePasajero.Text) Then
                Throw New Exception("El campo Nombre está vacío.")
            End If

            If String.IsNullOrEmpty(TextBoxNumeroDePasaporte.Text) Then
                Throw New Exception("El campo Numero de Pasaporte está vacío.")
            End If

            If String.IsNullOrEmpty(txtapellido1.Text) Then
                Throw New Exception("El campo Apellido está vacío.")
            End If

            If String.IsNullOrEmpty(txtApellido2.Text) Then
                Throw New Exception("El campo Apellido está vacío.")
            End If

            If String.IsNullOrEmpty(TextBoxNacionalidad.Text) Then
                Throw New Exception("El campo Nacionalidad está vacío.")
            End If




            ' Si no se encuentra ningún campo vacío, llamar a la función GuardarVenta


            DatosPasajeros()
            DatosTiquetes()


            ' Crear una instancia de la clase Ventanilla_DB
            Dim ventanillaDB As New Ventanilla_DB()
                ventanillaDB.GuardarVentanilla()
                ventanillaDB.GuardarPasajero()
                ventanillaDB.GuardarVenta()
                ventanillaDB.GuardarTiquete()



                Dim result As DialogResult = MessageBox.Show("Venta guardada exitosamente. ¿Desea imprimir la venta?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    borrarPasajero()
                    limpiarVuelo()
                    GroupBoxOrigen.Enabled = False
                Else
                    borrarPasajero()
                    limpiarVuelo()
                    GroupBoxOrigen.Enabled = False
                End If



            Catch ex As Exception
                ' Mostrar mensaje de alerta
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try



    End Sub



    Public Sub CargarDestinos()
        ' Crear una instancia de la clase Ventanilla_DB
        Dim ventanillaDB As New Ventanilla_DB()

        ' Obtener la lista de destinos desde la base de datos
        Dim destinos As List(Of String) = ventanillaDB.ObtenerDestinos()

        ' Limpiar el ComboBox antes de agregar los nuevos destinos
        cbDestinos.Items.Clear()

        ' Agregar los destinos al ComboBox
        For Each destino As String In destinos
            cbDestinos.Items.Add(destino)
        Next
    End Sub
    Public Sub CargarAsientosDisponiblesPorDestino(destino As String)
        Try
            ' Limpiar el ComboBox antes de cargar los nuevos datos
            cbAsientos.Items.Clear()

            ' Crear una instancia de la clase Ventanilla_DB
            Dim ventanillaDB As New Ventanilla_DB()

            ' Obtener los asientos disponibles para el destino especificado
            Dim asientosDisponibles As List(Of String) = ventanillaDB.ObtenerAsientosDisponiblesPorDestino(destino)

            ' Agregar los asientos al ComboBox
            For Each asiento As String In asientosDisponibles
                cbAsientos.Items.Add(asiento)
            Next

            ' Seleccionar el primer asiento si hay al menos uno disponible
            If asientosDisponibles.Count > 0 Then
                cbAsientos.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir al cargar los asientos
            MessageBox.Show("Error al cargar los asientos disponibles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cbDestinos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDestinos.SelectedIndexChanged
        ' Verificar si se ha seleccionado un destino
        If cbDestinos.SelectedIndex <> -1 Then
            ' Obtener el destino seleccionado
            Dim destinoSeleccionado As String = cbDestinos.SelectedItem.ToString()

            ' Crear una instancia de la clase Ventanilla_DB
            Dim ventanillaDB As New Ventanilla_DB()

            ' Obtener los detalles de los vuelos correspondientes al destino seleccionado
            ventanillaDB.ObtenerDetallesVuelosPorDestino(destinoSeleccionado)


            ' Verificar si se encontraron detalles de vuelos
            If cbDestinos IsNot Nothing Then
                ' Mostrar los detalles de vuelos en los campos del formulario
                GroupBoxOrigen.Enabled = True
                MostrarDetallesVuelos()
                CargarAsientosDisponiblesPorDestino(cbDestinos.SelectedItem.ToString)
            Else
                ' Limpiar los campos del formulario si no se encontraron detalles de vuelos
                LimpiarCampos()
            End If
        End If
    End Sub

    Private Sub MostrarDetallesVuelos()


        ' Mostrar los detalles del vuelo en los campos del formulario
        cbAsientos.Text = VentanillaAbierta.NumeroAsiento
        TextBoxHoraSalida.Text = VentanillaAbierta.HoraSalida.ToString()
        TextBoxNumVentanilla.Text = VentanillaAbierta.NumeroVentanilla
        'TextBoxEscala.Text = VentanillaAbierta.Escala
        'TextBoxFechaSalida.Text = VentanillaAbierta.FechaSalida.ToString()
        TextBoxHoraLlegada.Text = VentanillaAbierta.HoraLlegada.ToString()
        TextBoxOrigen.Text = VentanillaAbierta.Origen
        TextBoxPrecioTiquete.Text = Convert.ToDecimal(VentanillaAbierta.PrecioTiquete).ToString("C")
        TextBoxOrigen.Text = VentanillaAbierta.CiudadOrigen.ToString()
        TextBoxNumVentanilla.Text = ComboBoxID_Ventanilla.SelectedItem.ToString

        If VentanillaAbierta.Escala = 0 Then
            escalaNo.Checked = True
            TextBoxEscala.Text = "Sin Escala"
        Else
            escalaSi.Checked = True
            TextBoxEscala.Text = VentanillaAbierta.LugarEscala
        End If

        ' Puedes seguir llenando los otros campos del formulario con los datos del detalle de vuelo
    End Sub


    Private Sub LimpiarCampos()
        '' Limpiar los campos del formulario
        'cbAsientos.Text = ""
        '' Continuar con los demás campos...
    End Sub

    Private Sub TextBoxNumeroDePasaporte_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBoxNumeroDePasaporte.KeyPress
        ' Verificar si la tecla presionada no es un número o una tecla de control
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, cancelar la pulsación de tecla
            e.Handled = True
        End If
    End Sub
End Class
