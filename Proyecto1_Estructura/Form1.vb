Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar el MenuStrip si es la primera vez que se carga
        MenuCompartido.InitializeMenuStrip()

        ' Agregar el MenuStrip compartido al formulario
        Me.Controls.Add(MenuCompartido.menuStrip)
        Me.MainMenuStrip = MenuCompartido.menuStrip
    End Sub

    Private Sub Button_Cola_Click(sender As Object, e As EventArgs) Handles Button_Cola.Click
        mostrarMensaje("restriccion")
    End Sub

    Private Sub Button_Pila_Click(sender As Object, e As EventArgs) Handles Button_Pila.Click
        Me.Hide()
        Form2.Show()
        Form2.Controls.Add(MenuCompartido.menuStrip)
        Form2.MainMenuStrip = MenuCompartido.menuStrip
    End Sub
End Class
