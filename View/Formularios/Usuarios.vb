Imports Domain
Imports Common
Imports DataAccess

Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        CargarLineasAereas()
    End Sub
    Private Sub CargarLineasAereas()
        Dim aerolineaDataAccess As New AerolineaDataAccess()
        Dim lineasAereas As List(Of Aerolinea) = aerolineaDataAccess.ObtenerLineasAereas

        ' Limpiar el ComboBox
        cbLineaAerea.Items.Clear()

        ' Agregar las líneas aéreas al ComboBox
        For Each aerolinea As Aerolinea In lineasAereas
            cbLineaAerea.Items.Add(aerolinea.Nombre)
        Next
    End Sub



    Private Sub LoadUserData()
        ' View
        lblApellido1.Text = ActiveUser.apellido1
        lblapellido2.Text = ActiveUser.apellido2
        lblemail.Text = ActiveUser.email
        lblidentificacion.Text = ActiveUser.identificacion
        lblnombre.Text = ActiveUser.nombre

        If ActiveUser.tipo = 0 Then
            lblrol.Text = "Administrador"
            btnAgregarUsuario.Visible = True
        Else
            lblrol.Text = "Vendedor"
            btnEditarMiPerfil.Visible = False
            PanelTipo.Visible = False
            Panel2.Enabled = True
            LoadDatosEdicion()
        End If
    End Sub

    Public Sub LoadPass()
        txtPass.Text = ActiveUser.pass
        TxtConf_Pass.Text = ActiveUser.pass
    End Sub

    Public Sub LoadDatosEdicion()
        txtIdentificacion.Text = ActiveUser.identificacion
        txtnombre.Text = ActiveUser.nombre
        txtap1.Text = ActiveUser.apellido1
        txtap2.Text = ActiveUser.apellido2
        txtemail.Text = ActiveUser.email
        txtPass.Text = ActiveUser.pass
        TxtConf_Pass.Text = ActiveUser.pass
        cbLineaAerea.Text = ActiveUser.lineaaerea

        Panel2.Enabled = True

        If ActiveUser.tipo = 0 Then
            rbSI.Checked = True
        Else
            rbNO.Checked = True
        End If
    End Sub

    Private Sub btnEditarMiPerfil_Click(sender As Object, e As EventArgs) Handles btnEditarMiPerfil.Click
        txtIdentificacion.Enabled = False
        PanelTipo.Visible = False
        LoadDatosEdicion()
    End Sub

    Public Sub Reset()
        LoadUserData()
        InicializarEditarPassword()
        LoadPass()
    End Sub

    Private Sub InicializarEditarPassword()
        txtPass.UseSystemPasswordChar = True
        txtPass.Enabled = False
        TxtConf_Pass.UseSystemPasswordChar = True
        TxtConf_Pass.Enabled = False
        txtPass_Actual.Text = ""
        LinkEditar.Text = "Editar"
    End Sub

    Private Sub LinkEditar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEditar.LinkClicked
        If LinkEditar.Text = "Editar" Then
            LinkEditar.Text = "Cancelar"
            txtPass.Text = ""
            txtPass.Enabled = True
            TxtConf_Pass.Enabled = True
            TxtConf_Pass.Text = ""
        ElseIf LinkEditar.Text = "Cancelar" Then
            Reset()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Reset()
        Panel2.Enabled = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If btnguardar.Text = "Guardar" Then
            editar()

        End If
        If btnguardar.Text = "Agregar" Then
            agregar()
            btnguardar.Text = "Guardar"
            Panel2.Enabled = False
            Label8.Text = "Editar Datos"


        End If
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Panel2.Enabled = True
        btnguardar.Text = "Agregar"
        Label11.Visible = False
        txtPass_Actual.Visible = False
        LinkEditar.Visible = False
        txtPass.Enabled = True
        TxtConf_Pass.Enabled = True
        rbNO.Checked = True
        Label8.Text = "Agregar Datos"

    End Sub
    Public Sub agregar()
        Dim tipo As Integer

        If txtPass.Text = TxtConf_Pass.Text Then
            If rbSI.Checked Then
                tipo = 0
            Else
                tipo = 1
            End If

            Dim userModel As New UserModel()

            ' Agregar un nuevo usuario
            Dim result = userModel.agregarUser(txtIdentificacion.Text, txtPass.Text, txtnombre.Text, txtap1.Text, txtap2.Text, txtemail.Text, tipo, cbLineaAerea.SelectedItem)
            MessageBox.Show(result)

            ' Limpiar los campos del formulario después de agregar el usuario
            LimpiarCampos()
        Else
            MessageBox.Show("Las contraseñas no coinciden, inténtelo de nuevo")
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtIdentificacion.Text = ""
        txtPass.Text = ""
        TxtConf_Pass.Text = ""
        txtnombre.Text = ""
        txtap1.Text = ""
        txtap2.Text = ""
        txtemail.Text = ""
        rbSI.Checked = False
        rbNO.Checked = False
    End Sub

    Public Sub editar()
        Dim tipo As Integer

        If txtPass.Text = TxtConf_Pass.Text Then
            If rbSI.Checked Then
                tipo = 0
            Else
                tipo = 1
            End If

            If txtPass_Actual.Text = ActiveUser.pass Then
                Dim userModel As New UserModel()

                ' Actualizar perfil del usuario
                Dim result = userModel.editarPerfilUser(txtIdentificacion.Text,
                                                         txtPass.Text,
                                                         txtnombre.Text,
                                                         txtap1.Text,
                                                         txtap2.Text,
                                                         txtemail.Text,
                                                         tipo,
                                                         cbLineaAerea.SelectedItem)
                MessageBox.Show(result)

                ' Volver a cargar los datos del usuario en el formulario
                LoadUserData()
                InicializarEditarPassword()
            Else
                MessageBox.Show("La contraseña actual es incorrecta, inténtelo de nuevo")
            End If
        Else
            MessageBox.Show("Las contraseñas no coinciden, inténtelo de nuevo")
        End If
    End Sub

    Private Sub cbLineaAerea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLineaAerea.SelectedIndexChanged

    End Sub
End Class
