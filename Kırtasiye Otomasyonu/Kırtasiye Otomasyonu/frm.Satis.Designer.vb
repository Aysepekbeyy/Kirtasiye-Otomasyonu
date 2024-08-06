<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SatısIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarihDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusteriIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiktarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiyatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TutarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OdemeYontemiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonelIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatışTablosuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kırtasiye_otomasyonuDataSet = New Kırtasiye_Otomasyonu.Kırtasiye_otomasyonuDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblGenelToplam = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SatışTablosuTableAdapter = New Kırtasiye_Otomasyonu.Kırtasiye_otomasyonuDataSetTableAdapters.SatışTablosuTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatışTablosuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kırtasiye_otomasyonuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SatısIDDataGridViewTextBoxColumn, Me.TarihDataGridViewTextBoxColumn, Me.MusteriIDDataGridViewTextBoxColumn, Me.UrunIDDataGridViewTextBoxColumn, Me.MiktarDataGridViewTextBoxColumn, Me.FiyatDataGridViewTextBoxColumn, Me.TutarDataGridViewTextBoxColumn, Me.OdemeYontemiDataGridViewTextBoxColumn, Me.PersonelIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SatışTablosuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(118, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(569, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'SatısIDDataGridViewTextBoxColumn
        '
        Me.SatısIDDataGridViewTextBoxColumn.DataPropertyName = "SatısID"
        Me.SatısIDDataGridViewTextBoxColumn.HeaderText = "SatısID"
        Me.SatısIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SatısIDDataGridViewTextBoxColumn.Name = "SatısIDDataGridViewTextBoxColumn"
        Me.SatısIDDataGridViewTextBoxColumn.Width = 125
        '
        'TarihDataGridViewTextBoxColumn
        '
        Me.TarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih"
        Me.TarihDataGridViewTextBoxColumn.HeaderText = "Tarih"
        Me.TarihDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TarihDataGridViewTextBoxColumn.Name = "TarihDataGridViewTextBoxColumn"
        Me.TarihDataGridViewTextBoxColumn.Width = 125
        '
        'MusteriIDDataGridViewTextBoxColumn
        '
        Me.MusteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID"
        Me.MusteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID"
        Me.MusteriIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MusteriIDDataGridViewTextBoxColumn.Name = "MusteriIDDataGridViewTextBoxColumn"
        Me.MusteriIDDataGridViewTextBoxColumn.Width = 125
        '
        'UrunIDDataGridViewTextBoxColumn
        '
        Me.UrunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID"
        Me.UrunIDDataGridViewTextBoxColumn.HeaderText = "UrunID"
        Me.UrunIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UrunIDDataGridViewTextBoxColumn.Name = "UrunIDDataGridViewTextBoxColumn"
        Me.UrunIDDataGridViewTextBoxColumn.Width = 125
        '
        'MiktarDataGridViewTextBoxColumn
        '
        Me.MiktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar"
        Me.MiktarDataGridViewTextBoxColumn.HeaderText = "Miktar"
        Me.MiktarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MiktarDataGridViewTextBoxColumn.Name = "MiktarDataGridViewTextBoxColumn"
        Me.MiktarDataGridViewTextBoxColumn.Width = 125
        '
        'FiyatDataGridViewTextBoxColumn
        '
        Me.FiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat"
        Me.FiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat"
        Me.FiyatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FiyatDataGridViewTextBoxColumn.Name = "FiyatDataGridViewTextBoxColumn"
        Me.FiyatDataGridViewTextBoxColumn.Width = 125
        '
        'TutarDataGridViewTextBoxColumn
        '
        Me.TutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar"
        Me.TutarDataGridViewTextBoxColumn.HeaderText = "Tutar"
        Me.TutarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TutarDataGridViewTextBoxColumn.Name = "TutarDataGridViewTextBoxColumn"
        Me.TutarDataGridViewTextBoxColumn.Width = 125
        '
        'OdemeYontemiDataGridViewTextBoxColumn
        '
        Me.OdemeYontemiDataGridViewTextBoxColumn.DataPropertyName = "OdemeYontemi"
        Me.OdemeYontemiDataGridViewTextBoxColumn.HeaderText = "OdemeYontemi"
        Me.OdemeYontemiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OdemeYontemiDataGridViewTextBoxColumn.Name = "OdemeYontemiDataGridViewTextBoxColumn"
        Me.OdemeYontemiDataGridViewTextBoxColumn.Width = 125
        '
        'PersonelIDDataGridViewTextBoxColumn
        '
        Me.PersonelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID"
        Me.PersonelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID"
        Me.PersonelIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PersonelIDDataGridViewTextBoxColumn.Name = "PersonelIDDataGridViewTextBoxColumn"
        Me.PersonelIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonelIDDataGridViewTextBoxColumn.Width = 125
        '
        'SatışTablosuBindingSource
        '
        Me.SatışTablosuBindingSource.DataMember = "SatışTablosu"
        Me.SatışTablosuBindingSource.DataSource = Me.Kırtasiye_otomasyonuDataSet
        '
        'Kırtasiye_otomasyonuDataSet
        '
        Me.Kırtasiye_otomasyonuDataSet.DataSetName = "Kırtasiye_otomasyonuDataSet"
        Me.Kırtasiye_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Sil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Satış İptal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(118, 421)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Ekle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(612, 421)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Satış Yap"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblGenelToplam
        '
        Me.lblGenelToplam.AutoSize = True
        Me.lblGenelToplam.Location = New System.Drawing.Point(349, 428)
        Me.lblGenelToplam.Name = "lblGenelToplam"
        Me.lblGenelToplam.Size = New System.Drawing.Size(93, 16)
        Me.lblGenelToplam.TabIndex = 7
        Me.lblGenelToplam.Text = "Genel Toplam"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(485, 424)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1162, 99)
        Me.Panel1.TabIndex = 9
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(904, 15)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(180, 51)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Satışları Listeleme"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(623, 15)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(180, 51)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Ürün Listeleme"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(437, 15)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(180, 51)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Ürün Ekleme"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(202, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(180, 51)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Müşteri Listeleme"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 51)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Müşteri Ekleme"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'SatışTablosuTableAdapter
        '
        Me.SatışTablosuTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1175, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblGenelToplam)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Satış Sayfası"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatışTablosuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kırtasiye_otomasyonuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lblGenelToplam As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Kırtasiye_otomasyonuDataSet As Kırtasiye_otomasyonuDataSet
    Friend WithEvents SatışTablosuBindingSource As BindingSource
    Friend WithEvents SatışTablosuTableAdapter As Kırtasiye_otomasyonuDataSetTableAdapters.SatışTablosuTableAdapter
    Friend WithEvents SatısIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarihDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MusteriIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrunIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiktarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiyatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TutarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OdemeYontemiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonelIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
End Class
