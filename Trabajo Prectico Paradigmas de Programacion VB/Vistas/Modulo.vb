

Module Modulo

    Public jornada As Entidades2.Jornada
    Public unTicket As Entidades2.Ticket
    Public unAuto As Entidades2.Automovil
    Public unaMoto As Entidades2.Motocicleta
    Public unaCamioneta As Entidades2.Camionetas


    Public Function verificarnumero(e As KeyPressEventArgs) As KeyPressEventArgs
        If (Not IsNumeric(e.KeyChar)) Then e.Handled = True
        If ((Asc(e.KeyChar) = 8) Or (Asc(e.KeyChar) = 44)) Then e.Handled = False

        Return e
    End Function




End Module
