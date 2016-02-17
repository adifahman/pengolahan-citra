<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPointOperation
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
        Me.tcPointOP = New System.Windows.Forms.TabControl()
        Me.tabOrigin = New System.Windows.Forms.TabPage()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.pbOrigin = New System.Windows.Forms.PictureBox()
        Me.tabGrayscale = New System.Windows.Forms.TabPage()
        Me.btnGrayscale = New System.Windows.Forms.Button()
        Me.pbGrayscale = New System.Windows.Forms.PictureBox()
        Me.tbBW1 = New System.Windows.Forms.TabPage()
        Me.btnBW1 = New System.Windows.Forms.Button()
        Me.pbBW1 = New System.Windows.Forms.PictureBox()
        Me.tbBW2 = New System.Windows.Forms.TabPage()
        Me.btnBW2 = New System.Windows.Forms.Button()
        Me.pbBW2 = New System.Windows.Forms.PictureBox()
        Me.tbBrightness = New System.Windows.Forms.TabPage()
        Me.txtBrightness = New System.Windows.Forms.TextBox()
        Me.barBrightness = New System.Windows.Forms.TrackBar()
        Me.btnBrightness = New System.Windows.Forms.Button()
        Me.pbBrightness = New System.Windows.Forms.PictureBox()
        Me.tbContrast = New System.Windows.Forms.TabPage()
        Me.txtContrast = New System.Windows.Forms.TextBox()
        Me.barContrast = New System.Windows.Forms.TrackBar()
        Me.btnContrast = New System.Windows.Forms.Button()
        Me.pbContrast = New System.Windows.Forms.PictureBox()
        Me.dlgBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.tbInverse = New System.Windows.Forms.TabPage()
        Me.btnInverse = New System.Windows.Forms.Button()
        Me.pbInverse = New System.Windows.Forms.PictureBox()
        Me.tcPointOP.SuspendLayout()
        Me.tabOrigin.SuspendLayout()
        CType(Me.pbOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrayscale.SuspendLayout()
        CType(Me.pbGrayscale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBW1.SuspendLayout()
        CType(Me.pbBW1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBW2.SuspendLayout()
        CType(Me.pbBW2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBrightness.SuspendLayout()
        CType(Me.barBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbContrast.SuspendLayout()
        CType(Me.barContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbInverse.SuspendLayout()
        CType(Me.pbInverse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcPointOP
        '
        Me.tcPointOP.Controls.Add(Me.tabOrigin)
        Me.tcPointOP.Controls.Add(Me.tabGrayscale)
        Me.tcPointOP.Controls.Add(Me.tbBW1)
        Me.tcPointOP.Controls.Add(Me.tbBW2)
        Me.tcPointOP.Controls.Add(Me.tbBrightness)
        Me.tcPointOP.Controls.Add(Me.tbContrast)
        Me.tcPointOP.Controls.Add(Me.tbInverse)
        Me.tcPointOP.Location = New System.Drawing.Point(12, 12)
        Me.tcPointOP.Name = "tcPointOP"
        Me.tcPointOP.SelectedIndex = 0
        Me.tcPointOP.Size = New System.Drawing.Size(958, 629)
        Me.tcPointOP.TabIndex = 0
        '
        'tabOrigin
        '
        Me.tabOrigin.Controls.Add(Me.btnBrowse)
        Me.tabOrigin.Controls.Add(Me.pbOrigin)
        Me.tabOrigin.Location = New System.Drawing.Point(4, 25)
        Me.tabOrigin.Name = "tabOrigin"
        Me.tabOrigin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrigin.Size = New System.Drawing.Size(950, 600)
        Me.tabOrigin.TabIndex = 0
        Me.tabOrigin.Text = "Gambar Asli"
        Me.tabOrigin.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(869, 563)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse.."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'pbOrigin
        '
        Me.pbOrigin.Location = New System.Drawing.Point(6, 6)
        Me.pbOrigin.Name = "pbOrigin"
        Me.pbOrigin.Size = New System.Drawing.Size(938, 551)
        Me.pbOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbOrigin.TabIndex = 0
        Me.pbOrigin.TabStop = False
        '
        'tabGrayscale
        '
        Me.tabGrayscale.Controls.Add(Me.btnGrayscale)
        Me.tabGrayscale.Controls.Add(Me.pbGrayscale)
        Me.tabGrayscale.Location = New System.Drawing.Point(4, 25)
        Me.tabGrayscale.Name = "tabGrayscale"
        Me.tabGrayscale.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGrayscale.Size = New System.Drawing.Size(950, 600)
        Me.tabGrayscale.TabIndex = 1
        Me.tabGrayscale.Text = "Grayscale"
        Me.tabGrayscale.UseVisualStyleBackColor = True
        '
        'btnGrayscale
        '
        Me.btnGrayscale.Location = New System.Drawing.Point(869, 563)
        Me.btnGrayscale.Name = "btnGrayscale"
        Me.btnGrayscale.Size = New System.Drawing.Size(75, 23)
        Me.btnGrayscale.TabIndex = 2
        Me.btnGrayscale.Text = "Proses"
        Me.btnGrayscale.UseVisualStyleBackColor = True
        '
        'pbGrayscale
        '
        Me.pbGrayscale.Location = New System.Drawing.Point(6, 6)
        Me.pbGrayscale.Name = "pbGrayscale"
        Me.pbGrayscale.Size = New System.Drawing.Size(938, 551)
        Me.pbGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGrayscale.TabIndex = 1
        Me.pbGrayscale.TabStop = False
        '
        'tbBW1
        '
        Me.tbBW1.Controls.Add(Me.btnBW1)
        Me.tbBW1.Controls.Add(Me.pbBW1)
        Me.tbBW1.Location = New System.Drawing.Point(4, 25)
        Me.tbBW1.Name = "tbBW1"
        Me.tbBW1.Size = New System.Drawing.Size(950, 600)
        Me.tbBW1.TabIndex = 2
        Me.tbBW1.Text = "Hitam Putih 1"
        Me.tbBW1.UseVisualStyleBackColor = True
        '
        'btnBW1
        '
        Me.btnBW1.Location = New System.Drawing.Point(869, 563)
        Me.btnBW1.Name = "btnBW1"
        Me.btnBW1.Size = New System.Drawing.Size(75, 23)
        Me.btnBW1.TabIndex = 4
        Me.btnBW1.Text = "Proses"
        Me.btnBW1.UseVisualStyleBackColor = True
        '
        'pbBW1
        '
        Me.pbBW1.Location = New System.Drawing.Point(6, 6)
        Me.pbBW1.Name = "pbBW1"
        Me.pbBW1.Size = New System.Drawing.Size(938, 551)
        Me.pbBW1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBW1.TabIndex = 3
        Me.pbBW1.TabStop = False
        '
        'tbBW2
        '
        Me.tbBW2.Controls.Add(Me.btnBW2)
        Me.tbBW2.Controls.Add(Me.pbBW2)
        Me.tbBW2.Location = New System.Drawing.Point(4, 25)
        Me.tbBW2.Name = "tbBW2"
        Me.tbBW2.Size = New System.Drawing.Size(950, 600)
        Me.tbBW2.TabIndex = 3
        Me.tbBW2.Text = "Hitam Putih 2"
        Me.tbBW2.UseVisualStyleBackColor = True
        '
        'btnBW2
        '
        Me.btnBW2.Location = New System.Drawing.Point(869, 563)
        Me.btnBW2.Name = "btnBW2"
        Me.btnBW2.Size = New System.Drawing.Size(75, 23)
        Me.btnBW2.TabIndex = 6
        Me.btnBW2.Text = "Proses"
        Me.btnBW2.UseVisualStyleBackColor = True
        '
        'pbBW2
        '
        Me.pbBW2.Location = New System.Drawing.Point(6, 6)
        Me.pbBW2.Name = "pbBW2"
        Me.pbBW2.Size = New System.Drawing.Size(938, 551)
        Me.pbBW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBW2.TabIndex = 5
        Me.pbBW2.TabStop = False
        '
        'tbBrightness
        '
        Me.tbBrightness.Controls.Add(Me.txtBrightness)
        Me.tbBrightness.Controls.Add(Me.barBrightness)
        Me.tbBrightness.Controls.Add(Me.btnBrightness)
        Me.tbBrightness.Controls.Add(Me.pbBrightness)
        Me.tbBrightness.Location = New System.Drawing.Point(4, 25)
        Me.tbBrightness.Name = "tbBrightness"
        Me.tbBrightness.Size = New System.Drawing.Size(950, 600)
        Me.tbBrightness.TabIndex = 4
        Me.tbBrightness.Text = "Brightness"
        Me.tbBrightness.UseVisualStyleBackColor = True
        '
        'txtBrightness
        '
        Me.txtBrightness.Enabled = False
        Me.txtBrightness.Location = New System.Drawing.Point(823, 563)
        Me.txtBrightness.MaxLength = 3
        Me.txtBrightness.Name = "txtBrightness"
        Me.txtBrightness.Size = New System.Drawing.Size(40, 22)
        Me.txtBrightness.TabIndex = 11
        Me.txtBrightness.Text = "0"
        '
        'barBrightness
        '
        Me.barBrightness.BackColor = System.Drawing.Color.White
        Me.barBrightness.Location = New System.Drawing.Point(6, 563)
        Me.barBrightness.Maximum = 255
        Me.barBrightness.Minimum = -255
        Me.barBrightness.Name = "barBrightness"
        Me.barBrightness.Size = New System.Drawing.Size(811, 56)
        Me.barBrightness.TabIndex = 10
        Me.barBrightness.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'btnBrightness
        '
        Me.btnBrightness.Location = New System.Drawing.Point(869, 563)
        Me.btnBrightness.Name = "btnBrightness"
        Me.btnBrightness.Size = New System.Drawing.Size(75, 23)
        Me.btnBrightness.TabIndex = 8
        Me.btnBrightness.Text = "Proses"
        Me.btnBrightness.UseVisualStyleBackColor = True
        '
        'pbBrightness
        '
        Me.pbBrightness.Location = New System.Drawing.Point(6, 6)
        Me.pbBrightness.Name = "pbBrightness"
        Me.pbBrightness.Size = New System.Drawing.Size(938, 551)
        Me.pbBrightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBrightness.TabIndex = 7
        Me.pbBrightness.TabStop = False
        '
        'tbContrast
        '
        Me.tbContrast.Controls.Add(Me.txtContrast)
        Me.tbContrast.Controls.Add(Me.barContrast)
        Me.tbContrast.Controls.Add(Me.btnContrast)
        Me.tbContrast.Controls.Add(Me.pbContrast)
        Me.tbContrast.Location = New System.Drawing.Point(4, 25)
        Me.tbContrast.Name = "tbContrast"
        Me.tbContrast.Size = New System.Drawing.Size(950, 600)
        Me.tbContrast.TabIndex = 5
        Me.tbContrast.Text = "Contrast"
        Me.tbContrast.UseVisualStyleBackColor = True
        '
        'txtContrast
        '
        Me.txtContrast.Enabled = False
        Me.txtContrast.Location = New System.Drawing.Point(823, 563)
        Me.txtContrast.MaxLength = 3
        Me.txtContrast.Name = "txtContrast"
        Me.txtContrast.Size = New System.Drawing.Size(40, 22)
        Me.txtContrast.TabIndex = 12
        Me.txtContrast.Text = "0"
        '
        'barContrast
        '
        Me.barContrast.BackColor = System.Drawing.Color.White
        Me.barContrast.LargeChange = 1
        Me.barContrast.Location = New System.Drawing.Point(6, 563)
        Me.barContrast.Maximum = 5
        Me.barContrast.Name = "barContrast"
        Me.barContrast.Size = New System.Drawing.Size(811, 56)
        Me.barContrast.TabIndex = 11
        Me.barContrast.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'btnContrast
        '
        Me.btnContrast.Location = New System.Drawing.Point(869, 563)
        Me.btnContrast.Name = "btnContrast"
        Me.btnContrast.Size = New System.Drawing.Size(75, 23)
        Me.btnContrast.TabIndex = 8
        Me.btnContrast.Text = "Proses"
        Me.btnContrast.UseVisualStyleBackColor = True
        '
        'pbContrast
        '
        Me.pbContrast.Location = New System.Drawing.Point(6, 6)
        Me.pbContrast.Name = "pbContrast"
        Me.pbContrast.Size = New System.Drawing.Size(938, 551)
        Me.pbContrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbContrast.TabIndex = 7
        Me.pbContrast.TabStop = False
        '
        'dlgBrowse
        '
        Me.dlgBrowse.FileName = "OpenFileDialog1"
        '
        'tbInverse
        '
        Me.tbInverse.Controls.Add(Me.btnInverse)
        Me.tbInverse.Controls.Add(Me.pbInverse)
        Me.tbInverse.Location = New System.Drawing.Point(4, 25)
        Me.tbInverse.Name = "tbInverse"
        Me.tbInverse.Size = New System.Drawing.Size(950, 600)
        Me.tbInverse.TabIndex = 6
        Me.tbInverse.Text = "Inverse"
        Me.tbInverse.UseVisualStyleBackColor = True
        '
        'btnInverse
        '
        Me.btnInverse.Location = New System.Drawing.Point(869, 563)
        Me.btnInverse.Name = "btnInverse"
        Me.btnInverse.Size = New System.Drawing.Size(75, 23)
        Me.btnInverse.TabIndex = 3
        Me.btnInverse.Text = "Proses"
        Me.btnInverse.UseVisualStyleBackColor = True
        '
        'pbInverse
        '
        Me.pbInverse.Location = New System.Drawing.Point(6, 6)
        Me.pbInverse.Name = "pbInverse"
        Me.pbInverse.Size = New System.Drawing.Size(938, 551)
        Me.pbInverse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbInverse.TabIndex = 2
        Me.pbInverse.TabStop = False
        '
        'frmPointOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.tcPointOP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPointOperation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point Operation"
        Me.tcPointOP.ResumeLayout(False)
        Me.tabOrigin.ResumeLayout(False)
        CType(Me.pbOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGrayscale.ResumeLayout(False)
        CType(Me.pbGrayscale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBW1.ResumeLayout(False)
        CType(Me.pbBW1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBW2.ResumeLayout(False)
        CType(Me.pbBW2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBrightness.ResumeLayout(False)
        Me.tbBrightness.PerformLayout()
        CType(Me.barBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbContrast.ResumeLayout(False)
        Me.tbContrast.PerformLayout()
        CType(Me.barContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbContrast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbInverse.ResumeLayout(False)
        CType(Me.pbInverse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcPointOP As TabControl
    Friend WithEvents tabOrigin As TabPage
    Friend WithEvents tabGrayscale As TabPage
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbOrigin As PictureBox
    Friend WithEvents dlgBrowse As OpenFileDialog
    Friend WithEvents pbGrayscale As PictureBox
    Friend WithEvents btnGrayscale As Button
    Friend WithEvents tbBW1 As TabPage
    Friend WithEvents btnBW1 As Button
    Friend WithEvents pbBW1 As PictureBox
    Friend WithEvents tbBW2 As TabPage
    Friend WithEvents btnBW2 As Button
    Friend WithEvents pbBW2 As PictureBox
    Friend WithEvents tbBrightness As TabPage
    Friend WithEvents btnBrightness As Button
    Friend WithEvents pbBrightness As PictureBox
    Friend WithEvents tbContrast As TabPage
    Friend WithEvents btnContrast As Button
    Friend WithEvents pbContrast As PictureBox
    Friend WithEvents barBrightness As TrackBar
    Friend WithEvents txtBrightness As TextBox
    Friend WithEvents txtContrast As TextBox
    Friend WithEvents barContrast As TrackBar
    Friend WithEvents tbInverse As TabPage
    Friend WithEvents btnInverse As Button
    Friend WithEvents pbInverse As PictureBox
End Class
