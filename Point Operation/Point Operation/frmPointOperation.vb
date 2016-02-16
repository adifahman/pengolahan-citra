Public Class frmPointOperation
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        dlgBrowse.Title = "Buka Gambar"
        dlgBrowse.Filter = "Gambar|*.bmp;*.gif;*.png;*.jpg;*.jpeg"
        If dlgBrowse.ShowDialog() = DialogResult.OK Then
            pbOrigin.Image = Image.FromFile(dlgBrowse.FileName)
            Exit Sub
        End If
    End Sub

    Private Sub btnGrayscale_Click(sender As Object, e As EventArgs) Handles btnGrayscale.Click
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey As Integer

            pbGrayscale.Image = img

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3)

                    img.SetPixel(col, row, Color.FromArgb(grey, grey, grey))
                Next
            Next
        End If
    End Sub

    Private Sub btnBW1_Click(sender As Object, e As EventArgs) Handles btnBW1.Click
        Dim img As New Bitmap(pbOrigin.Image)
        Dim col, row As Integer
        Dim red, green, blue, grey As Integer

        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            pbBW1.Image = img

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3)
                    If grey >= 128 Then
                        img.SetPixel(col, row, Color.FromArgb(255, 255, 255))
                    Else
                        img.SetPixel(col, row, Color.FromArgb(0, 0, 0))
                    End If
                Next
            Next
        End If
    End Sub
End Class