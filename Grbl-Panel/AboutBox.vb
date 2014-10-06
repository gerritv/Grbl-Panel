Imports System.Reflection
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

''' <summary>
''' generic, self-contained About Box dialog
''' </summary>
''' <remarks>
''' Jeff Atwood
''' http://www.codinghorror.com
''' 
''' With modifications and enhancements by Gerrit Visser for use with GrblPanel
''' </remarks>
Public Class AboutBox
    Inherits System.Windows.Forms.Form

    Private _IsPainted As Boolean = False
    Private _EntryAssemblyName As String
    Private _CallingAssemblyName As String
    Private _ExecutingAssemblyName As String
    Private _EntryAssembly As System.Reflection.Assembly
    Private _EntryAssemblyAttribCollection As Specialized.NameValueCollection
    Private _MinWindowHeight As Integer
    Private githubLink As String = "http://github.com/Gerritv/Grbl-Panel/wiki"

#Region "Properties"

    ''' <summary>
    ''' Returns the entry assembly for the current application domain
    ''' </summary>
    ''' <remarks>
    ''' This is usually read-only, but in some weird cases (Smart Client apps) 
    ''' you won't have an entry assembly, so you may want to set this manually.
    ''' </remarks>
    Public Property AppEntryAssembly() As System.Reflection.Assembly
        Get
            Return _EntryAssembly
        End Get
        Set(ByVal Value As System.Reflection.Assembly)
            _EntryAssembly = Value
        End Set
    End Property

    ''' <summary>
    ''' single line of text to show in the application title section of the about box dialog
    ''' </summary>
    ''' <remarks>
    ''' defaults to "%title%" 
    ''' %title% = Assembly: AssemblyTitle
    ''' </remarks>
    Public Property AppTitle() As String
        Get
            Return AppTitleLabel.Text
        End Get
        Set(ByVal Value As String)
            AppTitleLabel.Text = Value
        End Set
    End Property

    ''' <summary>
    ''' single line of text to show in the description section of the about box dialog
    ''' </summary>
    ''' <remarks>
    ''' defaults to "%description%"
    ''' %description% = Assembly: AssemblyDescription
    ''' </remarks>
    Public Property AppDescription() As String
        Get
            Return AppDescriptionLabel.Text
        End Get
        Set(ByVal Value As String)
            If Value = "" Then
                AppDescriptionLabel.Visible = False
            Else
                AppDescriptionLabel.Visible = True
                AppDescriptionLabel.Text = Value
            End If
        End Set
    End Property

    ''' <summary>
    ''' single line of text to show in the version section of the about dialog
    ''' </summary>
    ''' <remarks>
    ''' defaults to "Version %version%"
    ''' %version% = Assembly: AssemblyVersion
    ''' </remarks>
    Public Property AppVersion() As String
        Get
            Return AppVersionLabel.Text
        End Get
        Set(ByVal Value As String)
            If Value = "" Then
                AppVersionLabel.Visible = False
            Else
                AppVersionLabel.Visible = True
                AppVersionLabel.Text = Value
            End If
        End Set
    End Property

    ''' <summary>
    ''' single line of text to show in the copyright section of the about dialog
    ''' </summary>
    ''' <remarks>
    ''' defaults to "Copyright © %year%, %company%"
    ''' %company% = Assembly: AssemblyCompany
    ''' %year% = current 4-digit year
    ''' </remarks>
    Public Property AppCopyright() As String
        Get
            Return AppCopyrightLabel.Text
        End Get
        Set(ByVal Value As String)
            If Value = "" Then
                AppCopyrightLabel.Visible = False
            Else
                AppCopyrightLabel.Visible = True
                AppCopyrightLabel.Text = Value
            End If
        End Set
    End Property

    ''' <summary>
    ''' intended for the default 32x32 application icon to appear in the upper left of the about dialog
    ''' </summary>
    ''' <remarks>
    ''' if you open this form using .ShowDialog(Owner), the icon can be derived from the owning form
    ''' </remarks>
    Public Property AppImage() As Image
        Get
            Return ImagePictureBox.Image
        End Get
        Set(ByVal Value As Image)
            ImagePictureBox.Image = Value
        End Set
    End Property

    ''' <summary>
    ''' multiple lines of miscellaneous text to show in rich text box
    ''' </summary>
    ''' <remarks>
    ''' defaults to "%product% is %copyright%, %trademark%"
    ''' %product% = Assembly: AssemblyProduct
    ''' %copyright% = Assembly: AssemblyCopyright
    ''' %trademark% = Assembly: AssemblyTrademark
    ''' </remarks>
    Public Property AppMoreInfo() As String
        Get
            Return MoreRichTextBox.Text
        End Get
        Set(ByVal Value As String)
            If Value = "" Then
                MoreRichTextBox.Visible = False
            Else
                MoreRichTextBox.Visible = True
                MoreRichTextBox.Text = Value
            End If
        End Set
    End Property

    ''' <summary>
    ''' determines if the "Details" (advanced assembly details) button is shown
    ''' </summary>
    Public Property AppDetailsButton() As Boolean
        Get
            Return DetailsButton.Visible
        End Get
        Set(ByVal Value As Boolean)
            DetailsButton.Visible = Value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' things to do when form is loaded
    ''' </summary>
    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '-- if the user didn't provide an assembly, try to guess which one is the entry assembly
        If _EntryAssembly Is Nothing Then
            _EntryAssembly = [Assembly].GetEntryAssembly
        End If
        If _EntryAssembly Is Nothing Then
            _EntryAssembly = [Assembly].GetExecutingAssembly
        End If

        _ExecutingAssemblyName = [Assembly].GetExecutingAssembly.GetName.Name
        _CallingAssemblyName = [Assembly].GetCallingAssembly.GetName.Name
        Try
            '-- for web hosted apps, GetEntryAssembly = nothing
            _EntryAssemblyName = [Assembly].GetEntryAssembly.GetName.Name
        Catch ex As Exception
        End Try

        '  _MinWindowHeight = AppCopyrightLabel.Top + AppCopyrightLabel.Height + OKButton.Height + 30
        ' Always add a ref to Github repository
        AppMoreInfo = "GrblPanel is designed for use with Grbl 0.9G or later." + vbLf + vbLf + "For more details on this app, please visit: "
        AppMoreInfo = MoreRichTextBox.Text + githubLink

        Me.TabPanelDetails.Visible = False
        Me.MoreRichTextBox.Visible = True
        btnAboutChanges.Visible = True
        btnAboutCredits.Visible = True
        btnAboutLicense.Visible = True
        DetailsButton.Visible = True
        Me.SysInfoButton.Visible = False
    End Sub

    ''' <summary>
    ''' things to do when form is FIRST painted
    ''' </summary>
    Private Sub AboutBox_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        If Not _IsPainted Then
            _IsPainted = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            PopulateLabels()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    ''' <summary>
    ''' exception-safe retrieval of LastWriteTime for this assembly.
    ''' </summary>
    ''' <returns>File.GetLastWriteTime, or DateTime.MaxValue if exception was encountered.</returns>
    Private Shared Function AssemblyLastWriteTime(ByVal a As System.Reflection.Assembly) As DateTime
        Try
            Return File.GetLastWriteTime(a.Location)
        Catch ex As Exception
            Return DateTime.MaxValue
        End Try
    End Function

    ''' <summary>
    ''' Returns DateTime this Assembly was last built. Will attempt to calculate from build number, if possible. 
    ''' If not, the actual LastWriteTime on the assembly file will be returned.
    ''' </summary>
    ''' <param name="a">Assembly to get build date for</param>
    ''' <param name="ForceFileDate">Don't attempt to use the build number to calculate the date</param>
    ''' <returns>DateTime this assembly was last built</returns>
    Private Shared Function AssemblyBuildDate(ByVal a As System.Reflection.Assembly, _
        Optional ByVal ForceFileDate As Boolean = False) As DateTime

        Dim AssemblyVersion As System.Version = a.GetName.Version
        Dim dt As DateTime

        If ForceFileDate Then
            dt = AssemblyLastWriteTime(a)
        Else
            dt = CType("01/01/2000", DateTime). _
                AddDays(AssemblyVersion.Build). _
                AddSeconds(AssemblyVersion.Revision * 2)
            If TimeZone.IsDaylightSavingTime(dt, TimeZone.CurrentTimeZone.GetDaylightChanges(dt.Year)) Then
                dt = dt.AddHours(1)
            End If
            If dt > DateTime.Now Or AssemblyVersion.Build < 730 Or AssemblyVersion.Revision = 0 Then
                dt = AssemblyLastWriteTime(a)
            End If
        End If

        Return dt
    End Function

    ''' <summary>
    ''' returns string name / string value pair of all attribs
    ''' for specified assembly
    ''' </summary>
    ''' <remarks>
    ''' note that Assembly* values are pulled from AssemblyInfo file in project folder
    '''
    ''' Trademark       = AssemblyTrademark string
    ''' Debuggable      = True
    ''' GUID            = 7FDF68D5-8C6F-44C9-B391-117B5AFB5467
    ''' CLSCompliant    = True
    ''' Product         = AssemblyProduct string
    ''' Copyright       = AssemblyCopyright string
    ''' Company         = AssemblyCompany string
    ''' Description     = AssemblyDescription string
    ''' Title           = AssemblyTitle string
    ''' </remarks>
    Private Function AssemblyAttribs(ByVal a As System.Reflection.Assembly) As Specialized.NameValueCollection
        Dim TypeName As String
        Dim Name As String
        Dim Value As String
        Dim nvc As New Specialized.NameValueCollection
        Dim r As New Regex("(\.Assembly|\.)(?<Name>[^.]*)Attribute$", RegexOptions.IgnoreCase)

        For Each attrib As Object In a.GetCustomAttributes(False)
            TypeName = attrib.GetType().ToString
            Name = r.Match(TypeName).Groups("Name").ToString
            Value = ""
            Select Case TypeName
                Case "System.CLSCompliantAttribute"
                    Value = CType(attrib, CLSCompliantAttribute).IsCompliant.ToString
                Case "System.Diagnostics.DebuggableAttribute"
                    Value = CType(attrib, Diagnostics.DebuggableAttribute).IsJITTrackingEnabled.ToString
                Case "System.Reflection.AssemblyCompanyAttribute"
                    Value = CType(attrib, AssemblyCompanyAttribute).Company.ToString
                Case "System.Reflection.AssemblyConfigurationAttribute"
                    Value = CType(attrib, AssemblyConfigurationAttribute).Configuration.ToString
                Case "System.Reflection.AssemblyCopyrightAttribute"
                    Value = CType(attrib, AssemblyCopyrightAttribute).Copyright.ToString
                Case "System.Reflection.AssemblyDefaultAliasAttribute"
                    Value = CType(attrib, AssemblyDefaultAliasAttribute).DefaultAlias.ToString
                Case "System.Reflection.AssemblyDelaySignAttribute"
                    Value = CType(attrib, AssemblyDelaySignAttribute).DelaySign.ToString
                Case "System.Reflection.AssemblyDescriptionAttribute"
                    Value = CType(attrib, AssemblyDescriptionAttribute).Description.ToString
                Case "System.Reflection.AssemblyInformationalVersionAttribute"
                    Value = CType(attrib, AssemblyInformationalVersionAttribute).InformationalVersion.ToString
                Case "System.Reflection.AssemblyKeyFileAttribute"
                    Value = CType(attrib, AssemblyKeyFileAttribute).KeyFile.ToString
                Case "System.Reflection.AssemblyProductAttribute"
                    Value = CType(attrib, AssemblyProductAttribute).Product.ToString
                Case "System.Reflection.AssemblyTrademarkAttribute"
                    Value = CType(attrib, AssemblyTrademarkAttribute).Trademark.ToString
                Case "System.Reflection.AssemblyTitleAttribute"
                    Value = CType(attrib, AssemblyTitleAttribute).Title.ToString
                Case "System.Resources.NeutralResourcesLanguageAttribute"
                    Value = CType(attrib, Resources.NeutralResourcesLanguageAttribute).CultureName.ToString
                Case "System.Resources.SatelliteContractVersionAttribute"
                    Value = CType(attrib, Resources.SatelliteContractVersionAttribute).Version.ToString
                Case "System.Runtime.InteropServices.ComCompatibleVersionAttribute"
                    Dim x As Runtime.InteropServices.ComCompatibleVersionAttribute
                    x = CType(attrib, Runtime.InteropServices.ComCompatibleVersionAttribute)
                    Value = x.MajorVersion & "." & x.MinorVersion & "." & x.RevisionNumber & "." & x.BuildNumber
                Case "System.Runtime.InteropServices.ComVisibleAttribute"
                    Value = CType(attrib, Runtime.InteropServices.ComVisibleAttribute).Value.ToString
                Case "System.Runtime.InteropServices.GuidAttribute"
                    Value = CType(attrib, Runtime.InteropServices.GuidAttribute).Value.ToString
                Case "System.Runtime.InteropServices.TypeLibVersionAttribute"
                    Dim x As Runtime.InteropServices.TypeLibVersionAttribute
                    x = CType(attrib, Runtime.InteropServices.TypeLibVersionAttribute)
                    Value = x.MajorVersion & "." & x.MinorVersion
                Case "System.Security.AllowPartiallyTrustedCallersAttribute"
                    Value = "(Present)"
                Case Else
                    '-- debug.writeline("** unknown assembly attribute '" & TypeName & "'")
                    Value = TypeName
            End Select

            If nvc.Item(Name) = "" Then
                nvc.Add(Name, Value)
            End If
        Next

        '-- add some extra values that are not in the AssemblyInfo, but nice to have
        With nvc
            '-- codebase
            Try
                .Add("CodeBase", a.CodeBase.Replace("file:///", ""))
            Catch ex As System.NotSupportedException
                .Add("CodeBase", "(not supported)")
            End Try
            '-- build date
            Dim dt As DateTime = AssemblyBuildDate(a)
            If dt = DateTime.MaxValue Then
                .Add("BuildDate", "(unknown)")
            Else
                .Add("BuildDate", dt.ToString("yyyy-MM-dd hh:mm tt"))
            End If
            '-- location
            Try
                .Add("Location", a.Location)
            Catch ex As System.NotSupportedException
                .Add("Location", "(not supported)")
            End Try
            '-- version
            Try
                If a.GetName.Version.Major = 0 And a.GetName.Version.Minor = 0 Then
                    .Add("Version", "(unknown)")
                Else
                    .Add("Version", a.GetName.Version.ToString)
                End If
            Catch ex As Exception
                .Add("Version", "(unknown)")
            End Try

            .Add("FullName", a.FullName)
        End With

        Return nvc
    End Function

    ''' <summary>
    ''' reads an HKLM Windows Registry key value
    ''' </summary>
    Private Function RegistryHklmValue(ByVal KeyName As String, ByVal SubKeyRef As String) As String
        Dim rk As RegistryKey
        Try
            rk = Registry.LocalMachine.OpenSubKey(KeyName)
            Return CType(rk.GetValue(SubKeyRef, ""), String)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' launch the MSInfo "system information" application (works on XP, 2003, and Vista)
    ''' </summary>
    Private Sub ShowSysInfo()
        Dim strSysInfoPath As String = ""

        strSysInfoPath = RegistryHklmValue("SOFTWARE\Microsoft\Shared Tools Location", "MSINFO")
        If strSysInfoPath = "" Then
            strSysInfoPath = RegistryHklmValue("SOFTWARE\Microsoft\Shared Tools\MSINFO", "PATH")
        End If

        If strSysInfoPath = "" Then
            MessageBox.Show("System Information is unavailable at this time." & _
                Environment.NewLine & _
                Environment.NewLine & _
                "(couldn't find path for Microsoft System Information Tool in the registry.)", _
                Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Process.Start(strSysInfoPath)
        Catch ex As Exception
            MessageBox.Show("System Information is unavailable at this time." & _
                Environment.NewLine & _
                Environment.NewLine & _
                "(couldn't launch '" & strSysInfoPath & "')", _
                Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    ''' <summary>
    ''' populate a listview with the specified key and value strings
    ''' </summary>
    Private Sub Populate(ByVal lvw As ListView, ByVal Key As String, ByVal Value As String)
        If Value = "" Then Return
        Dim lvi As New ListViewItem
        lvi.Text = Key
        lvi.SubItems.Add(Value)
        lvw.Items.Add(lvi)
    End Sub

    ''' <summary>
    ''' populates the Application Information listview
    ''' </summary>
    Private Sub PopulateAppInfo()
        Dim d As System.AppDomain = System.AppDomain.CurrentDomain
        Populate(AppInfoListView, "Application Name", d.SetupInformation.ApplicationName)
        Populate(AppInfoListView, "Application Base", d.SetupInformation.ApplicationBase)
        Populate(AppInfoListView, "Cache Path", d.SetupInformation.CachePath)
        Populate(AppInfoListView, "Configuration File", d.SetupInformation.ConfigurationFile)
        Populate(AppInfoListView, "Dynamic Base", d.SetupInformation.DynamicBase)
        Populate(AppInfoListView, "Friendly Name", d.FriendlyName)
        Populate(AppInfoListView, "License File", d.SetupInformation.LicenseFile)
        Populate(AppInfoListView, "Private Bin Path", d.SetupInformation.PrivateBinPath)
        Populate(AppInfoListView, "Shadow Copy Directories", d.SetupInformation.ShadowCopyDirectories)
        Populate(AppInfoListView, " ", " ")
        Populate(AppInfoListView, "Entry Assembly", _EntryAssemblyName)
        Populate(AppInfoListView, "Executing Assembly", _ExecutingAssemblyName)
        Populate(AppInfoListView, "Calling Assembly", _CallingAssemblyName)
    End Sub

    ''' <summary>
    ''' populate Assembly Information listview with ALL assemblies
    ''' </summary>
    Private Sub PopulateAssemblies()
        For Each a As [Assembly] In AppDomain.CurrentDomain.GetAssemblies
            PopulateAssemblySummary(a)
        Next
        AssemblyNamesComboBox.SelectedIndex = AssemblyNamesComboBox.FindStringExact(_EntryAssemblyName)
    End Sub

    ''' <summary>
    ''' populate Assembly Information listview with summary view for a specific assembly
    ''' </summary>
    Private Sub PopulateAssemblySummary(ByVal a As [Assembly])
        Dim nvc As Specialized.NameValueCollection = AssemblyAttribs(a)

        Dim strAssemblyName As String = a.GetName.Name

        Dim lvi As New ListViewItem
        With lvi
            .Text = strAssemblyName
            .Tag = strAssemblyName
            If strAssemblyName = _CallingAssemblyName Then
                .Text &= " (calling)"
            End If
            If strAssemblyName = _ExecutingAssemblyName Then
                .Text &= " (executing)"
            End If
            If strAssemblyName = _EntryAssemblyName Then
                .Text &= " (entry)"
            End If
            .SubItems.Add(nvc.Item("version"))
            .SubItems.Add(nvc.Item("builddate"))
            .SubItems.Add(nvc.Item("codebase"))
            '.SubItems.Add(AssemblyVersion(a))
            '.SubItems.Add(AssemblyBuildDateString(a, True))
            '.SubItems.Add(AssemblyCodeBase(a))
        End With
        AssemblyInfoListView.Items.Add(lvi)
        AssemblyNamesComboBox.Items.Add(strAssemblyName)
    End Sub

    ''' <summary>
    ''' retrieves a cached value from the entry assembly attribute lookup collection
    ''' </summary>
    Private Function EntryAssemblyAttrib(ByVal strName As String) As String
        If _EntryAssemblyAttribCollection(strName) = "" Then
            Return "<Assembly: Assembly" & strName & "("""")>"
        Else
            Return _EntryAssemblyAttribCollection(strName).ToString
        End If
    End Function

    ''' <summary>
    ''' Populate all the form labels with tokenized text
    ''' </summary>
    Private Sub PopulateLabels()
        '-- get entry assembly attribs
        _EntryAssemblyAttribCollection = AssemblyAttribs(_EntryAssembly)

        '-- set icon from parent, if present
        If Me.Owner Is Nothing Then
            ImagePictureBox.Visible = False
            AppTitleLabel.Left = AppCopyrightLabel.Left
            AppDescriptionLabel.Left = AppCopyrightLabel.Left
        Else
            Me.Icon = Me.Owner.Icon
            ImagePictureBox.Image = Me.Icon.ToBitmap
        End If

        '-- replace all labels and window title
        Me.Text = ReplaceTokens(Me.Text)
        AppTitleLabel.Text = ReplaceTokens(AppTitleLabel.Text)
        If AppDescriptionLabel.Visible Then
            AppDescriptionLabel.Text = ReplaceTokens(AppDescriptionLabel.Text)
        End If
        If AppCopyrightLabel.Visible Then
            AppCopyrightLabel.Text = ReplaceTokens(AppCopyrightLabel.Text)
        End If
        If AppVersionLabel.Visible Then
            AppVersionLabel.Text = ReplaceTokens(AppVersionLabel.Text)
        End If
        If AppDateLabel.Visible Then
            AppDateLabel.Text = ReplaceTokens(AppDateLabel.Text)
        End If
        If MoreRichTextBox.Visible Then
            MoreRichTextBox.Text = ReplaceTokens(MoreRichTextBox.Text)
        End If
    End Sub

    ''' <summary>
    ''' perform assemblyinfo to string replacements on labels
    ''' </summary>
    Private Function ReplaceTokens(ByVal s As String) As String
        s = s.Replace("%title%", EntryAssemblyAttrib("title"))
        s = s.Replace("%copyright%", EntryAssemblyAttrib("copyright"))
        s = s.Replace("%description%", EntryAssemblyAttrib("description"))
        s = s.Replace("%company%", EntryAssemblyAttrib("company"))
        s = s.Replace("%product%", EntryAssemblyAttrib("product"))
        s = s.Replace("%trademark%", EntryAssemblyAttrib("trademark"))
        s = s.Replace("%year%", DateTime.Now.Year.ToString)
        s = s.Replace("%version%", EntryAssemblyAttrib("version"))
        s = s.Replace("%builddate%", EntryAssemblyAttrib("builddate"))
        Return s
    End Function

    ''' <summary>
    ''' populate details for a single assembly
    ''' </summary>
    Private Sub PopulateAssemblyDetails(ByVal a As System.Reflection.Assembly, ByVal lvw As ListView)
        lvw.Items.Clear()

        '-- this assembly property is only available in framework versions 1.1+
        Populate(lvw, "Image Runtime Version", a.ImageRuntimeVersion)
        Populate(lvw, "Loaded from GAC", a.GlobalAssemblyCache.ToString)

        Dim nvc As Specialized.NameValueCollection = AssemblyAttribs(a)
        For Each strKey As String In nvc
            Populate(lvw, strKey, nvc.Item(strKey))
        Next
    End Sub

    ''' <summary>
    ''' matches assembly by Assembly.GetName.Name; returns nothing if no match
    ''' </summary>
    Private Function MatchAssemblyByName(ByVal AssemblyName As String) As [Assembly]
        For Each a As [Assembly] In AppDomain.CurrentDomain.GetAssemblies
            If a.GetName.Name = AssemblyName Then
                Return a
            End If
        Next
        Return Nothing
    End Function

 
    ''' <summary>
    ''' expand about dialog to show additional advanced details
    ''' </summary>
    Private Sub DetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsButton.Click
        Cursor.Current = Cursors.WaitCursor
        DetailsButton.Visible = False
        btnAboutChanges.Visible = False
        btnAboutCredits.Visible = False
        btnAboutLicense.Visible = False
        Me.SuspendLayout()
        Me.MaximizeBox = True
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.SizeGripStyle = SizeGripStyle.Show
        ' Me.Size = New Size(580, Me.Size.Height + 200)
        MoreRichTextBox.Visible = False
        TabPanelDetails.Visible = True
        SysInfoButton.Visible = True
        PopulateAssemblies()
        PopulateAppInfo()
        Me.CenterToParent()
        Me.ResumeLayout()
        Cursor.Current = Cursors.Default
    End Sub

    ''' <summary>
    ''' for detailed system info, launch the external Microsoft system info app
    ''' </summary>
    Private Sub SysInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SysInfoButton.Click
        ShowSysInfo()
    End Sub

    ''' <summary>
    ''' if an assembly is double-clicked, go to the detail page for that assembly
    ''' </summary>
    Private Sub AssemblyInfoListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AssemblyInfoListView.DoubleClick
        Dim strAssemblyName As String
        If AssemblyInfoListView.SelectedItems.Count > 0 Then
            strAssemblyName = Convert.ToString(AssemblyInfoListView.SelectedItems(0).Tag)
            AssemblyNamesComboBox.SelectedIndex = AssemblyNamesComboBox.FindStringExact(strAssemblyName)
            Me.TabPanelDetails.SelectedTab = Me.TabPageAssemblyDetails
        End If
    End Sub

    ''' <summary>
    ''' if a new assembly is selected from the combo box, show details for that assembly
    ''' </summary>
    Private Sub AssemblyNamesComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssemblyNamesComboBox.SelectedIndexChanged
        Dim strAssemblyName As String = Convert.ToString(AssemblyNamesComboBox.SelectedItem)
        PopulateAssemblyDetails(MatchAssemblyByName(strAssemblyName), AssemblyDetailsListView)
    End Sub

    ''' <summary>
    ''' sort the assembly list by column
    ''' </summary>
    Private Sub AssemblyInfoListView_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles AssemblyInfoListView.ColumnClick
        Dim intTargetCol As Integer = e.Column + 1

        If Not AssemblyInfoListView.Tag Is Nothing Then
            If Math.Abs(Convert.ToInt32(AssemblyInfoListView.Tag)) = intTargetCol Then
                intTargetCol = -Convert.ToInt32(AssemblyInfoListView.Tag)
            End If
        End If

        AssemblyInfoListView.Tag = intTargetCol
        AssemblyInfoListView.ListViewItemSorter = New ListViewItemComparer(intTargetCol)
    End Sub

    ''' <summary>
    ''' launch any http:// or mailto: links clicked in the body of the rich text box
    ''' </summary>
    Private Sub MoreRichTextBox_LinkClicked(ByVal sender As Object, ByVal e As LinkClickedEventArgs) Handles MoreRichTextBox.LinkClicked
        Try
            Process.Start(e.LinkText)
        Catch ex As Exception
        End Try
    End Sub

#Region "  ListViewItemComparer Class"

    Class ListViewItemComparer
        Implements IComparer

        Private _intCol As Integer
        Private _IsAscending As Boolean = True

        Public Sub New()
            _intCol = 0
            _IsAscending = True
        End Sub

        Public Sub New(ByVal column As Integer, Optional ByVal ascending As Boolean = True)
            If column < 0 Then
                _IsAscending = False
            Else
                _IsAscending = ascending
            End If
            _intCol = Math.Abs(column) - 1
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Dim intResult As Integer = _
                [String].Compare(CType(x, ListViewItem).SubItems(_intCol).Text, _
                CType(y, ListViewItem).SubItems(_intCol).Text)

            If _IsAscending Then
                Return intResult
            Else
                Return -intResult
            End If
        End Function
    End Class
#End Region

    ''' <summary>
    ''' things to do when the selected tab is changed
    ''' </summary>
    Private Sub TabPanelDetails_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPanelDetails.SelectedIndexChanged
        If TabPanelDetails.SelectedTab Is Me.TabPageAssemblyDetails Then
            AssemblyNamesComboBox.Focus()
        End If
    End Sub

    Private Sub btnAboutCredits_Click(sender As Object, e As EventArgs) Handles btnAboutCredits.Click
        ' Show the content of Credits file
        showFileContents("CREDITS")
    End Sub

    Private Sub btnAboutLicense_Click(sender As Object, e As EventArgs) Handles btnAboutLicense.Click
        showFileContents("LICENSE")
    End Sub

    Private Sub btnAboutChanges_Click(sender As Object, e As EventArgs) Handles btnAboutChanges.Click
        showFileContents("CHANGES")
    End Sub

    Private Sub showFileContents(ByVal fileName As String)
        ' helper for the 3  show buttons
        Dim fh As FileStream
        Dim data(4098) As Byte
        Dim d As System.AppDomain = System.AppDomain.CurrentDomain
        Try
            fh = New FileStream(d.BaseDirectory + "\" + fileName + ".txt", FileMode.Open)
        Catch ex As Exception
            MessageBox.Show("Can't find Credits file, did you copy all the files?")
            Return
        End Try
        fh.Read(data, 0, 4096)
        fh.Close()
        MoreRichTextBox.Text = System.Text.Encoding.ASCII.GetString(data)
    End Sub

End Class