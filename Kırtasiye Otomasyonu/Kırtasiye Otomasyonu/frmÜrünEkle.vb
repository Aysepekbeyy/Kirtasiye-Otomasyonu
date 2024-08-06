Imports System.Data.SqlClient

Public Class frmÜrünEkle
    Dim con As SqlConnection = New SqlConnection("Data Source=MIKAELSON\SQLEXPRESS;Initial Catalog=Kırtasiye Otomasyonu;Integrated Security=True")
    Dim cmd As SqlCommand = New SqlCommand
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmÜrünEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Ürünler_Tablosu VALUES (@ÜrünAdı,@ÜrünMarkası,@ÜrünBarkodu,@ÜrünKatagoriAdı,@ÜrünStok,@ÜrünAlisFiyat,@ÜrünSatisFiyat)"
        cmd.Parameters.AddWithValue("@ÜrünAdı", TextBox15.Text)
        cmd.Parameters.AddWithValue("@ÜrünMarkası", ComboBox2.Text)

        cmd.Parameters.AddWithValue("@ÜrünBarkodu", TextBox1.Text)
        cmd.Parameters.AddWithValue("@ÜrünKatagoriAdı", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@ÜrünStok", TextBox4.Text)
        cmd.Parameters.AddWithValue("@ÜrünAlisFiyat", TextBox13.Text)
        cmd.Parameters.AddWithValue("@ÜrünSatisFiyat", TextBox11.Text)

        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class