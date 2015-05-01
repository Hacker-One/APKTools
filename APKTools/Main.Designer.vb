<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits MetroFramework.Forms.MetroForm

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
        Me.B_OpenFwRES = New MetroFramework.Controls.MetroButton()
        Me.B_SaveOutputAPK = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.B_OpenTwFwRES = New MetroFramework.Controls.MetroButton()
        Me.B_SaveDecompiled = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TB_SaveDecompiled = New MetroFramework.Controls.MetroTextBox()
        Me.TB_TwFwRES = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.TB_FwRES = New MetroFramework.Controls.MetroTextBox()
        Me.B_Recompile = New MetroFramework.Controls.MetroButton()
        Me.B_OpenAPK = New MetroFramework.Controls.MetroButton()
        Me.CB_IsTouchWizAPK = New MetroFramework.Controls.MetroCheckBox()
        Me.TB_OutputAPK = New MetroFramework.Controls.MetroTextBox()
        Me.B_Decompile = New MetroFramework.Controls.MetroButton()
        Me.CB_IsSysAPK = New MetroFramework.Controls.MetroCheckBox()
        Me.TB_APK = New MetroFramework.Controls.MetroTextBox()
        Me.B_OpenDFolder = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TB_DFolder = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.B_ZIPAlign = New MetroFramework.Controls.MetroButton()
        Me.RTConsole = New System.Windows.Forms.RichTextBox()
        Me.B_SignAPKs = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.B_RemoveFW = New MetroFramework.Controls.MetroButton()
        Me.B_InstallFW = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage6 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.LAbout = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        Me.MetroTabPage5.SuspendLayout()
        Me.MetroTabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_OpenFwRES
        '
        Me.B_OpenFwRES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_OpenFwRES.Enabled = False
        Me.B_OpenFwRES.Highlight = False
        Me.B_OpenFwRES.Location = New System.Drawing.Point(513, 10)
        Me.B_OpenFwRES.Name = "B_OpenFwRES"
        Me.B_OpenFwRES.Size = New System.Drawing.Size(29, 23)
        Me.B_OpenFwRES.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_OpenFwRES.StyleManager = Nothing
        Me.B_OpenFwRES.TabIndex = 22
        Me.B_OpenFwRES.Text = "..."
        Me.B_OpenFwRES.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'B_SaveOutputAPK
        '
        Me.B_SaveOutputAPK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_SaveOutputAPK.Highlight = False
        Me.B_SaveOutputAPK.Location = New System.Drawing.Point(513, 39)
        Me.B_SaveOutputAPK.Name = "B_SaveOutputAPK"
        Me.B_SaveOutputAPK.Size = New System.Drawing.Size(29, 23)
        Me.B_SaveOutputAPK.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_SaveOutputAPK.StyleManager = Nothing
        Me.B_SaveOutputAPK.TabIndex = 16
        Me.B_SaveOutputAPK.Text = "..."
        Me.B_SaveOutputAPK.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.CustomBackground = False
        Me.MetroLabel2.CustomForeColor = False
        Me.MetroLabel2.Enabled = False
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 10)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel2.StyleManager = Nothing
        Me.MetroLabel2.TabIndex = 17
        Me.MetroLabel2.Text = "framework-res.apk:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel2.UseStyleColors = False
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.CustomBackground = False
        Me.MetroLabel6.CustomForeColor = False
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 39)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel6.StyleManager = Nothing
        Me.MetroLabel6.TabIndex = 15
        Me.MetroLabel6.Text = "Output Source:"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel6.UseStyleColors = False
        '
        'B_OpenTwFwRES
        '
        Me.B_OpenTwFwRES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_OpenTwFwRES.Enabled = False
        Me.B_OpenTwFwRES.Highlight = False
        Me.B_OpenTwFwRES.Location = New System.Drawing.Point(513, 39)
        Me.B_OpenTwFwRES.Name = "B_OpenTwFwRES"
        Me.B_OpenTwFwRES.Size = New System.Drawing.Size(29, 23)
        Me.B_OpenTwFwRES.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_OpenTwFwRES.StyleManager = Nothing
        Me.B_OpenTwFwRES.TabIndex = 21
        Me.B_OpenTwFwRES.Text = "..."
        Me.B_OpenTwFwRES.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'B_SaveDecompiled
        '
        Me.B_SaveDecompiled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_SaveDecompiled.Highlight = False
        Me.B_SaveDecompiled.Location = New System.Drawing.Point(513, 39)
        Me.B_SaveDecompiled.Name = "B_SaveDecompiled"
        Me.B_SaveDecompiled.Size = New System.Drawing.Size(29, 23)
        Me.B_SaveDecompiled.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_SaveDecompiled.StyleManager = Nothing
        Me.B_SaveDecompiled.TabIndex = 14
        Me.B_SaveDecompiled.Text = "..."
        Me.B_SaveDecompiled.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.CustomBackground = False
        Me.MetroLabel3.CustomForeColor = False
        Me.MetroLabel3.Enabled = False
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 39)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(135, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel3.StyleManager = Nothing
        Me.MetroLabel3.TabIndex = 18
        Me.MetroLabel3.Text = "twframework-res.apk:"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel3.UseStyleColors = False
        '
        'TB_SaveDecompiled
        '
        Me.TB_SaveDecompiled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_SaveDecompiled.CustomBackground = False
        Me.TB_SaveDecompiled.CustomForeColor = False
        Me.TB_SaveDecompiled.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TB_SaveDecompiled.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TB_SaveDecompiled.Location = New System.Drawing.Point(146, 39)
        Me.TB_SaveDecompiled.Multiline = False
        Me.TB_SaveDecompiled.Name = "TB_SaveDecompiled"
        Me.TB_SaveDecompiled.SelectedText = ""
        Me.TB_SaveDecompiled.Size = New System.Drawing.Size(361, 23)
        Me.TB_SaveDecompiled.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_SaveDecompiled.StyleManager = Nothing
        Me.TB_SaveDecompiled.TabIndex = 13
        Me.TB_SaveDecompiled.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_SaveDecompiled.UseStyleColors = False
        '
        'TB_TwFwRES
        '
        Me.TB_TwFwRES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_TwFwRES.CustomBackground = False
        Me.TB_TwFwRES.CustomForeColor = False
        Me.TB_TwFwRES.Enabled = False
        Me.TB_TwFwRES.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TB_TwFwRES.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TB_TwFwRES.Location = New System.Drawing.Point(146, 39)
        Me.TB_TwFwRES.Multiline = False
        Me.TB_TwFwRES.Name = "TB_TwFwRES"
        Me.TB_TwFwRES.SelectedText = ""
        Me.TB_TwFwRES.Size = New System.Drawing.Size(361, 23)
        Me.TB_TwFwRES.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_TwFwRES.StyleManager = Nothing
        Me.TB_TwFwRES.TabIndex = 20
        Me.TB_TwFwRES.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_TwFwRES.UseStyleColors = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.CustomBackground = False
        Me.MetroLabel5.CustomForeColor = False
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 39)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel5.StyleManager = Nothing
        Me.MetroLabel5.TabIndex = 15
        Me.MetroLabel5.Text = "Output APK:"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel5.UseStyleColors = False
        '
        'TB_FwRES
        '
        Me.TB_FwRES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_FwRES.CustomBackground = False
        Me.TB_FwRES.CustomForeColor = False
        Me.TB_FwRES.Enabled = False
        Me.TB_FwRES.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TB_FwRES.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TB_FwRES.Location = New System.Drawing.Point(146, 10)
        Me.TB_FwRES.Multiline = False
        Me.TB_FwRES.Name = "TB_FwRES"
        Me.TB_FwRES.SelectedText = ""
        Me.TB_FwRES.Size = New System.Drawing.Size(361, 23)
        Me.TB_FwRES.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_FwRES.StyleManager = Nothing
        Me.TB_FwRES.TabIndex = 19
        Me.TB_FwRES.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_FwRES.UseStyleColors = False
        '
        'B_Recompile
        '
        Me.B_Recompile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Recompile.Highlight = False
        Me.B_Recompile.Location = New System.Drawing.Point(3, 68)
        Me.B_Recompile.Name = "B_Recompile"
        Me.B_Recompile.Size = New System.Drawing.Size(539, 43)
        Me.B_Recompile.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_Recompile.StyleManager = Nothing
        Me.B_Recompile.TabIndex = 10
        Me.B_Recompile.Text = "Recompile APK"
        Me.B_Recompile.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'B_OpenAPK
        '
        Me.B_OpenAPK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_OpenAPK.Highlight = False
        Me.B_OpenAPK.Location = New System.Drawing.Point(513, 10)
        Me.B_OpenAPK.Name = "B_OpenAPK"
        Me.B_OpenAPK.Size = New System.Drawing.Size(29, 23)
        Me.B_OpenAPK.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_OpenAPK.StyleManager = Nothing
        Me.B_OpenAPK.TabIndex = 10
        Me.B_OpenAPK.Text = "..."
        Me.B_OpenAPK.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'CB_IsTouchWizAPK
        '
        Me.CB_IsTouchWizAPK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_IsTouchWizAPK.AutoSize = True
        Me.CB_IsTouchWizAPK.CustomBackground = False
        Me.CB_IsTouchWizAPK.CustomForeColor = False
        Me.CB_IsTouchWizAPK.Enabled = False
        Me.CB_IsTouchWizAPK.FontSize = MetroFramework.MetroLinkSize.Small
        Me.CB_IsTouchWizAPK.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.CB_IsTouchWizAPK.Location = New System.Drawing.Point(403, 73)
        Me.CB_IsTouchWizAPK.Name = "CB_IsTouchWizAPK"
        Me.CB_IsTouchWizAPK.Size = New System.Drawing.Size(141, 15)
        Me.CB_IsTouchWizAPK.Style = MetroFramework.MetroColorStyle.Blue
        Me.CB_IsTouchWizAPK.StyleManager = Nothing
        Me.CB_IsTouchWizAPK.TabIndex = 8
        Me.CB_IsTouchWizAPK.Text = "TouchWiz system APK"
        Me.CB_IsTouchWizAPK.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CB_IsTouchWizAPK.UseStyleColors = False
        Me.CB_IsTouchWizAPK.UseVisualStyleBackColor = True
        '
        'TB_OutputAPK
        '
        Me.TB_OutputAPK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_OutputAPK.CustomBackground = False
        Me.TB_OutputAPK.CustomForeColor = False
        Me.TB_OutputAPK.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TB_OutputAPK.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TB_OutputAPK.Location = New System.Drawing.Point(146, 39)
        Me.TB_OutputAPK.Multiline = False
        Me.TB_OutputAPK.Name = "TB_OutputAPK"
        Me.TB_OutputAPK.SelectedText = ""
        Me.TB_OutputAPK.Size = New System.Drawing.Size(361, 23)
        Me.TB_OutputAPK.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_OutputAPK.StyleManager = Nothing
        Me.TB_OutputAPK.TabIndex = 14
        Me.TB_OutputAPK.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_OutputAPK.UseStyleColors = False
        '
        'B_Decompile
        '
        Me.B_Decompile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Decompile.Highlight = False
        Me.B_Decompile.Location = New System.Drawing.Point(3, 68)
        Me.B_Decompile.Name = "B_Decompile"
        Me.B_Decompile.Size = New System.Drawing.Size(539, 43)
        Me.B_Decompile.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_Decompile.StyleManager = Nothing
        Me.B_Decompile.TabIndex = 6
        Me.B_Decompile.Text = "Decompile APK"
        Me.B_Decompile.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'CB_IsSysAPK
        '
        Me.CB_IsSysAPK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CB_IsSysAPK.AutoSize = True
        Me.CB_IsSysAPK.CustomBackground = False
        Me.CB_IsSysAPK.CustomForeColor = False
        Me.CB_IsSysAPK.FontSize = MetroFramework.MetroLinkSize.Small
        Me.CB_IsSysAPK.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.CB_IsSysAPK.Location = New System.Drawing.Point(3, 73)
        Me.CB_IsSysAPK.Name = "CB_IsSysAPK"
        Me.CB_IsSysAPK.Size = New System.Drawing.Size(206, 15)
        Me.CB_IsSysAPK.Style = MetroFramework.MetroColorStyle.Blue
        Me.CB_IsSysAPK.StyleManager = Nothing
        Me.CB_IsSysAPK.TabIndex = 7
        Me.CB_IsSysAPK.Text = "Decompile/Recompile system APK"
        Me.CB_IsSysAPK.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CB_IsSysAPK.UseStyleColors = False
        Me.CB_IsSysAPK.UseVisualStyleBackColor = True
        '
        'TB_APK
        '
        Me.TB_APK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_APK.CustomBackground = False
        Me.TB_APK.CustomForeColor = False
        Me.TB_APK.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TB_APK.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TB_APK.Location = New System.Drawing.Point(146, 10)
        Me.TB_APK.Multiline = False
        Me.TB_APK.Name = "TB_APK"
        Me.TB_APK.SelectedText = ""
        Me.TB_APK.Size = New System.Drawing.Size(361, 23)
        Me.TB_APK.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_APK.StyleManager = Nothing
        Me.TB_APK.TabIndex = 3
        Me.TB_APK.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_APK.UseStyleColors = False
        '
        'B_OpenDFolder
        '
        Me.B_OpenDFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_OpenDFolder.Highlight = False
        Me.B_OpenDFolder.Location = New System.Drawing.Point(513, 10)
        Me.B_OpenDFolder.Name = "B_OpenDFolder"
        Me.B_OpenDFolder.Size = New System.Drawing.Size(29, 23)
        Me.B_OpenDFolder.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_OpenDFolder.StyleManager = Nothing
        Me.B_OpenDFolder.TabIndex = 13
        Me.B_OpenDFolder.Text = "..."
        Me.B_OpenDFolder.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.CustomBackground = False
        Me.MetroLabel1.CustomForeColor = False
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel1.StyleManager = Nothing
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "APK for Decompile:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel1.UseStyleColors = False
        '
        'TB_DFolder
        '
        Me.TB_DFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_DFolder.CustomBackground = False
        Me.TB_DFolder.CustomForeColor = False
        Me.TB_DFolder.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.TB_DFolder.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TB_DFolder.Location = New System.Drawing.Point(146, 10)
        Me.TB_DFolder.Multiline = False
        Me.TB_DFolder.Name = "TB_DFolder"
        Me.TB_DFolder.SelectedText = ""
        Me.TB_DFolder.Size = New System.Drawing.Size(361, 23)
        Me.TB_DFolder.Style = MetroFramework.MetroColorStyle.Blue
        Me.TB_DFolder.StyleManager = Nothing
        Me.TB_DFolder.TabIndex = 12
        Me.TB_DFolder.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TB_DFolder.UseStyleColors = False
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.CustomBackground = False
        Me.MetroLabel4.CustomForeColor = False
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 10)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel4.StyleManager = Nothing
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Source Folder:"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel4.UseStyleColors = False
        '
        'B_ZIPAlign
        '
        Me.B_ZIPAlign.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_ZIPAlign.Highlight = False
        Me.B_ZIPAlign.Location = New System.Drawing.Point(3, 3)
        Me.B_ZIPAlign.Name = "B_ZIPAlign"
        Me.B_ZIPAlign.Size = New System.Drawing.Size(541, 114)
        Me.B_ZIPAlign.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_ZIPAlign.StyleManager = Nothing
        Me.B_ZIPAlign.TabIndex = 1
        Me.B_ZIPAlign.Text = "Drag APKs here"
        Me.B_ZIPAlign.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'RTConsole
        '
        Me.RTConsole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTConsole.Cursor = System.Windows.Forms.Cursors.No
        Me.RTConsole.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTConsole.ForeColor = System.Drawing.Color.Black
        Me.RTConsole.Location = New System.Drawing.Point(27, 228)
        Me.RTConsole.Name = "RTConsole"
        Me.RTConsole.ReadOnly = True
        Me.RTConsole.Size = New System.Drawing.Size(551, 104)
        Me.RTConsole.TabIndex = 3
        Me.RTConsole.Text = ""
        '
        'B_SignAPKs
        '
        Me.B_SignAPKs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_SignAPKs.Highlight = False
        Me.B_SignAPKs.Location = New System.Drawing.Point(3, 3)
        Me.B_SignAPKs.Name = "B_SignAPKs"
        Me.B_SignAPKs.Size = New System.Drawing.Size(541, 114)
        Me.B_SignAPKs.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_SignAPKs.StyleManager = Nothing
        Me.B_SignAPKs.TabIndex = 1
        Me.B_SignAPKs.Text = "Drag APKs here"
        Me.B_SignAPKs.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage5)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage6)
        Me.MetroTabControl1.CustomBackground = False
        Me.MetroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(555, 159)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabControl1.StyleManager = Nothing
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseStyleColors = False
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.TB_APK)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.B_Decompile)
        Me.MetroTabPage1.Controls.Add(Me.B_SaveDecompiled)
        Me.MetroTabPage1.Controls.Add(Me.B_OpenAPK)
        Me.MetroTabPage1.Controls.Add(Me.TB_SaveDecompiled)
        Me.MetroTabPage1.CustomBackground = False
        Me.MetroTabPage1.HorizontalScrollbar = False
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(547, 120)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage1.StyleManager = Nothing
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Decompile APK"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage1.VerticalScrollbar = False
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.B_SaveOutputAPK)
        Me.MetroTabPage2.Controls.Add(Me.B_Recompile)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage2.Controls.Add(Me.TB_DFolder)
        Me.MetroTabPage2.Controls.Add(Me.B_OpenDFolder)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.Controls.Add(Me.TB_OutputAPK)
        Me.MetroTabPage2.CustomBackground = False
        Me.MetroTabPage2.HorizontalScrollbar = False
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(547, 120)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage2.StyleManager = Nothing
        Me.MetroTabPage2.TabIndex = 3
        Me.MetroTabPage2.Text = "Recompile APK"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage2.VerticalScrollbar = False
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.B_RemoveFW)
        Me.MetroTabPage3.Controls.Add(Me.B_InstallFW)
        Me.MetroTabPage3.Controls.Add(Me.CB_IsTouchWizAPK)
        Me.MetroTabPage3.Controls.Add(Me.CB_IsSysAPK)
        Me.MetroTabPage3.Controls.Add(Me.B_OpenFwRES)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage3.Controls.Add(Me.B_OpenTwFwRES)
        Me.MetroTabPage3.Controls.Add(Me.TB_TwFwRES)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage3.Controls.Add(Me.TB_FwRES)
        Me.MetroTabPage3.CustomBackground = False
        Me.MetroTabPage3.HorizontalScrollbar = False
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(547, 120)
        Me.MetroTabPage3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage3.StyleManager = Nothing
        Me.MetroTabPage3.TabIndex = 4
        Me.MetroTabPage3.Text = "Frameworks"
        Me.MetroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage3.VerticalScrollbar = False
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'B_RemoveFW
        '
        Me.B_RemoveFW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_RemoveFW.Highlight = False
        Me.B_RemoveFW.Location = New System.Drawing.Point(276, 94)
        Me.B_RemoveFW.Name = "B_RemoveFW"
        Me.B_RemoveFW.Size = New System.Drawing.Size(266, 23)
        Me.B_RemoveFW.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_RemoveFW.StyleManager = Nothing
        Me.B_RemoveFW.TabIndex = 24
        Me.B_RemoveFW.Text = "Remove Framework"
        Me.B_RemoveFW.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'B_InstallFW
        '
        Me.B_InstallFW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_InstallFW.Highlight = False
        Me.B_InstallFW.Location = New System.Drawing.Point(3, 94)
        Me.B_InstallFW.Name = "B_InstallFW"
        Me.B_InstallFW.Size = New System.Drawing.Size(267, 23)
        Me.B_InstallFW.Style = MetroFramework.MetroColorStyle.Blue
        Me.B_InstallFW.StyleManager = Nothing
        Me.B_InstallFW.TabIndex = 23
        Me.B_InstallFW.Text = "Install Framework"
        Me.B_InstallFW.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.B_ZIPAlign)
        Me.MetroTabPage4.CustomBackground = False
        Me.MetroTabPage4.HorizontalScrollbar = False
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(547, 120)
        Me.MetroTabPage4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage4.StyleManager = Nothing
        Me.MetroTabPage4.TabIndex = 1
        Me.MetroTabPage4.Text = "ZIPAlign"
        Me.MetroTabPage4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage4.VerticalScrollbar = False
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'MetroTabPage5
        '
        Me.MetroTabPage5.Controls.Add(Me.B_SignAPKs)
        Me.MetroTabPage5.CustomBackground = False
        Me.MetroTabPage5.HorizontalScrollbar = False
        Me.MetroTabPage5.HorizontalScrollbarBarColor = True
        Me.MetroTabPage5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.HorizontalScrollbarSize = 10
        Me.MetroTabPage5.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage5.Name = "MetroTabPage5"
        Me.MetroTabPage5.Size = New System.Drawing.Size(547, 120)
        Me.MetroTabPage5.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage5.StyleManager = Nothing
        Me.MetroTabPage5.TabIndex = 2
        Me.MetroTabPage5.Text = "SignAPK"
        Me.MetroTabPage5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage5.VerticalScrollbar = False
        Me.MetroTabPage5.VerticalScrollbarBarColor = True
        Me.MetroTabPage5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.VerticalScrollbarSize = 10
        '
        'MetroTabPage6
        '
        Me.MetroTabPage6.Controls.Add(Me.MetroLink1)
        Me.MetroTabPage6.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage6.Controls.Add(Me.LAbout)
        Me.MetroTabPage6.CustomBackground = False
        Me.MetroTabPage6.HorizontalScrollbar = False
        Me.MetroTabPage6.HorizontalScrollbarBarColor = True
        Me.MetroTabPage6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.HorizontalScrollbarSize = 10
        Me.MetroTabPage6.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage6.Name = "MetroTabPage6"
        Me.MetroTabPage6.Size = New System.Drawing.Size(547, 120)
        Me.MetroTabPage6.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage6.StyleManager = Nothing
        Me.MetroTabPage6.TabIndex = 5
        Me.MetroTabPage6.Text = "About"
        Me.MetroTabPage6.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage6.VerticalScrollbar = False
        Me.MetroTabPage6.VerticalScrollbarBarColor = True
        Me.MetroTabPage6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.VerticalScrollbarSize = 10
        '
        'MetroLink1
        '
        Me.MetroLink1.CustomBackground = False
        Me.MetroLink1.CustomForeColor = False
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Small
        Me.MetroLink1.FontWeight = MetroFramework.MetroLinkWeight.Bold
        Me.MetroLink1.Location = New System.Drawing.Point(3, 51)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(280, 54)
        Me.MetroLink1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLink1.StyleManager = Nothing
        Me.MetroLink1.TabIndex = 4
        Me.MetroLink1.Text = "Official thread"
        Me.MetroLink1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLink1.UseStyleColors = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.CustomBackground = False
        Me.MetroLabel7.CustomForeColor = False
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel7.Location = New System.Drawing.Point(301, 10)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(243, 95)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel7.StyleManager = Nothing
        Me.MetroLabel7.TabIndex = 3
        Me.MetroLabel7.Text = "Credits:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MetroFrameworkUI v1.0.1.1 by viperneo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "apktool v2.0.0 by brutall" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s" & _
    "ignapk v? by ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zipalign v? by AOSP"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel7.UseStyleColors = False
        '
        'LAbout
        '
        Me.LAbout.AutoSize = True
        Me.LAbout.CustomBackground = False
        Me.LAbout.CustomForeColor = False
        Me.LAbout.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LAbout.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LAbout.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LAbout.Location = New System.Drawing.Point(3, 10)
        Me.LAbout.Name = "LAbout"
        Me.LAbout.Size = New System.Drawing.Size(280, 38)
        Me.LAbout.Style = MetroFramework.MetroColorStyle.Blue
        Me.LAbout.StyleManager = Nothing
        Me.LAbout.TabIndex = 2
        Me.LAbout.Text = "APKTools v0.1 Build date 1/1/1970 0:00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By SandPox"
        Me.LAbout.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LAbout.UseStyleColors = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 368)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.RTConsole)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MinimumSize = New System.Drawing.Size(601, 368)
        Me.Name = "Main"
        Me.ShadowType = MetroFramework.Forms.ShadowType.DropShadow
        Me.Text = "APKTools"
        Me.TextAlign = MetroFramework.Forms.TextAlign.Center
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.MetroTabPage4.ResumeLayout(False)
        Me.MetroTabPage5.ResumeLayout(False)
        Me.MetroTabPage6.ResumeLayout(False)
        Me.MetroTabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents B_ZIPAlign As MetroFramework.Controls.MetroButton
    Friend WithEvents RTConsole As System.Windows.Forms.RichTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TB_APK As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CB_IsTouchWizAPK As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CB_IsSysAPK As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents B_Decompile As MetroFramework.Controls.MetroButton
    Friend WithEvents B_SignAPKs As MetroFramework.Controls.MetroButton
    Friend WithEvents B_OpenAPK As MetroFramework.Controls.MetroButton
    Friend WithEvents B_OpenDFolder As MetroFramework.Controls.MetroButton
    Friend WithEvents TB_DFolder As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents B_Recompile As MetroFramework.Controls.MetroButton
    Friend WithEvents B_SaveOutputAPK As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TB_OutputAPK As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_SaveDecompiled As MetroFramework.Controls.MetroTextBox
    Friend WithEvents B_SaveDecompiled As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents B_OpenFwRES As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents B_OpenTwFwRES As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TB_TwFwRES As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TB_FwRES As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents B_InstallFW As MetroFramework.Controls.MetroButton
    Friend WithEvents B_RemoveFW As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage6 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents LAbout As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink

End Class
