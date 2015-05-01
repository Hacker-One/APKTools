Imports System.IO


Public Class Main
    Dim JavaPath As String
    Dim IsFrameworkInstalled As Boolean = False
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        B_ZIPAlign.AllowDrop = True
        B_SignAPKs.AllowDrop = True
        TB_APK.AllowDrop = True
        TB_SaveDecompiled.AllowDrop = True
        TB_DFolder.AllowDrop = True
        TB_OutputAPK.AllowDrop = True
        TB_FwRES.AllowDrop = True
        TB_TwFwRES.AllowDrop = True
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WriteConsole("APKTools v0.1 Build date " & RetrieveLinkerTimestamp(Windows.Forms.Application.ExecutablePath), Color.DarkGreen)
        Dim Principal As New Security.Principal.WindowsPrincipal(Security.Principal.WindowsIdentity.GetCurrent())
        If Principal.IsInRole(Security.Principal.WindowsBuiltInRole.Administrator) = True And Environment.OSVersion.Version.Major >= 6 Then WriteConsole("I'm running on Administrator privilege, the Drag & Drop may not work due to a security mechanism on Windows Vista and above.", Color.DarkOrange)
        If System.IO.File.Exists(GetJavaInstallationPath) Then
            JavaPath = GetJavaInstallationPath()
            If File.Exists(Path.Combine(System.Environment.GetEnvironmentVariable("UserProfile"), "apktool\framework\1.apk")) Then
                WriteConsole("Detected Framework installed on this computer, if you want to decompile APK from another ROM/Device then you'll need install new Framework in Framework tab!", Color.BlueViolet)
                IsFrameworkInstalled = True
            End If
        Else
            WriteConsole("I can't find java binary on your system so most function has been disabled!", Color.Red)
            JavaPath = ""
            MetroTabPage1.Enabled = False
            MetroTabPage2.Enabled = False
            MetroTabPage3.Enabled = False
            MetroTabPage5.Enabled = False

        End If
        LAbout.Text = "APKTools v0.1 Build date " & RetrieveLinkerTimestamp(Windows.Forms.Application.ExecutablePath) & vbCrLf & _
            "2015 By SandPox"
    End Sub
    Function RetrieveLinkerTimestamp(ByVal filePath As String) As DateTime
        Const PeHeaderOffset As Integer = 60
        Const LinkerTimestampOffset As Integer = 8

        Dim b(2047) As Byte
        Dim s As Stream
        Try
            s = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            s.Read(b, 0, 2048)
        Finally
            If Not s Is Nothing Then s.Close()
        End Try

        Dim i As Integer = BitConverter.ToInt32(b, PeHeaderOffset)

        Dim SecondsSince1970 As Integer = BitConverter.ToInt32(b, i + LinkerTimestampOffset)
        Dim dt As New DateTime(1970, 1, 1, 0, 0, 0)
        dt = dt.AddSeconds(SecondsSince1970)
        dt = dt.AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours)
        Return dt
    End Function

    Private Sub B_ZIPAlign_Click(sender As Object, e As EventArgs) Handles B_ZIPAlign.Click
        Dim ZIPAlign_OpenDialog As New OpenFileDialog()
        ZIPAlign_OpenDialog.Filter = "Android Package (*.apk)|*.apk"
        ZIPAlign_OpenDialog.FilterIndex = 2
        ZIPAlign_OpenDialog.Multiselect = True
        ZIPAlign_OpenDialog.RestoreDirectory = True
        If ZIPAlign_OpenDialog.ShowDialog() = DialogResult.OK Then
            If ZIPAlign_OpenDialog.FileNames.Length > 1 Then
                B_ZIPAlign.Text = "(" & ZIPAlign_OpenDialog.FileNames.Length & " Files)"
            Else
                B_ZIPAlign.Text = ZIPAlign_OpenDialog.FileName.ToString()
            End If
            For Each fName In ZIPAlign_OpenDialog.FileNames
                If File.Exists(fName.ToString) Then
                    ZIPAlign(fName.ToString)
                Else
                    WriteConsole("No such file", Color.Red)
                End If

            Next
        End If
    End Sub

    
    Private Sub WriteConsole(Text As String, Color As Color)
        RTConsole.SelectionStart = RTConsole.Text.Length
        Dim OldColor = RTConsole.SelectionColor
        RTConsole.SelectionColor = Color
        RTConsole.AppendText(Text & vbCrLf)
        RTConsole.SelectionColor = OldColor
        RTConsole.ScrollToCaret()
    End Sub

    Private Sub B_OpenAPK_Click(sender As Object, e As EventArgs) Handles B_OpenAPK.Click
        Dim APK_OpenDialog As New OpenFileDialog()
        APK_OpenDialog.Filter = "Android Package (*.apk)|*.apk"
        APK_OpenDialog.FilterIndex = 2
        APK_OpenDialog.RestoreDirectory = True
        If APK_OpenDialog.ShowDialog() = DialogResult.OK Then
            TB_APK.Text = APK_OpenDialog.FileName.ToString()
            TB_SaveDecompiled.Text = APK_OpenDialog.FileName.ToString.Substring(0, APK_OpenDialog.FileName.Length - 4)
        End If
    End Sub
    Private Sub B_OpenFwRES_Click(sender As Object, e As EventArgs) Handles B_OpenFwRES.Click
        Dim APK_OpenDialog As New OpenFileDialog()
        APK_OpenDialog.Filter = "Android Package (*.apk)|*.apk"
        APK_OpenDialog.FilterIndex = 2
        APK_OpenDialog.RestoreDirectory = True
        If APK_OpenDialog.ShowDialog() = DialogResult.OK Then
            TB_FwRES.Text = APK_OpenDialog.FileName.ToString()
        End If
    End Sub

    Private Sub B_OpenTwFwRES_Click(sender As Object, e As EventArgs) Handles B_OpenTwFwRES.Click
        Dim APK_OpenDialog As New OpenFileDialog()
        APK_OpenDialog.Filter = "Android Package (*.apk)|*.apk"
        APK_OpenDialog.FilterIndex = 2
        APK_OpenDialog.RestoreDirectory = True
        If APK_OpenDialog.ShowDialog() = DialogResult.OK Then
            TB_TwFwRES.Text = APK_OpenDialog.FileName.ToString()
        End If
    End Sub

    Private Sub CB_IsSysAPK_CheckedChanged(sender As Object, e As EventArgs) Handles CB_IsSysAPK.CheckedChanged
        If CB_IsSysAPK.CheckState = 1 Then
            TB_FwRES.Enabled = True
            B_OpenFwRES.Enabled = True
            CB_IsTouchWizAPK.Enabled = True
            MetroLabel2.Enabled = True
        Else
            TB_FwRES.Enabled = False
            B_OpenFwRES.Enabled = False
            CB_IsTouchWizAPK.Enabled = False
            MetroLabel2.Enabled = False
            CB_IsTouchWizAPK.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CB_IsTouchWizAPK_CheckedChanged(sender As Object, e As EventArgs) Handles CB_IsTouchWizAPK.CheckedChanged
        If CB_IsTouchWizAPK.CheckState = 1 Then
            MetroLabel3.Enabled = True
            TB_TwFwRES.Enabled = True
            B_OpenTwFwRES.Enabled = True
        Else
            MetroLabel3.Enabled = False
            TB_TwFwRES.Enabled = False
            B_OpenTwFwRES.Enabled = False
        End If
    End Sub

    Private Sub B_Decompile_Click(sender As Object, e As EventArgs) Handles B_Decompile.Click
        If TB_APK.Text = "" Then
            WriteConsole("Please give me something to do.", Color.DarkGoldenrod)
        Else
            If Not IsFrameworkInstalled Then WriteConsole("If you want to decompile system APK then you'll need to install Framework file first!", Color.CadetBlue)
            DecompileAPK(TB_APK.Text)
        End If
    End Sub
    Private Sub B_InstallFW_Click(sender As Object, e As EventArgs) Handles B_InstallFW.Click

        If CB_IsSysAPK.CheckState = CheckState.Checked Then
            If TB_FwRES.Text = "" Then
                WriteConsole("You must specified Framework to Decompile system apps!", Color.Red)
                Exit Sub
            Else
                If IsFrameworkInstalled = True Then
                    WriteConsole("You need to remove old Framework before install new Framework!", Color.Red)
                Else
                    WriteConsole("Installing framework...", Color.Black)
                    InstallFramework(TB_FwRES.Text)
                    If CB_IsTouchWizAPK.CheckState = CheckState.Checked Then
                        If TB_TwFwRES.Text = "" Then
                            WriteConsole("You must specified twframework to Decompile TouchWiz system apps!", Color.Red)
                            Exit Sub
                        Else
                            WriteConsole("Installing twframework...", Color.Black)
                            InstallFramework(TB_TwFwRES.Text)
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub InstallFramework(Path As String)
        Dim startInfo As New System.Diagnostics.ProcessStartInfo
        Dim MyProcess As Process
        startInfo.FileName = JavaPath
        startInfo.Arguments = "-jar " & Chr(34) & Environment.CurrentDirectory & "\apktool.jar" & Chr(34) & " if " & Chr(34) & Path & Chr(34)
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = True
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        MyProcess = Process.Start(startInfo)
        MyProcess.WaitForExit()
        If (MyProcess.ExitCode = 0) Then
            WriteConsole("APKTool Finished install Framework with no error.", Color.Green)
            IsFrameworkInstalled = True
        Else
            WriteConsole("APKTool Finished install Framework with ERROR code: " & MyProcess.ExitCode & ".", Color.Red)
            IsFrameworkInstalled = False
        End If
    End Sub

    Private Sub B_RemoveFW_Click(sender As Object, e As EventArgs) Handles B_RemoveFW.Click
        If Directory.Exists(Path.Combine(System.Environment.GetEnvironmentVariable("UserProfile"), "apktool\framework")) Then
            Try
                Directory.Delete(Path.Combine(System.Environment.GetEnvironmentVariable("UserProfile"), "apktool\framework"), True)
                WriteConsole("Framework folder deleted.", Color.Blue)
                IsFrameworkInstalled = False
            Catch ex As Exception
                WriteConsole("Can't delete Framework folder.", Color.Red)
            End Try
        Else
            WriteConsole("Framework folder not found.", Color.OrangeRed)
            IsFrameworkInstalled = False
        End If
    End Sub

    Private Function GetJavaInstallationPath() As String
        Try
            Using JavaRegKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\JavaSoft\Java Runtime Environment\")
                Dim JavaVersion As String = JavaRegKey.GetValue("CurrentVersion").ToString()
                Using RegJavaVersion As Microsoft.Win32.RegistryKey = JavaRegKey.OpenSubKey(JavaVersion)
                    Return System.IO.Path.Combine(RegJavaVersion.GetValue("JavaHome").ToString(), "bin\Java.exe")
                End Using
            End Using
        Catch ex As Exception
            Return vbNull
        End Try
    End Function

    Private Sub B_SignAPKs_Click(sender As Object, e As EventArgs) Handles B_SignAPKs.Click
        Dim SignAPK_OpenDialog As New OpenFileDialog()
        SignAPK_OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        SignAPK_OpenDialog.Filter = "Android Package (*.apk)|*.apk"
        SignAPK_OpenDialog.FilterIndex = 2
        SignAPK_OpenDialog.Multiselect = True
        SignAPK_OpenDialog.RestoreDirectory = True
        If SignAPK_OpenDialog.ShowDialog() = DialogResult.OK Then
            If SignAPK_OpenDialog.FileNames.Length > 1 Then
                B_SignAPKs.Text = "(" & SignAPK_OpenDialog.FileNames.Length & " Files)"
            Else
                B_SignAPKs.Text = SignAPK_OpenDialog.FileName.ToString()
            End If
            For Each fName In SignAPK_OpenDialog.FileNames
                If File.Exists(fName.ToString) Then
                    SignAPK(fName.ToString)
                Else
                    WriteConsole("No such file", Color.Red)
                End If
            Next
        End If
    End Sub
    Private Sub SignAPK(Path As String)
        WriteConsole("Signing file: " & Path, Color.Black)
        Dim startInfo As New System.Diagnostics.ProcessStartInfo
        Dim MyProcess As Process
        startInfo.FileName = JavaPath
        startInfo.Arguments = "-jar " & Chr(34) & Environment.CurrentDirectory & "\SignApk.jar" & Chr(34) & " " & Chr(34) & Environment.CurrentDirectory & "\testkey.x509.pem" & Chr(34) & " " & Chr(34) & Environment.CurrentDirectory & "\testkey.pk8" & Chr(34) & " " & Chr(34) & Path & Chr(34) & " " & Chr(34) & Path.Substring(0, Path.Length - 4) & " - Signed.apk" & Chr(34)
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = True
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        MyProcess = Process.Start(startInfo)
        MyProcess.WaitForExit()
        If (MyProcess.ExitCode = 0) Then
            WriteConsole("SignAPK Finished with no error.", Color.Green)
        Else
            WriteConsole("SignAPK Finished with ERROR code: " & MyProcess.ExitCode & ".", Color.Red)
        End If
    End Sub
    Private Sub ZIPAlign(Path As String)
        WriteConsole("If you Align APK file after Sign then the signature will be invalid.", Color.CadetBlue)
        WriteConsole("Aligning file: " & Path, Color.Black)
        Dim startInfo As New System.Diagnostics.ProcessStartInfo
        Dim MyProcess As Process
        startInfo.FileName = "zipalign.exe"
        startInfo.Arguments = "-fv 4 " & Chr(34) & Path & Chr(34) & " " & Chr(34) & Path.Substring(0, Path.Length - 4) & " - Aligned.apk" & Chr(34)
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = True
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        MyProcess = Process.Start(startInfo)
        MyProcess.WaitForExit()
        If (MyProcess.ExitCode = 0) Then
            WriteConsole("ZIPAlign Finished with no error.", Color.Green)
        Else
            WriteConsole("ZIPAlign Finished with ERROR code: " & MyProcess.ExitCode & ".", Color.Red)
        End If
    End Sub
    Private Sub DecompileAPK(Path As String)
        WriteConsole("Decompiling: " & Path, Color.Black)
        Dim startInfo As New System.Diagnostics.ProcessStartInfo
        Dim MyProcess As Process
        startInfo.FileName = JavaPath
        startInfo.Arguments = "-jar " & Chr(34) & Environment.CurrentDirectory & "\apktool.jar" & Chr(34) & " d " & Chr(34) & Path & Chr(34) & " -o " & Chr(34) & System.IO.Path.GetDirectoryName(Path) & "\" & System.IO.Path.GetFileName(Path).Substring(0, System.IO.Path.GetFileName(Path).Length - 4) & Chr(34)
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = True
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        MyProcess = Process.Start(startInfo)
        MyProcess.WaitForExit()
        If (MyProcess.ExitCode = 0) Then
            WriteConsole("APKTool Finished with no error.", Color.Green)
        Else
            WriteConsole("APKTool Finished with ERROR code: " & MyProcess.ExitCode & ".", Color.Red)
            If CB_IsSysAPK.CheckState = CheckState.Checked Then WriteConsole("Make sure you're using valid Framework and APK must be deodexed.", Color.Red)
        End If
    End Sub

    Private Sub B_OpenDFolder_Click(sender As Object, e As EventArgs) Handles B_OpenDFolder.Click
        Dim FolderBrowser = New FolderBrowserDialog()
        FolderBrowser.SelectedPath = Application.StartupPath
        If FolderBrowser.ShowDialog() = DialogResult.OK Then
            TB_DFolder.Text = FolderBrowser.SelectedPath
            TB_OutputAPK.Text = FolderBrowser.SelectedPath & ".apk"
        End If
    End Sub

    Private Sub B_Recompile_Click(sender As Object, e As EventArgs) Handles B_Recompile.Click
        If TB_DFolder.Text = "" Then
            WriteConsole("Please give me something to do.", Color.DarkGoldenrod)
        Else
            WriteConsole("Recompiling: " & TB_DFolder.Text, Color.Black)
            Dim startInfo As New System.Diagnostics.ProcessStartInfo
            Dim MyProcess As Process
            startInfo.FileName = JavaPath
            startInfo.Arguments = "-jar " & Chr(34) & Environment.CurrentDirectory & "\apktool.jar" & Chr(34) & " b -f -d " & Chr(34) & TB_DFolder.Text & Chr(34) & " -o " & Chr(34) & TB_OutputAPK.Text & Chr(34)
            startInfo.CreateNoWindow = True
            startInfo.UseShellExecute = True
            startInfo.WindowStyle = ProcessWindowStyle.Hidden
            MyProcess = Process.Start(startInfo)
            MyProcess.WaitForExit()
            If (MyProcess.ExitCode = 0) Then
                WriteConsole("APKTool Finished with no error.", Color.Green)
            Else
                WriteConsole("APKTool Finished with ERROR code: " & MyProcess.ExitCode & ".", Color.Red)
            End If
        End If
    End Sub

    Private Sub B_SaveDecompiled_Click(sender As Object, e As EventArgs) Handles B_SaveDecompiled.Click
        Dim FolderBrowser = New FolderBrowserDialog()
        FolderBrowser.SelectedPath = Application.StartupPath
        If DialogResult.OK = FolderBrowser.ShowDialog() Then
            TB_SaveDecompiled.Text = FolderBrowser.SelectedPath
        End If
    End Sub

    Private Sub B_SaveOutputAPK_Click(sender As Object, e As EventArgs) Handles B_SaveOutputAPK.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Android Package (*.apk)|*.apk"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            TB_OutputAPK.Text = saveFileDialog1.FileName
        End If

    End Sub

#Region "DragDrop"
    Private Sub TB_APK_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_APK.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If Not DragFile.Length > 1 Then
            TB_APK.Text = DragFile(0)
            TB_SaveDecompiled.Text = TB_APK.Text.Substring(0, TB_APK.Text.Length - 4)
        End If
    End Sub
    Private Sub TB_APK_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_APK.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub TB_SaveDecompiled_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_SaveDecompiled.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If Not DragFile.Length > 1 Then
            TB_SaveDecompiled.Text = DragFile(0)
        End If
    End Sub
    Private Sub TB_SaveDecompiled_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_SaveDecompiled.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub TB_DFolder_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_DFolder.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If Not DragFile.Length > 1 Then
            TB_DFolder.Text = DragFile(0)
            TB_OutputAPK.Text = TB_DFolder.Text & ".apk"
        End If
    End Sub
    Private Sub TB_DFolder_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_DFolder.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub TB_OutputAPK_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_OutputAPK.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If Not DragFile.Length > 1 Then
            TB_OutputAPK.Text = DragFile(0)
        End If
    End Sub
    Private Sub TB_OutputAPK_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_OutputAPK.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub TB_FwRES_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_FwRES.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If Not DragFile.Length > 1 Then
            TB_FwRES.Text = DragFile(0)
        End If
    End Sub
    Private Sub TB_FwRES_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_FwRES.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub TB_TwFwRES_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_TwFwRES.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If Not DragFile.Length > 1 Then
            TB_TwFwRES.Text = DragFile(0)
        End If
    End Sub
    Private Sub TB_TwFwRES_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TB_TwFwRES.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub B_ZIPAlign_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles B_ZIPAlign.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If DragFile.Length > 1 Then
            B_ZIPAlign.Text = "(" & DragFile.Length & " Files)"
        Else
            B_ZIPAlign.Text = DragFile(0)
        End If
        For Each Path In DragFile
            ZIPAlign(Path)
        Next
    End Sub
    Private Sub B_ZIPAlign_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles B_ZIPAlign.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub B_SignAPKs_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles B_SignAPKs.DragDrop
        Dim DragFile() As String = e.Data.GetData(DataFormats.FileDrop)
        If DragFile.Length > 1 Then
            B_SignAPKs.Text = "(" & DragFile.Length & " Files)"
        Else
            B_SignAPKs.Text = DragFile(0)
        End If
        For Each Path In DragFile
            SignAPK(Path)
        Next
    End Sub
    Private Sub B_SignAPKs_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles B_SignAPKs.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
#End Region

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        System.Diagnostics.Process.Start("http://forum.xda-developers.com/android/general/tool-apktools-windows-gui-decompile-t3097613")
    End Sub
End Class
