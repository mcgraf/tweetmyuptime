
Public Class Form1

    Dim uname As String
    Dim passwd As String
    Dim result As String

    Dim tweet As Twitterizer.Framework.Twitter

    Private Sub Form1_Load(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) _
            Handles MyBase.Load

        On Error Resume Next

        uname = My.Settings.uname
        passwd = My.Settings.passwd
        tweet = New Twitterizer.Framework.Twitter(uname, passwd)
        cmdCopyIP.Enabled = False
        txtTwitterName.Text = My.Settings.uname
        txtTwitterPassword.Text = My.Settings.passwd

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) _
            Handles cmdExit.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, _
                                       ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) _
            Handles LinkLabel1.LinkClicked

        On Error Resume Next

        Dim WC As New System.Net.WebClient
        LinkLabel1.Text = System.Text.Encoding.ASCII.GetString((WC.DownloadData("http://whatismyip.com/automation/n09230945.asp")))
        WC.Dispose()
        LinkLabel1.LinkVisited = True
        cmdCopyIP.Enabled = True

    End Sub

    Private Sub cmdCopyIP_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
            Handles cmdCopyIP.Click
        TextBox1.Text = LinkLabel1.Text

    End Sub

    Private Sub cmdTweet_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
            Handles cmdTweet.Click
        result = tweet.Status.Update(TextBox1.Text).TwitterUser.UserName

        MsgBox(result)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        On Error Resume Next

        My.Settings.uname = txtTwitterName.Text
        My.Settings.passwd = txtTwitterPassword.Text
        My.Settings.Save()
        MsgBox(tweet.Status.Show(uname))



    End Sub
End Class
