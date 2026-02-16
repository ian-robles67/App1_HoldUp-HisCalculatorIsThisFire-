Public Class Form1
    Dim activo
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles resta.Click
        Dim Label1 As Double = Double.Parse(TextBox1.Text)
        Dim Label2 As Double = Double.Parse(TextBox2.Text)

        Dim Label3 As Double = Label1 - Label2

        Label4.Text = Label3.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles suma.Click
        Dim Label1 As Double = Double.Parse(TextBox1.Text)
        Dim Label2 As Double = Double.Parse(TextBox2.Text)

        Dim Label3 As Double = Label1 + Label2

        Label4.Text = Label3.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles multiplicar.Click
        Dim Label1 As Double = Double.Parse(TextBox1.Text)
        Dim Label2 As Double = Double.Parse(TextBox2.Text)

        Dim Label3 As Double = Label1 * Label2

        Label4.Text = Label3.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles dividir.Click
        Dim Label1 As Double = Double.Parse(TextBox1.Text)
        Dim Label2 As Double = Double.Parse(TextBox2.Text)

        Dim Label3 As Double = Label1 / Label2

        Label4.Text = Label3.ToString()
    End Sub

    Private Sub boton0_Click(sender As Object, e As EventArgs) Handles boton0.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = TextBox2
    End Sub
End Class
