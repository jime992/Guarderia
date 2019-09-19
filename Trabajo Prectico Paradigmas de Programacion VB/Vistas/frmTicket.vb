Imports System.ComponentModel

Public Class frmTicket
    Private Sub frmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNumTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumTicket.KeyPress
        verificarnumero(e)
    End Sub

    Private Sub btnCargarTick_Click(sender As Object, e As EventArgs) Handles btnCargarTick.Click
        unTicket = New Entidades2.Ticket(Val(txtNumTicket.Text), dtpLlegada.Value, dtpSalida.Value)
        Dim frm As frmEstacionamiento = frmEstacionamiento
        Dim i As Integer



        If (rdbAuto.Checked = True) Then
            unAuto = New Entidades2.Automovil(txtPatente.Text)
            unTicket.setVehiculo(unAuto)
            unTicket.setImporteaPagar(jornada.getTarifa)
        Else
            If (rdbCamioneta.Checked = True) Then
                unaCamioneta = New Entidades2.Camionetas(txtPatente.Text)
                unTicket.setVehiculo(unaCamioneta)
                unTicket.setImporteaPagar(jornada.getTarifa)
            Else
                unaMoto = New Entidades2.Motocicleta(txtPatente.Text)
                unTicket.setVehiculo(unaMoto)
                unTicket.setImporteaPagar(jornada.getTarifa)
            End If

        End If

        frm.cboTickets.Items.Add(CStr(unTicket.getNumTicket) + " Patente: " + CStr(unTicket.getVehiculo.getPatente) + " Total: " + CStr(unTicket.getImporteaPagar))
        jornada.cargartick(unTicket)

        frm.chkTickets.Items.Add(unTicket.getNumTicket)

        If (MsgBox("Desea Seguir Cargando Tickets?", vbYesNo, "Aviso") = vbYes) Then
            txtNumTicket.Clear()
        Else

            Me.Close()
            frm.Show()

        End If

    End Sub

    Private Sub frmTicket_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmEstacionamiento.Show()

    End Sub
End Class