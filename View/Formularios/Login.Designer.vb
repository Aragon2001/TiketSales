<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        titleBar = New Panel()
        btnMinimize = New PictureBox()
        btnClose = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        Label2 = New Label()
        btnLogin = New Button()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        titleBar.SuspendLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' titleBar
        ' 
        titleBar.AutoSize = True
        titleBar.BackColor = Color.FromArgb(CByte(36), CByte(43), CByte(73))
        titleBar.Controls.Add(btnMinimize)
        titleBar.Controls.Add(btnClose)
        titleBar.Dock = DockStyle.Top
        titleBar.Location = New Point(0, 0)
        titleBar.Margin = New Padding(4, 3, 4, 3)
        titleBar.Name = "titleBar"
        titleBar.Size = New Size(414, 31)
        titleBar.TabIndex = 0
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), Image)
        btnMinimize.Location = New Point(351, 12)
        btnMinimize.Margin = New Padding(4, 3, 4, 3)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(16, 16)
        btnMinimize.SizeMode = PictureBoxSizeMode.AutoSize
        btnMinimize.TabIndex = 10
        btnMinimize.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(385, 12)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(16, 16)
        btnClose.SizeMode = PictureBoxSizeMode.AutoSize
        btnClose.TabIndex = 9
        btnClose.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(151, 47)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 161)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(38, 258)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 21)
        Label1.TabIndex = 2
        Label1.Text = "Usuario"
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        txtUser.BorderStyle = BorderStyle.None
        txtUser.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        txtUser.ForeColor = Color.WhiteSmoke
        txtUser.Location = New Point(43, 285)
        txtUser.Margin = New Padding(4, 3, 4, 3)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(324, 21)
        txtUser.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        txtPass.BorderStyle = BorderStyle.None
        txtPass.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        txtPass.ForeColor = Color.WhiteSmoke
        txtPass.Location = New Point(43, 355)
        txtPass.Margin = New Padding(4, 3, 4, 3)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(324, 21)
        txtPass.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(38, 327)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 21)
        Label2.TabIndex = 4
        Label2.Text = "Contraseña"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(16), CByte(103), CByte(242))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Ebrima", 12F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(43, 414)
        btnLogin.Margin = New Padding(4, 3, 4, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(324, 47)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Iniciar"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkGray
        Label3.Location = New Point(129, 595)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 19)
        Label3.TabIndex = 8
        Label3.Text = "Olvide mi Contraseña"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        Panel1.Location = New Point(0, 582)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 10)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(36), CByte(43), CByte(73))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 627)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(414, 12)
        Panel2.TabIndex = 10
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(414, 639)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(Label2)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(titleBar)
        Font = New Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Login"
        Opacity = 0.95R
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        titleBar.ResumeLayout(False)
        titleBar.PerformLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents titleBar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents Panel2 As Panel
End Class
