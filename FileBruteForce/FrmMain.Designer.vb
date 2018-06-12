<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.TbFile = New System.Windows.Forms.TextBox()
        Me.BtnBrute = New System.Windows.Forms.Button()
        Me.TbCurAtt = New System.Windows.Forms.TextBox()
        Me.TbToAtt = New System.Windows.Forms.TextBox()
        Me.LbFile = New System.Windows.Forms.Label()
        Me.LbCurAtt = New System.Windows.Forms.Label()
        Me.LbToAtt = New System.Windows.Forms.Label()
        Me.LbTime = New System.Windows.Forms.Label()
        Me.TbTime = New System.Windows.Forms.TextBox()
        Me.TbAttPs = New System.Windows.Forms.TextBox()
        Me.LbAttPs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbFile
        '
        Me.TbFile.Location = New System.Drawing.Point(61, 14)
        Me.TbFile.Name = "TbFile"
        Me.TbFile.Size = New System.Drawing.Size(285, 20)
        Me.TbFile.TabIndex = 0
        Me.TbFile.Text = "E:\-= Programming =-\-=Projects=-\FileBruteForce\test.zip"
        '
        'BtnBrute
        '
        Me.BtnBrute.Location = New System.Drawing.Point(18, 144)
        Me.BtnBrute.Name = "BtnBrute"
        Me.BtnBrute.Size = New System.Drawing.Size(328, 28)
        Me.BtnBrute.TabIndex = 1
        Me.BtnBrute.Text = "Brute It!"
        Me.BtnBrute.UseVisualStyleBackColor = True
        '
        'TbCurAtt
        '
        Me.TbCurAtt.Location = New System.Drawing.Point(152, 40)
        Me.TbCurAtt.Name = "TbCurAtt"
        Me.TbCurAtt.Size = New System.Drawing.Size(194, 20)
        Me.TbCurAtt.TabIndex = 2
        Me.TbCurAtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbToAtt
        '
        Me.TbToAtt.Location = New System.Drawing.Point(152, 66)
        Me.TbToAtt.Name = "TbToAtt"
        Me.TbToAtt.Size = New System.Drawing.Size(194, 20)
        Me.TbToAtt.TabIndex = 3
        Me.TbToAtt.Text = "0"
        Me.TbToAtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbFile
        '
        Me.LbFile.AutoSize = True
        Me.LbFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFile.Location = New System.Drawing.Point(15, 16)
        Me.LbFile.Name = "LbFile"
        Me.LbFile.Size = New System.Drawing.Size(40, 18)
        Me.LbFile.TabIndex = 4
        Me.LbFile.Text = "File:"
        '
        'LbCurAtt
        '
        Me.LbCurAtt.AutoSize = True
        Me.LbCurAtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCurAtt.Location = New System.Drawing.Point(15, 42)
        Me.LbCurAtt.Name = "LbCurAtt"
        Me.LbCurAtt.Size = New System.Drawing.Size(131, 18)
        Me.LbCurAtt.TabIndex = 5
        Me.LbCurAtt.Text = "Current Attempt:"
        '
        'LbToAtt
        '
        Me.LbToAtt.AutoSize = True
        Me.LbToAtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbToAtt.Location = New System.Drawing.Point(15, 68)
        Me.LbToAtt.Name = "LbToAtt"
        Me.LbToAtt.Size = New System.Drawing.Size(122, 18)
        Me.LbToAtt.TabIndex = 6
        Me.LbToAtt.Text = "Total Attempts:"
        '
        'LbTime
        '
        Me.LbTime.AutoSize = True
        Me.LbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTime.Location = New System.Drawing.Point(15, 120)
        Me.LbTime.Name = "LbTime"
        Me.LbTime.Size = New System.Drawing.Size(107, 18)
        Me.LbTime.TabIndex = 7
        Me.LbTime.Text = "Runing Time:"
        '
        'TbTime
        '
        Me.TbTime.Location = New System.Drawing.Point(152, 118)
        Me.TbTime.Name = "TbTime"
        Me.TbTime.Size = New System.Drawing.Size(194, 20)
        Me.TbTime.TabIndex = 8
        Me.TbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbAttPs
        '
        Me.TbAttPs.Location = New System.Drawing.Point(152, 92)
        Me.TbAttPs.Name = "TbAttPs"
        Me.TbAttPs.Size = New System.Drawing.Size(194, 20)
        Me.TbAttPs.TabIndex = 10
        Me.TbAttPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbAttPs
        '
        Me.LbAttPs.AutoSize = True
        Me.LbAttPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAttPs.Location = New System.Drawing.Point(15, 94)
        Me.LbAttPs.Name = "LbAttPs"
        Me.LbAttPs.Size = New System.Drawing.Size(122, 18)
        Me.LbAttPs.TabIndex = 9
        Me.LbAttPs.Text = "Attempts per/s:"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 192)
        Me.Controls.Add(Me.TbAttPs)
        Me.Controls.Add(Me.LbAttPs)
        Me.Controls.Add(Me.TbTime)
        Me.Controls.Add(Me.LbTime)
        Me.Controls.Add(Me.LbToAtt)
        Me.Controls.Add(Me.LbCurAtt)
        Me.Controls.Add(Me.LbFile)
        Me.Controls.Add(Me.TbToAtt)
        Me.Controls.Add(Me.TbCurAtt)
        Me.Controls.Add(Me.BtnBrute)
        Me.Controls.Add(Me.TbFile)
        Me.Name = "FrmMain"
        Me.Text = "FileBruteForce"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbFile As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrute As System.Windows.Forms.Button
    Friend WithEvents TbCurAtt As System.Windows.Forms.TextBox
    Friend WithEvents TbToAtt As System.Windows.Forms.TextBox
    Friend WithEvents LbFile As System.Windows.Forms.Label
    Friend WithEvents LbCurAtt As System.Windows.Forms.Label
    Friend WithEvents LbToAtt As System.Windows.Forms.Label
    Friend WithEvents LbTime As System.Windows.Forms.Label
    Friend WithEvents TbTime As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TbAttPs As System.Windows.Forms.TextBox
    Friend WithEvents LbAttPs As System.Windows.Forms.Label

End Class
