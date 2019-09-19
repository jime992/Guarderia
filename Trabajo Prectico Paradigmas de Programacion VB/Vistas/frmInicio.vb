Imports System.ComponentModel




Public Class frmInicio

    Private Sub txtTarifa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarifa.KeyPress
        verificarnumero(e)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim fecha As Date
        Dim importe As Decimal

        fecha = dtpFechaActual.Value
        importe = Val(txtTarifa.Text)

        jornada = New Entidades2.Jornada(fecha, importe)

        If (importe > 0) Then
            MsgBox("Bienvenido", vbOKOnly, "Ingreso")
            frmEstacionamiento.Show()
            Me.Hide()
        Else
            MsgBox("Ingrese un valor valido en Tarifa", vbOKOnly, "Ingreso")
            txtTarifa.Focus()
        End If

    End Sub

    Private Sub txtTarifa_TextChanged(sender As Object, e As EventArgs) Handles txtTarifa.TextChanged

    End Sub
End Class