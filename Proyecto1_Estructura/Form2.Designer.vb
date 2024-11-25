<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtNumero = New TextBox()
        Label2 = New Label()
        btnInsertar = New Button()
        btnMostrar = New Button()
        btnEliminar = New Button()
        Button_Atras = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(543, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 38)
        Label1.TabIndex = 1
        Label1.Text = "Estructura de Pila"
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(706, 144)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(150, 31)
        txtNumero.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(464, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(236, 25)
        Label2.TabIndex = 3
        Label2.Text = "Ingresar numero de 01 al 99"
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Location = New Point(622, 213)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(112, 34)
        btnInsertar.TabIndex = 4
        btnInsertar.Text = "Insertar"
        btnInsertar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Location = New Point(622, 268)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(112, 34)
        btnMostrar.TabIndex = 5
        btnMostrar.Text = "Mostrar"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(623, 318)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(112, 34)
        btnEliminar.TabIndex = 6
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Button_Atras
        ' 
        Button_Atras.Location = New Point(12, 410)
        Button_Atras.Name = "Button_Atras"
        Button_Atras.Size = New Size(112, 34)
        Button_Atras.TabIndex = 7
        Button_Atras.Text = "Atras"
        Button_Atras.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(1366, 456)
        Controls.Add(Button_Atras)
        Controls.Add(btnEliminar)
        Controls.Add(btnMostrar)
        Controls.Add(btnInsertar)
        Controls.Add(Label2)
        Controls.Add(txtNumero)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button_Atras As Button
End Class
