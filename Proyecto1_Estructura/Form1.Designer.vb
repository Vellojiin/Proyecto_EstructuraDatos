<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Button_Pila = New Button()
        Button_Cola = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(590, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 38)
        Label1.TabIndex = 0
        Label1.Text = "Proyecto 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(483, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(386, 25)
        Label2.TabIndex = 2
        Label2.Text = "Escoja la estructura de datos que quiere realizar"
        ' 
        ' Button_Pila
        ' 
        Button_Pila.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Pila.Location = New Point(552, 181)
        Button_Pila.Name = "Button_Pila"
        Button_Pila.Size = New Size(246, 48)
        Button_Pila.TabIndex = 3
        Button_Pila.Text = "Estructura de Pila"
        Button_Pila.UseVisualStyleBackColor = True
        ' 
        ' Button_Cola
        ' 
        Button_Cola.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Cola.Location = New Point(552, 260)
        Button_Cola.Name = "Button_Cola"
        Button_Cola.Size = New Size(246, 45)
        Button_Cola.TabIndex = 4
        Button_Cola.Text = "Estructura de Cola"
        Button_Cola.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(1306, 490)
        Controls.Add(Button_Cola)
        Controls.Add(Button_Pila)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Proyecto Estructura de Datos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Pila As Button
    Friend WithEvents Button_Cola As Button

End Class
