Public Class MoneyCard
    Public Property Kingaku As Integer
    Public Property Point As Integer

    Public Sub New(kingaku As Integer)
        Me.Kingaku = kingaku
        Point = 0
    End Sub

    Sub Charge(money As Integer)
        Me.Kingaku += money
    End Sub

    Function Buy(price As Integer) As Boolean
        If price > Me.Kingaku Then
            Return False
        Else
            Me.Kingaku -= price
            Me.Point += price * 0.1
            Return True
        End If
    End Function

End Class
