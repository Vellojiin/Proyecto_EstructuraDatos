Public Class Procesos
    Function Insertar(ByRef pila() As Integer, ByRef tope As Integer, ByVal valor As Integer) As Boolean
        If tope < pila.Length - 1 Then
            tope += 1
            pila(tope) = valor
            Return True
        Else
            Return False
        End If
    End Function

    Function Eliminar(ByRef pila() As Integer, ByRef tope As Integer) As Boolean
        If tope >= 0 Then
            pila(tope) = 0
            tope -= 1
            Return True
        Else
            Return False
        End If
    End Function

    Function Mostrar(ByRef pila() As Integer, ByRef tope As Integer) As String
        Dim resultado As String = "Estado actual de la pila:" & vbCrLf
        For i As Integer = 0 To pila.Length - 1
            resultado &= "Índice " & i.ToString() & " - [ " & pila(i).ToString() & " ]" & vbCrLf
        Next
        resultado &= "Tope: " & tope.ToString()
        Return resultado
    End Function

End Class
