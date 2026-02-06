Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Label1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Label2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Label3 As Integer = Label1 - Label2

        Label4.Text = Label3.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Label1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Label2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Label3 As Integer = Label1 + Label2

        Label4.Text = Label3.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Label1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Label2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Label3 As Integer = Label1 * Label2

        Label4.Text = Label3.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Label1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Label2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Label3 As Integer = Label1 / Label2

        Label4.Text = Label3.ToString()
    End Sub
End Class
