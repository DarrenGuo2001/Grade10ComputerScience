<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.rbLd = New System.Windows.Forms.RadioButton()
        Me.rbPb = New System.Windows.Forms.RadioButton()
        Me.rbLe = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(118, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Question 1"
        '
        'btnNext
        '
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNext.Location = New System.Drawing.Point(122, 267)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(92, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'rbLd
        '
        Me.rbLd.AutoSize = True
        Me.rbLd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbLd.Location = New System.Drawing.Point(142, 215)
        Me.rbLd.Name = "rbLd"
        Me.rbLd.Size = New System.Drawing.Size(37, 17)
        Me.rbLd.TabIndex = 6
        Me.rbLd.TabStop = True
        Me.rbLd.Text = "Ld"
        Me.rbLd.UseVisualStyleBackColor = True
        '
        'rbPb
        '
        Me.rbPb.AutoSize = True
        Me.rbPb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbPb.Location = New System.Drawing.Point(142, 178)
        Me.rbPb.Name = "rbPb"
        Me.rbPb.Size = New System.Drawing.Size(38, 17)
        Me.rbPb.TabIndex = 7
        Me.rbPb.TabStop = True
        Me.rbPb.Text = "Pb"
        Me.rbPb.UseVisualStyleBackColor = True
        '
        'rbLe
        '
        Me.rbLe.AutoSize = True
        Me.rbLe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbLe.Location = New System.Drawing.Point(142, 144)
        Me.rbLe.Name = "rbLe"
        Me.rbLe.Size = New System.Drawing.Size(37, 17)
        Me.rbLe.TabIndex = 8
        Me.rbLe.TabStop = True
        Me.rbLe.Text = "Le"
        Me.rbLe.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(95, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 36)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "What is the chemical " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sybmol for lead?"
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbLe)
        Me.Controls.Add(Me.rbPb)
        Me.Controls.Add(Me.rbLd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "frmQuestion1"
        Me.Text = "Question 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents rbLd As System.Windows.Forms.RadioButton
    Friend WithEvents rbPb As System.Windows.Forms.RadioButton
    Friend WithEvents rbLe As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
