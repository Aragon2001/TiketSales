Imports System.Runtime.InteropServices
Imports Common

Public Class FormPrincipal
#Region "FUNCIONALIDADES DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Esta seguro que desea cerrar el programa?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Application.Exit()
        End If

    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub



    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub
#End Region

    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            'PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        AbrirFormEnPanel(Of Usuarios)()
        btnUsuarios.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnVentanilla_Click(sender As Object, e As EventArgs) Handles btnVentanilla.Click
        AbrirFormEnPanel(Of Ventanilla)()
        btnVentanilla.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnReporte_click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(Of Reporte)()
        btnReporte.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
    'METODO/EVENTO AL CERRAR FORMS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If (Application.OpenForms("Form1") Is Nothing) Then
            btnUsuarios.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form2") Is Nothing) Then
            btnVentanilla.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            btnReporte.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            btnReporte.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            btnReporte.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        lblUsuarioActivo.Text = nombre
        lblIdentificacion.Text = identificacion
        lblemail.Text = email
        If tipo = 0 Then
            lblUser.Text = lblUser.Text + " Admin"

        Else
            lblUser.Text = lblUser.Text + " Vendedor"
            btnReporte.Visible = False
            btnAddPlane.Visible = False
            btnAddVuelo.Visible = False
            btnUsuarios.Visible = False
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("¿Desea cerrar la session actual?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub linkEditarPerfil_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkEditarPerfil.LinkClicked
        AbrirFormEnPanel(Of Usuarios)()
    End Sub

    Private Sub btnAddVuelo_Click(sender As Object, e As EventArgs) Handles btnAddVuelo.Click
        AbrirFormEnPanel(Of AgregarVuelo)()
    End Sub

    Private Sub btnAddPlane_Click(sender As Object, e As EventArgs) Handles btnAddPlane.Click
        AbrirFormEnPanel(Of AgregarAvion)()
    End Sub
End Class
'#3D73FF