Public Class GameEndStats
    Private Sub GameEndStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Rows.Add("Total Money Made", Math.Round(FinalStatistics.StatTotalMoney, 2))

        DataGridView1.Rows.Add("Percentage profit", Math.Round((FinalStatistics.StatTotalMoney - 200) / 2, 2))

        DataGridView1.Rows.Add("Biggest Stock Profit", Math.Round(FinalStatistics.StatHighestProfitOneStock, 2))
        DataGridView1.Rows.Add("", FinalStatistics.DetailHighestProfitOneStock)
        DataGridView1.Rows.Add("Biggest Stock Loss", Math.Round(FinalStatistics.StatBiggestLossOneStock, 2))
        DataGridView1.Rows.Add("", FinalStatistics.DetailBiggestLossOneStock)


        DataGridView1.Rows.Add("Total Trades", FinalStatistics.StatOverallTradeNumber)
        DataGridView1.Rows.Add("Most Traded stock", Math.Round(FinalStatistics.StatHighestTradePercentageOneStock, 2))
        DataGridView1.Rows.Add("", FinalStatistics.DetailHighestTradePercentageOneStock)

        DataGridView1.Rows.Add("Biggest holding", FinalStatistics.StatMostStockAtOnce)
        DataGridView1.Rows.Add("", FinalStatistics.DetailMostStockAtOnce)

        DataGridView1.Rows.Add("Longest Holding (years)", Math.Round(FinalStatistics.StatLongestHoldOneStock / 3, 2))
        DataGridView1.Rows.Add("", FinalStatistics.DetailLongestHoldOneStock)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("You should have sent your results table in. Are you sure you want to end the game?", "Exit Game", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        ElseIf result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            Dim Credits = New Creditsform()
            Credits.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub GameEndStats_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing

        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("You should have sent your results table in. Are you sure you want to end the game?", "Exit Game", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True

            ElseIf result = DialogResult.No Then
                e.Cancel = True

            ElseIf result = DialogResult.Yes Then
                Exit Sub
            End If

        End If

    End Sub
End Class