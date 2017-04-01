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
        Me.BrawlSplitter3 = New VisualArtNet.BrawlSplitter()
        Me.BrawlSplitter2 = New VisualArtNet.BrawlSplitter()
        Me.BrawlSplitter1 = New VisualArtNet.BrawlSplitter()
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
        Me.WebBrowserF.Location = New System.Drawing.Point(0, 259)
        Me.WebBrowserF.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserF.Name = "WebBrowserF"
        Me.WebBrowserF.Size = New System.Drawing.Size(300, 329)
        Me.WebBrowserF.TabIndex = 1
        '
        'WebBrowserW
        '
        Me.WebBrowserW.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebBrowserW.Location = New System.Drawing.Point(357, 259)
        Me.WebBrowserW.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserW.Name = "WebBrowserW"
        Me.WebBrowserW.Size = New System.Drawing.Size(300, 329)
        Me.WebBrowserW.TabIndex = 2
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(309, 259)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(39, 329)
        Me.WebBrowser1.TabIndex = 3
        '
        'BrawlSplitter3
        '
        Me.BrawlSplitter3.ControlToHide = Me.WebBrowserW
        Me.BrawlSplitter3.Dock = System.Windows.Forms.DockStyle.Right
        Me.BrawlSplitter3.Location = New System.Drawing.Point(348, 259)
        Me.BrawlSplitter3.Name = "BrawlSplitter3"
        Me.BrawlSplitter3.Size = New System.Drawing.Size(9, 329)
        Me.BrawlSplitter3.TabIndex = 6
        Me.BrawlSplitter3.TabStop = False
        '
        'BrawlSplitter2
        '
        Me.BrawlSplitter2.ControlToHide = Me.WebBrowserF
        Me.BrawlSplitter2.Location = New System.Drawing.Point(300, 259)
        Me.BrawlSplitter2.Name = "BrawlSplitter2"
        Me.BrawlSplitter2.Size = New System.Drawing.Size(9, 329)
        Me.BrawlSplitter2.TabIndex = 5
        Me.BrawlSplitter2.TabStop = False
        '
        'BrawlSplitter1
        '
        Me.BrawlSplitter1.ControlToHide = Me.WebBrowserD
        Me.BrawlSplitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BrawlSplitter1.Location = New System.Drawing.Point(0, 250)
        Me.BrawlSplitter1.Name = "BrawlSplitter1"
        Me.BrawlSplitter1.Size = New System.Drawing.Size(657, 9)
        Me.BrawlSplitter1.TabIndex = 4
        Me.BrawlSplitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 588)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.BrawlSplitter3)
        Me.Controls.Add(Me.WebBrowserW)
        Me.Controls.Add(Me.BrawlSplitter2)
        Me.Controls.Add(Me.WebBrowserF)
        Me.Controls.Add(Me.BrawlSplitter1)
        Me.Controls.Add(Me.WebBrowserD)
        Me.Name = "Form1"
        Me.Text = "Visual Art.NET"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserD As WebBrowser
    Friend WithEvents WebBrowserF As WebBrowser
    Friend WithEvents WebBrowserW As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BrawlSplitter1 As BrawlSplitter
    Friend WithEvents BrawlSplitter2 As BrawlSplitter
    Friend WithEvents BrawlSplitter3 As BrawlSplitter
End Class
