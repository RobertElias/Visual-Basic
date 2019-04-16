<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtLeftValue = New System.Windows.Forms.TextBox()
        Me.txtRightValue = New System.Windows.Forms.TextBox()
        Me.btnSummarize = New System.Windows.Forms.Button()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLeftValue
        '
        Me.txtLeftValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeftValue.Location = New System.Drawing.Point(25, 47)
        Me.txtLeftValue.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLeftValue.MaximumSize = New System.Drawing.Size(75, 75)
        Me.txtLeftValue.Name = "txtLeftValue"
        Me.txtLeftValue.Size = New System.Drawing.Size(75, 49)
        Me.txtLeftValue.TabIndex = 0
        '
        'txtRightValue
        '
        Me.txtRightValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRightValue.Location = New System.Drawing.Point(475, 47)
        Me.txtRightValue.Margin = New System.Windows.Forms.Padding(20)
        Me.txtRightValue.MaximumSize = New System.Drawing.Size(75, 75)
        Me.txtRightValue.Name = "txtRightValue"
        Me.txtRightValue.Size = New System.Drawing.Size(75, 49)
        Me.txtRightValue.TabIndex = 1
        '
        'btnSummarize
        '
        Me.btnSummarize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummarize.Location = New System.Drawing.Point(207, 113)
        Me.btnSummarize.Name = "btnSummarize"
        Me.btnSummarize.Size = New System.Drawing.Size(228, 61)
        Me.btnSummarize.TabIndex = 2
        Me.btnSummarize.Text = "Summarize"
        Me.btnSummarize.UseVisualStyleBackColor = True
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(49, 234)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(0, 25)
        Me.lblSummary.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 489)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.btnSummarize)
        Me.Controls.Add(Me.txtRightValue)
        Me.Controls.Add(Me.txtLeftValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLeftValue As TextBox
    Friend WithEvents txtRightValue As TextBox
    Friend WithEvents btnSummarize As Button
    Friend WithEvents lblSummary As Label
End Class
