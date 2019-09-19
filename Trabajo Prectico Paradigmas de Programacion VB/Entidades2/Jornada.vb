Public Class Jornada
    Dim fecha As Date
    Dim listTickets As List(Of Ticket) = New List(Of Ticket)
    Dim Tarifa As Decimal
    Dim Recaudacion As Decimal

    Public Sub New(fec As Date, tar As Decimal)
        fecha = fec
        Tarifa = tar
    End Sub

    Public Sub cargartick(tick As Ticket)
        listTickets.Insert(listTickets.Count, tick)
    End Sub
    Public Function getTicket(i As Integer) As Ticket
        Return listTickets.Item(i)
    End Function
    Public Function getListTickets() As List(Of Ticket)
        Return listTickets
    End Function

    Public Sub calcRecaudacion()
        Dim aux_recaudacion As Decimal
        aux_recaudacion = 0
        For i = 0 To (listTickets.Count - 1)

            aux_recaudacion = aux_recaudacion + listTickets.Item(i).getImporteaPagar
        Next
        Recaudacion = aux_recaudacion
    End Sub

    Public Function getFecha()
        Return fecha
    End Function

    Public Function getTarifa()
        Return Tarifa
    End Function

    Public Function getRecaudacion()
        Return Recaudacion
    End Function



End Class
