Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        System.Windows.Forms.SendKeys.Send("{PRTSC}")

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtAnnual.Clear()
        lblWeekly.Clear()
        lblBiweekly.Clear()
        txtAnnual.Focus()




    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim Annual, Weekly, Biweekly As Double


        If IsNumeric(txtAnnual.Text) Then
            Annual = Double.Parse(txtAnnual.Text)
            Weekly = Annual / 52
            Biweekly = Annual / 26

            lblWeekly.Text = FormatCurrency(Weekly)
            lblBiweekly.Text = FormatCurrency(Biweekly)
        Else
            lblWeekly.Text = FormatCurrency(0)
            lblBiweekly.Text = FormatCurrency(0)



        End If
    End Sub
End Class
