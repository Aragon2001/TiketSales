Imports System.Runtime.InteropServices
Imports System.Security.AccessControl
Imports Domain

Public Class Login

#Region "Customize Controls - Personalizar Controles"

    Private Sub CustomizeComponents()
        'txtUser
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 30)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 30)
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath = New Drawing2D.GraphicsPath
        Dim myRectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

#End Region

#Region "Close and Minimize Form - Cerrar y Minimizar Formulario"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form - Arrastrar/ mover Formulario"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeComponents()
    End Sub

    Public Sub New()
        InitializeComponent()
        CustomizeComponents()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        IniciarSesion()
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            IniciarSesion()
        End If
    End Sub

    Private Sub IniciarSesion()
        Dim userModel As New UserModel()
        Dim validaLogin = userModel.Login(txtUser.Text, txtPass.Text)
        If validaLogin Then
            Dim frm As New FormPrincipal()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
            Me.Hide()
        Else
            MessageBox.Show("El Usuario o Contraseña es Incorrecto" & vbCrLf & "Por favor inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtPass.Clear()
        txtUser.Clear()
        Me.Show()
        txtUser.Focus()

    End Sub

End Class
