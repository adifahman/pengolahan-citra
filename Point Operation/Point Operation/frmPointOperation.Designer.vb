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
        Me.tbBW = New System.Windows.Forms.TabPage()
        Me.btnBW = New System.Windows.Forms.Button()
        Me.pbBW = New System.Windows.Forms.PictureBox()
        Me.dlgBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.tcPointOP.SuspendLayout()
        Me.tabOrigin.SuspendLayout()
        CType(Me.pbOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrayscale.SuspendLayout()
        CType(Me.pbGrayscale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBW.SuspendLayout()
        CType(Me.pbBW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcPointOP
        '
        Me.tcPointOP.Controls.Add(Me.tabOrigin)
        Me.tcPointOP.Controls.Add(Me.tabGrayscale)
        Me.tcPointOP.Controls.Add(Me.tbBW)
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
        'tbBW
        '
        Me.tbBW.Controls.Add(Me.btnBW)
        Me.tbBW.Controls.Add(Me.pbBW)
        Me.tbBW.Location = New System.Drawing.Point(4, 25)
        Me.tbBW.Name = "tbBW"
        Me.tbBW.Size = New System.Drawing.Size(950, 600)
        Me.tbBW.TabIndex = 2
        Me.tbBW.Text = "Hitam Putih"
        Me.tbBW.UseVisualStyleBackColor = True
        '
        'btnBW
        '
        Me.btnBW.Location = New System.Drawing.Point(869, 563)
        Me.btnBW.Name = "btnBW"
        Me.btnBW.Size = New System.Drawing.Size(75, 23)
        Me.btnBW.TabIndex = 4
        Me.btnBW.Text = "Proses"
        Me.btnBW.UseVisualStyleBackColor = True
        '
        'pbBW
        '
        Me.pbBW.Location = New System.Drawing.Point(6, 6)
        Me.pbBW.Name = "pbBW"
        Me.pbBW.Size = New System.Drawing.Size(938, 551)
        Me.pbBW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBW.TabIndex = 3
        Me.pbBW.TabStop = False
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
        Me.tbBW.ResumeLayout(False)
        CType(Me.pbBW, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbBW As TabPage
    Friend WithEvents btnBW As Button
    Friend WithEvents pbBW As PictureBox
End Class
