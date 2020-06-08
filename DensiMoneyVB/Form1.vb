Public Class Form1
    Private Card As MoneyCard
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Card = New MoneyCard(1000)
        UpdateCardStaus()
    End Sub

    Private Sub UpdateCardStaus()
        labelKingaku.Text = Card.Kingaku & "円"
        labelPoint.Text = Card.Point & "ポイント"

    End Sub


    Private Sub buttonCharge_Click(sender As Object, e As EventArgs) Handles buttonCharge.Click
        Dim money As Integer
        If Integer.TryParse(textBoxMoney.Text, money) = False Then
            textBoxMoney.Text = ""
            Exit Sub
        End If

        Card.Charge(money)

        textBoxMoney.Text = ""
        UpdateCardStaus()

    End Sub

    Private Sub buttonBuy_Click(sender As Object, e As EventArgs) Handles buttonBuy.Click
        Dim money As Integer
        If Integer.TryParse(textBoxMoney.Text, money) = False Then
            textBoxMoney.Text = ""
            Exit Sub
        End If
        If Card.Buy(money) = False Then
            MessageBox.Show("お金が足りません")
            Exit Sub
        End If

        textBoxMoney.Text = ""
        UpdateCardStaus()
    End Sub
End Class
