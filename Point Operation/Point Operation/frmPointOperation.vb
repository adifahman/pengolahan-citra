﻿Public Class frmPointOperation
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        dlgBrowse.Title = "Buka Gambar"
        dlgBrowse.Filter = "Gambar|*.bmp;*.gif;*.png;*.jpg;*.jpeg"
        If dlgBrowse.ShowDialog() = DialogResult.OK Then
            pbOrigin.Image = Image.FromFile(dlgBrowse.FileName)
            Dim img As New Bitmap(pbOrigin.Image)
            pbOrigin.Image = img
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
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey As Integer

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

    Private Sub btnBW2_Click(sender As Object, e As EventArgs) Handles btnBW2.Click
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row, count As Integer
            Dim red, green, blue, grey As Integer
            Dim tgrey, agrey As Integer

            pbBW2.Image = img

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3)
                    tgrey = tgrey + grey

                    count = count + 1
                Next
            Next

            agrey = tgrey / count

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3)
                    If grey >= agrey Then
                        img.SetPixel(col, row, Color.FromArgb(255, 255, 255))
                    Else
                        img.SetPixel(col, row, Color.FromArgb(0, 0, 0))
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub btnBrightness_Click(sender As Object, e As EventArgs) Handles btnBrightness.Click
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey, tbrightness As Integer

            pbBrightness.Image = img

            tbrightness = barBrightness.Value

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3) + tbrightness
                    If grey >= 255 Then
                        grey = 255
                    End If
                    If grey <= 0 Then
                        grey = 0
                    End If

                    img.SetPixel(col, row, Color.FromArgb(grey, grey, grey))
                Next
            Next
        End If
    End Sub

    Private Sub barBrightness_ValueChanged(sender As Object, e As EventArgs) Handles barBrightness.ValueChanged
        txtBrightness.Text = CStr(barBrightness.Value)
    End Sub

    Private Sub barContrast_ValueChanged(sender As Object, e As EventArgs) Handles barContrast.ValueChanged
        txtContrast.Text = CStr(barContrast.Value)
    End Sub

    Private Sub btnContrast_Click(sender As Object, e As EventArgs) Handles btnContrast.Click
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey, tcontrast As Integer

            pbContrast.Image = img

            tcontrast = barContrast.Value

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3) * tcontrast
                    If grey >= 255 Then
                        grey = 255
                    End If

                    img.SetPixel(col, row, Color.FromArgb(grey, grey, grey))
                Next
            Next
        End If
    End Sub

    Private Sub btnInverse_Click(sender As Object, e As EventArgs) Handles btnInverse.Click
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey As Integer

            pbInverse.Image = img

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = 255 - CInt((red + green + blue) / 3)

                    img.SetPixel(col, row, Color.FromArgb(grey, grey, grey))
                Next
            Next
        End If
    End Sub
End Class