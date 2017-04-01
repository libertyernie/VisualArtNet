Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WebBrowserD.Url = New Uri("https://www.deviantart.com/notifications/")
        WebBrowserF.Url = New Uri("https://www.furaffinity.net/msg/submissions/")
        WebBrowserW.Url = New Uri("https://www.weasyl.com/messages/submissions")
    End Sub

    Private Sub WebBrowserD_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowserD.Navigating
        Console.WriteLine(e.Url)
        If e.Url.Scheme = "res" Then
            WebBrowserD.Visible = False
            Return
        End If
    End Sub

    Private Sub WebBrowserD_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowserD.Navigated
        If e.Url.Host.EndsWith("deviantart.com") And e.Url.AbsolutePath <> "/notifications/" Then
            WebBrowser1.Url = e.Url
            WebBrowserD.Url = New Uri("https://www.deviantart.com/notifications/")
        End If
    End Sub

    Private Sub WebBrowserF_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowserF.Navigating
        If e.Url.Scheme = "res" Then
            WebBrowserF.Visible = False
            Return
        End If
        If String.IsNullOrEmpty(e.TargetFrameName) Then
            If Not e.Url.AbsolutePath.StartsWith("/msg") Then
                e.Cancel = True
                WebBrowser1.Url = e.Url
            End If
        End If
    End Sub

    Private Sub WebBrowserW_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowserW.Navigating
        If e.Url.Scheme = "res" Then
            WebBrowserW.Visible = False
            Return
        End If
        If String.IsNullOrEmpty(e.TargetFrameName) Then
            If e.Url.AbsolutePath.StartsWith("/~") Then
                e.Cancel = True
                WebBrowser1.Url = e.Url
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowserHelper.FixBrowserVersion()
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If e.Url.Host.EndsWith("betrad.com") Or e.Url.Host.EndsWith("doubleclick.net") Or e.Url.Host.EndsWith("googlesyndication.com") Then
            e.Cancel = True
            Return
        End If
        If String.IsNullOrEmpty(e.TargetFrameName) And e.Url.Scheme <> "javascript" Then
            TextBox1.Text = e.Url.AbsoluteUri
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(WebBrowser1.Url.AbsoluteUri)
        WebBrowser1.Url = New Uri("about:blank")
    End Sub
End Class
