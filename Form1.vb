Public Class Form1
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'MsgBox("The sum is = " & Val(TextBox1.Text) + Val(TextBox2.Text))
        'Label3.text = Val(TextBox1) +Val(Textbox.text)
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click
        MsgBox("The subtraction is = " & Val(TextBox1.Text) - Val(TextBox2.Text))
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        MsgBox("The divison is = " & Val(TextBox1.Text) / Val(TextBox2.Text))
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        MsgBox("The Multiplication is = " & Val(TextBox1.Text) * Val(TextBox2.Text))
    End Sub
End Class
