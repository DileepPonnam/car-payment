Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get today’s date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim decTax As Decimal
        Dim decPayment As Decimal
        Const decTAX_RATE As Decimal = 0.08  ' Tax rate
        Try
            'Calculate the Sales Tax
            decTax = CDec(txtprice.Text) * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            'calculate the monthly payment
            decPayment = (CDec(txtprice.Text) + decTax) / ((txtloan.Text) * 12)
            lblPayment.Text = txtName.Text & decPayment.ToString("c")
        Catch ex As Exception
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clear the fields
        txtName.Clear()
        txtprice.Clear()
        txtloan.Clear()
        'clearing the monthly and tax fields
        lblTax.Text = String.Empty
        lblPayment.Text = String.Empty

        txtName.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        lblDateToday.Text = Now.ToString("D")

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        lblTimeToday.Text = Now.ToString("T")
    End Sub
End Class

