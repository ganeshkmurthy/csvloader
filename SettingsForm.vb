Public Class SettingsForm

    Private Sub SettingsForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtFileName.Text = CSVLoader.Settings.FileName
        txtColumnHeaders.Text = CSVLoader.Settings.ColumnHeaders
        txtArticleText.Text = CSVLoader.Settings.InputText
        optAppend.Checked = (CSVLoader.Settings.TextMode = "Append")
        optPrepend.Checked = (CSVLoader.Settings.TextMode = "Prepend")
        optReplace.Checked = (CSVLoader.Settings.TextMode = "Replace")
        chkSkip.Checked = CSVLoader.Settings.Skip
        txtSeperator.Text = CSVLoader.Settings.Separator
        chkCreateLists.Checked = CSVLoader.Settings.CreateLists
        txtListSeperator.Text = CSVLoader.Settings.ListSeparator
        chkFindReplace.Checked = CSVLoader.Settings.FindReplace
        txtEditSummary.Text = CSVLoader.Settings.EditSummary
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        CSVLoader.Settings.ColumnHeaders = Trim(txtColumnHeaders.Text)
        CSVLoader.Settings.InputText = txtArticleText.Text
        If optAppend.Checked Then
            CSVLoader.Settings.TextMode = "Append"
        End If
        If optPrepend.Checked Then
            CSVLoader.Settings.TextMode = "Prepend"
        End If
        If optReplace.Checked Then
            CSVLoader.Settings.TextMode = "Replace"
        End If
        CSVLoader.Settings.Skip = chkSkip.Checked
        CSVLoader.Settings.Separator = Trim(txtSeperator.Text)
        CSVLoader.Settings.CreateLists = chkCreateLists.Checked
        CSVLoader.Settings.ListSeparator = Trim(txtListSeperator.Text)
        CSVLoader.Settings.FindReplace = chkFindReplace.Checked
        CSVLoader.Settings.EditSummary = txtEditSummary.Text
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class