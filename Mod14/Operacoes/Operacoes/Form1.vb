Public Class Form1
    Public Sub Soma()
        Dim n1, n2, resto As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resto = n1 + n2
        TextBox3.Text = resto
    End Sub
    Public Sub Menos()
        Dim n1, n2, resto As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resto = n1 - n2
        TextBox3.Text = resto
    End Sub
    Public Sub Mult()
        Dim n1, n2, resto As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resto = n1 * n2
        TextBox3.Text = resto
    End Sub
    Public Sub Div()
        Dim n1, n2, resto As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        resto = n1 / n2
        TextBox3.Text = resto
    End Sub








    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Soma()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Menos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Mult()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Div()
    End Sub
End Class
