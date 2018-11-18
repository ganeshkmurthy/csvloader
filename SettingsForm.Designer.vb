<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optReplace = New System.Windows.Forms.RadioButton()
        Me.optPrepend = New System.Windows.Forms.RadioButton()
        Me.optAppend = New System.Windows.Forms.RadioButton()
        Me.txtArticleText = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtColumnHeaders = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkFindReplace = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtListSeperator = New System.Windows.Forms.TextBox()
        Me.chkCreateLists = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSeperator = New System.Windows.Forms.TextBox()
        Me.chkSkip = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtEditSummary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optReplace)
        Me.GroupBox1.Controls.Add(Me.optPrepend)
        Me.GroupBox1.Controls.Add(Me.optAppend)
        Me.GroupBox1.Controls.Add(Me.txtArticleText)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 213)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Append/Prepend/Replace text"
        '
        'optReplace
        '
        Me.optReplace.AutoSize = True
        Me.optReplace.Location = New System.Drawing.Point(335, 19)
        Me.optReplace.Name = "optReplace"
        Me.optReplace.Size = New System.Drawing.Size(65, 17)
        Me.optReplace.TabIndex = 11
        Me.optReplace.Text = "&Replace"
        Me.optReplace.UseVisualStyleBackColor = True
        '
        'optPrepend
        '
        Me.optPrepend.AutoSize = True
        Me.optPrepend.Location = New System.Drawing.Point(266, 19)
        Me.optPrepend.Name = "optPrepend"
        Me.optPrepend.Size = New System.Drawing.Size(65, 17)
        Me.optPrepend.TabIndex = 10
        Me.optPrepend.Text = "&Prepend"
        Me.optPrepend.UseVisualStyleBackColor = True
        '
        'optAppend
        '
        Me.optAppend.AutoSize = True
        Me.optAppend.Checked = True
        Me.optAppend.Location = New System.Drawing.Point(200, 19)
        Me.optAppend.Name = "optAppend"
        Me.optAppend.Size = New System.Drawing.Size(62, 17)
        Me.optAppend.TabIndex = 9
        Me.optAppend.TabStop = True
        Me.optAppend.Text = "&Append"
        Me.optAppend.UseVisualStyleBackColor = True
        '
        'txtArticleText
        '
        Me.txtArticleText.AcceptsReturn = True
        Me.txtArticleText.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticleText.Location = New System.Drawing.Point(12, 46)
        Me.txtArticleText.Multiline = True
        Me.txtArticleText.Name = "txtArticleText"
        Me.txtArticleText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtArticleText.Size = New System.Drawing.Size(388, 153)
        Me.txtArticleText.TabIndex = 12
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(257, 541)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(338, 541)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtColumnHeaders)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 52)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Column headers"
        '
        'txtColumnHeaders
        '
        Me.txtColumnHeaders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColumnHeaders.Location = New System.Drawing.Point(12, 19)
        Me.txtColumnHeaders.Name = "txtColumnHeaders"
        Me.txtColumnHeaders.Size = New System.Drawing.Size(389, 20)
        Me.txtColumnHeaders.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkFindReplace)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtListSeperator)
        Me.GroupBox3.Controls.Add(Me.chkCreateLists)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSeperator)
        Me.GroupBox3.Controls.Add(Me.chkSkip)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 124)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'chkFindReplace
        '
        Me.chkFindReplace.AutoSize = True
        Me.chkFindReplace.Location = New System.Drawing.Point(14, 90)
        Me.chkFindReplace.Name = "chkFindReplace"
        Me.chkFindReplace.Size = New System.Drawing.Size(105, 17)
        Me.chkFindReplace.TabIndex = 3
        Me.chkFindReplace.Text = "&Find and replace"
        Me.chkFindReplace.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&List separator"
        '
        'txtListSeperator
        '
        Me.txtListSeperator.Location = New System.Drawing.Point(336, 62)
        Me.txtListSeperator.Name = "txtListSeperator"
        Me.txtListSeperator.Size = New System.Drawing.Size(66, 20)
        Me.txtListSeperator.TabIndex = 7
        '
        'chkCreateLists
        '
        Me.chkCreateLists.AutoSize = True
        Me.chkCreateLists.Location = New System.Drawing.Point(14, 59)
        Me.chkCreateLists.Name = "chkCreateLists"
        Me.chkCreateLists.Size = New System.Drawing.Size(77, 17)
        Me.chkCreateLists.TabIndex = 2
        Me.chkCreateLists.Text = "&Create lists"
        Me.chkCreateLists.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "F&ield separator"
        '
        'txtSeperator
        '
        Me.txtSeperator.Location = New System.Drawing.Point(336, 29)
        Me.txtSeperator.Name = "txtSeperator"
        Me.txtSeperator.Size = New System.Drawing.Size(66, 20)
        Me.txtSeperator.TabIndex = 5
        '
        'chkSkip
        '
        Me.chkSkip.AutoSize = True
        Me.chkSkip.Location = New System.Drawing.Point(14, 28)
        Me.chkSkip.Name = "chkSkip"
        Me.chkSkip.Size = New System.Drawing.Size(164, 17)
        Me.chkSkip.TabIndex = 1
        Me.chkSkip.Text = "&Skip when no changes made"
        Me.chkSkip.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFileName)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 53)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Text file"
        '
        'txtFileName
        '
        Me.txtFileName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(13, 21)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(387, 20)
        Me.txtFileName.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtEditSummary)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 478)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(415, 53)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Edit summary"
        '
        'txtEditSummary
        '
        Me.txtEditSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditSummary.Location = New System.Drawing.Point(13, 19)
        Me.txtEditSummary.Name = "txtEditSummary"
        Me.txtEditSummary.Size = New System.Drawing.Size(389, 20)
        Me.txtEditSummary.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 546)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ver 1.0.0.21"
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(439, 576)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "SettingsForm"
        Me.ShowIcon = False
        Me.Text = "CSV Loader Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtArticleText As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents optPrepend As System.Windows.Forms.RadioButton
    Friend WithEvents optAppend As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtColumnHeaders As System.Windows.Forms.TextBox
    Friend WithEvents optReplace As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSkip As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSeperator As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtListSeperator As System.Windows.Forms.TextBox
    Friend WithEvents chkCreateLists As System.Windows.Forms.CheckBox
    Friend WithEvents chkFindReplace As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEditSummary As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As Label
End Class
