Imports System.ComponentModel

Public Class BrawlSplitter
    Inherits Splitter
    Public Property Button() As Button
        Get
            Return m_Button
        End Get
        Private Set
            m_Button = Value
        End Set
    End Property
    Private m_Button As Button

    <Bindable(True), DefaultValue(GetType(Control), Nothing), Description("The control that the button in the splitter will show/hide")>
    Public Property ControlToHide() As Control
        Get
            Return m_ControlToHide
        End Get
        Set
            m_ControlToHide = Value
        End Set
    End Property
    Private m_ControlToHide As Control

    <Bindable(True), DefaultValue(GetType(Color), "ControlDark"), Description("The color of the seperator on either side of the button")>
    Public Property SeparatorColorDark() As Color
        Get
            Return m_SeparatorColorDark
        End Get
        Set
            m_SeparatorColorDark = Value
        End Set
    End Property
    Private m_SeparatorColorDark As Color

    <Bindable(True), DefaultValue(GetType(Color), "ControlLightLight"), Description("The color of the seperator on either side of the button")>
    Public Property SeparatorColorLight() As Color
        Get
            Return m_SeparatorColorLight
        End Get
        Set
            m_SeparatorColorLight = Value
        End Set
    End Property
    Private m_SeparatorColorLight As Color

    <Bindable(True), DefaultValue(0.5), Description("The maximum proportion (out of 1.0) of the length of the splitter taken up by the button")>
    Public Property MaxProportion() As Double
        Get
            Return m_MaxProportion
        End Get
        Set
            m_MaxProportion = Value
        End Set
    End Property
    Private m_MaxProportion As Double

    <Bindable(True), DefaultValue(64), Description("Tne length of the button. Ignored if Proportion is not null")>
    Public Property ButtonLength() As Integer
        Get
            Return m_ButtonLength
        End Get
        Set
            m_ButtonLength = Value
        End Set
    End Property
    Private m_ButtonLength As Integer

    Private OldCursor As Cursor

    <Bindable(True), DefaultValue(True), Description("Whether the splitter can be moved")>
    Public Property AllowResizing() As Boolean
        Get
            Return m_AllowResizing
        End Get
        Set
            m_AllowResizing = Value
        End Set
    End Property
    Private m_AllowResizing As Boolean

    Public Sub New()
        SeparatorColorDark = SystemColors.ControlDark
        SeparatorColorLight = SystemColors.ControlLightLight
        Height = 11
        MaxProportion = 0.5
        ButtonLength = 64
        AllowResizing = True

        Button = New Button
        Button.Cursor = Cursors.[Default]
        Button.FlatStyle = FlatStyle.Popup
        Me.Controls.Add(Button)

        AddHandler Me.MouseEnter, AddressOf BrawlSplitter_MouseEnter

        AddHandler Me.Resize, AddressOf BrawlSplitter_Resize
        AddHandler Me.Button.Click, AddressOf Button_Click
        AddHandler Me.Button.Paint, AddressOf Button_Paint

        AddHandler Me.VisibleChanged, AddressOf BrawlSplitter_Resize
    End Sub

    Private Sub BrawlSplitter_MouseEnter(sender As Object, e As EventArgs)
        If Not AllowResizing Then
            MinSize = Me.SplitPosition
            MinExtra = Me.Parent.Width - Me.SplitPosition
            OldCursor = Cursor
            Cursor = Cursors.[Default]
        ElseIf OldCursor IsNot Nothing Then
            Cursor = OldCursor
            OldCursor = Nothing
        End If
    End Sub

    Private Sub Button_Paint(sender As Object, e As PaintEventArgs)
        Dim brush As New SolidBrush(SystemColors.ControlText)
        If ControlToHide IsNot Nothing Then
            If Me.Width > Me.Height Then
                Dim top As Integer = (Button.Height / 2) - 2
                Dim bottom As Integer = (Button.Height / 2) + 2
                Dim left As Integer = (Button.Width / 2) - 4
                Dim right As Integer = (Button.Width / 2) + 4
                If ControlToHide.Visible Xor (Dock = DockStyle.Bottom OrElse Dock = DockStyle.Left) Then
                    e.Graphics.FillPolygon(brush, New Point() {New Point(Button.Width / 2, top), New Point(left, bottom), New Point(right, bottom)})
                Else
                    e.Graphics.FillPolygon(brush, New Point() {New Point(Button.Width / 2, bottom), New Point(left, top), New Point(right, top)})
                End If
            Else
                Dim top As Integer = (Button.Height / 2) - 4
                Dim bottom As Integer = (Button.Height / 2) + 4
                Dim left As Integer = (Button.Width / 2) - 2
                Dim right As Integer = (Button.Width / 2) + 2
                If ControlToHide.Visible Xor (Dock = DockStyle.Bottom OrElse Dock = DockStyle.Left) Then
                    e.Graphics.FillPolygon(brush, New Point() {New Point(right, Button.Height / 2), New Point(left, top), New Point(left, bottom)})
                Else
                    e.Graphics.FillPolygon(brush, New Point() {New Point(left, Button.Height / 2), New Point(right, top), New Point(right, bottom)})
                End If
            End If
        End If
    End Sub

    Private Sub BrawlSplitter_Resize(sender As Object, e As EventArgs)
        If Me.Width > Me.Height Then
            ' wide
            If Me.Width * MaxProportion < ButtonLength Then
                Button.Width = CInt(Me.Width * MaxProportion)
                Button.Height = Me.Height
                Button.Top = 0
                Button.Left = CInt(Me.Width * (1.0 - MaxProportion) / 2)
            Else
                Button.Width = ButtonLength
                Button.Height = Me.Height
                Button.Top = 0
                Button.Left = (Me.Width - ButtonLength) / 2
            End If
        ElseIf Me.Width < Me.Height Then
            ' tall
            If Me.Height * MaxProportion < ButtonLength Then
                Button.Width = Me.Width
                Button.Height = CInt(Me.Height * MaxProportion)
                Button.Top = CInt(Me.Height * (1.0 - MaxProportion) / 2)
                Button.Left = 0
            Else
                Button.Width = Me.Width
                Button.Height = ButtonLength
                Button.Top = (Me.Height - ButtonLength) / 2
                Button.Left = 0
            End If
        Else
            ' square
            Button.Width = Me.Width
            Button.Height = Me.Height
            Button.Top = 0
            Button.Left = 0
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        If ControlToHide IsNot Nothing Then
            ControlToHide.Visible = Not ControlToHide.Visible
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim pen As New Pen(Me.SeparatorColorDark, 1)
        Dim pen2 As New Pen(Me.SeparatorColorLight, 1)
        If Me.Width > Me.Height Then
            ' wide
            Dim middle As Integer = Me.Height / 2
            e.Graphics.DrawLine(pen, 0, middle, Me.Width, middle)
            e.Graphics.DrawLine(pen2, 0, middle - 1, Me.Width, middle - 1)
        ElseIf Me.Width < Me.Height Then
            ' tall
            Dim middle As Integer = Me.Width / 2
            e.Graphics.DrawLine(pen, middle, 0, middle, Me.Height)
            e.Graphics.DrawLine(pen2, middle - 1, 0, middle - 1, Me.Height)
        Else
            ' square - do nothing
        End If
    End Sub
End Class
