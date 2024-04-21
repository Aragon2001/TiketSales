
Imports data
Imports System.Data.SqlClient
Imports Common
Imports DataAccess
Imports Domain
Public Class Ventanilla
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
        ComboBoxLinea_Aereas.Text = ActiveUser.lineaaerea
        TextBoxNombre_Emple.Enabled = False
        TextBoxCedula_Empl.Enabled = False
        ComboBoxLinea_Aereas.Enabled = False
        BtnNuevaVentanilla.Enabled = False
        GroupBoxPasajero.Enabled = False
        BtnConfirmarCompra.Enabled = False
        ButtonBorrarP.Enabled = False
        logo()

    End Sub

    Private Sub btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles btn_VolverMenu.Click
        Me.Close()
    End Sub

    Private Sub ComboBoxNumeroDeAsiento_ValueChanged(sender As Object, e As EventArgs) Handles ComboBoxNumeroDeAsiento.ValueChanged

    End Sub

    Private Sub BtnConfirmarVentanilla_Click(sender As Object, e As EventArgs) Handles BtnConfirmarVentanilla.Click
        confirmarVentanilla()
    End Sub

    Private Sub BtnNuevaVentanilla_Click(sender As Object, e As EventArgs) Handles BtnNuevaVentanilla.Click
        cambiarVentanilla()
    End Sub


    Private Sub confirmarVentanilla()
        VentanillaAbierta.Cedula_Empleado = TextBoxCedula_Empl.Text
        VentanillaAbierta.Nombre_empleado = TextBoxNombre_Emple.Text
        VentanillaAbierta.NumeroVentanilla = TextBoxNumVentanilla.Text
        VentanillaAbierta.Linea_aerea = ComboBoxLinea_Aereas.SelectedItem
        VentanillaAbierta.fecha = DateTimeVentanilla.Text
        ComboBoxID_Ventanilla.Enabled = False
        BtnConfirmarVentanilla.Enabled = False
        BtnNuevaVentanilla.Enabled = True
        BtnConfirmarCompra.Enabled = True
        ButtonBorrarP.Enabled = True
        GroupBoxPasajero.Enabled = True

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

    Public Sub borrarPasajero()
        TextBoxNacionalidad.Clear()
        TextBoxNombrePasajero.Clear()
        TextBoxNumeroDePasaporte.Clear()
        ComboBoxDestino.Text = ""
    End Sub

    Private Sub ButtonBorrarP_Click(sender As Object, e As EventArgs) Handles ButtonBorrarP.Click
        borrarPasajero()
    End Sub


    Private Sub logo()
        ComboBoxLinea_Aereas.Enabled = True
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
        VM.ConfirmarVentanilla(NumeroVentanilla:=VentanillaAbierta.NumeroVentanilla,
                               Nombre_empleado:=VentanillaAbierta.Nombre_empleado,
                               Cedula_Empleado:=VentanillaAbierta.Cedula_Empleado,
                               Hora_Apertura:=VentanillaAbierta.Hora_Apertura,
                               Linea_aerea:=VentanillaAbierta.Linea_aerea,
                               Fecha:=VentanillaAbierta.fecha)
        'VM.GuardarPasajero(Nombre:=TextBoxNombrePasajero.Text,
        '                   Num_identificacion:=TextBoxNumeroDePasaporte.Text,
        '                   Apellido1:=txtapellido1.Text,
        '                   Apellido2:=txtApellido2,
        '                   Destino:=ComboBoxDestino.SelectedItem,
        '                   Hora_atencion:=h, Fecha_salida, Nacionalidad)

        'VM.GuardarVenta(ID_pasajero, ID_avion, Hora_venta, Monto_total, Num_identificacion, ID_vuelo)

    End Sub
End Class
