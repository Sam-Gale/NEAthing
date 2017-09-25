<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.QuestionBox = New System.Windows.Forms.TextBox()
        Me.AnswerBox = New System.Windows.Forms.TextBox()
        Me.MarkBtn = New System.Windows.Forms.Button()
        Me.MarkImage = New System.Windows.Forms.PictureBox()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.MarkImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuestionBox
        '
        Me.QuestionBox.BackColor = System.Drawing.SystemColors.Control
        Me.QuestionBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.QuestionBox.Location = New System.Drawing.Point(12, 12)
        Me.QuestionBox.Multiline = True
        Me.QuestionBox.Name = "QuestionBox"
        Me.QuestionBox.ReadOnly = True
        Me.QuestionBox.Size = New System.Drawing.Size(260, 152)
        Me.QuestionBox.TabIndex = 0
        '
        'AnswerBox
        '
        Me.AnswerBox.Location = New System.Drawing.Point(88, 175)
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.Size = New System.Drawing.Size(100, 20)
        Me.AnswerBox.TabIndex = 1
        '
        'MarkBtn
        '
        Me.MarkBtn.Location = New System.Drawing.Point(113, 211)
        Me.MarkBtn.Name = "MarkBtn"
        Me.MarkBtn.Size = New System.Drawing.Size(75, 23)
        Me.MarkBtn.TabIndex = 3
        Me.MarkBtn.Text = "Mark"
        Me.MarkBtn.UseVisualStyleBackColor = True
        '
        'MarkImage
        '
        Me.MarkImage.Location = New System.Drawing.Point(195, 175)
        Me.MarkImage.Name = "MarkImage"
        Me.MarkImage.Size = New System.Drawing.Size(20, 20)
        Me.MarkImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MarkImage.TabIndex = 4
        Me.MarkImage.TabStop = False
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(43, 216)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(0, 13)
        Me.AnswerLabel.TabIndex = 5
        Me.AnswerLabel.Visible = False
        '
        'NextBtn
        '
        Me.NextBtn.Location = New System.Drawing.Point(197, 211)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(75, 23)
        Me.NextBtn.TabIndex = 6
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Answer:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.AnswerLabel)
        Me.Controls.Add(Me.MarkImage)
        Me.Controls.Add(Me.MarkBtn)
        Me.Controls.Add(Me.AnswerBox)
        Me.Controls.Add(Me.QuestionBox)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.MarkImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AnswerBox As System.Windows.Forms.TextBox
    Friend WithEvents MarkBtn As System.Windows.Forms.Button
    Friend WithEvents MarkImage As System.Windows.Forms.PictureBox
    Friend WithEvents AnswerLabel As System.Windows.Forms.Label
    Friend WithEvents NextBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents QuestionBox As System.Windows.Forms.TextBox
End Class
