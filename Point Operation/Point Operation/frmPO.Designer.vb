<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPO
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
        Me.btnBit = New System.Windows.Forms.Button()
        Me.btnInverse = New System.Windows.Forms.Button()
        Me.btnBrightness = New System.Windows.Forms.Button()
        Me.btnContrast = New System.Windows.Forms.Button()
        Me.btnBW = New System.Windows.Forms.Button()
        Me.btnGrayscale = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.pbResult = New System.Windows.Forms.PictureBox()
        Me.pbOrigin = New System.Windows.Forms.PictureBox()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.lblOrigin = New System.Windows.Forms.Label()
        CType(Me.pbResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBit
        '
        Me.btnBit.Location = New System.Drawing.Point(560, 246)
        Me.btnBit.Name = "btnBit"
        Me.btnBit.Size = New System.Drawing.Size(88, 35)
        Me.btnBit.TabIndex = 17
        Me.btnBit.Text = "m Bit"
        Me.btnBit.UseVisualStyleBackColor = True
        '
        'btnInverse
        '
        Me.btnInverse.Location = New System.Drawing.Point(560, 205)
        Me.btnInverse.Name = "btnInverse"
        Me.btnInverse.Size = New System.Drawing.Size(88, 35)
        Me.btnInverse.TabIndex = 16
        Me.btnInverse.Text = "Inverse"
        Me.btnInverse.UseVisualStyleBackColor = True
        '
        'btnBrightness
        '
        Me.btnBrightness.Location = New System.Drawing.Point(560, 164)
        Me.btnBrightness.Name = "btnBrightness"
        Me.btnBrightness.Size = New System.Drawing.Size(88, 35)
        Me.btnBrightness.TabIndex = 15
        Me.btnBrightness.Text = "Brigtness"
        Me.btnBrightness.UseVisualStyleBackColor = True
        '
        'btnContrast
        '
        Me.btnContrast.Location = New System.Drawing.Point(560, 123)
        Me.btnContrast.Name = "btnContrast"
        Me.btnContrast.Size = New System.Drawing.Size(88, 35)
        Me.btnContrast.TabIndex = 14
        Me.btnContrast.Text = "Contrast"
        Me.btnContrast.UseVisualStyleBackColor = True
        '
        'btnBW
        '
        Me.btnBW.Location = New System.Drawing.Point(560, 82)
        Me.btnBW.Name = "btnBW"
        Me.btnBW.Size = New System.Drawing.Size(88, 35)
        Me.btnBW.TabIndex = 13
        Me.btnBW.Text = "BW"
        Me.btnBW.UseVisualStyleBackColor = True
        '
        'btnGrayscale
        '
        Me.btnGrayscale.Location = New System.Drawing.Point(560, 41)
        Me.btnGrayscale.Name = "btnGrayscale"
        Me.btnGrayscale.Size = New System.Drawing.Size(88, 35)
        Me.btnGrayscale.TabIndex = 12
        Me.btnGrayscale.Text = "Grayscale"
        Me.btnGrayscale.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(413, 689)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(141, 32)
        Me.btnOpen.TabIndex = 11
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'pbResult
        '
        Me.pbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbResult.Location = New System.Drawing.Point(654, 41)
        Me.pbResult.Name = "pbResult"
        Me.pbResult.Size = New System.Drawing.Size(542, 642)
        Me.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbResult.TabIndex = 10
        Me.pbResult.TabStop = False
        '
        'pbOrigin
        '
        Me.pbOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbOrigin.Location = New System.Drawing.Point(12, 41)
        Me.pbOrigin.Name = "pbOrigin"
        Me.pbOrigin.Size = New System.Drawing.Size(542, 642)
        Me.pbOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbOrigin.TabIndex = 9
        Me.pbOrigin.TabStop = False
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        '
        'lblOrigin
        '
        Me.lblOrigin.AutoSize = True
        Me.lblOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigin.Location = New System.Drawing.Point(12, 9)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(161, 29)
        Me.lblOrigin.TabIndex = 18
        Me.lblOrigin.Text = "Gambar Asal"
        '
        'frmPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 727)
        Me.Controls.Add(Me.lblOrigin)
        Me.Controls.Add(Me.btnBit)
        Me.Controls.Add(Me.btnInverse)
        Me.Controls.Add(Me.btnBrightness)
        Me.Controls.Add(Me.btnContrast)
        Me.Controls.Add(Me.btnBW)
        Me.Controls.Add(Me.btnGrayscale)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.pbResult)
        Me.Controls.Add(Me.pbOrigin)
        Me.Name = "frmPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point Operation"
        CType(Me.pbResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBit As Button
    Friend WithEvents btnInverse As Button
    Friend WithEvents btnBrightness As Button
    Friend WithEvents btnContrast As Button
    Friend WithEvents btnBW As Button
    Friend WithEvents btnGrayscale As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents pbResult As PictureBox
    Friend WithEvents pbOrigin As PictureBox
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents lblOrigin As Label
End Class
