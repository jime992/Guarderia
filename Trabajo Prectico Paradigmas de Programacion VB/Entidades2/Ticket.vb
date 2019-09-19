Public Class Ticket
    Dim NumTicket As Integer
    Dim vehiculo As Vehiculo
    Dim horadellegada As Date
    Dim importeapagar As Decimal
    Dim horadesalida As Date

    Public Sub New(num As Integer, horaLL As Date, horaSal As Date)
        NumTicket = num

        horadellegada = horaLL
        horadesalida = horaSal
    End Sub

    Public Sub setVehiculo(vehic As Vehiculo)
        vehiculo = vehic
    End Sub
    Public Function getNumTicket() As Integer
        Return NumTicket
    End Function

    Public Function getVehiculo() As Vehiculo
        Return vehiculo
    End Function

    Public Function getHoraLLegada() As Date
        Return horadellegada
    End Function

    Public Function getHoraSalida() As Date
        Return horadesalida
    End Function

    Public Sub setImporteaPagar(tar As Decimal)
        Dim aux_hora As Integer

        aux_hora = DateDiff(DateInterval.Hour, horadellegada, horadesalida)

        vehiculo.CalcTarifa(aux_hora, tar)

        importeapagar = vehiculo.getTarifa()
    End Sub
    Public Sub Infraccion(infracc As Decimal)
        importeapagar = importeapagar + infracc
    End Sub

    Public Function getImporteaPagar()
        Return importeapagar
    End Function

End Class
