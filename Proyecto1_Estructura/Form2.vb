Public Class Form2
    Dim pila(5) As Integer
    Dim tope As Integer = -1
    Dim Procesos As New Procesos()

    ' Insertar valor en la pila
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim valor As Integer
        ' Verificar si el valor ingresado es un número válido entre 01 y 99
        If Integer.TryParse(txtNumero.Text, valor) AndAlso valor >= 1 AndAlso valor <= 99 Then
            If Procesos.Insertar(pila, tope, valor) Then
                MessageBox.Show("Valor " & valor & " insertado en la pila.", "Inserción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNumero.Clear()  ' Limpiar el cuadro de texto después de insertar el valor
            Else
                MessageBox.Show("La pila está llena. No se puede insertar más elementos.")
                txtNumero.Clear()
            End If
        Else
            MessageBox.Show("Por favor, ingrese un número válido entre 01 y 99.")
        End If


    End Sub

    ' Eliminar valor de la pila
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If tope >= 0 Then
            ' Guardar el valor del tope antes de eliminarlo
            Dim valorEliminado As Integer = pila(tope)

            ' Llamar al método Eliminar de la clase Procesos
            If Procesos.Eliminar(pila, tope) Then
                ' Mostrar un mensaje de confirmación de eliminación
                MessageBox.Show("Valor " & valorEliminado & " eliminado de la pila.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("La pila está vacía. No hay elementos para eliminar.")
            End If
        End If

    End Sub

    ' Mostrar el estado actual de la pila en una ventana flotante
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim resultado As String = Procesos.Mostrar(pila, tope)
        MessageBox.Show(resultado, "Estado de la Pila", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button_Atras_Click(sender As Object, e As EventArgs) Handles Button_Atras.Click
        Me.Hide()
        Form1.Show()

        Form1.Controls.Add(MenuCompartido.menuStrip)
        Form1.MainMenuStrip = MenuCompartido.menuStrip
    End Sub

End Class