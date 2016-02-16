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
        Me.dlgBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.tcPointOP.SuspendLayout()
        Me.tabOrigin.SuspendLayout()
        CType(Me.pbOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrayscale.SuspendLayout()
        CType(Me.pbGrayscale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBW1.SuspendLayout()
        CType(Me.pbBW1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBW2.SuspendLayout()
        CType(Me.pbBW2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcPointOP
        '
        Me.tcPointOP.Controls.Add(Me.tabOrigin)
        Me.tcPointOP.Controls.Add(Me.tabGrayscale)
        Me.tcPointOP.Controls.Add(Me.tbBW1)
        Me.tcPointOP.Controls.Add(Me.tbBW2)
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
        'dlgBrowse
        '
        Me.dlgBrowse.FileName = "OpenFileDialog1"
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
End Class
