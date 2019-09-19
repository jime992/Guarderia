<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicket
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbCamioneta = New System.Windows.Forms.RadioButton()
        Me.rdbAuto = New System.Windows.Forms.RadioButton()
        Me.rdbMoto = New System.Windows.Forms.RadioButton()
        Me.txtNumTicket = New System.Windows.Forms.TextBox()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.dtpLlegada = New System.Windows.Forms.DateTimePicker()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.btnCargarTick = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Ticket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patente del Vehiculo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hora de Llegada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora de Salida"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbCamioneta)
        Me.GroupBox1.Controls.Add(Me.rdbAuto)
        Me.GroupBox1.Controls.Add(Me.rdbMoto)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 79)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Vehiculo"
        '
        'rdbCamioneta
        '
        Me.rdbCamioneta.AutoSize = True
        Me.rdbCamioneta.Location = New System.Drawing.Point(316, 38)
        Me.rdbCamioneta.Name = "rdbCamioneta"
        Me.rdbCamioneta.Size = New System.Drawing.Size(132, 29)
        Me.rdbCamioneta.TabIndex = 2
        Me.rdbCamioneta.TabStop = True
        Me.rdbCamioneta.Text = "Camioneta"
        Me.rdbCamioneta.UseVisualStyleBackColor = True
        '
        'rdbAuto
        '
        Me.rdbAuto.AutoSize = True
        Me.rdbAuto.Location = New System.Drawing.Point(177, 38)
        Me.rdbAuto.Name = "rdbAuto"
        Me.rdbAuto.Size = New System.Drawing.Size(78, 29)
        Me.rdbAuto.TabIndex = 1
        Me.rdbAuto.TabStop = True
        Me.rdbAuto.Text = "Auto"
        Me.rdbAuto.UseVisualStyleBackColor = True
        '
        'rdbMoto
        '
        Me.rdbMoto.AutoSize = True
        Me.rdbMoto.Location = New System.Drawing.Point(17, 38)
        Me.rdbMoto.Name = "rdbMoto"
        Me.rdbMoto.Size = New System.Drawing.Size(81, 29)
        Me.rdbMoto.TabIndex = 0
        Me.rdbMoto.TabStop = True
        Me.rdbMoto.Text = "Moto"
        Me.rdbMoto.UseVisualStyleBackColor = True
        '
        'txtNumTicket
        '
        Me.txtNumTicket.Location = New System.Drawing.Point(336, 53)
        Me.txtNumTicket.Name = "txtNumTicket"
        Me.txtNumTicket.Size = New System.Drawing.Size(226, 29)
        Me.txtNumTicket.TabIndex = 5
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(336, 98)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(226, 29)
        Me.txtPatente.TabIndex = 6
        '
        'dtpLlegada
        '
        Me.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpLlegada.Location = New System.Drawing.Point(265, 285)
        Me.dtpLlegada.Name = "dtpLlegada"
        Me.dtpLlegada.Size = New System.Drawing.Size(169, 29)
        Me.dtpLlegada.TabIndex = 7
        '
        'dtpSalida
        '
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalida.Location = New System.Drawing.Point(265, 339)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.Size = New System.Drawing.Size(169, 29)
        Me.dtpSalida.TabIndex = 8
        '
        'btnCargarTick
        '
        Me.btnCargarTick.Location = New System.Drawing.Point(195, 409)
        Me.btnCargarTick.Name = "btnCargarTick"
        Me.btnCargarTick.Size = New System.Drawing.Size(169, 62)
        Me.btnCargarTick.TabIndex = 9
        Me.btnCargarTick.Text = "Cargar Ticket"
        Me.btnCargarTick.UseVisualStyleBackColor = True
        '
        'frmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 518)
        Me.Controls.Add(Me.btnCargarTick)
        Me.Controls.Add(Me.dtpSalida)
        Me.Controls.Add(Me.dtpLlegada)
        Me.Controls.Add(Me.txtPatente)
        Me.Controls.Add(Me.txtNumTicket)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Ticket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbCamioneta As RadioButton
    Friend WithEvents rdbAuto As RadioButton
    Friend WithEvents rdbMoto As RadioButton
    Friend WithEvents txtNumTicket As TextBox
    Friend WithEvents txtPatente As TextBox
    Friend WithEvents dtpLlegada As DateTimePicker
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents btnCargarTick As Button
End Class
