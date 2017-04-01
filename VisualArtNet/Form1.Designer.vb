<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.WebBrowserD = New System.Windows.Forms.WebBrowser()
        Me.WebBrowserF = New System.Windows.Forms.WebBrowser()
        Me.WebBrowserW = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowserD
        '
        Me.WebBrowserD.Dock = System.Windows.Forms.DockStyle.Top
        Me.WebBrowserD.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserD.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserD.Name = "WebBrowserD"
        Me.WebBrowserD.Size = New System.Drawing.Size(657, 250)
        Me.WebBrowserD.TabIndex = 0
        '
        'WebBrowserF
        '
        Me.WebBrowserF.Dock = System.Windows.Forms.DockStyle.Left
        Me.WebBrowserF.Location = New System.Drawing.Point(0, 250)
        Me.WebBrowserF.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserF.Name = "WebBrowserF"
        Me.WebBrowserF.Size = New System.Drawing.Size(300, 338)
        Me.WebBrowserF.TabIndex = 1
        '
        'WebBrowserW
        '
        Me.WebBrowserW.Dock = System.Windows.Forms.DockStyle.Left
        Me.WebBrowserW.Location = New System.Drawing.Point(300, 250)
        Me.WebBrowserW.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserW.Name = "WebBrowserW"
        Me.WebBrowserW.Size = New System.Drawing.Size(300, 338)
        Me.WebBrowserW.TabIndex = 2
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(600, 250)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(57, 338)
        Me.WebBrowser1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 588)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.WebBrowserW)
        Me.Controls.Add(Me.WebBrowserF)
        Me.Controls.Add(Me.WebBrowserD)
        Me.Name = "Form1"
        Me.Text = "Visual Art.NET"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserD As WebBrowser
    Friend WithEvents WebBrowserF As WebBrowser
    Friend WithEvents WebBrowserW As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
