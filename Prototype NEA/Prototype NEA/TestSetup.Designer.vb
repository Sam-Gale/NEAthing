<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestSetup
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
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TopicCombo = New System.Windows.Forms.ComboBox()
        Me.DiffCombo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Difficulty:"
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(104, 110)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(75, 23)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Topic:"
        '
        'TopicCombo
        '
        Me.TopicCombo.FormattingEnabled = True
        Me.TopicCombo.Location = New System.Drawing.Point(82, 20)
        Me.TopicCombo.Name = "TopicCombo"
        Me.TopicCombo.Size = New System.Drawing.Size(121, 21)
        Me.TopicCombo.TabIndex = 4
        '
        'DiffCombo
        '
        Me.DiffCombo.FormattingEnabled = True
        Me.DiffCombo.Location = New System.Drawing.Point(82, 61)
        Me.DiffCombo.Name = "DiffCombo"
        Me.DiffCombo.Size = New System.Drawing.Size(121, 21)
        Me.DiffCombo.TabIndex = 5
        '
        'TestSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.DiffCombo)
        Me.Controls.Add(Me.TopicCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TestSetup"
        Me.Text = "Topic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TopicCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DiffCombo As System.Windows.Forms.ComboBox
End Class
