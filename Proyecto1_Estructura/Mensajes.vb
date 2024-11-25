Imports System.Windows.Forms.VisualStyles

Module Mensajes
    Public Sub mostrarMensaje(tipoM As String)

        While True
            Select Case tipoM
                Case "integrantes"
                    MsgBox("Elvis" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "", vbInformation, "Integrantes de este Proyecto")
                Case "restriccion"
                    MsgBox("Esta opcion no esta disponible en este momento!", vbInformation, "Error")
                Case Else
                    MsgBox("Opción no válida.")
            End Select

            Exit While
        End While

    End Sub

End Module
