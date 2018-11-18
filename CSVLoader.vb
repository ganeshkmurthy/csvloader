'CSV Loader
'Ganesh Krishnamurthy, 2008-2014
'
'This program is free software; you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation; either version 2 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with this program; if not, write to the Free Software
'Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
Imports System.Text
Public Class CSVLoader

    Implements WikiFunctions.Plugin.IAWBPlugin

    ' AWB objects:
    Private Shared AWBForm As WikiFunctions.Plugin.IAutoWikiBrowser
    Private Shared AWBList As WikiFunctions.Controls.Lists.ListMaker
    Private Shared AWBReplace As WikiFunctions.Parse.FindandReplace

    ' Menu item:
    Private Const conOurName As String = "CSV Loader"
    Private Const conOurWikiName As String = conOurName & " Plugin"
    Private WithEvents OurMenuItem As New ToolStripMenuItem(conOurWikiName)

    'Settings Class and Settings Form
    Friend Shared Settings As New CSVSettings()
    Private SettingsForm As New SettingsForm()

    ' User input and state:
    Private HeaderArray() As String
    Private LastItem As Long
    Private ArticleList As New List(Of List(Of String))
    Private RuleList As New List(Of RuleSetting)

    Public Sub Initialise(ByVal MainForm As WikiFunctions.Plugin.IAutoWikiBrowser) _
    Implements WikiFunctions.Plugin.IAWBPlugin.Initialise
        ' Add our menu item:
        With OurMenuItem
            .CheckOnClick = True
            .ToolTipText = "Enable the " & conOurWikiName
        End With

        MainForm.PluginsToolStripMenuItem.DropDownItems.Add(OurMenuItem)
        AWBForm = MainForm
        AWBList = AWBForm.ListMaker
        LastItem = 0
    End Sub

    Public Sub LoadSettings(ByVal Prefs() As Object) Implements WikiFunctions.Plugin.IAWBPlugin.LoadSettings
        Dim P As WikiFunctions.AWBSettings.PrefsKeyPair
        For Each O As Object In Prefs
            P = O
            Select Case P.Name.ToLower().Trim()
                Case "textmode"
                    Settings.TextMode = P.Setting.ToString()
                Case "inputtext"
                    Settings.InputText = P.Setting.ToString()
                Case "columnheaders"
                    Settings.ColumnHeaders = P.Setting.ToString()
                Case "skip"
                    Settings.Skip = P.Setting
                Case "separator"
                    Settings.Separator = P.Setting.ToString()
                Case "createlists"
                    Settings.CreateLists = P.Setting
                Case "listseparator"
                    Settings.ListSeparator = P.Setting.ToString()
                Case "findreplace"
                    Settings.FindReplace = P.Setting
                Case "editsummary"
                    Settings.EditSummary = P.Setting.ToString()
            End Select
        Next
    End Sub

    Public ReadOnly Property Name() As String Implements WikiFunctions.Plugin.IAWBPlugin.Name
        Get
            Return conOurName
        End Get
    End Property

    Public ReadOnly Property WikiName() As String Implements WikiFunctions.Plugin.IAWBPlugin.WikiName
        Get
            Return conOurWikiName
        End Get
    End Property

    Public Sub Nudge(ByRef Cancel As Boolean) Implements WikiFunctions.Plugin.IAWBPlugin.Nudge
        Cancel = False
    End Sub

    Public Sub Nudged(ByVal Nudges As Integer) Implements WikiFunctions.Plugin.IAWBPlugin.Nudged

    End Sub

    Public Function ProcessArticle(ByVal sender As WikiFunctions.Plugin.IAutoWikiBrowser, _
    ByVal eventargs As WikiFunctions.Plugin.IProcessArticleEventArgs) As String _
    Implements WikiFunctions.Plugin.IAWBPlugin.ProcessArticle
        Dim ArticleText As String = "", ArticleTitle As String = ""
        Dim ArticleIndex As Long = -1, nCtr As Long, mCtr As Long
        Dim ListText As String, Listing As String()
        Dim Rule As RuleSetting
        Dim EditSummary As String

        'If menu item is not checked, then return
        If (Not PluginEnabled) Then
            ProcessArticle = eventargs.ArticleText
            Exit Function
        End If

        ArticleTitle = eventargs.ArticleTitle
        EditSummary = Settings.EditSummary

        Select Case Settings.TextMode
            Case "Append"
                ArticleText = eventargs.ArticleText + Settings.InputText
            Case "Prepend"
                ArticleText = Settings.InputText + eventargs.ArticleText
            Case "Replace"
                ArticleText = Settings.InputText
        End Select

        For nCtr = LastItem To (ArticleList.Count - 1)
            If ArticleList(nCtr).Item(0) = ArticleTitle Then
                LastItem = nCtr
                ArticleIndex = nCtr
                Exit For
            End If
        Next

        If ArticleIndex >= 0 Then
            If Settings.FindReplace Then
                AWBReplace.Clear()
                For Each Rule In RuleList
                    Dim NewRule As New WikiFunctions.Parse.Replacement
                    NewRule.Comment = Rule.Comment
                    NewRule.Enabled = Rule.Enabled
                    NewRule.IsRegex = Rule.IsRegex
                    NewRule.RegularExpressionOptions = Rule.RegularExpressionOptions
                    NewRule.Find = Rule.Find
                    NewRule.Replace = Rule.Replace
                    For nCtr = 0 To HeaderArray.Length - 1
                        NewRule.Find = Replace(NewRule.Find, HeaderArray(nCtr), ArticleList.Item(ArticleIndex).Item(nCtr))
                        NewRule.Replace = Replace(NewRule.Replace, HeaderArray(nCtr), ArticleList.Item(ArticleIndex).Item(nCtr))
                    Next
                    AWBReplace.AddNew(NewRule)
                Next
            End If

            For nCtr = 0 To HeaderArray.Length - 1
                If (InStr(ArticleList.Item(ArticleIndex).Item(nCtr), Settings.ListSeparator) > 0) And _
                        CSVLoader.Settings.CreateLists Then
                    Listing = Split(ArticleList.Item(ArticleIndex).Item(nCtr), Settings.ListSeparator)
                    ListText = ""
                    For mCtr = 0 To UBound(Listing)
                        ListText = ListText & Listing(mCtr) & vbCrLf
                    Next
                    ArticleText = Replace(ArticleText, HeaderArray(nCtr), ListText)
                Else
                    ArticleText = Replace(ArticleText, HeaderArray(nCtr), ArticleList.Item(ArticleIndex).Item(nCtr))
                    If EditSummary.Trim().Length > 0 Then EditSummary = Replace(EditSummary, HeaderArray(nCtr), ArticleList.Item(ArticleIndex).Item(nCtr))
                End If
            Next

            'Special words
            ArticleText = Replace(ArticleText, "##BR##", "" & vbCrLf)

            If ArticleText <> "" Then
                ProcessArticle = ArticleText
                eventargs.Skip = (eventargs.ArticleText = ArticleText) And Settings.Skip
            Else
                ProcessArticle = eventargs.ArticleText
            End If
        Else
            ProcessArticle = eventargs.ArticleText
        End If

        If EditSummary.Trim().Length > 0 Then AWBForm.EditSummaryComboBox.Text = EditSummary
        If AWBList.Count = 1 Then PluginEnabled = False
    End Function

    Public Sub Reset() Implements WikiFunctions.Plugin.IAWBPlugin.Reset
        SettingsForm = New SettingsForm()
        Settings = New CSVSettings()
    End Sub

    Public Function SaveSettings() As Object() Implements WikiFunctions.Plugin.IAWBPlugin.SaveSettings
        Dim Prefs(8) As Object
        Prefs(0) = New WikiFunctions.AWBSettings.PrefsKeyPair("TextMode", Settings.TextMode)
        Prefs(1) = New WikiFunctions.AWBSettings.PrefsKeyPair("InputText", Settings.InputText)
        Prefs(2) = New WikiFunctions.AWBSettings.PrefsKeyPair("ColumnHeaders", Settings.ColumnHeaders)
        Prefs(3) = New WikiFunctions.AWBSettings.PrefsKeyPair("Skip", Settings.Skip)
        Prefs(4) = New WikiFunctions.AWBSettings.PrefsKeyPair("Separator", Settings.Separator)
        Prefs(5) = New WikiFunctions.AWBSettings.PrefsKeyPair("CreateLists", Settings.CreateLists)
        Prefs(6) = New WikiFunctions.AWBSettings.PrefsKeyPair("ListSeparator", Settings.ListSeparator)
        Prefs(7) = New WikiFunctions.AWBSettings.PrefsKeyPair("FindReplace", Settings.FindReplace)
        Prefs(8) = New WikiFunctions.AWBSettings.PrefsKeyPair("EditSummary", Settings.EditSummary)
        Return Prefs
    End Function

    ' Event handlers:
    Private Sub OurMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles OurMenuItem.Click
        Dim nRet As Long
        Dim currentRow As String()
        Dim ArticleCols As List(Of String)
        Dim Rule As New WikiFunctions.Parse.Replacement
        Dim TempRuleList As New List(Of WikiFunctions.Parse.Replacement)
        Dim FirstField As Boolean
        Dim FirstCol As String

        If PluginEnabled Then
            LastItem = 0
            Settings.FileName = ""
            Using ofd As New OpenFileDialog
                ofd.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv"
                ofd.Title = "Select File"

                If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then Settings.FileName = ofd.FileName
            End Using

            SettingsForm = New SettingsForm()
            nRet = SettingsForm.ShowDialog()

            If Settings.FileName.Length = 0 Then PluginEnabled = False
            If Settings.Separator.Length = 0 Then PluginEnabled = False
            If Settings.ColumnHeaders.Length = 0 Then PluginEnabled = False

            If PluginEnabled Then
                AWBList.Clear()
                ArticleList.Clear()
                RuleList.Clear()

                AWBReplace = AWBForm.FindandReplace
                TempRuleList = AWBReplace.GetList()
                For Each Rule In TempRuleList
                    Dim TempRule As New RuleSetting
                    TempRule.Comment = Rule.Comment
                    TempRule.Enabled = Rule.Enabled
                    TempRule.Find = Rule.Find
                    TempRule.Replace = Rule.Replace
                    TempRule.IsRegex = Rule.IsRegex
                    TempRule.RegularExpressionOptions = Rule.RegularExpressionOptions
                    RuleList.Add(TempRule)
                Next

                HeaderArray = Split(Settings.ColumnHeaders, Settings.Separator)
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Settings.FileName, Encoding.UTF8)
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(Settings.Separator)
                    While Not MyReader.EndOfData
                        Try
                            ArticleCols = New List(Of String)
                            currentRow = MyReader.ReadFields()
                            Dim currentField As String
                            FirstField = True
                            FirstCol = ""
                            For Each currentField In currentRow
                                If FirstField Then
                                    If AWBForm.LangCode = "en" And AWBForm.Project = 0 Then '(0=wikipedia)
                                        'Remove underscores on the article name and
                                        'convert the first character to upper case
                                        currentField = ToUpperFirstLetter(Replace(currentField, "_", " "))
                                    End If
                                    FirstCol = currentField
                                    FirstField = False
                                End If
                                ArticleCols.Add(currentField)
                            Next

                            If UBound(HeaderArray) <> ArticleCols.Count - 1 Then
                                PluginEnabled = False
                                MsgBox("Error on " & FirstCol & ". Please make sure the column header matches the number of columns on the file.")
                                Exit Sub
                            End If
                            ArticleList.Add(ArticleCols)
                            AWBList.Add(ArticleList(ArticleList.Count - 1).Item(0))
                        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                            MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                        End Try
                    End While
                End Using
            End If
        End If
    End Sub

    Property PluginEnabled() As Boolean
        Get
            Return OurMenuItem.Checked
        End Get
        Set(ByVal Value As Boolean)
            OurMenuItem.Checked = Value
        End Set
    End Property

    <Serializable()> Friend Class CSVSettings
        Public TextMode As String = "Append"
        Public InputText As String = ""
        Public ColumnHeaders As String = ""
        Public Skip As Boolean = True
        Public Separator As String = ","
        Public FileName As String = ""
        Public CreateLists As Boolean = False
        Public ListSeparator As String = "^"
        Public FindReplace As Boolean = False
        Public EditSummary As String = ""
    End Class

    Friend Class RuleSetting
        Public Comment As String
        Public Enabled As Boolean
        Public Find As String
        Public Replace As String
        Public IsRegex As Boolean
        Public RegularExpressionOptions As RegularExpressions.RegexOptions
    End Class

    Private Function ToUpperFirstLetter(ByVal source As String) As String
        If String.IsNullOrEmpty(source) Then
            Return String.Empty
        End If

        Dim letters As Char() = source.ToCharArray()
        letters(0) = Char.ToUpper(letters(0))
        Return New String(letters)
    End Function
End Class
