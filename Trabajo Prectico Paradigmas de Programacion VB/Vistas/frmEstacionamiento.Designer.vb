<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstacionamiento
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMontoTotal = New System.Windows.Forms.Label()
        Me.cboTickets = New System.Windows.Forms.ComboBox()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.chkTickets = New System.Windows.Forms.CheckedListBox()
        Me.btnInfrac = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tickets del Dia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tarifa Minima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 330)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monto Total del Dia: "
        '
        'lblMontoTotal
        '
        Me.lblMontoTotal.AutoSize = True
        Me.lblMontoTotal.Location = New System.Drawing.Point(238, 330)
        Me.lblMontoTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMontoTotal.Name = "lblMontoTotal"
        Me.lblMontoTotal.Size = New System.Drawing.Size(0, 17)
        Me.lblMontoTotal.TabIndex = 5
        '
        'cboTickets
        '
        Me.cboTickets.FormattingEnabled = True
        Me.cboTickets.Location = New System.Drawing.Point(207, 145)
        Me.cboTickets.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTickets.Name = "cboTickets"
        Me.cboTickets.Size = New System.Drawing.Size(216, 24)
        Me.cboTickets.TabIndex = 3
        '
        'txtTarifa
        '
        Me.txtTarifa.Enabled = False
        Me.txtTarifa.Location = New System.Drawing.Point(208, 96)
        Me.txtTarifa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(113, 22)
        Me.txtTarifa.TabIndex = 2
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(441, 133)
        Me.btnCargar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(71, 44)
        Me.btnCargar.TabIndex = 4
        Me.btnCargar.Text = "Agregar Ticket"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Actual"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(209, 52)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(115, 22)
        Me.dtpFecha.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(162, 283)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(120, 29)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar Caja"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'chkTickets
        '
        Me.chkTickets.FormattingEnabled = True
        Me.chkTickets.Location = New System.Drawing.Point(27, 190)
        Me.chkTickets.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkTickets.Name = "chkTickets"
        Me.chkTickets.Size = New System.Drawing.Size(350, 55)
        Me.chkTickets.TabIndex = 5
        '
        'btnInfrac
        '
        Me.btnInfrac.Location = New System.Drawing.Point(399, 209)
        Me.btnInfrac.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInfrac.Name = "btnInfrac"
        Me.btnInfrac.Size = New System.Drawing.Size(125, 27)
        Me.btnInfrac.TabIndex = 6
        Me.btnInfrac.Text = "Infracción"
        Me.btnInfrac.UseVisualStyleBackColor = True
        '
        'frmEstacionamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 398)
        Me.Controls.Add(Me.btnInfrac)
        Me.Controls.Add(Me.chkTickets)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtTarifa)
        Me.Controls.Add(Me.cboTickets)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblMontoTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEstacionamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estacionamiento ""La Rueda"""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMontoTotal As Label
    Friend WithEvents cboTickets As ComboBox
    Friend WithEvents txtTarifa As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnCerrar As Button
    Friend WithEvents chkTickets As CheckedListBox
    Friend WithEvents btnInfrac As Button
End Class
