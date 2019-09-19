Public MustInherit Class Vehiculo
    Dim patente As String
    Dim tarifa As Decimal

    Public Sub New(pat As String)
        patente = pat
    End Sub

    Public Function getPatente() As String
        Return patente
    End Function

    Public Function getTarifa() As Decimal
        Return tarifa
    End Function
    Public Sub setTarifa(tar As Decimal)
        tarifa = tar
    End Sub

    Public MustOverride Sub CalcTarifa(horas As Integer, precio As Decimal)

End Class

Public Class Motocicleta : Inherits Vehiculo
    Public Sub New(pat As String)
        MyBase.New(pat)

    End Sub

    Public Overrides Sub CalcTarifa(horas As Integer, precio As Decimal)
        Dim tarifa_aux As Decimal

        tarifa_aux = (horas) * (precio / 2)
        setTarifa(tarifa_aux)
    End Sub
End Class

Public Class Automovil : Inherits Vehiculo
    Public Sub New(pat As String)
        MyBase.New(pat)

    End Sub
    Public Overrides Sub CalcTarifa(horas As Integer, precio As Decimal)
        Dim aux_tarifa

        aux_tarifa = (2 * precio) * horas
        setTarifa(aux_tarifa)
    End Sub
End Class

Public Class Camionetas : Inherits Vehiculo
    Public Sub New(pat As String)
        MyBase.New(pat)
    End Sub
    Public Overrides Sub CalcTarifa(horas As Integer, precio As Decimal)
        Dim aux_tarifa

        aux_tarifa = (3 * precio) * horas
        setTarifa(aux_tarifa)
    End Sub
End Class
