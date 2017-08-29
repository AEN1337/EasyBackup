Public Class Form1

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backup.Click
        If String.IsNullOrEmpty(My.Settings.game_path) Or String.IsNullOrEmpty(My.Settings.backup_path) Then
            MsgBox("Please select a Path first!", MsgBoxStyle.Critical, Title:="Git Gud!")
        Else
            Timer1.Start()

            My.Computer.FileSystem.CopyDirectory(My.Settings.game_path, My.Settings.backup_path, True)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bckload.Click, bckload.Click
        If String.IsNullOrEmpty(My.Settings.game_path) Or String.IsNullOrEmpty(My.Settings.backup_path) Then
            MsgBox("Please select a Path first!", MsgBoxStyle.Critical, Title:="Error!")

        Else
            Timer1.Start()

            My.Computer.FileSystem.CopyDirectory(My.Settings.backup_path, My.Settings.game_path, True)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles folder.Click

        Process.Start("explorer.exe", My.Settings.backup_path)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Finished!", "EasyBackup", _
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            ProgressBar1.Value = 0
        End If
    End Sub
End Class
