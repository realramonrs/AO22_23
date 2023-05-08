<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Series
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerHBO = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValoracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlataforma = New System.Windows.Forms.TextBox()
        Me.txtFechaEstreno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(86, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(171, 251)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Series vistas"
        '
        'btnVerHBO
        '
        Me.btnVerHBO.Location = New System.Drawing.Point(322, 79)
        Me.btnVerHBO.Name = "btnVerHBO"
        Me.btnVerHBO.Size = New System.Drawing.Size(88, 51)
        Me.btnVerHBO.TabIndex = 2
        Me.btnVerHBO.Text = "HBO"
        Me.btnVerHBO.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valoración"
        '
        'txtValoracion
        '
        Me.txtValoracion.Enabled = False
        Me.txtValoracion.Location = New System.Drawing.Point(428, 167)
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Size = New System.Drawing.Size(100, 20)
        Me.txtValoracion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Plataforma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de estreno"
        '
        'txtPlataforma
        '
        Me.txtPlataforma.Enabled = False
        Me.txtPlataforma.Location = New System.Drawing.Point(428, 212)
        Me.txtPlataforma.Name = "txtPlataforma"
        Me.txtPlataforma.Size = New System.Drawing.Size(100, 20)
        Me.txtPlataforma.TabIndex = 7
        '
        'txtFechaEstreno
        '
        Me.txtFechaEstreno.Enabled = False
        Me.txtFechaEstreno.Location = New System.Drawing.Point(428, 266)
        Me.txtFechaEstreno.Name = "txtFechaEstreno"
        Me.txtFechaEstreno.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaEstreno.TabIndex = 8
        '
        'Series
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFechaEstreno)
        Me.Controls.Add(Me.txtPlataforma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValoracion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVerHBO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Series"
        Me.Text = "Series"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerHBO As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValoracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlataforma As TextBox
    Friend WithEvents txtFechaEstreno As TextBox
End Class
