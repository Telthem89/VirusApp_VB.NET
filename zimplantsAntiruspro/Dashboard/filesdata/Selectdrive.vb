Imports System.IO
Public Class Selectdrive
    Private Sub Selectdrive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each drive In Environment.GetLogicalDrives
                Dim InfoDrive As DriveInfo = New DriveInfo(drive)
                If InfoDrive.DriveType = DriveType.Removable Or InfoDrive.DriveType = DriveType.Fixed Then
                    ComboBox1.Items.Add(drive)
                End If
            Next
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("What the hell with your computer", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QuickScan.ListBox2.Items.Clear()
        QuickScan.ListBox1.Items.Clear()
        QuickScan.FolderBrowserDialog1.SelectedPath = ComboBox1.Text
        QuickScan.ProgressBar1.Value = 0
        QuickScan.lblVirus.Text = "0"

        On Error Resume Next
        For Each strDir As String In System.IO.Directory.GetDirectories(QuickScan.FolderBrowserDialog1.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
            For Each strFile As String In System.IO.Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                QuickScan.ListBox1.Items.Add(strFile)
            Next

        Next

        QuickScan.Button4.Visible = True
        QuickScan.Button2.Visible = False
        QuickScan.Button3.Visible = False
        QuickScan.Show()
        QuickScan.ListBox1.Enabled = False
        QuickScan.Timer1.Start()
        Me.Hide()
    End Sub
End Class