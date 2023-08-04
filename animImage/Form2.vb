Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim img As System.Drawing.Image = System.Drawing.Image.FromFile("C:\Users\lenovo\Desktop\projet vb\imageMky\mk4.jpeg")
        PictureBox1.Image = img
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class