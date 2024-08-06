Public Class Form1
    Private Sub lblGenelToplam_Click(sender As Object, e As EventArgs) Handles lblGenelToplam.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ekle As frmMüşteriEkle = New frmMüşteriEkle
        ekle.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim listele As frmMüşteriListele = New frmMüşteriListele
        listele.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Ürün As frmÜrünEkle = New frmÜrünEkle
        frmÜrünEkle.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kırtasiye_otomasyonuDataSet.SatışTablosu' table. You can move, or remove it, as needed.
        Me.SatışTablosuTableAdapter.Fill(Me.Kırtasiye_otomasyonuDataSet.SatışTablosu)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
