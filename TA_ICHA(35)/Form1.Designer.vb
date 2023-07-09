<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        cbkelas = New ComboBox()
        cbtujuan = New ComboBox()
        cbjam = New ComboBox()
        cbtahun = New ComboBox()
        cbbulan = New ComboBox()
        txtjumlah = New TextBox()
        txttgl = New TextBox()
        txttlpn = New TextBox()
        txtnama = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        bulan = New Label()
        tahun = New Label()
        Label25 = New Label()
        Label24 = New Label()
        jumlah = New Label()
        Label22 = New Label()
        total = New Label()
        diskon = New Label()
        harga = New Label()
        jam = New Label()
        tgl = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        kls = New Label()
        tlpn = New Label()
        Tujuan = New Label()
        Nama = New Label()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        btnpesan = New Button()
        btnclear = New Button()
        btnexit = New Button()
        Label9 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Plum
        GroupBox1.Controls.Add(cbkelas)
        GroupBox1.Controls.Add(cbtujuan)
        GroupBox1.Controls.Add(cbjam)
        GroupBox1.Controls.Add(cbtahun)
        GroupBox1.Controls.Add(cbbulan)
        GroupBox1.Controls.Add(txtjumlah)
        GroupBox1.Controls.Add(txttgl)
        GroupBox1.Controls.Add(txttlpn)
        GroupBox1.Controls.Add(txtnama)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(36, 44)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(653, 242)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pemesanan Tiket"
        ' 
        ' cbkelas
        ' 
        cbkelas.FormattingEnabled = True
        cbkelas.Items.AddRange(New Object() {"Ekonomi", "Bisnis"})
        cbkelas.Location = New Point(491, 85)
        cbkelas.Name = "cbkelas"
        cbkelas.Size = New Size(120, 23)
        cbkelas.TabIndex = 14
        ' 
        ' cbtujuan
        ' 
        cbtujuan.FormattingEnabled = True
        cbtujuan.Items.AddRange(New Object() {"Wonogiri", "Yogyakarta", "Malang", "Semarang"})
        cbtujuan.Location = New Point(491, 30)
        cbtujuan.Name = "cbtujuan"
        cbtujuan.Size = New Size(120, 23)
        cbtujuan.TabIndex = 13
        ' 
        ' cbjam
        ' 
        cbjam.FormattingEnabled = True
        cbjam.Items.AddRange(New Object() {"07.00", "08.15", "08.40", "09.15", "09.20", "10.00", "10.15", "10.45", "11.00", "11.25", "11.45", "12.00"})
        cbjam.Location = New Point(141, 201)
        cbjam.Name = "cbjam"
        cbjam.Size = New Size(88, 23)
        cbjam.TabIndex = 12
        ' 
        ' cbtahun
        ' 
        cbtahun.FormattingEnabled = True
        cbtahun.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        cbtahun.Location = New Point(301, 145)
        cbtahun.Name = "cbtahun"
        cbtahun.Size = New Size(88, 23)
        cbtahun.TabIndex = 11
        ' 
        ' cbbulan
        ' 
        cbbulan.FormattingEnabled = True
        cbbulan.Items.AddRange(New Object() {"Januari", "February", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        cbbulan.Location = New Point(185, 145)
        cbbulan.Name = "cbbulan"
        cbbulan.Size = New Size(88, 23)
        cbbulan.TabIndex = 10
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(514, 145)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(97, 23)
        txtjumlah.TabIndex = 9
        ' 
        ' txttgl
        ' 
        txttgl.Location = New Point(135, 145)
        txttgl.Name = "txttgl"
        txttgl.Size = New Size(33, 23)
        txttgl.TabIndex = 8
        ' 
        ' txttlpn
        ' 
        txttlpn.Location = New Point(120, 82)
        txttlpn.Name = "txttlpn"
        txttlpn.Size = New Size(269, 23)
        txttlpn.TabIndex = 7
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(120, 30)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(269, 23)
        txtnama.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(442, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 3
        Label5.Text = "Tujuan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(442, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 4
        Label6.Text = "Kelas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(426, 148)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 5
        Label7.Text = "Jumlah Tiket"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 15)
        Label4.TabIndex = 3
        Label4.Text = "Jam Pemberangkatan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 15)
        Label3.TabIndex = 2
        Label3.Text = "Tgl.Pemberangkatan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nomor Telepon"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Pemesan"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Plum
        GroupBox2.Controls.Add(bulan)
        GroupBox2.Controls.Add(tahun)
        GroupBox2.Controls.Add(Label25)
        GroupBox2.Controls.Add(Label24)
        GroupBox2.Controls.Add(jumlah)
        GroupBox2.Controls.Add(Label22)
        GroupBox2.Controls.Add(total)
        GroupBox2.Controls.Add(diskon)
        GroupBox2.Controls.Add(harga)
        GroupBox2.Controls.Add(jam)
        GroupBox2.Controls.Add(tgl)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(kls)
        GroupBox2.Controls.Add(tlpn)
        GroupBox2.Controls.Add(Tujuan)
        GroupBox2.Controls.Add(Nama)
        GroupBox2.Location = New Point(36, 313)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(378, 236)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Detail Tiket"
        ' 
        ' bulan
        ' 
        bulan.AutoSize = True
        bulan.Location = New Point(135, 94)
        bulan.Name = "bulan"
        bulan.Size = New Size(12, 15)
        bulan.TabIndex = 19
        bulan.Text = "-"
        ' 
        ' tahun
        ' 
        tahun.AutoSize = True
        tahun.Location = New Point(185, 94)
        tahun.Name = "tahun"
        tahun.Size = New Size(12, 15)
        tahun.TabIndex = 18
        tahun.Text = "-"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(120, 21)
        Label25.Name = "Label25"
        Label25.Size = New Size(12, 15)
        Label25.TabIndex = 17
        Label25.Text = "/"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(117, 56)
        Label24.Name = "Label24"
        Label24.Size = New Size(12, 15)
        Label24.TabIndex = 16
        Label24.Text = "/"
        ' 
        ' jumlah
        ' 
        jumlah.AutoSize = True
        jumlah.Location = New Point(286, 112)
        jumlah.Name = "jumlah"
        jumlah.Size = New Size(12, 15)
        jumlah.TabIndex = 15
        jumlah.Text = "-"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(226, 112)
        Label22.Name = "Label22"
        Label22.Size = New Size(45, 15)
        Label22.TabIndex = 14
        Label22.Text = "Jumlah"
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Location = New Point(135, 218)
        total.Name = "total"
        total.Size = New Size(12, 15)
        total.TabIndex = 13
        total.Text = "-"
        ' 
        ' diskon
        ' 
        diskon.AutoSize = True
        diskon.Location = New Point(135, 193)
        diskon.Name = "diskon"
        diskon.Size = New Size(12, 15)
        diskon.TabIndex = 12
        diskon.Text = "-"
        ' 
        ' harga
        ' 
        harga.AutoSize = True
        harga.Location = New Point(135, 164)
        harga.Name = "harga"
        harga.Size = New Size(12, 15)
        harga.TabIndex = 11
        harga.Text = "-"
        ' 
        ' jam
        ' 
        jam.AutoSize = True
        jam.Location = New Point(135, 130)
        jam.Name = "jam"
        jam.Size = New Size(12, 15)
        jam.TabIndex = 10
        jam.Text = "-"
        ' 
        ' tgl
        ' 
        tgl.AutoSize = True
        tgl.Location = New Point(91, 94)
        tgl.Name = "tgl"
        tgl.Size = New Size(12, 15)
        tgl.TabIndex = 9
        tgl.Text = "-"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(17, 218)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 15)
        Label16.TabIndex = 8
        Label16.Text = "Total Bayar"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(17, 193)
        Label15.Name = "Label15"
        Label15.Size = New Size(43, 15)
        Label15.TabIndex = 7
        Label15.Text = "Diskon"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(17, 164)
        Label14.Name = "Label14"
        Label14.Size = New Size(87, 15)
        Label14.TabIndex = 6
        Label14.Text = "Harga per Tiket"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(17, 130)
        Label13.Name = "Label13"
        Label13.Size = New Size(28, 15)
        Label13.TabIndex = 5
        Label13.Text = "Jam"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(17, 94)
        Label12.Name = "Label12"
        Label12.Size = New Size(48, 15)
        Label12.TabIndex = 4
        Label12.Text = "Tanggal"
        ' 
        ' kls
        ' 
        kls.AutoSize = True
        kls.Location = New Point(135, 56)
        kls.Name = "kls"
        kls.Size = New Size(12, 15)
        kls.TabIndex = 3
        kls.Text = "-"
        ' 
        ' tlpn
        ' 
        tlpn.AutoSize = True
        tlpn.Location = New Point(135, 21)
        tlpn.Name = "tlpn"
        tlpn.Size = New Size(12, 15)
        tlpn.TabIndex = 2
        tlpn.Text = "-"
        ' 
        ' Tujuan
        ' 
        Tujuan.AutoSize = True
        Tujuan.Location = New Point(17, 56)
        Tujuan.Name = "Tujuan"
        Tujuan.Size = New Size(12, 15)
        Tujuan.TabIndex = 1
        Tujuan.Text = "-"
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.Location = New Point(17, 21)
        Nama.Name = "Nama"
        Nama.Size = New Size(12, 15)
        Nama.TabIndex = 0
        Nama.Text = "-"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Plum
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Location = New Point(437, 313)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(278, 71)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Informasi"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 31)
        Label8.Name = "Label8"
        Label8.Size = New Size(240, 15)
        Label8.TabIndex = 0
        Label8.Text = "Jika Pembelian Tiket lebih dari 3, diskon 10%"
        ' 
        ' btnpesan
        ' 
        btnpesan.BackColor = Color.MediumOrchid
        btnpesan.Location = New Point(442, 414)
        btnpesan.Name = "btnpesan"
        btnpesan.Size = New Size(75, 23)
        btnpesan.TabIndex = 3
        btnpesan.Text = "Pesan"
        btnpesan.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.MediumOrchid
        btnclear.Location = New Point(550, 414)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 23)
        btnclear.TabIndex = 4
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.MediumOrchid
        btnexit.Location = New Point(662, 414)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 23)
        btnexit.TabIndex = 5
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(337, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(158, 19)
        Label9.TabIndex = 6
        Label9.Text = "PEMESANAN TIKET KA"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(885, 561)
        Controls.Add(Label9)
        Controls.Add(btnexit)
        Controls.Add(btnclear)
        Controls.Add(btnpesan)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbtahun As ComboBox
    Friend WithEvents cbbulan As ComboBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txttgl As TextBox
    Friend WithEvents txttlpn As TextBox
    Friend WithEvents cbkelas As ComboBox
    Friend WithEvents cbtujuan As ComboBox
    Friend WithEvents cbjam As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents kls As Label
    Friend WithEvents tlpn As Label
    Friend WithEvents Tujuan As Label
    Friend WithEvents Nama As Label
    Friend WithEvents jumlah As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents total As Label
    Friend WithEvents diskon As Label
    Friend WithEvents harga As Label
    Friend WithEvents jam As Label
    Friend WithEvents tgl As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents bulan As Label
    Friend WithEvents tahun As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnpesan As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Label9 As Label
End Class
