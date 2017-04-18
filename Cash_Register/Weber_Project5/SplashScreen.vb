Public Class splashscreen
    Private Sub splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppTitle.Text = My.Application.Info.Title
        Copyright.Text = My.Application.Info.Copyright

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If barLoading.Value >= 100 Then
            Timer1.Stop()
            frmCashRegister.Show()
            Me.Close()

        Else
            barLoading.Value += 1
            lblProgress.Text = barLoading.Value & "%"
        End If
    End Sub
End Class