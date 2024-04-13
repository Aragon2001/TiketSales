Public Class Ventanilla
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

    End Sub

    Private Sub btn_VolverMenu_Click(sender As Object, e As EventArgs) Handles btn_VolverMenu.Click
        Me.Close()
    End Sub
End Class
