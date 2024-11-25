Module MenuCompartido

    ' Definir el MenuStrip que será compartido
    Public menuStrip As New MenuStrip()

    ' Sub para inicializar y configurar el MenuStrip
    Public Sub InitializeMenuStrip()
        ' Crear los elementos del menú
        Dim integrantesMenuItem As New ToolStripMenuItem("Mostrar Integrantes")
        Dim salirMenuItem As New ToolStripMenuItem("Salir")

        ' Agregar eventos para los ítems del menú
        AddHandler estudiantesMenuItem.Click, AddressOf Vista Estudiante
        AddHandler cursosMenuItem.Click, AddressOf MostrarIntegrantes
        AddHandler matriculaMenuItem.Click, AddressOf MostrarIntegrantes
        AddHandler salirMenuItem.Click, AddressOf Salir

        ' Agregar los ítems al menú
        menuStrip.Items.Add(integrantesMenuItem)
        menuStrip.Items.Add(integrantesMenuItem)
        menuStrip.Items.Add(integrantesMenuItem)
        menuStrip.Items.Add(salirMenuItem)
    End Sub

    ' Subrutina para el evento "Mostrar Integrantes"
    Private Sub MostrarIntegrantes(ByVal sender As Object, ByVal e As EventArgs)
        mostrarMensaje("integrantes")

    End Sub

    ' Subrutina para el evento "Salir"
    Private Sub Salir(ByVal sender As Object, ByVal e As EventArgs)
        Application.Exit()
    End Sub
End Module
