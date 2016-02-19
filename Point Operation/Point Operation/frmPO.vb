Public Class frmPO
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        dlgOpen.Title = "Buka Gambar"
        dlgOpen.Filter = "Gambar|*.bmp;*.gif;*.png;*.jpg;*.jpeg"
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            pbOrigin.Image = Image.FromFile(dlgOpen.FileName)
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

            pbResult.Image = img

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

    Private Sub btnBW_Click(sender As Object, e As EventArgs) Handles btnBW.Click
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey As Integer

            pbResult.Image = img

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

    Private Sub btnContrast_Click(sender As Object, e As EventArgs) Handles btnContrast.Click
        Dim tContrast As String

        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            tContrast = InputBox("Masukan Besarnya Contrast", "Contrast", 1)
            If tContrast = "" Then
                Exit Sub
            End If

            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey As Integer

            pbResult.Image = img

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

    Private Sub btnBrightness_Click(sender As Object, e As EventArgs) Handles btnBrightness.Click
        Dim tBrightness As String

        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            tBrightness = InputBox("Masukan Besarnya Brightness", "Brightness", 1)
            If tBrightness = "" Then
                Exit Sub
            End If

            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey As Integer

            pbResult.Image = img

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3) + CInt(tBrightness)

                    If grey >= 255 Then
                        grey = 255
                    ElseIf grey <= 0 Then
                        grey = 0
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

            pbResult.Image = img

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

    Private Sub btnBit_Click(sender As Object, e As EventArgs) Handles btnBit.Click
        If pbOrigin.Image Is Nothing Then
            MsgBox("Silahkan pilih gambar yang akan di proses terlebih dahulu !", MsgBoxStyle.Exclamation, "Tidak Ada Gambar")
        Else
            Dim mBit As String

            mBit = InputBox("Masukan Besarnya Bit", "Bit", 1)
            If mBit = "" Then
                Exit Sub
            End If

            Dim conversion As Integer
            Dim img As New Bitmap(pbOrigin.Image)
            Dim col, row As Integer
            Dim red, green, blue, grey As Integer

            conversion = 255 / (CInt(mBit) - 1)

            pbResult.Image = img

            For col = 0 To img.Width - 1
                For row = 0 To img.Height - 1
                    red = img.GetPixel(col, row).R
                    green = img.GetPixel(col, row).G
                    blue = img.GetPixel(col, row).B

                    grey = CInt((red + green + blue) / 3)
                    grey = CInt((grey / conversion) + 0.5) * conversion

                    If grey >= 255 Then
                        grey = 255
                    End If

                    img.SetPixel(col, row, Color.FromArgb(grey, grey, grey))
                Next
            Next
        End If
    End Sub
End Class
