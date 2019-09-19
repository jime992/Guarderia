Imports System.ComponentModel

Public Class frmEstacionamiento
    Private Sub frmEstacionamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Value = jornada.getFecha
        txtTarifa.Text = jornada.getTarifa

    End Sub




    Private Sub frmEstacionamiento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Desea Salir?", vbYesNo, "Salir") = vbYes Then
            frmInicio.Close()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        frmTicket.Show()
        Me.Hide()

    End Sub

    Private Sub btnInfrac_Click(sender As Object, e As EventArgs) Handles btnInfrac.Click
        Dim i As Integer
        Dim j As Integer
        Dim infraccion As String = 0

        infraccion = InputBox("Cuanto desea aumentar", "Infraccion")
        While (Not IsNumeric(infraccion))
            infraccion = InputBox("Cuanto desea aumentar", "Infraccion")
        End While

        For i = 0 To chkTickets.Items.Count - 1
            If chkTickets.GetItemChecked(i) = True Then
                For j = 0 To jornada.getListTickets.Count - 1

                    If (chkTickets.Items(i) = jornada.getTicket(j).getNumTicket) Then
                        jornada.getTicket(j).Infraccion(CDec(infraccion))
                    End If
                Next
            End If
        Next

        cboTickets.Items.Clear()

        For i = 0 To jornada.getListTickets.Count - 1
            cboTickets.Items.Add(CStr(jornada.getTicket(i).getNumTicket) + " Patente: " + CStr(jornada.getTicket(i).getVehiculo.getPatente) + " Total: " + CStr(jornada.getTicket(i).getImporteaPagar))
        Next

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        jornada.calcRecaudacion()
        lblMontoTotal.Text = CStr(jornada.getRecaudacion())
    End Sub
End Class
