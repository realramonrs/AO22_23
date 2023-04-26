<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtPlataforma = New System.Windows.Forms.TextBox()
        Me.txtValoracion = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblPlataforma = New System.Windows.Forms.Label()
        Me.lblValoracion = New System.Windows.Forms.Label()
        Me.btnGuardarSerie = New System.Windows.Forms.Button()
        Me.dtpFechaEstreno = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaEstreno = New System.Windows.Forms.Label()
        Me.btnAbrirConsultaSeries = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(194, 62)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(137, 29)
        Me.txtTitulo.TabIndex = 0
        '
        'txtPlataforma
        '
        Me.txtPlataforma.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlataforma.Location = New System.Drawing.Point(194, 113)
        Me.txtPlataforma.Name = "txtPlataforma"
        Me.txtPlataforma.Size = New System.Drawing.Size(137, 29)
        Me.txtPlataforma.TabIndex = 1
        '
        'txtValoracion
        '
        Me.txtValoracion.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValoracion.Location = New System.Drawing.Point(194, 164)
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Size = New System.Drawing.Size(67, 29)
        Me.txtValoracion.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(71, 62)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(117, 22)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Titulo serie:"
        '
        'lblPlataforma
        '
        Me.lblPlataforma.AutoSize = True
        Me.lblPlataforma.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlataforma.Location = New System.Drawing.Point(73, 113)
        Me.lblPlataforma.Name = "lblPlataforma"
        Me.lblPlataforma.Size = New System.Drawing.Size(116, 22)
        Me.lblPlataforma.TabIndex = 4
        Me.lblPlataforma.Text = "Plataforma:"
        '
        'lblValoracion
        '
        Me.lblValoracion.AutoSize = True
        Me.lblValoracion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValoracion.Location = New System.Drawing.Point(71, 168)
        Me.lblValoracion.Name = "lblValoracion"
        Me.lblValoracion.Size = New System.Drawing.Size(113, 22)
        Me.lblValoracion.TabIndex = 5
        Me.lblValoracion.Text = "Valoracion:"
        '
        'btnGuardarSerie
        '
        Me.btnGuardarSerie.Location = New System.Drawing.Point(141, 314)
        Me.btnGuardarSerie.Name = "btnGuardarSerie"
        Me.btnGuardarSerie.Size = New System.Drawing.Size(143, 44)
        Me.btnGuardarSerie.TabIndex = 6
        Me.btnGuardarSerie.Text = "Guardar serie"
        Me.btnGuardarSerie.UseVisualStyleBackColor = True
        '
        'dtpFechaEstreno
        '
        Me.dtpFechaEstreno.Location = New System.Drawing.Point(216, 223)
        Me.dtpFechaEstreno.Name = "dtpFechaEstreno"
        Me.dtpFechaEstreno.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaEstreno.TabIndex = 7
        '
        'lblFechaEstreno
        '
        Me.lblFechaEstreno.AutoSize = True
        Me.lblFechaEstreno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEstreno.Location = New System.Drawing.Point(71, 223)
        Me.lblFechaEstreno.Name = "lblFechaEstreno"
        Me.lblFechaEstreno.Size = New System.Drawing.Size(139, 22)
        Me.lblFechaEstreno.TabIndex = 5
        Me.lblFechaEstreno.Text = "Fecha estreno"
        '
        'btnAbrirConsultaSeries
        '
        Me.btnAbrirConsultaSeries.Location = New System.Drawing.Point(396, 314)
        Me.btnAbrirConsultaSeries.Name = "btnAbrirConsultaSeries"
        Me.btnAbrirConsultaSeries.Size = New System.Drawing.Size(120, 44)
        Me.btnAbrirConsultaSeries.TabIndex = 8
        Me.btnAbrirConsultaSeries.Text = "Consultar Series"
        Me.btnAbrirConsultaSeries.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAbrirConsultaSeries)
        Me.Controls.Add(Me.dtpFechaEstreno)
        Me.Controls.Add(Me.btnGuardarSerie)
        Me.Controls.Add(Me.lblFechaEstreno)
        Me.Controls.Add(Me.lblValoracion)
        Me.Controls.Add(Me.lblPlataforma)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtValoracion)
        Me.Controls.Add(Me.txtPlataforma)
        Me.Controls.Add(Me.txtTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtPlataforma As TextBox
    Friend WithEvents txtValoracion As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblPlataforma As Label
    Friend WithEvents lblValoracion As Label
    Friend WithEvents btnGuardarSerie As Button
    Friend WithEvents dtpFechaEstreno As DateTimePicker
    Friend WithEvents lblFechaEstreno As Label
    Friend WithEvents btnAbrirConsultaSeries As Button
End Class
