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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BrawlSplitter3 = New VisualArtNet.BrawlSplitter()
        Me.BrawlSplitter2 = New VisualArtNet.BrawlSplitter()
        Me.BrawlSplitter1 = New VisualArtNet.BrawlSplitter()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowserD
        '
        Me.WebBrowserD.Dock = System.Windows.Forms.DockStyle.Top
        Me.WebBrowserD.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserD.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserD.Name = "WebBrowserD"
        Me.WebBrowserD.ScriptErrorsSuppressed = True
        Me.WebBrowserD.Size = New System.Drawing.Size(784, 250)
        Me.WebBrowserD.TabIndex = 0
        '
        'WebBrowserF
        '
        Me.WebBrowserF.Dock = System.Windows.Forms.DockStyle.Left
        Me.WebBrowserF.Location = New System.Drawing.Point(0, 259)
        Me.WebBrowserF.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserF.Name = "WebBrowserF"
        Me.WebBrowserF.ScriptErrorsSuppressed = True
        Me.WebBrowserF.Size = New System.Drawing.Size(300, 302)
        Me.WebBrowserF.TabIndex = 1
        '
        'WebBrowserW
        '
        Me.WebBrowserW.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebBrowserW.Location = New System.Drawing.Point(484, 259)
        Me.WebBrowserW.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserW.Name = "WebBrowserW"
        Me.WebBrowserW.ScriptErrorsSuppressed = True
        Me.WebBrowserW.Size = New System.Drawing.Size(300, 302)
        Me.WebBrowserW.TabIndex = 2
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(309, 283)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(166, 278)
        Me.WebBrowser1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(309, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(166, 24)
        Me.Panel1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(91, 24)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(91, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Detach"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BrawlSplitter3
        '
        Me.BrawlSplitter3.ControlToHide = Me.WebBrowserW
        Me.BrawlSplitter3.Dock = System.Windows.Forms.DockStyle.Right
        Me.BrawlSplitter3.Location = New System.Drawing.Point(475, 259)
        Me.BrawlSplitter3.Name = "BrawlSplitter3"
        Me.BrawlSplitter3.Size = New System.Drawing.Size(9, 302)
        Me.BrawlSplitter3.TabIndex = 6
        Me.BrawlSplitter3.TabStop = False
        '
        'BrawlSplitter2
        '
        Me.BrawlSplitter2.ControlToHide = Me.WebBrowserF
        Me.BrawlSplitter2.Location = New System.Drawing.Point(300, 259)
        Me.BrawlSplitter2.Name = "BrawlSplitter2"
        Me.BrawlSplitter2.Size = New System.Drawing.Size(9, 302)
        Me.BrawlSplitter2.TabIndex = 5
        Me.BrawlSplitter2.TabStop = False
        '
        'BrawlSplitter1
        '
        Me.BrawlSplitter1.ControlToHide = Me.WebBrowserD
        Me.BrawlSplitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BrawlSplitter1.Location = New System.Drawing.Point(0, 250)
        Me.BrawlSplitter1.Name = "BrawlSplitter1"
        Me.BrawlSplitter1.Size = New System.Drawing.Size(784, 9)
        Me.BrawlSplitter1.TabIndex = 4
        Me.BrawlSplitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BrawlSplitter3)
        Me.Controls.Add(Me.WebBrowserW)
        Me.Controls.Add(Me.BrawlSplitter2)
        Me.Controls.Add(Me.WebBrowserF)
        Me.Controls.Add(Me.BrawlSplitter1)
        Me.Controls.Add(Me.WebBrowserD)
        Me.Name = "Form1"
        Me.Text = "Visual Art.NET 1.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserD As WebBrowser
    Friend WithEvents WebBrowserF As WebBrowser
    Friend WithEvents WebBrowserW As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BrawlSplitter1 As BrawlSplitter
    Friend WithEvents BrawlSplitter2 As BrawlSplitter
    Friend WithEvents BrawlSplitter3 As BrawlSplitter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
