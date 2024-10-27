Public Class Form4
    Private Sub btusuario_Click(sender As Object, e As EventArgs) Handles btusuario.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub btrepuesto_Click(sender As Object, e As EventArgs) Handles btrepuesto.Click
        Dim form5 As New Form5()
        form5.Show()
        Me.Hide()
    End Sub
End Class