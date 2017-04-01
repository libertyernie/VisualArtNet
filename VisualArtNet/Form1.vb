Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WebBrowserD.Url = New Uri("https://www.deviantart.com/notifications/")
        WebBrowserF.Url = New Uri("https://sfw.furaffinity.net/msg/submissions/")
        WebBrowserW.Url = New Uri("https://www.weasyl.com/messages/submissions")
    End Sub

    Private Sub WebBrowserD_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowserD.Navigating
        If Not e.Url.AbsolutePath = "/notifications/" Then
            e.Cancel = True
            WebBrowser1.Url = e.Url
        End If
    End Sub

    Private Sub WebBrowserF_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowserF.Navigating
        If Not e.Url.AbsolutePath.StartsWith("/msg") Then
            e.Cancel = True
            WebBrowser1.Url = e.Url
        End If
    End Sub

    Private Sub WebBrowserW_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowserW.Navigating
        If e.Url.AbsolutePath.StartsWith("/~") Then
            e.Cancel = True
            WebBrowser1.Url = e.Url
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowserHelper.FixBrowserVersion()
    End Sub
End Class
