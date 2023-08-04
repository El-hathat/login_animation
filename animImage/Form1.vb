Imports System.Drawing.Image
Public Class Form1
    Sub Im(ByVal a As String)
        Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(a)
        PictureBox1.Image = img
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Im("../../pictures/mk1.jpeg")
    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        If TextBox2.Text = "Mot De Passe" Then
            TextBox1.ForeColor = Color.Black
            TextBox2.PasswordChar = "*"
            TextBox2.Text = Nothing
            TextBox2.ForeColor = Color.Black
        End If
        If TextBox2.PasswordChar = "*" Then
            CheckBox1.Checked = False
            Im("../../pictures/mk2.jpeg")
        End If

    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        If TextBox1.Text = "E-mail" Then
            TextBox1.Text = Nothing
            TextBox1.ForeColor = Color.Black
        End If
       
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.Text = "Mot De Passe" Then
            CheckBox1.Checked = True
        Else
            If CheckBox1.Checked Then
                Im("../../pictures/mk3.jpeg")
                TextBox2.PasswordChar = Nothing
            Else
                Im("../../pictures/mk2.jpeg")
                TextBox2.PasswordChar = "*"
            End If
        End If
        'TextBox2.PasswordChar = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.IndexOf(" ") <> -1 Then
            Label1.Text = "Votre E-mail est Incorrect"
        Else
            Label1.Text = Nothing
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        Form2.Show()

    End Sub
End Class
