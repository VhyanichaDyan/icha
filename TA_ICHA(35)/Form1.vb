Public Class Form1

    Private Sub btnpesan_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        If Me.cbtujuan.Text = "Wonogiri" And Me.cbkelas.Text = "Ekonomi" Then
            Me.harga.Text = "30000"
        ElseIf Me.cbtujuan.Text = "Wonogiri" And Me.cbkelas.Text = "Bisnis" Then
            Me.harga.Text = "40000"
        ElseIf Me.cbtujuan.Text = "Yogyakarta" And Me.cbkelas.Text = "Ekonomi" Then
            Me.harga.Text = "40000"
        ElseIf Me.cbtujuan.Text = "Yogyakarta" And Me.cbkelas.Text = "Bisnis" Then
            Me.harga.Text = "50000"
        ElseIf Me.cbtujuan.Text = "Malang" And Me.cbkelas.Text = "Ekonomi" Then
            Me.harga.Text = "40000"
        ElseIf Me.cbtujuan.Text = "Malang" And Me.cbkelas.Text = "Bisnis" Then
            Me.harga.Text = "50000"
        ElseIf Me.cbtujuan.Text = "Semarang" And Me.cbkelas.Text = "Ekonomi" Then
            Me.harga.Text = "55000"
        ElseIf Me.cbtujuan.Text = "Semarang" And Me.cbkelas.Text = "Bisnis" Then
            Me.harga.Text = "65000"
        End If

        Dim jumlah, harga, total, diskon As Double
        jumlah = Val(Me.txtjumlah.Text)
        harga = Val(Me.harga.Text)

        total = jumlah * harga

        If jumlah >= 3 Then
            diskon = total * 0.1
            total = total - diskon
        End If
        Me.total.Text = total
        Me.diskon.Text = diskon
        Me.jumlah.Text = jumlah
        Me.tlpn.Text = txttlpn.Text
        Me.tgl.Text = txttgl.Text
        Me.bulan.Text = cbbulan.Text
        Me.tahun.Text = cbtahun.Text
        Me.Tujuan.Text = cbtahun.Text
        Me.kls.Text = cbkelas.Text
        Me.jam.Text = cbjam.Text

        Me.harga.Text = Format(harga, "Rp ###, ###")
        Me.diskon.Text = Format(diskon, "Rp ###, ###")
        Me.total.Text = Format(total, "Rp ###,###")
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Me.txtnama.Text = ""
        Me.txttlpn.Text = ""
        Me.txtjumlah.Text = ""
        Me.txttgl.Text = ""
        Me.cbbulan.Text = ""
        Me.cbtahun.Text = ""
        Me.cbjam.Text = ""
        Me.cbtujuan.Text = ""
        Me.cbkelas.Text = ""
        Me.Nama.Text = "-"
        Me.tlpn.Text = "-"
        Me.Tujuan.Text = "-"
        Me.kls.Text = "-"
        Me.tgl.Text = "-"
        Me.bulan.Text = "-"
        Me.tahun.Text = "-"
        Me.jam.Text = "-"
        Me.jumlah.Text = "-"
        Me.harga.Text = "-"
        Me.diskon.Text = "-"
        Me.total.Text = "-"
        Me.txtnama.Focus()
    End Sub
End Class
